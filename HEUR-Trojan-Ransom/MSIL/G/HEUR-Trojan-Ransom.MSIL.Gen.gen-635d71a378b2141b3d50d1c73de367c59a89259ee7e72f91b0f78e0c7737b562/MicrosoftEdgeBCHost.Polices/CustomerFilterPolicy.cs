using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class CustomerFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CustomerFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		FindConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindConfig()
	{
	}
}
