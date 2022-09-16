using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace dfb44QxstTvciGRseP;

public class tbhMggxqSBF9lLkrtKB : oLXIBjxPfZLjvEX5tjr
{
	protected BinaryWriter ytFSJoxWVj;

	internal static tbhMggxqSBF9lLkrtKB CiBSUq7y5ZWaax4uoK8;

	public tbhMggxqSBF9lLkrtKB(Stream stream_0, VElg1KxQgKwns2H2VEa velg1KxQgKwns2H2VEa_0)
	{
		GRgbqpcvG2cupxT0496.SF54tCZzYSfdV();
		base._002Ector(stream_0, velg1KxQgKwns2H2VEa_0);
	}

	public override void Dispose()
	{
		c8BSPP7565 = null;
		ytFSJoxWVj.Dispose();
	}

	public void Y94SHTQDxu(in PBo11yxJuWSePXEpLhP command)
	{
		if (!c8BSPP7565.CanWrite)
		{
			throw new InvalidOperationException("The stream is unwritable.");
		}
		object obj = null;
		int num = 0;
		int num2 = 0;
		Array array = null;
		object ro6S91nO7K = Ro6S91nO7K;
		int num3 = 0;
		if (!mH43XJ7VveBnAwGSWkl())
		{
			int num4 = default(int);
			num3 = num4;
		}
		switch (num3)
		{
		case 1:
			return;
		}
		bool lockTaken = false;
		try
		{
			Monitor.Enter(ro6S91nO7K, ref lockTaken);
			byte[] array2 = new byte[3];
			bool flag = default(bool);
			int num8 = default(int);
			EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu2 = default(EdRPUvx6HtFjma48dEu);
			bool flag2 = default(bool);
			bool flag3 = default(bool);
			object obj2 = default(object);
			while (true)
			{
				array2[0] = CxVSIjjSkW().i4PuaWONq9;
				command.jvcSiZia4h.v1rSqe7Sqq.ulphyM5cQ1(array2, 1);
				ytFSJoxWVj.Write(array2);
				int num5 = 0;
				int num6 = 0;
				while (true)
				{
					EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu;
					if (num6 < command.jvcSiZia4h.lqcSeesD6g())
					{
						edRPUvx6HtFjma48dEu = command.jvcSiZia4h.K6nSFA122H(num6);
						if (array != null)
						{
							obj2 = array.GetValue(num);
							goto IL_00a0;
						}
						goto IL_0314;
					}
					obj = null;
					goto IL_0554;
					IL_02f1:
					object obj3 = null;
					goto IL_02f2;
					IL_026c:
					int num7;
					while (true)
					{
						switch (num7)
						{
						case 18:
							flag = edRPUvx6HtFjma48dEu.HasFlag((EdRPUvx6HtFjma48dEu)1);
							num8 = 10;
							goto case 10;
						case 10:
							if (!flag)
							{
								if (edRPUvx6HtFjma48dEu.HasFlag((EdRPUvx6HtFjma48dEu)2))
								{
									num7 = 0;
									if (!mH43XJ7VveBnAwGSWkl())
									{
										continue;
									}
									goto case 1;
								}
							}
							else
							{
								DTmSt7ZgUE(edRPUvx6HtFjma48dEu, obj2);
								num5++;
							}
							goto case 8;
						case 6:
							ytFSJoxWVj.Write((ushort)edRPUvx6HtFjma48dEu2);
							num7 = 3;
							if (mH43XJ7VveBnAwGSWkl())
							{
								continue;
							}
							goto IL_015c;
						case 5:
							if (edRPUvx6HtFjma48dEu == (EdRPUvx6HtFjma48dEu)4100)
							{
								if (obj != null)
								{
									if (obj.C8bhRxET3D())
									{
										num7 = 13;
										if (gM00ph7fECDqRJ6ITok() == null)
										{
											continue;
										}
										goto default;
									}
									num6 = command.jvcSiZia4h.tJcSAMKqWR(num6);
									goto IL_0478;
								}
								throw new InvalidOperationException("_IF_0 requires a missing parameter.");
							}
							goto IL_01c9;
						default:
							if (flag2)
							{
								num7 = 4;
								if (gM00ph7fECDqRJ6ITok() == null)
								{
									continue;
								}
								goto IL_015c;
							}
							goto IL_01af;
						case 4:
							ytFSJoxWVj.Write(CxVSIjjSkW().liyuIDPMcm);
							goto IL_01af;
						case 3:
							ytFSJoxWVj.Write(CxVSIjjSkW().jiKunPtGM5);
							num7 = 14;
							if (gM00ph7fECDqRJ6ITok() == null)
							{
								continue;
							}
							goto case 6;
						case 7:
							break;
						case 16:
							goto IL_02e8;
						case 23:
							goto IL_02f1;
						case 22:
							goto IL_0314;
						case 2:
							goto IL_03b3;
						case 14:
							if (edRPUvx6HtFjma48dEu2.HasFlag((EdRPUvx6HtFjma48dEu)1))
							{
								goto case 12;
							}
							if (edRPUvx6HtFjma48dEu2.HasFlag((EdRPUvx6HtFjma48dEu)2))
							{
								kFNSlModIp(edRPUvx6HtFjma48dEu2, obj2);
								goto IL_040a;
							}
							throw new ArgumentException("Unrecognized type of object (" + obj2.GetType().FullName + ")", "currObj");
						case 12:
							DTmSt7ZgUE(edRPUvx6HtFjma48dEu2, obj2);
							goto IL_040a;
						case 1:
							kFNSlModIp(edRPUvx6HtFjma48dEu, obj2);
							num5++;
							goto case 8;
						case 8:
							if (array == null)
							{
								goto IL_0478;
							}
							goto case 17;
						case 17:
							if (++num == num2)
							{
								array = null;
							}
							else
							{
								num6--;
								num5--;
							}
							goto IL_0478;
						case 20:
							goto IL_0465;
						case 13:
						case 19:
							goto IL_0478;
						case 21:
							goto end_IL_047e;
						case 11:
							throw new InvalidOperationException("_ARRAY_OF cannot be repeated.");
						case 15:
							throw new InvalidOperationException("_ARRAY_OF require a missing parameter.");
						case 9:
							goto IL_0554;
							IL_01af:
							if (edRPUvx6HtFjma48dEu != (EdRPUvx6HtFjma48dEu)64)
							{
								goto case 18;
							}
							edRPUvx6HtFjma48dEu2 = G7vqI854MalMAxPWQ1.vOGhuXnIqG(obj2);
							goto case 6;
							IL_040a:
							num5++;
							num8 = 8;
							goto case 8;
						}
						break;
						IL_01c9:
						if (edRPUvx6HtFjma48dEu != (EdRPUvx6HtFjma48dEu)6148)
						{
							if (edRPUvx6HtFjma48dEu == (EdRPUvx6HtFjma48dEu)8196)
							{
								if (obj2 == null || !(obj2 is Array))
								{
									num7 = 15;
									if (gM00ph7fECDqRJ6ITok() == null)
									{
										continue;
									}
								}
								else
								{
									if (array == null)
									{
										array = (Array)obj2;
										num2 = array.Length;
										ytFSJoxWVj.Write(num2);
										if (num2 != 0)
										{
											num = 0;
											goto IL_0478;
										}
										goto IL_03b3;
									}
									num7 = 11;
									if (mH43XJ7VveBnAwGSWkl())
									{
										continue;
									}
								}
								goto IL_015c;
							}
							throw new InvalidOperationException("Unable to recognize special parameter: " + $"0x{edRPUvx6HtFjma48dEu:x}");
						}
						if (obj != null)
						{
							flag3 = obj.C8bhRxET3D();
							goto IL_0465;
						}
						throw new InvalidOperationException("_IF_NOT_0 requires a missing parameter.");
						IL_0465:
						if (flag3)
						{
							num6 = command.jvcSiZia4h.tJcSAMKqWR(num6);
						}
						goto IL_0478;
						IL_03b3:
						array = null;
						num6++;
						goto IL_0478;
					}
					goto IL_02d6;
					IL_0554:
					obj2 = null;
					array = null;
					num2 = 0;
					num = 0;
					ytFSJoxWVj.Write(CxVSIjjSkW().JQNu5aifrj);
					ytFSJoxWVj.Flush();
					return;
					IL_0314:
					if (num5 < command.WiZS6JsgLe.Length)
					{
						obj3 = command.WiZS6JsgLe[num5];
						goto IL_02f2;
					}
					num7 = 23;
					if (!mH43XJ7VveBnAwGSWkl())
					{
						goto IL_015c;
					}
					goto IL_026c;
					IL_02d6:
					object obj4 = command.WiZS6JsgLe[num5 - 1];
					goto IL_02e1;
					IL_015c:
					num7 = num8;
					goto IL_026c;
					IL_02f2:
					obj2 = obj3;
					num8 = 16;
					goto IL_02e8;
					IL_02e8:
					if (num5 == 0)
					{
						obj4 = null;
						goto IL_02e1;
					}
					goto IL_02d6;
					IL_0478:
					num6++;
					continue;
					IL_02e1:
					obj = obj4;
					goto IL_00a0;
					IL_00a0:
					if (edRPUvx6HtFjma48dEu.HasFlag((EdRPUvx6HtFjma48dEu)4))
					{
						if (edRPUvx6HtFjma48dEu == (EdRPUvx6HtFjma48dEu)2052)
						{
							if (obj != null && obj is bool)
							{
								if (!(bool)obj)
								{
									num6 = command.jvcSiZia4h.tJcSAMKqWR(num6);
								}
								goto IL_0478;
							}
							throw new InvalidOperationException("_IF_TRUE requires a missing parameter.");
						}
						num7 = 5;
						if (gM00ph7fECDqRJ6ITok() != null)
						{
							goto IL_015c;
						}
					}
					else
					{
						flag2 = num5 > 0;
						num7 = 0;
						if (gM00ph7fECDqRJ6ITok() != null)
						{
							goto IL_015c;
						}
					}
					goto IL_026c;
					continue;
					end_IL_047e:
					break;
				}
			}
		}
		finally
		{
			if (lockTaken)
			{
				Monitor.Exit(ro6S91nO7K);
			}
		}
	}

