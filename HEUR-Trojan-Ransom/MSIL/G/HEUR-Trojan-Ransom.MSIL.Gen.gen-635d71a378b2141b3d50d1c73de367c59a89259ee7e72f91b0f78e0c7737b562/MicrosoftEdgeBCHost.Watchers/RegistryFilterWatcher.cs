using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class RegistryFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		SelectSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectSingleton()
	{
	}
}
