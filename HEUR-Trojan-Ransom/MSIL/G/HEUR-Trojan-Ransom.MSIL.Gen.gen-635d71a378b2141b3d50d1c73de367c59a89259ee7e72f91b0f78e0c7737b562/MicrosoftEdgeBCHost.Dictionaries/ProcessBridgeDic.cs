using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcessBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceBridge()
	{
	}
}
