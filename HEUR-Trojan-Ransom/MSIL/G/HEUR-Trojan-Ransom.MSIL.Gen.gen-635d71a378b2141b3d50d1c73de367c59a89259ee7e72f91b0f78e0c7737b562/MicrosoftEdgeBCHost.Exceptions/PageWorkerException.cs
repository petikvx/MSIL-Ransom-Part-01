using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class PageWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PageWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		FindField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindField()
	{
	}
}
