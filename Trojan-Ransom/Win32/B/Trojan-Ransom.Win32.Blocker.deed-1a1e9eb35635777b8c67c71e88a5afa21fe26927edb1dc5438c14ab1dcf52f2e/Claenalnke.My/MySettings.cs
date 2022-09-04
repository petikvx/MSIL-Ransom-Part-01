using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Runtime.CompilerServices;
using e1t9ZoIMs7pU1MfVBaV;

namespace Claenalnke.My;

[EditorBrowsable(EditorBrowsableState.Advanced)]
[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
[CompilerGenerated]
internal sealed class MySettings : ApplicationSettingsBase
{
	private static MySettings mySettings_0;

	public static MySettings Default
	{
		get
		{
			try
			{
				return mySettings_0;
			}
			catch (Exception object_)
			{
				MySettings object_2 = default(MySettings);
				eTnvEssLFGKC6AgciA(object_, object_2);
				throw;
			}
		}
	}

	static MySettings()
	{
		try
		{
			mySettings_0 = (MySettings)eYotikFSZC3lC6WMe0(new MySettings());
		}
		catch (Exception object_)
		{
			eeqx1mer1eWyi9mnHJ(object_);
			throw;
		}
	}

	public MySettings()
	{
		eGcTaWK6NedwiPbKvL(this);
	}

	internal static object eYotikFSZC3lC6WMe0(object object_0)
	{
		return SettingsBase.Synchronized((SettingsBase)object_0);
	}

	internal static void eeqx1mer1eWyi9mnHJ(object object_0)
	{
		eEJNauItTVW1j8pluTb.eulODlten((Exception)object_0);
	}

	internal static bool ewLiNmOqhxMBxOTsAm()
	{
		return true;
	}

	internal static bool enaBN43k57aSfRR3Qo()
	{
		return false;
	}

	internal static void eGcTaWK6NedwiPbKvL(object object_0)
	{
		((ApplicationSettingsBase)object_0)._002Ector();
	}

	internal static void eTnvEssLFGKC6AgciA(object object_0, object object_1)
	{
		eEJNauItTVW1j8pluTb.ecs0D1Zdd((Exception)object_0, object_1);
	}
}
