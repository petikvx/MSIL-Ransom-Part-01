using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ParamsWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParamsWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatAuthentication();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatAuthentication()
	{
	}
}
