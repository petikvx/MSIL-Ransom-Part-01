using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Caliburn.Micro;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Deserializers;
using RestSharp.Serializers;
using xbot_wpf.Extensions;
using xbot_wpf.Models;
using xbot_wpf.Responses;

namespace xbot_wpf.Services;

public class ApiMarketDota2Net : GInterface2
{
	private readonly ILog ilog_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private SettingDota2 settingDota2_0;

	public int Timeout
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		set
		{
			int_0 = value;
		}
	}

	public string ApiKey
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		set
		{
			string_0 = value;
		}
	}

	public SettingDota2 setting
	{
		[CompilerGenerated]
		get
		{
			return settingDota2_0;
		}
		[CompilerGenerated]
		set
		{
			settingDota2_0 = value;
		}
	}

	public ApiMarketDota2Net(ILog logger, string apiKey = null, int timeout = 0)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		ilog_0 = logger;
		ApiKey = apiKey;
		Timeout = timeout;
		ServicePointManager.ServerCertificateValidationCallback = (object senderX, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors) => true;
	}

	private RestClient method_0()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		RestClient val = new RestClient("https://market.dota2.net/api");
		val.AddHandler("application/json", (IDeserializer)(object)RestSharpJsonNetSerializer.Default);
		return val;
	}

	private async Task method_1()
	{
		if (Timeout <= 0)
		{
			await Task.CompletedTask;
		}
		else
		{
			await Task.Delay(Timeout);
		}
	}

	public async Task<InventoryItemsResponse> InventoryItems()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("InventoryItems", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<InventoryItemsResponse> obj = Execute<InventoryItemsResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<DeleteOrdersResponse> DeleteOrders()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("DeleteOrders", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<DeleteOrdersResponse> obj = Execute<DeleteOrdersResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<BuyOffersResponse> BuyOffers(long classid, long instanceid)
	{
		_003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass45_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("BuyOffers/{classid}_{instanceid}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<BuyOffersResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<BuyOffersResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<ItemInfoResponse> ItemInfo(long classid, long instanceid)
	{
		_003C_003Ec__DisplayClass46_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass46_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("ItemInfo/{classid}_{instanceid}/{lang}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			val2.AddUrlSegment("lang", "ru");
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<ItemInfoResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<ItemInfoResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<GetOrdersResponse> GetOrders()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("GetOrders/{page}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("page", "1000");
			method_2(val2);
			IRestResponse<GetOrdersResponse> obj = Execute<GetOrdersResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<InsertOrderResponse> InsertOrder(long classid, long instanceid, float price)
	{
		_003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass48_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		CS_0024_003C_003E8__locals0.price = price;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("InsertOrder/{classid}/{instanceid}/{price}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			val2.AddUrlSegment("price", CS_0024_003C_003E8__locals0.price.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<InsertOrderResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<InsertOrderResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<UpdateOrderResponse> UpdateOrder(long classid, long instanceid, float price)
	{
		_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass49_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		CS_0024_003C_003E8__locals0.price = price;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("UpdateOrder/{classid}/{instanceid}/{price}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			val2.AddUrlSegment("price", CS_0024_003C_003E8__locals0.price.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<UpdateOrderResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<UpdateOrderResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<ItemHistoryResponse> ItemHistory(long classid, long instanceid)
	{
		_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass50_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("ItemHistory/{classid}_{instanceid}", (Method)0);
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<ItemHistoryResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<ItemHistoryResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<ProcessOrderResponse> ProcessOrder(float price, long classid, long instanceid)
	{
		_003C_003Ec__DisplayClass51_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass51_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		CS_0024_003C_003E8__locals0.price = price;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("ProcessOrder/{classid}/{instanceid}/{price}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			val2.AddUrlSegment("price", CS_0024_003C_003E8__locals0.price.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<ProcessOrderResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<ProcessOrderResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<BestSellOfferResponse> BestSellOffer(long classid, long instanceid)
	{
		_003C_003Ec__DisplayClass52_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass52_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("BestSellOffer/{classid}_{instanceid}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<BestSellOfferResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<BestSellOfferResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<BestBuyOfferResponse> BestBuyOffer(long classid, long instanceidy)
	{
		_003C_003Ec__DisplayClass53_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass53_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceidy = instanceidy;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("BestBuyOffer/{classid}_{instanceid}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceidy.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<BestBuyOfferResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<BestBuyOfferResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<GetInvResponse> GetInv()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("GetInv", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<GetInvResponse> obj = Execute<GetInvResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<GetMySellOffersResponse> GetMySellOffers()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("GetMySellOffers", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<GetMySellOffersResponse> obj = Execute<GetMySellOffersResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<MassInfoResponse> MassInfo(long SELL, long BUY, long HISTORY, long INFO, string list)
	{
		_003C_003Ec__DisplayClass56_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass56_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.SELL = SELL;
		CS_0024_003C_003E8__locals0.BUY = BUY;
		CS_0024_003C_003E8__locals0.HISTORY = HISTORY;
		CS_0024_003C_003E8__locals0.INFO = INFO;
		CS_0024_003C_003E8__locals0.list = list;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("MassInfo/{SELL}/{BUY}/{HISTORY}/{INFO}", (Method)1);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("SELL", CS_0024_003C_003E8__locals0.SELL.ToString());
			val2.AddUrlSegment("BUY", CS_0024_003C_003E8__locals0.BUY.ToString());
			val2.AddUrlSegment("HISTORY", CS_0024_003C_003E8__locals0.HISTORY.ToString());
			val2.AddUrlSegment("INFO", CS_0024_003C_003E8__locals0.INFO.ToString());
			val2.AddParameter("list", (object)CS_0024_003C_003E8__locals0.list);
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<MassInfoResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<MassInfoResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<MassInfoStringResponse> MassInfoString(long SELL, long BUY, long HISTORY, long INFO, string list)
	{
		_003C_003Ec__DisplayClass57_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass57_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.SELL = SELL;
		CS_0024_003C_003E8__locals0.BUY = BUY;
		CS_0024_003C_003E8__locals0.HISTORY = HISTORY;
		CS_0024_003C_003E8__locals0.INFO = INFO;
		CS_0024_003C_003E8__locals0.list = list;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("MassInfo/{SELL}/{BUY}/{HISTORY}/{INFO}", (Method)1);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("SELL", CS_0024_003C_003E8__locals0.SELL.ToString());
			val2.AddUrlSegment("BUY", CS_0024_003C_003E8__locals0.BUY.ToString());
			val2.AddUrlSegment("HISTORY", CS_0024_003C_003E8__locals0.HISTORY.ToString());
			val2.AddUrlSegment("INFO", CS_0024_003C_003E8__locals0.INFO.ToString());
			val2.AddParameter("list", (object)CS_0024_003C_003E8__locals0.list);
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<MassInfoStringResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<MassInfoStringResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<MassSetPriceByIdResponse> MassSetPriceById(List<long> pricesForChange, List<long> uiIdForChange)
	{
		_003C_003Ec__DisplayClass58_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass58_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.uiIdForChange = uiIdForChange;
		CS_0024_003C_003E8__locals0.pricesForChange = pricesForChange;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("MassSetPriceById", (Method)1);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			for (int i = 0; i < CS_0024_003C_003E8__locals0.pricesForChange.Count; i++)
			{
				val2.AddParameter("list[" + CS_0024_003C_003E8__locals0.uiIdForChange[i] + "]", (object)CS_0024_003C_003E8__locals0.pricesForChange[i]);
			}
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<MassSetPriceByIdResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<MassSetPriceByIdResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<MassSetPriceResponse> MassSetPrice(string name, float price)
	{
		_003C_003Ec__DisplayClass59_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass59_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.name = name;
		CS_0024_003C_003E8__locals0.price = price;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("MassSetPrice/{name}/{price}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("name", CS_0024_003C_003E8__locals0.name);
			val2.AddUrlSegment("price", CS_0024_003C_003E8__locals0.price.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<MassSetPriceResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<MassSetPriceResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<OrderLogResponse> GetOrdersLog()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("GetOrdersLog", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<OrderLogResponse> obj = Execute<OrderLogResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<SellResponse> SellItem(long classid, long instanceid, float price)
	{
		_003C_003Ec__DisplayClass61_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass61_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.classid = classid;
		CS_0024_003C_003E8__locals0.instanceid = instanceid;
		CS_0024_003C_003E8__locals0.price = price;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("SetPrice/new_{classid}_{instanceid}/{price}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("status", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("classid", CS_0024_003C_003E8__locals0.classid.ToString());
			val2.AddUrlSegment("instanceid", CS_0024_003C_003E8__locals0.instanceid.ToString());
			val2.AddUrlSegment("price", CS_0024_003C_003E8__locals0.price.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<SellResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<SellResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<SetPriceResponse> SetPrice(long ui_id, long price)
	{
		_003C_003Ec__DisplayClass62_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass62_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.ui_id = ui_id;
		CS_0024_003C_003E8__locals0.price = price;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("SetPrice/{ui_id}/{price}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("ui_id", CS_0024_003C_003E8__locals0.ui_id.ToString());
			val2.AddUrlSegment("price", CS_0024_003C_003E8__locals0.price.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<SetPriceResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<SetPriceResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<List<TradesResponse>> Trades()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("Trades", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<List<TradesResponse>> obj = Execute<List<TradesResponse>>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<GetDiscountsResponse> GetDiscounts()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("GetDiscounts", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<GetDiscountsResponse> obj = Execute<GetDiscountsResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<OperationHistoryResponse> OperationHistory(long start_time, long end_time)
	{
		_003C_003Ec__DisplayClass65_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass65_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.start_time = start_time;
		CS_0024_003C_003E8__locals0.end_time = end_time;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("OperationHistory/{start_time}/{end_time}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("start_time", CS_0024_003C_003E8__locals0.start_time.ToString());
			val2.AddUrlSegment("end_time", CS_0024_003C_003E8__locals0.end_time.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<OperationHistoryResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<OperationHistoryResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<UpdateInventoryResponse> UpdateInventory()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("UpdateInventory", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<UpdateInventoryResponse> obj = Execute<UpdateInventoryResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<PingPongResponse> PingPong()
	{
		await method_1();
		return await Task.Run(delegate
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Expected O, but got Unknown
			RestClient client = method_0();
			RestRequest val = new RestRequest("PingPong", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			method_2(val2);
			IRestResponse<PingPongResponse> obj = Execute<PingPongResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	public async Task<ItemRequestOutResponse> ItemRequest(string type, long botid)
	{
		_003C_003Ec__DisplayClass68_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass68_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.type = type;
		CS_0024_003C_003E8__locals0.botid = botid;
		await method_1();
		return await Task.Run(delegate
		{
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Expected O, but got Unknown
			RestClient client = CS_0024_003C_003E8__locals0._003C_003E4__this.method_0();
			RestRequest val = new RestRequest("ItemRequest/{type}/{botid}", (Method)0);
			val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
			val.set_RequestFormat((DataFormat)0);
			RestRequest val2 = val;
			val2.AddUrlSegment("type", CS_0024_003C_003E8__locals0.type.ToString());
			val2.AddUrlSegment("botid", CS_0024_003C_003E8__locals0.botid.ToString());
			CS_0024_003C_003E8__locals0._003C_003E4__this.method_2(val2);
			IRestResponse<ItemRequestOutResponse> obj = CS_0024_003C_003E8__locals0._003C_003E4__this.Execute<ItemRequestOutResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
			smethod_0((IRestResponse)(object)obj);
			return obj.get_Data();
		});
	}

	private void method_2(RestRequest restRequest_0)
	{
		restRequest_0.AddQueryParameter("key", ApiKey);
	}

	private static void smethod_0(IRestResponse irestResponse_0)
	{
		if (irestResponse_0.get_ErrorException() != null)
		{
			throw new ApplicationException("Error retrieving response.  Check inner details for more info.", irestResponse_0.get_ErrorException());
		}
	}

	protected virtual IRestResponse<T> Execute<T>(IRestClient client, IRestRequest request) where T : new()
	{
		IRestResponse<T> val = null;
		Stopwatch stopwatch = new Stopwatch();
		try
		{
			stopwatch.Start();
			val = client.Execute<T>(request);
			stopwatch.Stop();
		}
		finally
		{
			method_3(client, request, (IRestResponse)(object)val, stopwatch.ElapsedMilliseconds);
		}
		return val;
	}

	private void method_3(IRestClient irestClient_0, IRestRequest irestRequest_0, IRestResponse irestResponse_0, long long_0)
	{
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		string resource = irestRequest_0.get_Resource();
		var parameters = irestRequest_0.get_Parameters().Select(delegate(Parameter parameter)
		{
			//IL_000d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0012: Unknown result type (might be due to invalid IL or missing references)
			string name = parameter.get_Name();
			object value = parameter.get_Value();
			ParameterType type = parameter.get_Type();
			return new
			{
				name = name,
				value = value,
				type = ((object)(ParameterType)(ref type)).ToString()
			};
		});
		Method method = irestRequest_0.get_Method();
		var anon = new
		{
			resource = resource,
			parameters = parameters,
			method = ((object)(Method)(ref method)).ToString(),
			uri = irestClient_0.BuildUri(irestRequest_0)
		};
		var anon2 = new
		{
			statusCode = irestResponse_0.get_StatusCode(),
			content = Regex.Unescape(irestResponse_0.get_Content()),
			headers = irestResponse_0.get_Headers(),
			responseUri = irestResponse_0.get_ResponseUri(),
			errorMessage = irestResponse_0.get_ErrorMessage()
		};
		if (setting.LoggerFlag)
		{
			ilog_0.Info("Request completed in {0} ms, {3} Request: {1}, {3} Response: {2}", new object[4]
			{
				long_0,
				JsonConvert.SerializeObject((object)anon),
				JsonConvert.SerializeObject((object)anon2),
				Environment.NewLine
			});
		}
	}

	[CompilerGenerated]
	private InventoryItemsResponse method_4()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("InventoryItems", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<InventoryItemsResponse> obj = Execute<InventoryItemsResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private DeleteOrdersResponse method_5()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("DeleteOrders", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<DeleteOrdersResponse> obj = Execute<DeleteOrdersResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private GetOrdersResponse method_6()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("GetOrders/{page}", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		val2.AddUrlSegment("page", "1000");
		method_2(val2);
		IRestResponse<GetOrdersResponse> obj = Execute<GetOrdersResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private GetInvResponse method_7()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("GetInv", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<GetInvResponse> obj = Execute<GetInvResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private GetMySellOffersResponse method_8()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("GetMySellOffers", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<GetMySellOffersResponse> obj = Execute<GetMySellOffersResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private OrderLogResponse method_9()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("GetOrdersLog", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<OrderLogResponse> obj = Execute<OrderLogResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private List<TradesResponse> method_10()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("Trades", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<List<TradesResponse>> obj = Execute<List<TradesResponse>>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private GetDiscountsResponse method_11()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("GetDiscounts", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<GetDiscountsResponse> obj = Execute<GetDiscountsResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private UpdateInventoryResponse method_12()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("UpdateInventory", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<UpdateInventoryResponse> obj = Execute<UpdateInventoryResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}

	[CompilerGenerated]
	private PingPongResponse method_13()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		RestClient client = method_0();
		RestRequest val = new RestRequest("PingPong", (Method)0);
		val.set_JsonSerializer((ISerializer)(object)new RestSharpJsonNetSerializer());
		val.set_RequestFormat((DataFormat)0);
		RestRequest val2 = val;
		method_2(val2);
		IRestResponse<PingPongResponse> obj = Execute<PingPongResponse>((IRestClient)(object)client, (IRestRequest)(object)val2);
		smethod_0((IRestResponse)(object)obj);
		return obj.get_Data();
	}
}
