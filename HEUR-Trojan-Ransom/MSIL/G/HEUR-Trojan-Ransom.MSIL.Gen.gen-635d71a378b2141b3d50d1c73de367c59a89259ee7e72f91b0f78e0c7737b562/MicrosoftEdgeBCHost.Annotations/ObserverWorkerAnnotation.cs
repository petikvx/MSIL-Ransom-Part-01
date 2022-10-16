using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ObserverWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObserverWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReadLiteralCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadLiteralCandidate()
	{
	}
}
