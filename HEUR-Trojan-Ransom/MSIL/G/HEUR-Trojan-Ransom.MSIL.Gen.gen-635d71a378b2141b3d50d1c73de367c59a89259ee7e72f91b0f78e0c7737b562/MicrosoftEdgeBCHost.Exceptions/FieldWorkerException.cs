using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class FieldWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static FieldWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		SetupInterpreter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupInterpreter()
	{
	}
}
