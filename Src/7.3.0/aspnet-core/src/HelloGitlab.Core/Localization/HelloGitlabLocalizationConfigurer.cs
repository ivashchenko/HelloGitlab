using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace HelloGitlab.Localization
{
    public static class HelloGitlabLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(HelloGitlabConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(HelloGitlabLocalizationConfigurer).GetAssembly(),
                        "HelloGitlab.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
