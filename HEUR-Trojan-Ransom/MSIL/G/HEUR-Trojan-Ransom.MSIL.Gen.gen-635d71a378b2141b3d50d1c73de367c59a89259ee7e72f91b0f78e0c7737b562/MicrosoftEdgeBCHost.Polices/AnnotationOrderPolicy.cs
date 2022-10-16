using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class AnnotationOrderPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationOrderPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceProc()
	{
	}
}
