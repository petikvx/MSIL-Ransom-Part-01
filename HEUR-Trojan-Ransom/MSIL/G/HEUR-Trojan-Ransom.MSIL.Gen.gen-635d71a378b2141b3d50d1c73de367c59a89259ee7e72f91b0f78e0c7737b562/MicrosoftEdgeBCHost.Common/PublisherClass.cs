using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PublisherClass
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PublisherClass()
	{
		WriterPropertyProducer.ResolveStub();
		LoginInterfacePool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginInterfacePool()
	{
	}
}
