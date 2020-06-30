using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ScintillaNET;

namespace MapLibrary
{
    public class MapLexer
    {
        public static int StyleDefault { get; } = 0;
        public static int StyleKeyword { get; } = 1;
        public static int StyleIdentifier { get; } = 2;
        public static int StyleNumber { get; } = 3;
        public static int StyleString { get; } = 4;

        private const int STATE_UNKNOWN = 0;
        private const int STATE_IDENTIFIER = 1;
        private const int STATE_NUMBER = 2;
        private const int STATE_STRING = 3;

        private readonly HashSet<string> keywords;

        public MapLexer(string keywords)
        {
            // Put keywords in a HashSet
            var list = Regex.Split(keywords ?? string.Empty, @"\s+").Where(l => !string.IsNullOrEmpty(l));
            this.keywords = new HashSet<string>(list);
        }

        public void Style(Scintilla scintilla, int startPos, int endPos)
        {
            // Back up to the line start
            var line = scintilla.LineFromPosition(startPos);
            startPos = scintilla.Lines[line].Position;

            var length = 0;
            var state = STATE_UNKNOWN;

            // Start styling
            scintilla.StartStyling(startPos);
            while (startPos < endPos)
            {
                var c = (char) scintilla.GetCharAt(startPos);

                REPROCESS:
                switch (state)
                {
                    case STATE_UNKNOWN:
                        if (c == '"')
                        {
                            // Start of "string"
                            scintilla.SetStyling(1, StyleString);
                            state = STATE_STRING;
                        }
                        else if (char.IsDigit(c))
                        {
                            state = STATE_NUMBER;
                            goto REPROCESS;
                        }
                        else if (char.IsLetter(c))
                        {
                            state = STATE_IDENTIFIER;
                            goto REPROCESS;
                        }
                        else
                        {
                            // Everything else
                            scintilla.SetStyling(1, StyleDefault);
                        }

                        break;

                    case STATE_STRING:
                        if (c == '"')
                        {
                            length++;
                            scintilla.SetStyling(length, StyleString);
                            length = 0;
                            state = STATE_UNKNOWN;
                        }
                        else
                        {
                            length++;
                        }

                        break;

                    case STATE_NUMBER:
                        if (char.IsDigit(c) || c >= 'a' && c <= 'f' || c >= 'A' && c <= 'F' || c == 'x')
                        {
                            length++;
                        }
                        else
                        {
                            scintilla.SetStyling(length, StyleNumber);
                            length = 0;
                            state = STATE_UNKNOWN;
                            goto REPROCESS;
                        }

                        break;

                    case STATE_IDENTIFIER:
                        if (char.IsLetterOrDigit(c))
                        {
                            length++;
                        }
                        else
                        {
                            var style = StyleIdentifier;
                            var identifier = scintilla.GetTextRange(startPos - length, length);
                            if (keywords.Contains(identifier))
                                style = StyleKeyword;

                            scintilla.SetStyling(length, style);
                            length = 0;
                            state = STATE_UNKNOWN;
                            goto REPROCESS;
                        }

                        break;
                }

                startPos++;
            }
        }
    }
}