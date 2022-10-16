using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RequestRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComparePredicate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComparePredicate()
	{
	}
}
