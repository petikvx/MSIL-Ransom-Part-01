using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class DefinitionWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceWriter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceWriter()
	{
	}
}
