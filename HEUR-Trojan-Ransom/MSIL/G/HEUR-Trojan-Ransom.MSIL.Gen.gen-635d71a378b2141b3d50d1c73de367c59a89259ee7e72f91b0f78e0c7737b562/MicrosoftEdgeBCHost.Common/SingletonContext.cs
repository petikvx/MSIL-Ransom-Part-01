using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SingletonContext
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonContext()
	{
		WriterPropertyProducer.ResolveStub();
		FlushInterfaceProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FlushInterfaceProducer()
	{
	}
}
