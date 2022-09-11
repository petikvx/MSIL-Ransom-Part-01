using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using ns10;
using ns9;

namespace ns11;

internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0;

	internal Button button_0;

	internal Button button_1;

	internal Control1 control1_0;

	internal Class47 class47_0;

	internal Control2 control2_0;

	private IContainer icontainer_0;

	public Form1()
	{
		//IL_0089: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			((Form)this)._002Ector();
			if (rriycsbS2iUQRMCT5xV())
			{
				switch (4)
				{
				case 0:
					break;
				case 4:
					Class17.smethod_113(this);
					((Form)this).set_Icon(Class17.smethod_38());
					((Control)this).set_Text(Class17.smethod_47(this, ((Control)this).get_Text()));
					goto IL_005c;
				case 1:
				case 2:
					goto IL_005c;
				default:
					goto IL_0074;
				case 6:
					goto end_IL_0001;
				}
				continue;
			}
			goto IL_005c;
			IL_0074:
			enumerator = ((ArrangedElementCollection)((Control)this).get_Controls()).GetEnumerator();
			break;
			IL_005c:
			if (((Control)this).get_Text().Length == 0)
			{
				((Control)this).set_Text("Security Exception");
			}
			goto IL_0074;
			continue;
			end_IL_0001:
			break;
		}
		try
		{
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				val.set_Text(Class17.smethod_47(this, val.get_Text()));
				foreach (Control item in (ArrangedElementCollection)val.get_Controls())
				{
					Control val2 = item;
					val2.set_Text(Class17.smethod_47(this, val2.get_Text()));
				}
			}
		}
		finally
		{
			if (enumerator is IDisposable disposable)
			{
				disposable.Dispose();
			}
		}
	}

	public Form1(EventArgs2 eventArgs2_1)
	{
		int num = 7;
		if (rriycsbS2iUQRMCT5xV())
		{
			StringBuilder stringBuilder = default(StringBuilder);
			while (true)
			{
				switch (num)
				{
				case 7:
					this._002Ector();
					goto case 0;
				case 0:
					if (eventArgs2_1 != null)
					{
						if (!eventArgs2_1.bool_2)
						{
							((Control)button_0).set_Visible(false);
						}
						eventArgs2_0 = eventArgs2_1;
						goto case 6;
					}
					return;
				case 6:
					if (eventArgs2_1.string_0.Length > 0)
					{
						((Control)class47_0).set_Text(eventArgs2_1.string_0);
						num = 2;
						if (!R9c0gPbGKdels7gHeHj())
						{
						}
						continue;
					}
					stringBuilder = new StringBuilder();
					stringBuilder.Append("%AppName% attempted to perform an operation not allowed by the security policy. To grant this application the required permission, contact your system administrator, or use the Microsoft .NET Framework Configuration tool.\n\n");
					if (eventArgs2_1.bool_2)
					{
						stringBuilder.Append("If you click Continue, the application will ignore this error and attempt to continue. If you click Quit, the application will close immediately.\n\n");
					}
					goto default;
				default:
					stringBuilder.Append(eventArgs2_1.securityException_0.Message);
					((Control)class47_0).set_Text(Class17.smethod_47(this, stringBuilder.ToString()));
					break;
				case 2:
					break;
				case 3:
				case 5:
					goto IL_00eb;
				case 8:
					return;
				}
				break;
			}
		}
		int num2 = ((Control)class47_0).get_Bottom() + 60;
		goto IL_00eb;
		IL_00eb:
		if (num2 > ((Form)this).get_ClientSize().Height)
		{
			((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num2));
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
		if (eventArgs2_0 != null)
		{
			eventArgs2_0.bool_0 = false;
		}
		((Form)this).Close();
	}

	internal static bool rriycsbS2iUQRMCT5xV()
	{
		return true;
	}

	internal static bool R9c0gPbGKdels7gHeHj()
	{
		return false;
	}
}
