using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InstanceRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		QueryFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryFacade()
	{
	}
}
