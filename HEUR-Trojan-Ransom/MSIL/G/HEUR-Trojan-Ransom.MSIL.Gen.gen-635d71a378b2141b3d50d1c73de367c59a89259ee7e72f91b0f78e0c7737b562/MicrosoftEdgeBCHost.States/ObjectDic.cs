using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.States;

internal class ObjectDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static ObjectDic()
	{
		WriterPropertyProducer.ResolveStub();
		SetupLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetupLiteralSpecification()
	{
	}
}
