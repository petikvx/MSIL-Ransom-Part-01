using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MessageBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PostMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostMapper()
	{
	}
}
