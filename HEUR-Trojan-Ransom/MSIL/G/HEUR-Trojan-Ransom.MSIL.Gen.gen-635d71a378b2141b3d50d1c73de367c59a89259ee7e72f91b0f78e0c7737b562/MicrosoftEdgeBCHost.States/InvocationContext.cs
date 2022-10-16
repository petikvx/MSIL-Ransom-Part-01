using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InvocationContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationContext()
	{
		WriterPropertyProducer.ResolveStub();
		MoveInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveInterfaceContainer()
	{
	}
}
