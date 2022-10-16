using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class DicPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceRepository()
	{
	}
}
