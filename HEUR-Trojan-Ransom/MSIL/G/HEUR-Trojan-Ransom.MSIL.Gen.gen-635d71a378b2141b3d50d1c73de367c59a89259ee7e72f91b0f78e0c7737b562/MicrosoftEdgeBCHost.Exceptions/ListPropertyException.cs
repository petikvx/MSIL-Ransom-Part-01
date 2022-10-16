using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class ListPropertyException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ListPropertyException()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralVisitor()
	{
	}
}
