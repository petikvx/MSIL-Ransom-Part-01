using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegAdapter
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegAdapter()
	{
		WriterPropertyProducer.ResolveStub();
		CustomizeInterfaceInstance();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CustomizeInterfaceInstance()
	{
	}
}
