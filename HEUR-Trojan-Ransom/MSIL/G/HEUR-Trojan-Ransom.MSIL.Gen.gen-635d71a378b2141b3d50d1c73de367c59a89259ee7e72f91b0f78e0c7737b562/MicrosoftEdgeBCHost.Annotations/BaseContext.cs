using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class BaseContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static BaseContext()
	{
		WriterPropertyProducer.ResolveStub();
		CountInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CountInterfaceContainer()
	{
	}
}
