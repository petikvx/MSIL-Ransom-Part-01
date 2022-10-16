using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdapterOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterOrder()
	{
		WriterPropertyProducer.ResolveStub();
		VisitFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitFilter()
	{
	}
}
