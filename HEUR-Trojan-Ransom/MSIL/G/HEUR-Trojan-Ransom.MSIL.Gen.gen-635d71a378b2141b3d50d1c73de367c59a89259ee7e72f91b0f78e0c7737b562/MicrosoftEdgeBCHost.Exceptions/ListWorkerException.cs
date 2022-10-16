using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		InstantiateSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InstantiateSingleton()
	{
	}
}
