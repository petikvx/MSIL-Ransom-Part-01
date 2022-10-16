using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ServerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ServerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateVal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateVal()
	{
	}
}
