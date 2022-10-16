using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateVisitor()
	{
	}
}
