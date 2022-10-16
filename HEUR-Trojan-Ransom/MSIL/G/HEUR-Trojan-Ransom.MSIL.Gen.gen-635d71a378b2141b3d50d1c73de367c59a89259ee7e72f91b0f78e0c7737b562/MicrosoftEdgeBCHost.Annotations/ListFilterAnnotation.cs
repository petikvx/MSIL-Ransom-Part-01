using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ListFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceDispatcher();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceDispatcher()
	{
	}
}
