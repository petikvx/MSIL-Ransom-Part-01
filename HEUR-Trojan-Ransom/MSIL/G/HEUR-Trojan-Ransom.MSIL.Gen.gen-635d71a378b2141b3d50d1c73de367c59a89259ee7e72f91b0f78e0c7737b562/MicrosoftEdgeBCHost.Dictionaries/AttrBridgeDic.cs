using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AttrBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		StopAdvisor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopAdvisor()
	{
	}
}
