using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceExpression()
	{
	}
}
