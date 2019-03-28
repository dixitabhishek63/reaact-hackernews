using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Shertech001.Localization
{
    public static class Shertech001LocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Shertech001Consts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Shertech001LocalizationConfigurer).GetAssembly(),
                        "Shertech001.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
