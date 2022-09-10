using System;
using System.Collections.Generic;

[GAttribute0]
public static class GClass43
{
	private static class Class21<T>
	{
		public static readonly T[] gparam_0 = new T[0];
	}

	[GAttribute0]
	public static T[] smethod_0<T>(IEnumerable<T> ienumerable_0)
	{
		T[] array = default(T[]);
		ICollection<T> collection = default(ICollection<T>);
		bool flag2 = default(bool);
		int num6 = default(int);
		int num5 = default(int);
		bool flag = default(bool);
		T[] array2 = default(T[]);
		T current = default(T);
		while (true)
		{
			int num = 997236872;
			while (true)
			{
				T[] result;
				uint num2;
				switch ((num2 = (uint)num ^ 0x6B5F00D3u) % 12u)
				{
				case 11u:
					array = new T[collection.Count];
					collection.CopyTo(array, 0);
					num = (int)((num2 * 662302001) ^ 0x76678359);
					continue;
				case 10u:
					array = null;
					num = (int)(num2 * 1029471622) ^ -1364676783;
					continue;
				case 8u:
					collection = ienumerable_0 as ICollection<T>;
					num = 1502563577;
					continue;
				case 7u:
				{
					int num12;
					int num13;
					if (flag2)
					{
						num12 = -2045602061;
						num13 = -2045602061;
					}
					else
					{
						num12 = -441410122;
						num13 = -441410122;
					}
					num = num12 ^ (int)(num2 * 1866333291);
					continue;
				}
				case 6u:
				{
					int num14;
					int num15;
					if (collection == null)
					{
						num14 = -649196473;
						num15 = -649196473;
					}
					else
					{
						num14 = -1139875732;
						num15 = -1139875732;
					}
					num = num14 ^ ((int)num2 * -1026516471);
					continue;
				}
				case 3u:
					flag2 = ienumerable_0 == null;
					num = (int)(num2 * 291505746) ^ -1783763446;
					continue;
				case 2u:
					num6 = 0;
					num = 1568687911;
					continue;
				case 1u:
					num = (int)(num2 * 25705717) ^ -111994371;
					continue;
				case 0u:
					break;
				default:
				{
					IEnumerator<T> enumerator = ienumerable_0.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0290:
							int num3;
							int num4;
							if (enumerator.MoveNext())
							{
								num3 = 266839678;
								num4 = 266839678;
							}
							else
							{
								num3 = 748823653;
								num4 = 748823653;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x6B5F00D3u) % 13u)
								{
								case 12u:
								{
									int num9;
									if (array.Length == num6)
									{
										num3 = 1325280582;
										num9 = 1325280582;
									}
									else
									{
										num3 = 1139982568;
										num9 = 1139982568;
									}
									continue;
								}
								case 11u:
									num5 = num6 + 1;
									num3 = ((int)num2 * -1239175351) ^ 0x3C68B92C;
									continue;
								case 9u:
								{
									int num7;
									int num8;
									if (!flag)
									{
										num7 = 1730153636;
										num8 = 1730153636;
									}
									else
									{
										num7 = 966988652;
										num8 = 966988652;
									}
									num3 = num7 ^ (int)(num2 * 534600049);
									continue;
								}
								case 8u:
									array2 = new T[checked(num6 * 2)];
									Array.Copy(array, 0, array2, 0, num6);
									num3 = ((int)num2 * -1854020647) ^ 0x15B2F87A;
									continue;
								case 7u:
									num3 = 266839678;
									continue;
								case 6u:
									array[num6] = current;
									num3 = 229302083;
									continue;
								case 5u:
									current = enumerator.Current;
									num3 = 233640120;
									continue;
								case 4u:
									num6 = num5;
									num3 = (int)(num2 * 1841800692) ^ -654026904;
									continue;
								case 3u:
									flag = array == null;
									num3 = ((int)num2 * -1027153375) ^ 0x5118DB31;
									continue;
								case 2u:
									array = array2;
									num3 = (int)(num2 * 52449783) ^ -1225378540;
									continue;
								case 1u:
									array = new T[4];
									num3 = ((int)num2 * -394645719) ^ -900260738;
									continue;
								default:
									goto end_IL_023a;
								case 0u:
									break;
								case 10u:
									goto end_IL_023a;
								}
								goto IL_0290;
								continue;
								end_IL_023a:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_02d9:
								int num10 = 783122752;
								while (true)
								{
									switch ((num2 = (uint)num10 ^ 0x6B5F00D3u) % 3u)
									{
									case 2u:
										goto IL_02a6;
									default:
										goto end_IL_02bb;
									case 0u:
										break;
									case 1u:
										goto end_IL_02bb;
									}
									goto IL_02d9;
									IL_02a6:
									enumerator.Dispose();
									num10 = (int)((num2 * 1337743497) ^ 0x48DE23E6);
									continue;
									end_IL_02bb:
									break;
								}
								break;
							}
						}
					}
					result = array ?? Class21<T>.gparam_0;
					while (true)
					{
						int num11 = 752858608;
						while (true)
						{
							switch ((num2 = (uint)num11 ^ 0x6B5F00D3u) % 3u)
							{
							case 1u:
								num11 = (int)(num2 * 1112843414) ^ -1129495682;
								continue;
							case 2u:
								break;
							default:
								goto end_IL_031b;
							}
							break;
						}
						continue;
						end_IL_031b:
						break;
					}
					goto IL_0330;
				}
				case 5u:
					throw new ArgumentNullException("source");
				case 9u:
					{
						result = array;
						goto IL_0330;
					}
					IL_0330:
					return result;
				}
				break;
			}
		}
	}

	[GAttribute0]
	public static bool smethod_1<T>(IEnumerable<T> ienumerable_0, T gparam_0)
	{
		bool flag = ienumerable_0 == null;
		ICollection<T> collection = default(ICollection<T>);
		EqualityComparer<T> @default = default(EqualityComparer<T>);
		T current = default(T);
		bool result = default(bool);
		while (true)
		{
			int num = 343875538;
			while (true)
			{
				uint num2;
				switch ((num2 = (uint)num ^ 0x5DA2156Fu) % 7u)
				{
				case 3u:
				{
					collection = ienumerable_0 as ICollection<T>;
					int num11;
					if (collection == null)
					{
						num = 15557353;
						num11 = 15557353;
					}
					else
					{
						num = 1215647202;
						num11 = 1215647202;
					}
					continue;
				}
				case 2u:
				{
					int num9;
					int num10;
					if (flag)
					{
						num9 = 1025282327;
						num10 = 1025282327;
					}
					else
					{
						num9 = 836834165;
						num10 = 836834165;
					}
					num = num9 ^ (int)(num2 * 1423426713);
					continue;
				}
				case 0u:
					@default = EqualityComparer<T>.Default;
					num = 1677648051;
					continue;
				case 5u:
					break;
				case 1u:
					throw new ArgumentNullException("source");
				default:
				{
					IEnumerator<T> enumerator = ienumerable_0.GetEnumerator();
					try
					{
						while (true)
						{
							IL_0159:
							int num3;
							int num4;
							if (!enumerator.MoveNext())
							{
								num3 = 1536539821;
								num4 = 1536539821;
							}
							else
							{
								num3 = 1286808718;
								num4 = 1286808718;
							}
							while (true)
							{
								switch ((num2 = (uint)num3 ^ 0x5DA2156Fu) % 8u)
								{
								case 7u:
									num3 = 383222443;
									continue;
								case 6u:
									num3 = 1286808718;
									continue;
								case 3u:
								{
									int num5;
									int num6;
									if (!@default.Equals(current, gparam_0))
									{
										num5 = 148098317;
										num6 = 148098317;
									}
									else
									{
										num5 = 70355154;
										num6 = 70355154;
									}
									num3 = num5 ^ ((int)num2 * -2146185129);
									continue;
								}
								case 1u:
									current = enumerator.Current;
									num3 = 2110054788;
									continue;
								case 0u:
									result = true;
									num3 = ((int)num2 * -73292605) ^ 0x444EF5A2;
									continue;
								default:
									goto end_IL_0118;
								case 4u:
									break;
								case 2u:
									goto end_IL_0118;
								case 5u:
									return result;
								}
								goto IL_0159;
								continue;
								end_IL_0118:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							while (true)
							{
								IL_01a7:
								int num7 = 2104489003;
								while (true)
								{
									switch ((num2 = (uint)num7 ^ 0x5DA2156Fu) % 3u)
									{
									case 2u:
										goto IL_0174;
									default:
										goto end_IL_0189;
									case 0u:
										break;
									case 1u:
										goto end_IL_0189;
									}
									goto IL_01a7;
									IL_0174:
									enumerator.Dispose();
									num7 = ((int)num2 * -4135714) ^ 0x61C85F58;
									continue;
									end_IL_0189:
									break;
								}
								break;
							}
						}
					}
					result = false;
					while (true)
					{
						int num8 = 61719914;
						while (true)
						{
							switch ((num2 = (uint)num8 ^ 0x5DA2156Fu) % 3u)
							{
							case 1u:
								num8 = (int)(num2 * 275861960) ^ -916012395;
								continue;
							case 0u:
								break;
							default:
								goto end_IL_01df;
							}
							break;
						}
						continue;
						end_IL_01df:
						break;
					}
					goto IL_01ee;
				}
				case 6u:
					{
						result = collection.Contains(gparam_0);
						goto IL_01ee;
					}
					IL_01ee:
					return result;
				}
				break;
			}
		}
	}

	[GAttribute0]
	public static IEnumerable<T> smethod_2<T>(IEnumerable<string> ienumerable_0, GDelegate1<string, T> gdelegate1_0)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new Class22<T>(-2)
		{
			ienumerable_1 = ienumerable_0,
			gdelegate1_1 = gdelegate1_0
		};
	}
}
