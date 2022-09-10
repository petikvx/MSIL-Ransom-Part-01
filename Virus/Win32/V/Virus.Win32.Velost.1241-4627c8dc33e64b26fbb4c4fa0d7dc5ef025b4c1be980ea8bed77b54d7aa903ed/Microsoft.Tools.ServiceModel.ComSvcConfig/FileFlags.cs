using System;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[Serializable]
internal enum FileFlags
{
	Loadable = 1,
	COM = 2,
	ContainsPS = 4,
	ContainsComp = 8,
	ContainsTLB = 0x10,
	SelfReg = 0x20,
	SelfUnReg = 0x40,
	UnloadableDLL = 0x80,
	DoesNotExists = 0x100,
	AlreadyInstalled = 0x200,
	BadTLB = 0x400,
	GetClassObjFailed = 0x800,
	ClassNotAvailable = 0x1000,
	Registrar = 0x2000,
	NoRegistrar = 0x4000,
	DLLRegsvrFailed = 0x8000,
	RegTLBFailed = 0x10000,
	RegistrarFailed = 0x20000,
	Error = 0x40000
}
