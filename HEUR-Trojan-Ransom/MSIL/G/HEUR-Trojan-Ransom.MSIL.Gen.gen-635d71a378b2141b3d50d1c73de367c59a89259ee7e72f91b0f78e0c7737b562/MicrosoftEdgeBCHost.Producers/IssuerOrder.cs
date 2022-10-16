using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class IssuerOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IssuerOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CloneRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneRule()
	{
	}
}
