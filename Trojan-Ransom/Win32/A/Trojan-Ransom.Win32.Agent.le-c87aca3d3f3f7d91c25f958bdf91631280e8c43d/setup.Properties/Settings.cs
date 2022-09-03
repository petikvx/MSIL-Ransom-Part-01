using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace setup.Properties;

[CompilerGenerated]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0")]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance = (Settings)(object)SettingsBase.Synchronized((SettingsBase)(object)new Settings());

	public static Settings Default => defaultInstance;

	[UserScopedSetting]
	[DefaultSettingValue("http://warezer.net/")]
	[DebuggerNonUserCode]
	public string url
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("url");
		}
		set
		{
			((SettingsBase)this).set_Item("url", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string uid
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("uid");
		}
		set
		{
			((SettingsBase)this).set_Item("uid", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string image
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("image");
		}
		set
		{
			((SettingsBase)this).set_Item("image", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string filepath
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("filepath");
		}
		set
		{
			((SettingsBase)this).set_Item("filepath", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("ss.php")]
	public string post_ss
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("post_ss");
		}
		set
		{
			((SettingsBase)this).set_Item("post_ss", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string fn
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("fn");
		}
		set
		{
			((SettingsBase)this).set_Item("fn", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string it
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("it");
		}
		set
		{
			((SettingsBase)this).set_Item("it", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string ih
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ih");
		}
		set
		{
			((SettingsBase)this).set_Item("ih", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string type
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("type");
		}
		set
		{
			((SettingsBase)this).set_Item("type", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string UserName
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("UserName");
		}
		set
		{
			((SettingsBase)this).set_Item("UserName", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string UserDomainName
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("UserDomainName");
		}
		set
		{
			((SettingsBase)this).set_Item("UserDomainName", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string MachineName
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("MachineName");
		}
		set
		{
			((SettingsBase)this).set_Item("MachineName", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string OSVersion
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("OSVersion");
		}
		set
		{
			((SettingsBase)this).set_Item("OSVersion", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string TickCount
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("TickCount");
		}
		set
		{
			((SettingsBase)this).set_Item("TickCount", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string WorkingSet
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("WorkingSet");
		}
		set
		{
			((SettingsBase)this).set_Item("WorkingSet", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string CurrentDirectory
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("CurrentDirectory");
		}
		set
		{
			((SettingsBase)this).set_Item("CurrentDirectory", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string IP
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("IP");
		}
		set
		{
			((SettingsBase)this).set_Item("IP", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string HOST
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("HOST");
		}
		set
		{
			((SettingsBase)this).set_Item("HOST", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string Screen
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Screen");
		}
		set
		{
			((SettingsBase)this).set_Item("Screen", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string Clip
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("Clip");
		}
		set
		{
			((SettingsBase)this).set_Item("Clip", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string it_dir
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("it_dir");
		}
		set
		{
			((SettingsBase)this).set_Item("it_dir", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string ih_dir
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("ih_dir");
		}
		set
		{
			((SettingsBase)this).set_Item("ih_dir", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string f1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("f1");
		}
		set
		{
			((SettingsBase)this).set_Item("f1", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string f2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("f2");
		}
		set
		{
			((SettingsBase)this).set_Item("f2", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string sei
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("sei");
		}
		set
		{
			((SettingsBase)this).set_Item("sei", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string mei
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("mei");
		}
		set
		{
			((SettingsBase)this).set_Item("mei", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string email
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("email");
		}
		set
		{
			((SettingsBase)this).set_Item("email", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string password
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("password");
		}
		set
		{
			((SettingsBase)this).set_Item("password", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string question
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("question");
		}
		set
		{
			((SettingsBase)this).set_Item("question", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string answer
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("answer");
		}
		set
		{
			((SettingsBase)this).set_Item("answer", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string sex
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("sex");
		}
		set
		{
			((SettingsBase)this).set_Item("sex", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string birth
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("birth");
		}
		set
		{
			((SettingsBase)this).set_Item("birth", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string zip
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("zip");
		}
		set
		{
			((SettingsBase)this).set_Item("zip", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string pref
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("pref");
		}
		set
		{
			((SettingsBase)this).set_Item("pref", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string addr1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("addr1");
		}
		set
		{
			((SettingsBase)this).set_Item("addr1", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string addr2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("addr2");
		}
		set
		{
			((SettingsBase)this).set_Item("addr2", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string tel
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("tel");
		}
		set
		{
			((SettingsBase)this).set_Item("tel", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string fax
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("fax");
		}
		set
		{
			((SettingsBase)this).set_Item("fax", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string mtel
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("mtel");
		}
		set
		{
			((SettingsBase)this).set_Item("mtel", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string memail
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("memail");
		}
		set
		{
			((SettingsBase)this).set_Item("memail", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string hero1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("hero1");
		}
		set
		{
			((SettingsBase)this).set_Item("hero1", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string hero2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("hero2");
		}
		set
		{
			((SettingsBase)this).set_Item("hero2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string hero3
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("hero3");
		}
		set
		{
			((SettingsBase)this).set_Item("hero3", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string lover1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("lover1");
		}
		set
		{
			((SettingsBase)this).set_Item("lover1", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string lover2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("lover2");
		}
		set
		{
			((SettingsBase)this).set_Item("lover2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string lover3
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("lover3");
		}
		set
		{
			((SettingsBase)this).set_Item("lover3", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string friend1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("friend1");
		}
		set
		{
			((SettingsBase)this).set_Item("friend1", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string friend2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("friend2");
		}
		set
		{
			((SettingsBase)this).set_Item("friend2", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string friend3
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("friend3");
		}
		set
		{
			((SettingsBase)this).set_Item("friend3", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int b_year
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("b_year");
		}
		set
		{
			((SettingsBase)this).set_Item("b_year", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("0")]
	[DebuggerNonUserCode]
	public int b_month
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("b_month");
		}
		set
		{
			((SettingsBase)this).set_Item("b_month", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	[UserScopedSetting]
	public int b_day
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("b_day");
		}
		set
		{
			((SettingsBase)this).set_Item("b_day", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string zip1
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("zip1");
		}
		set
		{
			((SettingsBase)this).set_Item("zip1", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string zip2
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("zip2");
		}
		set
		{
			((SettingsBase)this).set_Item("zip2", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int i_pref
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("i_pref");
		}
		set
		{
			((SettingsBase)this).set_Item("i_pref", (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int i_question
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("i_question");
		}
		set
		{
			((SettingsBase)this).set_Item("i_question", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("0")]
	public int i_family
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("i_family");
		}
		set
		{
			((SettingsBase)this).set_Item("i_family", (object)value);
		}
	}

	[DefaultSettingValue("0")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public int i_house
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("i_house");
		}
		set
		{
			((SettingsBase)this).set_Item("i_house", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("0")]
	public int i_job
	{
		get
		{
			return (int)((SettingsBase)this).get_Item("i_job");
		}
		set
		{
			((SettingsBase)this).set_Item("i_job", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string family
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("family");
		}
		set
		{
			((SettingsBase)this).set_Item("family", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string house
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("house");
		}
		set
		{
			((SettingsBase)this).set_Item("house", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string job
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("job");
		}
		set
		{
			((SettingsBase)this).set_Item("job", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string company
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("company");
		}
		set
		{
			((SettingsBase)this).set_Item("company", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string companypost
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("companypost");
		}
		set
		{
			((SettingsBase)this).set_Item("companypost", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string salary
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("salary");
		}
		set
		{
			((SettingsBase)this).set_Item("salary", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[UserScopedSetting]
	[DefaultSettingValue("")]
	public string loan
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("loan");
		}
		set
		{
			((SettingsBase)this).set_Item("loan", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string motivation
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("motivation");
		}
		set
		{
			((SettingsBase)this).set_Item("motivation", (object)value);
		}
	}

	[UserScopedSetting]
	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	public string hobby
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("hobby");
		}
		set
		{
			((SettingsBase)this).set_Item("hobby", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string specialty
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("specialty");
		}
		set
		{
			((SettingsBase)this).set_Item("specialty", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	[UserScopedSetting]
	public string feedback
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("feedback");
		}
		set
		{
			((SettingsBase)this).set_Item("feedback", (object)value);
		}
	}

	[DefaultSettingValue("")]
	[UserScopedSetting]
	[DebuggerNonUserCode]
	public string instalpass
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("instalpass");
		}
		set
		{
			((SettingsBase)this).set_Item("instalpass", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string age
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("age");
		}
		set
		{
			((SettingsBase)this).set_Item("age", (object)value);
		}
	}

	[UserScopedSetting]
	[DefaultSettingValue("")]
	[DebuggerNonUserCode]
	public string MyPictures
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("MyPictures");
		}
		set
		{
			((SettingsBase)this).set_Item("MyPictures", (object)value);
		}
	}

	[DebuggerNonUserCode]
	[DefaultSettingValue("")]
	[UserScopedSetting]
	public string MyMusic
	{
		get
		{
			return (string)((SettingsBase)this).get_Item("MyMusic");
		}
		set
		{
			((SettingsBase)this).set_Item("MyMusic", (object)value);
		}
	}

	private void SettingChangingEventHandler(object sender, SettingChangingEventArgs e)
	{
	}

	private void SettingsSavingEventHandler(object sender, CancelEventArgs e)
	{
	}
}
