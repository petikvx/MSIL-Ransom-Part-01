using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class WriterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateInterfaceStub()
	{
	}
}
