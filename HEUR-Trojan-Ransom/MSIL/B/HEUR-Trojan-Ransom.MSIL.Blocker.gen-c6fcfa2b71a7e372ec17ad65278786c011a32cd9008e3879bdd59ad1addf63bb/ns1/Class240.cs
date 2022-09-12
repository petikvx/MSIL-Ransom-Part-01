using System;
using System.Runtime.CompilerServices;
using ns13;

namespace ns1;

[Obsolete("BSON reading and writing has been moved to its own package. See https://www.nuget.org/packages/Newtonsoft.Json.Bson for more details.")]
internal class Class240
{
	[CompilerGenerated]
	private readonly byte[] byte_0;

	public byte[] Value
	{
		[CompilerGenerated]
		get
		{
			return byte_0;
		}
	}

	public Class240(byte[] byte_1)
	{
		Class112.smethod_0(byte_1, "value");
		if (byte_1.Length != 12)
		{
			throw new ArgumentException("An ObjectId must be 12 bytes", "value");
		}
		byte_0 = byte_1;
	}
}
