using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class AnnotationRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AnnotationRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectInterfacePage()
	{
	}
}
