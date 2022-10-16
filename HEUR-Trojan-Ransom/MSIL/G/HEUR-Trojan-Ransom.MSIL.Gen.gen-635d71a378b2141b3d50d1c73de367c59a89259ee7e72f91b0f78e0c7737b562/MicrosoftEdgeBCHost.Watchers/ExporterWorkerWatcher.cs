using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ExporterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralSetter()
	{
	}
}
