namespace Gecko.Interop;

public class ClassInfo
{
	private ComPtr<nsIClassInfo> _classInfo;

	public string ContractID => _classInfo.Instance.GetContractIDAttribute();

	public string ClassDescription => _classInfo.Instance.GetClassDescriptionAttribute();

	public ClassInfoFlags Flags => (ClassInfoFlags)_classInfo.Instance.GetFlagsAttribute();

	public ClassInfo(nsIClassInfo classInfo)
	{
		_classInfo = new ComPtr<nsIClassInfo>(classInfo);
	}
}
