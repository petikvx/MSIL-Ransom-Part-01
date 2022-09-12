using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[CompilerGenerated]
[Microsoft.CodeAnalysis.Embedded]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
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
