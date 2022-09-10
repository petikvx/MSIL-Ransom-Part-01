using System;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace Microsoft.Tools.ServiceModel.ComSvcConfig;

[ComImport]
[Guid("0002040E-0000-0000-C000-000000000046")]
[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
internal interface ICreateTypeInfo2
{
	void SetGuid([In][MarshalAs(UnmanagedType.LPStruct)] Guid guid);

	void SetTypeFlags(int uTypeFlags);

	void SetDocString(string doc);

	void SetHelpContext(int dwHelpContext);

	void SetVersion(short wMajorVerNum, short wMinorVerNum);

	void AddRefTypeInfo(ITypeInfo pTInfo, IntPtr phRefType);

	void AddFuncDesc(uint index, ref FUNCDESC pFuncDesc);

	void AddImplType(uint index, IntPtr hRefType);

	void SetImplTypeFlags(uint index, int implTypeFlags);

	void SetAlignment(int cbAlignment);

	void SetSchema(string pStrSchema);

	void AddVarDesc(uint index, ref VARDESC pVarDesc);

	void SetFuncAndParamNames();

	void SetVarName();

	void SetTypeDescAlias();

	void DefineFuncAsDllEntry();

	void SetFuncDocString();

	void SetVarDocString(ushort index, string szDocString);

	void SetFuncHelpContext(ushort index, uint dwHelpContext);

	void SetVarHelpContext(ushort index, uint dwHelpContext);

	void SetMops(ushort index, string bstrMops);

	void SetTypeIdldesc(ref IDLDESC pIdlDesc);

	void LayOut();

	void DeleteFuncDesc(ushort index);

	void DeleteFuncDescByMemId(int memid, INVOKEKIND invKind);

	void DeleteVarDesc(ushort index);

	void DeleteVarDescByMemId(int memid);

	void DeleteImplType();

	void SetCustData();

	void SetFuncCustData();

	void SetParamCustData();

	void SetVarCustData();

	void SetImplTypeCustData();

	void SetHelpStringContext();

	void SetFuncHelpStringContext();

	void SetVarHelpStringContext();

	void Invalidate();

	void SetName(string szName);
}
