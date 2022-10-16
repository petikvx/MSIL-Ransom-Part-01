using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ThreadWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ThreadWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutVisitor()
	{
	}
}
