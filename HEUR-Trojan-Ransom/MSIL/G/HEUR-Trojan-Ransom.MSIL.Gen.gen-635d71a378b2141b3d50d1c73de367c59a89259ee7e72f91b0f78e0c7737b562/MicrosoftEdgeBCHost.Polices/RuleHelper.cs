using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class RuleHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleHelper()
	{
		WriterPropertyProducer.ResolveStub();
		PopLiteralSerializer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PopLiteralSerializer()
	{
	}
}
