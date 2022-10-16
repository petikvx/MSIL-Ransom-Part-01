using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MapperRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ListInterceptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ListInterceptor()
	{
	}
}
