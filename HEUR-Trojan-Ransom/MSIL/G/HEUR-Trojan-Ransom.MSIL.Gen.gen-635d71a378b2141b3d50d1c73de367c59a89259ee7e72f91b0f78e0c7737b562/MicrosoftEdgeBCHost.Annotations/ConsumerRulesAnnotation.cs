using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ConsumerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConsumerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateTask();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateTask()
	{
	}
}
