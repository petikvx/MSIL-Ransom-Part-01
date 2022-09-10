using System;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[Serializable]
internal enum AuthenticationCapabilitiesOptions
{
	None = 0,
	StaticCloaking = 32,
	DynamicCloaking = 64,
	SecureReference = 2
}
