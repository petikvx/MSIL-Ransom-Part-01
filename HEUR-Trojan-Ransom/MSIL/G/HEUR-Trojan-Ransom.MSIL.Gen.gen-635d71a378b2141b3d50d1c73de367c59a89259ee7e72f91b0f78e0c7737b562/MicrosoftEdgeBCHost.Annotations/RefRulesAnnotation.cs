using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RefRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RefRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ExcludeInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ExcludeInterceptor()
	{
	}
}
