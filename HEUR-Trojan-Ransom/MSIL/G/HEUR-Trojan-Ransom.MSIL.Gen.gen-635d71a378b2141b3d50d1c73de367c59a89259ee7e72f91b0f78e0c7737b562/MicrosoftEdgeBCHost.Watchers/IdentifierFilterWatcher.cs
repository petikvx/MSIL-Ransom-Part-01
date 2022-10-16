using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class IdentifierFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriteIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteIterator()
	{
	}
}
