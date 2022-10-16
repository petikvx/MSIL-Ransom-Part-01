using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitFacade()
	{
	}
}
