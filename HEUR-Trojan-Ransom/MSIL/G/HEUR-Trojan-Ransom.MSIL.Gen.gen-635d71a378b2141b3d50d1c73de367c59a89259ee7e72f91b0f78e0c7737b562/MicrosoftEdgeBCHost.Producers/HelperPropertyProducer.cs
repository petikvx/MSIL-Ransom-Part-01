using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class HelperPropertyProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static HelperPropertyProducer()
	{
		WriterPropertyProducer.ResolveStub();
		UpdateLiteralCreator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void UpdateLiteralCreator()
	{
	}
}
