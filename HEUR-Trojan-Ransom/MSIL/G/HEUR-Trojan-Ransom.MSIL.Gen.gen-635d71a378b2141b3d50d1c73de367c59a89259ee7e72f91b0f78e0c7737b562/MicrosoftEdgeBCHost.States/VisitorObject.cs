using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class VisitorObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorObject()
	{
		WriterPropertyProducer.ResolveStub();
		ResetLiteralParams();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ResetLiteralParams()
	{
	}
}
