using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using ns11;
using ns12;

namespace ns13;

internal class Form0 : Form
{
	private Class54 class54_0;

	internal EventArgs1 eventArgs1_0;

	internal Thread thread_0;

	internal CheckBox checkBox_0;

	internal Label label_0;

	internal Button button_0;

	internal Button button_1;

	internal Label label_1;

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

	internal Control1 control1_0;

	internal Control1 control1_1;

	internal Button button_5;

	private IContainer icontainer_0;

	internal Panel panel_2;

	internal Label label_2;

	internal Control1 control1_2;

	internal Button button_6;

	internal TextBox textBox_0;

	internal Label label_3;

	internal CheckBox checkBox_1;

	internal Class53 class53_0;

	internal Control2 control2_0;

	internal Button button_7;

	internal Button button_8;

	private bool bool_0;

	public Form0(Class54 unhandledExceptionHandler, EventArgs1 reportExceptionEventArgs)
	{
		if (DynRTMpcf8p7QdYasnU())
		{
			switch (3)
			{
			case 0:
			case 3:
				break;
			case 1:
			case 5:
				goto IL_0044;
			case 2:
				goto IL_0059;
			case 8:
				goto IL_0098;
			default:
				goto IL_00af;
			case 6:
				goto IL_00f0;
			case 4:
				goto IL_0115;
			case 9:
				return;
			}
		}
		this._002Ector();
		goto IL_0044;
		IL_0115:
		((Control)textBox_0).set_Text(Class56.smethod_157("Email"));
		unhandledExceptionHandler.SendingReportFeedback += method_5;
		return;
		IL_00b6:
		if (reportExceptionEventArgs.bool_0)
		{
			unhandledExceptionHandler.DebuggerLaunched += method_6;
			((Control)button_5).set_Visible(true);
			((Control)control2_0).set_Visible(false);
		}
		if (!reportExceptionEventArgs.bool_1)
		{
			goto IL_00f0;
		}
		goto IL_0115;
		IL_0044:
		int num = ((Control)this).get_Height();
		eventArgs1_0 = reportExceptionEventArgs;
		class54_0 = unhandledExceptionHandler;
		goto IL_0059;
		IL_0059:
		((Control)class53_0).set_Text(reportExceptionEventArgs.exception_0.Message);
		num += ((Control)class53_0).get_Height() - ((Control)this).get_FontHeight();
		if (!reportExceptionEventArgs.bool_2)
		{
			((Control)checkBox_0).set_Visible(false);
			goto IL_0098;
		}
		goto IL_00a6;
		IL_00f0:
		((Control)button_1).set_Enabled(false);
		if (((Control)button_0).get_CanFocus())
		{
			((Control)button_0).Focus();
		}
		goto IL_0115;
		IL_0098:
		num -= ((Control)checkBox_0).get_Height();
		goto IL_00a6;
		IL_00a6:
		if (num > ((Control)this).get_Height())
		{
			goto IL_00af;
		}
		goto IL_00b6;
		IL_00af:
		((Control)this).set_Height(num);
		goto IL_00b6;
	}

