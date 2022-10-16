using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class MappingState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingState()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterInterfaceParam();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterInterfaceParam()
	{
	}
}
