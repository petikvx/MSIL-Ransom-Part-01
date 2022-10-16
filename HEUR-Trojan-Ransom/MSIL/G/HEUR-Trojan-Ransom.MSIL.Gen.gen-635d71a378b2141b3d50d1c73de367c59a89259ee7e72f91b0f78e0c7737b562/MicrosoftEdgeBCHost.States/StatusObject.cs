using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class StatusObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static StatusObject()
	{
		WriterPropertyProducer.ResolveStub();
		TestLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void TestLiteralParams()
	{
	}
}
