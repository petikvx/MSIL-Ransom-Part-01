using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Snake;

public class TutorialUC : UserControl
{
	private IContainer components = null;

	private PictureBox img_SnakeTitle;

	private Label label1;

	private Button btn_Home;

	private Button btn_Play;

	public mainForm homeForm { get; set; }

	public TutorialUC()
	{
		InitializeComponent();
	}

	private void btn_Play_Click(object sender, EventArgs e)
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
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Expected O, but got Unknown
		//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ba: Expected O, but got Unknown
		label1 = new Label();
		btn_Home = new Button();
		btn_Play = new Button();
		img_SnakeTitle = new PictureBox();
		((ISupportInitialize)img_SnakeTitle).BeginInit();
		((Control)this).SuspendLayout();
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new System.Drawing.Point(177, 711));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(1562, 63));
		((Control)label1).set_TabIndex(7);
		((Control)label1).set_Text("Use WASD or the arrow keys to control direction of the snake.");
		((Control)btn_Home).set_AutoSize(true);
		((Control)btn_Home).set_BackColor(Color.Firebrick);
		((Control)btn_Home).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_Home).set_ForeColor(Color.Black);
		((Control)btn_Home).set_Location(new System.Drawing.Point(305, 876));
		((Control)btn_Home).set_Name("btn_Home");
		((Control)btn_Home).set_Size(new Size(500, 84));
		((Control)btn_Home).set_TabIndex(10);
		((Control)btn_Home).set_Text("Home");
		((ButtonBase)btn_Home).set_UseVisualStyleBackColor(false);
		((Control)btn_Home).add_Click((EventHandler)btn_Home_Click);
		((Control)btn_Play).set_BackColor(Color.Firebrick);
		((Control)btn_Play).set_Font(new Font("Microsoft Sans Serif", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btn_Play).set_ForeColor(Color.Black);
		((Control)btn_Play).set_Location(new System.Drawing.Point(1105, 876));
		((Control)btn_Play).set_Name("btn_Play");
		((Control)btn_Play).set_Size(new Size(500, 84));
		((Control)btn_Play).set_TabIndex(9);
		((Control)btn_Play).set_Text("Play");
		((ButtonBase)btn_Play).set_UseVisualStyleBackColor(false);
		((Control)btn_Play).add_Click((EventHandler)btn_Play_Click);
		((Control)img_SnakeTitle).set_Location(new System.Drawing.Point(156, 152));
		((Control)img_SnakeTitle).set_Name("img_SnakeTitle");
		((Control)img_SnakeTitle).set_Size(new Size(1595, 508));
		img_SnakeTitle.set_SizeMode((PictureBoxSizeMode)1);
		img_SnakeTitle.set_TabIndex(6);
		img_SnakeTitle.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(14f, 29f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(64, 64, 64));
		((Control)this).get_Controls().Add((Control)(object)btn_Home);
		((Control)this).get_Controls().Add((Control)(object)btn_Play);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)img_SnakeTitle);
		((Control)this).set_Name("TutorialUC");
		((Control)this).set_Size(new Size(1920, 1080));
		((ISupportInitialize)img_SnakeTitle).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
