using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RepositoryOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RepositoryOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		CalcInterfaceStatus();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcInterfaceStatus()
	{
	}
}
