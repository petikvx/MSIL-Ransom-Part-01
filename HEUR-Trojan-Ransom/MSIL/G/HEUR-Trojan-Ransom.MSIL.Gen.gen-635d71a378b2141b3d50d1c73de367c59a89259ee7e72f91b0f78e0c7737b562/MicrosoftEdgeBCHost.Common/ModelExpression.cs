using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class ModelExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ModelExpression()
	{
		WriterPropertyProducer.ResolveStub();
		EnableLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void EnableLiteralMapper()
	{
	}
}
