using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceFacade()
	{
	}
}
