﻿using System;
using System.IO;
using System.Reflection;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetOffice.DeveloperToolbox.Ressources
{
    internal static class RessourceUtils
    {
        private static Dictionary<string, string> _cache = new Dictionary<string, string>();

        internal static Image ReadImageFromRessource(string ressourcePath)
        {
            System.IO.Stream ressourceStream = null;
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            ressourcePath = assemblyName + "." + ressourcePath;
            ressourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(ressourcePath);
            if (ressourceStream == null)
                throw (new System.IO.IOException("Error accessing resource Stream."));
            Bitmap newIcon = new Bitmap(ressourceStream);
            return newIcon;
        }

        internal static Image ReadIconImageFromRessource(string ressourcePath)
        {
            System.IO.Stream ressourceStream = null;
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            ressourcePath = assemblyName + "." + ressourcePath;
            ressourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(ressourcePath);
            if (ressourceStream == null)
                throw (new System.IO.IOException("Error accessing resource Stream."));
            Bitmap newIcon = new Icon(ressourceStream).ToBitmap();
            return newIcon;
        }

        internal static Stream ReadStream(string ressourcePath)
        {
            Assembly ass = Assembly.GetExecutingAssembly();
            string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            System.IO.Stream ressourceStream = ass.GetManifestResourceStream(assemblyName + "." + ressourcePath);
            if (ressourceStream == null)
                throw (new System.IO.IOException("Error accessing resource Stream."));
            ressourceStream.Seek(0, SeekOrigin.Begin);
            return ressourceStream;
        }

        internal static Stream CreateStreamFromString(string stringValue)
        {
            MemoryStream stream = new MemoryStream();
            StreamWriter writer = new StreamWriter(stream);
            writer.Write(stringValue);
            writer.Flush();
            stream.Position = 0;
            return stream;
        }

        internal static string ReadString(string ressourcePath, bool autoPrevRootNameSpace = true, bool throwExceptionIfNotFound = true)
        {
            string s = null;
            if (_cache.TryGetValue(ressourcePath, out s))
                return s;

            System.IO.Stream ressourceStream = null;
            System.IO.StreamReader textStreamReader = null;
            try
            {
                string assemblyName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
                if(true == autoPrevRootNameSpace)
                    ressourcePath = assemblyName + "." + ressourcePath;
                ressourceStream = System.Reflection.Assembly.GetExecutingAssembly().GetManifestResourceStream(ressourcePath);
                if (ressourceStream == null)
                {
                    if (throwExceptionIfNotFound)
                        throw (new System.IO.IOException("Error accessing resource Stream."));
                    else
                    {
                        Console.WriteLine("Error accessin resource Stream {0}", ressourcePath);
                        return null;
                    }
                }

                textStreamReader = new System.IO.StreamReader(ressourceStream);
                if (textStreamReader == null)
                    throw (new System.IO.IOException("Error accessing resource File."));

                string text = textStreamReader.ReadToEnd();
                if(!_cache.ContainsKey(ressourcePath))
                    _cache.Add(ressourcePath, text);
                return text;
            }
            catch (Exception exception)
            {
                throw (exception);
            }
            finally
            {
                if (null != textStreamReader)
                    textStreamReader.Close();
                if (null != ressourceStream)
                    ressourceStream.Close();
            }
        }
    }
}
