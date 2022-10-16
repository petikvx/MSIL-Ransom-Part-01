using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AdvisorWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InitLiteralInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitLiteralInstance()
	{
	}
}
