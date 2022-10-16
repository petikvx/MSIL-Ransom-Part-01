using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class DicFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		SearchInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchInterfaceStrategy()
	{
	}
}
