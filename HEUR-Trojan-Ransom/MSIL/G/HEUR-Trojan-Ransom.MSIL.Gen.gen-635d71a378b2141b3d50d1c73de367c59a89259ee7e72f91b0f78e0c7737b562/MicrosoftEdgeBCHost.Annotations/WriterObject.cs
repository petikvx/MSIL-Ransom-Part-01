using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class WriterObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WriterObject()
	{
		WriterPropertyProducer.ResolveStub();
		CallLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallLiteralParameter()
	{
	}
}
