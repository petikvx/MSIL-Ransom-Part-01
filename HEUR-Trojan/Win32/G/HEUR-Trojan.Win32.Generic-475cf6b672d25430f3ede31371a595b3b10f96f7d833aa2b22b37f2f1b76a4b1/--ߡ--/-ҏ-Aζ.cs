using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.CompilerServices;

namespace _060C_0327ߡ_0097_FFFD;

[StandardModule]
internal sealed class _FFFDҏ_1CFCAζ
{
	[DllImport("user32.dll", EntryPoint = "GetClipboardData")]
	private static extern IntPtr _0300ӥʭ_005E_FFFD(uint _07B8_FFFD_FFFD皍R);

	[DllImport("user32.dll", EntryPoint = "IsClipboardFormatAvailable")]
	private static extern bool _FFFD_FFFD_FFFD콪_FFFD(uint _061CŔ_00BE_05B5ӛ);

	[DllImport("user32.dll", EntryPoint = "OpenClipboard", SetLastError = true)]
	private static extern bool _07B9_FFFDē뜸_FFFD(IntPtr Ɵܪƚ_0332Ϙ);

	[DllImport("user32.dll", EntryPoint = "CloseClipboard", SetLastError = true)]
	private static extern bool ӓ똛Πҏޤ();

	[DllImport("kernel32.dll", EntryPoint = "GlobalLock")]
	private static extern IntPtr ųϱų_0655_00AB(IntPtr Α_FFFD_FFFD䇹ϫ);

	[DllImport("kernel32.dll", EntryPoint = "GlobalUnlock")]
	private static extern bool _0332ӓˤãі(IntPtr ߟ_060C꾯בé);

	public static string _FFFDcӺɩƉ()
	{
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string text = default(string);
		IntPtr intPtr = default(IntPtr);
		IntPtr intPtr2 = default(IntPtr);
		string result = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_000b;
				case 259:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 1:
							break;
						default:
							goto end_IL_0001;
						}
						int num4 = num2 + 1;
						num2 = 0;
						switch (num4)
						{
						case 1:
							break;
						case 2:
							goto IL_000b;
						case 4:
							goto IL_0022;
						case 6:
							goto IL_0039;
						case 7:
							goto IL_003e;
						case 8:
							goto IL_0049;
						case 9:
							goto IL_005d;
						case 10:
							goto IL_0069;
						case 11:
							goto IL_007e;
						case 12:
							goto IL_008a;
						case 13:
						case 14:
						case 15:
							goto IL_0099;
						case 16:
							goto end_IL_0001_2;
						default:
							goto end_IL_0001;
						case 3:
						case 5:
						case 17:
							goto end_IL_0001_3;
						}
						goto default;
					}
					IL_007e:
					num = 11;
					text = Marshal.PtrToStringUni(intPtr);
					goto IL_008a;
					IL_008a:
					num = 12;
					_0332ӓˤãі(intPtr);
					goto IL_0099;
					IL_0069:
					num = 10;
					if (intPtr != IntPtr.Zero)
					{
						goto IL_007e;
					}
					goto IL_0099;
					IL_0099:
					num = 15;
					ӓ똛Πҏޤ();
					break;
					IL_000b:
					num = 2;
					if (!_FFFD_FFFD_FFFD콪_FFFD(13u))
					{
						goto end_IL_0001_3;
					}
					goto IL_0022;
					IL_0022:
					num = 4;
					if (!_07B9_FFFDē뜸_FFFD(IntPtr.Zero))
					{
						goto end_IL_0001_3;
					}
					goto IL_0039;
					IL_0039:
					num = 6;
					text = null;
					goto IL_003e;
					IL_003e:
					num = 7;
					intPtr2 = _0300ӥʭ_005E_FFFD(13u);
					goto IL_0049;
					IL_0049:
					num = 8;
					if (intPtr2 != IntPtr.Zero)
					{
						goto IL_005d;
					}
					goto IL_0099;
					IL_005d:
					num = 9;
					intPtr = ųϱų_0655_00AB(intPtr2);
					goto IL_0069;
					end_IL_0001_2:
					break;
				}
				num = 16;
				result = text;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 259;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}
}
