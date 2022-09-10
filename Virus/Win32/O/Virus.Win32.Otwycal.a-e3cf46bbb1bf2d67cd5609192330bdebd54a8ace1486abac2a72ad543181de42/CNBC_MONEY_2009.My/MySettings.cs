using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using Microsoft.VisualBasic.CompilerServices;

namespace CNBC_MONEY_2009.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "8.0.0.0")]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

	public static MySettings Default => defaultInstance;

	[DefaultSettingValue("server=192.168.30.166;database=Finwizfinal;uid=sa;pwd=beesys")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string strCON
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("strCON"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("strCON", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("VERDANA")]
	public string FONT_DATA
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("FONT_DATA"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("FONT_DATA", (object)value);
		}
	}

	[DefaultSettingValue("10")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string FONT_SIZE
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("FONT_SIZE"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("FONT_SIZE", (object)value);
		}
	}

	[DefaultSettingValue("TV18")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string DOMAINNAME1
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("DOMAINNAME1"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("DOMAINNAME1", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("BOM")]
	public string DOMAINNAME2
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("DOMAINNAME2"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("DOMAINNAME2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("192.168.26.26")]
	[UserScopedSetting]
	public string LDAP_SERVER1
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("LDAP_SERVER1"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("LDAP_SERVER1", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("192.168.30.11")]
	[DebuggerNonUserCode]
	public string LDAP_SERVER2
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("LDAP_SERVER2"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("LDAP_SERVER2", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string USERNAME
	{
		get
		{
			return Conversions.ToString(((ApplicationSettingsBase)this).get_Item("USERNAME"));
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("USERNAME", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("Black")]
	[UserScopedSetting]
	public Color COLOR_CHANGE_E_ZERO
	{
		get
		{
			object obj = ((ApplicationSettingsBase)this).get_Item("COLOR_CHANGE_E_ZERO");
			Color color = default(Color);
			return (obj != null) ? ((Color)obj) : color;
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("COLOR_CHANGE_E_ZERO", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Green")]
	public Color COLOR_CHANGE_G_ZERO
	{
		get
		{
			object obj = ((ApplicationSettingsBase)this).get_Item("COLOR_CHANGE_G_ZERO");
			Color color = default(Color);
			return (obj != null) ? ((Color)obj) : color;
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("COLOR_CHANGE_G_ZERO", (object)value);
		}
	}

	[DefaultSettingValue("White")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public Color COLOR_BACKGROUND
	{
		get
		{
			object obj = ((ApplicationSettingsBase)this).get_Item("COLOR_BACKGROUND");
			Color color = default(Color);
			return (obj != null) ? ((Color)obj) : color;
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("COLOR_BACKGROUND", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("Red")]
	public Color COLOR_CHANGE_L_ZERO
	{
		get
		{
			object obj = ((ApplicationSettingsBase)this).get_Item("COLOR_CHANGE_L_ZERO");
			Color color = default(Color);
			return (obj != null) ? ((Color)obj) : color;
		}
		set
		{
			((ApplicationSettingsBase)this).set_Item("COLOR_CHANGE_L_ZERO", (object)value);
		}
	}

	[DebuggerNonUserCode]
	public MySettings()
	{
	}
}
