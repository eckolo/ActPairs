using System;
using System.Linq;
using System.Xml.Linq;
using UnityEditor;

namespace Assets.Editor
{
    public class EnableNullable : AssetPostprocessor
    {
        private static string OnGeneratedCSProject(string path, string content)
        {
            var document = XDocument.Parse(content);
            if(document.Root == null)
                throw new Exception($"document.Root == null");

            XNamespace xNamespace = "http://schemas.microsoft.com/developer/msbuild/2003";

            // ReSharper disable once PossibleNullReferenceException
            var propertyGroup = document
                .Element(xNamespace + "Project")
                .Elements(xNamespace + "PropertyGroup")
                .First();
            propertyGroup.Add(new XElement(xNamespace + "Nullable", "enable"));
            return document.ToString();
        }
    }
}
