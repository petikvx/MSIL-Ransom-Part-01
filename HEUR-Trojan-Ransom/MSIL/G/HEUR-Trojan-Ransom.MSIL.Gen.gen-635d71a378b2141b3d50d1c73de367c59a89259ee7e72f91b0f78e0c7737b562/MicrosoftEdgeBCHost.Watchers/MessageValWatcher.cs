using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MessageValWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageValWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		VisitInterfaceTest();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitInterfaceTest()
	{
	}
}
