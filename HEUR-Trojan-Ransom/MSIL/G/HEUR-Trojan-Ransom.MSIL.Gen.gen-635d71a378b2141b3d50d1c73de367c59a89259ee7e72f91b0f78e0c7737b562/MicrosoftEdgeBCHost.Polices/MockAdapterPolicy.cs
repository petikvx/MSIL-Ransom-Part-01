using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MockAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralCallback()
	{
	}
}
