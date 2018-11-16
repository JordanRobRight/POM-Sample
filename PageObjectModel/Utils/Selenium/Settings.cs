using static System.Configuration.ConfigurationManager;

namespace PageObjectModel.Utils.Selenium
{
    public class Settings
    {
        public static string BaseUrl = AppSettings["BaseUrl"];
        public static string WelcomeMessage = AppSettings["WelcomeMessage"];
        public static string TestEmail = AppSettings["TestEmail"];
    }
}
