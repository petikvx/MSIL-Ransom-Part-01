using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class CodeVal
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static CodeVal()
	{
		WriterPropertyProducer.ResolveStub();
		ReadProducer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ReadProducer()
	{
	}
}
