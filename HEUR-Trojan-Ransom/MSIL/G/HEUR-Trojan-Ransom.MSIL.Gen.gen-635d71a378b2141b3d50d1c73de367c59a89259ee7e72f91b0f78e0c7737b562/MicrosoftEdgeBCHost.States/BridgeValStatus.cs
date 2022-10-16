using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BridgeValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		WriteLiteralValue();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void WriteLiteralValue()
	{
	}
}
