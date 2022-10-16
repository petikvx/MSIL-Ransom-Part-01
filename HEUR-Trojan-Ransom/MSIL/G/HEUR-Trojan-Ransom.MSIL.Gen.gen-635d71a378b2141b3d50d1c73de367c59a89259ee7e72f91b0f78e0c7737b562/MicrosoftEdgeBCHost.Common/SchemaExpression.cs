using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class SchemaExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static SchemaExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralMapper();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralMapper()
	{
	}
}
