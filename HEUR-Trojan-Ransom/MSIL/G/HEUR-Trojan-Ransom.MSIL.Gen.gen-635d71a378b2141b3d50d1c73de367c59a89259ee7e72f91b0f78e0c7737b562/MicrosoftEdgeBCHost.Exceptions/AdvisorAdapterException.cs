using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AdvisorAdapterException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AdvisorAdapterException()
	{
		WriterPropertyProducer.ResolveStub();
		VerifyInterfaceProc();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void VerifyInterfaceProc()
	{
	}
}
