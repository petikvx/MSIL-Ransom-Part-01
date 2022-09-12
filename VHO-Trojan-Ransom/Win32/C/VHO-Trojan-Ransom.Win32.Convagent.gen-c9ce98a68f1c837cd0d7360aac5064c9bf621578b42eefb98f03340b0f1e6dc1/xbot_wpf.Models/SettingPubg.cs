using System;
using System.Runtime.CompilerServices;
using ServiceStack.DataAnnotations;

namespace xbot_wpf.Models;

public class SettingPubg : IEntity<int>, IEntity
{
	[CompilerGenerated]
	private int int_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private string string_2;

	[CompilerGenerated]
	private string string_3;

	[CompilerGenerated]
	private string string_4;

	[CompilerGenerated]
	private float float_0;

	[CompilerGenerated]
	private float float_1;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private bool bool_1;

	[CompilerGenerated]
	private int int_1;

	[CompilerGenerated]
	private int int_2;

	[CompilerGenerated]
	private int int_3;

	[CompilerGenerated]
	private int int_4;

	[CompilerGenerated]
	private int int_5;

	[CompilerGenerated]
	private float float_2;

	[CompilerGenerated]
	private float float_3;

	[CompilerGenerated]
	private float float_4;

	[CompilerGenerated]
	private float float_5;

	[CompilerGenerated]
	private float float_6;

	[CompilerGenerated]
	private float float_7;

	[CompilerGenerated]
	private DateTime dateTime_0;

	[CompilerGenerated]
	private DateTime dateTime_1;

	[CompilerGenerated]
	private DateTime dateTime_2;

	[CompilerGenerated]
	private DateTime dateTime_3;

	[CompilerGenerated]
	private DateTime dateTime_4;

	[CompilerGenerated]
	private int int_6;

	[CompilerGenerated]
	private float float_8;

	[CompilerGenerated]
	private int int_7;

	[CompilerGenerated]
	private int int_8;

	[CompilerGenerated]
	private int int_9;

	[CompilerGenerated]
	private int int_10;

	[CompilerGenerated]
	private int int_11;

	[CompilerGenerated]
	private int int_12;

	[CompilerGenerated]
	private int int_13;

	[CompilerGenerated]
	private int int_14;

	[CompilerGenerated]
	private int int_15;

	[CompilerGenerated]
	private int int_16;

	[CompilerGenerated]
	private int int_17;

	[CompilerGenerated]
	private int int_18;

	[CompilerGenerated]
	private int int_19;

	[CompilerGenerated]
	private float float_9;

	[CompilerGenerated]
	private float float_10;

	[CompilerGenerated]
	private int int_20;

	[CompilerGenerated]
	private int int_21;

	[CompilerGenerated]
	private int int_22;

	[CompilerGenerated]
	private int int_23;

	[CompilerGenerated]
	private int int_24;

	[CompilerGenerated]
	private int int_25;

	[CompilerGenerated]
	private int int_26;

	[CompilerGenerated]
	private float float_11;

	[CompilerGenerated]
	private int int_27;

	[CompilerGenerated]
	private bool bool_2;

	[CompilerGenerated]
	private bool bool_3;

	[CompilerGenerated]
	private bool bool_4;

	[CompilerGenerated]
	private bool bool_5;

	[CompilerGenerated]
	private bool bool_6;

	[CompilerGenerated]
	private bool bool_7;

	[CompilerGenerated]
	private bool bool_8;

	[CompilerGenerated]
	private bool bool_9;

	[CompilerGenerated]
	private bool bool_10;

	[CompilerGenerated]
	private bool bool_11;

	[CompilerGenerated]
	private bool bool_12;

	[CompilerGenerated]
	private bool bool_13;

	[CompilerGenerated]
	private bool bool_14;

	[CompilerGenerated]
	private bool bool_15;

	[CompilerGenerated]
	private bool bool_16;

	[CompilerGenerated]
	private bool bool_17;

	[CompilerGenerated]
	private bool bool_18;

	[CompilerGenerated]
	private bool bool_19;

	[CompilerGenerated]
	private bool bool_20;

	[CompilerGenerated]
	private bool bool_21;

	[CompilerGenerated]
	private bool bool_22;

	[CompilerGenerated]
	private bool bool_23;

	[CompilerGenerated]
	private bool bool_24;

	[CompilerGenerated]
	private int int_28;

	[CompilerGenerated]
	private float float_12;

	[CompilerGenerated]
	private float float_13;

	[CompilerGenerated]
	private float float_14;

	[CompilerGenerated]
	private float float_15;

	[PrimaryKey]
	[AutoIncrement]
	public int Id
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

