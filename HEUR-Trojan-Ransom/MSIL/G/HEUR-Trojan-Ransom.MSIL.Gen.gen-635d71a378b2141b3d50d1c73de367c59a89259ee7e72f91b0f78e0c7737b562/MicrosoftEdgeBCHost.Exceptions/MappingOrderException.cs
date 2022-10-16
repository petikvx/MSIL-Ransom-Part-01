using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class MappingOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceIndexer()
	{
	}
}
