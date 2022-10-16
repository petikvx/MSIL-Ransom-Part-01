using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TestWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceProperty()
	{
	}
}
