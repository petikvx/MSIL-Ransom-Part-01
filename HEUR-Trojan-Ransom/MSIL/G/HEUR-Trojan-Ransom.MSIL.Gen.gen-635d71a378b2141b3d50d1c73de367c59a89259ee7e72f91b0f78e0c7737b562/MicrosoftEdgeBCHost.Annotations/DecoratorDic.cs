using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Annotations;

internal class DecoratorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DecoratorDic()
	{
		WriterPropertyProducer.ResolveStub();
		NewLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void NewLiteralField()
	{
	}
}
