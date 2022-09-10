using System;

namespace Intuit.Spc.Map.HelpSystem;

[Flags]
internal enum CLSCTX : uint
{
	CLSCTX_INPROC_SERVER = 1u,
	CLSCTX_INPROC_HANDLER = 2u,
	CLSCTX_LOCAL_SERVER = 4u,
	CLSCTX_INPROC_SERVER16 = 8u,
	CLSCTX_REMOTE_SERVER = 0x10u,
	CLSCTX_INPROC_HANDLER16 = 0x20u,
	CLSCTX_RESERVED1 = 0x40u,
	CLSCTX_RESERVED2 = 0x80u,
	CLSCTX_RESERVED3 = 0x100u,
	CLSCTX_RESERVED4 = 0x200u,
	CLSCTX_NO_CODE_DOWNLOAD = 0x400u,
	CLSCTX_RESERVED5 = 0x800u,
	CLSCTX_NO_CUSTOM_MARSHAL = 0x1000u,
	CLSCTX_ENABLE_CODE_DOWNLOAD = 0x2000u,
	CLSCTX_NO_FAILURE_LOG = 0x4000u,
	CLSCTX_DISABLE_AAA = 0x8000u,
	CLSCTX_ENABLE_AAA = 0x10000u,
	CLSCTX_FROM_DEFAULT_CONTEXT = 0x20000u,
	CLSCTX_INPROC = 3u,
	CLSCTX_SERVER = 0x15u,
	CLSCTX_ALL = 0x17u
}
