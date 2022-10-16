using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class AttributeBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CountSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountSerializer()
	{
	}
}
