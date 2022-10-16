using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class AccountWorkerProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountWorkerProducer()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceBridge();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceBridge()
	{
	}
}
