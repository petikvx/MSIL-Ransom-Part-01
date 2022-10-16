using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class ValBridge
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValBridge()
	{
		WriterPropertyProducer.ResolveStub();
		ValidateParser();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ValidateParser()
	{
	}
}
