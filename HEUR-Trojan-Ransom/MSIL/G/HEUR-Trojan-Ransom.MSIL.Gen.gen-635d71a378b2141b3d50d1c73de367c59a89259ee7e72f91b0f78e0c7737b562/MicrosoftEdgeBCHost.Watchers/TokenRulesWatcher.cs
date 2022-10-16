using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class TokenRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TokenRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		GetCustomer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void GetCustomer()
	{
	}
}
