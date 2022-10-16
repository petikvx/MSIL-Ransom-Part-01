using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleSerializer
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleSerializer()
	{
		WriterPropertyProducer.ResolveStub();
		FillLiteralDescriptor();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void FillLiteralDescriptor()
	{
	}
}
