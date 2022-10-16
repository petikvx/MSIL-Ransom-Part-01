using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MockValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateLiteralListener();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateLiteralListener()
	{
	}
}
