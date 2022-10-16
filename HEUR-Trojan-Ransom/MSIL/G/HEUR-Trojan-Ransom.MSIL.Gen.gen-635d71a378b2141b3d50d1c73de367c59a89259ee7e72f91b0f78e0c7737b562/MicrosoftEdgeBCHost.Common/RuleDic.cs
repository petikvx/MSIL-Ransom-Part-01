using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RuleDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RuleDic()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralDatabase();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralDatabase()
	{
	}
}
