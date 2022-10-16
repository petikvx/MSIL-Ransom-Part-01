using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ConfigUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigUtils()
	{
		WriterPropertyProducer.ResolveStub();
		DisableInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DisableInterfaceMapper()
	{
	}
}
