using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace F0;

internal static class b2
{
	private delegate bool Vo(int idCar, Dd sim);

	public static List<ni> PgJ;

	public static readonly Brush rgs;

	public static readonly Brush fgA;

	internal static b2 pE;

	public static bool egi(int int_0, iF iF_0)
	{
		using (List<ni>.Enumerator enumerator = PgJ.GetEnumerator())
		{
			int num2 = default(int);
			while (true)
			{
				if (!enumerator.MoveNext())
				{
					int num = 1;
					if (!F2())
					{
						num = num2;
					}
					switch (num)
					{
					case 1:
						goto end_IL_0052;
					}
				}
				ni current = enumerator.Current;
				if (current.MY() == 0 && iF_0 == current.RQ())
				{
					return false;
				}
				continue;
				end_IL_0052:
				break;
			}
		}
		PgJ[int_0].vN(0);
		bool result = true;
		if (!F2())
		{
			switch (0)
			{
			}
		}
		return result;
	}

	public static bool igk(int int_0, Dd dd_0)
	{
		return (bool)((DispatcherObject)dd_0).get_Dispatcher().Invoke((Delegate)new Vo(agT), new object[2] { int_0, dd_0 });
	}

	public static bool QgF(int int_0, iF iF_0)
	{
		bool result = default(bool);
		foreach (ni item in PgJ)
		{
			if (XV(item) != iF_0)
			{
				continue;
			}
			int num = 0;
			if (o0() == null)
			{
				goto IL_0043;
			}
			goto IL_0050;
			IL_0043:
			switch (num)
			{
			case 1:
				return result;
			}
			goto IL_0050;
			IL_0050:
			if (PgJ[int_0].MY() != lA(item) - 1)
			{
				continue;
			}
			result = false;
			num = 0;
			if (F2())
			{
				return result;
			}
			goto IL_0043;
		}
		return true;
	}

