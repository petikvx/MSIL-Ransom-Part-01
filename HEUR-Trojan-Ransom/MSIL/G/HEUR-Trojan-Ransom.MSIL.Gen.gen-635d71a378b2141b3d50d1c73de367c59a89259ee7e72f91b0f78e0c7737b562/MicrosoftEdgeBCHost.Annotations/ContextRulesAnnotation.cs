using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContextRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeProperty()
	{
	}
}
