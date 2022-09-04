using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using ns6;
using ns7;

namespace ns8;

internal class Form0 : Form
{
	private EventArgs2 eventArgs2_0;

	private Thread thread_0;

	private CheckBox checkBox_0 = new CheckBox();

	private Label label_0 = new Label();

	private Button button_0 = new Button();

	private Button button_1 = new Button();

	private Label label_1 = new Label();

	private Class51 class51_0 = new Class51();

	private Panel panel_0 = new Panel();

	private Panel panel_1 = new Panel();

	private Button button_2 = new Button();

	private Control3 control3_0 = new Control3();

	private Control0 control0_0 = new Control0("Preparing the error report.");

	private Control0 control0_1 = new Control0("Connecting to server.");

	private Control0 control0_2 = new Control0("Transferring report.");

	private Control0 control0_3 = new Control0("Error reporting completed. Thank you.");

	private Button button_3 = new Button();

	private Button button_4 = new Button();

	private Button button_5 = new Button();

	private Control1 control1_0 = new Control1(string.Format("{0} has encountered a problem.\nWe are sorry for the inconvenience.", "hfghfgmkhj"));

	private Control1 control1_1 = new Control1(string.Format("Please wait while {0} is sending the report to {1} through the Internet.", "hfghfgmkhj", "sdfsdsggggggghhhh"));

	private Control2 control2_0 = new Control2();

	private Button button_6 = new Button();

	private bool bool_0;

