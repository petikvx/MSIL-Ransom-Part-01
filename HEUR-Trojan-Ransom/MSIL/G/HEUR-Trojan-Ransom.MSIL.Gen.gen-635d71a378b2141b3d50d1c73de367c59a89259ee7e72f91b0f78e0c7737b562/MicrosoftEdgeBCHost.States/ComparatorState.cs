using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ComparatorState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComparatorState()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceDefinition()
	{
	}
}
