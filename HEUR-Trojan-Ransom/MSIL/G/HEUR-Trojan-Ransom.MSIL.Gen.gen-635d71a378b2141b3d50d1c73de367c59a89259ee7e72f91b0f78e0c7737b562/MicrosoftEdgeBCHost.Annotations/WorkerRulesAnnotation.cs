using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WorkerRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DestroyConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DestroyConfiguration()
	{
	}
}
