using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ConfigurationWorkerPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigurationWorkerPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceUtils()
	{
	}
}
