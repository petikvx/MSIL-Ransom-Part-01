using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RegistryUtils
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegistryUtils()
	{
		WriterPropertyProducer.ResolveStub();
		ReadInterfaceMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadInterfaceMapper()
	{
	}
}
