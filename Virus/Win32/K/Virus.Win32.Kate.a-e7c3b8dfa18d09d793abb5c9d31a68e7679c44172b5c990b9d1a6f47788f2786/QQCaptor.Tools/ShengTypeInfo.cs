using System.Collections.ObjectModel;

namespace QQCaptor.Tools;

public class ShengTypeInfo
{
	public string m_shenname;

	public string m_code;

	public Collection<CityTypeInfo> m_cityTypeList = new Collection<CityTypeInfo>();

	public ShengTypeInfo(string shenname, string code, Collection<CityTypeInfo> cityTypeList)
	{
		m_shenname = shenname;
		m_code = code;
		m_cityTypeList = cityTypeList;
	}
}
