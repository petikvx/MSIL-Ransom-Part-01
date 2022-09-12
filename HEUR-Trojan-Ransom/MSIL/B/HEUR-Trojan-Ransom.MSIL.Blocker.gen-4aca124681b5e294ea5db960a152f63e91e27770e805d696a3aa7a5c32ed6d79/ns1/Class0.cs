using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using SmartAssembly.Delegates;
using SmartAssembly.HouseOfCards;
using ns0;
using ns11;

namespace ns1;

internal static class Class0
{
	[NonSerialized]
	internal static GetString getString_0;

	[STAThread]
	private static void Main()
	{
		if (!Class35.smethod_3())
		{
			return;
		}
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		Console.WriteLine(executingAssembly.GetType().GUID.ToString());
		GuidAttribute guidAttribute = (GuidAttribute)executingAssembly.GetCustomAttributes(typeof(GuidAttribute), inherit: true)[0];
		string value = guidAttribute.Value;
		using Mutex mutex = new Mutex(initiallyOwned: false, getString_0(107391441) + value);
		if (mutex.WaitOne(0, exitContext: false))
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run((Form)(object)new Form0());
		}
	}

	static Class0()
	{
		Strings.CreateGetStringDelegate(typeof(Class0));
	}
}
