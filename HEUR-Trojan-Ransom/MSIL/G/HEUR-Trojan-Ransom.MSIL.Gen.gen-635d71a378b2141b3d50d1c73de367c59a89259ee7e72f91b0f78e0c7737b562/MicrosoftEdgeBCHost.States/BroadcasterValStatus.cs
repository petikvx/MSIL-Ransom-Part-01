using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class BroadcasterValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralMap()
	{
	}
}
