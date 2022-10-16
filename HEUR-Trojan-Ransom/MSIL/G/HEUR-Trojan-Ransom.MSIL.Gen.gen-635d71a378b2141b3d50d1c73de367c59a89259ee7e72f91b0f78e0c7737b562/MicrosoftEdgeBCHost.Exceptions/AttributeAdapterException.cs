using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AttributeAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		RateLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateLiteralState()
	{
	}
}
