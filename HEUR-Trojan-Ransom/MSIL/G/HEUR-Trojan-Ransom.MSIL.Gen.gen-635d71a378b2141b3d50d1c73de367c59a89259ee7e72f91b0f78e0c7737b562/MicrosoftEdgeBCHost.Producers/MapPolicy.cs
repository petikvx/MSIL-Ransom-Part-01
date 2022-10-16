using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class MapPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		IncludeInterfaceDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void IncludeInterfaceDatabase()
	{
	}
}
