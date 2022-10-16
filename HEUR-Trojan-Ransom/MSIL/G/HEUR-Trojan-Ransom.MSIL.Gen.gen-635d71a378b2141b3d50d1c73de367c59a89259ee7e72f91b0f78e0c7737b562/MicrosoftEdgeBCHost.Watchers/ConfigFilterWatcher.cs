using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class ConfigFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		ReadSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadSingleton()
	{
	}
}
