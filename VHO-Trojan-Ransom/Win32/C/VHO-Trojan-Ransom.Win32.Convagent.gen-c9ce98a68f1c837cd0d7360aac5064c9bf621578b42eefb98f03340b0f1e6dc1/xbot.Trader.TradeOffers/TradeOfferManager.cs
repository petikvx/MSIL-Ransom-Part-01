using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;

namespace xbot.Trader.TradeOffers;

public class TradeOfferManager
{
	public delegate void TradeOfferUpdatedHandler(TradeOffer offer);

	private readonly Dictionary<string, TradeOfferState> dictionary_0;

	private readonly OfferSession offerSession_0;

	private readonly TradeOfferWebAPI tradeOfferWebAPI_0;

	private readonly Queue<Offer> queue_0;

	[CompilerGenerated]
	private DateTime dateTime_0;

	[CompilerGenerated]
	private TradeOfferUpdatedHandler tradeOfferUpdatedHandler_0;

	public DateTime LastTimeCheckedOffers
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
		[CompilerGenerated]
		private set
		{
			dateTime_0 = value;
		}
	}

	public event TradeOfferUpdatedHandler OnTradeOfferUpdated
	{
		[CompilerGenerated]
		add
		{
			TradeOfferUpdatedHandler tradeOfferUpdatedHandler = tradeOfferUpdatedHandler_0;
			TradeOfferUpdatedHandler tradeOfferUpdatedHandler2;
			do
			{
				tradeOfferUpdatedHandler2 = tradeOfferUpdatedHandler;
				TradeOfferUpdatedHandler value2 = (TradeOfferUpdatedHandler)Delegate.Combine(tradeOfferUpdatedHandler2, value);
				tradeOfferUpdatedHandler = Interlocked.CompareExchange(ref tradeOfferUpdatedHandler_0, value2, tradeOfferUpdatedHandler2);
			}
			while ((object)tradeOfferUpdatedHandler != tradeOfferUpdatedHandler2);
		}
		[CompilerGenerated]
		remove
		{
			TradeOfferUpdatedHandler tradeOfferUpdatedHandler = tradeOfferUpdatedHandler_0;
			TradeOfferUpdatedHandler tradeOfferUpdatedHandler2;
			do
			{
				tradeOfferUpdatedHandler2 = tradeOfferUpdatedHandler;
				TradeOfferUpdatedHandler value2 = (TradeOfferUpdatedHandler)Delegate.Remove(tradeOfferUpdatedHandler2, value);
				tradeOfferUpdatedHandler = Interlocked.CompareExchange(ref tradeOfferUpdatedHandler_0, value2, tradeOfferUpdatedHandler2);
			}
			while ((object)tradeOfferUpdatedHandler != tradeOfferUpdatedHandler2);
		}
	}

	public TradeOfferManager(string apiKey, SteamWeb steamWeb)
	{
		Class24.nhQmSIPz7n4eU();
		dictionary_0 = new Dictionary<string, TradeOfferState>();
		base._002Ector();
		if (apiKey == null)
		{
			throw new ArgumentNullException("apiKey");
		}
		LastTimeCheckedOffers = DateTime.MinValue;
		tradeOfferWebAPI_0 = new TradeOfferWebAPI(apiKey, steamWeb);
		offerSession_0 = new OfferSession(tradeOfferWebAPI_0, steamWeb);
		queue_0 = new Queue<Offer>();
	}

	public void EnqueueUpdatedOffers()
	{
		DateTime now = DateTime.Now;
		OffersResponse offersResponse_ = ((LastTimeCheckedOffers == DateTime.MinValue) ? tradeOfferWebAPI_0.GetAllTradeOffers() : tradeOfferWebAPI_0.GetAllTradeOffers(method_4(LastTimeCheckedOffers).ToString()));
		method_0(offersResponse_);
		LastTimeCheckedOffers = now - TimeSpan.FromMinutes(5.0);
	}

	private void method_0(OffersResponse offersResponse_0)
	{
		if (offersResponse_0 == null || offersResponse_0.AllOffers == null)
		{
			return;
		}
		lock (queue_0)
		{
			foreach (Offer allOffer in offersResponse_0.AllOffers)
			{
				queue_0.Enqueue(allOffer);
			}
		}
	}

	public bool HandleNextPendingTradeOfferUpdate()
	{
		Offer offer_;
		lock (queue_0)
		{
			if (!queue_0.Any())
			{
				return false;
			}
			offer_ = queue_0.Dequeue();
		}
		return method_1(offer_);
	}

	private bool method_1(Offer offer_0)
	{
		if (dictionary_0.ContainsKey(offer_0.TradeOfferId) && dictionary_0[offer_0.TradeOfferId] == offer_0.TradeOfferState)
		{
			return false;
		}
		if (method_2(offer_0))
		{
			method_3(offer_0);
		}
		else
		{
			OfferResponse tradeOffer = tradeOfferWebAPI_0.GetTradeOffer(offer_0.TradeOfferId);
			if (!method_2(tradeOffer.Offer))
			{
				return false;
			}
			method_3(tradeOffer.Offer);
		}
		return true;
	}

	private bool method_2(Offer offer_0)
	{
		return (offer_0.ItemsToGive != null && offer_0.ItemsToGive.Count != 0) | (offer_0.ItemsToReceive != null && offer_0.ItemsToReceive.Count != 0);
	}

	private void method_3(Offer offer_0)
	{
		dictionary_0[offer_0.TradeOfferId] = offer_0.TradeOfferState;
		tradeOfferUpdatedHandler_0(new TradeOffer(offerSession_0, offer_0));
	}

	private uint method_4(DateTime dateTime_1)
	{
		DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
		return (uint)(dateTime_1.ToUniversalTime() - dateTime).TotalSeconds;
	}

	public bool TryGetOffer(string offerId, out TradeOffer tradeOffer)
	{
		tradeOffer = null;
		OfferResponse tradeOffer2 = tradeOfferWebAPI_0.GetTradeOffer(offerId);
		if (tradeOffer2 != null && method_2(tradeOffer2.Offer))
		{
			tradeOffer = new TradeOffer(offerSession_0, tradeOffer2.Offer);
			return true;
		}
		return false;
	}
}
