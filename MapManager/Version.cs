﻿using System.IO;
using System.Reflection;

namespace MapManager
{
    public static class Version
    {
        /// <summary>
        ///     Accessor for the AssemblyTitle attribute.
        /// </summary>
        public static string AssemblyTitle
        {
            get
            {
                // Get all Title attributes on this assembly
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                // If there is at least one Title attribute
                if (attributes.Length > 0)
                {
                    // Select the first one
                    var titleAttribute = (AssemblyTitleAttribute) attributes[0];
                    // If it is not an empty string, return it
                    if (titleAttribute.Title != "")
                        return titleAttribute.Title;
                }

                // If there was no Title attribute, or if the Title attribute was the empty string, return the .exe name
                return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        /// <summary>
        ///     Accessor for the AssemblyVersion attribute.
        /// </summary>
        public static string AssemblyVersion => Assembly.GetExecutingAssembly().GetName().Version.ToString();

        /// <summary>
        ///     Accessor for the AssemblyDescription attribute.
        /// </summary>
        public static string AssemblyDescription
        {
            get
            {
                // Get all Description attributes on this assembly
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                // If there aren't any Description attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Description attribute, return its value
                return ((AssemblyDescriptionAttribute) attributes[0]).Description;
            }
        }

        /// <summary>
        ///     Accessor for the AssemblyProduct attribute.
        /// </summary>
        public static string AssemblyProduct
        {
            get
            {
                // Get all Product attributes on this assembly
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                // If there aren't any Product attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Product attribute, return its value
                return ((AssemblyProductAttribute) attributes[0]).Product;
            }
        }

        /// <summary>
        ///     Accessor for the AssemblyCopyright attribute.
        /// </summary>
        public static string AssemblyCopyright
        {
            get
            {
                // Get all Copyright attributes on this assembly
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                // If there aren't any Copyright attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Copyright attribute, return its value
                return ((AssemblyCopyrightAttribute) attributes[0]).Copyright;
            }
        }

        /// <summary>
        ///     Accessor for the AssemblyCompany attribute.
        /// </summary>
        public static string AssemblyCompany
        {
            get
            {
                // Get all Company attributes on this assembly
                var attributes = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                // If there aren't any Company attributes, return an empty string
                if (attributes.Length == 0)
                    return "";
                // If there is a Company attribute, return its value
                return ((AssemblyCompanyAttribute) attributes[0]).Company;
            }
        }
    }
}