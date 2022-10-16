using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WriterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralConfiguration()
	{
	}
}
