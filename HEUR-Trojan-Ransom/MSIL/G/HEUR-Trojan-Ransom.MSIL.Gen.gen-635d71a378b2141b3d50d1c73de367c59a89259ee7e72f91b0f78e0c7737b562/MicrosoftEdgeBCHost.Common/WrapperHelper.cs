using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class WrapperHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static WrapperHelper()
	{
		WriterPropertyProducer.ResolveStub();
		LoginLiteralField();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void LoginLiteralField()
	{
	}
}
