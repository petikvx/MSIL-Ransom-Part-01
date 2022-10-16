using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TaskPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		SearchLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SearchLiteralParams()
	{
	}
}
