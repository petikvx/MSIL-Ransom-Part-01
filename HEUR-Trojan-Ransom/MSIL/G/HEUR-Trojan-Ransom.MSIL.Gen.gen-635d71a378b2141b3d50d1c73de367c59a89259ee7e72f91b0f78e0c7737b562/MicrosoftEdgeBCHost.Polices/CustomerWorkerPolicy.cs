using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceToken();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceToken()
	{
	}
}
