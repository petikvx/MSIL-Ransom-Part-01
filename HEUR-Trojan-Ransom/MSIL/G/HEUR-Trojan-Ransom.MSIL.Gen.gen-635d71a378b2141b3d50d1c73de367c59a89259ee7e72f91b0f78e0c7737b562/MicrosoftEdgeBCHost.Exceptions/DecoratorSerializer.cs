using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DecoratorSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		FindLiteralState();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindLiteralState()
	{
	}
}
