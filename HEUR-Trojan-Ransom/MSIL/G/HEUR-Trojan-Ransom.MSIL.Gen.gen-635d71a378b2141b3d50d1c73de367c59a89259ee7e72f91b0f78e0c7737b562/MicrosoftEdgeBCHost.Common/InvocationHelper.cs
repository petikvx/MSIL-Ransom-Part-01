using System.Runtime.CompilerServices;
using MicrosoftEdgeBCHost.Producers;

namespace MicrosoftEdgeBCHost.Common;

internal class InvocationHelper
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	static InvocationHelper()
	{
		WriterPropertyProducer.ResolveStub();
		SetLiteralThread();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	internal static void SetLiteralThread()
	{
	}
}
