using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class RoleValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleValDic()
	{
		WriterPropertyProducer.ResolveStub();
		ComputeLiteralTokenizer();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void ComputeLiteralTokenizer()
	{
	}
}
