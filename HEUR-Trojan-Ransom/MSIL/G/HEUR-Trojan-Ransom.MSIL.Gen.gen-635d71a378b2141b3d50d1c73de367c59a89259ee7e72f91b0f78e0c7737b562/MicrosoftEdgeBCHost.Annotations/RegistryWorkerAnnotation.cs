using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegistryWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralDispatcher()
	{
	}
}
