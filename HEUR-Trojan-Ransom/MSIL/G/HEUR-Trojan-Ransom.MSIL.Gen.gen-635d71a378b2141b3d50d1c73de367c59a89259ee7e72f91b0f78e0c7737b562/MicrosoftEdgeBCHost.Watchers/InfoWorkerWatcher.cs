using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InfoWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceReg()
	{
	}
}
