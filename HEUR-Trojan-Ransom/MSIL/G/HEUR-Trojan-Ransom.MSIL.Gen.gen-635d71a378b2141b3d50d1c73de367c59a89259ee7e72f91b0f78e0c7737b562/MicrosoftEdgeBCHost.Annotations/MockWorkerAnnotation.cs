using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MockWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralContainer()
	{
	}
}
