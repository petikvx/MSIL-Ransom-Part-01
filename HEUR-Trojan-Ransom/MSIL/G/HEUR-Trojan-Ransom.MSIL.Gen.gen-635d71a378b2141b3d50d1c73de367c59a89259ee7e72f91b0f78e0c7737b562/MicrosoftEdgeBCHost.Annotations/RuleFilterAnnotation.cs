using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RuleFilterAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleFilterAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillInterfaceConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillInterfaceConfiguration()
	{
	}
}
