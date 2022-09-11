using System;
using System.Collections;
using System.Collections.Specialized;
using System.Resources;

namespace ns0;

internal class Class0
{
	internal static readonly string string_0 = "Name";

	internal static readonly string string_1 = "Culture";

	internal static readonly string string_2 = "z.dll";

	internal static HybridDictionary hybridDictionary_0 = null;

	internal static ResourceManager resourceManager_0 = null;

	internal static ArrayList arrayList_0 = null;

	internal static bool bool_0 = false;

	[STAThread]
	public static int Main(string[] args)
	{
		try
		{
			Class33.smethod_43();
			AppDomain currentDomain = AppDomain.CurrentDomain;
			currentDomain.AssemblyResolve += Class33.smethod_37;
			return Class33.smethod_32(args);
		}
		catch (Exception ex)
		{
			string text = " .NET Runtime: ";
			Class33.smethod_13(string.Concat("#Error: ", ex.GetType().ToString(), Environment.NewLine, ex.Message, Environment.NewLine, ex.StackTrace, Environment.NewLine, ex.InnerException, Environment.NewLine, "Using", text, Environment.Version.ToString(), Environment.NewLine, "Created with", text, "4.0.30319.42000"));
			return -1;
		}
	}
}
