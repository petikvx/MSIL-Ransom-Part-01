using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ns10;
using ns7;
using ns9;

namespace ns11;

[DesignerCategory("Code")]
internal class Form0 : Form
{
	private EventArgs1 eventArgs1_0;

	internal Thread thread_0;

	internal CheckBox checkBox_0;

	internal Label label_0;

	internal Button button_0;

	internal Button button_1;

	internal Label label_1;

	internal Class37 class37_0;

	internal Panel panel_0;

	internal Panel panel_1;

	internal Button button_2;

	internal Control3 control3_0;

	internal Control0 control0_0;

	internal Control0 control0_1;

	internal Control0 control0_2;

	internal Control0 control0_3;

	internal Button button_3;

	internal Button button_4;

	internal Button button_5;

	internal Control1 control1_0;

	internal Control1 control1_1;

	internal Control2 control2_0;

	internal Button button_6;

	private bool bool_0;

	internal void method_0(object sender, EventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		//IL_006e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Invalid comparison between Unknown and I4
		EventArgs1 eventArgs = default(EventArgs1);
		while (true)
		{
			SaveFileDialog val = new SaveFileDialog();
			if (F8PNr743D4aXBgX2n2o())
			{
				switch (6)
				{
				case 0:
					continue;
				case 6:
					((FileDialog)val).set_Title(Class14.smethod_0(5210));
					goto case 2;
				case 2:
				case 4:
					((FileDialog)val).set_DefaultExt(Class14.smethod_0(6208));
					goto default;
				default:
					((FileDialog)val).set_Filter(Class14.smethod_0(6233));
					if ((int)((CommonDialog)val).ShowDialog() == 1)
					{
						eventArgs = eventArgs1_0;
						break;
					}
					return;
				case 5:
					break;
				case 7:
					return;
				}
			}
			string fileName = ((FileDialog)val).get_FileName();
			Class42.smethod_18(fileName, eventArgs);
			((Form)this).Close();
			break;
		}
	}

