using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.Shared;
using SmartAssembly.SmartExceptionsCore;
using ns0;

namespace SmartAssembly.License;

public class License
{
	private static void smethod_0()
	{
		try
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
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	public static bool Validate()
	{
		try
		{
			return smethod_1(bool_0: false);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	public static void ValidateDLL()
	{
		try
		{
			smethod_1(bool_0: true);
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException0(exception);
			throw;
		}
	}

	private static bool smethod_1(bool bool_0)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		DateTime dateTime = default(DateTime);
		Form0 form = default(Form0);
		string name = default(string);
		string text = default(string);
		Form0 form2 = default(Form0);
		try
		{
			dateTime = DateTime.Parse("2014-04-10T08:16:53");
			if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
			{
				if (AppPathFinder.ReadInstalledSaPath() == null)
				{
					try
					{
						form = new Form0("This application has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed. You can install SmartAssembly on this computer to be able to run this application.\n\nThis application will now quit.", "SmartAssembly Evaluation Version", "error");
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
			name = Assembly.GetExecutingAssembly().GetName().Name;
			text = string.Format("This copy of '{0}' has expired and will no longer run. \nThis is because it was created using a version of Red Gate's SmartAssembly which is only licensed for testing software. \n\nYou should report this problem to the vendor who supplied '{0}'.", name, dateTime.ToString("D"));
			if (bool_0)
			{
				throw new Exception(text);
			}
			form2 = new Form0(text, "Program has expired", "error");
			smethod_0();
			Application.Run((Form)(object)form2);
			return false;
		}
		catch (Exception exception)
		{
			StackFrameHelper.CreateException6(exception, dateTime, name, text, form2, form, bool_0);
			throw;
		}
	}
}
