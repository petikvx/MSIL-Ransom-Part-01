using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InstanceDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InstanceDic()
	{
		WriterPropertyProducer.ResolveStub();
		LogoutLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LogoutLiteralInfo()
	{
	}
}
