using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BaseWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralObserver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralObserver()
	{
	}
}
