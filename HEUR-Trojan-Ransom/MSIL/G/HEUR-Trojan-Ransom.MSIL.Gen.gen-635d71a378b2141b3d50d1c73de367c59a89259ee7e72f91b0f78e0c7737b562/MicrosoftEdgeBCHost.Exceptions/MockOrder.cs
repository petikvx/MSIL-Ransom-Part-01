using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MockOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterRule()
	{
	}
}
