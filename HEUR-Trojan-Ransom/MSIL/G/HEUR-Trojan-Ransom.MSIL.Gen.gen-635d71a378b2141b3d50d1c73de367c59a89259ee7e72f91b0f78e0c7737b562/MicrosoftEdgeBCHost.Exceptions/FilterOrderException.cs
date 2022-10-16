using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FilterOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateRegistry()
	{
	}
}
