using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComposerBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerBridge()
	{
		WriterPropertyProducer.ResolveStub();
		CountStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountStatus()
	{
	}
}
