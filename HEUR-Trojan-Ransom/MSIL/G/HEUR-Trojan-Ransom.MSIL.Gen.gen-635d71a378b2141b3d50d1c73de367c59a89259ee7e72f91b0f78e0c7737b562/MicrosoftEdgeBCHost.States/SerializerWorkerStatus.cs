using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SerializerWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		QueryLiteralPublisher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void QueryLiteralPublisher()
	{
	}
}
