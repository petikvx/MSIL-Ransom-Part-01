using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class OfferSession
{
	private readonly TradeOfferWebAPI tradeOfferWebAPI_0;

	private readonly SteamWeb steamWeb_0;

	[CompilerGenerated]
	private JsonSerializerSettings jsonSerializerSettings_0;

	[SpecialName]
	[CompilerGenerated]
	internal JsonSerializerSettings method_0()
	{
		return jsonSerializerSettings_0;
	}

	[SpecialName]
	[CompilerGenerated]
	internal void method_1(JsonSerializerSettings value)
	{
		jsonSerializerSettings_0 = value;
	}

	public OfferSession(TradeOfferWebAPI webApi, SteamWeb steamWeb)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		tradeOfferWebAPI_0 = webApi;
		steamWeb_0 = steamWeb;
		method_1(new JsonSerializerSettings());
		method_0().set_PreserveReferencesHandling((PreserveReferencesHandling)0);
		method_0().set_Formatting((Formatting)0);
	}

	public TradeOfferAcceptResponse Accept(string tradeOfferId)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", steamWeb_0.SessionId);
		nameValueCollection.Add("serverid", "1");
		nameValueCollection.Add("tradeofferid", tradeOfferId);
		string url = $"https://steamcommunity.com/tradeoffer/{tradeOfferId}/accept";
		string referer = $"https://steamcommunity.com/tradeoffer/{tradeOfferId}/";
		string text = steamWeb_0.Fetch(url, "POST", nameValueCollection, ajax: false, referer, fetchError: true);
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				TradeOfferAcceptResponse tradeOfferAcceptResponse = JsonConvert.DeserializeObject<TradeOfferAcceptResponse>(text);
				if (tradeOfferAcceptResponse != null)
				{
					tradeOfferAcceptResponse.Accepted = string.IsNullOrEmpty(tradeOfferAcceptResponse.TradeError);
					return tradeOfferAcceptResponse;
				}
			}
			catch (JsonException)
			{
				return new TradeOfferAcceptResponse
				{
					TradeError = "Error parsing server response: " + text
				};
			}
		}
		TradeOfferState offerState = tradeOfferWebAPI_0.GetOfferState(tradeOfferId);
		return new TradeOfferAcceptResponse
		{
			Accepted = (offerState == TradeOfferState.TradeOfferStateAccepted)
		};
	}

	public bool Decline(string tradeOfferId)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", steamWeb_0.SessionId);
		nameValueCollection.Add("serverid", "1");
		nameValueCollection.Add("tradeofferid", tradeOfferId);
		string url = $"https://steamcommunity.com/tradeoffer/{tradeOfferId}/decline";
		string referer = $"https://steamcommunity.com/tradeoffer/{tradeOfferId}/";
		string text = steamWeb_0.Fetch(url, "POST", nameValueCollection, ajax: false, referer);
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				NewTradeOfferResponse newTradeOfferResponse = JsonConvert.DeserializeObject<NewTradeOfferResponse>(text);
				if (newTradeOfferResponse.TradeOfferId != null && newTradeOfferResponse.TradeOfferId == tradeOfferId)
				{
					return true;
				}
			}
			catch (JsonException)
			{
			}
		}
		else if (tradeOfferWebAPI_0.GetOfferState(tradeOfferId) == TradeOfferState.TradeOfferStateDeclined)
		{
			return true;
		}
		return false;
	}

	public bool Cancel(string tradeOfferId)
	{
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", steamWeb_0.SessionId);
		nameValueCollection.Add("tradeofferid", tradeOfferId);
		nameValueCollection.Add("serverid", "1");
		string url = $"https://steamcommunity.com/tradeoffer/{tradeOfferId}/cancel";
		string referer = $"https://steamcommunity.com/tradeoffer/{tradeOfferId}/";
		string text = steamWeb_0.Fetch(url, "POST", nameValueCollection, ajax: false, referer);
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				NewTradeOfferResponse newTradeOfferResponse = JsonConvert.DeserializeObject<NewTradeOfferResponse>(text);
				if (newTradeOfferResponse.TradeOfferId != null && newTradeOfferResponse.TradeOfferId == tradeOfferId)
				{
					return true;
				}
			}
			catch (JsonException)
			{
			}
		}
		else if (tradeOfferWebAPI_0.GetOfferState(tradeOfferId) == TradeOfferState.TradeOfferStateCanceled)
		{
			return true;
		}
		return false;
	}

	public bool SendTradeOfferWithToken(string message, string otherSteamId, TradeOffer.TradeStatus status, string token, out string newTradeOfferId)
	{
		if (string.IsNullOrEmpty(token))
		{
			throw new ArgumentNullException("token", "Partner trade offer token is missing");
		}
		OfferAccessToken offerAccessToken = new OfferAccessToken
		{
			TradeOfferAccessToken = token
		};
		NameValueCollection nameValueCollection = new NameValueCollection();
		nameValueCollection.Add("sessionid", steamWeb_0.SessionId);
		nameValueCollection.Add("serverid", "1");
		long num = Convert.ToInt64(otherSteamId) + 61197960265728L;
		string value = "765" + num;
		nameValueCollection.Add("partner", value);
		nameValueCollection.Add("tradeoffermessage", message);
		nameValueCollection.Add("json_tradeoffer", JsonConvert.SerializeObject((object)status, method_0()));
		nameValueCollection.Add("trade_offer_create_params", JsonConvert.SerializeObject((object)offerAccessToken, method_0()));
		string string_ = $"https://steamcommunity.com/tradeoffer/new/?partner={otherSteamId}&token={token}";
		return method_2("https://steamcommunity.com/tradeoffer/new/send", nameValueCollection, string_, null, out newTradeOfferId);
	}

	internal bool method_2(string string_0, NameValueCollection nameValueCollection_0, string string_1, string string_2, out string string_3)
	{
		string_3 = "";
		string text = steamWeb_0.Fetch(string_0, "POST", nameValueCollection_0, ajax: false, string_1);
		if (!string.IsNullOrEmpty(text))
		{
			try
			{
				NewTradeOfferResponse newTradeOfferResponse = JsonConvert.DeserializeObject<NewTradeOfferResponse>(text);
				if (!string.IsNullOrEmpty(newTradeOfferResponse.TradeOfferId))
				{
					string_3 = newTradeOfferResponse.TradeOfferId;
					return true;
				}
			}
			catch (JsonException)
			{
			}
		}
		return false;
	}
}
