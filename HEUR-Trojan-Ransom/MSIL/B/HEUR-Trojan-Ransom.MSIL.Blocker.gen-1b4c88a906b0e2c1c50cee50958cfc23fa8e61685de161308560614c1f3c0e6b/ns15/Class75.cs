using System.Dynamic;
using ns2;

namespace ns15;

internal class Class75 : SetMemberBinder
{
	private readonly SetMemberBinder setMemberBinder_0;

	public Class75(SetMemberBinder setMemberBinder_1)
		: base(setMemberBinder_1.Name, setMemberBinder_1.IgnoreCase)
	{
		setMemberBinder_0 = setMemberBinder_1;
	}

	DynamicMetaObject SetMemberBinder.FallbackSetMember(DynamicMetaObject target, DynamicMetaObject value, DynamicMetaObject errorSuggestion)
	{
		DynamicMetaObject dynamicMetaObject = setMemberBinder_0.Bind(target, new DynamicMetaObject[1] { value });
		return new DynamicMetaObject(new Class76().Visit(dynamicMetaObject.Expression), dynamicMetaObject.Restrictions);
	}
}
