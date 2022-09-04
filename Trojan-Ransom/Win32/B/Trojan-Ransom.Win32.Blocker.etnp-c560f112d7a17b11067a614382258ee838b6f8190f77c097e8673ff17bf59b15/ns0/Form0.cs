using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ns0;

internal sealed class Form0 : Form
{
	private EventArgs1 eventArgs1_0;

	private Thread thread_0;

	private CheckBox checkBox_0 = new CheckBox();

	private Label label_0 = new Label();

	private Button button_0 = new Button();

	private Button button_1 = new Button();

	private Label label_1 = new Label();

	private Class30 class30_0 = new Class30();

	private Panel panel_0 = new Panel();

	private Panel panel_1 = new Panel();

	private Button button_2 = new Button();

	private Control3 control3_0 = new Control3();

	private Control0 control0_0 = new Control0(Class5.smethod_0(83284));

	private Control0 control0_1 = new Control0(Class5.smethod_0(83321));

	private Control0 control0_2 = new Control0(Class5.smethod_0(83350));

	private Control0 control0_3 = new Control0(Class5.smethod_0(83379));

	private Button button_3 = new Button();

	private Button button_4 = new Button();

	private Button button_5 = new Button();

	private Control1 control1_0 = new Control1(string.Format(Class5.smethod_0(83432), Class5.smethod_0(81401)));

	private Control1 control1_1 = new Control1(string.Format(Class5.smethod_0(83521), Class5.smethod_0(81401), Class5.smethod_0(82827)));

	private Control2 control2_0 = new Control2();

	private Button button_6 = new Button();

	private bool bool_0;

	public Form0(Class31 CO_, EventArgs1 CO_)
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
		method_0();
		int height = ((Control)this).get_Height();
		eventArgs1_0 = CO_;
		((Control)class30_0).set_Text(CO_.method_0().Message);
		height += ((Control)class30_0).get_Height() - ((Control)this).get_FontHeight();
		if (!CO_.method_3())
		{
			((Control)checkBox_0).set_Visible(false);
			height -= ((Control)checkBox_0).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (CO_.method_1())
		{
			CO_.method_0(method_3);
			((Control)button_6).set_Visible(true);
			if (((Control)button_6).get_Left() < ((Control)control2_0).get_Right())
			{
				((Control)control2_0).set_Visible(false);
			}
		}
		if (!CO_.method_2())
		{
			((Control)button_1).set_Enabled(false);
			if (((Control)button_0).get_CanFocus())
			{
				((Control)button_0).Focus();
			}
		}
		CO_.method_1(method_2);
	}

