using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComposerFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SetupThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupThread()
	{
	}
}
