using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TaskFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskFilter()
	{
		WriterPropertyProducer.ResolveStub();
		SelectCandidate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SelectCandidate()
	{
	}
}
