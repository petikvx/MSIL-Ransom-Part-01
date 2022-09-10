using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns10;
using ns12;
using ns13;

namespace ns14;

[DesignerCategory("Code")]
internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0;

	internal Control2 control2_0;

	internal Button button_0;

	internal Button button_1;

	internal Control1 control1_0;

	internal Class55 class55_0;

	internal void method_0(object sender, EventArgs e)
	{
		eventArgs2_0.bool_0 = true;
		((Form)this).Close();
	}

	internal void method_1(object sender, EventArgs e)
	{
		eventArgs2_0.bool_0 = false;
		((Form)this).Close();
	}

	public Form1(EventArgs2 securityExceptionEventArgs)
	{
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			control2_0 = new Control2();
			while (true)
			{
				button_0 = new Button();
				button_1 = new Button();
				control1_0 = new Control1(string.Format(Class32.smethod_0(7540), Class32.smethod_0(759)));
				int num = 1;
				if (wKjMXIRZUamQp14vcpf())
				{
					while (true)
					{
						switch (num)
						{
						case 3:
						case 5:
							((Form)this)._002Ector();
							Class12.smethod_20(this);
							((Form)this).set_Icon(Class12.smethod_33());
							((Control)this).set_Text(Class32.smethod_0(759));
							if (((Control)this).get_Text().Length == 0)
							{
								((Control)this).set_Text(Class32.smethod_0(7641));
							}
							eventArgs2_0 = securityExceptionEventArgs;
							if (securityExceptionEventArgs.bool_2)
							{
								goto IL_0123;
							}
							num = 6;
							if (wKjMXIRZUamQp14vcpf())
							{
								continue;
							}
							goto case 9;
						case 1:
							class55_0 = new Class55();
							goto case 3;
						default:
							num = 7;
							if (!tkhI3JR9bfIR8fXPVgP())
							{
							}
							continue;
						case 0:
							break;
						case 2:
							goto end_IL_00b9;
						case 4:
						case 6:
							((Control)button_0).set_Visible(false);
							goto IL_0123;
						case 9:
							if (securityExceptionEventArgs.bool_2)
							{
								stringBuilder.Append(Class32.smethod_0(7956));
							}
							stringBuilder.Append(securityExceptionEventArgs.securityException_0.Message);
							goto IL_0195;
						case 8:
							goto IL_0195;
						case 7:
							goto IL_01a6;
						case 10:
							return;
							IL_0123:
							if (securityExceptionEventArgs.string_0.Length > 0)
							{
								((Control)class55_0).set_Text(securityExceptionEventArgs.string_0);
								goto IL_01a6;
							}
							stringBuilder = new StringBuilder();
							stringBuilder.Append(string.Format(Class32.smethod_0(7662), Class32.smethod_0(759)));
							goto case 9;
						}
						break;
					}
					continue;
				}
				goto IL_0195;
				IL_01a6:
				int num2 = ((Control)class55_0).get_Bottom() + 60;
				if (num2 > ((Form)this).get_ClientSize().Height)
				{
					((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num2));
				}
				return;
				IL_0195:
				((Control)class55_0).set_Text(stringBuilder.ToString());
				goto IL_01a6;
				continue;
				end_IL_00b9:
				break;
			}
		}
	}

	internal static bool wKjMXIRZUamQp14vcpf()
	{
		return true;
	}

	internal static bool tkhI3JR9bfIR8fXPVgP()
	{
		return false;
	}
}
