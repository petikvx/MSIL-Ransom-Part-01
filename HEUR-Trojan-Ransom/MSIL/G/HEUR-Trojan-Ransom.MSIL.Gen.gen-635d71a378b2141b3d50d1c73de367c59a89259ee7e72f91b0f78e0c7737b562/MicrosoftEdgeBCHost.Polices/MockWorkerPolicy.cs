using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MockWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MockWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfaceSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfaceSingleton()
	{
	}
}
