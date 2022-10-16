using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CandidateFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CandidateFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceModel()
	{
	}
}
