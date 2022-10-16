using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SpecificationPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		InvokeInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InvokeInterfaceField()
	{
	}
}
