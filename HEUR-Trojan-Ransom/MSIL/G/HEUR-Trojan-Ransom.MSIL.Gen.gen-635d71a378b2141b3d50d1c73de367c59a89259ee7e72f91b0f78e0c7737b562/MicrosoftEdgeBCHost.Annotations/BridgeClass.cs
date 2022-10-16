using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BridgeClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeClass()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceList()
	{
	}
}
