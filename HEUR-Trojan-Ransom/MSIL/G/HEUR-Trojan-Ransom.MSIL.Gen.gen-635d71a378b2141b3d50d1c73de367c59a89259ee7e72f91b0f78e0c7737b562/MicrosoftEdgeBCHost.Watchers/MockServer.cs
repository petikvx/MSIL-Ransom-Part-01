using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class MockServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockServer()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralUtils()
	{
	}
}
