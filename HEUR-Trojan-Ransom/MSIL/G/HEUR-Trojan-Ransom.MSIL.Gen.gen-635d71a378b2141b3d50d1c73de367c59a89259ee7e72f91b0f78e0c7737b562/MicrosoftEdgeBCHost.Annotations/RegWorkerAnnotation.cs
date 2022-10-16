using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralComparator()
	{
	}
}
