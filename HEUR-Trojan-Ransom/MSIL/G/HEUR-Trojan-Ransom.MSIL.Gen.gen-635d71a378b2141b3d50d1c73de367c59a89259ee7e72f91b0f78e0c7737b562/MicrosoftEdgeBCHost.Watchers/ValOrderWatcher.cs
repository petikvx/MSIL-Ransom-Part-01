using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ValOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		AddLiteralParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddLiteralParser()
	{
	}
}
