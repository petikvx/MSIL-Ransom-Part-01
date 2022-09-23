using System.Runtime.InteropServices;

public class GClass12
{
	[StructLayout(LayoutKind.Explicit)]
	private struct Struct11
	{
		[FieldOffset(0)]
		public ulong ulong_0;

		[FieldOffset(0)]
		public uint uint_0;

		[FieldOffset(4)]
		public uint uint_1;
	}

	private const int int_0 = 15;

	private const int int_1 = 8;

	private const int int_2 = 2;

	private const int int_3 = 32;

	private readonly uint[] uint_0;

	private const uint uint_1 = 4207804417u;

	private const uint uint_2 = 4207804418u;

	public extern GClass12(byte[] byte_0);

	private extern void method_0(ref Struct11 struct11_0);

	private void method_1(ref Struct11 struct11_0)
	{
	}

	public extern byte[] method_2(byte[] byte_0);

	public extern byte[] method_3(byte[] byte_0);

	public extern void method_4(byte[] byte_0, byte[] byte_1);

	public extern void method_5(byte[] byte_0, byte[] byte_1);
}
