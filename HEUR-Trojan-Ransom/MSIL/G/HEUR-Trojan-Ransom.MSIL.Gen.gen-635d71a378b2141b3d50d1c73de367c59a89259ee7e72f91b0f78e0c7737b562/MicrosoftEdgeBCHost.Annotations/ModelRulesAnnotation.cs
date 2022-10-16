using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ModelRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		NewList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewList()
	{
	}
}
