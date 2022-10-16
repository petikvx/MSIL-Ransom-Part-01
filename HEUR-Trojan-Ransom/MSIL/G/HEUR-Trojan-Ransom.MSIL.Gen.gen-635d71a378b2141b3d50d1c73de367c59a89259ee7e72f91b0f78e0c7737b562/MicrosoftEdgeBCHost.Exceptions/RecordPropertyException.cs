using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class RecordPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RecordPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		CheckLiteralMessage();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CheckLiteralMessage()
	{
	}
}
