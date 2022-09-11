using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using ns10;
using ns9;

namespace ns11;

internal class Form0 : Form
{
	private Class48 class48_0;

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

	internal Class47 class47_0;

	internal Control2 control2_0;

	internal Button button_7;

	internal Button button_8;

	private bool bool_0;

	public Form0(Class48 class48_1, EventArgs1 eventArgs1_1)
	{
		while (true)
		{
			this._002Ector();
			while (true)
			{
				int height = ((Control)this).get_Height();
				eventArgs1_0 = eventArgs1_1;
				class48_0 = class48_1;
				((Control)class47_0).set_Text(eventArgs1_1.exception_0.Message);
				height += ((Control)class47_0).get_Height() - ((Control)this).get_FontHeight();
				while (true)
				{
					if (!eventArgs1_1.bool_2)
					{
						((Control)checkBox_0).set_Visible(false);
						height -= ((Control)checkBox_0).get_Height();
					}
					if (height <= ((Control)this).get_Height())
					{
						goto IL_001d;
					}
					int num = 0;
					if (o5yAc6GqAASM8i0qTZ8())
					{
					}
					goto IL_0096;
					IL_0096:
					switch (num)
					{
					case 0:
						goto IL_0061;
					case 7:
						continue;
					case 1:
					case 6:
						goto end_IL_00e4;
					case 2:
						goto end_IL_00f2;
					case 3:
						goto IL_013c;
					case 5:
						goto IL_015d;
					case 9:
						return;
					}
					goto IL_0054;
					IL_015d:
					Class17.smethod_187((Delegate14)method_5, class48_1);
					return;
					IL_013c:
					((Control)button_0).Focus();
					goto IL_0148;
					IL_001d:
					if (eventArgs1_1.bool_0)
					{
						Class17.smethod_162(class48_1, (EventHandler)method_6);
						((Control)button_5).set_Visible(true);
						((Control)control2_0).set_Visible(false);
					}
					goto IL_0054;
					IL_0061:
					((Control)this).set_Height(height);
					goto IL_001d;
					IL_0054:
					if (!eventArgs1_1.bool_1)
					{
						((Control)button_1).set_Enabled(false);
						if (((Control)button_0).get_CanFocus())
						{
							num = 3;
							if (!evjUdQGBjmAWdreoZCk())
							{
								break;
							}
							goto IL_0096;
						}
					}
					goto IL_0148;
					IL_0148:
					((Control)textBox_0).set_Text(Class17.smethod_11("Email"));
					goto IL_015d;
					continue;
					end_IL_00e4:
					break;
				}
				continue;
				end_IL_00f2:
				break;
			}
		}
	}

