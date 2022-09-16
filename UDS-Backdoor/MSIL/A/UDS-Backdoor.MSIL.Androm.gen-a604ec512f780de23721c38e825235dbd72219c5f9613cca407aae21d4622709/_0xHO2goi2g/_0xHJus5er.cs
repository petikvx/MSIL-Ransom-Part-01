using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Internal.VisualStudio.PlatformUI.Automation;

namespace _0xHO2goi2g;

public class _0xHJus5er : TextBlock
{
	private class _0xHP1trici1n : FrameworkElementAutomationPeer, ICustomAutomationEventSource
	{
		public _0xHP1trici1n(_0xHJus5er owner)
			: base((FrameworkElement)(object)owner)
		{
		}

		public IRawElementProviderSimple _0xH8axilliped()
		{
			return ((AutomationPeer)this).ProviderFromPeer((AutomationPeer)(object)this);
		}

		protected override AutomationControlType GetAutomationControlTypeCore()
		{
			return (AutomationControlType)20;
		}

		protected override string GetClassNameCore()
		{
			return "LiveTextBlock";
		}

		protected override bool IsContentElementCore()
		{
			return true;
		}

		protected override bool IsControlElementCore()
		{
			return true;
		}
	}

	private static AutomationLiveSetting _0xHFib6rl6ss = (AutomationLiveSetting)1;

	public static readonly DependencyProperty _0xHAdob4 = DependencyProperty.Register("LiveText", typeof(string), typeof(_0xHJus5er), new PropertyMetadata((object)null, new PropertyChangedCallback(_0xHJamm5)));

	public string _0xHImbe4ilities
	{
		get
		{
			return (string)((DependencyObject)this).GetValue(_0xHAdob4);
		}
		set
		{
			((DependencyObject)this).SetValue(_0xHAdob4, (object)value);
		}
	}

	public _0xHJus5er()
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Expected O, but got Unknown
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0035: Expected O, but got Unknown
		CustomAutomationProperties.SetLiveSetting((DependencyObject)(object)this, _0xHFib6rl6ss);
		Binding val = new Binding();
		val.set_Path(new PropertyPath((object)TextBlock.TextProperty));
		val.set_Source((object)this);
		val.set_Mode((BindingMode)1);
		Binding val2 = val;
		((FrameworkElement)this).SetBinding(_0xHAdob4, (BindingBase)(object)val2);
	}

	private static void _0xHJamm5(DependencyObject _0xHD4gos, DependencyPropertyChangedEventArgs _0xHMi2re)
	{
		if (_0xHD4gos is _0xHJus5er _0xHJus5er2)
		{
			AutomationPeer obj = UIElementAutomationPeer.CreatePeerForElement((UIElement)(object)_0xHJus5er2);
			AutomationPeer obj2 = ((obj is ICustomAutomationEventSource) ? obj : null);
			if (obj2 != null)
			{
				CustomAutomationEvents.RaiseCustomAutomationEvent((ICustomAutomationEventSource)(object)obj2, CustomAutomationEvents.LiveRegionChangedEvent);
			}
		}
	}

	protected override AutomationPeer OnCreateAutomationPeer()
	{
		return (AutomationPeer)(object)new _0xHP1trici1n(this);
	}
}
