using ThinkAM.Sites.Debugging;

namespace ThinkAM.Sites
{
    public class SitesConsts
    {
        public const string LocalizationSourceName = "Sites";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e9ae400f9ca84f72b3ef4b7c03518116";
    }
}
