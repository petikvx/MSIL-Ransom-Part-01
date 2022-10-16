using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class GlobalOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeLiteralHelper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeLiteralHelper()
	{
	}
}
