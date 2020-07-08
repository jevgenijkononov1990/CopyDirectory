using CopyDirectory.Libs.Models;
using System;
using System.Collections.Generic;
using System.IO;

namespace CopyDirectory.Libs.Services
{
    public class CopyService : ICopyService
    {
        private static string InputValidatinoError = "input validation error";
        private static string UnhandledError = "Unhandled exception occured";

        public CopyService()
        {

        }

        public (bool succes, string error) Copy(CopySettings copySettings)
        {
            if(copySettings == null)
            {
                //log
                return (false, InputValidatinoError);
            }

            if(string.IsNullOrWhiteSpace(copySettings.Source) 
                || string.IsNullOrWhiteSpace(copySettings.Target)
                ||!Enum.IsDefined( typeof(CopySettings),copySettings.Item))
            {
                //log
                return (false, InputValidatinoError);
            }
            try
            {
                switch (copySettings.Item)
                {
                    case CopyItem.FILE:
                        return CopyOnlyFile(copySettings.Source, copySettings.Target);
                    case CopyItem.FOLDER:
                        return CopyDirectory(copySettings.Source, copySettings.Target);
                    default:
                        throw new NotImplementedException();
                }
            }
            catch (Exception ex)
            {
                //log
                Console.WriteLine(ex.Message);
                return (false, UnhandledError);
            }
        }

        public (bool succes, string error) Copy(string source, string target, CopyItem Item)
        {
            return Copy(new CopySettings
            {
                Item = Item,
                Source = source,
                Target = target
            });
        }

        public (bool success, string error) CopyDirectory(string source, string target)
        {
            if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(target))
            {
                //log
                return (false, InputValidatinoError);
            }

            try
                {
                var stack = new Stack<Folders>();

                while (stack.Count > 0)
                {
                    var folders = stack.Pop();
                    Directory.CreateDirectory(folders.Target);
                    foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                    {
                        File.Copy(file, Path.Combine(folders.Target, Path.GetFileName(file)));
                    }

                    foreach (var folder in Directory.GetDirectories(folders.Source))
                    {
                        stack.Push(new Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
                    }
                }
                return (true,null);
            }
            catch (Exception ex)
            {
                //log
                Console.WriteLine(ex.Message);   
                return (false, UnhandledError);
            }
        }

        public (bool succes, string error) CopyOnlyFile(string source, string target)
        {
            if (string.IsNullOrWhiteSpace(source) || string.IsNullOrWhiteSpace(target))
            {
                //log
                return (false, "input validation error");
            }

            try
            {
                File.Copy(source, target, true);
                return (true, "input validation error");
            }
            catch (IOException iox)
            {
                //log
                Console.WriteLine(iox.Message);
                return (false, iox.Message);
            }
        }
    }
}