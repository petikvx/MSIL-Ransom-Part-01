using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ExporterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RemoveInterfaceCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RemoveInterfaceCandidate()
	{
	}
}
