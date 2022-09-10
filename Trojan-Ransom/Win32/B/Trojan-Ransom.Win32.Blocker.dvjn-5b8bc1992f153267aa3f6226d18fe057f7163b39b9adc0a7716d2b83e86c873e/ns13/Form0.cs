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
		while (true)
		{
			this._002Ector();
			while (true)
			{
				int height = ((Control)this).get_Height();
				if (oTab6BvT4EQaZ2iGDXe())
				{
				}
				switch (2)
				{
				case 1:
				case 7:
					continue;
				case 3:
					break;
				case 2:
					eventArgs1_0 = reportExceptionEventArgs;
					class54_0 = unhandledExceptionHandler;
					((Control)class53_0).set_Text(reportExceptionEventArgs.exception_0.Message);
					height += ((Control)class53_0).get_Height() - ((Control)this).get_FontHeight();
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
						goto case 8;
					}
					goto default;
				case 8:
					unhandledExceptionHandler.DebuggerLaunched += method_6;
					((Control)button_5).set_Visible(true);
					((Control)control2_0).set_Visible(false);
					goto default;
				default:
					if (!reportExceptionEventArgs.bool_1)
					{
						((Control)button_1).set_Enabled(false);
						if (((Control)button_0).get_CanFocus())
						{
							((Control)button_0).Focus();
						}
					}
					goto case 0;
				case 0:
					((Control)textBox_0).set_Text(Class58.smethod_141("Email"));
					goto case 6;
				case 6:
					unhandledExceptionHandler.SendingReportFeedback += method_5;
					return;
				case 9:
					return;
				}
				break;
			}
		}
	}

	public Form0()
	{
		//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0114: Expected O, but got Unknown
		Class58.smethod_78(this);
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
		((Control)this).set_Text(Class58.smethod_54(this, ((Control)this).get_Text()));
		((Control)panel_2).set_Location(Point.Empty);
		((Control)panel_2).set_Dock((DockStyle)5);
		foreach (Control item in (ArrangedElementCollection)((Control)this).get_Controls())
		{
			Control val = item;
			val.set_Text(Class58.smethod_54(this, val.get_Text()));
			foreach (Control item2 in (ArrangedElementCollection)val.get_Controls())
			{
				Control val2 = item2;
				val2.set_Text(Class58.smethod_54(this, val2.get_Text()));
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
		while (true)
		{
			IL_0052:
			if (thread_0 == null)
			{
				goto IL_0003;
			}
			goto IL_0035;
			IL_0003:
			while (true)
			{
				((Form)this).OnClosing(e);
				if (fPmFMFvMlkxyy6FIH5E())
				{
					switch (5)
					{
					case 4:
						goto end_IL_0003;
					case 0:
					case 3:
						goto IL_0052;
					case 5:
						return;
					}
					continue;
				}
				break;
				continue;
				end_IL_0003:
				break;
			}
			goto IL_0035;
			IL_0035:
			if (thread_0.IsAlive)
			{
				thread_0.Abort();
			}
			goto IL_0003;
		}
	}

	private void method_7(object sender, EventArgs3 e)
	{
		Button val = ((!bool_0 || Thread.CurrentThread.ApartmentState != 0) ? button_4 : button_8);
		switch (e.enum4_0)
		{
		case Enum4.const_0:
			if (e.bool_0)
			{
				Class58.smethod_3(control0_0, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class58.smethod_155(control0_0);
			}
			break;
		case Enum4.const_1:
			if (e.bool_0)
			{
				Class58.smethod_3(control0_1, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class58.smethod_162(control0_0);
				Class58.smethod_155(control0_1);
			}
			break;
		case Enum4.const_2:
			if (e.bool_0)
			{
				((Control)control3_0).set_Visible(false);
				Class58.smethod_3(control0_2, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class58.smethod_162(control0_1);
				Class58.smethod_155(control0_2);
				((Control)control3_0).set_Visible(true);
			}
			break;
		case Enum4.const_3:
			((Control)control3_0).set_Visible(false);
			Class58.smethod_162(control0_2);
			Class58.smethod_162(control0_3);
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			((Control)button_2).set_Enabled(false);
			break;
		}
	}

	private void method_8(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_9(object sender, EventArgs e)
	{
		bool_0 = true;
		((Control)button_4).set_Visible(false);
		Class58.smethod_160(control0_0);
		Class58.smethod_160(control0_1);
		Class58.smethod_160(control0_2);
		if (eventArgs1_0 != null)
		{
			Class58.smethod_106((ThreadStart)method_10, this);
		}
	}

	internal void method_10()
	{
		Class58.smethod_122(eventArgs1_0);
	}

	internal void method_11(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class58.smethod_106((ThreadStart)eventArgs1_0.method_0, this);
		}
	}

	internal void method_12(object sender, EventArgs e)
	{
		string text = default(string);
		string string_ = default(string);
		EventArgs1 eventArgs = default(EventArgs1);
		string string_2 = default(string);
		string text2 = default(string);
		while (!checkBox_1.get_Checked())
		{
			int num = 0;
			if (!fPmFMFvMlkxyy6FIH5E())
			{
				goto IL_0095;
			}
			while (true)
			{
				switch (num)
				{
				case 0:
					break;
				case 5:
					goto end_IL_0035;
				case 1:
				case 2:
					text = ((Control)textBox_0).get_Text();
					goto default;
				default:
					Class58.smethod_50(string_, text, eventArgs);
					string_2 = "Email";
					text2 = ((Control)textBox_0).get_Text();
					goto IL_0095;
				case 6:
					goto IL_0095;
				case 7:
					return;
				}
				if (eventArgs1_0 == null)
				{
					goto end_IL_005c;
				}
				eventArgs = eventArgs1_0;
				string_ = "Email";
				num = 1;
				if (!oTab6BvT4EQaZ2iGDXe())
				{
				}
				continue;
				end_IL_0035:
				break;
			}
			continue;
			IL_0095:
			Class58.smethod_4(text2, string_2);
			break;
			continue;
			end_IL_005c:
			break;
		}
		Class58.smethod_102(this);
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
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_0019: Invalid comparison between Unknown and I4
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
		while (true)
		{
			SaveFileDialog val = new SaveFileDialog();
			int num = 3;
			if (!fPmFMFvMlkxyy6FIH5E())
			{
				break;
			}
			while (true)
			{
				switch (num)
				{
				case 6:
					((FileDialog)val).set_Title("Save an Exception Report");
					if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) == 2)
					{
						return;
					}
					if (!Class58.smethod_12(eventArgs1_0, ((FileDialog)val).get_FileName()))
					{
						MessageBox.Show("Failed to save the report.", "vf", (MessageBoxButtons)0, (MessageBoxIcon)16);
						num = 7;
						if (oTab6BvT4EQaZ2iGDXe())
						{
						}
						continue;
					}
					MessageBox.Show(string.Format("Please send the Exception Report to {0} Support Team.", "fbff"), "vf", (MessageBoxButtons)0, (MessageBoxIcon)64);
					goto default;
				case 1:
				case 3:
					((FileDialog)val).set_DefaultExt("saencryptedreport");
					((FileDialog)val).set_Filter("SmartAssembly Exception Report|*.saencryptedreport|All files|*.*");
					goto case 6;
				case 0:
				case 4:
					break;
				default:
					((Form)this).Close();
					return;
				case 5:
					return;
				case 7:
					return;
				}
				break;
			}
		}
	}

	internal void method_16(object sender, EventArgs e)
	{
		method_15(sender, e);
	}

	internal static bool fPmFMFvMlkxyy6FIH5E()
	{
		return true;
	}

	internal static bool oTab6BvT4EQaZ2iGDXe()
	{
		return false;
	}
}
