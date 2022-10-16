using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class DicDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static DicDic()
	{
		WriterPropertyProducer.ResolveStub();
		CreateLiteralSpecification();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CreateLiteralSpecification()
	{
	}
}
