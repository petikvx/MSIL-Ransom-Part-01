using System;
using System.Collections.Generic;
using System.Net.Http;

internal class Get_IsPureWinMD
{
	private string GetElementType;

	public Get_IsPureWinMD(string P_0)
	{
		while (true)
		{
			int num = -44895684;
			while (true)
			{
				uint extraMonoPaths;
				switch ((extraMonoPaths = (uint)_003CModule_003E.GetExtraMonoPaths(num)) % 5u)
				{
				case 3u:
					break;
				default:
					return;
				case 4u:
					num = (int)(extraMonoPaths * 1432521871) ^ -330774822;
					continue;
				case 0u:
					num = (int)(extraMonoPaths * 2147100383) ^ -1168451177;
					continue;
				case 2u:
					GetElementType = P_0;
					num = ((int)extraMonoPaths * -425564546) ^ 0x1A866EC7;
					continue;
				case 1u:
					return;
				}
				break;
			}
		}
	}

	public unsafe void Memcpyimpl(string P_0)
	{
		_003CModule_003E.EventFullName = new Dictionary<string, string>
		{
			{
				_003CModule_003E.Control<string>((uint)(976422442 + sizeof(short) - 426), "\u000f\u0002\u000e\u0002xz|pd", (uint)(7462 + sizeof(bool) - 877), "JOKES ON YOU AHAHAHA"),
				P_0
			},
			{
				_003CModule_003E.Get_AsyncWaitHandle<string>((uint)(-1987351281 + sizeof(Guid) + 730), "\u0004\u0006\b\u0001|}{pf\u0016", (uint)(6661 + sizeof(float) - 79), "JOKES ON YOU AHAHAHA"),
				_003CModule_003E.MajorLinkerVersion<string>((uint)(916392428 + sizeof(char) + 905), "\u000f\u0004\u000e\u0005sv\u007fud", (uint)(6399 - sizeof(short) + 189), "JOKES ON YOU AHAHAHA")
			},
			{
				_003CModule_003E.Get_AsyncWaitHandle<string>((uint)(-1987346644 - sizeof(ushort) - 961), "\u0004\u0006\b\u0001|}{pf\u0013", (uint)(6937 - sizeof(uint) - 347), "JOKES ON YOU AHAHAHA"),
				_003CModule_003E.Control<string>((uint)(976421327 + sizeof(Guid) - 507), "\u000f\u0002\u000e\u0002xz|qd", (uint)(6055 - sizeof(decimal) + 547), "JOKES ON YOU AHAHAHA")
			}
		};
		try
		{
			_003CModule_003E.Get_StringLength = (HttpClient)_003CModule_003E.ÀúÅäM();
			try
			{
				while (true)
				{
					int num = -1101856109;
					while (true)
					{
						uint extraMonoPaths;
						switch ((extraMonoPaths = (uint)_003CModule_003E.GetExtraMonoPaths(num)) % 5u)
						{
						case 2u:
							break;
						default:
							return;
						case 4u:
							_003CModule_003E.Silent = _003CModule_003E.áyõiò(_003CModule_003E.Get_StringLength, GetElementType, _003CModule_003E._008Fp_007F_000Cú(_003CModule_003E.EventFullName)).GetAwaiter();
							num = ((int)extraMonoPaths * -1026052463) ^ 0x79C42F8B;
							continue;
						case 0u:
							_003CModule_003E.Silent.GetResult();
							num = ((int)extraMonoPaths * -293600282) ^ 0x4EF42C17;
							continue;
						case 3u:
							num = (int)(extraMonoPaths * 351967639) ^ -2050024948;
							continue;
						case 1u:
							return;
						}
						break;
					}
				}
			}
			finally
			{
				if (_003CModule_003E.Get_StringLength != null)
				{
					while (true)
					{
						IL_01d4:
						int num2 = -563758576;
						while (true)
						{
							uint extraMonoPaths;
							switch ((extraMonoPaths = (uint)_003CModule_003E.GetExtraMonoPaths(num2)) % 4u)
							{
							case 2u:
								break;
							default:
								goto end_IL_01d9;
							case 1u:
								_003CModule_003E._00D7ÇUOî(_003CModule_003E.Get_StringLength);
								num2 = ((int)extraMonoPaths * -1833590139) ^ 0x7133902F;
								continue;
							case 3u:
								num2 = ((int)extraMonoPaths * -401807382) ^ 0x281DC9FB;
								continue;
							case 0u:
								goto end_IL_01d9;
							}
							goto IL_01d4;
							continue;
							end_IL_01d9:
							break;
						}
						break;
					}
				}
			}
		}
		catch
		{
			while (true)
			{
				int num3 = -532482244;
				while (true)
				{
					uint extraMonoPaths;
					switch ((extraMonoPaths = (uint)_003CModule_003E.GetExtraMonoPaths(num3)) % 4u)
					{
					case 3u:
						break;
					default:
						return;
					case 1u:
						num3 = ((int)extraMonoPaths * -1793177691) ^ 0x1A5D6560;
						continue;
					case 0u:
						num3 = (int)((extraMonoPaths * 1545743416) ^ 0x192CBACF);
						continue;
					case 2u:
						return;
					}
					break;
				}
			}
		}
	}
}
