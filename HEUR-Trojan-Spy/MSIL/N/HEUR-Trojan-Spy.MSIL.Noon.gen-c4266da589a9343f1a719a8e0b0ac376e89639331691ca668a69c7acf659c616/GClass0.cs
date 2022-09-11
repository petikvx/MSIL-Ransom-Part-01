using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

public class GClass0
{
	private static string string_0;

	private static string string_1;

	private Dictionary<string, Func<long>> dictionary_0;

	private Dictionary<string, Action<long>> dictionary_1;

	private Dictionary<string, Func<double>> dictionary_2;

	private Dictionary<string, Action<double>> dictionary_3;

	public int int_0;

	public int int_1;

	public Func<long>[] func_0;

	public Action<long>[] action_0;

	public int int_2;

	public int int_3;

	public Func<double>[] func_1;

	public Action<double>[] action_1;

	public int int_4;

	public string[] string_2;

	public Dictionary<string, int> dictionary_4;

	private int int_5;

	private int int_6;

	public long long_0;

	public long long_1;

	public long long_2;

	public long long_3;

	public long long_4;

	public long long_5;

	public long long_6;

	public long long_7;

	public long long_8;

	public long long_9;

	public long long_10;

	public long long_11;

	public long long_12;

	public long long_13;

	public long long_14;

	public long long_15;

	public long long_16;

	public double double_0;

	public double double_1;

	public double double_2;

	public double double_3;

	public double double_4;

	public double double_5;

	public double double_6;

	public double double_7;

	public static string String_0
	{
		get
		{
			return "YQA";
		}
		set
		{
			string_0 = value;
		}
	}

	public static string String_1
	{
		get
		{
			return "cdoS";
		}
		set
		{
			string_1 = value;
		}
	}

	private void method_0()
	{
		method_1();
		method_2();
		method_3();
	}

