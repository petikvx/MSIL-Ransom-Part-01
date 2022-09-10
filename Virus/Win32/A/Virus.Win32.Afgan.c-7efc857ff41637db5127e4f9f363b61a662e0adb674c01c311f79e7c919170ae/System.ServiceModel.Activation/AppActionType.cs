using System.Runtime.InteropServices;

namespace System.ServiceModel.Activation;

[StructLayout(LayoutKind.Auto)]
internal struct AppActionType : Enum
{
	public _003F value__;

	public const _003F Deleted = 0;

	public const _003F SettingsChanged = -2006099524;
}
