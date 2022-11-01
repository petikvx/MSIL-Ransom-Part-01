using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using Guna.UI2.WinForms;
using Microsoft.Win32;
using Siticone.UI.AnimatorNS;
using Siticone.UI.WinForms;

namespace YullySpoofer;

public class LoginForm : Form
{
	private int originalExStyle = -1;

	private bool enableFormLevelDoubleBuffering = true;

	private static Random random;

	private int clickCounter;

	private IContainer components;

	private SiticoneTransition siticoneTransition1;

	private GunaTextBox UserBox;

	private SiticoneShadowPanel siticoneShadowPanel1;

	private Label label1;

	private Label label3;

	private GunaTextBox PassBox;

	private Guna2Button LoginButton;

	private Label label2;

	protected override CreateParams CreateParams
	{
		get
		{
			if (originalExStyle == -1)
			{
				originalExStyle = ((Form)this).get_CreateParams().get_ExStyle();
			}
			CreateParams createParams = ((Form)this).get_CreateParams();
			if (!enableFormLevelDoubleBuffering)
			{
				createParams.set_ExStyle(originalExStyle);
			}
			else
			{
				CreateParams val = createParams;
				val.set_ExStyle(val.get_ExStyle() | 0x2000000);
			}
			return createParams;
		}
	}

	static LoginForm()
	{
		random = new Random();
	}

