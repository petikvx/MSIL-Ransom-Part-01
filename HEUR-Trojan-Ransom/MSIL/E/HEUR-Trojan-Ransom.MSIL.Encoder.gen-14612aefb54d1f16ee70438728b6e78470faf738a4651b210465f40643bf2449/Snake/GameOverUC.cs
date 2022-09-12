using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake;

public class GameOverUC : UserControl
{
	private IContainer components = null;

	private Button btn_Home;

	private Button btn_PlayAgain;

	private PictureBox img_Snake;

	private Label label1;

	private Label lbl_GameOver;

	public mainForm homeForm { get; set; }

	public GameOverUC()
	{
		InitializeComponent();
	}

	private void btn_PlayAgain_Click(object sender, EventArgs e)
	{
		((Control)homeForm).Show();
		homeForm.SnekGame();
	}

	private void btn_Home_Click(object sender, EventArgs e)
	{
		((Control)homeForm).Show();
		homeForm.Home();
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
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_0081: Expected O, but got Unknown
		//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_0149: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0293: Unknown result type (might be due to invalid IL or missing references)
		//IL_029d: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_033b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0345: Expected O, but got Unknown
		//IL_0379: Unknown result type (might be due to invalid IL or missing references)
		//IL_0448: Unknown result type (might be due to invalid IL or missing references)
		btn_Home = new Button();
		btn_PlayAgain = new Button();
		img_Snake = new PictureBox();
		label1 = new Label();
		lbl_GameOver = new Label();
		((ISupportInitialize)img_Snake).BeginInit();
		((Control)this).SuspendLayout();
		((Control)btn_Home).set_AutoSize(true);
		((Control)btn_Home).set_BackColor(Color.Firebrick);
		((Control)btn_Home).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_Home).set_ForeColor(Color.Black);
		((Control)btn_Home).set_Location(new System.Drawing.Point(211, 610));
		((Control)btn_Home).set_Margin(new Padding(2, 2, 2, 2));
		((Control)btn_Home).set_Name("btn_Home");
		((Control)btn_Home).set_Size(new Size(199, 75));
		((Control)btn_Home).set_TabIndex(10);
		((Control)btn_Home).set_Text("Home");
		((ButtonBase)btn_Home).set_UseVisualStyleBackColor(false);
		((Control)btn_Home).add_Click((EventHandler)btn_Home_Click);
		((Control)btn_PlayAgain).set_BackColor(Color.Firebrick);
		((Control)btn_PlayAgain).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_PlayAgain).set_ForeColor(Color.Black);
		((Control)btn_PlayAgain).set_Location(new System.Drawing.Point(802, 610));
		((Control)btn_PlayAgain).set_Margin(new Padding(2, 2, 2, 2));
		((Control)btn_PlayAgain).set_Name("btn_PlayAgain");
		((Control)btn_PlayAgain).set_Size(new Size(199, 75));
		((Control)btn_PlayAgain).set_TabIndex(9);
		((Control)btn_PlayAgain).set_Text("Play Again");
		((ButtonBase)btn_PlayAgain).set_UseVisualStyleBackColor(false);
		((Control)btn_PlayAgain).add_Click((EventHandler)btn_PlayAgain_Click);
		((Control)img_Snake).set_Location(new System.Drawing.Point(442, 273));
		((Control)img_Snake).set_Margin(new Padding(2, 2, 2, 2));
		((Control)img_Snake).set_Name("img_Snake");
		((Control)img_Snake).set_Size(new Size(326, 412));
		img_Snake.set_SizeMode((PictureBoxSizeMode)1);
		img_Snake.set_TabIndex(8);
		img_Snake.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 48f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.DarkRed);
		((Control)label1).set_Location(new System.Drawing.Point(285, 63));
		((Control)label1).set_Margin(new Padding(2, 0, 2, 0));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(663, 108));
		((Control)label1).set_TabIndex(11);
		((Control)label1).set_Text("GAME OVER!");
		((Control)lbl_GameOver).set_AutoSize(true);
		((Control)lbl_GameOver).set_Font(new Font("Microsoft Sans Serif", 16f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)lbl_GameOver).set_ForeColor(Color.DarkRed);
		((Control)lbl_GameOver).set_Location(new System.Drawing.Point(204, 200));
		((Control)lbl_GameOver).set_Margin(new Padding(2, 0, 2, 0));
		((Control)lbl_GameOver).set_Name("lbl_GameOver");
		((Control)lbl_GameOver).set_Size(new Size(797, 37));
		((Control)lbl_GameOver).set_TabIndex(12);
		((Control)lbl_GameOver).set_Text("OUCHY! (You have Collided with a wall or yourself)");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(9f, 20f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).get_Controls().Add((Control)(object)lbl_GameOver);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)btn_Home);
		((Control)this).get_Controls().Add((Control)(object)btn_PlayAgain);
		((Control)this).get_Controls().Add((Control)(object)img_Snake);
		((Control)this).set_Margin(new Padding(2, 2, 2, 2));
		((Control)this).set_Name("GameOverUC");
		((Control)this).set_Size(new Size(1234, 745));
		((ISupportInitialize)img_Snake).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
