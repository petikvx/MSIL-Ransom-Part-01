using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class StructOrderProducer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StructOrderProducer()
	{
		WriterPropertyProducer.ResolveStub();
		PatchInterfaceField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PatchInterfaceField()
	{
	}
}
