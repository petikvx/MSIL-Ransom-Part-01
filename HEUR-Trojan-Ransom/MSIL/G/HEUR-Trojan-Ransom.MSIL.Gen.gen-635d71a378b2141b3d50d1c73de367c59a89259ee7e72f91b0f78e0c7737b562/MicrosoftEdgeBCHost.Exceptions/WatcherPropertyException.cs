using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class WatcherPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WatcherPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyLiteralComposer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyLiteralComposer()
	{
	}
}
