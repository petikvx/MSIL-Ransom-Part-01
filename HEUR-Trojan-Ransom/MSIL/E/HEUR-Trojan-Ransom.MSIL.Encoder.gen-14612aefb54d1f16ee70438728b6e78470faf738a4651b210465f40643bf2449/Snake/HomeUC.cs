using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake;

public class HomeUC : UserControl
{
	private IContainer components = null;

	private Button btn_Tutorial;

	private Button btn_Play;

	private PictureBox img_SnakeTitle;

	private PictureBox img_Snake;

	public mainForm homeForm { get; set; }

	public HomeUC()
	{
		InitializeComponent();
	}

	private void btn_Play_Click(object sender, EventArgs e)
	{
		((Control)homeForm).Show();
		homeForm.SnekGame();
	}

	private void btn_Tutorial_Click(object sender, EventArgs e)
	{
		((Control)homeForm).Show();
		homeForm.Tutorial();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((ContainerControl)this).Dispose(disposing);
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
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0148: Unknown result type (might be due to invalid IL or missing references)
		//IL_0152: Expected O, but got Unknown
		//IL_0186: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_035b: Unknown result type (might be due to invalid IL or missing references)
		btn_Tutorial = new Button();
		btn_Play = new Button();
		img_SnakeTitle = new PictureBox();
		img_Snake = new PictureBox();
		((ISupportInitialize)img_SnakeTitle).BeginInit();
		((ISupportInitialize)img_Snake).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btn_Tutorial).set_AutoSize(true);
		((Control)btn_Tutorial).set_BackColor(Color.Firebrick);
		((Control)btn_Tutorial).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_Tutorial).set_ForeColor(Color.Black);
		((Control)btn_Tutorial).set_Location(new System.Drawing.Point(285, 617));
		((Control)btn_Tutorial).set_Margin(new Padding(2, 2, 2, 2));
		((Control)btn_Tutorial).set_Name("btn_Tutorial");
		((Control)btn_Tutorial).set_Size(new Size(151, 75));
		((Control)btn_Tutorial).set_TabIndex(7);
		((Control)btn_Tutorial).set_Text("Tutorial");
		((ButtonBase)btn_Tutorial).set_UseVisualStyleBackColor(false);
		((Control)btn_Tutorial).add_Click((EventHandler)btn_Tutorial_Click);
		((Control)btn_Play).set_BackColor(Color.Firebrick);
		((Control)btn_Play).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_Play).set_ForeColor(Color.Black);
		((Control)btn_Play).set_Location(new System.Drawing.Point(799, 617));
		((Control)btn_Play).set_Margin(new Padding(2, 2, 2, 2));
		((Control)btn_Play).set_Name("btn_Play");
		((Control)btn_Play).set_Size(new Size(151, 75));
		((Control)btn_Play).set_TabIndex(6);
		((Control)btn_Play).set_Text("Play");
		((ButtonBase)btn_Play).set_UseVisualStyleBackColor(false);
		((Control)btn_Play).add_Click((EventHandler)btn_Play_Click);
		((Control)img_SnakeTitle).set_Location(new System.Drawing.Point(351, 38));
		((Control)img_SnakeTitle).set_Margin(new Padding(2, 2, 2, 2));
		((Control)img_SnakeTitle).set_Name("img_SnakeTitle");
		((Control)img_SnakeTitle).set_Size(new Size(528, 252));
		img_SnakeTitle.set_SizeMode((PictureBoxSizeMode)1);
		img_SnakeTitle.set_TabIndex(5);
		img_SnakeTitle.set_TabStop(false);
		((Control)img_Snake).set_Location(new System.Drawing.Point(455, 294));
		((Control)img_Snake).set_Margin(new Padding(2, 2, 2, 2));
		((Control)img_Snake).set_Name("img_Snake");
		((Control)img_Snake).set_Size(new Size(326, 412));
		img_Snake.set_SizeMode((PictureBoxSizeMode)1);
		img_Snake.set_TabIndex(4);
		img_Snake.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).get_Controls().Add((Control)(object)btn_Tutorial);
		((Control)this).get_Controls().Add((Control)(object)btn_Play);
		((Control)this).get_Controls().Add((Control)(object)img_SnakeTitle);
		((Control)this).get_Controls().Add((Control)(object)img_Snake);
		((Control)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("HomeUC");
		((Control)this).set_Size(new Size(1234, 745));
		((ISupportInitialize)img_SnakeTitle).EndInit();
		((ISupportInitialize)img_Snake).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
