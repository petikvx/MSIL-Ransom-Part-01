using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class TaskAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfaceFactory();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfaceFactory()
	{
	}
}
