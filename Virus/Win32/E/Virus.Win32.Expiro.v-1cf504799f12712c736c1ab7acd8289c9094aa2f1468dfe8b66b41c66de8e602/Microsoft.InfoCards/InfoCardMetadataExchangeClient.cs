using System;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using Microsoft.InfoCards.Diagnostics;

namespace Microsoft.InfoCards;

internal class InfoCardMetadataExchangeClient : MetadataExchangeClient
{
	private HttpWebRequest m_currentHttpGetRequest;

	private object m_abortSync;

	private bool m_aborted;

	private IWebProxy m_proxy;

	public IWebProxy Proxy
	{
		set
		{
			m_proxy = value;
		}
	}

	public InfoCardMetadataExchangeClient(Binding mexBinding)
		: base(mexBinding)
	{
		m_abortSync = new object();
	}

	public void Abort()
	{
		lock (m_abortSync)
		{
			if (m_currentHttpGetRequest != null)
			{
				m_currentHttpGetRequest.Abort();
			}
			else
			{
				ChannelFactory<IMetadataExchange> channelFactory = ((MetadataExchangeClient)this).GetChannelFactory((EndpointAddress)null, (string)null, (string)null);
				if (channelFactory != null)
				{
					((CommunicationObject)channelFactory).Abort();
				}
			}
			m_aborted = true;
		}
	}

	protected override HttpWebRequest GetWebRequest(Uri location, string dialect, string identifier)
	{
		if (string.Compare(location.Scheme, "https", StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("NonHttpsURIFound", new object[1] { location.AbsoluteUri })));
		}
		HttpWebRequest webRequest = ((MetadataExchangeClient)this).GetWebRequest(location, dialect, identifier);
		InfoCardTrace.Assert(null != m_proxy, "Set the proxy value before creating a WebRequest", new object[0]);
		webRequest.Proxy = m_proxy;
		lock (m_abortSync)
		{
			if (m_aborted)
			{
				webRequest.Abort();
			}
			return m_currentHttpGetRequest = webRequest;
		}
	}

	protected override ChannelFactory<IMetadataExchange> GetChannelFactory(EndpointAddress metadataAddress, string dialect, string identifier)
	{
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		if ((EndpointAddress)null != metadataAddress && string.Compare(metadataAddress.get_Uri().Scheme, "https", StringComparison.OrdinalIgnoreCase) != 0)
		{
			throw InfoCardTrace.ThrowHelperError((Exception)(object)new TrustExchangeException(SR.GetString("NonHttpsURIFound", new object[1] { metadataAddress.get_Uri().AbsoluteUri })));
		}
		InfoCardTrace.Assert(null != m_proxy, "Set the proxy value before creating a WebRequest", new object[0]);
		ChannelFactory<IMetadataExchange> channelFactory = ((MetadataExchangeClient)this).GetChannelFactory(metadataAddress, dialect, identifier);
		((ChannelFactory)channelFactory).get_Endpoint().set_Binding((Binding)new CustomBinding((IEnumerable<BindingElement>)HttpProxyTransportBindingElement.ReplaceHttpTransportWithProxy(((ChannelFactory)channelFactory).get_Endpoint().get_Binding().CreateBindingElements(), m_proxy)));
		lock (m_abortSync)
		{
			if (m_aborted)
			{
				((CommunicationObject)channelFactory).Abort();
				return channelFactory;
			}
			return channelFactory;
		}
	}
}
