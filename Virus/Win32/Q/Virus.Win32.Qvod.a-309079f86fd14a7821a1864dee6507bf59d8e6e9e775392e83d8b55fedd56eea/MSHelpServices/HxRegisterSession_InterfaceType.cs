using System.Runtime.InteropServices;

namespace MSHelpServices;

[Guid("31411230-A502-11D2-BBCA-00C04F8EC294")]
public enum HxRegisterSession_InterfaceType
{
	HxRegisterSession_IHxFilters = 1,
	HxRegisterSession_IHxPlugIn = 2,
	HxRegisterSession_IHxRegister = 0
}
