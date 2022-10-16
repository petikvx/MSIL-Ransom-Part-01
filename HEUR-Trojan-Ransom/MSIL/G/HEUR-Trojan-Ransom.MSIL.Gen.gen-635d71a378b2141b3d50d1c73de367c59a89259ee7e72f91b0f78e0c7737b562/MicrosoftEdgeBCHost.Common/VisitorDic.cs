using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class VisitorDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static VisitorDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralInfo();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralInfo()
	{
	}
}
