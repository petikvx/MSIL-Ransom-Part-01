using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class ValueObject
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ValueObject()
	{
		WriterPropertyProducer.ResolveStub();
		PrintLiteralParameter();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void PrintLiteralParameter()
	{
	}
}
