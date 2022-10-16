using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigurationAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceGetter()
	{
	}
}
