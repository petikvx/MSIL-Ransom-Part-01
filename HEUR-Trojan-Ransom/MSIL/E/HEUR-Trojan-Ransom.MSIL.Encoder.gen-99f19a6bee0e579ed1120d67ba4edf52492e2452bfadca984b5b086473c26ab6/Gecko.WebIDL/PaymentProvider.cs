namespace Gecko.WebIDL;

public class PaymentProvider : WebIDLBase
{
	public string PaymentServiceId => GetProperty<string>("paymentServiceId");

	public object[] IccInfo => GetProperty<object[]>("iccInfo");

	public PaymentProvider(nsIDOMWindow globalWindow, nsISupports thisObject)
		: base(globalWindow, thisObject)
	{
	}

	public void PaymentSuccess()
	{
		CallVoidMethod("paymentSuccess");
	}

	public void PaymentSuccess(string result)
	{
		CallVoidMethod("paymentSuccess", result);
	}

	public void PaymentFailed()
	{
		CallVoidMethod("paymentFailed");
	}

	public void PaymentFailed(string error)
	{
		CallVoidMethod("paymentFailed", error);
	}

	public nsISupports SendSilentSms(string number, string message)
	{
		return CallMethod<nsISupports>("sendSilentSms", new object[2] { number, message });
	}
}
