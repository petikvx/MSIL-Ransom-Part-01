using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigurationState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationState()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceProxy()
	{
	}
}
