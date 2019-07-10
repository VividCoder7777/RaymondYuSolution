using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace RaymondYuSolution.Localization
{
    public static class RaymondYuSolutionLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(RaymondYuSolutionConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(RaymondYuSolutionLocalizationConfigurer).GetAssembly(),
                        "RaymondYuSolution.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
