using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ObjectOrder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectOrder()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutPool();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutPool()
	{
	}
}
