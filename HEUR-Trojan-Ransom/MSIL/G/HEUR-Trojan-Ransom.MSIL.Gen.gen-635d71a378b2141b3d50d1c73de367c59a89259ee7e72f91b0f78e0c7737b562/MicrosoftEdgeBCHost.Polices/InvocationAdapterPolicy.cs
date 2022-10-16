using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class InvocationAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralWrapper()
	{
	}
}