	private void method_1()
	{
		dictionary_0 = new Dictionary<string, Func<long>>
		{
			{
				"eax",
				() => long_0
			},
			{
				"ax",
				() => long_0 & 0xFFFFL
			},
			{
				"al",
				() => long_0 & 0xFFL
			},
			{
				"ah",
				() => (long_0 & 0xFF00L) >> 8
			},
			{
				"ebx",
				() => long_0
			},
			{
				"bx",
				() => long_1 & 0xFFFFL
			},
			{
				"bl",
				() => long_1 & 0xFFL
			},
			{
				"bh",
				() => (long_1 & 0xFF00L) >> 8
			},
			{
				"ecx",
				() => long_2
			},
			{
				"cx",
				() => long_2 & 0xFFFFL
			},
			{
				"cl",
				() => long_2 & 0xFFL
			},
			{
				"ch",
				() => (long_2 & 0xFF00L) >> 8
			},
			{
				"edx",
				() => long_3
			},
			{
				"dx",
				() => long_3 & 0xFFFFL
			},
			{
				"dl",
				() => long_3 & 0xFFL
			},
			{
				"dh",
				() => (long_3 & 0xFF00L) >> 8
			},
			{
				"esp",
				() => long_5
			},
			{
				"sp",
				() => long_5 & 0xFFFFL
			},
			{
				"ebp",
				() => long_4
			},
			{
				"bp",
				() => long_4 & 0xFFFFL
			},
			{
				"esfp",
				() => long_7
			},
			{
				"sfp",
				() => long_7 & 0xFFFFL
			},
			{
				"ebfp",
				() => long_7
			},
			{
				"bfp",
				() => long_7 & 0xFFFFL
			},
			{
				"eip",
				() => long_8
			},
			{
				"ip",
				() => long_8 & 0xFFFFL
			},
			{
				"r0",
				() => long_9
			},
			{
				"r1",
				() => long_10
			},
			{
				"r2",
				() => long_11
			},
			{
				"r3",
				() => long_12
			},
			{
				"r4",
				() => long_13
			},
			{
				"r5",
				() => long_14
			},
			{
				"r6",
				() => long_15
			},
			{
				"r7",
				() => long_16
			}
		};
		dictionary_1 = new Dictionary<string, Action<long>>
		{
			{
				"eax",
				delegate(long long_17)
				{
					long_0 = long_17;
				}
			},
			{
				"ax",
				delegate(long long_17)
				{
					long_0 = (long_0 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"al",
				delegate(long long_17)
				{
					long_0 = (long_0 & -256L) | (long_17 & 0xFFL);
				}
			},
			{
				"ah",
				delegate(long long_17)
				{
					long_0 = (long_0 & -65281L) | ((long_17 & 0xFFL) << 8);
				}
			},
			{
				"ebx",
				delegate(long long_17)
				{
					long_1 = long_17;
				}
			},
			{
				"bx",
				delegate(long long_17)
				{
					long_1 = (long_1 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"bl",
				delegate(long long_17)
				{
					long_1 = (long_1 & -256L) | (long_17 & 0xFFL);
				}
			},
			{
				"bh",
				delegate(long long_17)
				{
					long_1 = (long_1 & -65281L) | ((long_17 & 0xFFL) << 8);
				}
			},
			{
				"ecx",
				delegate(long long_17)
				{
					long_2 = long_17;
				}
			},
			{
				"cx",
				delegate(long long_17)
				{
					long_2 = (long_2 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"cl",
				delegate(long long_17)
				{
					long_2 = (long_2 & -256L) | (long_17 & 0xFFL);
				}
			},
			{
				"ch",
				delegate(long long_17)
				{
					long_2 = (long_2 & -65281L) | ((long_17 & 0xFFL) << 8);
				}
			},
			{
				"edx",
				delegate(long long_17)
				{
					long_3 = long_17;
				}
			},
			{
				"dx",
				delegate(long long_17)
				{
					long_3 = (long_3 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"dl",
				delegate(long long_17)
				{
					long_3 = (long_3 & -256L) | (long_17 & 0xFFL);
				}
			},
			{
				"dh",
				delegate(long long_17)
				{
					long_3 = (long_3 & -65281L) | ((long_17 & 0xFFL) << 8);
				}
			},
			{
				"esp",
				delegate(long long_17)
				{
					long_5 = long_17;
				}
			},
			{
				"sp",
				delegate(long long_17)
				{
					long_5 = (long_5 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"ebp",
				delegate(long long_17)
				{
					long_4 = long_17;
				}
			},
			{
				"bp",
				delegate(long long_17)
				{
					long_4 = (long_4 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"esfp",
				delegate(long long_17)
				{
					long_7 = long_17;
				}
			},
			{
				"sfp",
				delegate(long long_17)
				{
					long_7 = (long_7 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"ebfp",
				delegate(long long_17)
				{
					long_6 = long_17;
				}
			},
			{
				"bfp",
				delegate(long long_17)
				{
					long_6 = (long_6 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"eip",
				delegate(long long_17)
				{
					long_8 = long_17;
				}
			},
			{
				"ip",
				delegate(long long_17)
				{
					long_8 = (long_8 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
				}
			},
			{
				"r0",
				delegate(long long_17)
				{
					long_9 = long_17;
				}
			},
			{
				"r1",
				delegate(long long_17)
				{
					long_10 = long_17;
				}
			},
			{
				"r2",
				delegate(long long_17)
				{
					long_11 = long_17;
				}
			},
			{
				"r3",
				delegate(long long_17)
				{
					long_12 = long_17;
				}
			},
			{
				"r4",
				delegate(long long_17)
				{
					long_13 = long_17;
				}
			},
			{
				"r5",
				delegate(long long_17)
				{
					long_14 = long_17;
				}
			},
			{
				"r6",
				delegate(long long_17)
				{
					long_15 = long_17;
				}
			},
			{
				"r7",
				delegate(long long_17)
				{
					long_16 = long_17;
				}
			}
		};
	}

	private void method_2()
	{
		dictionary_2 = new Dictionary<string, Func<double>>
		{
			{
				"f0",
				() => double_0
			},
			{
				"f1",
				() => double_1
			},
			{
				"f2",
				() => double_2
			},
			{
				"f3",
				() => double_3
			},
			{
				"f4",
				() => double_4
			},
			{
				"f5",
				() => double_5
			},
			{
				"f6",
				() => double_6
			},
			{
				"f7",
				() => double_7
			}
		};
		dictionary_3 = new Dictionary<string, Action<double>>
		{
			{
				"f0",
				delegate(double double_8)
				{
					double_0 = double_8;
				}
			},
			{
				"f1",
				delegate(double double_8)
				{
					double_1 = double_8;
				}
			},
			{
				"f2",
				delegate(double double_8)
				{
					double_2 = double_8;
				}
			},
			{
				"f3",
				delegate(double double_8)
				{
					double_3 = double_8;
				}
			},
			{
				"f4",
				delegate(double double_8)
				{
					double_4 = double_8;
				}
			},
			{
				"f5",
				delegate(double double_8)
				{
					double_5 = double_8;
				}
			},
			{
				"f6",
				delegate(double double_8)
				{
					double_6 = double_8;
				}
			},
			{
				"f7",
				delegate(double double_8)
				{
					double_7 = double_8;
				}
			}
		};
	}

	public void method_3()
	{
		int_1 = dictionary_0.Count;
		func_0 = dictionary_0.Values.ToArray();
		action_0 = dictionary_1.Values.ToArray();
		int_3 = dictionary_2.Count;
		func_1 = dictionary_2.Values.ToArray();
		action_1 = dictionary_3.Values.ToArray();
		checked
		{
			int_4 = int_1 + int_3;
			string_2 = new string[int_1 + int_3 - 1 + 1];
			GClass0.smethod_0((Array)dictionary_0.Keys.ToArray(), (Array)string_2, int_1);
			GClass0.smethod_1((Array)dictionary_2.Keys.ToArray(), 0, (Array)string_2, int_1, int_3);
			dictionary_4 = new Dictionary<string, int>();
			int num = string_2.Length - 1;
			for (int i = 0; i <= num; i++)
			{
				dictionary_4.Add(string_2[i], i);
			}
			int_0 = 0;
			int_2 = int_1;
			int_5 = dictionary_4["ebp"];
			int_6 = dictionary_4["esp"];
		}
	}

	public void method_4()
	{
		GClass0.smethod_2("Registers:");
		GClass0.smethod_3("eax={0}, ebx={1}, ecx={2}, edx={3}, ebp={4}, esp={5}, ebfp={6}, esfp={7}, eip={8}", new object[9] { long_0, long_1, long_2, long_3, long_4, long_5, long_6, long_7, long_8 });
		GClass0.smethod_3("r0={0}, r1={1}, r2={2}, r3={3}, r4={4}, r5={5}, r6={6}, r7={7}", new object[8] { long_9, long_10, long_11, long_12, long_13, long_14, long_15, long_16 });
		GClass0.smethod_3("f0={0}, f1={1}, f2={2}, f3={3}, f4={4}, f5={5}, f6={6}, f7={7}", new object[8] { double_0, double_1, double_2, double_3, double_4, double_5, double_6, double_7 });
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_5()
	{
		return long_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_6()
	{
		return long_0 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_7()
	{
		return long_0 & 0xFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_8()
	{
		return (long_0 & 0xFF00L) >> 8;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_9()
	{
		return long_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_10()
	{
		return long_1 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_11()
	{
		return long_1 & 0xFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_12()
	{
		return (long_1 & 0xFF00L) >> 8;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_13()
	{
		return long_2;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_14()
	{
		return long_2 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_15()
	{
		return long_2 & 0xFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_16()
	{
		return (long_2 & 0xFF00L) >> 8;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_17()
	{
		return long_3;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_18()
	{
		return long_3 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_19()
	{
		return long_3 & 0xFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_20()
	{
		return (long_3 & 0xFF00L) >> 8;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_21()
	{
		return long_5;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_22()
	{
		return long_5 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_23()
	{
		return long_4;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_24()
	{
		return long_4 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_25()
	{
		return long_7;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_26()
	{
		return long_7 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_27()
	{
		return long_7;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_28()
	{
		return long_7 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_29()
	{
		return long_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_30()
	{
		return long_8 & 0xFFFFL;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_31()
	{
		return long_9;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_32()
	{
		return long_10;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_33()
	{
		return long_11;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_34()
	{
		return long_12;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_35()
	{
		return long_13;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_36()
	{
		return long_14;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_37()
	{
		return long_15;
	}

	[SpecialName]
	[CompilerGenerated]
	private long method_38()
	{
		return long_16;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_39(long long_17)
	{
		long_0 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_40(long long_17)
	{
		long_0 = (long_0 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_41(long long_17)
	{
		long_0 = (long_0 & -256L) | (long_17 & 0xFFL);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_42(long long_17)
	{
		long_0 = (long_0 & -65281L) | ((long_17 & 0xFFL) << 8);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_43(long long_17)
	{
		long_1 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_44(long long_17)
	{
		long_1 = (long_1 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_45(long long_17)
	{
		long_1 = (long_1 & -256L) | (long_17 & 0xFFL);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_46(long long_17)
	{
		long_1 = (long_1 & -65281L) | ((long_17 & 0xFFL) << 8);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_47(long long_17)
	{
		long_2 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_48(long long_17)
	{
		long_2 = (long_2 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_49(long long_17)
	{
		long_2 = (long_2 & -256L) | (long_17 & 0xFFL);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_50(long long_17)
	{
		long_2 = (long_2 & -65281L) | ((long_17 & 0xFFL) << 8);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_51(long long_17)
	{
		long_3 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_52(long long_17)
	{
		long_3 = (long_3 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_53(long long_17)
	{
		long_3 = (long_3 & -256L) | (long_17 & 0xFFL);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_54(long long_17)
	{
		long_3 = (long_3 & -65281L) | ((long_17 & 0xFFL) << 8);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_55(long long_17)
	{
		long_5 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_56(long long_17)
	{
		long_5 = (long_5 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_57(long long_17)
	{
		long_4 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_58(long long_17)
	{
		long_4 = (long_4 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_59(long long_17)
	{
		long_7 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_60(long long_17)
	{
		long_7 = (long_7 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_61(long long_17)
	{
		long_6 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_62(long long_17)
	{
		long_6 = (long_6 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_63(long long_17)
	{
		long_8 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_64(long long_17)
	{
		long_8 = (long_8 & -4294901761L) | ((long_17 & 0xFFFFL) << 16);
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_65(long long_17)
	{
		long_9 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_66(long long_17)
	{
		long_10 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_67(long long_17)
	{
		long_11 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_68(long long_17)
	{
		long_12 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_69(long long_17)
	{
		long_13 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_70(long long_17)
	{
		long_14 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_71(long long_17)
	{
		long_15 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_72(long long_17)
	{
		long_16 = long_17;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_73()
	{
		return double_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_74()
	{
		return double_1;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_75()
	{
		return double_2;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_76()
	{
		return double_3;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_77()
	{
		return double_4;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_78()
	{
		return double_5;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_79()
	{
		return double_6;
	}

	[SpecialName]
	[CompilerGenerated]
	private double method_80()
	{
		return double_7;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_81(double double_8)
	{
		double_0 = double_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_82(double double_8)
	{
		double_1 = double_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_83(double double_8)
	{
		double_2 = double_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_84(double double_8)
	{
		double_3 = double_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_85(double double_8)
	{
		double_4 = double_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_86(double double_8)
	{
		double_5 = double_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_87(double double_8)
	{
		double_6 = double_8;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_88(double double_8)
	{
		double_7 = double_8;
	}

	static void smethod_0(Array array_0, Array array_1, int int_7)
	{
		Array.Copy(array_0, array_1, int_7);
	}

	static void smethod_1(Array array_0, int int_7, Array array_1, int int_8, int int_9)
	{
		Array.Copy(array_0, int_7, array_1, int_8, int_9);
	}

	static void smethod_2(string string_3)
	{
		Console.WriteLine(string_3);
	}

	static void smethod_3(string string_3, object[] object_0)
	{
		Console.WriteLine(string_3, object_0);
	}
}
