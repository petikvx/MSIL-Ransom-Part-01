using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorOrderException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorOrderException()
	{
		WriterPropertyProducer.ResolveStub();
		RunInterfaceException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunInterfaceException()
	{
	}
}
