using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace Flying_Cow_TMS.Localization
{
    public static class Flying_Cow_TMSLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(Flying_Cow_TMSConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(Flying_Cow_TMSLocalizationConfigurer).GetAssembly(),
                        "Flying_Cow_TMS.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
