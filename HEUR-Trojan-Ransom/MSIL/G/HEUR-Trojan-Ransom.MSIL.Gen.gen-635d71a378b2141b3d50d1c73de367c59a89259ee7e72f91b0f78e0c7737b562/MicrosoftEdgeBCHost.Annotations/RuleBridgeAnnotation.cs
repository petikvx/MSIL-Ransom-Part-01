using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RuleBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotProccesor()
	{
	}
}
