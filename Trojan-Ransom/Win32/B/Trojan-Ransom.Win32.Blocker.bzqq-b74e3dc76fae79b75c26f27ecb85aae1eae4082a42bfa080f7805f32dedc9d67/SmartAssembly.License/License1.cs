using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using SmartAssembly.SmartExceptionsCore;
using ns1;
using ns2;

namespace SmartAssembly.License;

public class License1
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
		Form2 form = default(Form2);
		string name = default(string);
		string text = default(string);
		Form2 form2 = default(Form2);
		try
		{
			dateTime = DateTime.Parse("2013-08-15T05:49:45");
			if (!(DateTime.Now > dateTime) && !(DateTime.Now < dateTime.AddDays(-21.0)))
			{
				if (Class43.smethod_0() == null)
				{
					try
					{
						form = new Form2("This application has been built with an evaluation version of SmartAssembly, and therefore cannot be distributed. You can install SmartAssembly on this computer to be able to run this application.\n\nThis application will now quit.", "SmartAssembly Evaluation Version", "error");
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
			form2 = new Form2(text, "Program has expired", "error");
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
