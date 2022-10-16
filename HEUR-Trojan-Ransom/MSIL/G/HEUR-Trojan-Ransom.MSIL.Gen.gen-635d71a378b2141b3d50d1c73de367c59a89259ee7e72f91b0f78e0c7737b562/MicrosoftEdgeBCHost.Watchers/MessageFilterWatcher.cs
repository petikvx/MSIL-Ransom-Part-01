using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MessageFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		LoginIterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginIterator()
	{
	}
}
