using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DecoratorFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceTemplate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceTemplate()
	{
	}
}
