using System;
using System.Collections.Generic;
using System.IO;
using System.Web.Script.Serialization;
using Gherkin.Ast;

namespace Gherkin;

public class GherkinDialectProvider : IGherkinDialectProvider
{
	protected class GherkinLanguageSetting
	{
		public string name;

		public string native;

		public string[] feature;

		public string[] background;

		public string[] scenario;

		public string[] scenarioOutline;

		public string[] examples;

		public string[] given;

		public string[] when;

		public string[] then;

		public string[] and;

		public string[] but;
	}

	private readonly Lazy<GherkinDialect> defaultDialect;

	public GherkinDialect DefaultDialect => defaultDialect.Value;

	public GherkinDialectProvider(string defaultLanguage = "en")
	{
		GherkinDialectProvider gherkinDialectProvider = this;
		defaultDialect = new Lazy<GherkinDialect>(() => gherkinDialectProvider.GetDialect(defaultLanguage, null));
	}

	public virtual GherkinDialect GetDialect(string language, Location location)
	{
		Dictionary<string, GherkinLanguageSetting> gherkinLanguageSettings = LoadLanguageSettings();
		return GetDialect(language, gherkinLanguageSettings, location);
	}

	protected virtual Dictionary<string, GherkinLanguageSetting> LoadLanguageSettings()
	{
		Stream manifestResourceStream = typeof(GherkinDialectProvider).Assembly.GetManifestResourceStream(typeof(GherkinDialectProvider), "gherkin-languages.json");
		if (manifestResourceStream == null)
		{
			throw new InvalidOperationException("Gherkin language resource not found: gherkin-languages.json");
		}
		string languagesFileContent = new StreamReader(manifestResourceStream).ReadToEnd();
		return ParseJsonContent(languagesFileContent);
	}

	protected Dictionary<string, GherkinLanguageSetting> ParseJsonContent(string languagesFileContent)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		JavaScriptSerializer val = new JavaScriptSerializer();
		return val.Deserialize<Dictionary<string, GherkinLanguageSetting>>(languagesFileContent);
	}

	protected virtual GherkinDialect GetDialect(string language, Dictionary<string, GherkinLanguageSetting> gherkinLanguageSettings, Location location)
	{
		if (!gherkinLanguageSettings.TryGetValue(language, out var value))
		{
			throw new NoSuchLanguageException(language, location);
		}
		return CreateGherkinDialect(language, value);
	}

	protected GherkinDialect CreateGherkinDialect(string language, GherkinLanguageSetting languageSettings)
	{
		return new GherkinDialect(language, ParseTitleKeywords(languageSettings.feature), ParseTitleKeywords(languageSettings.background), ParseTitleKeywords(languageSettings.scenario), ParseTitleKeywords(languageSettings.scenarioOutline), ParseTitleKeywords(languageSettings.examples), ParseStepKeywords(languageSettings.given), ParseStepKeywords(languageSettings.when), ParseStepKeywords(languageSettings.then), ParseStepKeywords(languageSettings.and), ParseStepKeywords(languageSettings.but));
	}

	private string[] ParseStepKeywords(string[] stepKeywords)
	{
		return stepKeywords;
	}

	private string[] ParseTitleKeywords(string[] keywords)
	{
		return keywords;
	}

	protected static GherkinDialect GetFactoryDefault()
	{
		return new GherkinDialect("en", new string[1] { "Feature" }, new string[1] { "Background" }, new string[1] { "Scenario" }, new string[2] { "Scenario Outline", "Scenario Template" }, new string[2] { "Examples", "Scenarios" }, new string[2] { "* ", "Given " }, new string[2] { "* ", "When " }, new string[2] { "* ", "Then " }, new string[2] { "* ", "And " }, new string[2] { "* ", "But " });
	}
}
