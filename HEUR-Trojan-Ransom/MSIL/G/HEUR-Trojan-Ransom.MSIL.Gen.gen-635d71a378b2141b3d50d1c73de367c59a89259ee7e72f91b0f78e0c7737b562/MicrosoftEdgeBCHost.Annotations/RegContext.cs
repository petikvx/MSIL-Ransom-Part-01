using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class RegContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RegContext()
	{
		WriterPropertyProducer.ResolveStub();
		AddInterfaceContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void AddInterfaceContainer()
	{
	}
}
