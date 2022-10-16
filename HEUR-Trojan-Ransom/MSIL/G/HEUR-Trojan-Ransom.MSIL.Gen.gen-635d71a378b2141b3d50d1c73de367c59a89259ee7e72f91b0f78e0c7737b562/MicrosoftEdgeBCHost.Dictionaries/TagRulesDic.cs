using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class TagRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TagRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		RestartInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartInterfaceAnnotation()
	{
	}
}
