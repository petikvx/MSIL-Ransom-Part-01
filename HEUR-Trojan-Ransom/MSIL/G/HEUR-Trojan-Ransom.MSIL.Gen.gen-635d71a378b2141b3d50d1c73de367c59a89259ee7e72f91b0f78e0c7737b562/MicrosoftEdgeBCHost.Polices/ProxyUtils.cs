using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProxyUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProxyUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceExporter()
	{
	}
}
