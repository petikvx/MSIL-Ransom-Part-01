using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClientWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClientWorker()
	{
		WriterPropertyProducer.ResolveStub();
		PublishWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PublishWriter()
	{
	}
}
