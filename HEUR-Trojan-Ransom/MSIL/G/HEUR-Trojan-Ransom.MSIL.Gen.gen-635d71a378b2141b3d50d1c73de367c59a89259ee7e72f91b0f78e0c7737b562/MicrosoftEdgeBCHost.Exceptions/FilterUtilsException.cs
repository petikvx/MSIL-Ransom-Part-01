using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FilterUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeLiteralPool()
	{
	}
}
