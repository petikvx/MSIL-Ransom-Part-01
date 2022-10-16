using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ManagerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ManagerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralProcess();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralProcess()
	{
	}
}
