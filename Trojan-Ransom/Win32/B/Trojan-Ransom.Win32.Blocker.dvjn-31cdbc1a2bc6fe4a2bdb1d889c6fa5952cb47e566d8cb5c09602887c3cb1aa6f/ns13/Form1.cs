using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using ns11;
using ns12;

namespace ns13;

internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0;

	internal Button button_0;

	internal Button button_1;

	internal Control1 control1_0;

	internal Class54 class54_0;

	internal Control2 control2_0;

	private IContainer icontainer_0;

	public Form1()
	{
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		Class21.smethod_83(this);
		((Form)this).set_Icon(Class21.smethod_169());
		((Control)this).set_Text(Class21.smethod_5(((Control)this).get_Text(), this));
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Security Exception");
		}
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			val.set_Text(Class21.smethod_5(val.get_Text(), this));
			foreach (Control item2 in (ArrangedElementCollection)val.get_Controls())
			{
				Control val2 = item2;
				val2.set_Text(Class21.smethod_5(val2.get_Text(), this));
			}
		}
	}

	public Form1(EventArgs2 securityExceptionEventArgs)
		: this()
	{
		if (securityExceptionEventArgs == null)
		{
			return;
		}
		if (!securityExceptionEventArgs.bool_2)
		{
			((Control)button_0).set_Visible(false);
		}
		eventArgs2_0 = securityExceptionEventArgs;
		if (securityExceptionEventArgs.string_0.Length > 0)
		{
			((Control)class54_0).set_Text(securityExceptionEventArgs.string_0);
		}
		else
		{
			StringBuilder stringBuilder = new StringBuilder();
			stringBuilder.Append("%AppName% attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n");
			if (securityExceptionEventArgs.bool_2)
			{
				stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
			}
			stringBuilder.Append(securityExceptionEventArgs.securityException_0.Message);
			((Control)class54_0).set_Text(Class21.smethod_5(stringBuilder.ToString(), this));
		}
		int num = ((Control)class54_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	internal void method_0(object sender, EventArgs e)
	{
		if (eventArgs2_0 != null)
		{
			eventArgs2_0.bool_0 = true;
		}
		((Form)this).Close();
	}

	internal void method_1(object sender, EventArgs e)
	{
		while (true)
		{
			IL_0051:
			if (eventArgs2_0 != null)
			{
				goto IL_0031;
			}
			goto IL_003d;
			IL_003d:
			while (true)
			{
				IL_003d_2:
				((Form)this).Close();
				int num = 5;
				if (!KxttA5XhNVcrMGoVcRB())
				{
					return;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 3;
						if (KxttA5XhNVcrMGoVcRB())
						{
							continue;
						}
						goto IL_003d_2;
					case 1:
					case 4:
						break;
					case 2:
					case 3:
						goto IL_003d_2;
					case 0:
						goto IL_0051;
					case 5:
						return;
					}
					break;
				}
				break;
			}
			goto IL_0031;
			IL_0031:
			eventArgs2_0.bool_0 = false;
			goto IL_003d;
		}
	}

	internal static bool KxttA5XhNVcrMGoVcRB()
	{
		return true;
	}

	internal static bool lPqyNJXdeQAwQqahJf1()
	{
		return false;
	}
}
