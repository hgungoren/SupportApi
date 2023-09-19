using SK.Support.Debugging;

namespace SK.Support
{
    public class SupportConsts
    {
        public const string LocalizationSourceName = "Support";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "06fbcf9e1cae43bdac2637349d7e807d";
    }
}
