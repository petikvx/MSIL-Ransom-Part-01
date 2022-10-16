using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AlgoGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AlgoGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceSchema()
	{
	}
}
