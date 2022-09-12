using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
[CompilerGenerated]
[Microsoft.CodeAnalysis.Embedded]
internal sealed class NullableAttribute : Attribute
{
	public readonly byte[] NullableFlags;

	public NullableAttribute(byte byte_0)
	{
		NullableFlags = new byte[1] { byte_0 };
	}

	public NullableAttribute(byte[] byte_0)
	{
		NullableFlags = byte_0;
	}
}
