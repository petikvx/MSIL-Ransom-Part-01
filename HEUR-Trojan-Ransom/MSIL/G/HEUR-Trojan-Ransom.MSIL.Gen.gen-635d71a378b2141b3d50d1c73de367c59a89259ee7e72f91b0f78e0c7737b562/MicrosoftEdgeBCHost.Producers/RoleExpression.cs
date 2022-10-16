using System.Runtime.CompilerServices;

namespace MicrosoftEdgeBCHost.Producers;

internal class RoleExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleExpression()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralCollection()
	{
	}
}