	public LoginForm()
	{
		InitializeComponent();
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	[DllImport("DwmApi")]
	private static extern int DwmSetWindowAttribute(IntPtr hwnd, int attr, int[] attrValue, int attrSize);

	private string GetCurrentWallpaper()
	{
		return Convert.ToString(Registry.CurrentUser.OpenSubKey("Control Panel")!.OpenSubKey("Desktop")!.GetValue("Wallpaper"));
	}

	public static Image GetUserimage()
	{
		return Image.FromFile(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "\\Microsoft\\User Account Pictures\\user.bmp");
	}

	[Obfuscation(Feature = "virtualize", Exclude = true)]
	private void InitializeComponent()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0037: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_0042: Expected O, but got Unknown
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0234: Unknown result type (might be due to invalid IL or missing references)
		//IL_023e: Expected O, but got Unknown
		//IL_041f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0429: Expected O, but got Unknown
		//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_04da: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_0852: Unknown result type (might be due to invalid IL or missing references)
		//IL_085c: Expected O, but got Unknown
		//IL_0961: Unknown result type (might be due to invalid IL or missing references)
		//IL_096b: Expected O, but got Unknown
		Animation val = new Animation();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LoginForm));
		siticoneTransition1 = new SiticoneTransition();
		UserBox = new GunaTextBox();
		siticoneShadowPanel1 = new SiticoneShadowPanel();
		label1 = new Label();
		label3 = new Label();
		PassBox = new GunaTextBox();
		label2 = new Label();
		LoginButton = new Guna2Button();
		((Control)siticoneShadowPanel1).SuspendLayout();
		((Control)this).SuspendLayout();
		((Animator)siticoneTransition1).set_Cursor((Cursor)null);
		val.set_AnimateOnlyDifferences(true);
		val.set_BlindCoeff((PointF)componentResourceManager.GetObject("animation6.BlindCoeff"));
		val.set_LeafCoeff(0f);
		val.set_MaxTime(1f);
		val.set_MinTime(0f);
		val.set_MosaicCoeff((PointF)componentResourceManager.GetObject("animation6.MosaicCoeff"));
		val.set_MosaicShift((PointF)componentResourceManager.GetObject("animation6.MosaicShift"));
		val.set_MosaicSize(0);
		val.set_Padding(new Padding(0, 0, 0, 0));
		val.set_RotateCoeff(0f);
		val.set_RotateLimit(0f);
		val.set_ScaleCoeff((PointF)componentResourceManager.GetObject("animation6.ScaleCoeff"));
		val.set_SlideCoeff((PointF)componentResourceManager.GetObject("animation6.SlideCoeff"));
		val.set_TimeCoeff(0f);
		val.set_TransparencyCoeff(0f);
		((Animator)siticoneTransition1).set_DefaultAnimation(val);
		((Control)UserBox).set_BackColor(Color.Transparent);
		UserBox.set_BaseColor(Color.FromArgb(14, 14, 14));
		UserBox.set_BorderColor(Color.FromArgb(128, 76, 146));
		UserBox.set_BorderSize(1);
		((Control)UserBox).set_Cursor(Cursors.get_IBeam());
		((Animator)siticoneTransition1).SetDecoration((Control)(object)UserBox, (DecorationType)0);
		UserBox.set_FocusedBaseColor(Color.FromArgb(14, 14, 14));
		UserBox.set_FocusedBorderColor(Color.FromArgb(133, 78, 148));
		UserBox.set_FocusedForeColor(Color.White);
		((Control)UserBox).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)UserBox).set_ForeColor(Color.FromArgb(93, 101, 111));
		((Control)UserBox).set_Location(new Point(34, 97));
		((Control)UserBox).set_Name("UserBox");
		UserBox.set_PasswordChar('\0');
		UserBox.set_Radius(2);
		UserBox.set_SelectedText("");
		((Control)UserBox).set_Size(new Size(336, 35));
		((Control)UserBox).set_TabIndex(25);
		((Control)UserBox).set_Text(" ");
		((Control)siticoneShadowPanel1).set_BackColor(Color.Transparent);
		((Control)siticoneShadowPanel1).get_Controls().Add((Control)(object)LoginButton);
		((Control)siticoneShadowPanel1).get_Controls().Add((Control)(object)UserBox);
		((Control)siticoneShadowPanel1).get_Controls().Add((Control)(object)label1);
		((Control)siticoneShadowPanel1).get_Controls().Add((Control)(object)label3);
		((Control)siticoneShadowPanel1).get_Controls().Add((Control)(object)PassBox);
		((Control)siticoneShadowPanel1).get_Controls().Add((Control)(object)label2);
		((Animator)siticoneTransition1).SetDecoration((Control)(object)siticoneShadowPanel1, (DecorationType)0);
		siticoneShadowPanel1.set_FillColor(Color.FromArgb(14, 14, 14));
		((Control)siticoneShadowPanel1).set_Location(new Point(132, 112));
		((Control)siticoneShadowPanel1).set_Name("siticoneShadowPanel1");
		siticoneShadowPanel1.set_ShadowColor(Color.Black);
		((Control)siticoneShadowPanel1).set_Size(new Size(398, 303));
		((Control)siticoneShadowPanel1).set_TabIndex(35);
		((Control)label1).set_AutoSize(true);
		((Animator)siticoneTransition1).SetDecoration((Control)(object)label1, (DecorationType)0);
		((Control)label1).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.FromArgb(183, 184, 190));
		((Control)label1).set_Location(new Point(23, 28));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(159, 17));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("LOGIN | YULLY SPOOFER");
		((Control)label3).set_AutoSize(true);
		((Animator)siticoneTransition1).SetDecoration((Control)(object)label3, (DecorationType)0);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_ForeColor(Color.FromArgb(158, 159, 168));
		((Control)label3).set_Location(new Point(30, 144));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(61, 15));
		((Control)label3).set_TabIndex(36);
		((Control)label3).set_Text("Password");
		((Control)PassBox).set_BackColor(Color.Transparent);
		PassBox.set_BaseColor(Color.FromArgb(14, 14, 14));
		PassBox.set_BorderColor(Color.FromArgb(128, 76, 146));
		PassBox.set_BorderSize(1);
		((Control)PassBox).set_Cursor(Cursors.get_IBeam());
		((Animator)siticoneTransition1).SetDecoration((Control)(object)PassBox, (DecorationType)0);
		PassBox.set_FocusedBaseColor(Color.FromArgb(14, 14, 14));
		PassBox.set_FocusedBorderColor(Color.FromArgb(133, 78, 148));
		PassBox.set_FocusedForeColor(Color.White);
		((Control)PassBox).set_Font(new Font("Segoe UI", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)PassBox).set_ForeColor(Color.FromArgb(93, 101, 111));
		((Control)PassBox).set_Location(new Point(34, 169));
		((Control)PassBox).set_Name("PassBox");
		PassBox.set_PasswordChar('•');
		PassBox.set_Radius(2);
		PassBox.set_SelectedText("");
		((Control)PassBox).set_Size(new Size(336, 35));
		((Control)PassBox).set_TabIndex(35);
		((Control)PassBox).set_Text(" ");
		((Control)label2).set_AutoSize(true);
		((Animator)siticoneTransition1).SetDecoration((Control)(object)label2, (DecorationType)0);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.FromArgb(158, 159, 168));
		((Control)label2).set_Location(new Point(30, 75));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(65, 15));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Username");
		LoginButton.set_BorderColor(Color.FromArgb(184, 53, 238));
		LoginButton.set_BorderRadius(2);
		LoginButton.set_BorderThickness(1);
		((Animator)siticoneTransition1).SetDecoration((Control)(object)LoginButton, (DecorationType)0);
		LoginButton.get_DisabledState().set_BorderColor(Color.DarkGray);
		LoginButton.get_DisabledState().set_CustomBorderColor(Color.DarkGray);
		LoginButton.get_DisabledState().set_FillColor(Color.FromArgb(169, 169, 169));
		LoginButton.get_DisabledState().set_ForeColor(Color.FromArgb(141, 141, 141));
		LoginButton.set_FillColor(Color.FromArgb(184, 53, 238));
		((Control)LoginButton).set_Font(new Font("Segoe UI", 9.75f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)LoginButton).set_ForeColor(Color.FromArgb(224, 224, 224));
		((Control)LoginButton).set_Location(new Point(34, 222));
		((Control)LoginButton).set_Name("LoginButton");
		((Control)LoginButton).set_Size(new Size(336, 33));
		((Control)LoginButton).set_TabIndex(37);
		((Control)LoginButton).set_Text("LOGIN");
		((Control)LoginButton).add_Click((EventHandler)LoginButton_Click_2);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Form)this).set_ClientSize(new Size(649, 570));
		((Control)this).get_Controls().Add((Control)(object)siticoneShadowPanel1);
		((Animator)siticoneTransition1).SetDecoration((Control)(object)this, (DecorationType)0);
		((Control)this).set_DoubleBuffered(true);
		((Form)this).set_FormBorderStyle((FormBorderStyle)1);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("LoginForm");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).add_Load((EventHandler)LoginForm_Load);
		((Form)this).add_Shown((EventHandler)LoginForm_Shown);
		((Control)siticoneShadowPanel1).ResumeLayout(false);
		((Control)siticoneShadowPanel1).PerformLayout();
		((Control)this).ResumeLayout(false);
	}

	private void KeyBox_TextChanged(object sender, EventArgs e)
	{
	}

	private async void Login()
	{
		Program.KeyAuthApp.login(((Control)UserBox).get_Text(), ((Control)PassBox).get_Text());
		if (!Program.KeyAuthApp.response.success)
		{
			((Control)LoginButton).set_Enabled(false);
			((Control)LoginButton).set_Text("WRONG PASSWORD");
			await Task.Delay(7000);
			((Control)LoginButton).set_Text("CLOSING...");
			await Task.Delay(1000);
			Environment.Exit(0);
			return;
		}
		await Task.Delay(7000);
		Program.KeyAuthApp.check();
		await Task.Delay(7000);
		Program.KeyAuthApp.checkblack();
		try
		{
			((Control)LoginButton).set_Enabled(false);
			((Control)LoginButton).set_Text("LOGIN");
			File.WriteAllText(Path.GetPathRoot(Environment.SystemDirectory) + "\\LoginV2.txt", ((Control)UserBox).get_Text() + "\n" + ((Control)PassBox).get_Text());
		}
		catch
		{
		}
		Client client = new Client();
		((Control)this).Hide();
		((Control)client).Show();
	}

	private void LoginButton_Click(object sender, EventArgs e)
	{
		try
		{
			Login();
		}
		catch (Exception ex)
		{
			OnlineErrorReport.SendException(ex.Message, Severe: true);
		}
	}

	private void LoginButton_Click_1(object sender, EventArgs e)
	{
		((Control)LoginButton).set_Enabled(false);
		((Control)LoginButton).set_Text("LOGGING IN...");
		try
		{
			Login();
		}
		catch (Exception ex)
		{
			OnlineErrorReport.SendException(ex.Message, Severe: true);
		}
	}

	private async void LoginForm_Load(object sender, EventArgs e)
	{
	}

	private void LoginForm_Shown(object sender, EventArgs e)
	{
		TurnOffFormLevelDoubleBuffering();
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		if (DwmSetWindowAttribute(((Control)this).get_Handle(), 19, new int[1] { 1 }, 4) != 0)
		{
			DwmSetWindowAttribute(((Control)this).get_Handle(), 20, new int[1] { 1 }, 4);
		}
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void PassBox_TextChanged(object sender, EventArgs e)
	{
	}

	private void pictureBox1_Click(object sender, EventArgs e)
	{
	}

	public static string RandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	private void siticoneButton2_Click(object sender, EventArgs e)
	{
	}

	private void TurnOffFormLevelDoubleBuffering()
	{
		enableFormLevelDoubleBuffering = false;
		((Form)this).set_MaximizeBox(true);
	}

	private void LoginButton_Click_2(object sender, EventArgs e)
	{
		((Control)LoginButton).set_Enabled(false);
		((Control)LoginButton).set_Text("LOGGING IN...");
		try
		{
			Login();
		}
		catch (Exception ex)
		{
			OnlineErrorReport.SendException(ex.Message, Severe: true);
		}
	}
}
