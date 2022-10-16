using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Watchers;

internal class CodeFilterWatcher
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeFilterWatcher()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
