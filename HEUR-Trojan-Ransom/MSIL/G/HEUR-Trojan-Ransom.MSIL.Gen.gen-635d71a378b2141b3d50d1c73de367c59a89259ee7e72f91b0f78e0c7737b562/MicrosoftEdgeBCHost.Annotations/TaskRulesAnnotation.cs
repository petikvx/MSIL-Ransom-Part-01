using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TaskRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ManageSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageSpecification()
	{
	}
}
