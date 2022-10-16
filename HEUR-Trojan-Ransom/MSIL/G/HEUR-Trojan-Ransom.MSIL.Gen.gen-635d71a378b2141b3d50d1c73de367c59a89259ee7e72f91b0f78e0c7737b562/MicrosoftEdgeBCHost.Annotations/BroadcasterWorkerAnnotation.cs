using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BroadcasterWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralException()
	{
	}
}
