using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ReflectConsumer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReflectConsumer()
	{
	}
}
