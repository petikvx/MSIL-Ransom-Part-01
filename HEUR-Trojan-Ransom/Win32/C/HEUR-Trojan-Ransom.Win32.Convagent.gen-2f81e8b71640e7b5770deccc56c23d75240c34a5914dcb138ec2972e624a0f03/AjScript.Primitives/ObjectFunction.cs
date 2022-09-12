using AjScript.Language;

namespace AjScript.Primitives;

public class ObjectFunction : Function
{
	public ObjectFunction(IContext context)
		: base(null, null, context)
	{
	}

	public override object NewInstance(object[] parameters)
	{
		return new DynamicObject(this);
	}
}
