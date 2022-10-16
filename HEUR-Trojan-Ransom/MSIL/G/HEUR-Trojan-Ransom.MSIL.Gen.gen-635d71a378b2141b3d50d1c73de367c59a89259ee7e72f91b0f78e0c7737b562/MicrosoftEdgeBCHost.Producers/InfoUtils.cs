using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class InfoUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InfoUtils()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceGlobal();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceGlobal()
	{
	}
}
