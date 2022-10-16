using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class StubUtilsException
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StubUtilsException()
	{
		WriterPropertyProducer.ResolveStub();
		RunLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RunLiteralSerializer()
	{
	}
}