	private void method_0()
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)panel_0).SuspendLayout();
		((Control)panel_1).SuspendLayout();
		((Control)this).SuspendLayout();
		control1_0.method_0(Enum2.const_1);
		control1_1.method_0(Enum2.const_1);
		((Control)checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)checkBox_0).set_Location(new Point(22, 98));
		((Control)checkBox_0).set_Size(new Size(226, 16));
		((Control)checkBox_0).set_TabIndex(13);
		((Control)checkBox_0).set_Text("Ignore this error and attempt to &continue.");
		checkBox_0.add_CheckedChanged((EventHandler)checkBox_0_CheckedChanged);
		((Control)label_0).set_Anchor((AnchorStyles)14);
		label_0.set_FlatStyle((FlatStyle)3);
		((Control)label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label_0).set_Location(new Point(20, 124));
		((Control)label_0).set_Size(new Size(381, 16));
		((Control)label_0).set_Text(string.Format("Please tell {0} about this problem.", "sdfsdsggggggghhhh"));
		((Control)button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_0).set_FlatStyle((FlatStyle)3);
		((Control)button_0).set_Size(new Size(75, 24));
		((Control)button_0).set_Location(new Point(400 - ((Control)button_0).get_Width(), 205));
		((Control)button_0).set_TabIndex(4);
		((Control)button_0).set_Text("&Don't Send");
		((Control)button_0).add_Click((EventHandler)button_0_Click);
		((Control)button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_1).set_FlatStyle((FlatStyle)3);
		((Control)button_1).set_Size(new Size(105, 24));
		((Control)button_1).set_Location(new Point(((Control)button_0).get_Left() - ((Control)button_1).get_Width() - 6, 205));
		((Control)button_1).set_TabIndex(3);
		((Control)button_1).set_Text("&Send Error Report");
		((Control)button_1).add_Click((EventHandler)button_1_Click);
		((Control)button_6).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_6).set_FlatStyle((FlatStyle)3);
		((Control)button_6).set_Size(new Size(64, 24));
		((Control)button_6).set_Location(new Point(((Control)button_1).get_Left() - ((Control)button_6).get_Width() - 6, 205));
		((Control)button_6).set_TabIndex(14);
		((Control)button_6).set_Text("De&bug");
		((Control)button_6).set_Visible(false);
		((Control)button_6).add_Click((EventHandler)button_6_Click);
		((Control)label_1).set_Anchor((AnchorStyles)14);
		label_1.set_FlatStyle((FlatStyle)3);
		((Control)label_1).set_Location(new Point(20, 140));
		((Control)label_1).set_Size(new Size(381, 55));
		((Control)label_1).set_Text(string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "sdfsdsggggggghhhh"));
		((Control)class51_0).set_Anchor((AnchorStyles)13);
		((Control)class51_0).set_Location(new Point(20, 69));
		((Control)class51_0).set_Size(new Size(381, 13));
		((Control)button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_2).set_FlatStyle((FlatStyle)3);
		((Control)button_2).set_Size(new Size(80, 24));
		((Control)button_2).set_Location(new Point(400 - ((Control)button_2).get_Width(), 205));
		((Control)button_2).set_TabIndex(7);
		((Control)button_2).set_Text("&Cancel");
		((Control)button_2).add_Click((EventHandler)button_2_Click);
		((Control)button_3).set_Anchor((AnchorStyles)10);
		((Control)button_3).set_Enabled(false);
		((ButtonBase)button_3).set_FlatStyle((FlatStyle)3);
		((Control)button_3).set_Size(new Size(105, 24));
		((Control)button_3).set_Location(new Point(((Control)button_2).get_Left() - ((Control)button_3).get_Width() - 6, 205));
		((Control)button_3).set_TabIndex(6);
		((Control)button_3).set_Text("&OK");
		((Control)button_3).add_Click((EventHandler)button_3_Click);
		((Control)button_4).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_4).set_FlatStyle((FlatStyle)3);
		((Control)button_4).set_Location(((Control)button_3).get_Location());
		((Control)button_4).set_Size(((Control)button_3).get_Size());
		((Control)button_4).set_TabIndex(5);
		((Control)button_4).set_Text("&Retry");
		((Control)button_4).set_Visible(false);
		((Control)button_4).add_Click((EventHandler)button_4_Click);
		((Control)button_5).set_Anchor((AnchorStyles)10);
		((ButtonBase)button_5).set_FlatStyle((FlatStyle)3);
		((Control)button_5).set_Location(((Control)button_3).get_Location());
		((Control)button_5).set_Size(((Control)button_3).get_Size());
		((Control)button_5).set_TabIndex(5);
		((Control)button_5).set_Text("Save Report");
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
			(Control)class51_0,
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
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_MinimizeBox(false);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("hfghfgmkhj");
		if (((Control)this).get_Text().Length == 0)
		{
			((Control)this).set_Text("Error Reporting");
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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Invalid comparison between Unknown and I4
		SaveFileDialog val = new SaveFileDialog();
		((FileDialog)val).set_Title("Save Report");
		((FileDialog)val).set_DefaultExt("saencryptedreport");
		((FileDialog)val).set_Filter("SmartAssembly Encrypted Exception Report|*.saencryptedreport");
		if ((int)((CommonDialog)val).ShowDialog() == 1)
		{
			eventArgs2_0.method_9(((FileDialog)val).get_FileName());
			((Form)this).Close();
		}
	}

	private void button_1_Click(object sender, EventArgs e)
	{
		try
		{
			((Control)panel_0).set_Visible(false);
			((Control)panel_1).set_Visible(true);
			((Control)control2_0).set_Visible(true);
			if (eventArgs2_0 != null)
			{
				method_1(method_6);
			}
		}
		catch
		{
		}
	}

	private void method_1(ThreadStart threadStart_0)
	{
		thread_0 = new Thread(threadStart_0);
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

	private void button_3_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void checkBox_0_CheckedChanged(object sender, EventArgs e)
	{
		eventArgs2_0.method_7(checkBox_0.get_Checked());
	}

	private void method_2(object sender, EventArgs4 e)
	{
		try
		{
			((Control)this).Invoke((Delegate)new Delegate3(method_4), new object[2] { sender, e });
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
		if (thread_0 != null && thread_0.IsAlive)
		{
			thread_0.Abort();
		}
		((Form)this).OnClosing(e);
	}

	private void method_4(object sender, EventArgs4 e)
	{
		Button val = ((!bool_0 || Thread.CurrentThread.ApartmentState != 0) ? button_4 : button_5);
		switch (e.method_0())
		{
		case Enum1.const_0:
			if (e.method_1())
			{
				control0_0.method_3(e.method_2());
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				control0_0.method_1();
			}
			break;
		case Enum1.const_1:
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
			break;
		case Enum1.const_2:
			if (e.method_1())
			{
				((Control)control3_0).set_Visible(false);
				control0_2.method_3(e.method_2());
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				control0_1.method_2();
				control0_2.method_1();
				((Control)control3_0).set_Visible(true);
			}
			break;
		case Enum1.const_3:
			((Control)control3_0).set_Visible(false);
			control0_2.method_2();
			control0_3.method_2();
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			((Control)button_2).set_Enabled(false);
			break;
		}
	}

	private void method_5(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button_4_Click(object sender, EventArgs e)
	{
		bool_0 = true;
		((Control)button_4).set_Visible(false);
		control0_0.method_0();
		control0_1.method_0();
		control0_2.method_0();
		if (eventArgs2_0 != null)
		{
			method_1(method_6);
		}
	}

	private void method_6()
	{
		eventArgs2_0.method_10();
	}

	private void button_6_Click(object sender, EventArgs e)
	{
		if (eventArgs2_0 != null)
		{
			method_1(eventArgs2_0.method_8);
		}
	}

	public Form0(Class52 class52_0, EventArgs2 eventArgs2_1)
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
		//IL_00af: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Expected O, but got Unknown
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c4: Expected O, but got Unknown
		//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cf: Expected O, but got Unknown
		//IL_0114: Unknown result type (might be due to invalid IL or missing references)
		//IL_011e: Expected O, but got Unknown
		method_0();
		int height = ((Control)this).get_Height();
		eventArgs2_0 = eventArgs2_1;
		((Control)class51_0).set_Text(eventArgs2_1.method_0().Message);
		height += ((Control)class51_0).get_Height() - ((Control)this).get_FontHeight();
		if (!eventArgs2_1.method_3())
		{
			((Control)checkBox_0).set_Visible(false);
			height -= ((Control)checkBox_0).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (eventArgs2_1.method_1())
		{
			class52_0.method_0(method_3);
			((Control)button_6).set_Visible(true);
			if (((Control)button_6).get_Left() < ((Control)control2_0).get_Right())
			{
				((Control)control2_0).set_Visible(false);
			}
		}
		if (!eventArgs2_1.method_2())
		{
			((Control)button_1).set_Enabled(false);
			if (((Control)button_0).get_CanFocus())
			{
				((Control)button_0).Focus();
			}
		}
		class52_0.method_1(method_2);
	}
}
