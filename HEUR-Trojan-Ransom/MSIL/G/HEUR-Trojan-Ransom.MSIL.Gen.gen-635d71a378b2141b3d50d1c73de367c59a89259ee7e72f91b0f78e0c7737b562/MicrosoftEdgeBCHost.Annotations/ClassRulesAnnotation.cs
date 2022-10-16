using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClassRulesAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassRulesAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitProperty();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitProperty()
	{
	}
}
