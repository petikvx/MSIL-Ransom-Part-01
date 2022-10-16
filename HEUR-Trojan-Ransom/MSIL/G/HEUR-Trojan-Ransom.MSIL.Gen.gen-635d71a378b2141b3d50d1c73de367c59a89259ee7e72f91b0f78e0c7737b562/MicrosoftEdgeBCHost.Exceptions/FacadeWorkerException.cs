using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadeWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		InsertConfiguration();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void InsertConfiguration()
	{
	}
}
