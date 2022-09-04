using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ns4;
using ns5;

namespace ns6;

internal class Form0 : Form
{
	private EventArgs1 eventArgs1_0;

	internal Thread thread_0;

	internal CheckBox checkBox_0;

	internal Label label_0;

	internal Button button_0;

	internal Button button_1;

	internal Label label_1;

	internal Class34 class34_0;

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
			EventArgs1 eventArgs = eventArgs1_0;
			string fileName = ((FileDialog)val).get_FileName();
			Class24.smethod_27(fileName, eventArgs);
			((Form)this).Close();
		}
	}

	internal void method_1(object sender, EventArgs e)
	{
		try
		{
			((Control)panel_0).set_Visible(false);
			((Control)panel_1).set_Visible(true);
			((Control)control2_0).set_Visible(true);
			if (eventArgs1_0 != null)
			{
				Class24.smethod_97((ThreadStart)method_11, this);
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
			((Control)this).Invoke((Delegate)new Delegate1(method_8), new object[2] { sender, e });
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
		if (thread_0 != null && thread_0.IsAlive)
		{
			thread_0.Abort();
		}
		((Form)this).OnClosing(e);
	}

	private void method_8(object sender, EventArgs3 e)
	{
		Button val = ((!bool_0 || Thread.CurrentThread.ApartmentState != 0) ? button_4 : button_5);
		switch (e.enum0_0)
		{
		case Enum0.const_0:
			if (e.bool_0)
			{
				Control0 control = control0_0;
				string string_ = e.string_0;
				Class24.smethod_121(string_, control);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class24.smethod_141(control0_0);
			}
			break;
		case Enum0.const_1:
			if (e.bool_0)
			{
				Control0 control = control0_1;
				string string_ = e.string_0;
				Class24.smethod_121(string_, control);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class24.smethod_61(control0_0);
				Class24.smethod_141(control0_1);
			}
			break;
		case Enum0.const_2:
			if (e.bool_0)
			{
				((Control)control3_0).set_Visible(false);
				Control0 control = control0_2;
				string string_ = e.string_0;
				Class24.smethod_121(string_, control);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class24.smethod_61(control0_1);
				Class24.smethod_141(control0_2);
				((Control)control3_0).set_Visible(true);
			}
			break;
		case Enum0.const_3:
			((Control)control3_0).set_Visible(false);
			Class24.smethod_61(control0_2);
			Class24.smethod_61(control0_3);
			((Control)button_3).set_Enabled(true);
			((Control)button_3).Focus();
			((Control)button_2).set_Enabled(false);
			break;
		}
	}

	private void method_9(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	internal void method_10(object sender, EventArgs e)
	{
		bool_0 = true;
		((Control)button_4).set_Visible(false);
		Class24.smethod_132(control0_0);
		Class24.smethod_132(control0_1);
		Class24.smethod_132(control0_2);
		if (eventArgs1_0 != null)
		{
			Class24.smethod_97((ThreadStart)method_11, this);
		}
	}

	private void method_11()
	{
		Class24.smethod_65(eventArgs1_0);
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class24.smethod_97((ThreadStart)eventArgs1_0.method_0, this);
		}
	}

	public Form0(Class35 class35_0, EventArgs1 eventArgs1_1)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Expected O, but got Unknown
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00be: Expected O, but got Unknown
		//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c9: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		Class42.hMqjKD0znI7T7();
		checkBox_0 = new CheckBox();
		label_0 = new Label();
		button_0 = new Button();
		button_1 = new Button();
		label_1 = new Label();
		class34_0 = new Class34();
		panel_0 = new Panel();
		panel_1 = new Panel();
		button_2 = new Button();
		control3_0 = new Control3();
		control0_0 = new Control0("Preparing the error report.");
		control0_1 = new Control0("Connecting to server.");
		control0_2 = new Control0("Transferring report.");
		control0_3 = new Control0("Error reporting completed. Thank you.");
		button_3 = new Button();
		button_4 = new Button();
		button_5 = new Button();
		control1_0 = new Control1(string.Format("{0} has encountered a problem.\nWe are sorry for the inconvenience.", "1234"));
		control1_1 = new Control1(string.Format("Please wait while {0} is sending the report to {1} through the Internet.", "1234", "[Unknown company]"));
		control2_0 = new Control2();
		button_6 = new Button();
		((Form)this)._002Ector();
		Class24.smethod_54(this);
		int height = ((Control)this).get_Height();
		eventArgs1_0 = eventArgs1_1;
		((Control)class34_0).set_Text(eventArgs1_1.exception_0.Message);
		height += ((Control)class34_0).get_Height() - ((Control)this).get_FontHeight();
		if (!eventArgs1_1.bool_2)
		{
			((Control)checkBox_0).set_Visible(false);
			height -= ((Control)checkBox_0).get_Height();
		}
		if (height > ((Control)this).get_Height())
		{
			((Control)this).set_Height(height);
		}
		if (eventArgs1_1.bool_0)
		{
			Class24.smethod_113(class35_0, (EventHandler)method_7);
			((Control)button_6).set_Visible(true);
			if (((Control)button_6).get_Left() < ((Control)control2_0).get_Right())
			{
				((Control)control2_0).set_Visible(false);
			}
		}
		if (!eventArgs1_1.bool_1)
		{
			((Control)button_1).set_Enabled(false);
			if (((Control)button_0).get_CanFocus())
			{
				((Control)button_0).Focus();
			}
		}
		Class24.smethod_87(class35_0, (Delegate1)method_6);
	}
}
