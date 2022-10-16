using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ConsumerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		LoginQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginQueue()
	{
	}
}
