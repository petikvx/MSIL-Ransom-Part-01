using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class CallbackBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ReadExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadExpression()
	{
	}
}
