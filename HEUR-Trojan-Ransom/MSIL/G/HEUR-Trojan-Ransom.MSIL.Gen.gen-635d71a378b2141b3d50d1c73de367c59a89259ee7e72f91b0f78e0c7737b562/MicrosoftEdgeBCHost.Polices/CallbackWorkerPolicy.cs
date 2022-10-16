using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CallbackWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CallbackWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceFacade();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceFacade()
	{
	}
}
