using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class SpecificationWorkerAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SpecificationWorkerAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralComparator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralComparator()
	{
	}
}
