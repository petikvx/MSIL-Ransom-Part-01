using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralField()
	{
	}
}
