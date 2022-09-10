using System;
using System.Collections;
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
	private Class55 class55_0;

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

	internal Class54 class54_0;

	internal Control2 control2_0;

	internal Button button_7;

	internal Button button_8;

	private bool bool_0;

	public Form0(Class55 unhandledExceptionHandler, EventArgs1 reportExceptionEventArgs)
		: this()
	{
		int height = ((Control)this).get_Height();
		eventArgs1_0 = reportExceptionEventArgs;
		class55_0 = unhandledExceptionHandler;
		((Control)class54_0).set_Text(reportExceptionEventArgs.exception_0.Message);
		height += ((Control)class54_0).get_Height() - ((Control)this).get_FontHeight();
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
			unhandledExceptionHandler.DebuggerLaunched += method_6;
			((Control)button_5).set_Visible(true);
			((Control)control2_0).set_Visible(false);
		}
		if (!reportExceptionEventArgs.bool_1)
		{
			((Control)button_1).set_Enabled(false);
			if (((Control)button_0).get_CanFocus())
			{
				((Control)button_0).Focus();
			}
		}
		((Control)textBox_0).set_Text(Class21.smethod_15("Email"));
		unhandledExceptionHandler.SendingReportFeedback += method_5;
	}

	public Form0()
	{
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0136: Expected O, but got Unknown
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0163: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			((Form)this)._002Ector();
			while (true)
			{
				Class21.smethod_121(this);
				while (true)
				{
					IL_0094:
					((Form)this).set_Size(new Size(419, 264));
					((Form)this).set_MinimizeBox(false);
					((Form)this).set_MaximizeBox(false);
					((Control)panel_0).set_Location(Point.Empty);
					((Control)panel_0).set_Dock((DockStyle)5);
					((Control)button_4).set_Location(((Control)button_3).get_Location());
					while (true)
					{
						IL_006e:
						((Control)button_4).set_Size(((Control)button_3).get_Size());
						((Control)button_4).BringToFront();
						while (true)
						{
							((Control)panel_1).set_Location(Point.Empty);
							((Control)panel_1).set_Dock((DockStyle)5);
							((Control)this).set_Text(Class21.smethod_10(this, ((Control)this).get_Text()));
							if (!RLoJTvXSeb6VgDcAe5e())
							{
								break;
							}
							switch (6)
							{
							case 3:
								goto IL_006e;
							case 2:
								goto IL_0094;
							case 0:
							case 1:
								goto end_IL_0006;
							case 4:
								goto end_IL_00ec;
							case 5:
							case 6:
								((Control)panel_2).set_Location(Point.Empty);
								((Control)panel_2).set_Dock((DockStyle)5);
								enumerator = ((ArrangedElementCollection)((Control)this).get_Controls()).GetEnumerator();
								goto case 8;
							case 8:
								try
								{
									while (enumerator.MoveNext())
									{
										Control val = (Control)enumerator.Current;
										val.set_Text(Class21.smethod_10(this, val.get_Text()));
										foreach (Control item in (ArrangedElementCollection)val.get_Controls())
										{
											Control val2 = item;
											if (sb9sLPXP1RJ1pK3ig1B())
											{
											}
											switch (2)
											{
											case 0:
											case 2:
												val2.set_Text(Class21.smethod_10(this, val2.get_Text()));
												break;
											}
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
							continue;
							end_IL_0006:
							break;
						}
						break;
					}
					break;
				}
				continue;
				end_IL_00ec:
				break;
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
		if (thread_0 != null && thread_0.IsAlive)
		{
			thread_0.Abort();
		}
		((Form)this).OnClosing(e);
	}

	private void method_7(object sender, EventArgs3 e)
	{
		Control0 control = default(Control0);
		string string_ = default(string);
		while (true)
		{
			if (bool_0)
			{
				goto IL_00b3;
			}
			goto IL_00cf;
			IL_00cf:
			Button obj = button_4;
			goto IL_00c5;
			IL_00c5:
			Button val = obj;
			Enum4 enum4_ = e.enum4_0;
			while (true)
			{
				switch (enum4_)
				{
				case Enum4.const_2:
					break;
				case Enum4.const_0:
					goto IL_0083;
				default:
					return;
				case Enum4.const_1:
					goto IL_00ef;
				case Enum4.const_3:
					goto IL_0185;
				}
				int num;
				if (e.bool_0)
				{
					((Control)control3_0).set_Visible(false);
					control = control0_2;
					string_ = e.string_0;
					Class21.smethod_23(string_, control);
					((Control)val).set_Visible(true);
					num = 9;
					if (!sb9sLPXP1RJ1pK3ig1B())
					{
					}
					goto IL_0045;
				}
				Class21.smethod_165(control0_1);
				Class21.smethod_42(control0_2);
				((Control)control3_0).set_Visible(true);
				return;
				IL_0185:
				((Control)control3_0).set_Visible(false);
				goto IL_0191;
				IL_00ef:
				if (e.bool_0)
				{
					control = control0_1;
					string_ = e.string_0;
					Class21.smethod_23(string_, control);
					((Control)val).set_Visible(true);
					goto IL_012c;
				}
				Class21.smethod_165(control0_0);
				Class21.smethod_42(control0_1);
				return;
				IL_0191:
				Class21.smethod_165(control0_2);
				goto IL_019c;
				IL_019c:
				Class21.smethod_165(control0_3);
				((Control)button_3).set_Enabled(true);
				((Control)button_3).Focus();
				((Control)button_2).set_Enabled(false);
				return;
				IL_0083:
				if (e.bool_0)
				{
					num = 6;
					if (sb9sLPXP1RJ1pK3ig1B())
					{
						break;
					}
					goto IL_0045;
				}
				Class21.smethod_42(control0_0);
				return;
				IL_012c:
				((Control)val).Focus();
				return;
				IL_0045:
				switch (num)
				{
				case 4:
					break;
				case 1:
				case 5:
					goto IL_00b3;
				case 7:
					goto end_IL_0099;
				default:
					goto IL_012c;
				case 6:
					control = control0_0;
					string_ = e.string_0;
					goto case 2;
				case 2:
					Class21.smethod_23(string_, control);
					goto case 11;
				case 9:
					((Control)val).Focus();
					return;
				case 11:
					((Control)val).set_Visible(true);
					((Control)val).Focus();
					return;
				case 8:
				case 10:
					goto IL_0191;
				case 3:
					goto IL_019c;
				case 12:
					return;
				}
				continue;
				end_IL_0099:
				break;
			}
			continue;
			IL_00b3:
			if (Thread.CurrentThread.ApartmentState == ApartmentState.STA)
			{
				obj = button_8;
				goto IL_00c5;
			}
			goto IL_00cf;
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
		Class21.smethod_47(control0_0);
		Class21.smethod_47(control0_1);
		Class21.smethod_47(control0_2);
		if (eventArgs1_0 != null)
		{
			Class21.smethod_26((ThreadStart)method_10, this);
		}
	}

	internal void method_10()
	{
		Class21.smethod_2(eventArgs1_0);
	}

	internal void method_11(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class21.smethod_26((ThreadStart)eventArgs1_0.method_0, this);
		}
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (!checkBox_1.get_Checked() && eventArgs1_0 != null)
		{
			EventArgs1 eventArgs = eventArgs1_0;
			string string_ = "Email";
			string text = ((Control)textBox_0).get_Text();
			Class21.smethod_99(string_, text, eventArgs);
			Class21.smethod_106("Email", ((Control)textBox_0).get_Text());
		}
		Class21.smethod_143(this);
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
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0062: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Invalid comparison between Unknown and I4
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
		if (!RLoJTvXSeb6VgDcAe5e())
		{
			return;
		}
		SaveFileDialog val = default(SaveFileDialog);
		switch (0)
		{
		case 0:
			val = new SaveFileDialog();
			goto case 1;
		case 1:
		case 6:
			((FileDialog)val).set_DefaultExt("saencryptedreport");
			((FileDialog)val).set_Filter("SmartAssembly Exception Report|*.saencryptedreport|All files|*.*");
			goto case 2;
		case 2:
		case 5:
			((FileDialog)val).set_Title("Save an Exception Report");
			break;
		case 3:
			return;
		case 7:
			return;
		}
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) != 2)
		{
			if (Class21.smethod_31(eventArgs1_0, ((FileDialog)val).get_FileName()))
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

	internal static bool RLoJTvXSeb6VgDcAe5e()
	{
		return true;
	}

	internal static bool sb9sLPXP1RJ1pK3ig1B()
	{
		return false;
	}
}
