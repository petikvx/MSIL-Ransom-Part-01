using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class SingletonAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralSingleton()
	{
	}
}
