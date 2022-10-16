using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ValWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		ReadCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadCustomer()
	{
	}
}
