using System;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[Serializable]
internal enum ComponentFlags
{
	TypeInfoFound = 1,
	COMPlusPropertiesFound = 2,
	ProxyFound = 4,
	InterfacesFound = 8,
	AlreadyInstalled = 0x10,
	NotInApplication = 0x20
}
