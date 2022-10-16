using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InstanceVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceVal()
	{
		WriterPropertyProducer.ResolveStub();
		PostUtils();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PostUtils()
	{
	}
}
