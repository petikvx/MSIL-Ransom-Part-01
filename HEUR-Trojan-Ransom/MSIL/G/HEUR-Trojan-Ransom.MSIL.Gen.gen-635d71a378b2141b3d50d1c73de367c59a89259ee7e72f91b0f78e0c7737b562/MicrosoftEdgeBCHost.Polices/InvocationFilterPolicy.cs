using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InvocationFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeDispatcher()
	{
	}
}
