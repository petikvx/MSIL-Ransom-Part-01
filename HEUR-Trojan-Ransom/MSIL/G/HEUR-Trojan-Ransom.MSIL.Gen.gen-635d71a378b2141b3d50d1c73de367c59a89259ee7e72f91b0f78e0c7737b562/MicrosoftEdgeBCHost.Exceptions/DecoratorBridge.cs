using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorBridge()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareIndexer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareIndexer()
	{
	}
}
