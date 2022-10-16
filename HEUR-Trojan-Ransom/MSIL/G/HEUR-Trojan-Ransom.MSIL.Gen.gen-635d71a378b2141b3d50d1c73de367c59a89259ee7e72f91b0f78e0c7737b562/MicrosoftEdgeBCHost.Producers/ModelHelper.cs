using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ModelHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PatchLiteralFilter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchLiteralFilter()
	{
	}
}
