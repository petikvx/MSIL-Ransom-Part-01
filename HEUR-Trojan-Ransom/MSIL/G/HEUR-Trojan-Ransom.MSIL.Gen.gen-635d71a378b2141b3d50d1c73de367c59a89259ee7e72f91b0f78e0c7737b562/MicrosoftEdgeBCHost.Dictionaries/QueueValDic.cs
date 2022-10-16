using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class QueueValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueValDic()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
