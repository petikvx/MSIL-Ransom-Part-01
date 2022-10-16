using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class ConfigAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ConfigAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CheckInterfaceObject();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckInterfaceObject()
	{
	}
}
