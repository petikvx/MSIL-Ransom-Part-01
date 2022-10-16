using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RoleWorkerWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleWorkerWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralMapping()
	{
	}
}
