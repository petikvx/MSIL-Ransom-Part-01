using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ProductUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProductUtils()
	{
		WriterPropertyProducer.ResolveStub();
		TestInterfaceExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestInterfaceExporter()
	{
	}
}
