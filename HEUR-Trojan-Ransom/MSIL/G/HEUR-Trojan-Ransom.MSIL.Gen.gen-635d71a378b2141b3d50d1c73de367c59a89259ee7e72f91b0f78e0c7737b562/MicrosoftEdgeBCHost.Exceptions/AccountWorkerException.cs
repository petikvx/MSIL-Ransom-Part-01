using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class AccountWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static AccountWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		FindInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FindInterpreter()
	{
	}
}
