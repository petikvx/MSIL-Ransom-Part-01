using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class StubBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatContainer()
	{
	}
}
