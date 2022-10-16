using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RepositoryAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		ConcatInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConcatInterfaceProc()
	{
	}
}
