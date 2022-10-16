using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Exceptions;

internal class TestObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static TestObject()
	{
		WriterPropertyProducer.ResolveStub();
		PushLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PushLiteralParams()
	{
	}
}
