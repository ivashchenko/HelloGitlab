using HelloGitlab.Debugging;

namespace HelloGitlab
{
    public class HelloGitlabConsts
    {
        public const string LocalizationSourceName = "HelloGitlab";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "921cb87ab6d14b24892c52460bb03afb";
    }
}
