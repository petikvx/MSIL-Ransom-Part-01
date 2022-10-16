using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class QueueRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static QueueRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakePage()
	{
	}
}
