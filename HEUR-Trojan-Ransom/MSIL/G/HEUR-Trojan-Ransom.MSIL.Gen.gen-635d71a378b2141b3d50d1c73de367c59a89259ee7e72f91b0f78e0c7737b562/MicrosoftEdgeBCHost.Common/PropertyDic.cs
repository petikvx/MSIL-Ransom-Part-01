using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class PropertyDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static PropertyDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralSingleton();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralSingleton()
	{
	}
}
