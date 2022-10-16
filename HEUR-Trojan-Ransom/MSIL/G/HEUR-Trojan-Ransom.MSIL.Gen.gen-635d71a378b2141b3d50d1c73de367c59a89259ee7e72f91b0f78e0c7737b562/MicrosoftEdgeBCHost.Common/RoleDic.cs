using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class RoleDic
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static RoleDic()
	{
		WriterPropertyProducer.ResolveStub();
		CompareLiteralCallback();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void CompareLiteralCallback()
	{
	}
}
