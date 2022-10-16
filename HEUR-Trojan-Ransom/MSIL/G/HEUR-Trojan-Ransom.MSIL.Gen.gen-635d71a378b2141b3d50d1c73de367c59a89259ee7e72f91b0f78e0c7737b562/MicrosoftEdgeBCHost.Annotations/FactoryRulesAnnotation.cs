using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FactoryRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FactoryRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillFacade()
	{
	}
}
