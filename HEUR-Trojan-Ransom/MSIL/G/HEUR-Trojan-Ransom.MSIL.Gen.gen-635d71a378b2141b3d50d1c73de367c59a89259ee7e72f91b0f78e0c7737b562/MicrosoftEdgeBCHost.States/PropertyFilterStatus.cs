using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class PropertyFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		PopInterfaceComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopInterfaceComparator()
	{
	}
}
