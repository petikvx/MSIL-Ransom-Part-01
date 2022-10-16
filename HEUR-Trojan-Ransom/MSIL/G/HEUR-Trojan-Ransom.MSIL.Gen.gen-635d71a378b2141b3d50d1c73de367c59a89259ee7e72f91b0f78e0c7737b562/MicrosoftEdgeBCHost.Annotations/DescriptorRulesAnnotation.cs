using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DescriptorRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DescriptorRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectPool()
	{
	}
}
