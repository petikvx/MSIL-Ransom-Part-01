using System;
using System.Collections;
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

	internal Class53 class53_0;

	internal Control2 control2_0;

	private IContainer icontainer_0;

	public Form1()
	{
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e8: Expected O, but got Unknown
		int num = 2;
		if (raPMj6vjcgeAKh6S9l6())
		{
			goto IL_005a;
		}
		goto IL_0089;
		IL_0089:
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			switch (num)
			{
			case 2:
				break;
			case 4:
				goto IL_003b;
			case 3:
			case 5:
				goto IL_005a;
			case 0:
			case 1:
				Class58.smethod_20(this);
				((Form)this).set_Icon(Class58.smethod_137());
				goto IL_003b;
			default:
				num = 5;
				if (!raPMj6vjcgeAKh6S9l6())
				{
					continue;
				}
				goto case 0;
			case 6:
				try
				{
					while (enumerator.MoveNext())
					{
						Control val = (Control)enumerator.Current;
						val.set_Text(Class58.smethod_121(val.get_Text(), this));
						foreach (Control item in (ArrangedElementCollection)val.get_Controls())
						{
							Control val2 = item;
							val2.set_Text(Class58.smethod_121(val2.get_Text(), this));
						}
					}
					return;
				}
				finally
				{
					if (enumerator is IDisposable disposable)
					{
						disposable.Dispose();
					}
				}
			}
			break;
		}
		goto IL_0028;
		IL_000f:
		enumerator = ((ArrangedElementCollection)((Control)this).get_Controls()).GetEnumerator();
		num = 6;
		if (!aXKCvVvWWb1LoWqv2dK())
		{
			goto IL_0028;
		}
		goto IL_0089;
		IL_0028:
		((Form)this)._002Ector();
		num = 0;
		if (!aXKCvVvWWb1LoWqv2dK())
		{
			goto IL_003b;
		}
		goto IL_0089;
		IL_005a:
		((Control)this).set_Text("Security Exception");
		goto IL_000f;
		IL_003b:
		((Control)this).set_Text(Class58.smethod_121(((Control)this).get_Text(), this));
		if (((Control)this).get_Text().Length != 0)
		{
			goto IL_000f;
		}
		goto IL_005a;
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
			((Control)class53_0).set_Text(securityExceptionEventArgs.string_0);
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
			((Control)class53_0).set_Text(Class58.smethod_121(stringBuilder.ToString(), this));
		}
		int num = ((Control)class53_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}

	void Form.Dispose(bool disposing)
	{
		if (aXKCvVvWWb1LoWqv2dK())
		{
			switch (4)
			{
			case 4:
				if (disposing)
				{
					break;
				}
				goto IL_0044;
			case 0:
			case 1:
				break;
			default:
				goto IL_0044;
			case 5:
				return;
			}
		}
		if (icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		goto IL_0044;
		IL_0044:
		((Form)this).Dispose(disposing);
	}

	internal void method_0(object sender, EventArgs e)
	{
		if (!raPMj6vjcgeAKh6S9l6())
		{
			switch (3)
			{
			case 0:
			case 3:
				if (eventArgs2_0 != null)
				{
					break;
				}
				goto IL_0042;
			case 1:
				break;
			default:
				goto IL_0042;
			case 5:
				return;
			}
		}
		eventArgs2_0.bool_0 = true;
		goto IL_0042;
		IL_0042:
		((Form)this).Close();
	}

	internal void method_1(object sender, EventArgs e)
	{
		int num = 2;
		if (!aXKCvVvWWb1LoWqv2dK())
		{
			goto IL_0030;
		}
		goto IL_003a;
		IL_003a:
		switch (num)
		{
		case 1:
		case 3:
			goto IL_0022;
		case 0:
		case 2:
			goto IL_0030;
		case 5:
			return;
		}
		goto IL_000f;
		IL_0030:
		if (eventArgs2_0 == null)
		{
			goto IL_000f;
		}
		goto IL_0022;
		IL_000f:
		((Form)this).Close();
		num = 5;
		if (raPMj6vjcgeAKh6S9l6())
		{
			goto IL_0022;
		}
		goto IL_003a;
		IL_0022:
		eventArgs2_0.bool_0 = false;
		goto IL_000f;
	}

	internal static bool aXKCvVvWWb1LoWqv2dK()
	{
		return true;
	}

	internal static bool raPMj6vjcgeAKh6S9l6()
	{
		return false;
	}
}
