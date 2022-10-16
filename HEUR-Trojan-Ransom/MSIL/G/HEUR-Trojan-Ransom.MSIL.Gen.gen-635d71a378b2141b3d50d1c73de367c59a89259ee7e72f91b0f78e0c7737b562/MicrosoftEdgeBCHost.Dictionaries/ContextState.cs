using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ContextState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextState()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceRecord();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceRecord()
	{
	}
}
