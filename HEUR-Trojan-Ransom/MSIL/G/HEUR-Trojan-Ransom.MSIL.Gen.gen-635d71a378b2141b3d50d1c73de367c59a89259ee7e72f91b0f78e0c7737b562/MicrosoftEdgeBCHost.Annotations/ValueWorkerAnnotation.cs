using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValueWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralMessage()
	{
	}
}
