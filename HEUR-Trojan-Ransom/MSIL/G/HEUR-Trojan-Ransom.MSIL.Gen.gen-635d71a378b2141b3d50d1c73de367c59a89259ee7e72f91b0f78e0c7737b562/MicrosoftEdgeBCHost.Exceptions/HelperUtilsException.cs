using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class HelperUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralInterceptor()
	{
	}
}
