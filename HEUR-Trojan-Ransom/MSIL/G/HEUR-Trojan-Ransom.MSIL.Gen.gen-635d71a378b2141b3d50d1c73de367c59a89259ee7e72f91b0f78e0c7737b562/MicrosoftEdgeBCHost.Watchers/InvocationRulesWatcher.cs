using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class InvocationRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterRole()
	{
	}
}
