using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class BroadcasterPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BroadcasterPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralProxy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralProxy()
	{
	}
}
