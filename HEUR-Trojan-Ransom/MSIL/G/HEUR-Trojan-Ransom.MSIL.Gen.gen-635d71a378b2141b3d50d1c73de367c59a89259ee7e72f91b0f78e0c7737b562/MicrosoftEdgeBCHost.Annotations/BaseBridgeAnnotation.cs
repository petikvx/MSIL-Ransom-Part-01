using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BaseBridgeAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseBridgeAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ForgotGetter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ForgotGetter()
	{
	}
}
