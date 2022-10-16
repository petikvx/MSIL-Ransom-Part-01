using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class FilterOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FilterOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		ManageLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ManageLiteralField()
	{
	}
}
