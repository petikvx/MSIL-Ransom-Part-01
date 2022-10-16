using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ParserFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		InitThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitThread()
	{
	}
}
