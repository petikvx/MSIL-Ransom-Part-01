namespace Gecko;

public sealed class GeckoNativeException : GeckoException
{
	private nsIException _exception;

	public string Name => nsString.Get(_exception.GetNameAttribute);

	private GeckoNativeException(nsIException exception)
		: base(nsString.Get(exception.GetMessageAttribute))
	{
		_exception = exception;
	}

	internal static GeckoNativeException Create(nsIException exception)
	{
		return (exception == null) ? null : new GeckoNativeException(exception);
	}
}
