using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class StubWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		RestartCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartCustomer()
	{
	}
}
