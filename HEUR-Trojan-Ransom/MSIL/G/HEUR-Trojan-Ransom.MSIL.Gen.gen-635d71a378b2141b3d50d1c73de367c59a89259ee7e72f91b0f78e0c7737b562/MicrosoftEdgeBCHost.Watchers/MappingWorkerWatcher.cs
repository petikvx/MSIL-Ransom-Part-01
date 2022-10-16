using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MappingWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralMapping()
	{
	}
}