	public Form0()
	{
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		IEnumerator enumerator = default(IEnumerator);
		while (true)
		{
			((Form)this)._002Ector();
			if (evjUdQGBjmAWdreoZCk())
			{
				switch (6)
				{
				case 0:
				case 1:
					break;
				case 6:
					Class17.smethod_44(this);
					((Form)this).set_Size(new Size(419, 264));
					((Form)this).set_MinimizeBox(false);
					goto case 2;
				case 2:
					((Form)this).set_MaximizeBox(false);
					((Control)panel_0).set_Location(Point.Empty);
					((Control)panel_0).set_Dock((DockStyle)5);
					((Control)button_4).set_Location(((Control)button_3).get_Location());
					goto case 3;
				case 3:
					((Control)button_4).set_Size(((Control)button_3).get_Size());
					goto default;
				default:
					((Control)button_4).BringToFront();
					((Control)panel_1).set_Location(Point.Empty);
					goto IL_00d0;
				case 5:
					goto IL_00d0;
				case 8:
					goto end_IL_0001;
				}
				continue;
			}
			goto IL_00d0;
			IL_00d0:
			((Control)panel_1).set_Dock((DockStyle)5);
			((Control)this).set_Text(Class17.smethod_121(((Control)this).get_Text(), this));
			((Control)panel_2).set_Location(Point.Empty);
			((Control)panel_2).set_Dock((DockStyle)5);
			enumerator = ((ArrangedElementCollection)((Control)this).get_Controls()).GetEnumerator();
			break;
			continue;
			end_IL_0001:
			break;
		}
		try
		{
			while (enumerator.MoveNext())
			{
				Control val = (Control)enumerator.Current;
				val.set_Text(Class17.smethod_121(val.get_Text(), this));
				foreach (Control item in (ArrangedElementCollection)val.get_Controls())
				{
					Control val2 = item;
					val2.set_Text(Class17.smethod_121(val2.get_Text(), this));
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
			((Control)this).Invoke((Delegate)new Delegate14(method_7), new object[2] { sender, e });
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
		while (thread_0 != null)
		{
			if (!evjUdQGBjmAWdreoZCk())
			{
				return;
			}
			switch (3)
			{
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

	private void method_7(object sender, EventArgs3 e)
	{
		Button val = default(Button);
		Enum1 enum1_ = default(Enum1);
		Control0 control = default(Control0);
		string string_ = default(string);
		while (true)
		{
			if (bool_0)
			{
				int num = 2;
				if (!evjUdQGBjmAWdreoZCk())
				{
					return;
				}
				while (true)
				{
					switch (num)
					{
					default:
						num = 10;
						if (!o5yAc6GqAASM8i0qTZ8())
						{
							continue;
						}
						return;
					case 0:
					case 8:
						break;
					case 2:
						goto IL_006b;
					case 1:
						goto IL_008d;
					case 9:
						return;
					case 4:
					case 11:
						goto IL_00b5;
					case 6:
						goto IL_00bc;
					case 10:
						return;
					case 7:
						return;
					case 5:
						goto IL_014a;
					case 3:
						goto end_IL_0058;
					case 12:
						return;
					}
					break;
				}
				continue;
			}
			goto IL_007f;
			IL_014a:
			((Control)val).set_Visible(true);
			((Control)val).Focus();
			return;
			IL_00b5:
			string_ = e.string_0;
			goto IL_00bc;
			IL_006b:
			if (Thread.CurrentThread.ApartmentState != 0)
			{
				goto IL_007f;
			}
			Button obj = button_8;
			goto IL_0085;
			IL_00de:
			if (e.bool_0)
			{
				control = control0_1;
				string_ = e.string_0;
				Class17.smethod_177(string_, control);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class17.smethod_32(control0_0);
				Class17.smethod_71(control0_1);
			}
			return;
			IL_007f:
			obj = button_4;
			goto IL_0085;
			IL_0085:
			val = obj;
			enum1_ = e.enum1_0;
			goto IL_008d;
			IL_008d:
			switch (enum1_)
			{
			default:
				return;
			case Enum1.const_0:
				break;
			case Enum1.const_1:
				goto IL_00de;
			case Enum1.const_2:
				goto IL_0121;
			case Enum1.const_3:
				goto IL_017c;
			}
			if (e.bool_0)
			{
				control = control0_0;
				goto IL_00b5;
			}
			Class17.smethod_71(control0_0);
			return;
			IL_017c:
			((Control)control3_0).set_Visible(false);
			Class17.smethod_32(control0_2);
			Class17.smethod_32(control0_3);
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			break;
			IL_0121:
			if (e.bool_0)
			{
				((Control)control3_0).set_Visible(false);
				control = control0_2;
				string_ = e.string_0;
				Class17.smethod_177(string_, control);
				goto IL_014a;
			}
			Class17.smethod_32(control0_1);
			Class17.smethod_71(control0_2);
			((Control)control3_0).set_Visible(true);
			return;
			IL_00bc:
			Class17.smethod_177(string_, control);
			((Control)val).set_Visible(true);
			((Control)val).Focus();
			return;
			continue;
			end_IL_0058:
			break;
		}
		((Control)button_2).set_Enabled(false);
	}

	private void method_8(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_9(object sender, EventArgs e)
	{
		bool_0 = true;
		((Control)button_4).set_Visible(false);
		Class17.smethod_8(control0_0);
		Class17.smethod_8(control0_1);
		Class17.smethod_8(control0_2);
		if (eventArgs1_0 != null)
		{
			Class17.smethod_60(this, (ThreadStart)method_10);
		}
	}

	internal void method_10()
	{
		Class17.smethod_18(eventArgs1_0);
	}

	internal void method_11(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class17.smethod_60(this, (ThreadStart)eventArgs1_0.method_0);
		}
	}

	internal void method_12(object sender, EventArgs e)
	{
		while (true)
		{
			int num;
			if (!checkBox_1.get_Checked())
			{
				num = 4;
				if (!o5yAc6GqAASM8i0qTZ8())
				{
					goto IL_0012;
				}
				goto IL_0035;
			}
			goto IL_0073;
			IL_003d:
			EventArgs1 eventArgs = eventArgs1_0;
			string string_ = "Email";
			string text = ((Control)textBox_0).get_Text();
			Class17.smethod_117(text, eventArgs, string_);
			Class17.smethod_54("Email", ((Control)textBox_0).get_Text());
			goto IL_0073;
			IL_0073:
			Class17.smethod_78(this);
			num = 6;
			if (o5yAc6GqAASM8i0qTZ8())
			{
				break;
			}
			goto IL_0012;
			IL_0012:
			switch (num)
			{
			case 4:
				break;
			case 2:
			case 5:
				goto IL_003d;
			default:
				goto IL_0073;
			case 0:
			case 3:
				continue;
			case 6:
				return;
			}
			goto IL_0035;
			IL_0035:
			if (eventArgs1_0 != null)
			{
				goto IL_003d;
			}
			goto IL_0073;
		}
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
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_DefaultExt("saencryptedreport");
		((FileDialog)val).set_Filter("SmartAssembly Exception Report|*.saencryptedreport|All files|*.*");
		((FileDialog)val).set_Title("Save an Exception Report");
		if ((int)((CommonDialog)val).ShowDialog((IWin32Window)(object)this) != 2)
		{
			if (Class17.smethod_3(eventArgs1_0, ((FileDialog)val).get_FileName()))
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

	internal static bool evjUdQGBjmAWdreoZCk()
	{
		return true;
	}

	internal static bool o5yAc6GqAASM8i0qTZ8()
	{
		return false;
	}
}
