using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DicOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralPool()
	{
	}
}
