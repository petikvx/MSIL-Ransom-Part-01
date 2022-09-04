using System;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml;

public sealed class GClass1 : GClass0, IEquatable<GClass1>
{
	private EndPoint endPoint_0;

	private IPAddress ipaddress_0;

	private string string_0;

	private string string_1;

	private string string_2;

	private GDelegate0 gdelegate0_0;

	internal GClass1(IPAddress ipaddress_1, string string_3, string string_4)
	{
		Class51.smethod_0();
		base._002Ector();
		imethod_16(DateTime.Now);
		ipaddress_0 = ipaddress_1;
		string text = string_3.Substring(string_3.IndexOf("Location", StringComparison.InvariantCultureIgnoreCase) + 9).Split(new char[1] { '\r' })[0];
		string_2 = string_4;
		text = text.Trim();
		if (text.StartsWith("http://", StringComparison.InvariantCultureIgnoreCase))
		{
			GClass3.smethod_4("Found device at: {0}", text);
			text = text.Substring(7);
			string text2 = text.Remove(text.IndexOf('/'));
			if (text2.IndexOf(':') > 0)
			{
				endPoint_0 = new IPEndPoint(IPAddress.Parse(text2.Remove(text2.IndexOf(':'))), Convert.ToUInt16(text2.Substring(text2.IndexOf(':') + 1), CultureInfo.InvariantCulture));
			}
			else
			{
				endPoint_0 = new IPEndPoint(IPAddress.Parse(text2), 80);
			}
			GClass3.smethod_4("Parsed device as: {0}", endPoint_0.ToString());
			string_0 = text.Substring(text.IndexOf('/'));
		}
	}

	[SpecialName]
	internal EndPoint method_0()
	{
		return endPoint_0;
	}

	[SpecialName]
	internal string method_1()
	{
		return string_0;
	}

	[SpecialName]
	internal string method_2()
	{
		return string_1;
	}

	[SpecialName]
	internal string method_3()
	{
		return string_2;
	}

	public override IAsyncResult imethod_8(AsyncCallback asyncCallback_0, object object_0)
	{
		Class39 class34_ = new Class39(this);
		return method_4(class34_, asyncCallback_0, object_0, method_11);
	}

	public override IAsyncResult imethod_5(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0)
	{
		Class37 class34_ = new Class37(gclass2_0, ipaddress_0, this);
		return method_4(class34_, asyncCallback_0, gclass2_0, method_7);
	}

	public override IAsyncResult imethod_6(GClass2 gclass2_0, AsyncCallback asyncCallback_0, object object_0)
	{
		Class38 class34_ = new Class38(gclass2_0, this);
		return method_4(class34_, asyncCallback_0, object_0, method_9);
	}

	public override IAsyncResult imethod_7(AsyncCallback asyncCallback_0, object object_0)
	{
		Class40 class34_ = new Class40(0, this);
		return method_4(class34_, asyncCallback_0, object_0, method_10);
	}

	public override IAsyncResult imethod_9(GEnum1 genum1_0, int int_0, AsyncCallback asyncCallback_0, object object_0)
	{
		Class41 class34_ = new Class41(genum1_0, int_0, this);
		return method_4(class34_, asyncCallback_0, object_0, method_12);
	}

