using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestsPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceList()
	{
	}
}
