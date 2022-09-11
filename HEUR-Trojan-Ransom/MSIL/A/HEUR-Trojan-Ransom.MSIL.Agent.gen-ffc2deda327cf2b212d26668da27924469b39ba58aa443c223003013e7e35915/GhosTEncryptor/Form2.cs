using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GhosTEncryptor;

public class Form2 : Form
{
	private string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

	private IContainer components;

	private Label label1;

	private Button button1;

	private Button button2;

	private TextBox textBox1;

	private Label label2;

	public Form2()
	{
		InitializeComponent();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		if (((Control)textBox1).get_Text() == "rLaeEMucHrUMCBZ")
		{
			((Form)new Form1()).ShowDialog();
			((Control)this).Hide();
			((Form)this).Close();
		}
		else
		{
			MessageBox.Show("Incorrect key! The application will now exit.");
			Application.Exit();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void Form2_Load(object sender, EventArgs e)
	{
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		label1 = new Label();
		button1 = new Button();
		button2 = new Button();
		textBox1 = new TextBox();
		label2 = new Label();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(87, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(336, 78));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text(componentResourceManager.GetString("label1.Text"));
		((Control)button1).set_Location(new Point(118, 132));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(113, 35));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Yes");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_Font(new Font("Microsoft Sans Serif", 9.75f, (FontStyle)5, (GraphicsUnit)3, (byte)238));
		((Control)button2).set_ForeColor(Color.Crimson);
		((Control)button2).set_Location(new Point(257, 132));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(113, 35));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("No");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)textBox1).set_Location(new Point(118, 106));
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(252, 20));
		((Control)textBox1).set_TabIndex(3);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(56, 109));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(56, 13));
		((Control)label2).set_TabIndex(4);
		((Control)label2).set_Text("Password:");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)0);
		((Form)this).set_ClientSize(new Size(507, 203));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form2");
		((Form)this).set_ShowIcon(false);
		((Control)this).set_Text("Warning!");
		((Form)this).add_Load((EventHandler)Form2_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
