using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Remotes_App_Translation_Project.tools;

namespace Remotes_App_Translation_Project
{
    public partial class TranslationsForm : Form
    {
        private HintsCreator hintsCreator;
        private static string developerMail, keywords;

        //finals
        private string DEFAULT_LANGUAGE = "English";

        private Dictionary<string, string> languagesDict;


        public TranslationsForm()
        {
            InitializeComponent();
            SetHints();
            LoadPreviousParams();
            FillTranslationsCB();
        }

        private void FillTranslationsCB()
        {
            FilesExlorerManager filesMgr = new FilesExlorerManager();
            languagesDict = filesMgr.ExtractFilesNamesList();
            string[] languagesNames = languagesDict.Keys.ToArray();
            Array.Sort(languagesNames);
            foreach (var language in languagesNames)
                languagesCB.Items.Add(language);
            languagesCB.Text = DEFAULT_LANGUAGE;
        }

        private void LoadPreviousParams()
        {
            if (!developerMail.Equals("")) { 
                developerMailTB.Text = developerMail;
                developerMailTB.ForeColor = Color.Black;
            }
            if (!Keywords.Equals("")) { 
            keywordsTB.Text = Keywords;
                keywordsTB.ForeColor = Color.Black;
            }
        }

        internal void OnTBHintLeave(object sender, EventArgs e)
        {
            if (((TextBox)sender).Text.Length == 0)
            {
                ((TextBox)sender).Text = ((TextBox)sender).Tag.ToString();
                ((TextBox)sender).ForeColor = SystemColors.GrayText;
            }
        }


        private void goBtn_Click(object sender, EventArgs e)
        {
            SaveParams();
            EnableFields(true);
            PrepareOutput();
        }

        private void PrepareOutput()
        {
            OutputHandler outputHandler = new OutputHandler(languagesDict[languagesCB.Text]);
            outputHandler.SetInputParams(appNameTB.Text, developerMailTB.Text, keywordsTB.Text);
            outputHandler.SetOutputParams(appNameOutputTB, summaryOutputTB, appDescriptionOutputRTB);
            outputHandler.FetchData();
        }

        private void SaveParams()
        {
            developerMail = developerMailTB.Text;
            keywords = keywordsTB.Text;
            UserSettings.SaveSettings();
        }

        private void EnableFields(bool enable)
        {
            appDescriptionOutputRTB.Enabled = enable;
            appNameOutputTB.Enabled = enable;
            summaryOutputTB.Enabled = enable;
        }


        public static string DeveloperMail
        {
            get => developerMail;
            set => developerMail = value;
        }

        public static string Keywords
        {
            get => keywords;
            set => keywords = value;
        }

        private void languagesCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(appNameTB.Text.Equals("") || developerMailTB.Text.Equals(""))return;
            goBtn_Click(null, null);
        }

        private void SetHints()
        {
            hintsCreator = new HintsCreator();
            keywordsTB.Leave += new System.EventHandler(hintsCreator.OnRTBHint_Leave);
            keywordsTB.Enter += new System.EventHandler(hintsCreator.OnRTBHint_Enter);
            developerMailTB.Leave += new System.EventHandler(hintsCreator.OnTBHint_Leave);
            developerMailTB.Enter += new System.EventHandler(hintsCreator.OnTBHint_Enter);
            appNameTB.Leave += new System.EventHandler(hintsCreator.OnTBHint_Leave);
            appNameTB.Enter += new System.EventHandler(hintsCreator.OnTBHint_Enter);
            hintsCreator.OnRTBHint_Leave(keywordsTB, null);
            hintsCreator.OnTBHint_Leave(developerMailTB, null);
            hintsCreator.OnTBHint_Leave(appNameTB, null);
        }

    }


}
