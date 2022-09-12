namespace Gecko.WebIDL;

public class PhoneNumberService : WebIDLBase
{
	public PhoneNumberService(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public nsISupports FuzzyMatch()
	{
		return CallMethod<nsISupports>("fuzzyMatch", new object[0]);
	}

	public nsISupports FuzzyMatch(string number1)
	{
		return CallMethod<nsISupports>("fuzzyMatch", new object[1] { number1 });
	}

	public nsISupports FuzzyMatch(string number1, string number2)
	{
		return CallMethod<nsISupports>("fuzzyMatch", new object[2] { number1, number2 });
	}

	public string Normalize(string number)
	{
		return CallMethod<string>("normalize", new object[1] { number });
	}
}
