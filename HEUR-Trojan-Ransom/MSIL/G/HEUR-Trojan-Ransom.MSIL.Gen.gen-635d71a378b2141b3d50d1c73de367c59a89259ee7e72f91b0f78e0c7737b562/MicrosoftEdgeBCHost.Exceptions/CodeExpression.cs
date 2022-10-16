using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class CodeExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeExpression()
	{
		WriterPropertyProducer.ResolveStub();
		ConnectLiteralExporter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ConnectLiteralExporter()
	{
	}
}
