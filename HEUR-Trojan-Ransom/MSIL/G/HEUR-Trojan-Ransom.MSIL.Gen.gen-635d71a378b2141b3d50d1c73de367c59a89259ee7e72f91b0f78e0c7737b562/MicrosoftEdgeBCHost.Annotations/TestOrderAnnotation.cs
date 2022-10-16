using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class TestOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralBase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralBase()
	{
	}
}
