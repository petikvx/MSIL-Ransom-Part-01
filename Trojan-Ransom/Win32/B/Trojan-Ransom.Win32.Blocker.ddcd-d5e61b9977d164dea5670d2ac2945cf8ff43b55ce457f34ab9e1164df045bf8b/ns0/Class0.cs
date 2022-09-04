using System;
using System.Reflection;
using System.Windows.Forms;
using ns2;

namespace ns0;

internal sealed class Class0
{
	private static void smethod_0()
	{
		try
		{
			typeof(Application).InvokeMember("EnableVisualStyles", BindingFlags.Static | BindingFlags.Public | BindingFlags.InvokeMethod, null, null, null);
		}
		catch (MissingMethodException)
		{
		}
		Application.DoEvents();
	}

	public static bool smethod_1()
	{
		return smethod_2(bool_0: false);
	}

	private static bool smethod_2(bool bool_0)
	{
		DateTime dateTime = DateTime.Parse("2013-12-25T00:00:00");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			return true;
		}
		string name = Assembly.GetExecutingAssembly().GetName().Name;
		string text = string.Format("'{0}' has been built with an evaluation version of {{smartassembly}}, which has expired on {1}.\n\nYou need to purchase a license of {{smartassembly}}.", name, dateTime.ToString("D"));
		if (bool_0)
		{
			throw new Exception(text);
		}
		Form0 form = new Form0(text, "{smartassembly} License Exception", "error");
		smethod_0();
		Application.Run((Form)(object)form);
		return false;
	}
}
