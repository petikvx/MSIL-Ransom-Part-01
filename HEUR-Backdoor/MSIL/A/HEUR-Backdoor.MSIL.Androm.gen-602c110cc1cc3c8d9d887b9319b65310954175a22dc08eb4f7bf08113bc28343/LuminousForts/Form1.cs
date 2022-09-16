using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using LuminousForts.Properties;

namespace LuminousForts;

public class Form1 : Form
{
	private IContainer components = null;

	private PictureBox headPictureBox;

	private PictureBox tailPictureBox;

	private Button headButton;

	private Button tailButton;

	private Button exitButton;

	public Form1()
	{
		InitializeComponent();
	}

	private void headButton_Click(object sender, EventArgs e)
	{
		((Control)headPictureBox).set_Visible(true);
		((Control)tailPictureBox).set_Visible(false);
	}

	private void tailButton_Click(object sender, EventArgs e)
	{
		((Control)headPictureBox).set_Visible(false);
		((Control)tailPictureBox).set_Visible(true);
	}

	private void exitButton_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
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
		//IL_0094: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0242: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e2: Expected O, but got Unknown
		//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		tailPictureBox = new PictureBox();
		headPictureBox = new PictureBox();
		headButton = new Button();
		tailButton = new Button();
		exitButton = new Button();
		((ISupportInitialize)tailPictureBox).BeginInit();
		((ISupportInitialize)headPictureBox).BeginInit();
		((Control)this).SuspendLayout();
		tailPictureBox.set_Image((Image)(object)Resources.free_trial);
		((Control)tailPictureBox).set_Location(new Point(723, 31));
		((Control)tailPictureBox).set_Margin(new Padding(8, 7, 8, 7));
		((Control)tailPictureBox).set_Name("tailPictureBox");
		((Control)tailPictureBox).set_Size(new Size(416, 365));
		tailPictureBox.set_SizeMode((PictureBoxSizeMode)4);
		tailPictureBox.set_TabIndex(1);
		tailPictureBox.set_TabStop(false);
		((Control)tailPictureBox).set_Visible(false);
		headPictureBox.set_Image((Image)(object)Resources.free_trial);
		((Control)headPictureBox).set_Location(new Point(35, 31));
		((Control)headPictureBox).set_Margin(new Padding(8, 7, 8, 7));
		((Control)headPictureBox).set_Name("headPictureBox");
		((Control)headPictureBox).set_Size(new Size(413, 365));
		headPictureBox.set_SizeMode((PictureBoxSizeMode)4);
		headPictureBox.set_TabIndex(0);
		headPictureBox.set_TabStop(false);
		((Control)headPictureBox).set_Visible(false);
		((Control)headButton).set_Location(new Point(141, 465));
		((Control)headButton).set_Margin(new Padding(8, 7, 8, 7));
		((Control)headButton).set_Name("headButton");
		((Control)headButton).set_Size(new Size(200, 100));
		((Control)headButton).set_TabIndex(2);
		((Control)headButton).set_Text("Show &Heads");
		((ButtonBase)headButton).set_UseVisualStyleBackColor(true);
		((Control)headButton).add_Click((EventHandler)headButton_Click);
		((Control)tailButton).set_Location(new Point(483, 465));
		((Control)tailButton).set_Margin(new Padding(8, 7, 8, 7));
		((Control)tailButton).set_Name("tailButton");
		((Control)tailButton).set_Size(new Size(200, 100));
		((Control)tailButton).set_TabIndex(3);
		((Control)tailButton).set_Text("Show &Tails");
		((ButtonBase)tailButton).set_UseVisualStyleBackColor(true);
		((Control)tailButton).add_Click((EventHandler)tailButton_Click);
		((Control)exitButton).set_Location(new Point(843, 465));
		((Control)exitButton).set_Margin(new Padding(8, 7, 8, 7));
		((Control)exitButton).set_Name("exitButton");
		((Control)exitButton).set_Size(new Size(200, 100));
		((Control)exitButton).set_TabIndex(4);
		((Control)exitButton).set_Text("&Exit");
		((ButtonBase)exitButton).set_UseVisualStyleBackColor(true);
		((Control)exitButton).add_Click((EventHandler)exitButton_Click);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(16f, 31f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(1141, 625));
		((Control)this).get_Controls().Add((Control)(object)exitButton);
		((Control)this).get_Controls().Add((Control)(object)tailButton);
		((Control)this).get_Controls().Add((Control)(object)headButton);
		((Control)this).get_Controls().Add((Control)(object)tailPictureBox);
		((Control)this).get_Controls().Add((Control)(object)headPictureBox);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(8, 7, 8, 7));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Heads or Tails");
		((ISupportInitialize)tailPictureBox).EndInit();
		((ISupportInitialize)headPictureBox).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
