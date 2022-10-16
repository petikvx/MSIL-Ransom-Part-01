using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterpreterProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterProperty()
	{
		WriterPropertyProducer.ResolveStub();
		StartInterfaceSetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartInterfaceSetter()
	{
	}
}
