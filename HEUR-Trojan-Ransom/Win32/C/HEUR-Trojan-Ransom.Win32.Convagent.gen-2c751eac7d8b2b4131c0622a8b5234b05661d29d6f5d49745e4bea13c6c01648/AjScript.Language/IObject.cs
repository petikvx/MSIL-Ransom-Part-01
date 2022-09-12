using System.Collections.Generic;

namespace AjScript.Language;

public interface IObject
{
	IFunction Function { get; }

	object GetValue(string name);

	void SetValue(string name, object value);

	ICollection<string> GetNames();

	object Invoke(string name, object[] parameters);

	object Invoke(ICallable method, object[] parameters);
}