	public Form0()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		Class56.smethod_97(this);
		((Form)this).set_Size(new Size(419, 264));
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Control)panel_0).set_Location(Point.Empty);
		((Control)panel_0).set_Dock((DockStyle)5);
		((Control)button_4).set_Location(((Control)button_3).get_Location());
		((Control)button_4).set_Size(((Control)button_3).get_Size());
		((Control)button_4).BringToFront();
		((Control)panel_1).set_Location(Point.Empty);
		((Control)panel_1).set_Dock((DockStyle)5);
		((Control)this).set_Text(Class56.smethod_24(((Control)this).get_Text(), this));
		((Control)panel_2).set_Location(Point.Empty);
		((Control)panel_2).set_Dock((DockStyle)5);
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			val.set_Text(Class56.smethod_24(val.get_Text(), this));
			foreach (Control item2 in (ArrangedElementCollection)val.get_Controls())
			{
				Control val2 = item2;
				val2.set_Text(Class56.smethod_24(val2.get_Text(), this));
			}
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
		((Control)panel_0).set_Visible(false);
		((Control)panel_2).set_Visible(true);
	}

	internal void method_1(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_2(object sender, EventArgs e)
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

	internal void method_3(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_4(object sender, EventArgs e)
	{
		eventArgs1_0.bool_3 = checkBox_0.get_Checked();
	}

	private void method_5(object sender, EventArgs3 e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new Delegate20(method_7), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_6(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(method_8), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	void Form.OnClosing(CancelEventArgs e)
	{
		if (RjlUkVpsMZ1o3Sm47Nr())
		{
		}
		switch (4)
		{
		case 0:
		case 4:
			if (thread_0 == null)
			{
				break;
			}
			goto case 1;
		case 1:
		case 2:
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
		((Form)this).OnClosing(e);
	}

	private void method_7(object sender, EventArgs3 e)
	{
		int num = 6;
		Button val = default(Button);
		if (!RjlUkVpsMZ1o3Sm47Nr())
		{
			Control0 control = default(Control0);
			while (true)
			{
				Button obj;
				switch (num)
				{
				case 6:
					if (bool_0)
					{
						goto case 3;
					}
					goto IL_002e;
				case 3:
					if (Thread.CurrentThread.ApartmentState != 0)
					{
						goto IL_002e;
					}
					obj = button_8;
					goto IL_0034;
				default:
				{
					((Control)control3_0).set_Visible(false);
					control = control0_2;
					string string_ = e.string_0;
					Class56.smethod_28(string_, control);
					((Control)val).set_Visible(true);
					break;
				}
				case 5:
					return;
				case 1:
				case 7:
					break;
				case 2:
					return;
				case 9:
				{
					control = control0_0;
					string string_ = e.string_0;
					Class56.smethod_28(string_, control);
					((Control)val).set_Visible(true);
					((Control)val).Focus();
					return;
				}
				case 10:
				{
					string string_ = e.string_0;
					Class56.smethod_28(string_, control);
					((Control)val).set_Visible(true);
					goto case 4;
				}
				case 4:
				case 8:
					((Control)val).Focus();
					return;
				case 11:
					return;
				case 12:
					return;
					IL_002e:
					obj = button_4;
					goto IL_0034;
					IL_0034:
					val = obj;
					switch (e.enum4_0)
					{
					default:
						return;
					case Enum4.const_0:
						break;
					case Enum4.const_1:
						goto IL_00b5;
					case Enum4.const_2:
						goto IL_00e4;
					case Enum4.const_3:
						((Control)control3_0).set_Visible(false);
						Class56.smethod_37(control0_2);
						Class56.smethod_37(control0_3);
						((Control)button_3).set_Enabled(true);
						((Control)button_3).Focus();
						((Control)button_2).set_Enabled(false);
						return;
					}
					if (e.bool_0)
					{
						num = 9;
						if (DynRTMpcf8p7QdYasnU())
						{
							continue;
						}
						goto default;
					}
					Class56.smethod_17(control0_0);
					return;
					IL_00e4:
					if (!e.bool_0)
					{
						Class56.smethod_37(control0_1);
						Class56.smethod_17(control0_2);
						((Control)control3_0).set_Visible(true);
						return;
					}
					goto default;
					IL_00b5:
					if (e.bool_0)
					{
						control = control0_1;
						goto case 10;
					}
					Class56.smethod_37(control0_0);
					Class56.smethod_17(control0_1);
					return;
				}
				break;
			}
		}
		((Control)val).Focus();
	}

	private void method_8(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_9(object sender, EventArgs e)
	{
		bool_0 = true;
		((Control)button_4).set_Visible(false);
		Class56.smethod_18(control0_0);
		Class56.smethod_18(control0_1);
		Class56.smethod_18(control0_2);
		if (eventArgs1_0 != null)
		{
			Class56.smethod_22((ThreadStart)method_10, this);
		}
	}

	internal void method_10()
	{
		Class56.smethod_162(eventArgs1_0);
	}

	internal void method_11(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class56.smethod_22((ThreadStart)eventArgs1_0.method_0, this);
		}
	}

	internal void method_12(object sender, EventArgs e)
	{
		int num = 0;
		if (!DynRTMpcf8p7QdYasnU())
		{
			goto IL_0023;
		}
		goto IL_0072;
		IL_0072:
		switch (num)
		{
		case 1:
		case 4:
			goto IL_0023;
		case 2:
		case 3:
			goto IL_0032;
		case 0:
			if (checkBox_1.get_Checked())
			{
				break;
			}
			goto IL_0023;
		case 6:
			return;
		}
		goto IL_000f;
		IL_000f:
		Class56.smethod_80(this);
		num = 6;
		if (!DynRTMpcf8p7QdYasnU())
		{
			return;
		}
		goto IL_0072;
		IL_0023:
		if (eventArgs1_0 == null)
		{
			goto IL_000f;
		}
		EventArgs1 eventArgs = eventArgs1_0;
		goto IL_0032;
		IL_0032:
		string string_ = "Email";
		string text = ((Control)textBox_0).get_Text();
		Class56.smethod_81(text, eventArgs, string_);
		Class56.smethod_9("Email", ((Control)textBox_0).get_Text());
		goto IL_000f;
	}

	internal void method_13(object sender, EventArgs e)
	{
		((Control)button_6).set_Enabled(((Control)textBox_0).get_Text().Length > 0 || checkBox_1.get_Checked());
	}

	internal void method_14(object sender, EventArgs e)
	{
		((Control)textBox_0).set_Enabled(!checkBox_1.get_Checked());
		((Control)button_6).set_Enabled(((Control)textBox_0).get_Text().Length > 0 || checkBox_1.get_Checked());
	}

	internal void method_15(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0029: Unknown result type (might be due to invalid IL or missing references)
		//IL_002f: Invalid comparison between Unknown and I4
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_DefaultExt("saencryptedreport");
		((FileDialog)val).set_Filter("SmartAssembly Exception Report|*.saencryptedreport|All files|*.*");
		((FileDialog)val).set_Title("Save an Exception Report");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) != 2)
		{
			EventArgs1 eventArgs = eventArgs1_0;
			string fileName = ((FileDialog)val).get_FileName();
			if (Class56.smethod_134(fileName, eventArgs))
			{
				MessageBox.Show(string.Format("Please send the Exception Report to {0} Support Team.", "fbff"), "vf", (MessageBoxButtons)0, (MessageBoxIcon)64);
				((Form)this).Close();
			}
			else
			{
				MessageBox.Show("Failed to save the report.", "vf", (MessageBoxButtons)0, (MessageBoxIcon)16);
			}
		}
	}

	internal void method_16(object sender, EventArgs e)
	{
		method_15(sender, e);
	}

	internal static bool DynRTMpcf8p7QdYasnU()
	{
		return true;
	}

	internal static bool RjlUkVpsMZ1o3Sm47Nr()
	{
		return false;
	}
}
