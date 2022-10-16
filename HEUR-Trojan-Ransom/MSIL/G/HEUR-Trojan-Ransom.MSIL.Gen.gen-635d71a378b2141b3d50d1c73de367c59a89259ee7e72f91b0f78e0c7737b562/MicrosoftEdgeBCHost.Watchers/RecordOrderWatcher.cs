using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RecordOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralDispatcher()
	{
	}
}
