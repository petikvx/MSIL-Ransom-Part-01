using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class RegBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CompareExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareExpression()
	{
	}
}
