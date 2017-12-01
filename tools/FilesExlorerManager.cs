using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Remotes_App_Translation_Project
{
    internal class FilesExlorerManager
    {
        private string FOLDER_TRASNLATIONS = "Translations";
        private string FOLDER_AC_TRASNLATIONS = "ac translations";

        public Dictionary<string, string> ExtractFilesNamesList(bool acRemote)
        {
            string currentFolder = System.IO.Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            string translationsFolder;

            if (acRemote)
            translationsFolder = currentFolder.Substring(0, currentFolder.IndexOf("bin"))+FOLDER_AC_TRASNLATIONS;
            else
                translationsFolder = currentFolder.Substring(0, currentFolder.IndexOf("bin")) + FOLDER_TRASNLATIONS;

            Dictionary<string, string> languagesDict = new Dictionary<string, string>();
            string[] files = Directory.GetFiles(translationsFolder);

            foreach (var languageFilePath in files)
            {
                int startIdx = languageFilePath.LastIndexOf("\\") + 1;
                int endIdx = languageFilePath.LastIndexOf(".");
                int length = endIdx - startIdx;
                string languageFileName = languageFilePath.Substring(startIdx, length);
                languagesDict.Add(languageFileName, languageFilePath);
            }
            return languagesDict;
        }
    }
}