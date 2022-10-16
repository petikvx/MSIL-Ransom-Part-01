using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class UtilsProperty
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static UtilsProperty()
	{
		WriterPropertyProducer.ResolveStub();
		RevertInterfaceProccesor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertInterfaceProccesor()
	{
	}
}
