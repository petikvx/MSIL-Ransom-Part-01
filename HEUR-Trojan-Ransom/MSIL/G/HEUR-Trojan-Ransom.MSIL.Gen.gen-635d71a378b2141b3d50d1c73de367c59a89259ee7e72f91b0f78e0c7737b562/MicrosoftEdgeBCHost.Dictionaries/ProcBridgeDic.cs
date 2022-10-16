using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ProcBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		GetInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetInterfaceMap()
	{
	}
}
