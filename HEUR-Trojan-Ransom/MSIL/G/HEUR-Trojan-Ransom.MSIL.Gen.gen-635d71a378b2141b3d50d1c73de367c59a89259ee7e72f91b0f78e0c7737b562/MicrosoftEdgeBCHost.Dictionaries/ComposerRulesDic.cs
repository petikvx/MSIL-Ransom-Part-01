using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ComposerRulesDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ComposerRulesDic()
	{
		WriterPropertyProducer.ResolveStub();
		PrepareInterfaceAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrepareInterfaceAnnotation()
	{
	}
}
