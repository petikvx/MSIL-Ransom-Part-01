using System.Dynamic;
using ns1;
using ns14;

namespace ns8;

internal class Class73 : GetMemberBinder
{
	private readonly GetMemberBinder getMemberBinder_0;

	public Class73(GetMemberBinder getMemberBinder_1)
		: base(getMemberBinder_1.Name, getMemberBinder_1.IgnoreCase)
	{
		getMemberBinder_0 = getMemberBinder_1;
	}

	DynamicMetaObject GetMemberBinder.FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
	{
		DynamicMetaObject dynamicMetaObject = getMemberBinder_0.Bind(target, Class44.smethod_10<DynamicMetaObject>());
		return new DynamicMetaObject(new Class75().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
	}
}
