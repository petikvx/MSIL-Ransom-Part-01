using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PublishInterfaceError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishInterfaceError()
	{
	}
}
