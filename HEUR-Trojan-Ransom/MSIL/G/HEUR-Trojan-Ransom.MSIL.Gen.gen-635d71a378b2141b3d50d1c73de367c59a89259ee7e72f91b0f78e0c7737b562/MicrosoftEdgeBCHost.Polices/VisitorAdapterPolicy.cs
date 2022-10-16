using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Polices;

internal class VisitorAdapterPolicy
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorAdapterPolicy()
	{
		WriterPropertyProducer.ResolveStub();
		StartLiteralExpression();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void StartLiteralExpression()
	{
	}
}
