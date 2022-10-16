using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RulesWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RulesWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		CountCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountCustomer()
	{
	}
}
