using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ContextOrderAnnotation
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ContextOrderAnnotation()
	{
		WriterPropertyProducer.ResolveStub();
		RestartLiteralList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RestartLiteralList()
	{
	}
}
