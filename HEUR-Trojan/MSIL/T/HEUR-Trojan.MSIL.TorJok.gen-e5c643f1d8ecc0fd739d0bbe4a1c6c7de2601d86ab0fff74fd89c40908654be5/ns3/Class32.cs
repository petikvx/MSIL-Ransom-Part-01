using System.Runtime.CompilerServices;
using ns0;
using ns1;
using ns4;
using ns5;

namespace ns3;

internal sealed class Class32
{
	internal sealed class Class33
	{
		public readonly bool[] bool_0 = new bool[256];

		public readonly byte[] byte_0 = new byte[256];

		public readonly int[] int_0 = new int[Class35.int_3];

		public readonly byte[] byte_1 = new byte[Class35.int_8];

		public readonly byte[] byte_2 = new byte[Class35.int_8];

		public readonly byte[] byte_3 = new byte[256];

		public byte[][] byte_4;

		public int[][] int_1;

		public readonly int[] int_2 = new int[Class35.int_5];

		public readonly short[] short_0 = new short[Class35.int_5];

		public int[][] int_3;

		public readonly byte[] byte_5 = new byte[Class35.int_5];

		public readonly bool[] bool_1 = new bool[16];

		public readonly int[] int_4 = new int[Class35.int_10];

		public readonly int[] int_5 = new int[Class35.int_10];

		public readonly int[] int_6 = new int[Class35.int_10];

		public readonly int[] int_7 = new int[256];

		public readonly int[] int_8 = new int[256];

		public readonly bool[] bool_2 = new bool[256];

		public int[] int_9 = new int[Class35.int_3 + 2];

		public int[] int_10 = new int[Class35.int_3 * 2];

		public int[] int_11 = new int[Class35.int_3 * 2];

		public readonly int[] int_12 = new int[65537];

		public byte[] byte_6;

		public int[] int_13;

		public char[] char_0;

		public char[] char_1;

		public Class33(int int_14)
		{
			int num = int_14 * Class35.int_0;
			byte_6 = new byte[num + 1 + Class35.int_9];
			int_13 = new int[num];
			char_0 = new char[2 * num];
			char_1 = char_0;
			byte_4 = Class35.smethod_0<byte>(Class35.int_5, Class35.int_3);
			int_1 = Class35.smethod_0<int>(Class35.int_5, Class35.int_3);
			int_3 = Class35.smethod_0<int>(Class35.int_5, Class35.int_3);
		}
	}

	private int int_0;

	internal int int_1 = -1;

	internal int int_2;

	internal int int_3;

	internal int int_4;

	internal Class33 class33_0;

	internal readonly GClass3 gclass3_0 = new GClass3(bool_1: true);

	internal Class31 class31_0;

	internal int int_5;

	internal int int_6;

	internal int int_7;

	internal bool bool_0;

	internal bool bool_1;

	internal int int_8;

	internal int int_9;

	internal int int_10;

	internal static readonly int int_11 = 2097152;

	internal static readonly int int_12 = ~int_11;

	internal static readonly byte byte_0 = 15;

	internal static readonly byte byte_1 = 0;

	internal static readonly int int_13 = 20;

	internal static readonly int int_14 = 10;

	internal static readonly int int_15 = 30;

	internal static readonly int[] int_16 = new int[14]
	{
		1, 4, 13, 40, 121, 364, 1093, 3280, 9841, 29524,
		88573, 265720, 797161, 2391484
	};

	[CompilerGenerated]
	private uint uint_0;

	public Class32(Class31 class31_1, int int_17)
	{
		int_0 = int_17;
		class31_0 = class31_1;
		int_4 = int_17 * Class35.int_0 - 20;
		class33_0 = new Class33(int_17);
		Class6.smethod_454(this);
	}

	[SpecialName]
	[CompilerGenerated]
	public uint method_0()
	{
		return uint_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(uint uint_1)
	{
		uint_0 = uint_1;
	}
}
