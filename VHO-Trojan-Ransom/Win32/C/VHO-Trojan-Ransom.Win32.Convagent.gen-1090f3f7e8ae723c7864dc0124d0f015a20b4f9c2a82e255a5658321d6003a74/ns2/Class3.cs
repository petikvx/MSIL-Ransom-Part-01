using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using ns0;
using ns1;

namespace ns2;

internal class Class3
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
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		DateTime dateTime = DateTime.Parse("2014-06-19T07:47:08");
		if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
		{
			if (Class1.smethod_0() == null)
			{
				try
				{
					Form0 form = new Form0("This application has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed. You can install SmartAssembly on this computer to be able to run this application.\n\nThis application will now quit.", "SmartAssembly Evaluation Version", "error");
					smethod_0();
					((Control)form).set_BackColor(Color.White);
					((Form)form).ShowDialog();
				}
				catch
				{
				}
				return false;
			}
			return true;
		}
		string name = Assembly.GetExecutingAssembly().GetName().Name;
		string text = string.Format("This copy of '{0}' has expired and will no longer run. \nThis is because it was created using a version of Red Gate's SmartAssembly which is only licensed for testing software. \n\nYou should report this problem to the vendor who supplied '{0}'.", name, dateTime.ToString("D"));
		if (bool_0)
		{
			throw new Exception(text);
		}
		Form0 form2 = new Form0(text, "Program has expired", "error");
		smethod_0();
		Application.Run((Form)(object)form2);
		return false;
	}
}
