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

	internal CheckBox checkBox_0 = new CheckBox();

	internal Label label_0 = new Label();

	internal Button button_0 = new Button();

	internal Button button_1 = new Button();

	internal Label label_1 = new Label();

	internal Class38 class38_0 = new Class38();

	internal Panel panel_0 = new Panel();

	internal Panel panel_1 = new Panel();

	internal Button button_2 = new Button();

	internal Control3 control3_0 = new Control3();

	internal Control0 control0_0 = new Control0(Class14.smethod_0(7046));

	internal Control0 control0_1 = new Control0(Class14.smethod_0(7083));

	internal Control0 control0_2 = new Control0(Class14.smethod_0(7112));

	internal Control0 control0_3 = new Control0(Class14.smethod_0(7141));

	internal Button button_3 = new Button();

	internal Button button_4 = new Button();

	internal Button button_5 = new Button();

	internal Control1 control1_0 = new Control1(string.Format(Class14.smethod_0(7194), Class14.smethod_0(4213)));

	internal Control1 control1_1 = new Control1(string.Format(Class14.smethod_0(7283), Class14.smethod_0(4213), Class14.smethod_0(3899)));

	internal Control2 control2_0 = new Control2();

	internal Button button_6 = new Button();

	private bool bool_0;

	internal void method_0(object sender, EventArgs e)
	{
		//IL_003f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Invalid comparison between Unknown and I4
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		while (true)
		{
			SaveFileDialog val = new SaveFileDialog();
			while (true)
			{
				((FileDialog)val).set_Title(Class14.smethod_0(4196));
				((FileDialog)val).set_DefaultExt(Class14.smethod_0(6940));
				((FileDialog)val).set_Filter(Class14.smethod_0(6965));
				while (true)
				{
					if ((int)((CommonDialog)val).ShowDialog() != 1)
					{
						return;
					}
					while (true)
					{
						EventArgs1 eventArgs = eventArgs1_0;
						if (!V0ZW4OrIJicOxQFvM6f())
						{
							break;
						}
						switch (3)
						{
						case 2:
						case 4:
							goto end_IL_0003;
						case 1:
						case 5:
							goto end_IL_003e;
						case 6:
							goto end_IL_0049;
						case 3:
						{
							string fileName = ((FileDialog)val).get_FileName();
							Class33.smethod_50(fileName, eventArgs);
							((Form)this).Close();
							return;
						}
						case 7:
							return;
						}
						continue;
						end_IL_0003:
						break;
					}
					continue;
					end_IL_003e:
					break;
				}
				continue;
				end_IL_0049:
				break;
			}
		}
	}

	internal void method_1(object sender, EventArgs e)
	{
		try
		{
			((Control)panel_0).set_Visible(false);
			while (true)
			{
				((Control)panel_1).set_Visible(true);
				((Control)control2_0).set_Visible(true);
				while (true)
				{
					if (eventArgs1_0 == null)
					{
						return;
					}
					if (!NPjLacroS15YuB1ZV8o())
					{
						switch (4)
						{
						default:
							continue;
						case 0:
						case 3:
							break;
						case 4:
							Class33.smethod_141(this, (ThreadStart)method_11);
							return;
						}
					}
					break;
				}
			}
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
			((Control)this).Invoke((Delegate)new Delegate11(method_8), new object[2] { sender, e });
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
			if (!V0ZW4OrIJicOxQFvM6f())
			{
				return;
			}
			switch (4)
			{
			case 0:
			case 1:
				continue;
			case 4:
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
			if (bool_0)
			{
				goto IL_005a;
			}
			goto IL_008e;
			IL_008e:
			Button obj = button_4;
			goto IL_006c;
			IL_006c:
			Button val = obj;
			switch (e.enum1_0)
			{
			case Enum1.const_0:
				break;
			default:
				return;
			case Enum1.const_1:
				goto IL_00d3;
			case Enum1.const_2:
				goto IL_0112;
			case Enum1.const_3:
				goto IL_0169;
			}
			if (e.bool_0)
			{
				if (V0ZW4OrIJicOxQFvM6f())
				{
					switch (5)
					{
					case 1:
						break;
					case 6:
						continue;
					case 5:
						Class33.smethod_124(control0_0, e.string_0);
						((Control)val).set_Visible(true);
						((Control)val).Focus();
						return;
					case 2:
					case 7:
						return;
					case 0:
					case 4:
						goto IL_00f3;
					default:
						goto IL_0106;
					case 8:
						goto IL_011a;
					case 3:
						goto IL_0137;
					case 10:
						goto end_IL_0096;
					case 11:
						return;
					}
					goto IL_005a;
				}
				return;
			}
			Class33.smethod_15(control0_0);
			return;
			IL_0169:
			((Control)control3_0).set_Visible(false);
			break;
			IL_0112:
			if (!e.bool_0)
			{
				Class33.smethod_69(control0_1);
				Class33.smethod_15(control0_2);
				((Control)control3_0).set_Visible(true);
				return;
			}
			goto IL_011a;
			IL_00f3:
			((Control)val).Focus();
			return;
			IL_00d3:
			if (e.bool_0)
			{
				Class33.smethod_124(control0_1, e.string_0);
				((Control)val).set_Visible(true);
				goto IL_00f3;
			}
			Class33.smethod_69(control0_0);
			goto IL_0106;
			IL_005a:
			if (Thread.CurrentThread.ApartmentState == ApartmentState.STA)
			{
				obj = button_5;
				goto IL_006c;
			}
			goto IL_008e;
			IL_0137:
			((Control)val).set_Visible(true);
			((Control)val).Focus();
			return;
			IL_0106:
			Class33.smethod_15(control0_1);
			return;
			IL_011a:
			((Control)control3_0).set_Visible(false);
			Class33.smethod_124(control0_2, e.string_0);
			goto IL_0137;
			continue;
			end_IL_0096:
			break;
		}
		Class33.smethod_69(control0_2);
		Class33.smethod_69(control0_3);
		((Control)button_3).set_Enabled(true);
		((Control)button_3).Focus();
		((Control)button_2).set_Enabled(false);
	}

	private void method_9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_10(object sender, EventArgs e)
	{
		while (true)
		{
			bool_0 = true;
			if (NPjLacroS15YuB1ZV8o())
			{
			}
			switch (1)
			{
			case 0:
			case 2:
				break;
			case 1:
				((Control)button_4).set_Visible(false);
				Class33.smethod_66(control0_0);
				Class33.smethod_66(control0_1);
				Class33.smethod_66(control0_2);
				goto case 5;
			case 5:
				if (eventArgs1_0 == null)
				{
					return;
				}
				goto default;
			default:
				Class33.smethod_141(this, (ThreadStart)method_11);
				return;
			case 6:
				return;
			}
		}
	}

	private void method_11()
	{
		Class33.smethod_115(eventArgs1_0);
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class33.smethod_141(this, (ThreadStart)eventArgs1_0.method_0);
		}
	}

	public Form0(Class39 unhandledExceptionHandler, EventArgs1 reportExceptionEventArgs)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Expected O, but got Unknown
		//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d8: Expected O, but got Unknown
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e3: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		Class33.smethod_146(this);
		int height = ((Control)this).get_Height();
		eventArgs1_0 = reportExceptionEventArgs;
		((Control)class38_0).set_Text(reportExceptionEventArgs.exception_0.Message);
		height += ((Control)class38_0).get_Height() - ((Control)this).get_FontHeight();
		if (!reportExceptionEventArgs.bool_2)
		{
			((Control)checkBox_0).set_Visible(false);
			height -= ((Control)checkBox_0).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (reportExceptionEventArgs.bool_0)
		{
			unhandledExceptionHandler.DebuggerLaunched += method_7;
			((Control)button_6).set_Visible(true);
			if (((Control)button_6).get_Left() < ((Control)control2_0).get_Right())
			{
				((Control)control2_0).set_Visible(false);
			}
		}
		if (!reportExceptionEventArgs.bool_1)
		{
			((Control)button_1).set_Enabled(false);
			if (((Control)button_0).get_CanFocus())
			{
				((Control)button_0).Focus();
			}
		}
		unhandledExceptionHandler.SendingReportFeedback += method_6;
	}

	internal static bool V0ZW4OrIJicOxQFvM6f()
	{
		return true;
	}

	internal static bool NPjLacroS15YuB1ZV8o()
	{
		return false;
	}
}
