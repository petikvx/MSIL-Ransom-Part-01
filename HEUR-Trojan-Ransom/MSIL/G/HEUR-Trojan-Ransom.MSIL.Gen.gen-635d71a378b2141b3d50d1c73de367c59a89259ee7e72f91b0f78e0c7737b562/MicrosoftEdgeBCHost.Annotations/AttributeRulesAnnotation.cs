using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AttributeRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttributeRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeConsumer()
	{
	}
}
