using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InterpreterBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceBroadcaster()
	{
	}
}
