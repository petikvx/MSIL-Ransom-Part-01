using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ReaderState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ReaderState()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceDefinition();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceDefinition()
	{
	}
}
