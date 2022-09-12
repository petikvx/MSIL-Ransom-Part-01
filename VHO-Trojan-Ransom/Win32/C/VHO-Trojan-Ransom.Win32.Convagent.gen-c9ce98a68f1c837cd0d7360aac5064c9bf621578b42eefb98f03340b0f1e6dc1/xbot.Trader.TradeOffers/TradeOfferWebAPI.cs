using System;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class TradeOfferWebAPI
{
	private readonly SteamWeb steamWeb_0;

	private readonly string string_0;

	public TradeOfferWebAPI(string apiKey, SteamWeb steamWeb)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		steamWeb_0 = steamWeb;
		string_0 = apiKey;
		if (apiKey == null)
		{
			throw new ArgumentNullException("apiKey");
		}
	}

	public OfferResponse GetTradeOffer(string tradeofferid)
	{
		string arg = string.Format("?key={0}&tradeofferid={1}&language={2}", string_0, tradeofferid, "en_us");
		string url = string.Format("http://api.steampowered.com/IEconService/{0}/{1}/{2}", "GetTradeOffer", "v1", arg);
		try
		{
			return JsonConvert.DeserializeObject<ApiResponse<OfferResponse>>(steamWeb_0.Fetch(url, "GET", null, ajax: false)).Response;
		}
		catch (Exception)
		{
		}
		return new OfferResponse();
	}

	public TradeOfferState GetOfferState(string tradeofferid)
	{
		OfferResponse tradeOffer = GetTradeOffer(tradeofferid);
		if (tradeOffer != null && tradeOffer.Offer != null)
		{
			return tradeOffer.Offer.TradeOfferState;
		}
		return TradeOfferState.TradeOfferStateUnknown;
	}

	public OffersResponse GetAllTradeOffers(string timeHistoricalCutoff = "1389106496", string language = "en_us")
	{
		return GetTradeOffers(getSentOffers: true, getReceivedOffers: true, getDescriptions: false, activeOnly: true, historicalOnly: false, timeHistoricalCutoff, language);
	}

	public OffersResponse GetActiveTradeOffers(bool getSentOffers, bool getReceivedOffers, bool getDescriptions, string language = "en_us")
	{
		return GetTradeOffers(getSentOffers, getReceivedOffers, getDescriptions, activeOnly: true, historicalOnly: false, "1389106496", language);
	}

	public OffersResponse GetTradeOffers(bool getSentOffers, bool getReceivedOffers, bool getDescriptions, bool activeOnly, bool historicalOnly, string timeHistoricalCutoff = "1389106496", string language = "en_us")
	{
		if (!getSentOffers && !getReceivedOffers)
		{
			throw new ArgumentException("getSentOffers and getReceivedOffers can't be both false");
		}
		string arg = $"?key={string_0}&get_sent_offers={smethod_0(getSentOffers)}&get_received_offers={smethod_0(getReceivedOffers)}&get_descriptions={smethod_0(getDescriptions)}&language={language}&active_only={smethod_0(activeOnly)}&historical_only={smethod_0(historicalOnly)}&time_historical_cutoff={timeHistoricalCutoff}";
		string url = string.Format("http://api.steampowered.com/IEconService/{0}/{1}/{2}", "GetTradeOffers", "v1", arg);
		string text = steamWeb_0.Fetch(url, "GET", null, ajax: false);
		try
		{
			return JsonConvert.DeserializeObject<ApiResponse<OffersResponse>>(text).Response;
		}
		catch (Exception)
		{
		}
		return new OffersResponse();
	}

	private static string smethod_0(bool bool_0)
	{
		if (!bool_0)
		{
			return "0";
		}
		return "1";
	}

	public TradeOffersSummary GetTradeOffersSummary(uint timeLastVisit)
	{
		string arg = $"?key={string_0}&time_last_visit={timeLastVisit}";
		string url = string.Format("http://api.steampowered.com/IEconService/{0}/{1}/{2}", "GetTradeOffersSummary", "v1", arg);
		try
		{
			return JsonConvert.DeserializeObject<ApiResponse<TradeOffersSummary>>(steamWeb_0.Fetch(url, "GET", null, ajax: false)).Response;
		}
		catch (Exception)
		{
		}
		return new TradeOffersSummary();
	}

	private bool method_0(ulong ulong_0)
	{
		string arg = $"?key={string_0}&tradeofferid={ulong_0}";
		string url = string.Format("http://api.steampowered.com/IEconService/{0}/{1}/{2}", "DeclineTradeOffer", "v1", arg);
		dynamic val = JsonConvert.DeserializeObject(steamWeb_0.Fetch(url, "POST", null, ajax: false));
		dynamic val2 = val == null;
		if (!(val2 ? true : false) && !((val2 | (val.success != "1")) ? true : false))
		{
			return true;
		}
		return false;
	}

	private bool method_1(ulong ulong_0)
	{
		string arg = $"?key={string_0}&tradeofferid={ulong_0}";
		string url = string.Format("http://api.steampowered.com/IEconService/{0}/{1}/{2}", "CancelTradeOffer", "v1", arg);
		dynamic val = JsonConvert.DeserializeObject(steamWeb_0.Fetch(url, "POST", null, ajax: false));
		dynamic val2 = val == null;
		if (!(val2 ? true : false) && !((val2 | (val.success != "1")) ? true : false))
		{
			return true;
		}
		return false;
	}
}
