using System;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Windows.Forms;

internal static class Class2
{
	private static bool smethod_0(bool bool_0)
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		DateTime dateTime = DateTime.Parse("2013-01-19T19:42:11.5549000Z", CultureInfo.InvariantCulture, DateTimeStyles.RoundtripKind);
		DateTime utcNow = DateTime.UtcNow;
		if (!(utcNow > dateTime) && !(utcNow < dateTime.AddDays(-21.0)))
		{
			if (Class1.smethod_0() == null)
			{
				try
				{
					smethod_1();
					Form0 form = new Form0("This application has been built with an evaluation version of Eazfuscator.NET, and therefore cannot be distributed.\n\nYou can install Eazfuscator.NET on this computer to be able to run this application.\n\nThis application will now quit.", "Program Has Expired", "Error");
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
		Assembly assembly = typeof(Class2).Assembly;
		string name = assembly.GetName().Name;
		string text = string.Format("This copy of '{0}' has expired and will no longer run.\n\nThis happened because it was created using an evaluation version of Gapotchenko's Eazfuscator.NET which is only licensed for testing purposes. \n\nYou should report this problem to the vendor of '{0}'.", name);
		if (bool_0)
		{
			throw new Exception(text);
		}
		smethod_1();
		Form0 form2 = new Form0(text, "Program Has Expired", "Error");
		Application.Run((Form)(object)form2);
		return false;
	}

	private static void smethod_1()
	{
		Application.EnableVisualStyles();
		Application.DoEvents();
	}

	public static bool smethod_2()
	{
		return smethod_0(bool_0: false);
	}

	public static void smethod_3()
	{
		smethod_0(bool_0: true);
	}
}
