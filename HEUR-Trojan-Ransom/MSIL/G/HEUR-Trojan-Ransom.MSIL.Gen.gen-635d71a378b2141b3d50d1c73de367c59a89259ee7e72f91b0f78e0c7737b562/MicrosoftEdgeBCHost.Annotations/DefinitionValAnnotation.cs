using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DefinitionValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DefinitionValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ViewInterfaceCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ViewInterfaceCallback()
	{
	}
}
