using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MessageState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageState()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceIndexer()
	{
	}
}
