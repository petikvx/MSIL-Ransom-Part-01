using Gecko.Interop;

namespace Gecko.DOM;

public sealed class DomEventTarget
{
	private ComPtr<nsIDOMEventTarget> _target;

	public nsIDOMEventTarget NativeObject => _target.Instance;

	public DomEventTarget TargetForDOMEvent => _target.Instance.GetTargetForDOMEvent().Wrap(Create);

	public DomEventTarget TargetForEventTargetChain => _target.Instance.GetTargetForEventTargetChain().Wrap(Create);

	private DomEventTarget(nsIDOMEventTarget target)
	{
		_target = new ComPtr<nsIDOMEventTarget>(target);
	}

	public static DomEventTarget Create(nsIDOMEventTarget target)
	{
		return new DomEventTarget(target);
	}

	public GeckoElement CastToGeckoElement()
	{
		nsIDOMElement obj = Xpcom.QueryInterface<nsIDOMElement>(_target.Instance);
		return obj.Wrap(GeckoElement.CreateDomElementWrapper);
	}

	public void DispatchEvent(DomEventArgs @event)
	{
		_target.Instance.DispatchEvent(@event.DomEvent);
	}

	public void AddEventListener(string type, nsIDOMEventListener listener, bool useCapture, bool wantUntrusted, int argc)
	{
		using nsAString type2 = new nsAString(type);
		_target.Instance.AddEventListener(type2, listener, useCapture, wantUntrusted, argc);
	}

	public void RemoveEventListener(string type, nsIDOMEventListener listener, bool useCapture)
	{
		using nsAString type2 = new nsAString(type);
		_target.Instance.RemoveEventListener(type2, listener, useCapture);
	}
}
