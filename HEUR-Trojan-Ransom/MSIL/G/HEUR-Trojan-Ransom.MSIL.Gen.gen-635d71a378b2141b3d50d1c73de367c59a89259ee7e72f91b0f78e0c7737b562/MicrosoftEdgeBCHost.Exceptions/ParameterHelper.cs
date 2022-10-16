using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParameterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralReponse();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralReponse()
	{
	}
}
