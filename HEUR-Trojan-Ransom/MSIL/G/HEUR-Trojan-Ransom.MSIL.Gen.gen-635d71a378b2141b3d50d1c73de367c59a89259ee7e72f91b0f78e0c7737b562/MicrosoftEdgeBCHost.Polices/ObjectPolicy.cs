using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ObjectPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ResetInterfaceRepository();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetInterfaceRepository()
	{
	}
}
