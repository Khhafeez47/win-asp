using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace win-asp-core-iis.Localization
{
    public static class win-asp-core-iisLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(win-asp-core-iisConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(win-asp-core-iisLocalizationConfigurer).GetAssembly(),
                        "win-asp-core-iis.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
