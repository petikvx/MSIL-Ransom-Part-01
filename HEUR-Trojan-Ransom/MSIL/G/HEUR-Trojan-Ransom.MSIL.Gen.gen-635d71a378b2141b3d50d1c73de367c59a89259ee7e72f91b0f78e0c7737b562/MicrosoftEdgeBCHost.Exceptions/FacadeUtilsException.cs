using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadeUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		SortLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortLiteralInterceptor()
	{
	}
}
