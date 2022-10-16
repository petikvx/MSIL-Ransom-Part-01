using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AlgoFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceIdentifier();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceIdentifier()
	{
	}
}
