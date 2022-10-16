using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestsWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PostLiteralAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostLiteralAnnotation()
	{
	}
}
