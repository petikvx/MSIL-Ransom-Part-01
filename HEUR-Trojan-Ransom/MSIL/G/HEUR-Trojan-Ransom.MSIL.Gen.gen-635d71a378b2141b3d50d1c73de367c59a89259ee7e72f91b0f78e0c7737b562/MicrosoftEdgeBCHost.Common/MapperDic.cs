using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class MapperDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static MapperDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralField()
	{
	}
}
