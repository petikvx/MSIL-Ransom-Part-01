using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RequestPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CompareInterfaceStub();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareInterfaceStub()
	{
	}
}
