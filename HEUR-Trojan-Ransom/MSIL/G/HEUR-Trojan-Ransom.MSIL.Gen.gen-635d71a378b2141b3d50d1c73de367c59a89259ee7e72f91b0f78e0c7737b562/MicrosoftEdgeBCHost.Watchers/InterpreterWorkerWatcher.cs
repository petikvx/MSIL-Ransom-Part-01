using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InterpreterWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeLiteralImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeLiteralImporter()
	{
	}
}
