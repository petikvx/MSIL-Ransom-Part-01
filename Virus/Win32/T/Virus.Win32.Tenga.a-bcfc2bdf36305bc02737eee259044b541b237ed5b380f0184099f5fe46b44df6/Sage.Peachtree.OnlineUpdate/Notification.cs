using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Web.Services;
using System.Web.Services.Protocols;

namespace Sage.Peachtree.OnlineUpdate;

[DebuggerStepThrough]
[DesignerCategory("code")]
[WebServiceBinding(Name = "NotificationSoap", Namespace = "http://tempuri.org/")]
public class Notification : SoapHttpClientProtocol
{
	public Notification()
	{
		((WebClientProtocol)this).set_Url("http://www.peachtreewebservices.com/OnlineUpdate/Notification.asmx");
	}

	[SoapDocumentMethod(/*Could not decode attribute arguments.*/)]
	public string ProductUpdateNotification(NotificationData data)
	{
		object[] array = ((SoapHttpClientProtocol)this).Invoke("ProductUpdateNotification", new object[1] { data });
		return (string)array[0];
	}

	public IAsyncResult BeginProductUpdateNotification(NotificationData data, AsyncCallback callback, object asyncState)
	{
		return ((SoapHttpClientProtocol)this).BeginInvoke("ProductUpdateNotification", new object[1] { data }, callback, asyncState);
	}

	public string EndProductUpdateNotification(IAsyncResult asyncResult)
	{
		object[] array = ((SoapHttpClientProtocol)this).EndInvoke(asyncResult);
		return (string)array[0];
	}
}
