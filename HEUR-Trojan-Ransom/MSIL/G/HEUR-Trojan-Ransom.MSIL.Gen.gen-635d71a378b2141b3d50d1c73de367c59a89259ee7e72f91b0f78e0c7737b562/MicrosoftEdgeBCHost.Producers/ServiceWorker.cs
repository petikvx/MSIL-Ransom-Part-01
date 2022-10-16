using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ServiceWorker
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServiceWorker()
	{
		WriterPropertyProducer.ResolveStub();
		SetHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetHelper()
	{
	}
}
