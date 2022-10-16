using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestsBridgeStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsBridgeStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateList()
	{
	}
}
