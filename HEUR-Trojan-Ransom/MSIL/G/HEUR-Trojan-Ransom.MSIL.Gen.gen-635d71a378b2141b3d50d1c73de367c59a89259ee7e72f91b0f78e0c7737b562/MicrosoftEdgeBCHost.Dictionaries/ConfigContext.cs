using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigContext()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceUtils()
	{
	}
}