	[CompilerGenerated]
	private void DTmSt7ZgUE(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, object object_0)
	{
		EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu = edRPUvx6HtFjma48dEu_0;
		EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu2 = edRPUvx6HtFjma48dEu;
		int num = 2;
		if (gM00ph7fECDqRJ6ITok() == null)
		{
			goto IL_0078;
		}
		goto IL_0127;
		IL_0127:
		switch (num)
		{
		case 17:
			break;
		case 9:
			goto IL_0051;
		case 6:
			goto IL_0078;
		default:
			return;
		case 1:
			if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)201)
			{
				yqJGJY7UJWb8DMcDwJY(ytFSJoxWVj, (char)object_0);
			}
			return;
		case 5:
			if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)865)
			{
				return;
			}
			goto case 16;
		case 8:
			goto IL_0282;
		case 10:
			goto IL_02fc;
		case 3:
		case 13:
			goto IL_0312;
		case 16:
			ytFSJoxWVj.Write((double)object_0);
			return;
		case 12:
			goto IL_035e;
		case 18:
			goto IL_0384;
		case 0:
		case 2:
		case 4:
		case 7:
		case 11:
		case 14:
		case 15:
			return;
		}
		goto IL_0019;
		IL_0078:
		int num2 = default(int);
		if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)401)
		{
			if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)41)
			{
				if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)17)
				{
					if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)9)
					{
						goto IL_0051;
					}
					goto IL_0312;
				}
				if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)25)
				{
					goto IL_0384;
				}
				ytFSJoxWVj.Write((byte[])object_0, 0, 4);
				return;
			}
			if (edRPUvx6HtFjma48dEu2 > (EdRPUvx6HtFjma48dEu)201)
			{
				switch (edRPUvx6HtFjma48dEu2)
				{
				case (EdRPUvx6HtFjma48dEu)401:
					ytFSJoxWVj.Write((short)object_0);
					break;
				case (EdRPUvx6HtFjma48dEu)329:
					ytFSJoxWVj.Write((byte)object_0);
					break;
				case (EdRPUvx6HtFjma48dEu)265:
					ytFSJoxWVj.Write((sbyte)object_0);
					break;
				}
				return;
			}
			if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)153)
			{
				ytFSJoxWVj.Write((bool)object_0);
				return;
			}
			num = 1;
			if (!mH43XJ7VveBnAwGSWkl())
			{
				goto IL_0123;
			}
		}
		else if (edRPUvx6HtFjma48dEu2 <= (EdRPUvx6HtFjma48dEu)737)
		{
			if (edRPUvx6HtFjma48dEu2 > (EdRPUvx6HtFjma48dEu)537)
			{
				goto IL_0019;
			}
			if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)465)
			{
				TXwQew722hlUNfaU1fc(ytFSJoxWVj, (ushort)object_0);
				num2 = 11;
				return;
			}
			if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)537)
			{
				sy8vmB7AhUkBytt8Noq(ytFSJoxWVj, (int)object_0);
				return;
			}
			num = 4;
			if (gM00ph7fECDqRJ6ITok() != null)
			{
				goto IL_0123;
			}
		}
		else
		{
			if (edRPUvx6HtFjma48dEu2 > (EdRPUvx6HtFjma48dEu)865)
			{
				goto IL_0282;
			}
			if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)793)
			{
				goto IL_02fc;
			}
			num = 5;
			if (gM00ph7fECDqRJ6ITok() != null)
			{
				goto IL_0123;
			}
		}
		goto IL_0127;
		IL_02fc:
		ytFSJoxWVj.Write((float)object_0);
		return;
		IL_0123:
		num = num2;
		goto IL_0127;
		IL_0019:
		if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)601)
		{
			if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)673)
			{
				if (edRPUvx6HtFjma48dEu2 != (EdRPUvx6HtFjma48dEu)737)
				{
					num = 0;
					if (!mH43XJ7VveBnAwGSWkl())
					{
						return;
					}
					goto IL_0127;
				}
				ytFSJoxWVj.Write((ulong)object_0);
				return;
			}
			goto IL_035e;
		}
		ytFSJoxWVj.Write((uint)object_0);
		return;
		IL_0051:
		ytFSJoxWVj.Write((byte[])object_0, 0, 1);
		num = 4;
		if (gM00ph7fECDqRJ6ITok() == null)
		{
			return;
		}
		goto IL_0127;
		IL_035e:
		ytFSJoxWVj.Write((long)object_0);
		return;
		IL_0384:
		switch (edRPUvx6HtFjma48dEu2)
		{
		case (EdRPUvx6HtFjma48dEu)41:
			y7e51r7rWIJBEBQMxAo(ytFSJoxWVj, (byte[])object_0, 0, 16);
			break;
		case (EdRPUvx6HtFjma48dEu)33:
			ytFSJoxWVj.Write((byte[])object_0, 0, 8);
			break;
		}
		return;
		IL_0282:
		switch (edRPUvx6HtFjma48dEu2)
		{
		case (EdRPUvx6HtFjma48dEu)1065:
			ytFSJoxWVj.Write(((Guid)object_0).ToByteArray());
			break;
		case (EdRPUvx6HtFjma48dEu)993:
			cPeaac7BRKJGVVarBWU(ytFSJoxWVj, ((DateTime)object_0).ToBinary());
			break;
		case (EdRPUvx6HtFjma48dEu)937:
			ytFSJoxWVj.Write((decimal)object_0);
			break;
		}
		return;
		IL_0312:
		if (edRPUvx6HtFjma48dEu2 == (EdRPUvx6HtFjma48dEu)17)
		{
			y7e51r7rWIJBEBQMxAo(ytFSJoxWVj, (byte[])object_0, 0, 2);
		}
	}

	[CompilerGenerated]
	private void kFNSlModIp(EdRPUvx6HtFjma48dEu edRPUvx6HtFjma48dEu_0, object object_0)
	{
		byte[] array = null;
		string text = object_0 as string;
		int num = 2;
		if (!mH43XJ7VveBnAwGSWkl())
		{
			goto IL_002f;
		}
		goto IL_003f;
		IL_003f:
		bool flag = default(bool);
		while (true)
		{
			switch (num)
			{
			case 2:
				flag = text != null;
				num = 1;
				if (mH43XJ7VveBnAwGSWkl())
				{
					continue;
				}
				goto IL_007b;
			case 1:
				break;
			default:
				goto IL_007b;
			}
			break;
		}
		goto IL_002f;
		IL_008f:
		ytFSJoxWVj.Write(array.Length);
		ytFSJoxWVj.Write(CxVSIjjSkW().jiKunPtGM5);
		ytFSJoxWVj.Write(array);
		return;
		IL_002f:
		if (flag)
		{
			num = 0;
			if (mH43XJ7VveBnAwGSWkl())
			{
				goto IL_003f;
			}
			goto IL_007b;
		}
		if (object_0 is byte[] array2)
		{
			array = array2;
			goto IL_008f;
		}
		throw new ArgumentException("Invalid type of data (only string and byte[] are allowed).", "value");
		IL_007b:
		array = CxVSIjjSkW().MTKuXsMd6S.GetBytes(text);
		goto IL_008f;
	}

	internal static bool mH43XJ7VveBnAwGSWkl()
	{
		return CiBSUq7y5ZWaax4uoK8 == null;
	}

	internal static tbhMggxqSBF9lLkrtKB gM00ph7fECDqRJ6ITok()
	{
		return CiBSUq7y5ZWaax4uoK8;
	}

	internal static void y7e51r7rWIJBEBQMxAo(object object_0, object object_1, int int_0, int int_1)
	{
		((BinaryWriter)object_0).Write((byte[])object_1, int_0, int_1);
	}

	internal static void yqJGJY7UJWb8DMcDwJY(object object_0, char char_0)
	{
		((BinaryWriter)object_0).Write(char_0);
	}

	internal static void TXwQew722hlUNfaU1fc(object object_0, ushort ushort_0)
	{
		((BinaryWriter)object_0).Write(ushort_0);
	}

	internal static void sy8vmB7AhUkBytt8Noq(object object_0, int int_0)
	{
		((BinaryWriter)object_0).Write(int_0);
	}

	internal static void cPeaac7BRKJGVVarBWU(object object_0, long long_0)
	{
		((BinaryWriter)object_0).Write(long_0);
	}
}
