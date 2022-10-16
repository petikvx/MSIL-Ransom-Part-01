using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CandidateBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		StartService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartService()
	{
	}
}
