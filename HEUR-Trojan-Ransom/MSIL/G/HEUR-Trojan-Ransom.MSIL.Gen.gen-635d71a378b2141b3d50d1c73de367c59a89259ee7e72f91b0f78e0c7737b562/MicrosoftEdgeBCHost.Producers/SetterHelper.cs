using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class SetterHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SetterHelper()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
