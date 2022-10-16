using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class GlobalAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static GlobalAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CallInterfaceMethod();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallInterfaceMethod()
	{
	}
}
