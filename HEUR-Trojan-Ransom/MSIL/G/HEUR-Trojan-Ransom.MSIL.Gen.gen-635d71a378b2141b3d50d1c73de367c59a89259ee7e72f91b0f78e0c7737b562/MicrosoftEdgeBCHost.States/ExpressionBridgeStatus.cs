using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ExpressionBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExpressionBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		DefineCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineCollection()
	{
	}
}
