using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SingletonWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SingletonWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupContainer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupContainer()
	{
	}
}
