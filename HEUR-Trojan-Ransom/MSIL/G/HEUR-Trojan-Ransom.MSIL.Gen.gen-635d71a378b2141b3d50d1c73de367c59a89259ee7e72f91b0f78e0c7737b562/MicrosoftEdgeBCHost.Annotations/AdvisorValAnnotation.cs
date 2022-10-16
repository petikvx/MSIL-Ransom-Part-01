using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class AdvisorValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		SortInterfaceRule();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SortInterfaceRule()
	{
	}
}
