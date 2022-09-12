using System.Configuration;

namespace Examine.Config;

public class ExamineSettings : ConfigurationSection
{
	private const string SectionName = "Examine";

	private static readonly ExamineSettings Examine;

	public static ExamineSettings Instance => Examine;

	[ConfigurationProperty("RebuildOnAppStart", DefaultValue = true)]
	public bool RebuildOnAppStart => (bool)((ConfigurationElement)this).get_Item("RebuildOnAppStart");

	[ConfigurationProperty("ExamineSearchProviders")]
	public SearchProvidersSection SearchProviders => (SearchProvidersSection)((ConfigurationElement)this).get_Item("ExamineSearchProviders");

	[ConfigurationProperty("ExamineIndexProviders")]
	public IndexProvidersSection IndexProviders => (IndexProvidersSection)((ConfigurationElement)this).get_Item("ExamineIndexProviders");

	private ExamineSettings()
	{
	}

	static ExamineSettings()
	{
		Examine = ConfigurationManager.GetSection("Examine") as ExamineSettings;
	}
}
