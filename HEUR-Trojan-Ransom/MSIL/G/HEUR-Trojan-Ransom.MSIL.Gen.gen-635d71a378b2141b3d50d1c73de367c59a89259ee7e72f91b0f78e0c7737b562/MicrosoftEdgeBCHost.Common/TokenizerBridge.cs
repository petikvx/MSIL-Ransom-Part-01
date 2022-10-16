using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TokenizerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeQueue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeQueue()
	{
	}
}
