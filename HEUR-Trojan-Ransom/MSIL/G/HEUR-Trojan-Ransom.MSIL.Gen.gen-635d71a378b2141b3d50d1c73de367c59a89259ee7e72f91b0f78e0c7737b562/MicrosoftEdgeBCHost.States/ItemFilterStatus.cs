using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ItemFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ListLiteralObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListLiteralObject()
	{
	}
}
