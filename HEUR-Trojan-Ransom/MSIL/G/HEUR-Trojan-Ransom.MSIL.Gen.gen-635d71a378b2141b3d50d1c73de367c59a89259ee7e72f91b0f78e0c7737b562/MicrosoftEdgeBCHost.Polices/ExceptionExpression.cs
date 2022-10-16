using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class ExceptionExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ExceptionExpression()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralRole();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralRole()
	{
	}
}
