using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ServiceRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateFilter()
	{
	}
}
