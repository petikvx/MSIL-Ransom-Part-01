using System.Collections.ObjectModel;
using System.Net;
using System.ServiceModel.Channels;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class HttpProxyTransportBindingElement : TransportBindingElement
{
	private HttpTransportBindingElement innerHttpTransport;

	private IWebProxy proxy;

	public override long MaxBufferPoolSize
	{
		get
		{
			return ((TransportBindingElement)innerHttpTransport).get_MaxBufferPoolSize();
		}
		set
		{
			((TransportBindingElement)innerHttpTransport).set_MaxBufferPoolSize(value);
		}
	}

	public override long MaxReceivedMessageSize
	{
		get
		{
			return ((TransportBindingElement)innerHttpTransport).get_MaxReceivedMessageSize();
		}
		set
		{
			((TransportBindingElement)innerHttpTransport).set_MaxReceivedMessageSize(value);
		}
	}

	public override string Scheme => ((TransportBindingElement)innerHttpTransport).get_Scheme();

	public static BindingElementCollection ReplaceHttpTransportWithProxy(BindingElementCollection bindingElements, IWebProxy proxy, bool turnOffClientAuthOnTransport)
	{
		//IL_004d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Expected O, but got Unknown
		int num = -1;
		for (int i = 0; i < ((Collection<BindingElement>)(object)bindingElements).Count; i++)
		{
			if (((Collection<BindingElement>)(object)bindingElements)[i] is HttpTransportBindingElement)
			{
				num = i;
				break;
			}
		}
		if (num == -1)
		{
			return bindingElements;
		}
		InfoCardTrace.Assert(num == ((Collection<BindingElement>)(object)bindingElements).Count - 1, "Transport should be last in the Binding Element list", new object[0]);
		HttpTransportBindingElement val = (HttpTransportBindingElement)((Collection<BindingElement>)(object)bindingElements)[num];
		if (turnOffClientAuthOnTransport)
		{
			val.set_AuthenticationScheme(AuthenticationSchemes.Anonymous);
		}
		HttpProxyTransportBindingElement httpProxyTransportBindingElement = (HttpProxyTransportBindingElement)(object)(((Collection<BindingElement>)(object)bindingElements)[num] = (BindingElement)(object)new HttpProxyTransportBindingElement(proxy, val));
		return bindingElements;
	}

	private HttpProxyTransportBindingElement(IWebProxy proxy, HttpTransportBindingElement innerHttpTransport)
	{
		this.innerHttpTransport = innerHttpTransport;
		this.proxy = proxy;
	}

	private HttpProxyTransportBindingElement(HttpProxyTransportBindingElement elementToBeCloned)
		: base((TransportBindingElement)(object)elementToBeCloned)
	{
		innerHttpTransport = elementToBeCloned.innerHttpTransport;
		proxy = elementToBeCloned.proxy;
	}

	public override IChannelFactory<TChannel> BuildChannelFactory<TChannel>(BindingContext context)
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		innerHttpTransport.set_Proxy(proxy);
		HttpChannelFactory val = (HttpChannelFactory)((BindingElement)innerHttpTransport).BuildChannelFactory<TChannel>(context);
		return (IChannelFactory<TChannel>)(object)val;
	}

	public override IChannelListener<TChannel> BuildChannelListener<TChannel>(BindingContext context)
	{
		return ((BindingElement)innerHttpTransport).BuildChannelListener<TChannel>(context);
	}

	public override bool CanBuildChannelFactory<TChannel>(BindingContext context)
	{
		return ((BindingElement)innerHttpTransport).CanBuildChannelFactory<TChannel>(context);
	}

	public override bool CanBuildChannelListener<TChannel>(BindingContext context)
	{
		return ((BindingElement)innerHttpTransport).CanBuildChannelListener<TChannel>(context);
	}

	public override BindingElement Clone()
	{
		return (BindingElement)(object)new HttpProxyTransportBindingElement(this);
	}

	public override T GetProperty<T>(BindingContext context)
	{
		return ((BindingElement)innerHttpTransport).GetProperty<T>(context);
	}
}
