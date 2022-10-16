using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TemplateFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TemplateFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfacePage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfacePage()
	{
	}
}
