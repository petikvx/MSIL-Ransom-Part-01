using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace KalinCheat;

public class Form2 : Form
{
	private IContainer components = null;

	private GroupBox groupBox1;

	private TextBox textBox1;

	private Label label1;

	private Timer timer1;

	private ProgressBar progressBar1;

	public Form2()
	{
		InitializeComponent();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
	}

	private void textBox1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		if ((int)e.get_KeyCode() == 13 && ((Control)textBox1).get_Text() == "Darst_100")
		{
			((Form)this).Close();
		}
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		progressBar1.Increment(1);
		if (progressBar1.get_Value() == 100)
		{
			timer1.set_Enabled(false);
		}
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
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0033: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		components = new Container();
		groupBox1 = new GroupBox();
		textBox1 = new TextBox();
		label1 = new Label();
		timer1 = new Timer(components);
		progressBar1 = new ProgressBar();
		((Control)groupBox1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)groupBox1).get_Controls().Add((Control)(object)textBox1);
		((Control)groupBox1).set_ForeColor(Color.Green);
		((Control)groupBox1).set_Location(new Point(12, 66));
		((Control)groupBox1).set_Name("groupBox1");
		((Control)groupBox1).set_Size(new Size(290, 42));
		((Control)groupBox1).set_TabIndex(0);
		groupBox1.set_TabStop(false);
		((Control)groupBox1).set_Text("Веди команду для отмены");
		((Control)textBox1).set_ForeColor(Color.Green);
		((Control)textBox1).set_Location(new Point(6, 16));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(278, 20));
		((Control)textBox1).set_TabIndex(1);
		((Control)textBox1).add_KeyDown(new KeyEventHandler(textBox1_KeyDown));
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15.75f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)label1).set_ForeColor(Color.Green);
		((Control)label1).set_Location(new Point(7, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(297, 25));
		((Control)label1).set_TabIndex(1);
		((Control)label1).set_Text("Идет удаление Windows...");
		timer1.set_Enabled(true);
		timer1.set_Interval(300000);
		timer1.add_Tick((EventHandler)timer1_Tick);
		((Control)progressBar1).set_Location(new Point(12, 37));
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(290, 23));
		((Control)progressBar1).set_TabIndex(2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(314, 119));
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)groupBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)groupBox1).ResumeLayout(false);
		((Control)groupBox1).PerformLayout();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
