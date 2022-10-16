using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RequestWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RequestWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		CloneExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CloneExpression()
	{
	}
}
