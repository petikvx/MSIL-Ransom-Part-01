using Microsoft.CodeAnalysis;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
[CompilerGenerated]
[Microsoft.CodeAnalysis.Embedded]
internal sealed class NullableContextAttribute : Attribute
{
	public readonly byte Flag;

	public NullableContextAttribute(byte byte_0)
	{
		Flag = byte_0;
	}
}
