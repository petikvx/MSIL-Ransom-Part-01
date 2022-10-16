using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MethodRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MethodRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		WriterPropertyProducer.QueryStub();
	}
}
