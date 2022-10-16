using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InterpreterState
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterState()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceModel();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceModel()
	{
	}
}
