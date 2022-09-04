using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security;
using Evaluation;

namespace ns0;

internal sealed class Class1
{
	private sealed class Class2
	{
		public static readonly Class2 class2_0;

		internal byte[] byte_0;

		[SecuritySafeCritical]
		static Class2()
		{
			if (DateTime.Now > new DateTime(634925624809544226L))
			{
				throw new Exception();
			}
			class2_0 = new Class2();
		}

		private Class2()
		{
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream(smethod_1());
			if (manifestResourceStream != null)
			{
				byte[] array = (byte_0 = new byte[256]);
				manifestResourceStream.Read(byte_0, 0, byte_0.Length);
			}
			Class3.smethod_12();
		}

		public string method_0(string string_0, int int_0)
		{
			int num = string_0.Length;
			int num2 = int_0 & 0xFF;
			char[] array = string_0.ToCharArray();
			while (--num >= 0)
			{
				array[num] = (char)(array[num] ^ (byte_0[num2] | int_0));
			}
			return string.Intern(new string(array));
		}
	}

	internal sealed class Class3
	{
		internal sealed class Class4
		{
			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 20584)]
			private struct Struct0
			{
			}

			[StructLayout(LayoutKind.Explicit, Pack = 1, Size = 300)]
			private struct Struct1
			{
			}

			internal static byte byte_0/* Not supported: data(00) */;

			private static readonly object object_0;

			private static readonly Array array_0;

			private static readonly object object_1;

			internal static byte byte_1/* Not supported: data(00) */;

			internal static Type smethod_0()
			{
				smethod_0();
				return typeof(_003CModule_003E);
			}

			[SecuritySafeCritical]
			internal static byte smethod_1()
			{
				AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", null);
				return 21;
			}

			[SecuritySafeCritical]
			internal static Type smethod_2()
			{
				AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", null);
				return typeof(_003CModule_003E);
			}

			internal static string smethod_3()
			{
				smethod_3();
				return null;
			}

