using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TokenizerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenizerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ResolveParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResolveParameter()
	{
	}
}
