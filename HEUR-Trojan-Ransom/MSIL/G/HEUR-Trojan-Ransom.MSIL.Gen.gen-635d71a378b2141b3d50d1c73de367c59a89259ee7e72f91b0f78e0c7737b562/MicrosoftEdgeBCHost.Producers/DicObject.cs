using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicObject()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
