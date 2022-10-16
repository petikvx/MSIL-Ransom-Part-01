using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ObjectUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralRegistry();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralRegistry()
	{
	}
}
