using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1;

public class Form3 : Form
{
	internal static string variableCompartida;

	private IContainer components = null;

	private Button button1;

	private Button button2;

	private Button button3;

	private Button button4;

	public Form3()
	{
		InitializeComponent();
	}

	private void Form3_FormClosing(object sender, FormClosingEventArgs e)
	{
	}

	private void Form3_Load(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		variableCompartida = "español";
		((Control)this).set_Text("idioma");
	}

	private void button2_Click(object sender, EventArgs e)
	{
		variableCompartida = "ingles";
		((Control)this).set_Text("language");
	}

	private void button3_Click(object sender, EventArgs e)
	{
		variableCompartida = "chino";
		((Control)this).set_Text("中文");
	}

	private void button4_Click(object sender, EventArgs e)
	{
		variableCompartida = "ruso";
		((Control)this).set_Text("язык");
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_036e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0378: Expected O, but got Unknown
		button1 = new Button();
		button2 = new Button();
		button3 = new Button();
		button4 = new Button();
		((Control)this).SuspendLayout();
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Red);
		((Control)button1).set_Location(new Point(12, 12));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(159, 83));
		((Control)button1).set_TabIndex(17);
		((Control)button1).set_Text("Español");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_ForeColor(Color.Red);
		((Control)button2).set_Location(new Point(336, 12));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(159, 83));
		((Control)button2).set_TabIndex(18);
		((Control)button2).set_Text("English");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_ForeColor(Color.Red);
		((Control)button3).set_Location(new Point(12, 123));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(159, 83));
		((Control)button3).set_TabIndex(19);
		((Control)button3).set_Text("中国语");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_ForeColor(Color.Red);
		((Control)button4).set_Location(new Point(336, 123));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Size(new Size(159, 83));
		((Control)button4).set_TabIndex(20);
		((Control)button4).set_Text("Русский");
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(523, 232));
		((Control)this).get_Controls().Add((Control)(object)button4);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).set_ForeColor(Color.Red);
		((Form)this).set_FormBorderStyle((FormBorderStyle)3);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form3");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("language");
		((Form)this).set_TopMost(true);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form3_FormClosing));
		((Form)this).add_Load((EventHandler)Form3_Load);
		((Control)this).ResumeLayout(false);
	}
}
