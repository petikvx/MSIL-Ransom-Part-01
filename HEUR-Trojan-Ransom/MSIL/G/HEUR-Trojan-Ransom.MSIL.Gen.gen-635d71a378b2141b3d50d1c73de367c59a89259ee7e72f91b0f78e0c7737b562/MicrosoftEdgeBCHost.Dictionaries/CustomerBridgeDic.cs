using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class CustomerBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceBridge()
	{
	}
}
