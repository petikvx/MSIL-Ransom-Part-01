using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ClassSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ClassSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		StopLiteralCode();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StopLiteralCode()
	{
	}
}
