using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ProccesorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MapLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MapLiteralCode()
	{
	}
}