	public override void imethod_10(IAsyncResult iasyncResult_0)
	{
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException("result");
		}
		if (!(iasyncResult_0 is Class26 @class))
		{
			throw new ArgumentException("Invalid AsyncResult", "result");
		}
		if (!iasyncResult_0.IsCompleted)
		{
			iasyncResult_0.AsyncWaitHandle.WaitOne();
		}
		if (@class.method_8() is Class35)
		{
			Class35 class2 = @class.method_8() as Class35;
			throw new GException0(class2.method_1(), class2.Description);
		}
	}

	public override void imethod_11(IAsyncResult iasyncResult_0)
	{
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException("result");
		}
		if (!(iasyncResult_0 is Class26 @class))
		{
			throw new ArgumentException("Invalid AsyncResult", "result");
		}
		if (!@class.IsCompleted)
		{
			@class.method_0().WaitOne();
		}
		if (@class.method_8() is Class35)
		{
			Class35 class2 = @class.method_8() as Class35;
			throw new GException0(class2.method_1(), class2.Description);
		}
	}

	public override GClass2[] imethod_12(IAsyncResult iasyncResult_0)
	{
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException("result");
		}
		if (!(iasyncResult_0 is Class27 @class))
		{
			throw new ArgumentException("Invalid AsyncResult", "result");
		}
		if (!@class.IsCompleted)
		{
			@class.method_0().WaitOne();
		}
		if (@class.method_8() is Class35)
		{
			Class35 class2 = @class.method_8() as Class35;
			if (class2.method_1() != 713)
			{
				throw new GException0(class2.method_1(), class2.Description);
			}
		}
		return @class.method_10().ToArray();
	}

	public override IPAddress imethod_13(IAsyncResult iasyncResult_0)
	{
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException("result");
		}
		if (!(iasyncResult_0 is Class26 @class))
		{
			throw new ArgumentException("Invalid AsyncResult", "result");
		}
		if (!iasyncResult_0.IsCompleted)
		{
			iasyncResult_0.AsyncWaitHandle.WaitOne();
		}
		if (@class.method_8() is Class35)
		{
			Class35 class2 = @class.method_8() as Class35;
			throw new GException0(class2.method_1(), class2.Description);
		}
		return ((Class44)@class.method_8()).method_1();
	}

	public override GClass2 imethod_14(IAsyncResult iasyncResult_0)
	{
		if (iasyncResult_0 == null)
		{
			throw new ArgumentNullException("result");
		}
		if (!(iasyncResult_0 is Class27 @class))
		{
			throw new ArgumentException("Invalid AsyncResult", "result");
		}
		if (!@class.IsCompleted)
		{
			@class.method_0().WaitOne();
		}
		if (@class.method_8() is Class35)
		{
			Class35 class2 = @class.method_8() as Class35;
			if (class2.method_1() != 714)
			{
				throw new GException0(class2.method_1(), class2.Description);
			}
		}
		if (@class.method_10().Count == 0)
		{
			return new GClass2((GEnum1)0, -1, -1);
		}
		return @class.method_10()[0];
	}

	public override bool Equals(object obj)
	{
		if (obj is GClass1 other)
		{
			return Equals(other);
		}
		return false;
	}

	public bool Equals(GClass1 other)
	{
		if (other != null)
		{
			if (endPoint_0.Equals(other.endPoint_0))
			{
				return string_0 == other.string_0;
			}
			return false;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return endPoint_0.GetHashCode() ^ string_1.GetHashCode() ^ string_0.GetHashCode();
	}

	private IAsyncResult method_4(Class34 class34_0, AsyncCallback asyncCallback_0, object object_0, AsyncCallback asyncCallback_1)
	{
		_003C_003Ec__DisplayClass2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass2();
		CS_0024_003C_003E8__locals0.callback = asyncCallback_1;
		CS_0024_003C_003E8__locals0.request = class34_0.vmethod_0(out CS_0024_003C_003E8__locals0.body);
		CS_0024_003C_003E8__locals0.mappingResult = Class26.smethod_0(class34_0, CS_0024_003C_003E8__locals0.request, asyncCallback_0, object_0);
		if (CS_0024_003C_003E8__locals0.body.Length > 0)
		{
			CS_0024_003C_003E8__locals0.request.ContentLength = CS_0024_003C_003E8__locals0.body.Length;
			CS_0024_003C_003E8__locals0.request.BeginGetRequestStream(delegate(IAsyncResult result)
			{
				try
				{
					Stream stream = CS_0024_003C_003E8__locals0.request.EndGetRequestStream(result);
					stream.Write(CS_0024_003C_003E8__locals0.body, 0, CS_0024_003C_003E8__locals0.body.Length);
					CS_0024_003C_003E8__locals0.request.BeginGetResponse(CS_0024_003C_003E8__locals0.callback, CS_0024_003C_003E8__locals0.mappingResult);
				}
				catch (Exception exception_)
				{
					CS_0024_003C_003E8__locals0.mappingResult.method_5(exception_);
				}
			}, null);
		}
		else
		{
			CS_0024_003C_003E8__locals0.request.BeginGetResponse(CS_0024_003C_003E8__locals0.callback, CS_0024_003C_003E8__locals0.mappingResult);
		}
		return CS_0024_003C_003E8__locals0.mappingResult;
	}

	private void method_5(IAsyncResult iasyncResult_0)
	{
		Class26 @class = iasyncResult_0.AsyncState as Class26;
		@class.CompletedSynchronously = iasyncResult_0.CompletedSynchronously;
		@class.method_4();
	}

	private Class34 method_6(Stream stream_0, long long_0)
	{
		StringBuilder stringBuilder = new StringBuilder();
		int num = 0;
		int i = 0;
		byte[] array = new byte[10240];
		if (long_0 != -1L)
		{
			for (; i < long_0; i += num)
			{
				num = stream_0.Read(array, 0, array.Length);
				stringBuilder.Append(Encoding.UTF8.GetString(array, 0, num));
			}
		}
		else
		{
			while ((num = stream_0.Read(array, 0, array.Length)) != 0)
			{
				stringBuilder.Append(Encoding.UTF8.GetString(array, 0, num));
			}
		}
		return Class34.smethod_0(this, stringBuilder.ToString());
	}

	private void method_7(IAsyncResult iasyncResult_0)
	{
		method_8(iasyncResult_0);
		method_5(iasyncResult_0);
	}

	private void method_8(IAsyncResult iasyncResult_0)
	{
		HttpWebResponse httpWebResponse = null;
		Class26 @class = iasyncResult_0.AsyncState as Class26;
		try
		{
			try
			{
				httpWebResponse = (HttpWebResponse)@class.method_6().EndGetResponse(iasyncResult_0);
			}
			catch (WebException ex)
			{
				httpWebResponse = ex.Response as HttpWebResponse;
				if (httpWebResponse == null)
				{
					@class.method_9(new Class35((int)ex.Status, ex.Message));
				}
			}
			if (httpWebResponse != null)
			{
				@class.method_9(method_6(httpWebResponse.GetResponseStream(), httpWebResponse.ContentLength));
			}
		}
		finally
		{
			httpWebResponse?.Close();
		}
	}

	private void method_9(IAsyncResult iasyncResult_0)
	{
		method_8(iasyncResult_0);
		method_5(iasyncResult_0);
	}

	private void method_10(IAsyncResult iasyncResult_0)
	{
		method_8(iasyncResult_0);
		Class27 @class = iasyncResult_0.AsyncState as Class27;
		if (@class.method_8() is Class45 class2)
		{
			GClass2 gClass = new GClass2(class2.method_3(), class2.method_4(), class2.method_2(), class2.method_8());
			gClass.Description = class2.method_7();
			@class.method_10().Add(gClass);
			Class40 class3 = new Class40(@class.method_10().Count, this);
			byte[] byte_;
			WebRequest webRequest = class3.vmethod_0(out byte_);
			if (byte_.Length > 0)
			{
				webRequest.ContentLength = byte_.Length;
				webRequest.GetRequestStream().Write(byte_, 0, byte_.Length);
			}
			@class.method_7(webRequest);
			webRequest.BeginGetResponse(method_10, @class);
		}
		else
		{
			method_5(iasyncResult_0);
		}
	}

	private void method_11(IAsyncResult iasyncResult_0)
	{
		method_8(iasyncResult_0);
		method_5(iasyncResult_0);
	}

	private void method_12(IAsyncResult iasyncResult_0)
	{
		method_8(iasyncResult_0);
		Class27 @class = iasyncResult_0.AsyncState as Class27;
		if (@class.method_8() is Class45 class2)
		{
			GClass2 gClass = new GClass2(@class.method_11().method_0(), class2.method_4(), @class.method_11().method_4(), class2.method_8());
			gClass.Description = @class.method_11().Description;
			@class.method_10().Add(gClass);
		}
		method_5(iasyncResult_0);
	}

	internal void method_13(GDelegate0 gdelegate0_1)
	{
		gdelegate0_0 = gdelegate0_1;
		byte[] byte_;
		WebRequest webRequest = new Class36(string_0, endPoint_0).vmethod_0(out byte_);
		if (byte_.Length > 0)
		{
			GClass3.smethod_4("Error: Services Message contained a body");
		}
		webRequest.BeginGetResponse(method_14, webRequest);
	}

	private void method_14(IAsyncResult iasyncResult_0)
	{
		HttpWebResponse httpWebResponse = null;
		try
		{
			int num = 0;
			int num2 = 0;
			byte[] array = new byte[10240];
			StringBuilder stringBuilder = new StringBuilder();
			XmlDocument xmlDocument = new XmlDocument();
			HttpWebRequest httpWebRequest = iasyncResult_0.AsyncState as HttpWebRequest;
			httpWebResponse = httpWebRequest.EndGetResponse(iasyncResult_0) as HttpWebResponse;
			Stream responseStream = httpWebResponse.GetResponseStream();
			if (httpWebResponse.StatusCode != HttpStatusCode.OK)
			{
				GClass3.smethod_4("{0}: Couldn't get services list: {1}", method_0(), httpWebResponse.StatusCode);
				return;
			}
			while (true)
			{
				num2 = responseStream.Read(array, 0, array.Length);
				stringBuilder.Append(Encoding.UTF8.GetString(array, 0, num2));
				try
				{
					xmlDocument.LoadXml(stringBuilder.ToString());
					httpWebResponse.Close();
				}
				catch (XmlException)
				{
					if (num++ > 50)
					{
						httpWebResponse.Close();
						return;
					}
					GClass3.smethod_4("{0}: Couldn't parse services list", method_0());
					Thread.Sleep(10);
					continue;
				}
				break;
			}
			GClass3.smethod_4("{0}: Parsed services list", method_0());
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
			xmlNamespaceManager.AddNamespace("ns", "urn:schemas-upnp-org:device-1-0");
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes("//*/ns:serviceList", xmlNamespaceManager);
			foreach (XmlNode item in xmlNodeList)
			{
				foreach (XmlNode childNode in item.ChildNodes)
				{
					string innerText = childNode["serviceType"]!.InnerText;
					GClass3.smethod_4("{0}: Found service: {1}", method_0(), innerText);
					if (!innerText.Equals(string_2, StringComparison.OrdinalIgnoreCase))
					{
						continue;
					}
					string_1 = childNode["controlURL"]!.InnerText;
					GClass3.smethod_4("{0}: Found upnp service at: {1}", method_0(), string_1);
					try
					{
						Uri uri = new Uri(string_1);
						if (uri.IsAbsoluteUri)
						{
							EndPoint endPoint = endPoint_0;
							endPoint_0 = new IPEndPoint(IPAddress.Parse(uri.Host), uri.Port);
							GClass3.smethod_4("{0}: Absolute URI detected. Host address is now: {1}", endPoint, method_0());
							string_1 = string_1.Substring(uri.GetLeftPart(UriPartial.Authority).Length);
							GClass3.smethod_4("{0}: New control url: {1}", method_0(), string_1);
						}
					}
					catch
					{
						GClass3.smethod_4("{0}: Assuming control Uri is relative: {1}", method_0(), string_1);
					}
					GClass3.smethod_4("{0}: Handshake Complete", method_0());
					gdelegate0_0(this);
					return;
				}
			}
		}
		catch (WebException ex2)
		{
			GClass3.smethod_4("{0}: Device denied the connection attempt: {1}", method_0(), ex2);
		}
		finally
		{
			httpWebResponse?.Close();
		}
	}

	public override string ToString()
	{
		return string.Format("UpnpNatDevice - EndPoint: {0}, External IP: {1}, Control Url: {2}, Service Description Url: {3}, Service Type: {4}, Last Seen: {5}", endPoint_0, "Manually Check", string_1, string_0, string_2, imethod_15());
	}
}
