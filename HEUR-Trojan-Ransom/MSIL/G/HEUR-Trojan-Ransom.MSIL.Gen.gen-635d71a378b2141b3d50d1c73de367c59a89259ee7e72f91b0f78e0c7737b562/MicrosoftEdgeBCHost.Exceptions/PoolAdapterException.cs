using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PoolAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PoolAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralDecorator()
	{
	}
}
