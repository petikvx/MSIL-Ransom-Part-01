using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CustomerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveClass()
	{
	}
}
