using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GetterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GetterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		InitInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InitInterfaceComparator()
	{
	}
}
