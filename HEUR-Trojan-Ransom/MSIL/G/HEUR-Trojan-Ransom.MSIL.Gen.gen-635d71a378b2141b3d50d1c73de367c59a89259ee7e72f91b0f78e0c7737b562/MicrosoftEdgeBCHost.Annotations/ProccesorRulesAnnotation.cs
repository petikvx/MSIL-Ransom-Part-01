using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProccesorRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProccesorRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeReg();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeReg()
	{
	}
}
