using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StubContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubContext()
	{
		WriterPropertyProducer.ResolveStub();
		PostInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostInterfaceFacade()
	{
	}
}
