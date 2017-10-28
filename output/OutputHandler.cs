using System;
using System.Windows.Forms;
using Remotes_App_Translation_Project.output;

namespace Remotes_App_Translation_Project
{
    internal class OutputHandler
    {
        private TextBox appNameOutputCB;
        private TextBox summaryOutputCB;
        private RichTextBox appDescriptionOutputRTB;
        private string translationPath;
        private string userAppName, userEmail, userKeywords;
        private string APP_NAME_PREFIX = "Remote for ";
        private string APP_NAME_SUFFIX = " - NOW FREE";

        public OutputHandler(string translationPath)
        {
            this.translationPath = translationPath;
        }

        public void SetOutputParams(TextBox appNameOutputTB, TextBox summaryOutputTB, RichTextBox appDescriptionOutputRTB)
        {
            this.appNameOutputCB = appNameOutputTB;
            this.summaryOutputCB = summaryOutputTB;
            this.appDescriptionOutputRTB = appDescriptionOutputRTB;
        }

        public void SetInputParams(string userAppName, string userEmail, string userKeywords)
        {
            this.userAppName = userAppName;
            this.userEmail = userEmail;
            this.userKeywords = userKeywords;
        }

        public void FetchData()
        {
            ExcelParser excelParser = new ExcelParser();
            excelParser.LoadExcelFile(translationPath);
            appNameOutputCB.Text = APP_NAME_PREFIX + userAppName + APP_NAME_SUFFIX;
            summaryOutputCB.Text = appNameOutputCB.Text;
            summaryOutputCB.AppendText(Environment.NewLine);
            summaryOutputCB.AppendText(excelParser.FetchAppSummary());
            appDescriptionOutputRTB.Text = excelParser.FetchAppDescription(userEmail, userKeywords, userAppName);
        }
    }
}