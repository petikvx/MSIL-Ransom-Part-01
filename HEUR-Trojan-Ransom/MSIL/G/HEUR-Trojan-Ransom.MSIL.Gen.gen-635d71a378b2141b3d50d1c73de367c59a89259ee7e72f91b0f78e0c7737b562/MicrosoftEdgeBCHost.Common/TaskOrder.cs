using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TaskOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskOrder()
	{
		WriterPropertyProducer.ResolveStub();
		CompareClass();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareClass()
	{
	}
}
