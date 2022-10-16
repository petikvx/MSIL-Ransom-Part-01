using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FacadeOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FacadeOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CreateInterfaceWorker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateInterfaceWorker()
	{
	}
}
