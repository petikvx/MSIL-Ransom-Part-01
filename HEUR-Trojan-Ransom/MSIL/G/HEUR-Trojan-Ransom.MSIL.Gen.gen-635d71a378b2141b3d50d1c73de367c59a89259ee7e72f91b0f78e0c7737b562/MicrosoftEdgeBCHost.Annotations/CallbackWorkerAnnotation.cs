using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class CallbackWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ViewLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewLiteralComparator()
	{
	}
}
