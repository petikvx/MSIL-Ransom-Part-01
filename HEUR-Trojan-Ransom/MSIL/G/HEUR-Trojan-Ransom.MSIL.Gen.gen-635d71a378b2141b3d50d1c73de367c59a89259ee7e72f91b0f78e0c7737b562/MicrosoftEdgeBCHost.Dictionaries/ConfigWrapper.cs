using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigWrapper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigWrapper()
	{
		WriterPropertyProducer.ResolveStub();
		DefineBroadcaster();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DefineBroadcaster()
	{
	}
}