	private static bool agT(int int_0, Dd dd_0)
	{
		int num = 32;
		bool flag3 = default(bool);
		bool result = default(bool);
		bool flag = default(bool);
		bool flag5 = default(bool);
		bool flag4 = default(bool);
		bool flag2 = default(bool);
		while (true)
		{
			iF iF2 = PgJ[int_0].RQ();
			int num2 = 31;
			if (!F2())
			{
				goto IL_01da;
			}
			goto IL_01de;
			IL_01de:
			while (true)
			{
				switch (num2)
				{
				case 31:
					switch (iF2)
					{
					case (iF)1:
						break;
					case (iF)3:
						goto IL_00de;
					case (iF)18:
						goto IL_010c;
					case (iF)21:
						goto IL_0135;
					case (iF)22:
						goto IL_015e;
					case (iF)24:
						goto IL_0187;
					case (iF)26:
						goto IL_01b6;
					case (iF)0:
						goto IL_02cb;
					case (iF)6:
						goto IL_0305;
					case (iF)7:
						goto IL_0329;
					case (iF)8:
						goto IL_034d;
					case (iF)11:
						goto IL_0371;
					case (iF)12:
						goto IL_0395;
					case (iF)13:
						goto IL_03b9;
					case (iF)16:
						goto IL_03e1;
					default:
						goto IL_0423;
					case (iF)28:
						goto IL_042b;
					case (iF)29:
						goto IL_044a;
					case (iF)30:
						goto IL_047b;
					case (iF)31:
						goto IL_049f;
					case (iF)32:
						goto IL_04c3;
					case (iF)33:
						goto IL_04e7;
					case (iF)34:
						goto IL_050b;
					case (iF)35:
						goto IL_0529;
					case (iF)36:
						goto IL_054b;
					case (iF)19:
						goto IL_056e;
					}
					if (((Shape)dd_0.light1).get_Fill() == fgA)
					{
						goto IL_00c9;
					}
					goto case 15;
				case 3:
					goto IL_00de;
				case 25:
					break;
				case 6:
					if (!flag3)
					{
						result = false;
						num2 = 11;
						if (o0() != null)
						{
							continue;
						}
					}
					else
					{
						result = true;
					}
					goto case 4;
				case 32:
					goto end_IL_01de;
				case 1:
					result = true;
					goto case 4;
				case 16:
					result = true;
					goto case 4;
				case 17:
					result = (flag ? true : false);
					goto case 4;
				case 29:
					result = true;
					goto case 4;
				case 15:
					result = false;
					goto case 4;
				case 23:
					result = true;
					goto case 4;
				case 19:
					result = true;
					goto case 4;
				case 26:
					if (!flag5)
					{
						goto default;
					}
					result = true;
					goto case 4;
				default:
					result = false;
					goto case 4;
				case 10:
					goto IL_042b;
				case 13:
					if (!flag4)
					{
						goto case 20;
					}
					result = true;
					goto case 4;
				case 20:
					result = false;
					goto case 4;
				case 27:
					result = false;
					goto case 4;
				case 11:
					goto IL_0529;
				case 21:
					if (flag2)
					{
						goto case 9;
					}
					result = false;
					goto case 4;
				case 9:
					result = true;
					goto case 4;
				case 7:
					goto IL_054b;
				case 18:
					result = false;
					goto case 4;
				case 33:
					result = false;
					goto case 4;
				case 34:
					goto IL_056e;
				case 2:
					result = false;
					goto case 4;
				case 35:
					result = false;
					goto case 4;
				case 4:
				case 5:
				case 8:
				case 12:
				case 14:
				case 22:
				case 24:
				case 28:
				case 30:
					{
						return result;
					}
					IL_056e:
					if (((Shape)dd_0.light25).get_Fill() != fgA)
					{
						goto case 2;
					}
					result = true;
					goto case 4;
					IL_015e:
					if (((Shape)dd_0.light22).get_Fill() != fgA)
					{
						break;
					}
					result = true;
					goto case 4;
					IL_054b:
					if (SM(dd_0.light14) != fgA)
					{
						goto case 18;
					}
					result = true;
					goto case 4;
					IL_0529:
					flag2 = ((Shape)dd_0.light11).get_Fill() == fgA;
					goto case 21;
					IL_0135:
					if (((Shape)dd_0.light2).get_Fill() == fgA)
					{
						goto IL_014c;
					}
					result = false;
					goto case 4;
					IL_050b:
					result = ((((Shape)dd_0.light17).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_0305:
					result = ((((Shape)dd_0.light7).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_04e7:
					if (SM(dd_0.light5) != fgA)
					{
						goto case 27;
					}
					result = true;
					goto case 4;
					IL_0371:
					result = ((((Shape)dd_0.light18).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_04c3:
					result = ((((Shape)dd_0.light21).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_01b6:
					if (((Shape)dd_0.light15).get_Fill() == fgA)
					{
						goto IL_01cd;
					}
					goto case 35;
					IL_049f:
					result = ((((Shape)dd_0.light4).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_034d:
					result = ((((Shape)dd_0.light24).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_02cb:
					result = ((((Shape)dd_0.light9).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_047b:
					result = ((SM(dd_0.light20) == fgA) ? true : false);
					goto case 4;
					IL_0187:
					flag3 = ((Shape)dd_0.light19).get_Fill() == fgA;
					goto case 6;
					IL_0329:
					if (((Shape)dd_0.light6).get_Fill() == fgA)
					{
						goto case 23;
					}
					result = false;
					goto case 4;
					IL_044a:
					flag4 = ((Shape)dd_0.light16).get_Fill() == fgA;
					num = 13;
					goto case 13;
					IL_0395:
					if (((Shape)dd_0.light12).get_Fill() == fgA)
					{
						goto case 19;
					}
					result = false;
					goto case 4;
					IL_042b:
					if (((Shape)dd_0.light10).get_Fill() != fgA)
					{
						goto case 33;
					}
					result = true;
					goto case 4;
					IL_00de:
					if (((Shape)dd_0.light8).get_Fill() != fgA)
					{
						result = false;
						num2 = 29;
						if (o0() != null)
						{
							continue;
						}
					}
					else
					{
						result = true;
					}
					goto case 4;
					IL_0423:
					result = true;
					goto case 4;
					IL_03e1:
					result = ((((Shape)dd_0.light13).get_Fill() == fgA) ? true : false);
					goto case 4;
					IL_03b9:
					flag5 = ((Shape)dd_0.light23).get_Fill() == fgA;
					goto case 26;
				}
				result = false;
				num2 = 24;
				if (o0() == null)
				{
					continue;
				}
				goto IL_01da;
				IL_01cd:
				num2 = 16;
				if (F2())
				{
					continue;
				}
				goto IL_01da;
				IL_00c9:
				num2 = 1;
				if (o0() == null)
				{
					continue;
				}
				goto IL_01da;
				IL_014c:
				num2 = 29;
				if (F2())
				{
					continue;
				}
				goto IL_01da;
				IL_010c:
				flag = ((Shape)dd_0.light4).get_Fill() == fgA;
				num2 = 17;
				if (F2())
				{
					continue;
				}
				goto IL_01da;
				continue;
				end_IL_01de:
				break;
			}
			continue;
			IL_01da:
			num2 = num;
			goto IL_01de;
		}
	}

	static b2()
	{
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_004b: Expected O, but got Unknown
		AJ();
		PgJ = new List<ni>();
		rgs = (Brush)((TypeConverter)new BrushConverter()).ConvertFrom((object)sE.znu(348));
		fgA = (Brush)((TypeConverter)new BrushConverter()).ConvertFrom((object)sE.znu(358));
	}

	internal static bool F2()
	{
		return pE == null;
	}

	internal static b2 o0()
	{
		return pE;
	}

	internal static iF XV(object object_0)
	{
		return ((ni)object_0).RQ();
	}

	internal static int lA(object object_0)
	{
		return ((ni)object_0).MY();
	}

	internal static object SM(object object_0)
	{
		return ((Shape)object_0).get_Fill();
	}

	internal static void AJ()
	{
		Rg.XRF6rz();
	}
}
