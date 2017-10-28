using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Codaxy.Xlio;

namespace Remotes_App_Translation_Project.output
{
    class ExcelParser
    {
        private string appDescription;

        public void LoadExcelFile(string translationPath)
        {
            Workbook workbook = Workbook.Load(translationPath);
            Sheet sheet = workbook.Sheets[0];
            int rows = sheet.Data.Rows.Count;
            appDescription = (string) sheet[rows, 1].Value;
        }


        public string FetchAppSummary()
        {
            return appDescription.Substring(0, appDescription.IndexOf("\n"));
        }

        internal string FetchAppDescription(string userEmail, string userKeywords, string appName)
        {
            string modifiedDescription = string.Copy(appDescription);

            modifiedDescription.Replace("contact us on _____", "contact us on " + userEmail);
            modifiedDescription.Replace("____", appName);
            modifiedDescription += "\n" + userKeywords;
            return modifiedDescription;
        }
    }
}
