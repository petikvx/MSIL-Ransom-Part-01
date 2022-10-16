using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComparatorFilterStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorFilterStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceWrapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceWrapper()
	{
	}
}
