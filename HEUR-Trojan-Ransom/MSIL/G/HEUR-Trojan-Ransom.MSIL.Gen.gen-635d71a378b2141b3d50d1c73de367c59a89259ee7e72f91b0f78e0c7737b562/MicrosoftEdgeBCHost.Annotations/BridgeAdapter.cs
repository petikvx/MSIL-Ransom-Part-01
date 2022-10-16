using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BridgeAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BridgeAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		TestProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestProc()
	{
	}
}
