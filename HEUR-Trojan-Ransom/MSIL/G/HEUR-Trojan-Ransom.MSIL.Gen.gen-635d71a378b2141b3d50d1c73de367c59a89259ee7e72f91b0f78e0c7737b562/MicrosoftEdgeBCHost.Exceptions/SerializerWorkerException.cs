using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class SerializerWorkerException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SerializerWorkerException()
	{
		WriterPropertyProducer.ResolveStub();
		MoveException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void MoveException()
	{
	}
}
