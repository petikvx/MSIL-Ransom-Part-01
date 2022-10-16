using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValueOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueOrder()
	{
		WriterPropertyProducer.ResolveStub();
		RunPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunPolicy()
	{
	}
}
