using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using A6yJVNZuoAn9NC1LAS;
using AESxWin.Helpers;
using Microsoft.Win32;

namespace AESxWin;

internal static class Program
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[STAThread]
	private static void Main(string[] args)
	{
		//Discarded unreachable code: IL_0005, IL_00cb
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0179: Incompatible stack heights: 0 vs 1
		int num = 12;
		if (1 == 0)
		{
			goto IL_0016;
		}
		goto IL_00d4;
		IL_00d4:
		int num3;
		bool flag2 = default(bool);
		bool flag = default(bool);
		bool flag3 = default(bool);
		while (true)
		{
			IL_00d4_2:
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 0:
					break;
				case 3:
					RegisterApp();
					return;
				case 9:
					return;
				case 10:
					Application.SetCompatibleTextRenderingDefault(false);
					num3 = 15;
					goto IL_00d0;
				case 1:
				case 14:
					Application.add_ThreadException((ThreadExceptionEventHandler)Application_ThreadException);
					num3 = 5;
					goto IL_00d0;
				case 7:
					goto IL_0072;
				case 15:
					flag2 = args.Length != 0;
					num2 = 8;
					continue;
				case 5:
					Application.EnableVisualStyles();
					num2 = 10;
					continue;
				case 4:
					return;
				case 6:
					if (flag)
					{
						goto case 3;
					}
					flag3 = args[0] == S7EI44sMaZQ92MiG6X.pA2PN5iOW(2172);
					num = 7;
					if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						goto IL_00d4_2;
					}
					goto case 10;
				default:
					num = 3;
					goto IL_00d4_2;
				case 13:
					return;
				case 12:
					if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(104))
					{
						return;
					}
					_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091();
					if (!_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
					{
						num = 13;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							goto IL_00d4_2;
						}
					}
					else
					{
						num = 14;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							goto IL_00d4_2;
						}
					}
					goto case 10;
				case 2:
					return;
				case 8:
					goto IL_01b5;
				case 11:
					flag = args[0] == S7EI44sMaZQ92MiG6X.pA2PN5iOW(2168);
					num = 6;
					goto IL_00d4_2;
				case 16:
					return;
				}
				break;
				IL_01b5:
				if (!flag2)
				{
					Application.Run((Form)(object)new AESxWinAuto());
					num2 = 16;
					continue;
				}
				num3 = 11;
				goto IL_00d0;
			}
			break;
			IL_0072:
			if (flag3)
			{
				num3 = 0;
				goto IL_00d0;
			}
			Application.Run((Form)(object)new AESxWinAuto());
			num = 4;
		}
		goto IL_0016;
		IL_00d0:
		num = num3;
		goto IL_00d4;
		IL_0016:
		UnRegisterApp();
		num3 = 2;
		goto IL_00d0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
	{
		//Discarded unreachable code: IL_0005, IL_0089
		//IL_0006: Incompatible stack heights: 0 vs 1
		try
		{
			DateTime now = DateTime.Now;
			_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092();
			int num;
			if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
			{
				num = 3;
			}
			else
			{
				num = 4;
				if (1 == 0)
				{
					return;
				}
			}
			string text = default(string);
			string path = default(string);
			while (true)
			{
				int num2;
				switch (num)
				{
				case 0:
				case 3:
					text = now.ToString(S7EI44sMaZQ92MiG6X.pA2PN5iOW(216));
					num2 = 1;
					goto IL_008e;
				case 1:
					path = Path.Combine(S7EI44sMaZQ92MiG6X.pA2PN5iOW(212), text + S7EI44sMaZQ92MiG6X.pA2PN5iOW(224));
					break;
				case 5:
					return;
				}
				Log.WriteLog(path, e.Exception.ToString());
				num2 = 5;
				goto IL_008e;
				IL_008e:
				num = num2;
			}
		}
		catch
		{
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void RegisterApp()
	{
		//Discarded unreachable code: IL_0005, IL_0133
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_01f0: Incompatible stack heights: 0 vs 1
		//IL_0239: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Unknown result type (might be due to invalid IL or missing references)
		if (!S7EI44sMaZQ92MiG6X.EmWT1u1C4(108))
		{
			return;
		}
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2176))!.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2180))!.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2184), writable: true)!.CreateSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164));
			int num = 9;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 1:
						case 3:
							registryKey.SetValue("", Application.get_ExecutablePath() + S7EI44sMaZQ92MiG6X.pA2PN5iOW(2200));
							num2 = 10;
							if (true)
							{
								break;
							}
							goto case 9;
						case 9:
							registryKey.SetValue("", S7EI44sMaZQ92MiG6X.pA2PN5iOW(2188), RegistryValueKind.String);
							num2 = 6;
							if (0 == 0)
							{
								break;
							}
							goto default;
						default:
							registryKey.SetValue("", S7EI44sMaZQ92MiG6X.pA2PN5iOW(2188), RegistryValueKind.String);
							num2 = 0;
							if (0 == 0)
							{
								break;
							}
							goto case 2;
						case 2:
							registryKey = registryKey.CreateSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2196));
							num3 = 4;
							continue;
						case 10:
							registryKey = Registry.ClassesRoot.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2176))!.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2184), writable: true)!.CreateSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164));
							goto default;
						case 4:
							registryKey.SetValue("", Application.get_ExecutablePath() + S7EI44sMaZQ92MiG6X.pA2PN5iOW(2204));
							num2 = 8;
							if (true)
							{
								break;
							}
							goto case 0;
						case 0:
							registryKey.SetValue(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2192), Application.get_ExecutablePath(), RegistryValueKind.String);
							num3 = 2;
							continue;
						case 11:
							registryKey = registryKey.CreateSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2196));
							_ = 1;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								num3 = 1;
								continue;
							}
							goto end_IL_013c;
						case 6:
							registryKey.SetValue(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2192), Application.get_ExecutablePath(), RegistryValueKind.String);
							num3 = 11;
							continue;
						case 8:
							MessageBox.Show(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2208), S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)64);
							num2 = 12;
							if (1 == 0)
							{
								return;
							}
							break;
						case 12:
							return;
						}
						break;
					}
					continue;
					end_IL_013c:
					break;
				}
				num = 7;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + S7EI44sMaZQ92MiG6X.pA2PN5iOW(2212), S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void UnRegisterApp()
	{
		//Discarded unreachable code: IL_0005, IL_0086
		//IL_0006: Incompatible stack heights: 0 vs 1
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		if (S7EI44sMaZQ92MiG6X.EmWT1u1C4(112))
		{
			return;
		}
		try
		{
			RegistryKey registryKey = Registry.ClassesRoot.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2176))!.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2180))!.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2184), writable: true);
			int num = 0;
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						registryKey = Registry.ClassesRoot.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2176))!.OpenSubKey(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2184), writable: true);
						goto default;
					default:
						_ = 0;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							num2 = 1;
							continue;
						}
						goto end_IL_008f;
					case 0:
						registryKey.DeleteSubKeyTree(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164));
						num2 = 4;
						if (0 == 0)
						{
							continue;
						}
						goto case 1;
					case 1:
					case 2:
						registryKey.DeleteSubKeyTree(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164));
						break;
					case 3:
					case 5:
						break;
					case 6:
						return;
					}
					MessageBox.Show(S7EI44sMaZQ92MiG6X.pA2PN5iOW(2216), S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)64);
					num2 = 6;
					if (false)
					{
						return;
					}
					continue;
					end_IL_008f:
					break;
				}
				num = 5;
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message + S7EI44sMaZQ92MiG6X.pA2PN5iOW(2212), S7EI44sMaZQ92MiG6X.pA2PN5iOW(2164), (MessageBoxButtons)0, (MessageBoxIcon)16);
		}
	}

	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return true;
	}

	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		//Discarded unreachable code: IL_0005
		//IL_0006: Incompatible stack heights: 0 vs 1
		return false;
	}
}
