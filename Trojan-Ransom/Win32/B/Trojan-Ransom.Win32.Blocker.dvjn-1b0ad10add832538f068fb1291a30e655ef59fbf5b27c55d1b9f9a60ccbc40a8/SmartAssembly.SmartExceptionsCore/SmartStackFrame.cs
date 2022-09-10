using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using EkIJjm7vjs8xMISmTn;
using NCDRxx4R49CZy0gNBsi;

namespace SmartAssembly.SmartExceptionsCore;

[Serializable]
public sealed class SmartStackFrame : ISerializable
{
	public readonly int MethodID;

	public readonly object[] Objects;

	public readonly int ILOffset;

	public readonly int ExceptionStackDepth;

	[MethodImpl(MethodImplOptions.NoInlining)]
	public virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		//Discarded unreachable code: IL_006a, IL_018b
		int num = 5;
		int num3 = default(int);
		int num4 = default(int);
		string name = default(string);
		while (true)
		{
			int num5;
			int num2;
			switch (num)
			{
			case 7:
			case 10:
				if (num3 >= num4)
				{
					num = 11;
					if (0 == 0)
					{
						continue;
					}
					goto case 9;
				}
				name = string.Format(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48002), num3);
				num = 6;
				if (0 == 0)
				{
					continue;
				}
				goto case 8;
			case 9:
				if (Objects != null)
				{
					num = 8;
					if (!W26A9Dg3tjKcWBbuan8())
					{
						continue;
					}
					goto case 6;
				}
				num5 = 0;
				goto IL_0165;
			case 6:
				try
				{
					if (Objects[num3] == null)
					{
						int num6 = 2;
						int num7 = num6;
						while (true)
						{
							switch (num7)
							{
							case 0:
							case 2:
								P_0.AddValue(name, null, typeof(object));
								break;
							default:
								num7 = 3;
								if (true)
								{
									continue;
								}
								break;
							case 1:
							case 3:
								break;
							}
							break;
						}
					}
					else
					{
						P_0.AddValue(name, string.Concat(Objects[num3].GetType(), teuVAA2ghHDQmtOkUp.dYB2ebULO8(48047), Objects[num3]), typeof(string));
					}
				}
				catch (Exception)
				{
				}
				num3++;
				num = 7;
				if (0 == 0)
				{
					continue;
				}
				goto case 4;
			case 4:
				num3 = 0;
				num2 = 10;
				break;
			case 0:
			case 5:
				P_0.AddValue(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47830), MethodID, typeof(int));
				num2 = 3;
				break;
			case 8:
				num5 = Objects.Length;
				goto IL_0165;
			default:
				num = 4;
				if (0 == 0)
				{
					continue;
				}
				goto case 1;
			case 1:
			case 3:
				P_0.AddValue(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47867), ILOffset, typeof(int));
				num2 = 2;
				break;
			case 2:
				P_0.AddValue(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47904), ExceptionStackDepth, typeof(int));
				num2 = 9;
				break;
			case 11:
				return;
				IL_0165:
				num4 = num5;
				P_0.AddValue(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47957), num4, typeof(int));
				goto case 4;
			}
			num = num2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal SmartStackFrame(SerializationInfo P_0, StreamingContext P_1)
	{
		//Discarded unreachable code: IL_014c
		int num = 2;
		if (!W26A9Dg3tjKcWBbuan8())
		{
		}
		int num3 = default(int);
		int @int = default(int);
		while (true)
		{
			int num2;
			switch (num)
			{
			case 9:
				base._002Ector();
				num2 = 3;
				break;
			case 1:
			case 7:
				num3 = 0;
				num2 = 11;
				break;
			case 3:
				MethodID = P_0.GetInt32(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47830));
				num = 6;
				if (!W26A9Dg3tjKcWBbuan8())
				{
					continue;
				}
				goto case 6;
			case 6:
				ILOffset = P_0.GetInt32(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47867));
				num2 = 10;
				break;
			case 10:
				ExceptionStackDepth = P_0.GetInt32(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47904));
				num2 = 4;
				break;
			case 5:
			case 8:
			case 11:
				if (num3 < @int)
				{
					try
					{
						Objects[num3] = P_0.GetValue(string.Format(teuVAA2ghHDQmtOkUp.dYB2ebULO8(48002), num3), typeof(string));
					}
					catch (Exception)
					{
						Objects[num3] = teuVAA2ghHDQmtOkUp.dYB2ebULO8(48052);
					}
					num3++;
					num = 5;
					if (dtjJAugRdw8QtJ1ac0q())
					{
						continue;
					}
					goto case 3;
				}
				num = 12;
				if (0 == 0)
				{
					continue;
				}
				goto case 0;
			case 0:
				Objects = new object[@int];
				num2 = 1;
				break;
			case 4:
				@int = P_0.GetInt32(teuVAA2ghHDQmtOkUp.dYB2ebULO8(47957));
				goto case 0;
			default:
				num2 = 0;
				break;
			case 2:
				QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
				num2 = 9;
				break;
			case 12:
				return;
			}
			num = num2;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal SmartStackFrame(int P_0, object[] P_1, int P_2, int P_3)
	{
		//Discarded unreachable code: IL_0081
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					MethodID = P_0;
					num2 = 2;
					continue;
				case 1:
				case 4:
					base._002Ector();
					num2 = 7;
					continue;
				case 0:
				case 6:
					QA1I51451Fm9FyPCw1q.nLTn9WFXoXK9o();
					num2 = 4;
					if (dtjJAugRdw8QtJ1ac0q())
					{
						continue;
					}
					goto case 3;
				case 3:
					Objects = P_1;
					num2 = 8;
					if (W26A9Dg3tjKcWBbuan8())
					{
					}
					continue;
				case 5:
					break;
				case 2:
					ExceptionStackDepth = P_3;
					break;
				default:
					num2 = 5;
					continue;
				case 8:
					return;
				}
				break;
			}
			ILOffset = P_2;
			num = 3;
		}
	}

	internal static bool dtjJAugRdw8QtJ1ac0q()
	{
		return true;
	}

	internal static bool W26A9Dg3tjKcWBbuan8()
	{
		return false;
	}
}
