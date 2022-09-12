namespace Gecko.WebIDL;

public class ValidityState : WebIDLBase
{
	public bool ValueMissing => GetProperty<bool>("valueMissing");

	public bool TypeMismatch => GetProperty<bool>("typeMismatch");

	public bool PatternMismatch => GetProperty<bool>("patternMismatch");

	public bool TooLong => GetProperty<bool>("tooLong");

	public bool RangeUnderflow => GetProperty<bool>("rangeUnderflow");

	public bool RangeOverflow => GetProperty<bool>("rangeOverflow");

	public bool StepMismatch => GetProperty<bool>("stepMismatch");

	public bool BadInput => GetProperty<bool>("badInput");

	public bool CustomError => GetProperty<bool>("customError");

	public bool Valid => GetProperty<bool>("valid");

	public ValidityState(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}
}
