using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace com.daudus.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[DefaultSettingValue("c:\\Users\\david.skarka\\Documents\\Priv\\MTU\\")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string ArchiImportDirectory
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ArchiImportDirectory"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("ArchiImportDirectory", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("elements.csv")]
	public string ArchiImportFileElements
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ArchiImportFileElements"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("ArchiImportFileElements", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("properties.csv")]
	[DebuggerNonUserCode]
	public string ArchiImportFileProperties
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ArchiImportFileProperties"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("ArchiImportFileProperties", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("relations.csv")]
	public string ArchiImportFileRelations
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ArchiImportFileRelations"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("ArchiImportFileRelations", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("csv")]
	public string ArchiImportFileFormat
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ArchiImportFileFormat"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("ArchiImportFileFormat", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("c:\\Users\\david.skarka\\Documents\\Priv\\MTU\\")]
	[UserScopedSetting]
	public string SparxEATargetRepostoryDirectory
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("SparxEATargetRepostoryDirectory"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("SparxEATargetRepostoryDirectory", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("MTU2.eap")]
	public string SparxEATargetRepostoryFile
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("SparxEATargetRepostoryFile"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("SparxEATargetRepostoryFile", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("eap")]
	[UserScopedSetting]
	public string SparxEATargetRepostoryFormat
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("SparxEATargetRepostoryFormat"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("SparxEATargetRepostoryFormat", (object)value);
		}
	}

	[DefaultSettingValue("importedFromArchi")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string SparxEATargetRepostoryPackageArchiImported
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("SparxEATargetRepostoryPackageArchiImported"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("SparxEATargetRepostoryPackageArchiImported", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("Global")]
	public string SparxEATargetRepostoryModelArchiImported
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("SparxEATargetRepostoryModelArchiImported"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("SparxEATargetRepostoryModelArchiImported", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("HuMaInn")]
	[UserScopedSetting]
	public string Author
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Author"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("Author", (object)value);
		}
	}
}
