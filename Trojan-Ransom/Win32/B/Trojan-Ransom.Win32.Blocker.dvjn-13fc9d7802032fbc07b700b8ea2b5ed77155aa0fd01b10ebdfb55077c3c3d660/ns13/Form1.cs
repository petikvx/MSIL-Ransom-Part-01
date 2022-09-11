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
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		if (!dB5VSxpxfNb9I5Sk9b8())
		{
			switch (5)
			{
			case 5:
				((Form)this)._002Ector();
				goto case 1;
			case 1:
			case 4:
				Class56.smethod_4(this);
				break;
			case 2:
				break;
			default:
				goto IL_0068;
			case 6:
				goto IL_007f;
			}
		}
		((Form)this).set_Icon(Class56.smethod_83());
		((Control)this).set_Text(Class56.smethod_16(((Control)this).get_Text(), this));
		if (((Control)this).get_Text().Length == 0)
		{
			goto IL_0068;
		}
		goto IL_0073;
		IL_0068:
		((Control)this).set_Text("Security Exception");
		goto IL_0073;
		IL_007f:
		IEnumerator enumerator = default(IEnumerator);
		try
		{
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				val.set_Text(Class56.smethod_16(val.get_Text(), this));
				foreach (Control item in (ArrangedElementCollection)val.get_Controls())
				{
					Control val2 = item;
					val2.set_Text(Class56.smethod_16(val2.get_Text(), this));
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
		IL_0073:
		enumerator = ((ArrangedElementCollection)((Control)this).get_Controls()).GetEnumerator();
		goto IL_007f;
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
			((Control)class53_0).set_Text(Class56.smethod_16(stringBuilder.ToString(), this));
		}
		int num = ((Control)class53_0).get_Bottom() + 60;
		if (num > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num));
		}
	}

	void Form.Dispose(bool disposing)
	{
		while (true)
		{
			if (!disposing)
			{
				goto IL_0003;
			}
			goto IL_0035;
			IL_0003:
			((Form)this).Dispose(disposing);
			if (dB5VSxpxfNb9I5Sk9b8())
			{
				continue;
			}
			switch (5)
			{
			case 0:
			case 1:
				break;
			default:
				goto IL_003d;
			case 3:
				continue;
			case 5:
				return;
			}
			goto IL_0035;
			IL_003d:
			icontainer_0.Dispose();
			goto IL_0003;
			IL_0035:
			if (icontainer_0 == null)
			{
				goto IL_0003;
			}
			goto IL_003d;
		}
	}

	internal void method_0(object sender, EventArgs e)
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
				if (!wInxVepWaHRiadLZjAt())
				{
					return;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 2;
						if (wInxVepWaHRiadLZjAt())
						{
							continue;
						}
						goto IL_003d_2;
					case 1:
					case 3:
						break;
					case 2:
						goto IL_003d_2;
					case 0:
					case 4:
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
			eventArgs2_0.bool_0 = true;
			goto IL_003d;
		}
	}

	internal void method_1(object sender, EventArgs e)
	{
		if (eventArgs2_0 != null)
		{
			eventArgs2_0.bool_0 = false;
		}
		((Form)this).Close();
	}

	internal static bool wInxVepWaHRiadLZjAt()
	{
		return true;
	}

	internal static bool dB5VSxpxfNb9I5Sk9b8()
	{
		return false;
	}
}
