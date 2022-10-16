using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceReader();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceReader()
	{
	}
}
