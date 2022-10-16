using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ItemBridgeDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ItemBridgeDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
