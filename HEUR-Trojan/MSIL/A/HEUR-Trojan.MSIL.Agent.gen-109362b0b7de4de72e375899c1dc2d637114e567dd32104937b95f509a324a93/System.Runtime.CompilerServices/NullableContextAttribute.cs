using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[Microsoft.CodeAnalysis.Embedded]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[CompilerGenerated]
internal sealed class NullableContextAttribute : Attribute
{
	public readonly byte Flag;

	public NullableContextAttribute(byte byte_0)
	{
		Flag = byte_0;
	}
}
