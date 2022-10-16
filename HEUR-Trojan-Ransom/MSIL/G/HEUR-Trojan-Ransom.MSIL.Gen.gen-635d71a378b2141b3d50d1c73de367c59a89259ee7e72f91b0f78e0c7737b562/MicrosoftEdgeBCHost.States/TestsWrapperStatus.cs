using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class TestsWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateState()
	{
	}
}
