using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Remotes_App_Translation_Project.output;

namespace Remotes_App_Translation_Project
{
    internal class OutputHandler
    {
        private TextBox appNameOutputCB;
        private TextBox summaryOutputCB;
        private TextBox appDescriptionOutputRTB;
        private string translationPath;
        private string userAppName, userEmail, userKeywords;
        private string appNamePrefix = "Remote for ";
        private string APP_NAME_SUFFIX = " - NOW FREE";
        private string AC_NAME_PREFIX = "AC ";
        public static string PLACE_HOLDER_APP_NAME = "(__+)";
        

        public OutputHandler(string translationPath)
        {
            this.translationPath = translationPath;
        }

        public void SetOutputParams(TextBox appNameOutputTB, TextBox summaryOutputTB, TextBox appDescriptionOutputRTB)
        {
            this.appNameOutputCB = appNameOutputTB;
            this.summaryOutputCB = summaryOutputTB;
            this.appDescriptionOutputRTB = appDescriptionOutputRTB;
        }

        public void SetInputParams(bool acRemote, string userAppName, string userEmail, string userKeywords)
        {
            if (acRemote)
                appNamePrefix = AC_NAME_PREFIX + appNamePrefix;
            this.userAppName = userAppName;
            this.userEmail = userEmail;
            this.userKeywords = userKeywords;
        }

        public void FetchData()
        {
            ExcelParser excelParser = new ExcelParser();
            excelParser.LoadExcelFile(translationPath);
            //appNameOutputCB.Text = excelParser.OutputOutputAppName.Replace("____", userAppName);
            appNameOutputCB.Text = Regex.Replace(excelParser.OutputOutputAppName, PLACE_HOLDER_APP_NAME, userAppName);
            summaryOutputCB.Text = appNameOutputCB.Text;
            summaryOutputCB.AppendText(Environment.NewLine);
            summaryOutputCB.AppendText(excelParser.AppSummary);
            appDescriptionOutputRTB.Text = excelParser.FetchAppDescription(userEmail, userKeywords, userAppName);
        }
    }
}