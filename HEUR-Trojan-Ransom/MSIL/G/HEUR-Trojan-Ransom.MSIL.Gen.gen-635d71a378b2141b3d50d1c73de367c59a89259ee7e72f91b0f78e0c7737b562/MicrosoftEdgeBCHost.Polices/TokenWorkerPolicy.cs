using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class TokenWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceContext()
	{
	}
}
