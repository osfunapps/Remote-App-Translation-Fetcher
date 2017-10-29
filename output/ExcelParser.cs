using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Codaxy.Xlio;

namespace Remotes_App_Translation_Project.output
{
    class ExcelParser
    {
        private string outputOutputAppName, appSummary, appDescription;

        public void LoadExcelFile(string translationPath)
        {
            Workbook workbook = Workbook.Load(translationPath);
            Sheet sheet = workbook.Sheets[0];
            int rows = workbook.Sheets[0].Data.Rows.Count;
            appDescription = (string)sheet[rows, 2].Value;
            outputOutputAppName = (string) sheet[3, 2].Value;
            appSummary = (string) sheet[4, 2].Value;
        }


        public string FetchAppSummary()
        {
            return appDescription.Substring(0, appDescription.IndexOf("\n"));
        }

        internal string FetchAppDescription(string userEmail, string userKeywords, string userAppName)
        {

            //find all two or more ___ signs with regexp. Delete them and replace them with the app name.
            //check the issue with the hindi language in the rich text box

            string modifiedDescription = Regex.Replace(appDescription,"_x000D_", "");
            modifiedDescription = modifiedDescription.Replace(" contact us on _____", "contact us on " + userEmail);

            modifiedDescription = Regex.Replace(modifiedDescription, OutputHandler.PLACE_HOLDER_APP_NAME,  userAppName);
            //modifiedDescription = modifiedDescription.Replace("____", userAppName);
            modifiedDescription += "\n" + userKeywords;
            modifiedDescription = modifiedDescription.Replace("\n", "\r\n");
            return modifiedDescription;
        }

        public string OutputOutputAppName
        {
            get => outputOutputAppName;
            set => outputOutputAppName = value;
        }

        public string AppSummary
        {
            get => appSummary;
            set => appSummary = value;
        }
    }


}
