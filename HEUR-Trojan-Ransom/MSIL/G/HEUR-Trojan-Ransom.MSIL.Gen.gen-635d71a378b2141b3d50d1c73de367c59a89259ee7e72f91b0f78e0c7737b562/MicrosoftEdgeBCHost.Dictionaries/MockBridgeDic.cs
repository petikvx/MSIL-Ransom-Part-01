using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class MockBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceMapping()
	{
	}
}
