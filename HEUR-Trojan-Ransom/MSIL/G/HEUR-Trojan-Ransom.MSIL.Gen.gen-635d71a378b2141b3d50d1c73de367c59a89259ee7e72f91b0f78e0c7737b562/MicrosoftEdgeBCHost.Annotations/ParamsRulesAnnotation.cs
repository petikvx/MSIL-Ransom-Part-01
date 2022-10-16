using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ParamsRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillVisitor()
	{
	}
}
