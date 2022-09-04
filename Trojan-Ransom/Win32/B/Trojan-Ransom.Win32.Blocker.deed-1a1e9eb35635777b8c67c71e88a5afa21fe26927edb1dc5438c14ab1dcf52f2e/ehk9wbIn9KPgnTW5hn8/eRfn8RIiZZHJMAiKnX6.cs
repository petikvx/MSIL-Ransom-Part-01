using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using eC98jAqdnPLlDITmK6;
using etKNQTu9kgqwCqmIAv;

namespace ehk9wbIn9KPgnTW5hn8;

internal class eRfn8RIiZZHJMAiKnX6
{
	[NonSerialized]
	internal static eDHHd4vO3FpvmheVMk e9jslfSvk;

	public static Bitmap eulODlten(string string_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream stream = (Stream)e8CCK02EyE45u9kA5ZW(eT9sSE221O1ZqC8HxNN(), eu0fJ12iu88keYdc9sM(e9jslfSvk(24415), string_0, e9jslfSvk(24476)));
			return (stream == null) ? ((Bitmap)null) : new Bitmap(stream);
		}
		catch
		{
			return null;
		}
	}

	public static Icon ecs0D1Zdd(string string_0)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream stream = (Stream)e8CCK02EyE45u9kA5ZW(eT9sSE221O1ZqC8HxNN(), eu0fJ12iu88keYdc9sM(e9jslfSvk(24415), string_0, e9jslfSvk(24485)));
			return (stream == null) ? ((Icon)null) : new Icon(stream);
		}
		catch
		{
			return null;
		}
	}

	static eRfn8RIiZZHJMAiKnX6()
	{
		ehFfDB2frcIS4CSw1Li(emoexm2YnSxpJdkgVjg(typeof(eRfn8RIiZZHJMAiKnX6).TypeHandle));
	}

	internal static object eT9sSE221O1ZqC8HxNN()
	{
		return Assembly.GetExecutingAssembly();
	}

	internal static object eu0fJ12iu88keYdc9sM(object object_0, object object_1, object object_2)
	{
		return (string?)object_0 + (string?)object_1 + (string?)object_2;
	}

	internal static object e8CCK02EyE45u9kA5ZW(object object_0, object object_1)
	{
		return ((Assembly)object_0).GetManifestResourceStream((string)object_1);
	}

	internal static bool e2pbSW2ZH0exKFZV8qI()
	{
		return true;
	}

	internal static bool eIaSMP2gDbVjRJQ5yUJ()
	{
		return false;
	}

	internal static Type emoexm2YnSxpJdkgVjg(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}

	internal static void ehFfDB2frcIS4CSw1Li(Type type_0)
	{
		eMbooerndU5ci2DHIZ.e4ZIbpnTa(type_0);
	}
}
