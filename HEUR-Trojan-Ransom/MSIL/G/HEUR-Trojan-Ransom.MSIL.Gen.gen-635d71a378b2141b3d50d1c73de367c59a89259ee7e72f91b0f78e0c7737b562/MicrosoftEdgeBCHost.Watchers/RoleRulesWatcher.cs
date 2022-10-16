using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RoleRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetStatus()
	{
	}
}
