using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class AccountRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetParser()
	{
	}
}
