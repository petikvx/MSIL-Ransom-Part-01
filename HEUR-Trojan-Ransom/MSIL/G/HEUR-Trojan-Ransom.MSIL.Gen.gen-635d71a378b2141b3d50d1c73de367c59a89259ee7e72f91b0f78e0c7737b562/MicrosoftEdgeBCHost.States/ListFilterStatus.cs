using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ListFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		CalculateInterfaceFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalculateInterfaceFilter()
	{
	}
}
