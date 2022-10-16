using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttributeBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitStatus()
	{
	}
}
