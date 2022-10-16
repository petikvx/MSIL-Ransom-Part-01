using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class DicSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		OrderLiteralMapping();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void OrderLiteralMapping()
	{
	}
}
