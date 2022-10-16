using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ResolverRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ResolverRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SetupStruct();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupStruct()
	{
	}
}
