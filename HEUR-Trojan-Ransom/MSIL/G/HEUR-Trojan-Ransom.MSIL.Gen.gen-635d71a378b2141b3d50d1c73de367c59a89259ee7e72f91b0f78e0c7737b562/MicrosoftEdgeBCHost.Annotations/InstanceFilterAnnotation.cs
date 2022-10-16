using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InstanceFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceMap()
	{
	}
}
