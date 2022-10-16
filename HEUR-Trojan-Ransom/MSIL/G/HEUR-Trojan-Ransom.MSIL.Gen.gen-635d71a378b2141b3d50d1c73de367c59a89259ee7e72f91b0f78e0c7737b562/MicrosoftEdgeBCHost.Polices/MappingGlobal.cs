using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class MappingGlobal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MappingGlobal()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutInterfaceStrategy();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutInterfaceStrategy()
	{
	}
}
