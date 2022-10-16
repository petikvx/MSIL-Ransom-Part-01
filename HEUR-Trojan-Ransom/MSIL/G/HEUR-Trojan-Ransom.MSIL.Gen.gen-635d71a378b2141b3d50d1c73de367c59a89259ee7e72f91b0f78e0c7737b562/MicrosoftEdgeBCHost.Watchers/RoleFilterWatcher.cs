using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RoleFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		CountPolicy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountPolicy()
	{
	}
}
