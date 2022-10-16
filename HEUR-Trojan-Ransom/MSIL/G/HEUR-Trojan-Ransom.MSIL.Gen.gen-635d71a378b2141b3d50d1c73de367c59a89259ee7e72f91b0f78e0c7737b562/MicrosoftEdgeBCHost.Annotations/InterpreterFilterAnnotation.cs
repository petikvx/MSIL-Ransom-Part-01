using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class InterpreterFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InterpreterFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RateInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RateInterfacePage()
	{
	}
}
