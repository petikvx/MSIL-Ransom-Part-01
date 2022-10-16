using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdapterWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdapterWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupResolver();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupResolver()
	{
	}
}
