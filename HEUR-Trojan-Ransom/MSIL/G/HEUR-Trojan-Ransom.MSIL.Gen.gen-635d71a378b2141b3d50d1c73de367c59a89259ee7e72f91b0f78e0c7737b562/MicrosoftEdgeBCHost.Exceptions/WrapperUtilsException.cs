using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WrapperUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeLiteralFilter()
	{
	}
}
