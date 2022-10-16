using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ProcessVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessVal()
	{
		WriterPropertyProducer.ResolveStub();
		RegisterAnnotation();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RegisterAnnotation()
	{
	}
}
