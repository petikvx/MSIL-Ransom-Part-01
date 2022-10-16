using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IdentifierRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptProduct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptProduct()
	{
	}
}
