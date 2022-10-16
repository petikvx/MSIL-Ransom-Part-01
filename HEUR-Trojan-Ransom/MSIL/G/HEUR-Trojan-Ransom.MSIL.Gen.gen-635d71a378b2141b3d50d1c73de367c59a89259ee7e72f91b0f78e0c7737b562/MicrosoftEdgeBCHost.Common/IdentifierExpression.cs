using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class IdentifierExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static IdentifierExpression()
	{
		WriterPropertyProducer.ResolveStub();
		RevertLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void RevertLiteralRole()
	{
	}
}
