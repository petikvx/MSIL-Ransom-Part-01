using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComparatorValStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorValStatus()
	{
		WriterPropertyProducer.ResolveStub();
		InsertLiteralService();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertLiteralService()
	{
	}
}
