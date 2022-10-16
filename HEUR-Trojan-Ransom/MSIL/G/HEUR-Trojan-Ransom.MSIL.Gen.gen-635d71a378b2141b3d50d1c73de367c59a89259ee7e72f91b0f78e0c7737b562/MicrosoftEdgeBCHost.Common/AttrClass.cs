using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class AttrClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AttrClass()
	{
		WriterPropertyProducer.ResolveStub();
		InterruptInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InterruptInterfacePool()
	{
	}
}
