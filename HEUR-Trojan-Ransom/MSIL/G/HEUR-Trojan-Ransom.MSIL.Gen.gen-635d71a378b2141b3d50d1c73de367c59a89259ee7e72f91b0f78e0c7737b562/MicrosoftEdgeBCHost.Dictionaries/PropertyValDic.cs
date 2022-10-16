using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Dictionaries;

internal class PropertyValDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyValDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralSchema();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralSchema()
	{
	}
}
