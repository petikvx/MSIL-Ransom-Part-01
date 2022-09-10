using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;

namespace c;

internal sealed class t
{
	internal struct v
	{
		public string t;

		public Version t;

		public string m;

		public string d;

		public v(string string_0)
		{
			t = null;
			m = string.Empty;
			d = string.Empty;
			this.t = string.Empty;
			Array array = new char[1];
			((char[])array)[0] = ',';
			object obj = v.smethod_7(string_0, (char[])array);
			for (int k = 0; k < (obj as string[]).Length; k++)
			{
				ICloneable cloneable = ((string[])obj)[k];
				IComparable<string> comparable = v.smethod_8(cloneable as string);
				if (v.smethod_9(comparable as string, c.k(1229547658, null, 4)))
				{
					t = v.smethod_11(v.smethod_10((string)comparable, 8));
				}
				else if (v.smethod_9(comparable as string, global::c.v.a.u(0, 7, v.smethod_3(typeof(q).TypeHandle), 1468094718)))
				{
					m = v.smethod_10(comparable as string, 8);
					if (v.smethod_12(m, global::c.v.a.u(1, 3, v.smethod_3(typeof(u).TypeHandle), 1468094681)))
					{
						m = string.Empty;
					}
				}
				else if (v.smethod_9(comparable as string, c.k(1229547653, string_0, 0)))
				{
					d = v.smethod_10((string)comparable, 15);
					if (v.smethod_12(d, c.k(1229547666, string_0, 5)))
					{
						d = string.Empty;
					}
				}
				else
				{
					this.t = comparable as string;
				}
			}
		}

		public string i(bool bool_0)
		{
			byte[] array = h.d;
			object obj = default(object);
			char[] s = default(char[]);
			int num4 = default(int);
			while (true)
			{
				int num = -196920085;
				while (true)
				{
					uint num2;
					int num3;
					switch ((num2 = (uint)num ^ 0x8C3F15B5u) % 10u)
					{
					case 9u:
						while (true)
						{
							switch (num4)
							{
							case 4:
							case 6:
								v.smethod_4(obj as StringBuilder, (object)t);
								num4 = s[391] - 28110;
								continue;
							case 2:
								if (v.smethod_2(t, (Version)null))
								{
									num4 = 0;
									goto case 0;
								}
								num4 = array[101];
								continue;
							case 0:
							case 1:
								v.smethod_1((StringBuilder)obj, global::c.v.a.u(1, 2, v.smethod_3(typeof(p.z).TypeHandle), 1468094676));
								num4 = s[54] - 45246;
								continue;
							case 3:
								goto IL_00aa;
							case 7:
								v.smethod_1(obj as StringBuilder, c.k(1229547675, null, 1));
								v.smethod_1(obj as StringBuilder, (v.smethod_5(m) == 0) ? global::c.v.a.u(5, 0, v.smethod_3(typeof(global::c.v.t).TypeHandle), 1468094685) : m);
								v.smethod_1(obj as StringBuilder, global::c.v.a.u(4, 10, v.smethod_3(typeof(i.q).TypeHandle), 1468094662));
								num4 = 5;
								goto case 5;
							case 5:
							case 8:
								v.smethod_1((StringBuilder)obj, (v.smethod_5(d) == 0) ? c.k(1229547667, null, 4) : d);
								return v.smethod_6((object)(StringBuilder)obj);
							}
							break;
						}
						num = -614523205;
						continue;
					case 8u:
						goto IL_00aa;
					case 7u:
					{
						int num5;
						int num6;
						if (bool_0)
						{
							num5 = 736090340;
							num6 = 736090340;
						}
						else
						{
							num5 = 794698340;
							num6 = 794698340;
						}
						num = num5 ^ ((int)num2 * -1448669457);
						continue;
					}
					default:
						num3 = array[101];
						goto IL_00e2;
					case 4u:
						s = x.s;
						num = (int)((num2 * 1547869196) ^ 0x725A99A2);
						continue;
					case 3u:
						num4 = 3;
						num = ((int)num2 * -1964299795) ^ 0x7A775E49;
						continue;
					case 2u:
						num3 = 2;
						goto IL_00e2;
					case 1u:
						num = ((int)num2 * -908225322) ^ -214541916;
						continue;
					case 0u:
						v.smethod_1(obj as StringBuilder, this.t);
						num = (int)(num2 * 655594264) ^ -74523106;
						continue;
					case 5u:
						break;
						IL_00e2:
						num4 = num3;
						num = -1630534328;
						continue;
						IL_00aa:
						obj = v.smethod_0();
						num = -635132009;
						continue;
					}
					break;
				}
			}
		}

		static StringBuilder smethod_0()
		{
			return new StringBuilder();
		}

		static StringBuilder smethod_1(StringBuilder stringBuilder_0, string string_0)
		{
			return stringBuilder_0.Append(string_0);
		}

		static bool smethod_2(Version version_0, Version version_1)
		{
			return version_0 != version_1;
		}

