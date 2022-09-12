namespace Gecko;

public struct MutableJSVal
{
	private JsVal _val;

	public JsVal Val => _val;

	public MutableJSVal(JsVal val)
	{
		_val = val;
	}
}
