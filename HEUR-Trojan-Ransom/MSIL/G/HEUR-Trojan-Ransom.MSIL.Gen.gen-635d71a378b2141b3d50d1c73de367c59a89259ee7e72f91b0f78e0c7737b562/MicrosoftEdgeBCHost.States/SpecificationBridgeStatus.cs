using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class SpecificationBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ChangeExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ChangeExpression()
	{
	}
}
