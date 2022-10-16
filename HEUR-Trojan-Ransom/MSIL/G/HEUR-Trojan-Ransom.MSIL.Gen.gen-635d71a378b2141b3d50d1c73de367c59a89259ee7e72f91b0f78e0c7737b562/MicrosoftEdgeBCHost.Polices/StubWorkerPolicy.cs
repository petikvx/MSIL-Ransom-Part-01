using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class StubWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PushInterfaceService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushInterfaceService()
	{
	}
}
