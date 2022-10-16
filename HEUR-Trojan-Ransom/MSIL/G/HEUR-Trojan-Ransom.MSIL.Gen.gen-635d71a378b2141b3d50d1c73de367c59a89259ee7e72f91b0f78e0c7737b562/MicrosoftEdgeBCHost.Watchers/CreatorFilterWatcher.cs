using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CreatorFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CreatorFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterConfig();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterConfig()
	{
	}
}
