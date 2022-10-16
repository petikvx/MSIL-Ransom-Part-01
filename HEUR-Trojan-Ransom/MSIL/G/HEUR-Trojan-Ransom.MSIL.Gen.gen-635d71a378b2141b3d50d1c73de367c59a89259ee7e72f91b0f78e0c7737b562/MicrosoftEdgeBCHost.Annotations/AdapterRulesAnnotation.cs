using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AdapterRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetConfiguration()
	{
	}
}
