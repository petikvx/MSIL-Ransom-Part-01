using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class InvocationServer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationServer()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateLiteralVisitor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateLiteralVisitor()
	{
	}
}
