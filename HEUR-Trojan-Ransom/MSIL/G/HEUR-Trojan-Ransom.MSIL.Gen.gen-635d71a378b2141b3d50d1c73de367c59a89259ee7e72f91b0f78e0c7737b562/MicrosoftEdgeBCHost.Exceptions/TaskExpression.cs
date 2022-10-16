using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TaskExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TaskExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralExporter()
	{
	}
}
