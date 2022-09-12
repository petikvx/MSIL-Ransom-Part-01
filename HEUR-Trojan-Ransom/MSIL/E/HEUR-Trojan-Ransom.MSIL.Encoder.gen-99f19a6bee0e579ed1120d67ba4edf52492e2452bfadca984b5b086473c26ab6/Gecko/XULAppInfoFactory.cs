using System.Runtime.InteropServices;

namespace Gecko;

[ContractID("@mozilla.org/xre/app-info;1")]
[Guid("8E4AABE2-B832-4cff-B213-2174DE2B839F")]
internal class XULAppInfoFactory : GenericOneClassNsFactory<XULAppInfoFactory, XULAppInfo>
{
	public const string ContractID = "@mozilla.org/xre/app-info;1";

	public static void Init()
	{
		XULAppInfo.Init();
		BaseNsFactory<XULAppInfoFactory>.Register();
	}
}
