using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class IteratorContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IteratorContext()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotInterfaceProducer()
	{
	}
}
