using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace snake;

public class Form1 : Form
{
	private IContainer components = null;

	private Label label1;

	private Button button1;

	private Button button2;

	public Form1(bool t)
	{
		InitializeComponent();
		if (t)
		{
			((Control)label1).set_Text("Congratulations, you won ! ! !\nNow what do you want to do?");
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void button2_Click(object sender, EventArgs e)
	{
		Application.Exit();
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
		//IL_0066: Unknown result type (might be due to invalid IL or missing references)
		//IL_0070: Expected O, but got Unknown
		//IL_0230: Unknown result type (might be due to invalid IL or missing references)
		//IL_023a: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		label1 = new Label();
		button1 = new Button();
		button2 = new Button();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_BackColor(Color.DarkRed);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)label1).set_Location(new Point(64, 33));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(185, 20));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("What do you want to do?");
		((Control)button1).set_BackColor(Color.DarkRed);
		((Control)button1).set_ForeColor(SystemColors.ControlLightLight);
		((Control)button1).set_Location(new Point(66, 78));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(60, 24));
		((Control)button1).set_TabIndex(1);
		((Control)button1).set_Text("Menu");
		((ButtonBase)button1).set_UseVisualStyleBackColor(false);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button2).set_BackColor(Color.DarkRed);
		((Control)button2).set_ForeColor(SystemColors.ControlLightLight);
		((Control)button2).set_Location(new Point(174, 78));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(61, 24));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Quit");
		((ButtonBase)button2).set_UseVisualStyleBackColor(false);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackgroundImage((Image)componentResourceManager.GetObject("$this.BackgroundImage"));
		((Form)this).set_ClientSize(new Size(319, 127));
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Perdu");
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
