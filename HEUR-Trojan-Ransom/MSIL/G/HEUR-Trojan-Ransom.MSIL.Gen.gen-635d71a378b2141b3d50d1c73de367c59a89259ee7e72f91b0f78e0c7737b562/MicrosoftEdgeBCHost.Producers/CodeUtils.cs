using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class CodeUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeUtils()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
