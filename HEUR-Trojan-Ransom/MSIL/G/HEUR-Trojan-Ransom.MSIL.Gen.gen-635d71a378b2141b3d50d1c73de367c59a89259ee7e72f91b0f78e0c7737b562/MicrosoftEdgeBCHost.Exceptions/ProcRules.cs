using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ProcRules
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcRules()
	{
		WriterPropertyProducer.ResolveStub();
		SortParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortParameter()
	{
	}
}
