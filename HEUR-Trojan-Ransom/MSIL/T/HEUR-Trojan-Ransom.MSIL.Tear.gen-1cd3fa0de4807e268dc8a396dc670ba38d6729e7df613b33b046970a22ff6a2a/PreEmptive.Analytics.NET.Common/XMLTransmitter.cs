using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.InteropServices;
using PreEmptive.Analytics.Common;
using PreEmptive.Analytics.Common.Utilities;

namespace PreEmptive.Analytics.NET.Common;

public class XMLTransmitter : IXMLTransmitter
{
	internal class Class7 : WebClient
	{
		protected override WebRequest GetWebRequest(Uri address)
		{
			int num = 18874;
			int num2 = num;
			num = 18874;
			switch (num2 == num)
			{
			default:
			{
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				HttpWebRequest httpWebRequest = (HttpWebRequest)base.GetWebRequest(address);
				httpWebRequest.AllowAutoRedirect = false;
				return httpWebRequest;
			}
			}
		}

		protected override WebResponse GetWebResponse(WebRequest request)
		{
			int num = 7;
			int statusCode = default(int);
			while (true)
			{
				WebResponse webResponse = base.GetWebResponse(request);
				int num2 = 3;
				int num3 = num2;
				while (true)
				{
					int num4;
					switch (num3)
					{
					case 5:
					{
						if (1 == 0)
						{
						}
						HttpWebResponse httpWebResponse = webResponse as HttpWebResponse;
						statusCode = (int)httpWebResponse.StatusCode;
						num2 = 1;
						num3 = num2;
						continue;
					}
					case 4:
						num2 = 0;
						num3 = num2;
						continue;
					case 3:
						if (webResponse is HttpWebResponse)
						{
							num2 = 5;
							num3 = num2;
							continue;
						}
						goto IL_00b6;
					case 1:
						if (statusCode >= 200)
						{
							num2 = 4;
							num3 = num2;
							continue;
						}
						goto case 2;
					case 0:
						if (statusCode > 299)
						{
							num2 = 2;
							num3 = num2;
							continue;
						}
						goto IL_00b6;
					case 2:
						{
							throw new WebException("튔횷튻껂닇뛄닗뺞닠뛓닁껞刽嘸刡帻割嘄刷渍爛瘓爄縛爖", WebExceptionStatus.ConnectFailure);
						}
						IL_00b6:
						num2 = -10144;
						num4 = num2;
						num2 = -10144;
						switch (num4 == num2)
						{
						case false:
						case true:
							break;
						default:
							if (0 == 0)
							{
							}
							return webResponse;
						}
						break;
					}
					break;
				}
			}
		}
	}

	private string string_0 = "";

	private ILogger ilogger_0;

	public XMLTransmitter(Configuration config, [Optional] ILogger logger)
	{
		string_0 = config.GetFullEndpointURI();
		ilogger_0 = logger ?? new BlankLogger();
	}

	public bool Post(IEnumerable<KeyValuePair<string, string>> headers, string data)
	{
		int num = 14;
		switch (0)
		{
		default:
		{
			bool flag = false;
			Class7 @class = new Class7();
			try
			{
				@class.Headers.Add(HttpRequestHeader.ContentType, "껆닓뛊닊뺝닎뛟닂");
				IEnumerator<KeyValuePair<string, string>> enumerator = headers.GetEnumerator();
				try
				{
					int num2 = 3;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num2 = 1;
								num3 = num2;
								continue;
							}
							KeyValuePair<string, string> current = enumerator.Current;
							@class.Headers.Add(current.Key, current.Value);
							num2 = 2;
							num3 = num2;
							continue;
						}
						default:
							num2 = 4;
							num3 = num2;
							continue;
						case 1:
							num2 = 0;
							num3 = num2;
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				finally
				{
					int num2 = 2;
					int num3 = num2;
					while (true)
					{
						switch (num3)
						{
						default:
							if (enumerator != null)
							{
								num2 = 0;
								num3 = num2;
								continue;
							}
							break;
						case 0:
							enumerator.Dispose();
							num2 = 1;
							num3 = num2;
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				try
				{
					@class.UploadString(string_0, data);
					return true;
				}
				catch (Exception exception_)
				{
					ilogger_0.LogException(exception_, "껳님뚒닛뻊닕뛗닞긦刿嘽到干刹嘱刍渇爄瘗爚繒爒瘇爜渻券嘵剾带判嘳勀껁닛뛛닍뻁닟뛝닀껲특횴틾\udebf튳횡튝\uee93\uf291\uf697\uf28d");
					return false;
				}
			}
			finally
			{
				int num2 = 2;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
					{
						if (@class == null)
						{
							break;
						}
						num2 = 12858;
						int num4 = num2;
						num2 = 12858;
						switch (num4 == num2)
						{
						default:
							if (0 == 0)
							{
							}
							num2 = 0;
							num3 = num2;
							continue;
						case false:
						case true:
							break;
						}
						break;
					}
					case 0:
						if (1 == 0)
						{
						}
						((IDisposable)@class).Dispose();
						num2 = 1;
						num3 = num2;
						continue;
					case 1:
						break;
					}
					break;
				}
			}
		}
		}
	}
}
