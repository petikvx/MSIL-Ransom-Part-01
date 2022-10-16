using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComposerRulesWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerRulesWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		MoveGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveGlobal()
	{
	}
}
