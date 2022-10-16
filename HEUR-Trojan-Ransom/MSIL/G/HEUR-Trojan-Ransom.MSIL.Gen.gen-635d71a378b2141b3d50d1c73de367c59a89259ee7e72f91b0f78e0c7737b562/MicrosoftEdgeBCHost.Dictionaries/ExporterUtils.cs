using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ExporterUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceResolver()
	{
	}
}