	internal void method_1(object sender, EventArgs e)
	{
		try
		{
			((Control)panel_0).set_Visible(false);
			if (!zEcDL44SMyv7pXuffVG())
			{
				switch (2)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_004e;
				case 4:
					goto IL_0056;
				}
			}
			((Control)panel_1).set_Visible(true);
			((Control)control2_0).set_Visible(true);
			goto IL_004e;
			IL_0056:
			Class42.smethod_93((ThreadStart)method_11, this);
			return;
			IL_004e:
			if (eventArgs1_0 == null)
			{
				return;
			}
			goto IL_0056;
		}
		catch
		{
		}
	}

	internal void method_2(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_3(object sender, EventArgs e)
	{
		try
		{
			if (thread_0 != null)
			{
				thread_0.Abort();
			}
		}
		catch
		{
		}
		((Form)this).Close();
	}

	internal void method_4(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_5(object sender, EventArgs e)
	{
		eventArgs1_0.bool_3 = checkBox_0.get_Checked();
	}

	private void method_6(object sender, EventArgs3 e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new Delegate10(method_8), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_7(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(method_9), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	void Form.OnClosing(CancelEventArgs e)
	{
		while (thread_0 != null)
		{
			if (!F8PNr743D4aXBgX2n2o())
			{
				return;
			}
			switch (3)
			{
			case 0:
			case 4:
				continue;
			case 1:
			case 3:
				if (!thread_0.IsAlive)
				{
					break;
				}
				goto default;
			default:
				thread_0.Abort();
				break;
			case 5:
				return;
			}
			break;
		}
		((Form)this).OnClosing(e);
	}

	private void method_8(object sender, EventArgs3 e)
	{
		while (true)
		{
			IL_0122:
			if (bool_0)
			{
				goto IL_00af;
			}
			goto IL_0119;
			IL_0119:
			Button obj = button_4;
			goto IL_00f4;
			IL_00f4:
			Button val = obj;
			switch (e.enum1_0)
			{
			case Enum1.const_3:
				break;
			case Enum1.const_1:
				goto IL_00c3;
			default:
				return;
			case Enum1.const_0:
				goto IL_012c;
			case Enum1.const_2:
				goto IL_0177;
			}
			((Control)control3_0).set_Visible(false);
			goto IL_0012;
			IL_0177:
			if (e.bool_0)
			{
				((Control)control3_0).set_Visible(false);
				Class42.smethod_151(control0_2, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
				return;
			}
			Class42.smethod_84(control0_1);
			break;
			IL_00af:
			if (Thread.CurrentThread.ApartmentState == ApartmentState.STA)
			{
				obj = button_5;
				goto IL_00f4;
			}
			goto IL_0119;
			IL_0078:
			int num;
			while (true)
			{
				switch (num)
				{
				case 10:
					break;
				case 0:
				case 7:
					goto IL_0028;
				case 9:
					((Control)val).Focus();
					num = 8;
					if (F8PNr743D4aXBgX2n2o())
					{
						continue;
					}
					goto case 6;
				default:
					num = 3;
					if (!zEcDL44SMyv7pXuffVG())
					{
						continue;
					}
					return;
				case 2:
					goto IL_00af;
				case 4:
					goto IL_0122;
				case 1:
					return;
				case 3:
				case 5:
					goto end_IL_0122;
				case 8:
					return;
				case 6:
					((Control)button_2).set_Enabled(false);
					return;
				case 11:
					return;
				}
				break;
			}
			goto IL_0012;
			IL_012c:
			if (e.bool_0)
			{
				Class42.smethod_151(control0_0, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class42.smethod_68(control0_0);
			}
			return;
			IL_0012:
			Class42.smethod_84(control0_2);
			Class42.smethod_84(control0_3);
			goto IL_0028;
			IL_0028:
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			num = 6;
			if (!F8PNr743D4aXBgX2n2o())
			{
				continue;
			}
			goto IL_0078;
			IL_00c3:
			if (e.bool_0)
			{
				Class42.smethod_151(control0_1, e.string_0);
				((Control)val).set_Visible(true);
				num = 9;
				if (zEcDL44SMyv7pXuffVG())
				{
				}
				goto IL_0078;
			}
			Class42.smethod_84(control0_0);
			Class42.smethod_68(control0_1);
			return;
			continue;
			end_IL_0122:
			break;
		}
		Class42.smethod_68(control0_2);
		((Control)control3_0).set_Visible(true);
	}

	private void method_9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_10(object sender, EventArgs e)
	{
		bool_0 = true;
		((Control)button_4).set_Visible(false);
		Class42.smethod_16(control0_0);
		Class42.smethod_16(control0_1);
		Class42.smethod_16(control0_2);
		if (eventArgs1_0 != null)
		{
			Class42.smethod_93((ThreadStart)method_11, this);
		}
	}

	private void method_11()
	{
		Class42.smethod_7(eventArgs1_0);
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class42.smethod_93((ThreadStart)eventArgs1_0.method_0, this);
		}
	}

	public Form0(Class38 unhandledExceptionHandler, EventArgs1 reportExceptionEventArgs)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_0130: Expected O, but got Unknown
		//IL_0131: Unknown result type (might be due to invalid IL or missing references)
		//IL_013b: Expected O, but got Unknown
		//IL_013c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0146: Expected O, but got Unknown
		//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Expected O, but got Unknown
		int height = default(int);
		while (true)
		{
			checkBox_0 = new CheckBox();
			while (true)
			{
				label_0 = new Label();
				button_0 = new Button();
				button_1 = new Button();
				label_1 = new Label();
				class37_0 = new Class37();
				panel_0 = new Panel();
				panel_1 = new Panel();
				button_2 = new Button();
				if (!zEcDL44SMyv7pXuffVG())
				{
					switch (0)
					{
					case 2:
						break;
					case 6:
						goto end_IL_0006;
					case 0:
						control3_0 = new Control3();
						goto case 3;
					case 3:
					case 13:
						control0_0 = new Control0(Class14.smethod_0(6314));
						goto case 4;
					case 4:
					case 5:
						control0_1 = new Control0(Class14.smethod_0(6351));
						control0_2 = new Control0(Class14.smethod_0(6380));
						control0_3 = new Control0(Class14.smethod_0(6409));
						button_3 = new Button();
						goto case 9;
					case 9:
						button_4 = new Button();
						goto case 11;
					case 11:
						button_5 = new Button();
						control1_0 = new Control1(string.Format(Class14.smethod_0(6462), Class14.smethod_0(5227)));
						control1_1 = new Control1(string.Format(Class14.smethod_0(6551), Class14.smethod_0(5227), Class14.smethod_0(4913)));
						control2_0 = new Control2();
						button_6 = new Button();
						goto default;
					default:
						((Form)this)._002Ector();
						Class42.smethod_101(this);
						height = ((Control)this).get_Height();
						eventArgs1_0 = reportExceptionEventArgs;
						((Control)class37_0).set_Text(reportExceptionEventArgs.exception_0.Message);
						height += ((Control)class37_0).get_Height() - ((Control)this).get_FontHeight();
						if (!reportExceptionEventArgs.bool_2)
						{
							goto case 8;
						}
						goto IL_0215;
					case 8:
						((Control)checkBox_0).set_Visible(false);
						height -= ((Control)checkBox_0).get_Height();
						goto IL_0215;
					case 7:
						goto IL_0215;
					case 12:
						goto IL_0225;
					case 10:
						goto IL_0263;
					case 14:
						return;
					}
					continue;
				}
				goto IL_0215;
				IL_026f:
				if (!reportExceptionEventArgs.bool_1)
				{
					((Control)button_1).set_Enabled(false);
					if (((Control)button_0).get_CanFocus())
					{
						((Control)button_0).Focus();
					}
				}
				unhandledExceptionHandler.SendingReportFeedback += method_6;
				return;
				IL_0215:
				if (height > ((Control)this).get_Height())
				{
					((Control)this).set_Height(height);
				}
				goto IL_0225;
				IL_0263:
				((Control)control2_0).set_Visible(false);
				goto IL_026f;
				IL_0225:
				if (reportExceptionEventArgs.bool_0)
				{
					unhandledExceptionHandler.DebuggerLaunched += method_7;
					((Control)button_6).set_Visible(true);
					if (((Control)button_6).get_Left() < ((Control)control2_0).get_Right())
					{
						goto IL_0263;
					}
				}
				goto IL_026f;
				continue;
				end_IL_0006:
				break;
			}
		}
	}

	internal static bool F8PNr743D4aXBgX2n2o()
	{
		return true;
	}

	internal static bool zEcDL44SMyv7pXuffVG()
	{
		return false;
	}
}
