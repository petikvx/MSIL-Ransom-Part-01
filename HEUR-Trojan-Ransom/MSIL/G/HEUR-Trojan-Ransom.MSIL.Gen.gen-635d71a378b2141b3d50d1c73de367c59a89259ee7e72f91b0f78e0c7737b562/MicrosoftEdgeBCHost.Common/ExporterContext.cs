using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ExporterContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExporterContext()
	{
		WriterPropertyProducer.ResolveStub();
		CloneInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneInterfaceAnnotation()
	{
	}
}
