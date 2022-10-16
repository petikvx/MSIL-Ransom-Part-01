using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class IndexerValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SelectInterfaceInvocation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectInterfaceInvocation()
	{
	}
}
