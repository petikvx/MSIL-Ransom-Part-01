using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestsValAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestsValAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		DeleteLiteralError();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void DeleteLiteralError()
	{
	}
}
