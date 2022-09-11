using System;
using System.IO;
using System.Threading.Tasks;

internal static class Class13
{
	internal enum Enum2
	{
		const_0,
		const_1
	}

	internal interface Interface0 : IDisposable
	{
		float Single_0 { get; }

		float Single_1 { get; }

		Task imethod_0(Enum2 enum2_0, float float_0, Stream stream_0);
	}

	internal interface Interface1
	{
		Task<Interface0> imethod_0(Stream stream_0, float? nullable_0, float? nullable_1);

		Task<Interface0> imethod_1(string string_0, float? nullable_0, float? nullable_1);

		Interface0 imethod_2(float float_0, float float_1);
	}

	private static Interface1 interface1_0;

	public static Interface1 Interface1_0
	{
		get; set
		{
			//Discarded unreachable code: IL_000a, IL_0012, IL_0018, IL_001e, IL_0025
			//IL_0015: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Expected O, but got I4
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			while (true)
			{
				if (/*Error near IL_0005: Stack underflow*/ > /*Error near IL_0005: Stack underflow*/)
				{
				}
			}
		}
	}

	public static extern byte[] smethod_0(byte[] byte_0, byte[] byte_1);

	static extern Class13();

	static extern Exception UfPwyoEKFqrUPOEDEAlSCAOthDiV(string string_0);
}
