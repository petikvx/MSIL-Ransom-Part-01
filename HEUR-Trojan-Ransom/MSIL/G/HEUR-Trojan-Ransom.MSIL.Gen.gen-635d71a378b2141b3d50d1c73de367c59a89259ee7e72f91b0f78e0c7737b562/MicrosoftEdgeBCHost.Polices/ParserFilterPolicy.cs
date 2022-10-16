using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ParserFilterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ParserFilterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		CallParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CallParameter()
	{
	}
}
