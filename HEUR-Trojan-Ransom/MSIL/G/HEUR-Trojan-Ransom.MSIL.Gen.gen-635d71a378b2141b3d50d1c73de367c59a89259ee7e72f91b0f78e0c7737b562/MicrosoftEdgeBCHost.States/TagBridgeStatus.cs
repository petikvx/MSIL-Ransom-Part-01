using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TagBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		NewVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewVisitor()
	{
	}
}
