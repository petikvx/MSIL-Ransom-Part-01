using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace svchost.My;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
[EditorBrowsable(EditorBrowsableState.Advanced)]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
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

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
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

	[DebuggerNonUserCode]
	[UserScopedSetting]
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

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
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

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
