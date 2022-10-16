using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MessageRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MessageRules()
	{
		WriterPropertyProducer.ResolveStub();
		FlushDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushDispatcher()
	{
	}
}
