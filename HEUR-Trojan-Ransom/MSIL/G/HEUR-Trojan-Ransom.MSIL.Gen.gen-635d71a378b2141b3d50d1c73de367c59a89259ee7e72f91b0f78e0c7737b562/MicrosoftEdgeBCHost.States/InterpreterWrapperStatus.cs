using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class InterpreterWrapperStatus
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterWrapperStatus()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateDecorator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateDecorator()
	{
	}
}
