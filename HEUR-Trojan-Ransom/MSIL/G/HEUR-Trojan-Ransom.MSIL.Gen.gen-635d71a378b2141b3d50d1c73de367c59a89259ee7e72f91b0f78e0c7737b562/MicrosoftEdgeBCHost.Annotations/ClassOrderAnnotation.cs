using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ClassOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		VisitLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VisitLiteralList()
	{
	}
}
