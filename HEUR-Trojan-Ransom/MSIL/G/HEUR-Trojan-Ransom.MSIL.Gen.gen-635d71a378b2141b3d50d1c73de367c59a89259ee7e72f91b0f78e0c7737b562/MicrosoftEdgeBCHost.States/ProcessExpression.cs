using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ProcessExpression
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ProcessExpression()
	{
		WriterPropertyProducer.ResolveStub();
		CalcLiteralCollection();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CalcLiteralCollection()
	{
	}
}
