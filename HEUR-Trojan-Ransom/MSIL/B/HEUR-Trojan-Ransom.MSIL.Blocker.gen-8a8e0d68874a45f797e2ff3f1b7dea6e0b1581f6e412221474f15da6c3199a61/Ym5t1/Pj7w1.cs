using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using Microsoft.VisualBasic.CompilerServices;

namespace Ym5t1;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
internal sealed class Pj7w1 : ApplicationSettingsBase
{
	private static Pj7w1 defaultInstance = (Pj7w1)(object)SettingsBase.Synchronized((SettingsBase)(object)new Pj7w1());

	public static Pj7w1 Default
	{
		get
		{
			ApplicationSettingsBase val = (ApplicationSettingsBase)(object)defaultInstance;
			return (Pj7w1)(object)val;
		}
	}

	[DefaultSettingValue("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database1.mdf;Integrated Security=True")]
	[ApplicationScopedSetting]
	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	public string Database1ConnectionString
	{
		get
		{
			IComparable comparable = Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database1ConnectionString"));
			return comparable as string;
		}
	}

	[SpecialSetting(/*Could not decode attribute arguments.*/)]
	[ApplicationScopedSetting]
	[DefaultSettingValue("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database2.mdf;Integrated Security=True")]
	public string Database2ConnectionString
	{
		get
		{
			IComparable<string> comparable = Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Database2ConnectionString"));
			return (string)comparable;
		}
	}
}
