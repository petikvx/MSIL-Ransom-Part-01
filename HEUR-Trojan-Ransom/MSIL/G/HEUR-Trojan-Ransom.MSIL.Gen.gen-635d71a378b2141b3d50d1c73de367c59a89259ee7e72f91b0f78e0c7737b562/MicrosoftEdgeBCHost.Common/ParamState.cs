using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ParamState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamState()
	{
		WriterPropertyProducer.ResolveStub();
		StopInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopInterfaceDefinition()
	{
	}
}
