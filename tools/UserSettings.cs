using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Remotes_App_Translation_Project.Properties;

namespace Remotes_App_Translation_Project.tools
{
    class UserSettings
    {

        public static void LoadSettings()
        {
            TranslationsForm.DeveloperMail = Settings.Default.developerMail;
            TranslationsForm.Keywords = Settings.Default.developerMail;
        }

        public static void SaveSettings()
        {
            Settings.Default.Upgrade(); 
            Settings.Default.developerMail = TranslationsForm.DeveloperMail;
            Settings.Default.keywords = TranslationsForm.Keywords;
            Settings.Default.Save();
        }
    }
}
