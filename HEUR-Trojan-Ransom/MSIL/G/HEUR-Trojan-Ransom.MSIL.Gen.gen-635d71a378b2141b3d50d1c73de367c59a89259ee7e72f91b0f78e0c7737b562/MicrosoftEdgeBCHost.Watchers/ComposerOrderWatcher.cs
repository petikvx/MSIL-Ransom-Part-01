using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ComposerOrderWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerOrderWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralWrapper()
	{
	}
}
