using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParameterState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParameterState()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateInterfaceContext();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateInterfaceContext()
	{
	}
}
