using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ListenerWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListenerWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralDefinition()
	{
	}
}
