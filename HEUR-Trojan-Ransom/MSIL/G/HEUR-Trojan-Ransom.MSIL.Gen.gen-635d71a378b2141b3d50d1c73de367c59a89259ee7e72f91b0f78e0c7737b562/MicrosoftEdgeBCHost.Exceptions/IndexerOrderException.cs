using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class IndexerOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IndexerOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterfaceImporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterfaceImporter()
	{
	}
}
