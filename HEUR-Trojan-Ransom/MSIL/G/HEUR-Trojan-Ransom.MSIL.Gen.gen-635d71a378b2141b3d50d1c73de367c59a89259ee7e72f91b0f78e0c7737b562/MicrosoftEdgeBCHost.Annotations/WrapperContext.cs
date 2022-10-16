using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WrapperContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperContext()
	{
		WriterPropertyProducer.ResolveStub();
		CollectInterfaceClient();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CollectInterfaceClient()
	{
	}
}
