using System.Dynamic;
using ns17;
using ns9;

namespace ns10;

internal class Class74 : GetMemberBinder
{
	private readonly GetMemberBinder getMemberBinder_0;

	public Class74(GetMemberBinder getMemberBinder_1)
		: base(getMemberBinder_1.Name, getMemberBinder_1.IgnoreCase)
	{
		getMemberBinder_0 = getMemberBinder_1;
	}

	DynamicMetaObject GetMemberBinder.FallbackGetMember(DynamicMetaObject target, DynamicMetaObject errorSuggestion)
	{
		DynamicMetaObject dynamicMetaObject = getMemberBinder_0.Bind(target, Class45.smethod_10<DynamicMetaObject>());
		return new DynamicMetaObject(new Class76().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
	}
}
