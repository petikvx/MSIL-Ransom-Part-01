using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace xbot.Trader.TradeOffers;

public class TradeOffer
{
	public class TradeStatus
	{
		[CompilerGenerated]
		private bool bool_0;

		[CompilerGenerated]
		private int int_0;

		[CompilerGenerated]
		private TradeStatusUser tradeStatusUser_0;

		[CompilerGenerated]
		private TradeStatusUser tradeStatusUser_1;

		[JsonProperty("newversion")]
		public bool NewVersion
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			private set
			{
				bool_0 = value;
			}
		}

		[JsonProperty("version")]
		private int Int32_0
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

		[JsonProperty("me")]
		private TradeStatusUser TradeStatusUser_0
		{
			[CompilerGenerated]
			get
			{
				return tradeStatusUser_0;
			}
			[CompilerGenerated]
			set
			{
				tradeStatusUser_0 = value;
			}
		}

		[JsonProperty("them")]
		private TradeStatusUser TradeStatusUser_1
		{
			[CompilerGenerated]
			get
			{
				return tradeStatusUser_1;
			}
			[CompilerGenerated]
			set
			{
				tradeStatusUser_1 = value;
			}
		}

		public TradeStatus()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
			Int32_0 = 1;
			TradeStatusUser_0 = new TradeStatusUser();
			TradeStatusUser_1 = new TradeStatusUser();
		}

		public TradeStatus(List<TradeStatusUser.TradeAsset> myItems, List<TradeStatusUser.TradeAsset> theirItems)
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
			Int32_0 = 1;
			TradeStatusUser_0 = new TradeStatusUser();
			TradeStatusUser_1 = new TradeStatusUser();
			foreach (TradeStatusUser.TradeAsset myItem in myItems)
			{
				TradeStatusUser_0.method_0(myItem);
			}
			foreach (TradeStatusUser.TradeAsset theirItem in theirItems)
			{
				TradeStatusUser_1.method_0(theirItem);
			}
		}

		private bool method_0(bool bool_1)
		{
			if (bool_1)
			{
				NewVersion = true;
				Int32_0++;
				return true;
			}
			return false;
		}

		public bool AddMyItem(int appId, long contextId, long assetId, long amount = 1L)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateItemAsset(appId, contextId, assetId, amount);
			return method_0(TradeStatusUser_0.method_0(tradeAsset));
		}

		public bool AddTheirItem(int appId, long contextId, long assetId, long amount = 1L)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateItemAsset(appId, contextId, assetId, amount);
			return method_0(TradeStatusUser_1.method_0(tradeAsset));
		}

		public bool AddMyCurrencyItem(int appId, long contextId, long currencyId, long amount)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateCurrencyAsset(appId, contextId, currencyId, amount);
			return method_0(TradeStatusUser_0.method_1(tradeAsset));
		}

		public bool AddTheirCurrencyItem(int appId, long contextId, long currencyId, long amount)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateCurrencyAsset(appId, contextId, currencyId, amount);
			return method_0(TradeStatusUser_1.method_1(tradeAsset));
		}

		public bool RemoveMyItem(int appId, long contextId, long assetId, long amount = 1L)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateItemAsset(appId, contextId, assetId, amount);
			return method_0(TradeStatusUser_0.method_2(tradeAsset));
		}

		public bool RemoveTheirItem(int appId, long contextId, long assetId, long amount = 1L)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateItemAsset(appId, contextId, assetId, amount);
			return method_0(TradeStatusUser_1.method_2(tradeAsset));
		}

		public bool RemoveMyCurrencyItem(int appId, long contextId, long currencyId, long amount)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateCurrencyAsset(appId, contextId, currencyId, amount);
			return method_0(TradeStatusUser_0.method_3(tradeAsset));
		}

		public bool RemoveTheirCurrencyItem(int appId, long contextId, long currencyId, long amount)
		{
			TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
			tradeAsset.CreateCurrencyAsset(appId, contextId, currencyId, amount);
			return method_0(TradeStatusUser_1.method_3(tradeAsset));
		}

		public bool TryGetMyItem(int appId, long contextId, long assetId, long amount, out TradeStatusUser.TradeAsset asset)
		{
			TradeStatusUser.TradeAsset other = new TradeStatusUser.TradeAsset
			{
				AppId = appId,
				Amount = amount,
				AssetId = assetId,
				ContextId = contextId
			};
			asset = new TradeStatusUser.TradeAsset();
			foreach (TradeStatusUser.TradeAsset asset2 in TradeStatusUser_0.Assets)
			{
				if (asset2.Equals(other))
				{
					asset = asset2;
					return true;
				}
			}
			return false;
		}

		public bool TryGetTheirItem(int appId, long contextId, long assetId, long amount, out TradeStatusUser.TradeAsset asset)
		{
			TradeStatusUser.TradeAsset other = new TradeStatusUser.TradeAsset
			{
				AppId = appId,
				Amount = amount,
				AssetId = assetId,
				ContextId = contextId
			};
			asset = new TradeStatusUser.TradeAsset();
			foreach (TradeStatusUser.TradeAsset asset2 in TradeStatusUser_1.Assets)
			{
				if (asset2.Equals(other))
				{
					asset = asset2;
					return true;
				}
			}
			return false;
		}

		public bool TryGetMyCurrencyItem(int appId, long contextId, long currencyId, long amount, out TradeStatusUser.TradeAsset asset)
		{
			TradeStatusUser.TradeAsset other = new TradeStatusUser.TradeAsset
			{
				AppId = appId,
				Amount = amount,
				CurrencyId = currencyId,
				ContextId = contextId
			};
			asset = new TradeStatusUser.TradeAsset();
			foreach (TradeStatusUser.TradeAsset item in TradeStatusUser_0.Currency)
			{
				if (item.Equals(other))
				{
					asset = item;
					return true;
				}
			}
			return false;
		}

		public bool TryGetTheirCurrencyItem(int appId, long contextId, long currencyId, long amount, out TradeStatusUser.TradeAsset asset)
		{
			TradeStatusUser.TradeAsset other = new TradeStatusUser.TradeAsset
			{
				AppId = appId,
				Amount = amount,
				CurrencyId = currencyId,
				ContextId = contextId
			};
			asset = new TradeStatusUser.TradeAsset();
			foreach (TradeStatusUser.TradeAsset item in TradeStatusUser_1.Currency)
			{
				if (item.Equals(other))
				{
					asset = item;
					return true;
				}
			}
			return false;
		}

		public List<TradeStatusUser.TradeAsset> GetMyItems()
		{
			return TradeStatusUser_0.Assets;
		}

		public List<TradeStatusUser.TradeAsset> GetTheirItems()
		{
			return TradeStatusUser_1.Assets;
		}
	}

	public class TradeAssetsConverter : JsonConverter
	{
		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			List<TradeStatusUser.TradeAsset> list = ((Dictionary<TradeStatusUser.TradeAsset, TradeStatusUser.TradeAsset>)value).Select((KeyValuePair<TradeStatusUser.TradeAsset, TradeStatusUser.TradeAsset> x) => x.Value).ToList();
			serializer.Serialize(writer, (object)list);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			return serializer.Deserialize<List<TradeStatusUser.TradeAsset>>(reader).ToDictionary((TradeStatusUser.TradeAsset x) => x, (TradeStatusUser.TradeAsset x) => x);
		}

		public override bool CanConvert(Type objectType)
		{
			if (!(objectType == typeof(Dictionary<TradeStatusUser.TradeAsset, TradeStatusUser.TradeAsset>)))
			{
				return objectType == typeof(List<TradeStatusUser.TradeAsset>);
			}
			return true;
		}

		public TradeAssetsConverter()
		{
			Class24.nhQmSIPz7n4eU();
			((JsonConverter)this)._002Ector();
		}
	}

	public class TradeStatusUser
	{
		public class ValueStringConverter : JsonConverter
		{
			public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
			{
				writer.WriteValue(value.ToString());
				writer.Flush();
			}

			public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
			{
				throw new NotImplementedException();
			}

			public override bool CanConvert(Type objectType)
			{
				return true;
			}

			public ValueStringConverter()
			{
				Class24.nhQmSIPz7n4eU();
				((JsonConverter)this)._002Ector();
			}
		}

		public class TradeAsset : IEquatable<TradeAsset>
		{
			[CompilerGenerated]
			private long long_0;

			[CompilerGenerated]
			private long long_1;

			[CompilerGenerated]
			private long long_2;

			[CompilerGenerated]
			private long long_3;

			[CompilerGenerated]
			private long long_4;

			[JsonProperty("appid")]
			public long AppId
			{
				[CompilerGenerated]
				get
				{
					return long_0;
				}
				[CompilerGenerated]
				set
				{
					long_0 = value;
				}
			}

			[JsonProperty("contextid")]
			public long ContextId
			{
				[CompilerGenerated]
				get
				{
					return long_1;
				}
				[CompilerGenerated]
				set
				{
					long_1 = value;
				}
			}

			[JsonProperty("amount")]
			public long Amount
			{
				[CompilerGenerated]
				get
				{
					return long_2;
				}
				[CompilerGenerated]
				set
				{
					long_2 = value;
				}
			}

			[JsonConverter(typeof(ValueStringConverter))]
			[JsonProperty("assetid")]
			public long AssetId
			{
				[CompilerGenerated]
				get
				{
					return long_3;
				}
				[CompilerGenerated]
				set
				{
					long_3 = value;
				}
			}

			[JsonProperty("currencyid")]
			[JsonConverter(typeof(ValueStringConverter))]
			public long CurrencyId
			{
				[CompilerGenerated]
				get
				{
					return long_4;
				}
				[CompilerGenerated]
				set
				{
					long_4 = value;
				}
			}

			public void CreateItemAsset(long appId, long contextId, long assetId, long amount)
			{
				AppId = appId;
				ContextId = contextId;
				AssetId = assetId;
				Amount = amount;
				CurrencyId = 0L;
			}

			public void CreateCurrencyAsset(long appId, long contextId, long currencyId, long amount)
			{
				AppId = appId;
				ContextId = contextId;
				CurrencyId = currencyId;
				Amount = amount;
				AssetId = 0L;
			}

			public bool ShouldSerializeAssetId()
			{
				return (ulong)AssetId > 0uL;
			}

			public bool ShouldSerializeCurrencyId()
			{
				return (ulong)CurrencyId > 0uL;
			}

			public bool Equals(TradeAsset other)
			{
				if (AppId == other.AppId && ContextId == other.ContextId && CurrencyId == other.CurrencyId && AssetId == other.AssetId && Amount == other.Amount)
				{
					return true;
				}
				return false;
			}

			public TradeAsset()
			{
				Class24.nhQmSIPz7n4eU();
				base._002Ector();
			}
		}

		[CompilerGenerated]
		private List<TradeAsset> list_0;

		[CompilerGenerated]
		private List<TradeAsset> list_1;

		[CompilerGenerated]
		private bool bool_0;

		[JsonProperty("assets")]
		public List<TradeAsset> Assets
		{
			[CompilerGenerated]
			get
			{
				return list_0;
			}
			[CompilerGenerated]
			set
			{
				list_0 = value;
			}
		}

		[JsonProperty("currency")]
		public List<TradeAsset> Currency
		{
			[CompilerGenerated]
			get
			{
				return list_1;
			}
			[CompilerGenerated]
			set
			{
				list_1 = value;
			}
		}

		[JsonProperty("ready")]
		public bool IsReady
		{
			[CompilerGenerated]
			get
			{
				return bool_0;
			}
			[CompilerGenerated]
			set
			{
				bool_0 = value;
			}
		}

		public TradeStatusUser()
		{
			Class24.nhQmSIPz7n4eU();
			base._002Ector();
			Assets = new List<TradeAsset>();
			IsReady = false;
			Currency = new List<TradeAsset>();
		}

		internal bool method_0(TradeAsset tradeAsset_0)
		{
			if (!Assets.Contains(tradeAsset_0))
			{
				Assets.Add(tradeAsset_0);
				return true;
			}
			return false;
		}

		internal bool method_1(TradeAsset tradeAsset_0)
		{
			if (!Currency.Contains(tradeAsset_0))
			{
				Currency.Add(tradeAsset_0);
				return true;
			}
			return false;
		}

		internal bool method_2(TradeAsset tradeAsset_0)
		{
			if (Assets.Contains(tradeAsset_0))
			{
				return Assets.Remove(tradeAsset_0);
			}
			return false;
		}

		internal bool method_3(TradeAsset tradeAsset_0)
		{
			if (Currency.Contains(tradeAsset_0))
			{
				return Currency.Remove(tradeAsset_0);
			}
			return false;
		}

		public bool ContainsItem(TradeAsset asset)
		{
			return Assets.Contains(asset);
		}
	}

	[CompilerGenerated]
	private OfferSession offerSession_0;

	[CompilerGenerated]
	private TradeStatus tradeStatus_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private TradeOfferState tradeOfferState_0;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private string string_1;

	public TradeStatus Items
	{
		[CompilerGenerated]
		get
		{
			return tradeStatus_0;
		}
		[CompilerGenerated]
		set
		{
			tradeStatus_0 = value;
		}
	}

	public string TradeOfferId
	{
		[CompilerGenerated]
		get
		{
			return string_0;
		}
		[CompilerGenerated]
		private set
		{
			string_0 = value;
		}
	}

	public TradeOfferState OfferState
	{
		[CompilerGenerated]
		get
		{
			return tradeOfferState_0;
		}
		[CompilerGenerated]
		private set
		{
			tradeOfferState_0 = value;
		}
	}

	public bool IsOurOffer
	{
		[CompilerGenerated]
		get
		{
			return bool_0;
		}
		[CompilerGenerated]
		private set
		{
			bool_0 = value;
		}
	}

	public int TimeCreated
	{
		[CompilerGenerated]
		get
		{
			return int_0;
		}
		[CompilerGenerated]
		private set
		{
			int_0 = value;
		}
	}

	public int ExpirationTime
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		private set
		{
			int_1 = value;
		}
	}

	public int TimeUpdated
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		private set
		{
			int_2 = value;
		}
	}

	public string Message
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		private set
		{
			string_1 = value;
		}
	}

	public bool IsFirstOffer => TimeCreated == TimeUpdated;

	[SpecialName]
	[CompilerGenerated]
	private OfferSession method_0()
	{
		return offerSession_0;
	}

	[SpecialName]
	[CompilerGenerated]
	private void method_1(OfferSession value)
	{
		offerSession_0 = value;
	}

	public TradeOffer(OfferSession session, Offer offer)
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
		List<TradeStatusUser.TradeAsset> list = new List<TradeStatusUser.TradeAsset>();
		List<TradeStatusUser.TradeAsset> list2 = new List<TradeStatusUser.TradeAsset>();
		List<TradeStatusUser.TradeAsset> list3 = new List<TradeStatusUser.TradeAsset>();
		List<TradeStatusUser.TradeAsset> list4 = new List<TradeStatusUser.TradeAsset>();
		if (offer.ItemsToGive != null)
		{
			foreach (CEconAsset item in offer.ItemsToGive)
			{
				TradeStatusUser.TradeAsset tradeAsset = new TradeStatusUser.TradeAsset();
				tradeAsset.CreateItemAsset(Convert.ToInt64(item.AppId), Convert.ToInt64(item.ContextId), Convert.ToInt64(item.AssetId), Convert.ToInt64(item.Amount));
				if (!item.IsMissing)
				{
					list.Add(tradeAsset);
				}
				else
				{
					list2.Add(tradeAsset);
				}
			}
		}
		if (offer.ItemsToReceive != null)
		{
			foreach (CEconAsset item2 in offer.ItemsToReceive)
			{
				TradeStatusUser.TradeAsset tradeAsset2 = new TradeStatusUser.TradeAsset();
				tradeAsset2.CreateItemAsset(Convert.ToInt64(item2.AppId), Convert.ToInt64(item2.ContextId), Convert.ToInt64(item2.AssetId), Convert.ToInt64(item2.Amount));
				if (!item2.IsMissing)
				{
					list3.Add(tradeAsset2);
				}
				else
				{
					list4.Add(tradeAsset2);
				}
			}
		}
		method_1(session);
		TradeOfferId = offer.TradeOfferId;
		OfferState = offer.TradeOfferState;
		IsOurOffer = offer.IsOurOffer;
		ExpirationTime = offer.ExpirationTime;
		TimeCreated = offer.TimeCreated;
		TimeUpdated = offer.TimeUpdated;
		Message = offer.Message;
		Items = new TradeStatus(list, list3);
	}

	public TradeOfferAcceptResponse Accept()
	{
		if (TradeOfferId == null)
		{
			return new TradeOfferAcceptResponse
			{
				TradeError = "Can't accept a trade without a tradeofferid"
			};
		}
		if (!IsOurOffer && OfferState == TradeOfferState.TradeOfferStateActive)
		{
			return method_0().Accept(TradeOfferId);
		}
		return new TradeOfferAcceptResponse
		{
			TradeError = "Не удалось принять трейд, поскольку он был отменён...\n"
		};
	}

	[Obsolete("Use TradeOfferAcceptResponse Accept()")]
	public bool Accept(out string tradeId)
	{
		tradeId = string.Empty;
		if (TradeOfferId == null)
		{
			throw new ArgumentException("TradeOfferId");
		}
		TradeOfferAcceptResponse tradeOfferAcceptResponse = Accept();
		if (tradeOfferAcceptResponse.Accepted)
		{
			tradeId = tradeOfferAcceptResponse.TradeId;
		}
		return tradeOfferAcceptResponse.Accepted;
	}

	public bool Decline()
	{
		if (TradeOfferId == null)
		{
			throw new ArgumentException("TradeOfferId");
		}
		if (!IsOurOffer && OfferState == TradeOfferState.TradeOfferStateActive)
		{
			return method_0().Decline(TradeOfferId);
		}
		return false;
	}

	public bool Cancel()
	{
		if (TradeOfferId == null)
		{
			throw new ArgumentException("TradeOfferId");
		}
		if (IsOurOffer && OfferState == TradeOfferState.TradeOfferStateActive)
		{
			return method_0().Cancel(TradeOfferId);
		}
		return false;
	}
}
