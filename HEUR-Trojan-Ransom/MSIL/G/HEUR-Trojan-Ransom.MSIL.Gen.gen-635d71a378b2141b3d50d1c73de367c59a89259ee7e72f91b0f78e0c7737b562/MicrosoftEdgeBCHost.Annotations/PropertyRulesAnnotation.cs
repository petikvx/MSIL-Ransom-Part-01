using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class PropertyRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FindConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindConfiguration()
	{
	}
}
