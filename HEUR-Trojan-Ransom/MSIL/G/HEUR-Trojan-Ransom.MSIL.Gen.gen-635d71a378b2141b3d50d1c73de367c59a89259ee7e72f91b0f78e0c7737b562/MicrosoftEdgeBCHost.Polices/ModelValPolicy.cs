using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ModelValPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelValPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		AwakeInterfaceServer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AwakeInterfaceServer()
	{
	}
}