	public string ApiKeySteam
	{
		[CompilerGenerated]
		get
		{
			return string_1;
		}
		[CompilerGenerated]
		set
		{
			string_1 = value;
		}
	}

	public string Username
	{
		[CompilerGenerated]
		get
		{
			return string_2;
		}
		[CompilerGenerated]
		set
		{
			string_2 = value;
		}
	}

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return string_3;
		}
		[CompilerGenerated]
		set
		{
			string_3 = value;
		}
	}

	public string PathToExcelFile
	{
		[CompilerGenerated]
		get
		{
			return string_4;
		}
		[CompilerGenerated]
		set
		{
			string_4 = value;
		}
	}

	public float DiscountsOnTheSite
	{
		[CompilerGenerated]
		get
		{
			return float_0;
		}
		[CompilerGenerated]
		set
		{
			float_0 = value;
		}
	}

	public float CommissionOnTheSite
	{
		[CompilerGenerated]
		get
		{
			return float_1;
		}
		[CompilerGenerated]
		set
		{
			float_1 = value;
		}
	}

	public bool NotCreateOrdersFromBlueCategory
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

	public bool SoundNotifications
	{
		[CompilerGenerated]
		get
		{
			return bool_1;
		}
		[CompilerGenerated]
		set
		{
			bool_1 = value;
		}
	}

	public int FrequencyVerificationtTeMainAlgorithm
	{
		[CompilerGenerated]
		get
		{
			return int_1;
		}
		[CompilerGenerated]
		set
		{
			int_1 = value;
		}
	}

	public int FrequencyAlgorithmChecksAutomax
	{
		[CompilerGenerated]
		get
		{
			return int_2;
		}
		[CompilerGenerated]
		set
		{
			int_2 = value;
		}
	}

	public int FrequencyAlgorithmChecksAutoMin
	{
		[CompilerGenerated]
		get
		{
			return int_3;
		}
		[CompilerGenerated]
		set
		{
			int_3 = value;
		}
	}

	public int FrequencyCheckingItemsNotDelivered
	{
		[CompilerGenerated]
		get
		{
			return int_4;
		}
		[CompilerGenerated]
		set
		{
			int_4 = value;
		}
	}

	public int SelectedAutosellChoise
	{
		[CompilerGenerated]
		get
		{
			return int_5;
		}
		[CompilerGenerated]
		set
		{
			int_5 = value;
		}
	}

	public float PercentageBeforeTheDiscountIsAdded
	{
		[CompilerGenerated]
		get
		{
			return float_2;
		}
		[CompilerGenerated]
		set
		{
			float_2 = value;
		}
	}

	public float MaxThresholdInTheAbsenceThingOnSale
	{
		[CompilerGenerated]
		get
		{
			return float_3;
		}
		[CompilerGenerated]
		set
		{
			float_3 = value;
		}
	}

	public float DefaultMinThreshold
	{
		[CompilerGenerated]
		get
		{
			return float_4;
		}
		[CompilerGenerated]
		set
		{
			float_4 = value;
		}
	}

	public float DefaultMaxThreshold
	{
		[CompilerGenerated]
		get
		{
			return float_5;
		}
		[CompilerGenerated]
		set
		{
			float_5 = value;
		}
	}

	public float IncreaseMaxThresholFor
	{
		[CompilerGenerated]
		get
		{
			return float_6;
		}
		[CompilerGenerated]
		set
		{
			float_6 = value;
		}
	}

	public float DecreaseMinThresholdFor
	{
		[CompilerGenerated]
		get
		{
			return float_7;
		}
		[CompilerGenerated]
		set
		{
			float_7 = value;
		}
	}

	public DateTime AnalyticsLastTime
	{
		[CompilerGenerated]
		get
		{
			return dateTime_0;
		}
		[CompilerGenerated]
		set
		{
			dateTime_0 = value;
		}
	}

	public DateTime LastStart
	{
		[CompilerGenerated]
		get
		{
			return dateTime_1;
		}
		[CompilerGenerated]
		set
		{
			dateTime_1 = value;
		}
	}

	public DateTime LastStartAutomax
	{
		[CompilerGenerated]
		get
		{
			return dateTime_2;
		}
		[CompilerGenerated]
		set
		{
			dateTime_2 = value;
		}
	}

	public DateTime LastStartAutosell
	{
		[CompilerGenerated]
		get
		{
			return dateTime_3;
		}
		[CompilerGenerated]
		set
		{
			dateTime_3 = value;
		}
	}

	public DateTime LastStartAutomin
	{
		[CompilerGenerated]
		get
		{
			return dateTime_4;
		}
		[CompilerGenerated]
		set
		{
			dateTime_4 = value;
		}
	}

	public int ApiTimeoutMs
	{
		[CompilerGenerated]
		get
		{
			return int_6;
		}
		[CompilerGenerated]
		set
		{
			int_6 = value;
		}
	}

	public float BlueOrderPercent
	{
		[CompilerGenerated]
		get
		{
			return float_8;
		}
		[CompilerGenerated]
		set
		{
			float_8 = value;
		}
	}

	public int CountForMinThresholdColor
	{
		[CompilerGenerated]
		get
		{
			return int_7;
		}
		[CompilerGenerated]
		set
		{
			int_7 = value;
		}
	}

	public int ImportCountFrom
	{
		[CompilerGenerated]
		get
		{
			return int_8;
		}
		[CompilerGenerated]
		set
		{
			int_8 = value;
		}
	}

	public int ImportCountTo
	{
		[CompilerGenerated]
		get
		{
			return int_9;
		}
		[CompilerGenerated]
		set
		{
			int_9 = value;
		}
	}

	public int ImportHistoryFrom
	{
		[CompilerGenerated]
		get
		{
			return int_10;
		}
		[CompilerGenerated]
		set
		{
			int_10 = value;
		}
	}

	public int ImportHistoryTo
	{
		[CompilerGenerated]
		get
		{
			return int_11;
		}
		[CompilerGenerated]
		set
		{
			int_11 = value;
		}
	}

	public int OrdersForAnalytics
	{
		[CompilerGenerated]
		get
		{
			return int_12;
		}
		[CompilerGenerated]
		set
		{
			int_12 = value;
		}
	}

	public int MinProfitMoney
	{
		[CompilerGenerated]
		get
		{
			return int_13;
		}
		[CompilerGenerated]
		set
		{
			int_13 = value;
		}
	}

	public int BuyPriceFrom
	{
		[CompilerGenerated]
		get
		{
			return int_14;
		}
		[CompilerGenerated]
		set
		{
			int_14 = value;
		}
	}

	public int BuyPriceTo
	{
		[CompilerGenerated]
		get
		{
			return int_15;
		}
		[CompilerGenerated]
		set
		{
			int_15 = value;
		}
	}

	public int CountForException
	{
		[CompilerGenerated]
		get
		{
			return int_16;
		}
		[CompilerGenerated]
		set
		{
			int_16 = value;
		}
	}

	public int DaysForException
	{
		[CompilerGenerated]
		get
		{
			return int_17;
		}
		[CompilerGenerated]
		set
		{
			int_17 = value;
		}
	}

	public int DaysForSellWithoutMinThreshold
	{
		[CompilerGenerated]
		get
		{
			return int_18;
		}
		[CompilerGenerated]
		set
		{
			int_18 = value;
		}
	}

	public int CountOnSellLimit
	{
		[CompilerGenerated]
		get
		{
			return int_19;
		}
		[CompilerGenerated]
		set
		{
			int_19 = value;
		}
	}

	public float MaxPointsFitsProfit
	{
		[CompilerGenerated]
		get
		{
			return float_9;
		}
		[CompilerGenerated]
		set
		{
			float_9 = value;
		}
	}

	public float BiggerProfit
	{
		[CompilerGenerated]
		get
		{
			return float_10;
		}
		[CompilerGenerated]
		set
		{
			float_10 = value;
		}
	}

	public int BiggerProfitMoney
	{
		[CompilerGenerated]
		get
		{
			return int_20;
		}
		[CompilerGenerated]
		set
		{
			int_20 = value;
		}
	}

	public int Months
	{
		[CompilerGenerated]
		get
		{
			return int_21;
		}
		[CompilerGenerated]
		set
		{
			int_21 = value;
		}
	}

	public int BuysCountFrom
	{
		[CompilerGenerated]
		get
		{
			return int_22;
		}
		[CompilerGenerated]
		set
		{
			int_22 = value;
		}
	}

	public int BuysCountTo
	{
		[CompilerGenerated]
		get
		{
			return int_23;
		}
		[CompilerGenerated]
		set
		{
			int_23 = value;
		}
	}

	public int MaxOrdersCount
	{
		[CompilerGenerated]
		get
		{
			return int_24;
		}
		[CompilerGenerated]
		set
		{
			int_24 = value;
		}
	}

	public int MaxItemsWithStickersCount
	{
		[CompilerGenerated]
		get
		{
			return int_25;
		}
		[CompilerGenerated]
		set
		{
			int_25 = value;
		}
	}

	public int PositionOfIgnorFirstOrder
	{
		[CompilerGenerated]
		get
		{
			return int_26;
		}
		[CompilerGenerated]
		set
		{
			int_26 = value;
		}
	}

	public float PercentOfIgnorFirstOrder
	{
		[CompilerGenerated]
		get
		{
			return float_11;
		}
		[CompilerGenerated]
		set
		{
			float_11 = value;
		}
	}

	public int OnlyBiggerProfitCount
	{
		[CompilerGenerated]
		get
		{
			return int_27;
		}
		[CompilerGenerated]
		set
		{
			int_27 = value;
		}
	}

	public bool AnalyticsTimeFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_2;
		}
		[CompilerGenerated]
		set
		{
			bool_2 = value;
		}
	}

	public bool BuysCountFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_3;
		}
		[CompilerGenerated]
		set
		{
			bool_3 = value;
		}
	}

	public bool ExposeTimeFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_4;
		}
		[CompilerGenerated]
		set
		{
			bool_4 = value;
		}
	}

	public bool AutoStartCheckFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_5;
		}
		[CompilerGenerated]
		set
		{
			bool_5 = value;
		}
	}

	public bool AutoStartSteamTraderFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_6;
		}
		[CompilerGenerated]
		set
		{
			bool_6 = value;
		}
	}

	public bool LoggerFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_7;
		}
		[CompilerGenerated]
		set
		{
			bool_7 = value;
		}
	}

	public bool DeleteOrdersFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_8;
		}
		[CompilerGenerated]
		set
		{
			bool_8 = value;
		}
	}

	public bool FrequencyAlgorithmChecksAutomaxFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_9;
		}
		[CompilerGenerated]
		set
		{
			bool_9 = value;
		}
	}

	public bool FrequencyAlgorithmChecksAutoMinFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_10;
		}
		[CompilerGenerated]
		set
		{
			bool_10 = value;
		}
	}

	public bool ImportCountFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_11;
		}
		[CompilerGenerated]
		set
		{
			bool_11 = value;
		}
	}

	public bool ImportHistoryFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_12;
		}
		[CompilerGenerated]
		set
		{
			bool_12 = value;
		}
	}

	public bool AddImportFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_13;
		}
		[CompilerGenerated]
		set
		{
			bool_13 = value;
		}
	}

	public bool AdvancedSettingsFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_14;
		}
		[CompilerGenerated]
		set
		{
			bool_14 = value;
		}
	}

	public bool MaxOrdersFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_15;
		}
		[CompilerGenerated]
		set
		{
			bool_15 = value;
		}
	}

	public bool MaxItemsWithStickersFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_16;
		}
		[CompilerGenerated]
		set
		{
			bool_16 = value;
		}
	}

	public bool IgnorFirstOrderFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_17;
		}
		[CompilerGenerated]
		set
		{
			bool_17 = value;
		}
	}

	public bool IgnorFarOrderFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_18;
		}
		[CompilerGenerated]
		set
		{
			bool_18 = value;
		}
	}

	public bool OnlyBiggerProfitFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_19;
		}
		[CompilerGenerated]
		set
		{
			bool_19 = value;
		}
	}

	public bool BlueOrderFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_20;
		}
		[CompilerGenerated]
		set
		{
			bool_20 = value;
		}
	}

	public bool BlueSellFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_21;
		}
		[CompilerGenerated]
		set
		{
			bool_21 = value;
		}
	}

	public bool RedOrderFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_22;
		}
		[CompilerGenerated]
		set
		{
			bool_22 = value;
		}
	}

	public bool RedSellFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_23;
		}
		[CompilerGenerated]
		set
		{
			bool_23 = value;
		}
	}

	public bool DeleteUnprofitableOrderFlag
	{
		[CompilerGenerated]
		get
		{
			return bool_24;
		}
		[CompilerGenerated]
		set
		{
			bool_24 = value;
		}
	}

	public int LastBuyCountDays
	{
		[CompilerGenerated]
		get
		{
			return int_28;
		}
		[CompilerGenerated]
		set
		{
			int_28 = value;
		}
	}

	public float OrderXPercentage
	{
		[CompilerGenerated]
		get
		{
			return float_12;
		}
		[CompilerGenerated]
		set
		{
			float_12 = value;
		}
	}

	public float MaxThresholdYPercentage
	{
		[CompilerGenerated]
		get
		{
			return float_13;
		}
		[CompilerGenerated]
		set
		{
			float_13 = value;
		}
	}

	public float MinThresholdYPercentage
	{
		[CompilerGenerated]
		get
		{
			return float_14;
		}
		[CompilerGenerated]
		set
		{
			float_14 = value;
		}
	}

	public float MinDiffForCancelOrderPercentage
	{
		[CompilerGenerated]
		get
		{
			return float_15;
		}
		[CompilerGenerated]
		set
		{
			float_15 = value;
		}
	}

	public SettingPubg()
	{
		Class24.nhQmSIPz7n4eU();
		base._002Ector();
	}
}
