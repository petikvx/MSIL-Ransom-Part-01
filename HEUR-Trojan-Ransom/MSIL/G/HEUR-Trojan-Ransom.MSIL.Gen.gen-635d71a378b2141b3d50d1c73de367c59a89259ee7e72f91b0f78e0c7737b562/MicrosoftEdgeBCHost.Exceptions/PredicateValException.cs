using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PredicateValException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PredicateValException()
	{
		WriterPropertyProducer.ResolveStub();
		InsertGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertGlobal()
	{
	}
}