		static Type smethod_3(RuntimeTypeHandle runtimeTypeHandle_0)
		{
			return Type.GetTypeFromHandle(runtimeTypeHandle_0);
		}

		static StringBuilder smethod_4(StringBuilder stringBuilder_0, object object_0)
		{
			return stringBuilder_0.Append(object_0);
		}

		static int smethod_5(string string_0)
		{
			return string_0.Length;
		}

		static string smethod_6(object object_0)
		{
			return object_0.ToString();
		}

		static string[] smethod_7(string string_0, char[] char_0)
		{
			return string_0.Split(char_0);
		}

		static string smethod_8(string string_0)
		{
			return string_0.Trim();
		}

		static bool smethod_9(string string_0, string string_1)
		{
			return string_0.StartsWith(string_1);
		}

		static string smethod_10(string string_0, int int_0)
		{
			return string_0.Substring(int_0);
		}

		static Version smethod_11(string string_0)
		{
			return new Version(string_0);
		}

		static bool smethod_12(string string_0, string string_1)
		{
			return string_0 == string_1;
		}
	}

	internal const string i = "{71461f04-2faa-4bb9-a0dd-28a79101b599}";

	private const int m = 4;

	internal static Dictionary<string, Assembly> t = new Dictionary<string, Assembly>();

	internal static bool f
	{
		get
		{
			char[] s = x.s;
			byte[] d = h.d;
			bool result = default(bool);
			try
			{
				object obj = default(object);
				while (true)
				{
					IL_0126:
					int num = 4;
					int num2 = 1833660966;
					while (true)
					{
						uint num3;
						int num6;
						switch ((num3 = (uint)num2 ^ 0x6678BFC6u) % 7u)
						{
						case 6u:
						{
							int num4;
							int num5;
							if (!global::c.t.smethod_4((string)obj, c.k(1229547691, null, 0)))
							{
								num4 = 1347801218;
								num5 = 1347801218;
							}
							else
							{
								num4 = 216468092;
								num5 = 216468092;
							}
							num2 = num4 ^ (int)(num3 * 550131604);
							continue;
						}
						case 5u:
							num6 = 7;
							goto IL_0051;
						default:
							num6 = s[452] - 3841;
							goto IL_0051;
						case 2u:
							while (true)
							{
								switch (num)
								{
								case 0:
								case 5:
									break;
								default:
									goto end_IL_00a7;
								case 4:
								case 6:
									goto IL_00d4;
								case 2:
									goto end_IL_00f6;
								case 3:
									result = true;
									return result;
								case 1:
								case 7:
									result = true;
									return result;
								}
								num = ((!global::c.t.smethod_4(obj as string, global::c.v.a.u(0, 1, global::c.t.smethod_5(typeof(i.q).TypeHandle), 1468094691))) ? (s[546] - 45508) : d[276]);
								continue;
								end_IL_00a7:
								break;
							}
							num2 = 588117586;
							continue;
						case 1u:
							goto IL_00d4;
						case 0u:
							num2 = 1458958778;
							continue;
						case 3u:
							break;
							IL_00d4:
							obj = global::c.t.smethod_3(global::c.t.smethod_2(global::c.t.smethod_1(global::c.t.smethod_0())));
							num2 = 312829110;
							continue;
							IL_0051:
							num = num6;
							num2 = 1833660966;
							continue;
						}
						goto IL_0126;
						continue;
						end_IL_00f6:
						break;
					}
					break;
				}
			}
			catch
			{
			}
			while (true)
			{
				int num7 = 4;
				int num8 = 1827340214;
				while (true)
				{
					uint num3;
					switch ((num3 = (uint)num8 ^ 0x6678BFC6u) % 5u)
					{
					case 2u:
						switch (num7)
						{
						case 0:
						case 2:
						case 4:
							goto IL_019c;
						case 1:
						case 3:
							goto IL_019e;
						}
						num8 = ((int)num3 * -9830062) ^ 0x4AC571FE;
						continue;
					case 0u:
						num8 = 224547166;
						continue;
					case 3u:
						break;
					case 4u:
						goto IL_019c;
					default:
						goto IL_019e;
						IL_019e:
						return result;
						IL_019c:
						return false;
					}
					break;
				}
			}
		}
	}

	static Process smethod_0()
	{
		return Process.GetCurrentProcess();
	}

	static ProcessModule smethod_1(Process process_0)
	{
		return process_0.MainModule;
	}

	static string smethod_2(ProcessModule processModule_0)
	{
		return processModule_0.ModuleName;
	}

	static string smethod_3(string string_0)
	{
		return string_0.ToLower();
	}

	static bool smethod_4(string string_0, string string_1)
	{
		return string_0 == string_1;
	}

	static Type smethod_5(RuntimeTypeHandle runtimeTypeHandle_0)
	{
		return Type.GetTypeFromHandle(runtimeTypeHandle_0);
	}
}
