using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class UtilsWorkerStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsWorkerStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CloneLiteralWatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneLiteralWatcher()
	{
	}
}
