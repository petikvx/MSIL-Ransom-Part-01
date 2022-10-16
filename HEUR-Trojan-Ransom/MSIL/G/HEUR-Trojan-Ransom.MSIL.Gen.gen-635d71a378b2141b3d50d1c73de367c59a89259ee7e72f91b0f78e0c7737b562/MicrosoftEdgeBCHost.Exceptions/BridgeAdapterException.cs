using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BridgeAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceComposer()
	{
	}
}
