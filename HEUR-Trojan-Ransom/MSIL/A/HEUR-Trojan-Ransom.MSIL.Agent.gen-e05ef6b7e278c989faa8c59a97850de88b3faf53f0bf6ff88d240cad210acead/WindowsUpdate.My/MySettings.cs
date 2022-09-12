using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace WindowsUpdate.My;

[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string NewHost
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("NewHost"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("NewHost", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int NewPort
	{
		get
		{
			return Conversions.ToInteger(((ApplicationSettingsBase)this).get_Item("NewPort"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("NewPort", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("False")]
	public bool TransferStatus
	{
		get
		{
			return Conversions.ToBoolean(((ApplicationSettingsBase)this).get_Item("TransferStatus"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("TransferStatus", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string ID
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("ID"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("ID", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string PW
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("PW"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("PW", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string Group
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("Group"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("Group", (object)value);
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
