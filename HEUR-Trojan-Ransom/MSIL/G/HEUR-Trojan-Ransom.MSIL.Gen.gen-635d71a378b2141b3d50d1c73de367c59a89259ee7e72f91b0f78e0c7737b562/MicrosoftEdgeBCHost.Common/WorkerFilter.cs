using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WorkerFilter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WorkerFilter()
	{
		WriterPropertyProducer.ResolveStub();
		PushPage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushPage()
	{
	}
}
