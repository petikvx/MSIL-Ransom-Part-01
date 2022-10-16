using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ItemSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralService()
	{
	}
}
