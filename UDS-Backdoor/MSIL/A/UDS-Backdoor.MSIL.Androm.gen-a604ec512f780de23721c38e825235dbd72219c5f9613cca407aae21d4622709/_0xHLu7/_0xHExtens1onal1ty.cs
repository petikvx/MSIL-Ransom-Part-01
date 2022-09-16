using System;
using EnvDTE;
using Microsoft.VisualStudio;
using Microsoft.VisualStudio.Shell.Interop;
using Microsoft.VisualStudio.WindowsAzure;

namespace _0xHLu7;

internal static class _0xHExtens1onal1ty
{
	internal static bool _0xHDecom6ensates(this IServiceProvider _0xHE4ectrowinnings)
	{
		IVsExtensibility3 obj = ServiceProviderExtensions.GetService<IVsExtensibility3, IVsExtensibility>(_0xHE4ectrowinnings) ?? throw new InvalidOperationException();
		int num = 0;
		ErrorHandler.ThrowOnFailure(obj.IsInAutomationFunction(ref num));
		return num != 0;
	}
}
