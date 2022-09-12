using AjScript.Language;

namespace AjScript;

public interface IContext
{
	ReturnValue ReturnValue { get; set; }

	void SetValue(string name, object value);

	object GetValue(string name);

	void DefineVariable(string name);
}
