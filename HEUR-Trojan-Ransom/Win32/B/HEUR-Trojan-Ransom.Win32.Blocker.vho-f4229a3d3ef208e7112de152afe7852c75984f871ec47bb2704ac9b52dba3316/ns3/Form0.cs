using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;
using ns0;
using ns2;
using ns5;
using ns6;
using ns8;

namespace ns3;

internal class Form0 : Form
{
	private EventArgs1 eventArgs1_0;

	internal Thread thread_0;

	internal CheckBox checkBox_0 = new CheckBox();

	internal Label label_0 = new Label();

	internal Button button_0 = new Button();

	internal Button button_1 = new Button();

	internal Label label_1 = new Label();

	internal Class35 class35_0 = new Class35();

	internal Panel panel_0 = new Panel();

	internal Panel panel_1 = new Panel();

	internal Button button_2 = new Button();

	internal Control3 control3_0 = new Control3();

	internal Control0 control0_0 = new Control0("Preparing the error report.");

	internal Control0 control0_1 = new Control0("Connecting to server.");

	internal Control0 control0_2 = new Control0("Transferring report.");

	internal Control0 control0_3 = new Control0("Error reporting completed. Thank you.");

	internal Button button_3 = new Button();

	internal Button button_4 = new Button();

	internal Button button_5 = new Button();

	internal Control1 control1_0 = new Control1(string.Format("{0} has encountered a problem.\nWe are sorry for the inconvenience.", "svchost"));

	internal Control1 control1_1 = new Control1(string.Format("Please wait while {0} is sending the report to {1} through the Internet.", "svchost", "[Unknown company]"));

	internal Control2 control2_0 = new Control2();

	internal Button button_6 = new Button();

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
			Class24.smethod_132(fileName, eventArgs);
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
				Class24.smethod_106((ThreadStart)method_11, this);
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
			((Control)this).Invoke((Delegate)new Delegate2(method_8), new object[2] { sender, e });
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
				Class24.smethod_85(control0_0, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class24.smethod_155(control0_0);
			}
			break;
		case Enum0.const_1:
			if (e.bool_0)
			{
				Class24.smethod_85(control0_1, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class24.smethod_141(control0_0);
				Class24.smethod_155(control0_1);
			}
			break;
		case Enum0.const_2:
			if (e.bool_0)
			{
				((Control)control3_0).set_Visible(false);
				Class24.smethod_85(control0_2, e.string_0);
				((Control)val).set_Visible(true);
				((Control)val).Focus();
			}
			else
			{
				Class24.smethod_141(control0_1);
				Class24.smethod_155(control0_2);
				((Control)control3_0).set_Visible(true);
			}
			break;
		case Enum0.const_3:
			((Control)control3_0).set_Visible(false);
			Class24.smethod_141(control0_2);
			Class24.smethod_141(control0_3);
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
		Class24.smethod_194(control0_0);
		Class24.smethod_194(control0_1);
		Class24.smethod_194(control0_2);
		if (eventArgs1_0 != null)
		{
			Class24.smethod_106((ThreadStart)method_11, this);
		}
	}

	private void method_11()
	{
		Class24.smethod_111(eventArgs1_0);
	}

	internal void method_12(object sender, EventArgs e)
	{
		if (eventArgs1_0 != null)
		{
			Class24.smethod_106((ThreadStart)eventArgs1_0.method_0, this);
		}
	}

	public Form0(Class36 class36_0, EventArgs1 eventArgs1_1)
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
		Class24.smethod_48(this);
		int height = ((Control)this).get_Height();
		eventArgs1_0 = eventArgs1_1;
		((Control)class35_0).set_Text(eventArgs1_1.exception_0.Message);
		height += ((Control)class35_0).get_Height() - ((Control)this).get_FontHeight();
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
			Class24.smethod_131((EventHandler)method_7, class36_0);
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
		Class24.smethod_60(class36_0, (Delegate2)method_6);
	}
}
