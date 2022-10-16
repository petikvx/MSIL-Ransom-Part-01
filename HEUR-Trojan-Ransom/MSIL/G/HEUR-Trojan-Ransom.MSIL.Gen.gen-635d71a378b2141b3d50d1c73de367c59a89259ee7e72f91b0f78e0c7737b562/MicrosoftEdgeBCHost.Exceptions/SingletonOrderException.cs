using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectInterfaceAdapter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectInterfaceAdapter()
	{
	}
}