			[SecuritySafeCritical]
			internal static Type smethod_4()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						Class3.smethod_5();
					}
					num++;
					if (array[num] >= 207)
					{
						if (207 != array[num])
						{
							Class3.smethod_1();
						}
						num++;
						if (array[num] >= 173)
						{
							if (173 != array[num])
							{
								Class6.smethod_0();
							}
							num++;
							if (array[num] >= 229)
							{
								if (229 != array[num])
								{
									smethod_1();
								}
								num++;
								if (array[num] >= 167)
								{
									if (167 != array[num])
									{
										Class6.smethod_2();
									}
									num++;
									return typeof(Class0);
								}
								return typeof(Class6);
							}
							return typeof(DeepSeaObfuscator);
						}
						return typeof(Class2);
					}
					return typeof(Class6);
				}
				return typeof(Class6);
			}

			[SecuritySafeCritical]
			internal static byte smethod_5()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						Class3.smethod_4();
					}
					num++;
					if (array[num] >= 207)
					{
						if (207 != array[num])
						{
							Class1.smethod_2();
						}
						num++;
						if (array[num] >= 173)
						{
							if (173 != array[num])
							{
								smethod_0();
							}
							num++;
							if (array[num] >= 229)
							{
								if (229 != array[num])
								{
									smethod_2();
								}
								num++;
								if (array[num] >= 167)
								{
									if (167 != array[num])
									{
										Class3.smethod_3();
									}
									num++;
									if (array[num] >= 32)
									{
										if (32 != array[num])
										{
											smethod_0();
										}
										num++;
										if (array[num] >= 213)
										{
											if (213 != array[num])
											{
												Class3.smethod_1();
											}
											num++;
											return 6;
										}
										return 20;
									}
									return 4;
								}
								return 13;
							}
							return 15;
						}
						return 30;
					}
					return 7;
				}
				return 8;
			}

			[SecuritySafeCritical]
			internal static object smethod_6()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						Class1.smethod_3();
					}
					num++;
					if (array[num] >= 207)
					{
						if (207 != array[num])
						{
							Class6.smethod_1();
						}
						num++;
						if (array[num] >= 173)
						{
							if (173 != array[num])
							{
								Class1.smethod_3();
							}
							num++;
							if (array[num] >= 229)
							{
								if (229 != array[num])
								{
									Class3.smethod_5();
								}
								num++;
								if (array[num] >= 167)
								{
									if (167 != array[num])
									{
										Class1.smethod_2();
									}
									num++;
									if (array[num] >= 32)
									{
										if (32 != array[num])
										{
											Class1.smethod_3();
										}
										num++;
										return null;
									}
									return null;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}

			[SecuritySafeCritical]
			internal static int smethod_7()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						Class6.smethod_0();
					}
					num++;
					if (array[num] >= 207)
					{
						if (207 != array[num])
						{
							Class1.smethod_2();
						}
						num++;
						if (array[num] >= 173)
						{
							if (173 != array[num])
							{
								Class6.smethod_1();
							}
							num++;
							return 6;
						}
						return 3;
					}
					return 4;
				}
				return 15;
			}

			static Class4()
			{
				array_0 = new char[150];
				char[] array = new char[8];
				array[0] = 'ㆳ';
				array[2] = 'ᱤ';
				array[4] = '⽌';
				array[6] = 'ଣ';
				array[5] = '⸥';
				array[7] = '㸅';
				array[1] = 'މ';
				array[3] = '㥴';
				object_1 = new string[6];
				object_0 = array;
			}
		}

		internal sealed class Class5
		{
			[SecuritySafeCritical]
			internal static string smethod_0()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						Class4.smethod_1();
					}
					num++;
					if (array[num] >= 207)
					{
						if (207 != array[num])
						{
							Class3.smethod_1();
						}
						num++;
						if (array[num] >= 173)
						{
							if (173 != array[num])
							{
								Class1.smethod_3();
							}
							num++;
							if (array[num] >= 229)
							{
								if (229 != array[num])
								{
									Class1.smethod_3();
								}
								num++;
								if (array[num] >= 167)
								{
									if (167 != array[num])
									{
										Class4.smethod_0();
									}
									num++;
									if (array[num] >= 32)
									{
										if (32 != array[num])
										{
											smethod_5();
										}
										num++;
										if (array[num] >= 213)
										{
											if (213 != array[num])
											{
												Class3.smethod_1();
											}
											num++;
											if (array[num] >= 18)
											{
												if (18 != array[num])
												{
													Class4.smethod_1();
												}
												num++;
												return null;
											}
											return null;
										}
										return null;
									}
									return null;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}

			[SecuritySafeCritical]
			internal static long smethod_1()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						smethod_4();
					}
					num++;
					return 4L;
				}
				return 14L;
			}

			[SecuritySafeCritical]
			internal static object smethod_2()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						Class1.smethod_2();
					}
					num++;
					return null;
				}
				return null;
			}

			[SecuritySafeCritical]
			internal static string smethod_3()
			{
				int num = 0;
				byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
				if (array[0] >= 8)
				{
					if (8 != array[num])
					{
						Class4.smethod_2();
					}
					num++;
					if (array[num] >= 207)
					{
						if (207 != array[num])
						{
							Class4.smethod_2();
						}
						num++;
						if (array[num] >= 173)
						{
							if (173 != array[num])
							{
								Class6.smethod_1();
							}
							num++;
							if (array[num] >= 229)
							{
								if (229 != array[num])
								{
									Class3.smethod_1();
								}
								num++;
								if (array[num] >= 167)
								{
									if (167 != array[num])
									{
										Class6.smethod_0();
									}
									num++;
									return null;
								}
								return null;
							}
							return null;
						}
						return null;
					}
					return null;
				}
				return null;
			}
		}

		private static bool bool_0;

		[SecuritySafeCritical]
		internal static Type smethod_0()
		{
			AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", null);
			return typeof(DeepSeaObfuscator);
		}

		[SecuritySafeCritical]
		internal static string smethod_1()
		{
			AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", null);
			return null;
		}

		[SecuritySafeCritical]
		internal static object smethod_2()
		{
			AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", null);
			return null;
		}

		[SecuritySafeCritical]
		internal static void smethod_3()
		{
			AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", null);
		}

		internal static long smethod_4()
		{
			smethod_4();
			return 6L;
		}

		[SecuritySafeCritical]
		internal static long smethod_5()
		{
			AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", null);
			return 15L;
		}

		internal static string smethod_6()
		{
			smethod_6();
			return null;
		}

		[SecuritySafeCritical]
		internal static void smethod_7()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] < 8)
			{
				return;
			}
			if (8 != array[num])
			{
				smethod_1();
			}
			num++;
			if (array[num] < 207)
			{
				return;
			}
			if (207 != array[num])
			{
				Class4.smethod_2();
			}
			num++;
			if (array[num] >= 173)
			{
				if (173 != array[num])
				{
					smethod_6();
				}
				num++;
			}
		}

		[SecuritySafeCritical]
		internal static int smethod_8()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.smethod_1();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						Class6.smethod_2();
					}
					num++;
					return 0;
				}
				return 5;
			}
			return 4;
		}

		[SecuritySafeCritical]
		internal static Type smethod_9()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.smethod_0();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						smethod_4();
					}
					num++;
					if (array[num] >= 173)
					{
						if (173 != array[num])
						{
							Class6.smethod_1();
						}
						num++;
						if (array[num] >= 229)
						{
							if (229 != array[num])
							{
								smethod_6();
							}
							num++;
							if (array[num] >= 167)
							{
								if (167 != array[num])
								{
									smethod_1();
								}
								num++;
								if (array[num] >= 32)
								{
									if (32 != array[num])
									{
										smethod_4();
									}
									num++;
									return typeof(Struct2);
								}
								return typeof(Struct2);
							}
							return typeof(Struct3);
						}
						return typeof(Struct2);
					}
					return typeof(Class0);
				}
				return typeof(BabelAttribute);
			}
			return typeof(Class6);
		}

		[SecuritySafeCritical]
		internal static Type smethod_10()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.smethod_0();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						Class4.smethod_1();
					}
					num++;
					if (array[num] >= 173)
					{
						if (173 != array[num])
						{
							Class1.smethod_2();
						}
						num++;
						if (array[num] >= 229)
						{
							if (229 != array[num])
							{
								smethod_3();
							}
							num++;
							if (array[num] >= 167)
							{
								if (167 != array[num])
								{
									smethod_4();
								}
								num++;
								if (array[num] >= 32)
								{
									if (32 != array[num])
									{
										smethod_2();
									}
									num++;
									if (array[num] >= 213)
									{
										if (213 != array[num])
										{
											Class1.smethod_2();
										}
										num++;
										return typeof(Struct2);
									}
									return typeof(Class2);
								}
								return typeof(BabelAttribute);
							}
							return typeof(BabelAttribute);
						}
						return typeof(DeepSeaObfuscator);
					}
					return typeof(DeepSeaObfuscator);
				}
				return typeof(_003CModule_003E);
			}
			return typeof(Struct3);
		}

		[SecuritySafeCritical]
		internal static void smethod_11()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] < 8)
			{
				return;
			}
			if (8 != array[num])
			{
				smethod_2();
			}
			num++;
			if (array[num] < 207)
			{
				return;
			}
			if (207 != array[num])
			{
				smethod_3();
			}
			num++;
			if (array[num] < 173)
			{
				return;
			}
			if (173 != array[num])
			{
				smethod_5();
			}
			num++;
			if (array[num] < 229)
			{
				return;
			}
			if (229 != array[num])
			{
				smethod_5();
			}
			num++;
			if (array[num] < 167)
			{
				return;
			}
			if (167 != array[num])
			{
				smethod_3();
			}
			num++;
			if (array[num] < 32)
			{
				return;
			}
			if (32 != array[num])
			{
				smethod_5();
			}
			num++;
			if (array[num] < 213)
			{
				return;
			}
			if (213 != array[num])
			{
				smethod_6();
			}
			num++;
			if (array[num] >= 18)
			{
				if (18 != array[num])
				{
					Class6.smethod_1();
				}
				num++;
			}
		}

		[SecuritySafeCritical]
		internal static int smethod_12()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					smethod_0();
				}
				num++;
				return 11;
			}
			return 12;
		}

		[SecuritySafeCritical]
		internal static object smethod_13()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class1.smethod_3();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						Class6.smethod_2();
					}
					num++;
					return null;
				}
				return null;
			}
			return null;
		}

		[SecuritySafeCritical]
		internal static byte smethod_14()
		{
			int num = 0;
			byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
			if (array[0] >= 8)
			{
				if (8 != array[num])
				{
					Class4.smethod_0();
				}
				num++;
				if (array[num] >= 207)
				{
					if (207 != array[num])
					{
						Class4.smethod_2();
					}
					num++;
					if (array[num] >= 173)
					{
						if (173 != array[num])
						{
							smethod_2();
						}
						num++;
						if (array[num] >= 229)
						{
							if (229 != array[num])
							{
								Class4.smethod_0();
							}
							num++;
							if (array[num] >= 167)
							{
								if (167 != array[num])
								{
									smethod_3();
								}
								num++;
								if (array[num] >= 32)
								{
									if (32 != array[num])
									{
										Class4.smethod_0();
									}
									num++;
									return 17;
								}
								return 21;
							}
							return 29;
						}
						return 6;
					}
					return 17;
				}
				return 0;
			}
			return 15;
		}

		[SecuritySafeCritical]
		internal static int smethod_15()
		{
			byte[] bytes = BitConverter.GetBytes(DateTime.UtcNow.Ticks);
			AppDomain.CurrentDomain.SetData("1d3dbcb35e234a0897c6c7a522b19667", bytes);
			if (BitConverter.IsLittleEndian)
			{
				Array.Reverse((Array)bytes);
			}
			return 7;
		}
	}

	public Class1()
	{
		smethod_4();
	}

	public static string smethod_0(string string_0, int int_0)
	{
		if (DateTime.Now > new DateTime(634925624810064255L))
		{
			throw new Exception();
		}
		string result = string.Intern(Class2.class2_0.method_0(string_0, int_0));
		Class3.Class4.smethod_6();
		return result;
	}

	[SpecialName]
	public static string smethod_1()
	{
		Class3.Class5.smethod_3();
		return "828d03eb501144ee860b330bfa913124";
	}

	internal static byte smethod_2()
	{
		smethod_2();
		return 5;
	}

	internal static void smethod_3()
	{
		smethod_3();
	}

	[SecuritySafeCritical]
	internal static string smethod_4()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.Class4.smethod_1();
			}
			num++;
			return null;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static string smethod_5()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_5();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class3.smethod_0();
				}
				num++;
				if (array[num] >= 173)
				{
					if (173 != array[num])
					{
						Class3.Class4.smethod_2();
					}
					num++;
					if (array[num] >= 229)
					{
						if (229 != array[num])
						{
							Class6.smethod_1();
						}
						num++;
						return null;
					}
					return null;
				}
				return null;
			}
			return null;
		}
		return null;
	}

	[SecuritySafeCritical]
	internal static long smethod_6()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_5();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class3.Class4.smethod_1();
				}
				num++;
				if (array[num] >= 173)
				{
					if (173 != array[num])
					{
						Class3.smethod_6();
					}
					num++;
					if (array[num] >= 229)
					{
						if (229 != array[num])
						{
							Class3.Class4.smethod_2();
						}
						num++;
						if (array[num] >= 167)
						{
							if (167 != array[num])
							{
								Class3.smethod_3();
							}
							num++;
							if (array[num] >= 32)
							{
								if (32 != array[num])
								{
									Class3.smethod_2();
								}
								num++;
								if (array[num] >= 213)
								{
									if (213 != array[num])
									{
										Class3.Class4.smethod_1();
									}
									num++;
									return 9L;
								}
								return 15L;
							}
							return 14L;
						}
						return 10L;
					}
					return 6L;
				}
				return 14L;
			}
			return 7L;
		}
		return 10L;
	}

	[SecuritySafeCritical]
	internal static int smethod_7()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class6.smethod_0();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					smethod_3();
				}
				num++;
				if (array[num] >= 173)
				{
					if (173 != array[num])
					{
						Class3.smethod_1();
					}
					num++;
					if (array[num] >= 229)
					{
						if (229 != array[num])
						{
							Class3.smethod_0();
						}
						num++;
						return 12;
					}
					return 5;
				}
				return 9;
			}
			return 9;
		}
		return 8;
	}

	[SecuritySafeCritical]
	internal static void smethod_8()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			Class3.smethod_5();
		}
		num++;
		if (array[num] < 207)
		{
			return;
		}
		if (207 != array[num])
		{
			Class3.smethod_5();
		}
		num++;
		if (array[num] < 173)
		{
			return;
		}
		if (173 != array[num])
		{
			Class6.smethod_1();
		}
		num++;
		if (array[num] < 229)
		{
			return;
		}
		if (229 != array[num])
		{
			Class3.Class4.smethod_2();
		}
		num++;
		if (array[num] >= 167)
		{
			if (167 != array[num])
			{
				Class3.smethod_4();
			}
			num++;
		}
	}

	[SecuritySafeCritical]
	internal static long smethod_9()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_3();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class6.smethod_1();
				}
				num++;
				if (array[num] >= 173)
				{
					if (173 != array[num])
					{
						Class3.smethod_3();
					}
					num++;
					if (array[num] >= 229)
					{
						if (229 != array[num])
						{
							Class3.smethod_6();
						}
						num++;
						return 6L;
					}
					return 6L;
				}
				return 9L;
			}
			return 9L;
		}
		return 14L;
	}

	[SecuritySafeCritical]
	internal static Type smethod_10()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_4();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					smethod_2();
				}
				num++;
				if (array[num] >= 173)
				{
					if (173 != array[num])
					{
						Class3.smethod_6();
					}
					num++;
					if (array[num] >= 229)
					{
						if (229 != array[num])
						{
							Class3.smethod_2();
						}
						num++;
						if (array[num] >= 167)
						{
							if (167 != array[num])
							{
								Class6.smethod_1();
							}
							num++;
							return typeof(BabelAttribute);
						}
						return typeof(Struct2);
					}
					return typeof(_003CModule_003E);
				}
				return typeof(_003CModule_003E);
			}
			return typeof(_003CModule_003E);
		}
		return typeof(Class1);
	}

	[SecuritySafeCritical]
	internal static void smethod_11()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] < 8)
		{
			return;
		}
		if (8 != array[num])
		{
			Class3.smethod_1();
		}
		num++;
		if (array[num] < 207)
		{
			return;
		}
		if (207 != array[num])
		{
			smethod_3();
		}
		num++;
		if (array[num] < 173)
		{
			return;
		}
		if (173 != array[num])
		{
			Class6.smethod_1();
		}
		num++;
		if (array[num] < 229)
		{
			return;
		}
		if (229 != array[num])
		{
			Class3.smethod_1();
		}
		num++;
		if (array[num] < 167)
		{
			return;
		}
		if (167 != array[num])
		{
			smethod_3();
		}
		num++;
		if (array[num] < 32)
		{
			return;
		}
		if (32 != array[num])
		{
			Class3.smethod_6();
		}
		num++;
		if (array[num] >= 213)
		{
			if (213 != array[num])
			{
				smethod_3();
			}
			num++;
		}
	}

	[SecuritySafeCritical]
	internal static byte smethod_12()
	{
		int num = 0;
		byte[] array = (byte[])AppDomain.CurrentDomain.GetData("1d3dbcb35e234a0897c6c7a522b19667");
		if (array[0] >= 8)
		{
			if (8 != array[num])
			{
				Class3.smethod_0();
			}
			num++;
			if (array[num] >= 207)
			{
				if (207 != array[num])
				{
					Class3.smethod_2();
				}
				num++;
				if (array[num] >= 173)
				{
					if (173 != array[num])
					{
						Class3.smethod_5();
					}
					num++;
					if (array[num] >= 229)
					{
						if (229 != array[num])
						{
							Class3.smethod_4();
						}
						num++;
						if (array[num] >= 167)
						{
							if (167 != array[num])
							{
								Class3.smethod_6();
							}
							num++;
							if (array[num] >= 32)
							{
								if (32 != array[num])
								{
									Class6.smethod_0();
								}
								num++;
								if (array[num] >= 213)
								{
									if (213 != array[num])
									{
										Class3.Class4.smethod_0();
									}
									num++;
									if (array[num] >= 18)
									{
										if (18 != array[num])
										{
											Class3.Class4.smethod_2();
										}
										num++;
										return 0;
									}
									return 8;
								}
								return 12;
							}
							return 18;
						}
						return 27;
					}
					return 24;
				}
				return 28;
			}
			return 4;
		}
		return 18;
	}
}
