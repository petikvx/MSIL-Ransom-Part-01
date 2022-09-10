using System;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ns10;
using ns7;
using ns9;

namespace ns11;

[DesignerCategory("Code")]
internal class Form1 : Form
{
	private EventArgs2 eventArgs2_0;

	internal Control2 control2_0;

	internal Button button_0;

	internal Button button_1;

	internal Control1 control1_0;

	internal Class38 class38_0;

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
		//IL_0135: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Expected O, but got Unknown
		//IL_0140: Unknown result type (might be due to invalid IL or missing references)
		//IL_014a: Expected O, but got Unknown
		int num2 = default(int);
		while (true)
		{
			control2_0 = new Control2();
			while (true)
			{
				button_0 = new Button();
				button_1 = new Button();
				while (true)
				{
					control1_0 = new Control1(string.Format(Class14.smethod_0(7380), Class14.smethod_0(4213)));
					class38_0 = new Class38();
					while (true)
					{
						((Form)this)._002Ector();
						Class33.smethod_132(this);
						((Form)this).set_Icon(Class33.smethod_5());
						((Control)this).set_Text(Class14.smethod_0(4213));
						while (true)
						{
							if (((Control)this).get_Text().Length == 0)
							{
								((Control)this).set_Text(Class14.smethod_0(7481));
							}
							eventArgs2_0 = securityExceptionEventArgs;
							if (!securityExceptionEventArgs.bool_2)
							{
								((Control)button_0).set_Visible(false);
							}
							if (securityExceptionEventArgs.string_0.Length > 0)
							{
								goto IL_016f;
							}
							StringBuilder stringBuilder = new StringBuilder();
							stringBuilder.Append(string.Format(Class14.smethod_0(7502), Class14.smethod_0(4213)));
							if (!securityExceptionEventArgs.bool_2)
							{
								goto IL_0182;
							}
							int num = 6;
							if (!ynsL14rZ9pO3aO9pYGi())
							{
								goto IL_01b4;
							}
							while (true)
							{
								switch (num)
								{
								default:
									num = 7;
									if (!SWdxqxruOXEEXmQ83Eb())
									{
									}
									continue;
								case 9:
									break;
								case 2:
									goto end_IL_00c8;
								case 8:
									goto end_IL_00da;
								case 1:
								case 4:
									goto end_IL_0103;
								case 3:
									goto end_IL_0134;
								case 6:
									goto IL_015c;
								case 5:
								case 7:
									goto IL_016f;
								case 0:
									goto IL_01b4;
								case 10:
									return;
								}
								break;
							}
							continue;
							IL_01b4:
							if (num2 > ((Form)this).get_ClientSize().Height)
							{
								((Form)this).set_ClientSize(new Size(((Form)this).get_ClientSize().Width, num2));
							}
							return;
							IL_01a5:
							num2 = ((Control)class38_0).get_Bottom() + 60;
							goto IL_01b4;
							IL_0182:
							stringBuilder.Append(securityExceptionEventArgs.securityException_0.Message);
							((Control)class38_0).set_Text(stringBuilder.ToString());
							goto IL_01a5;
							IL_015c:
							stringBuilder.Append(Class14.smethod_0(7796));
							goto IL_0182;
							IL_016f:
							((Control)class38_0).set_Text(securityExceptionEventArgs.string_0);
							goto IL_01a5;
							continue;
							end_IL_00c8:
							break;
						}
						continue;
						end_IL_00da:
						break;
					}
					continue;
					end_IL_0103:
					break;
				}
				continue;
				end_IL_0134:
				break;
			}
		}
	}

	internal static bool ynsL14rZ9pO3aO9pYGi()
	{
		return true;
	}

	internal static bool SWdxqxruOXEEXmQ83Eb()
	{
		return false;
	}
}