	private void method_0()
	{
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f1: Expected O, but got Unknown
		((Control)panel_0).SuspendLayout();
		((Control)panel_1).SuspendLayout();
		if (0 == 0)
		{
			((Control)this).SuspendLayout();
		}
		control1_0.method_0(Enum1.const_1);
		control1_1.method_0(Enum1.const_1);
		((Control)checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)checkBox_0).set_Location(new Point(22, 98));
		((Control)checkBox_0).set_Size(new Size(226, 16));
		((Control)checkBox_0).set_TabIndex(13);
		((Control)checkBox_0).set_Text(Class5.smethod_0(82688));
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((Control)label_0).set_Anchor((AnchorStyles)14);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Font(new Font(Class5.smethod_0(82749), 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(20, 124));
		((Control)label_0).set_Size(new Size(381, 16));
		((Control)label_0).set_Text(string.Format(Class5.smethod_0(82778), Class5.smethod_0(82827)));
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(75, 24));
		((Control)button_0).set_Location(new Point(400 - ((Control)button_0).get_Width(), 205));
		((Control)button_0).set_TabIndex(4);
		((Control)button_0).set_Text(Class5.smethod_0(82852));
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(105, 24));
		((Control)button_1).set_Location(new Point(((Control)button_0).get_Left() - ((Control)button_1).get_Width() - 6, 205));
		((Control)button_1).set_TabIndex(3);
		((Control)button_1).set_Text(Class5.smethod_0(82869));
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_6).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_6).set_FlatStyle((FlatStyle)3);
		((Control)button_6).set_Size(new Size(64, 24));
		((Control)button_6).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_6).get_Width() - 6, 205));
		((Control)button_6).set_TabIndex(14);
		((Control)button_6).set_Text(Class5.smethod_0(82894));
		((Control)button_6).set_Visible(false);
		((Control)button_6).add_Click((EventHandler)button_6_Click);
		((Control)label_1).set_Anchor((AnchorStyles)14);
		label_1.set_FlatStyle((FlatStyle)3);
		((Control)label_1).set_Location(new Point(20, 140));
		((Control)label_1).set_Size(new Size(381, 55));
		((Control)label_1).set_Text(string.Format(Class5.smethod_0(82903), Class5.smethod_0(82827)));
		((Control)class30_0).set_Anchor((AnchorStyles)13);
		((Control)class30_0).set_Location(new Point(20, 69));
		((Control)class30_0).set_Size(new Size(381, 13));
		((Control)button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)3);
		if (uint.MaxValue != 0)
		{
			((Control)button_2).set_Size(new Size(80, 24));
			((Control)button_2).set_Location(new Point(400 - ((Control)button_2).get_Width(), 205));
			((Control)button_2).set_TabIndex(7);
			((Control)button_2).set_Text(Class5.smethod_0(83113));
			((Control)button_2).add_Click((EventHandler)button_2_Click);
			((Control)button_3).set_Anchor((AnchorStyles)10);
			((Control)button_3).set_Enabled(false);
			((ButtonBase)button_3).set_FlatStyle((FlatStyle)3);
			((Control)button_3).set_Size(new Size(105, 24));
			((Control)button_3).set_Location(new Point(((Control)button_2).get_Left() - ((Control)button_3).get_Width() - 6, 205));
			((Control)button_3).set_TabIndex(6);
			((Control)button_3).set_Text(Class5.smethod_0(83126));
			((Control)button_3).add_Click((EventHandler)button_3_Click);
			((Control)button_4).set_Anchor((AnchorStyles)10);
			((ButtonBase)button_4).set_FlatStyle((FlatStyle)3);
			((Control)button_4).set_Location(((Control)button_3).get_Location());
			((Control)button_4).set_Size(((Control)button_3).get_Size());
			((Control)button_4).set_TabIndex(5);
			((Control)button_4).set_Text(Class5.smethod_0(83131));
			((Control)button_4).set_Visible(false);
			((Control)button_4).add_Click((EventHandler)button_4_Click);
			((Control)button_5).set_Anchor((AnchorStyles)10);
			((ButtonBase)button_5).set_FlatStyle((FlatStyle)3);
			((Control)button_5).set_Location(((Control)button_3).get_Location());
			((Control)button_5).set_Size(((Control)button_3).get_Size());
			((Control)button_5).set_TabIndex(5);
			((Control)button_5).set_Text(Class5.smethod_0(83140));
			((Control)button_5).set_Visible(false);
			((Control)button_5).add_Click((EventHandler)button_5_Click);
			((Control)control3_0).set_Location(new Point(87, 146));
			((Control)control3_0).set_Visible(false);
			((Control)control0_0).SetBounds(24, 72, 368, 16);
			((Control)control0_1).SetBounds(24, 96, 368, 16);
			((Control)control0_2).SetBounds(24, 120, 368, 16);
			((Control)control0_3).SetBounds(24, 144, 368, 16);
			((Control)control2_0).set_Anchor((AnchorStyles)6);
			((Control)control2_0).SetBounds(20, 444, 120, 32);
			((Control)panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
			{
				(Control)button_6,
				(Control)checkBox_0,
				(Control)label_0,
				(Control)button_0,
				(Control)button_1,
				(Control)label_1,
				(Control)class30_0,
				control1_0
			});
			((Control)panel_0).set_Size(new Size(413, 240));
			((Control)panel_0).set_TabIndex(0);
			((Control)panel_1).get_Controls().AddRange((Control[])(object)new Control[10]
			{
				(Control)button_2,
				(Control)button_3,
				(Control)button_4,
				(Control)button_5,
				control3_0,
				control1_1,
				control0_0,
				control0_1,
				control0_2,
				control0_3
			});
			((Control)panel_1).set_Size(new Size(413, 240));
			((Control)panel_1).set_TabIndex(2);
			((Control)panel_1).set_Visible(false);
			((Form)this).set_AutoScaleBaseSize(new Size(5, 13));
			((Form)this).set_ClientSize(new Size(434, 488));
			((Form)this).set_ControlBox(false);
			((Control)this).get_Controls().AddRange((Control[])(object)new Control[3]
			{
				control2_0,
				(Control)panel_0,
				(Control)panel_1
			});
		}
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text(Class5.smethod_0(81401));
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text(Class5.smethod_0(83157));
		}
		try
		{
			((Form)this).set_TopMost(true);
		}
		catch
		{
		}
		((Control)panel_0).ResumeLayout(false);
		((Control)panel_1).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
		((Control)button_4).BringToFront();
		((Control)button_5).BringToFront();
		((Form)this).set_Size(new Size(419, 264));
		((Control)panel_1).set_Dock((DockStyle)5);
		((Control)panel_0).set_Dock((DockStyle)5);
	}

	private void button_5_Click(object sender, EventArgs e)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Title(Class5.smethod_0(83140));
		string defaultExt = Class5.smethod_0(83178);
		if (0 == 0)
		{
			((FileDialog)val).set_DefaultExt(defaultExt);
		}
		((FileDialog)val).set_Filter(Class5.smethod_0(83203));
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			eventArgs1_0.method_9(((FileDialog)val).get_FileName());
			((Form)this).Close();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			while (true)
			{
				if (2u != 0)
				{
					if (0 == 0)
					{
						Panel obj = panel_0;
						if (0 == 0)
						{
							((Control)obj).set_Visible(false);
						}
						if (7 == 0)
						{
							continue;
						}
						((Control)panel_1).set_Visible(true);
						goto IL_0028;
					}
					goto IL_003f;
				}
				goto IL_0051;
				IL_0051:
				if (uint.MaxValue != 0)
				{
					break;
				}
				goto IL_0028;
				IL_003f:
				method_1(method_6);
				goto IL_0051;
				IL_0028:
				((Control)control2_0).set_Visible(true);
				if (false || eventArgs1_0 != null)
				{
					goto IL_003f;
				}
				goto IL_0051;
			}
		}
		catch
		{
		}
	}

	private void method_1(ThreadStart CO_)
	{
		thread_0 = new Thread(CO_);
		thread_0.Start();
	}

	private void button_0_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_2_Click(object sender, EventArgs e)
	{
		try
		{
			if (false || thread_0 != null)
			{
				thread_0.Abort();
			}
		}
		catch
		{
		}
		do
		{
			((Form)this).Close();
		}
		while (false);
	}

	private void button_3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		eventArgs1_0.method_7(checkBox_0.get_Checked());
	}

	private void method_2(object sender, EventArgs3 e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new Delegate1(method_4), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	private void method_3(object sender, EventArgs e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new EventHandler(method_5), new object[2] { sender, e });
		}
		catch (InvalidOperationException)
		{
		}
	}

	protected override void OnClosing(CancelEventArgs e)
	{
		if (4 == 0)
		{
			return;
		}
		if (thread_0 != null && thread_0.IsAlive)
		{
			if (false)
			{
				return;
			}
			thread_0.Abort();
		}
		((Form)this).OnClosing(e);
	}

	private void method_4(object sender, EventArgs3 e)
	{
		Button val;
		if (2u != 0)
		{
			Button obj;
			if (bool_0 && Thread.CurrentThread.ApartmentState == ApartmentState.STA)
			{
				if (false)
				{
					goto IL_0074;
				}
				obj = button_5;
			}
			else
			{
				obj = button_4;
			}
			val = obj;
			switch (e.method_0())
			{
			default:
				return;
			case Enum0.const_0:
				break;
			case Enum0.const_1:
				goto IL_0080;
			case Enum0.const_2:
				goto IL_00bf;
			case Enum0.const_3:
				goto IL_00fe;
			}
			if (e.method_1())
			{
				control0_0.method_3(e.method_2());
				((Control)val).set_Visible(true);
				((Control)val).Focus();
				return;
			}
			goto IL_0074;
		}
		goto IL_015a;
		IL_00fe:
		((Control)control3_0).set_Visible(false);
		control0_2.method_2();
		control0_3.method_2();
		if (0 == 0)
		{
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			((Control)button_2).set_Enabled(false);
			return;
		}
		goto IL_0148;
		IL_015a:
		((Control)control3_0).set_Visible(true);
		return;
		IL_0148:
		((Control)val).set_Visible(true);
		if (0 == 0)
		{
			((Control)val).Focus();
			return;
		}
		goto IL_015a;
		IL_0080:
		if (e.method_1())
		{
			control0_1.method_3(e.method_2());
			((Control)val).set_Visible(true);
			((Control)val).Focus();
		}
		else
		{
			control0_0.method_2();
			control0_1.method_1();
		}
		return;
		IL_00bf:
		if (e.method_1())
		{
			((Control)control3_0).set_Visible(false);
			control0_2.method_3(e.method_2());
			goto IL_0148;
		}
		control0_1.method_2();
		control0_2.method_1();
		goto IL_015a;
		IL_0074:
		control0_0.method_1();
	}

	private void method_5(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		while (true)
		{
			bool_0 = true;
			while (true)
			{
				IL_0054:
				((Control)button_4).set_Visible(false);
				while (true)
				{
					control0_0.method_0();
					if (-1 == 0)
					{
						break;
					}
					control0_1.method_0();
					control0_2.method_0();
					while (0 == 0)
					{
						if (eventArgs1_0 != null)
						{
							if (false)
							{
								goto IL_0054;
							}
							method_1(method_6);
						}
						if (false)
						{
							continue;
						}
						goto IL_0062;
					}
					continue;
					IL_0062:
					if (1 == 0)
					{
						break;
					}
					return;
				}
				break;
			}
		}
	}

	private void method_6()
	{
		eventArgs1_0.method_10();
	}

	private void button_6_Click(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			method_1(eventArgs1_0.method_8);
		}
	}
}
