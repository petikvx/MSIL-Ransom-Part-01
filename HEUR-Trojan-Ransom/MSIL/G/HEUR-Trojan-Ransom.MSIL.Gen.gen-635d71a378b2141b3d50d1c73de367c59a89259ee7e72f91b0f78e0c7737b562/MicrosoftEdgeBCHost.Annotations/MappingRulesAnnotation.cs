using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class MappingRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RunReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunReg()
	{
	}
}
