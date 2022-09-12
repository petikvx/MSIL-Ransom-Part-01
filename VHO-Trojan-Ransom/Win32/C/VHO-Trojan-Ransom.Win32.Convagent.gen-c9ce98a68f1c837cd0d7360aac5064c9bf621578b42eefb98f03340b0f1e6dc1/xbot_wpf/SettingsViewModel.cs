using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Caliburn.Micro;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using xbot_wpf.Common;
using xbot_wpf.Messages;
using xbot_wpf.Models;
using xbot_wpf.Services;
using xbot_wpf.Views;

namespace xbot_wpf;

public class SettingsViewModel : Screen, IHandle<ChangeSettingsIndexCsgo>, IHandle<ChangeSettingsIndexDota2>, IHandle, GInterface0
{
	private readonly ILog ilog_0;

	private readonly IApiMarketCsgoCom iapiMarketCsgoCom_0;

	private readonly GInterface2 ginterface2_0;

	private readonly IMessageBox imessageBox_0;

	private readonly GInterface1 ginterface1_0;

	private readonly IEventAggregator ieventAggregator_0;

	private JObject jobject_0;

	private Setting setting_0;

	private SettingDota2 settingDota2_0;

	private readonly List<string> list_0;

	private readonly List<string> list_1;

	private readonly List<string> list_2;

	private int int_0;

	private bool bool_0;

	private bool bool_1;

	private bool bool_2;

	private bool bool_3;

	private bool bool_4;

	private bool bool_5;

	private bool bool_6;

	private bool bool_7;

	private bool bool_8;

	private bool bool_9;

	private bool bool_10;

	private bool bool_11;

	private bool bool_12;

	private bool bool_13;

	private bool bool_14;

	private bool bool_15;

	private bool bool_16;

	private bool bool_17;

	private bool bool_18;

	private bool bool_19;

	private bool bool_20;

	private bool bool_21;

	private bool bool_22;

	private string string_0;

	private string string_1;

	private string string_2;

	private string string_3;

	private string string_4;

	private float float_0;

	private float float_1;

	private bool bool_23;

	private bool bool_24;

	public string _frequencyVerificationtTeMainAlgorithm;

	public string _frequencyAlgorithmChecksAutomax;

	public string _frequencyAlgorithmChecksAutoMin;

	private string string_5;

	private float float_2;

	private float float_3;

	private float float_4;

	private float float_5;

	private float float_6;

	private float float_7;

	private float float_8;

	private float float_9;

	private float float_10;

	private float float_11;

	private int int_1;

	private int int_2;

	private int IarvnCrfLt;

	private int int_3;

	private int int_4;

	private int int_5;

	private int int_6;

	private int int_7;

	private int int_8;

	private int int_9;

	private float float_12;

	private float BwfwviuaYw;

	private int int_10;

	private float float_13;

	private int int_11;

	private int int_12;

	private int int_13;

	private int int_14;

	private int int_15;

	private int int_16;

	private int int_17;

	private int int_18;

	private int int_19;

	private int int_20;

	private int int_21;

	private int int_22;

	private float float_14;

	private int int_23;

	private int int_24;

	private int int_25;

	private int int_26;

	private bool bool_25;

	private bool bool_26;

	private bool bool_27;

	private bool bool_28;

	private bool bool_29;

	private bool bool_30;

	private bool bool_31;

	private bool bool_32;

	private bool bool_33;

	private bool bool_34;

	private bool bool_35;

	private bool bool_36;

	private bool rRawOfcoFw;

	private bool bool_37;

	private bool bool_38;

	private bool bool_39;

	private bool bool_40;

	private bool bool_41;

	private bool bool_42;

	private bool bool_43;

	private bool bool_44;

	private bool bool_45;

	private bool bool_46;

	private bool bool_47;

	private string string_6;

	private string string_7;

	private string string_8;

	private string string_9;

	private string string_10;

	public string _frequencyVerificationtTeMainAlgorithmDota2;

	public string _frequencyAlgorithmChecksAutomaxDota2;

	public string _frequencyAlgorithmChecksAutoMinDota2;

	private string string_11;

	private float float_15;

	private float float_16;

	private float float_17;

	private float float_18;

	private float float_19;

	private float float_20;

	private float float_21;

	private float float_22;

	private float float_23;

	private int int_27;

	private int int_28;

	private int int_29;

	private int int_30;

	private int int_31;

	private int int_32;

	private int int_33;

	private int int_34;

	private int int_35;

	private int int_36;

	private float float_24;

	private float float_25;

	private int int_37;

	private float float_26;

	private int int_38;

	private int int_39;

	private int int_40;

	private int int_41;

	private int int_42;

	private int int_43;

	private int int_44;

	private int int_45;

	private int int_46;

	private int int_47;

	private int int_48;

	private int int_49;

	private int int_50;

	private float float_27;

	private int int_51;

	private int int_52;

	private int int_53;

	private int int_54;

	public int TabIndex
	{
		get
		{
			return int_0;
		}
		set
		{
			int_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => TabIndex));
		}
	}

	public bool AnalyticsTimeFlag
	{
		get
		{
			return bool_0;
		}
		set
		{
			bool_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => AnalyticsTimeFlag));
			setting_0.AnalyticsTimeFlag = bool_0;
		}
	}

	public bool ExposeTimeFlag
	{
		get
		{
			return bool_1;
		}
		set
		{
			bool_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => ExposeTimeFlag));
			setting_0.ExposeTimeFlag = bool_1;
		}
	}

	public bool LoggerFlag
	{
		get
		{
			return bool_2;
		}
		set
		{
			bool_2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => LoggerFlag));
			setting_0.LoggerFlag = bool_2;
		}
	}

	public bool DeleteOrdersFlag
	{
		get
		{
			return bool_3;
		}
		set
		{
			bool_3 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => DeleteOrdersFlag));
			setting_0.DeleteOrdersFlag = bool_3;
		}
	}

	public bool FrequencyAlgorithmChecksAutomaxFlag
	{
		get
		{
			return bool_4;
		}
		set
		{
			bool_4 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => FrequencyAlgorithmChecksAutomaxFlag));
			setting_0.FrequencyAlgorithmChecksAutomaxFlag = bool_4;
		}
	}

	public bool FrequencyAlgorithmChecksAutoMinFlag
	{
		get
		{
			return bool_5;
		}
		set
		{
			bool_5 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => FrequencyAlgorithmChecksAutoMinFlag));
			setting_0.FrequencyAlgorithmChecksAutoMinFlag = bool_5;
		}
	}

	public bool AdvancedSettingsFlag
	{
		get
		{
			return bool_6;
		}
		set
		{
			bool_6 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => AdvancedSettingsFlag));
			setting_0.AdvancedSettingsFlag = bool_6;
		}
	}

	public bool MaxOrdersFlag
	{
		get
		{
			return bool_7;
		}
		set
		{
			bool_7 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxOrdersFlag));
			setting_0.MaxOrdersFlag = bool_7;
		}
	}

	public bool MaxStatTrakFlag
	{
		get
		{
			return bool_8;
		}
		set
		{
			bool_8 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxStatTrakFlag));
			setting_0.MaxStatTrakFlag = bool_8;
		}
	}

	public bool MaxKniveFlag
	{
		get
		{
			return bool_9;
		}
		set
		{
			bool_9 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxKniveFlag));
			setting_0.MaxKniveFlag = bool_9;
		}
	}

	public bool MaxStatTrakKniveFlag
	{
		get
		{
			return bool_10;
		}
		set
		{
			bool_10 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxStatTrakKniveFlag));
			setting_0.MaxStatTrakKniveFlag = bool_10;
		}
	}

	public bool MaxStickersFlag
	{
		get
		{
			return bool_11;
		}
		set
		{
			bool_11 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxStickersFlag));
			setting_0.MaxStickersFlag = bool_11;
		}
	}

	public bool MaxCaseFlag
	{
		get
		{
			return bool_12;
		}
		set
		{
			bool_12 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxCaseFlag));
			setting_0.MaxCaseFlag = bool_12;
		}
	}

	public bool MaxItemsWithStickersFlag
	{
		get
		{
			return bool_13;
		}
		set
		{
			bool_13 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxItemsWithStickersFlag));
			setting_0.MaxItemsWithStickersFlag = bool_13;
		}
	}

	public bool IgnorFirstOrderFlag
	{
		get
		{
			return bool_14;
		}
		set
		{
			bool_14 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IgnorFirstOrderFlag));
			setting_0.IgnorFirstOrderFlag = bool_14;
		}
	}

	public bool IgnorFarOrderFlag
	{
		get
		{
			return bool_15;
		}
		set
		{
			bool_15 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IgnorFarOrderFlag));
			setting_0.IgnorFarOrderFlag = bool_15;
		}
	}

	public bool BlueOrderFlag
	{
		get
		{
			return bool_16;
		}
		set
		{
			bool_16 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => BlueOrderFlag));
			setting_0.BlueOrderFlag = bool_16;
		}
	}

	public bool BlueSellFlag
	{
		get
		{
			return bool_17;
		}
		set
		{
			bool_17 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => BlueSellFlag));
			setting_0.BlueSellFlag = bool_17;
		}
	}

	public bool RedOrderFlag
	{
		get
		{
			return bool_18;
		}
		set
		{
			bool_18 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => RedOrderFlag));
			setting_0.RedOrderFlag = bool_18;
		}
	}

	public bool RedSellFlag
	{
		get
		{
			return bool_19;
		}
		set
		{
			bool_19 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => RedSellFlag));
			setting_0.RedSellFlag = bool_19;
		}
	}

	public bool ImportCountFlag
	{
		get
		{
			return bool_20;
		}
		set
		{
			bool_20 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => ImportCountFlag));
			setting_0.ImportCountFlag = bool_20;
		}
	}

	public bool ImportHistoryFlag
	{
		get
		{
			return bool_21;
		}
		set
		{
			bool_21 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => ImportHistoryFlag));
			setting_0.ImportHistoryFlag = bool_21;
		}
	}

	public bool AddImportFlag
	{
		get
		{
			return bool_22;
		}
		set
		{
			bool_22 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => AddImportFlag));
			setting_0.AddImportFlag = bool_22;
		}
	}

	public int OrdersForAnalytics
	{
		get
		{
			return IarvnCrfLt;
		}
		set
		{
			IarvnCrfLt = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => OrdersForAnalytics));
			setting_0.OrdersForAnalytics = IarvnCrfLt;
		}
	}

	public int MinProfitMoney
	{
		get
		{
			return int_3;
		}
		set
		{
			int_3 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MinProfitMoney));
			setting_0.MinProfitMoney = int_3;
		}
	}

	public int BuyPriceFrom
	{
		get
		{
			return int_4;
		}
		set
		{
			int_4 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuyPriceFrom));
			setting_0.BuyPriceFrom = int_4;
		}
	}

	public int BuyPriceTo
	{
		get
		{
			return int_5;
		}
		set
		{
			int_5 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuyPriceTo));
			setting_0.BuyPriceTo = int_5;
		}
	}

	public int CountForException
	{
		get
		{
			return int_6;
		}
		set
		{
			int_6 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountForException));
			setting_0.CountForException = int_6;
		}
	}

	public int DaysForException
	{
		get
		{
			return int_7;
		}
		set
		{
			int_7 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => DaysForException));
			setting_0.DaysForException = int_7;
		}
	}

	public int DaysForSellWithoutMinThreshold
	{
		get
		{
			return int_8;
		}
		set
		{
			int_8 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => DaysForSellWithoutMinThreshold));
			setting_0.DaysForSellWithoutMinThreshold = int_8;
		}
	}

	public int CountOnSellLimit
	{
		get
		{
			return int_9;
		}
		set
		{
			int_9 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountOnSellLimit));
			setting_0.CountOnSellLimit = int_9;
		}
	}

	public float MaxPointsFitsProfit
	{
		get
		{
			return float_12;
		}
		set
		{
			float_12 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MaxPointsFitsProfit));
			setting_0.MaxPointsFitsProfit = float_12;
		}
	}

	public float BlueOrderPercent
	{
		get
		{
			return BwfwviuaYw;
		}
		set
		{
			BwfwviuaYw = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => BlueOrderPercent));
			setting_0.BlueOrderPercent = BwfwviuaYw;
		}
	}

	public int CountForMinThresholdColor
	{
		get
		{
			return int_10;
		}
		set
		{
			int_10 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountForMinThresholdColor));
			setting_0.CountForMinThresholdColor = int_10;
		}
	}

	public float BiggerProfit
	{
		get
		{
			return float_13;
		}
		set
		{
			float_13 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => BiggerProfit));
			setting_0.BiggerProfit = float_13;
		}
	}

	public int BiggerProfitMoney
	{
		get
		{
			return int_11;
		}
		set
		{
			int_11 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BiggerProfitMoney));
			setting_0.BiggerProfitMoney = int_11;
		}
	}

	public int Months
	{
		get
		{
			return int_12;
		}
		set
		{
			int_12 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => Months));
			setting_0.Months = int_12;
		}
	}

	public int BuysCountFrom
	{
		get
		{
			return int_13;
		}
		set
		{
			int_13 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuysCountFrom));
			setting_0.BuysCountFrom = int_13;
		}
	}

	public int BuysCountTo
	{
		get
		{
			return int_14;
		}
		set
		{
			int_14 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuysCountTo));
			setting_0.BuysCountTo = int_14;
		}
	}

	public int MaxOrdersCount
	{
		get
		{
			return int_15;
		}
		set
		{
			int_15 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxOrdersCount));
			setting_0.MaxOrdersCount = int_15;
		}
	}

	public int MaxStatTrakCount
	{
		get
		{
			return int_16;
		}
		set
		{
			int_16 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxStatTrakCount));
			setting_0.MaxStatTrakCount = int_16;
		}
	}

	public int MaxKniveCount
	{
		get
		{
			return int_17;
		}
		set
		{
			int_17 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxKniveCount));
			setting_0.MaxKniveCount = int_17;
		}
	}

	public int MaxStatTrakKniveCount
	{
		get
		{
			return int_18;
		}
		set
		{
			int_18 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxStatTrakKniveCount));
			setting_0.MaxStatTrakKniveCount = int_18;
		}
	}

	public int MaxStickersCount
	{
		get
		{
			return int_19;
		}
		set
		{
			int_19 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxStickersCount));
			setting_0.MaxStickersCount = int_19;
		}
	}

	public int MaxCaseCount
	{
		get
		{
			return int_20;
		}
		set
		{
			int_20 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxCaseCount));
			setting_0.MaxCaseCount = int_20;
		}
	}

	public int MaxItemsWithStickersCount
	{
		get
		{
			return int_21;
		}
		set
		{
			int_21 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxItemsWithStickersCount));
			setting_0.MaxItemsWithStickersCount = int_21;
		}
	}

	public int PositionOfIgnorFirstOrder
	{
		get
		{
			return int_22;
		}
		set
		{
			int_22 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => PositionOfIgnorFirstOrder));
			setting_0.PositionOfIgnorFirstOrder = int_22;
		}
	}

	public float PercentOfIgnorFirstOrder
	{
		get
		{
			return float_14;
		}
		set
		{
			float_14 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => PercentOfIgnorFirstOrder));
			setting_0.PercentOfIgnorFirstOrder = float_14;
		}
	}

	public int ImportCountFrom
	{
		get
		{
			return int_23;
		}
		set
		{
			int_23 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportCountFrom));
			setting_0.ImportCountFrom = int_23;
		}
	}

	public int ImportCountTo
	{
		get
		{
			return int_24;
		}
		set
		{
			int_24 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportCountTo));
			setting_0.ImportCountTo = int_24;
		}
	}

	public int ImportHistoryFrom
	{
		get
		{
			return int_25;
		}
		set
		{
			int_25 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportHistoryFrom));
			setting_0.ImportHistoryFrom = int_25;
		}
	}

	public int ImportHistoryTo
	{
		get
		{
			return int_26;
		}
		set
		{
			int_26 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportHistoryTo));
			setting_0.ImportHistoryTo = int_26;
		}
	}

	public int ApiTimeoutMs
	{
		get
		{
			return int_1;
		}
		set
		{
			int_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ApiTimeoutMs));
			setting_0.ApiTimeoutMs = int_1;
			iapiMarketCsgoCom_0.Timeout = int_1;
		}
	}

	public int LastBuyCountDays
	{
		get
		{
			return int_2;
		}
		set
		{
			int_2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => LastBuyCountDays));
			setting_0.LastBuyCountDays = int_2;
		}
	}

	public string ApiKey
	{
		get
		{
			return string_0;
		}
		set
		{
			string_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => ApiKey));
			setting_0.ApiKey = string_0;
			settingDota2_0.ApiKey = string_0;
			iapiMarketCsgoCom_0.ApiKey = string_0;
			ginterface2_0.ApiKey = string_0;
		}
	}

	public string ApiKeySteam
	{
		get
		{
			return string_1;
		}
		set
		{
			string_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => ApiKeySteam));
			setting_0.ApiKeySteam = string_1;
			settingDota2_0.ApiKeySteam = string_1;
		}
	}

	public string Username
	{
		get
		{
			return string_2;
		}
		set
		{
			string_2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => Username));
			setting_0.Username = string_2;
			settingDota2_0.Username = string_2;
		}
	}

	public string Password
	{
		get
		{
			return string_3;
		}
		set
		{
			string_3 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => Password));
			setting_0.Password = string_3;
			settingDota2_0.Password = string_3;
		}
	}

	public string PathToExcelFile
	{
		get
		{
			return string_4;
		}
		set
		{
			string_4 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => PathToExcelFile));
			setting_0.PathToExcelFile = string_4;
		}
	}

	public float DiscountsOnTheSite
	{
		get
		{
			return float_0;
		}
		set
		{
			float_0 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => DiscountsOnTheSite));
			setting_0.DiscountsOnTheSite = float_0;
		}
	}

	public float CommissionOnTheSite
	{
		get
		{
			return float_1;
		}
		set
		{
			float_1 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => CommissionOnTheSite));
			setting_0.CommissionOnTheSite = float_1;
		}
	}

	public bool NotCreateOrdersFromBlueCategory
	{
		get
		{
			return bool_23;
		}
		set
		{
			bool_23 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => NotCreateOrdersFromBlueCategory));
			setting_0.NotCreateOrdersFromBlueCategory = bool_23;
		}
	}

	public bool SoundNotifications
	{
		get
		{
			return bool_24;
		}
		set
		{
			bool_24 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => SoundNotifications));
			setting_0.SoundNotifications = bool_24;
		}
	}

	public List<string> FrequencyVerificationtTeMainAlgorithm => list_2;

	public string SelectedTimeToFrequencyVerificationtTeMainAlgorithm
	{
		get
		{
			return _frequencyVerificationtTeMainAlgorithm;
		}
		set
		{
			_frequencyVerificationtTeMainAlgorithm = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyVerificationtTeMainAlgorithm));
			setting_0.FrequencyVerificationtTeMainAlgorithm = SelectedTimeToIntFromMainAlgorithm(_frequencyVerificationtTeMainAlgorithm);
		}
	}

	public List<string> FrequencyAlgorithmChecksAutomax => list_0;

	public string SelectedTimeToFrequencyAlgorithmChecksAutomax
	{
		get
		{
			return _frequencyAlgorithmChecksAutomax;
		}
		set
		{
			_frequencyAlgorithmChecksAutomax = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyVerificationtTeMainAlgorithm));
			setting_0.FrequencyAlgorithmChecksAutomax = SelectedTimeToInt(_frequencyAlgorithmChecksAutomax);
		}
	}

	public List<string> FrequencyAlgorithmChecksAutoMin => list_0;

	public string SelectedTimeToFrequencyAlgorithmChecksAutoMin
	{
		get
		{
			return _frequencyAlgorithmChecksAutoMin;
		}
		set
		{
			_frequencyAlgorithmChecksAutoMin = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyAlgorithmChecksAutoMin));
			setting_0.FrequencyAlgorithmChecksAutoMin = SelectedTimeToInt(_frequencyAlgorithmChecksAutoMin);
		}
	}

	public List<string> FrequencyCheckingItemsNotDelivered => list_1;

	public string SelectedTimeToFrequencyCheckingItemsNotDelivered
	{
		get
		{
			return string_5;
		}
		set
		{
			string_5 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyCheckingItemsNotDelivered));
			setting_0.FrequencyCheckingItemsNotDelivered = SelectedTimeToIntForAutoSell(string_5);
		}
	}

	public float PercentageBeforeTheDiscountIsAdded
	{
		get
		{
			return float_2;
		}
		set
		{
			float_2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => PercentageBeforeTheDiscountIsAdded));
			setting_0.PercentageBeforeTheDiscountIsAdded = float_2;
		}
	}

	public float MaxThresholdInTheAbsenceThingOnSale
	{
		get
		{
			return float_3;
		}
		set
		{
			float_3 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MaxThresholdInTheAbsenceThingOnSale));
			setting_0.MaxThresholdInTheAbsenceThingOnSale = float_3;
		}
	}

	public float OrderXPercentage
	{
		get
		{
			return float_4;
		}
		set
		{
			float_4 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => OrderXPercentage));
			setting_0.OrderXPercentage = float_4;
		}
	}

	public float MaxThresholdYPercentage
	{
		get
		{
			return float_5;
		}
		set
		{
			float_5 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MaxThresholdYPercentage));
			setting_0.MaxThresholdYPercentage = float_5;
		}
	}

	public float MinThresholdYPercentage
	{
		get
		{
			return float_6;
		}
		set
		{
			float_6 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MinThresholdYPercentage));
			setting_0.MinThresholdYPercentage = float_6;
		}
	}

	public float DefaultMinThreshold
	{
		get
		{
			return float_7;
		}
		set
		{
			float_7 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => DefaultMinThreshold));
			setting_0.DefaultMinThreshold = float_7;
		}
	}

	public float DefaultMaxThreshold
	{
		get
		{
			return float_8;
		}
		set
		{
			float_8 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => DefaultMaxThreshold));
			setting_0.DefaultMaxThreshold = float_8;
		}
	}

	public float MinDiffForCancelOrderPercentage
	{
		get
		{
			return float_9;
		}
		set
		{
			float_9 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MinDiffForCancelOrderPercentage));
			setting_0.MinDiffForCancelOrderPercentage = float_9;
		}
	}

	public float IncreaseMaxThresholFor
	{
		get
		{
			return float_10;
		}
		set
		{
			float_10 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => IncreaseMaxThresholFor));
			setting_0.IncreaseMaxThresholFor = float_10;
		}
	}

	public float DecreaseMinThresholdFor
	{
		get
		{
			return float_11;
		}
		set
		{
			float_11 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => DecreaseMinThresholdFor));
			setting_0.DecreaseMinThresholdFor = float_11;
		}
	}

	public bool AnalyticsTimeFlagDota2
	{
		get
		{
			return bool_25;
		}
		set
		{
			bool_25 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => AnalyticsTimeFlagDota2));
			settingDota2_0.AnalyticsTimeFlag = bool_25;
		}
	}

	public bool ExposeTimeFlagDota2
	{
		get
		{
			return bool_26;
		}
		set
		{
			bool_26 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => ExposeTimeFlagDota2));
			settingDota2_0.ExposeTimeFlag = bool_26;
		}
	}

	public bool LoggerFlagDota2
	{
		get
		{
			return bool_27;
		}
		set
		{
			bool_27 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => LoggerFlagDota2));
			settingDota2_0.LoggerFlag = bool_27;
		}
	}

	public bool DeleteOrdersFlagDota2
	{
		get
		{
			return bool_28;
		}
		set
		{
			bool_28 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => DeleteOrdersFlagDota2));
			settingDota2_0.DeleteOrdersFlag = bool_28;
		}
	}

	public bool FrequencyAlgorithmChecksAutomaxFlagDota2
	{
		get
		{
			return bool_29;
		}
		set
		{
			bool_29 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => FrequencyAlgorithmChecksAutomaxFlagDota2));
			settingDota2_0.FrequencyAlgorithmChecksAutomaxFlag = bool_29;
		}
	}

	public bool FrequencyAlgorithmChecksAutoMinFlagDota2
	{
		get
		{
			return bool_30;
		}
		set
		{
			bool_30 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => FrequencyAlgorithmChecksAutoMinFlagDota2));
			settingDota2_0.FrequencyAlgorithmChecksAutoMinFlag = bool_30;
		}
	}

	public bool AdvancedSettingsFlagDota2
	{
		get
		{
			return bool_31;
		}
		set
		{
			bool_31 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => AdvancedSettingsFlagDota2));
			settingDota2_0.AdvancedSettingsFlag = bool_31;
		}
	}

	public bool MaxUncommonFlagDota2
	{
		get
		{
			return bool_32;
		}
		set
		{
			bool_32 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxUncommonFlagDota2));
			settingDota2_0.MaxUncommonFlagDota2 = bool_32;
		}
	}

	public bool MaxRareFlagDota2
	{
		get
		{
			return bool_33;
		}
		set
		{
			bool_33 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxRareFlagDota2));
			settingDota2_0.MaxRareFlagDota2 = bool_33;
		}
	}

	public bool MaxMythicalFlagDota2
	{
		get
		{
			return bool_34;
		}
		set
		{
			bool_34 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxMythicalFlagDota2));
			settingDota2_0.MaxMythicalFlagDota2 = bool_34;
		}
	}

	public bool MaxLegendaryFlagDota2
	{
		get
		{
			return bool_35;
		}
		set
		{
			bool_35 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxLegendaryFlagDota2));
			settingDota2_0.MaxLegendaryFlagDota2 = bool_35;
		}
	}

	public bool MaxImmortalFlagDota2
	{
		get
		{
			return bool_36;
		}
		set
		{
			bool_36 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxImmortalFlagDota2));
			settingDota2_0.MaxImmortalFlagDota2 = bool_36;
		}
	}

	public bool MaxAncientFlagDota2
	{
		get
		{
			return rRawOfcoFw;
		}
		set
		{
			rRawOfcoFw = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxAncientFlagDota2));
			settingDota2_0.MaxAncientFlagDota2 = rRawOfcoFw;
		}
	}

	public bool MaxArcanaFlagDota2
	{
		get
		{
			return bool_37;
		}
		set
		{
			bool_37 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxArcanaFlagDota2));
			settingDota2_0.MaxArcanaFlagDota2 = bool_37;
		}
	}

	public bool MaxOrdersFlagDota2
	{
		get
		{
			return bool_38;
		}
		set
		{
			bool_38 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => MaxOrdersFlagDota2));
			settingDota2_0.MaxOrdersFlag = bool_38;
		}
	}

	public bool IgnorFirstOrderFlagDota2
	{
		get
		{
			return bool_39;
		}
		set
		{
			bool_39 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IgnorFirstOrderFlagDota2));
			settingDota2_0.IgnorFirstOrderFlag = bool_39;
		}
	}

	public bool IgnorFarOrderFlagDota2
	{
		get
		{
			return bool_40;
		}
		set
		{
			bool_40 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => IgnorFarOrderFlagDota2));
			settingDota2_0.IgnorFarOrderFlag = bool_40;
		}
	}

	public bool BlueOrderFlagDota2
	{
		get
		{
			return bool_41;
		}
		set
		{
			bool_41 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => BlueOrderFlagDota2));
			settingDota2_0.BlueOrderFlag = bool_41;
		}
	}

	public bool BlueSellFlagDota2
	{
		get
		{
			return bool_42;
		}
		set
		{
			bool_42 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => BlueSellFlagDota2));
			settingDota2_0.BlueSellFlag = bool_42;
		}
	}

	public bool RedOrderFlagDota2
	{
		get
		{
			return bool_43;
		}
		set
		{
			bool_43 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => RedOrderFlagDota2));
			settingDota2_0.RedOrderFlag = bool_43;
		}
	}

	public bool RedSellFlagDota2
	{
		get
		{
			return bool_44;
		}
		set
		{
			bool_44 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => RedSellFlagDota2));
			settingDota2_0.RedSellFlag = bool_44;
		}
	}

	public bool ImportCountFlagDota2
	{
		get
		{
			return bool_45;
		}
		set
		{
			bool_45 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => ImportCountFlagDota2));
			settingDota2_0.ImportCountFlag = bool_45;
		}
	}

	public bool ImportHistoryFlagDota2
	{
		get
		{
			return bool_46;
		}
		set
		{
			bool_46 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => ImportHistoryFlagDota2));
			settingDota2_0.ImportHistoryFlag = bool_46;
		}
	}

	public bool AddImportFlagDota2
	{
		get
		{
			return bool_47;
		}
		set
		{
			bool_47 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<bool>((Expression<Func<bool>>)(() => AddImportFlagDota2));
			settingDota2_0.AddImportFlag = bool_47;
		}
	}

	public int OrdersForAnalyticsDota2
	{
		get
		{
			return int_29;
		}
		set
		{
			int_29 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => OrdersForAnalyticsDota2));
			settingDota2_0.OrdersForAnalytics = int_29;
		}
	}

	public int MinProfitMoneyDota2
	{
		get
		{
			return int_30;
		}
		set
		{
			int_30 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MinProfitMoneyDota2));
			settingDota2_0.MinProfitMoney = int_30;
		}
	}

	public int BuyPriceFromDota2
	{
		get
		{
			return int_31;
		}
		set
		{
			int_31 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuyPriceFromDota2));
			settingDota2_0.BuyPriceFrom = int_31;
		}
	}

	public int BuyPriceToDota2
	{
		get
		{
			return int_32;
		}
		set
		{
			int_32 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuyPriceToDota2));
			settingDota2_0.BuyPriceTo = int_32;
		}
	}

	public int CountForExceptionDota2
	{
		get
		{
			return int_33;
		}
		set
		{
			int_33 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountForExceptionDota2));
			settingDota2_0.CountForException = int_33;
		}
	}

	public int DaysForExceptionDota2
	{
		get
		{
			return int_34;
		}
		set
		{
			int_34 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => DaysForExceptionDota2));
			settingDota2_0.DaysForException = int_34;
		}
	}

	public int DaysForSellWithoutMinThresholdDota2
	{
		get
		{
			return int_35;
		}
		set
		{
			int_35 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => DaysForSellWithoutMinThresholdDota2));
			settingDota2_0.DaysForSellWithoutMinThreshold = int_35;
		}
	}

	public int CountOnSellLimitDota2
	{
		get
		{
			return int_36;
		}
		set
		{
			int_36 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountOnSellLimitDota2));
			settingDota2_0.CountOnSellLimit = int_36;
		}
	}

	public float MaxPointsFitsProfitDota2
	{
		get
		{
			return float_24;
		}
		set
		{
			float_24 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MaxPointsFitsProfitDota2));
			settingDota2_0.MaxPointsFitsProfit = float_24;
		}
	}

	public float BlueOrderPercentDota2
	{
		get
		{
			return float_25;
		}
		set
		{
			float_25 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => BlueOrderPercentDota2));
			settingDota2_0.BlueOrderPercent = float_25;
		}
	}

	public int CountForMinThresholdColorDota2
	{
		get
		{
			return int_37;
		}
		set
		{
			int_37 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => CountForMinThresholdColorDota2));
			settingDota2_0.CountForMinThresholdColor = int_37;
		}
	}

	public float BiggerProfitDota2
	{
		get
		{
			return float_26;
		}
		set
		{
			float_26 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => BiggerProfitDota2));
			settingDota2_0.BiggerProfit = float_26;
		}
	}

	public int BiggerProfitMoneyDota2
	{
		get
		{
			return int_38;
		}
		set
		{
			int_38 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BiggerProfitMoneyDota2));
			settingDota2_0.BiggerProfitMoney = int_38;
		}
	}

	public int MonthsDota2
	{
		get
		{
			return int_39;
		}
		set
		{
			int_39 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MonthsDota2));
			settingDota2_0.Months = int_39;
		}
	}

	public int BuysCountFromDota2
	{
		get
		{
			return int_40;
		}
		set
		{
			int_40 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuysCountFromDota2));
			settingDota2_0.BuysCountFrom = int_40;
		}
	}

	public int BuysCountToDota2
	{
		get
		{
			return int_41;
		}
		set
		{
			int_41 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => BuysCountToDota2));
			settingDota2_0.BuysCountTo = int_41;
		}
	}

	public int MaxOrdersCountDota2
	{
		get
		{
			return int_42;
		}
		set
		{
			int_42 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxOrdersCountDota2));
			settingDota2_0.MaxOrdersCount = int_42;
		}
	}

	public int MaxUncommonCountDota2
	{
		get
		{
			return int_43;
		}
		set
		{
			int_43 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxUncommonCountDota2));
			settingDota2_0.MaxUncommonCountDota2 = int_43;
		}
	}

	public int MaxRareCountDota2
	{
		get
		{
			return int_44;
		}
		set
		{
			int_44 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxRareCountDota2));
			settingDota2_0.MaxRareCountDota2 = int_44;
		}
	}

	public int MaxMythicalCountDota2
	{
		get
		{
			return int_45;
		}
		set
		{
			int_45 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxMythicalCountDota2));
			settingDota2_0.MaxMythicalCountDota2 = int_45;
		}
	}

	public int MaxLegendaryCountDota2
	{
		get
		{
			return int_46;
		}
		set
		{
			int_46 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxLegendaryCountDota2));
			settingDota2_0.MaxLegendaryCountDota2 = int_46;
		}
	}

	public int MaxImmortalCountDota2
	{
		get
		{
			return int_47;
		}
		set
		{
			int_47 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxImmortalCountDota2));
			settingDota2_0.MaxImmortalCountDota2 = int_47;
		}
	}

	public int MaxAncientCountDota2
	{
		get
		{
			return int_48;
		}
		set
		{
			int_48 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxAncientCountDota2));
			settingDota2_0.MaxAncientCountDota2 = int_48;
		}
	}

	public int MaxArcanaCountDota2
	{
		get
		{
			return int_49;
		}
		set
		{
			int_49 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => MaxArcanaCountDota2));
			settingDota2_0.MaxArcanaCountDota2 = int_49;
		}
	}

	public int PositionOfIgnorFirstOrderDota2
	{
		get
		{
			return int_50;
		}
		set
		{
			int_50 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => PositionOfIgnorFirstOrderDota2));
			settingDota2_0.PositionOfIgnorFirstOrder = int_50;
		}
	}

	public float PercentOfIgnorFirstOrderDota2
	{
		get
		{
			return float_27;
		}
		set
		{
			float_27 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => PercentOfIgnorFirstOrderDota2));
			settingDota2_0.PercentOfIgnorFirstOrder = float_27;
		}
	}

	public int ImportCountFromDota2
	{
		get
		{
			return int_51;
		}
		set
		{
			int_51 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportCountFromDota2));
			settingDota2_0.ImportCountFrom = int_51;
		}
	}

	public int ImportCountToDota2
	{
		get
		{
			return int_52;
		}
		set
		{
			int_52 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportCountToDota2));
			settingDota2_0.ImportCountTo = int_52;
		}
	}

	public int ImportHistoryFromDota2
	{
		get
		{
			return int_53;
		}
		set
		{
			int_53 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportHistoryFromDota2));
			settingDota2_0.ImportHistoryFrom = int_53;
		}
	}

	public int ImportHistoryToDota2
	{
		get
		{
			return int_54;
		}
		set
		{
			int_54 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ImportHistoryToDota2));
			settingDota2_0.ImportHistoryTo = int_54;
		}
	}

	public int ApiTimeoutMsDota2
	{
		get
		{
			return int_27;
		}
		set
		{
			int_27 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => ApiTimeoutMsDota2));
			settingDota2_0.ApiTimeoutMs = int_27;
			ginterface2_0.Timeout = int_27;
		}
	}

	public int LastBuyCountDaysDota2
	{
		get
		{
			return int_28;
		}
		set
		{
			int_28 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<int>((Expression<Func<int>>)(() => LastBuyCountDaysDota2));
			settingDota2_0.LastBuyCountDays = int_28;
		}
	}

	public string ApiKeyDota2
	{
		get
		{
			return string_6;
		}
		set
		{
			string_6 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => ApiKeyDota2));
			settingDota2_0.ApiKey = string_6;
			setting_0.ApiKey = string_6;
			ginterface2_0.ApiKey = string_6;
			iapiMarketCsgoCom_0.ApiKey = string_6;
		}
	}

	public string ApiKeySteamDota2
	{
		get
		{
			return string_7;
		}
		set
		{
			string_7 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => ApiKeySteamDota2));
			setting_0.ApiKeySteam = string_7;
			settingDota2_0.ApiKeySteam = string_7;
		}
	}

	public string UsernameDota2
	{
		get
		{
			return string_8;
		}
		set
		{
			string_8 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => UsernameDota2));
			setting_0.Username = string_8;
			settingDota2_0.Username = string_8;
		}
	}

	public string PasswordDota2
	{
		get
		{
			return string_9;
		}
		set
		{
			string_9 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => PasswordDota2));
			setting_0.Password = string_9;
			settingDota2_0.Password = string_9;
		}
	}

	public string PathToExcelFileDota2
	{
		get
		{
			return string_10;
		}
		set
		{
			string_10 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => PathToExcelFileDota2));
			settingDota2_0.PathToExcelFile = string_10;
		}
	}

	public List<string> FrequencyVerificationtTeMainAlgorithmDota2 => list_2;

	public string SelectedTimeToFrequencyVerificationtTeMainAlgorithmDota2
	{
		get
		{
			return _frequencyVerificationtTeMainAlgorithmDota2;
		}
		set
		{
			_frequencyVerificationtTeMainAlgorithmDota2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyVerificationtTeMainAlgorithmDota2));
			settingDota2_0.FrequencyVerificationtTeMainAlgorithm = SelectedTimeToIntFromMainAlgorithm(_frequencyVerificationtTeMainAlgorithmDota2);
		}
	}

	public List<string> FrequencyAlgorithmChecksAutomaxDota2 => list_0;

	public string SelectedTimeToFrequencyAlgorithmChecksAutomaxDota2
	{
		get
		{
			return _frequencyAlgorithmChecksAutomaxDota2;
		}
		set
		{
			_frequencyAlgorithmChecksAutomaxDota2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyVerificationtTeMainAlgorithmDota2));
			settingDota2_0.FrequencyAlgorithmChecksAutomax = SelectedTimeToInt(_frequencyAlgorithmChecksAutomaxDota2);
		}
	}

	public List<string> FrequencyAlgorithmChecksAutoMinDota2 => list_0;

	public string SelectedTimeToFrequencyAlgorithmChecksAutoMinDota2
	{
		get
		{
			return _frequencyAlgorithmChecksAutoMinDota2;
		}
		set
		{
			_frequencyAlgorithmChecksAutoMinDota2 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyAlgorithmChecksAutoMinDota2));
			settingDota2_0.FrequencyAlgorithmChecksAutoMin = SelectedTimeToInt(_frequencyAlgorithmChecksAutoMinDota2);
		}
	}

	public List<string> FrequencyCheckingItemsNotDeliveredDota2 => list_1;

	public string SelectedTimeToFrequencyCheckingItemsNotDeliveredDota2
	{
		get
		{
			return string_11;
		}
		set
		{
			string_11 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<string>((Expression<Func<string>>)(() => SelectedTimeToFrequencyCheckingItemsNotDeliveredDota2));
			settingDota2_0.FrequencyCheckingItemsNotDelivered = SelectedTimeToIntForAutoSell(string_11);
		}
	}

	public float PercentageBeforeTheDiscountIsAddedDota2
	{
		get
		{
			return float_15;
		}
		set
		{
			float_15 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => PercentageBeforeTheDiscountIsAddedDota2));
			settingDota2_0.PercentageBeforeTheDiscountIsAdded = float_15;
		}
	}

	public float MaxThresholdInTheAbsenceThingOnSaleDota2
	{
		get
		{
			return float_16;
		}
		set
		{
			float_16 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MaxThresholdInTheAbsenceThingOnSaleDota2));
			settingDota2_0.MaxThresholdInTheAbsenceThingOnSale = float_16;
		}
	}

	public float MaxThresholdYPercentageDota2
	{
		get
		{
			return float_17;
		}
		set
		{
			float_17 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MaxThresholdYPercentageDota2));
			settingDota2_0.MaxThresholdYPercentage = float_17;
		}
	}

	public float MinThresholdYPercentageDota2
	{
		get
		{
			return float_18;
		}
		set
		{
			float_18 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MinThresholdYPercentageDota2));
			settingDota2_0.MinThresholdYPercentage = float_18;
		}
	}

	public float DefaultMinThresholdDota2
	{
		get
		{
			return float_19;
		}
		set
		{
			float_19 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => DefaultMinThresholdDota2));
			settingDota2_0.DefaultMinThreshold = float_19;
		}
	}

	public float DefaultMaxThresholdDota2
	{
		get
		{
			return float_20;
		}
		set
		{
			float_20 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => DefaultMaxThresholdDota2));
			settingDota2_0.DefaultMaxThreshold = float_20;
		}
	}

	public float MinDiffForCancelOrderPercentageDota2
	{
		get
		{
			return float_21;
		}
		set
		{
			float_21 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => MinDiffForCancelOrderPercentageDota2));
			settingDota2_0.MinDiffForCancelOrderPercentage = float_21;
		}
	}

	public float IncreaseMaxThresholForDota2
	{
		get
		{
			return float_22;
		}
		set
		{
			float_22 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => IncreaseMaxThresholForDota2));
			settingDota2_0.IncreaseMaxThresholFor = float_22;
		}
	}

	public float DecreaseMinThresholdForDota2
	{
		get
		{
			return float_23;
		}
		set
		{
			float_23 = value;
			((PropertyChangedBase)this).NotifyOfPropertyChange<float>((Expression<Func<float>>)(() => DecreaseMinThresholdForDota2));
			settingDota2_0.DecreaseMinThresholdFor = float_23;
		}
	}

	public void ChangeTabIndex(int newTabIndex)
	{
		try
		{
			switch (newTabIndex)
			{
			case 1:
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new ChangeDbIndexDota2());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new ChangeSellIndexDota2());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new ChangeOrdersIndexDota2());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SellSumDota2());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new OrdersSumDota2());
				break;
			case 0:
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new ChangeDbIndexCsgo());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new ChangeSellIndexCsgo());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new ChangeOrdersIndexCsgo());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new SellSumCsgo());
				EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new OrdersSumCsgo());
				break;
			}
		}
		catch (OperationCanceledException)
		{
		}
	}

	public void Handle(ChangeSettingsIndexCsgo message)
	{
		TabIndex = 0;
	}

	public void Handle(ChangeSettingsIndexDota2 message)
	{
		TabIndex = 1;
	}

	public void ControlLastBuyCountDays()
	{
		if (LastBuyCountDays < 1)
		{
			LastBuyCountDays = 1;
		}
		if (LastBuyCountDaysDota2 < 1)
		{
			LastBuyCountDaysDota2 = 1;
		}
	}

	public void ControlMaxPointsFitsProfit()
	{
		if (MaxPointsFitsProfit > 100f)
		{
			MaxPointsFitsProfit = 100f;
		}
		if (MaxPointsFitsProfitDota2 > 100f)
		{
			MaxPointsFitsProfitDota2 = 100f;
		}
	}

	public void ControlPositionOfIgnorFirstOrder()
	{
		if (PositionOfIgnorFirstOrder < 2)
		{
			PositionOfIgnorFirstOrder = 2;
		}
		if (PositionOfIgnorFirstOrderDota2 < 2)
		{
			PositionOfIgnorFirstOrderDota2 = 2;
		}
	}

	public void ControlCountForMinThresholdColor()
	{
		if (CountForMinThresholdColor < 1)
		{
			CountForMinThresholdColor = 1;
		}
		if (CountForMinThresholdColorDota2 < 1)
		{
			CountForMinThresholdColorDota2 = 1;
		}
	}

	public void ControlHistoryTo()
	{
		if (ImportHistoryTo > 500)
		{
			ImportHistoryTo = 500;
		}
		if (ImportHistoryToDota2 > 500)
		{
			ImportHistoryToDota2 = 500;
		}
		if (BuysCountTo > 500)
		{
			BuysCountTo = 500;
		}
		if (BuysCountToDota2 > 500)
		{
			BuysCountToDota2 = 500;
		}
	}

	public SettingsViewModel(IEventAggregator events, ILog logger, IApiMarketCsgoCom apiMarketCsgoCom, GInterface2 apiMarketDota2Net, IMessageBox messageBox, GInterface1 exporter)
	{
		Class24.nhQmSIPz7n4eU();
		setting_0 = new Setting();
		settingDota2_0 = new SettingDota2();
		list_0 = new List<string> { "15", "30", "60", "120", "240" };
		list_1 = new List<string> { "5", "10", "15", "20", "25" };
		list_2 = new List<string> { "1/3", "1/2", "1", "2", "4", "6", "12", "24", "48" };
		string_0 = string.Empty;
		string_1 = string.Empty;
		string_2 = string.Empty;
		string_3 = string.Empty;
		string_4 = string.Empty;
		float_0 = 1f;
		_frequencyVerificationtTeMainAlgorithm = "2 дня";
		_frequencyAlgorithmChecksAutomax = "1 день";
		_frequencyAlgorithmChecksAutoMin = "1 день";
		string_5 = "1 день";
		float_2 = 1.5f;
		string_6 = string.Empty;
		string_7 = string.Empty;
		string_8 = string.Empty;
		string_9 = string.Empty;
		string_10 = string.Empty;
		_frequencyVerificationtTeMainAlgorithmDota2 = "2 дня";
		_frequencyAlgorithmChecksAutomaxDota2 = "1 день";
		_frequencyAlgorithmChecksAutoMinDota2 = "1 день";
		string_11 = "1 день";
		float_15 = 1.5f;
		((Screen)this)._002Ector();
		ilog_0 = logger;
		iapiMarketCsgoCom_0 = apiMarketCsgoCom;
		ginterface2_0 = apiMarketDota2Net;
		imessageBox_0 = messageBox;
		ginterface1_0 = exporter;
		ieventAggregator_0 = events;
		ieventAggregator_0.Subscribe((object)this);
		if (!Execute.get_InDesignMode())
		{
			method_0();
		}
	}

	private async Task method_0()
	{
		using (StreamReader streamReader = new StreamReader("settings.json"))
		{
			string text = streamReader.ReadToEnd();
			jobject_0 = JObject.Parse(text);
			setting_0.Username = ((object)jobject_0.get_Item("Username")).ToString();
			setting_0.Password = ((object)jobject_0.get_Item("Password")).ToString();
			setting_0.ApiKeySteam = ((object)jobject_0.get_Item("ApiKeySteam")).ToString();
			setting_0.ApiKey = ((object)jobject_0.get_Item("ApiKey")).ToString();
			settingDota2_0.Username = ((object)jobject_0.get_Item("Username")).ToString();
			settingDota2_0.Password = ((object)jobject_0.get_Item("Password")).ToString();
			settingDota2_0.ApiKeySteam = ((object)jobject_0.get_Item("ApiKeySteam")).ToString();
			settingDota2_0.ApiKey = ((object)jobject_0.get_Item("ApiKey")).ToString();
		}
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new GetSettigsForSteamTrader
		{
			setting = setting_0,
			settingDota2 = settingDota2_0
		});
		AnalyticsTimeFlag = setting_0.AnalyticsTimeFlag;
		ExposeTimeFlag = setting_0.ExposeTimeFlag;
		LoggerFlag = setting_0.LoggerFlag;
		DeleteOrdersFlag = setting_0.DeleteOrdersFlag;
		FrequencyAlgorithmChecksAutomaxFlag = setting_0.FrequencyAlgorithmChecksAutomaxFlag;
		FrequencyAlgorithmChecksAutoMinFlag = setting_0.FrequencyAlgorithmChecksAutoMinFlag;
		AdvancedSettingsFlag = setting_0.AdvancedSettingsFlag;
		MaxOrdersFlag = setting_0.MaxOrdersFlag;
		MaxStatTrakFlag = setting_0.MaxStatTrakFlag;
		MaxKniveFlag = setting_0.MaxKniveFlag;
		MaxStatTrakKniveFlag = setting_0.MaxStatTrakKniveFlag;
		MaxStickersFlag = setting_0.MaxStickersFlag;
		MaxCaseFlag = setting_0.MaxCaseFlag;
		MaxItemsWithStickersFlag = setting_0.MaxItemsWithStickersFlag;
		IgnorFirstOrderFlag = setting_0.IgnorFirstOrderFlag;
		IgnorFarOrderFlag = setting_0.IgnorFarOrderFlag;
		BlueOrderFlag = setting_0.BlueOrderFlag;
		BlueSellFlag = setting_0.BlueSellFlag;
		RedOrderFlag = setting_0.RedOrderFlag;
		RedSellFlag = setting_0.RedSellFlag;
		ImportCountFlag = setting_0.ImportCountFlag;
		ImportHistoryFlag = setting_0.ImportHistoryFlag;
		AddImportFlag = setting_0.AddImportFlag;
		BlueOrderPercent = setting_0.BlueOrderPercent;
		CountForMinThresholdColor = setting_0.CountForMinThresholdColor;
		BiggerProfit = setting_0.BiggerProfit;
		BiggerProfitMoney = setting_0.BiggerProfitMoney;
		Months = setting_0.Months;
		BuysCountFrom = setting_0.BuysCountFrom;
		BuysCountTo = setting_0.BuysCountTo;
		MaxOrdersCount = setting_0.MaxOrdersCount;
		MaxStatTrakCount = setting_0.MaxStatTrakCount;
		MaxKniveCount = setting_0.MaxKniveCount;
		MaxStatTrakKniveCount = setting_0.MaxStatTrakKniveCount;
		MaxStickersCount = setting_0.MaxStickersCount;
		MaxCaseCount = setting_0.MaxCaseCount;
		MaxItemsWithStickersCount = setting_0.MaxItemsWithStickersCount;
		PositionOfIgnorFirstOrder = setting_0.PositionOfIgnorFirstOrder;
		PercentOfIgnorFirstOrder = setting_0.PercentOfIgnorFirstOrder;
		ImportCountFrom = setting_0.ImportCountFrom;
		ImportCountTo = setting_0.ImportCountTo;
		ImportHistoryFrom = setting_0.ImportHistoryFrom;
		ImportHistoryTo = setting_0.ImportHistoryTo;
		OrdersForAnalytics = setting_0.OrdersForAnalytics;
		MinProfitMoney = setting_0.MinProfitMoney;
		BuyPriceFrom = setting_0.BuyPriceFrom;
		BuyPriceTo = setting_0.BuyPriceTo;
		CountForException = setting_0.CountForException;
		DaysForException = setting_0.DaysForException;
		CountOnSellLimit = setting_0.CountOnSellLimit;
		MaxPointsFitsProfit = setting_0.MaxPointsFitsProfit;
		ApiKey = setting_0.ApiKey;
		ApiKeySteam = setting_0.ApiKeySteam;
		Username = setting_0.Username;
		Password = setting_0.Password;
		ApiTimeoutMs = setting_0.ApiTimeoutMs;
		LastBuyCountDays = setting_0.LastBuyCountDays;
		MaxThresholdYPercentage = setting_0.MaxThresholdYPercentage;
		MinThresholdYPercentage = setting_0.MinThresholdYPercentage;
		SelectedTimeToFrequencyVerificationtTeMainAlgorithm = SelectedTimeToStringFromMainAlgorithm(setting_0.FrequencyVerificationtTeMainAlgorithm);
		SelectedTimeToFrequencyAlgorithmChecksAutomax = SelectedTimeToString(setting_0.FrequencyAlgorithmChecksAutomax);
		SelectedTimeToFrequencyAlgorithmChecksAutoMin = SelectedTimeToString(setting_0.FrequencyAlgorithmChecksAutoMin);
		SelectedTimeToFrequencyCheckingItemsNotDelivered = SelectedTimeToStringForAutoSell(setting_0.FrequencyCheckingItemsNotDelivered);
		PercentageBeforeTheDiscountIsAdded = setting_0.PercentageBeforeTheDiscountIsAdded;
		DefaultMinThreshold = setting_0.DefaultMinThreshold;
		DefaultMaxThreshold = setting_0.DefaultMaxThreshold;
		AnalyticsTimeFlagDota2 = settingDota2_0.AnalyticsTimeFlag;
		ExposeTimeFlagDota2 = settingDota2_0.ExposeTimeFlag;
		LoggerFlagDota2 = settingDota2_0.LoggerFlag;
		DeleteOrdersFlagDota2 = settingDota2_0.DeleteOrdersFlag;
		FrequencyAlgorithmChecksAutomaxFlagDota2 = settingDota2_0.FrequencyAlgorithmChecksAutomaxFlag;
		FrequencyAlgorithmChecksAutoMinFlagDota2 = settingDota2_0.FrequencyAlgorithmChecksAutoMinFlag;
		AdvancedSettingsFlagDota2 = settingDota2_0.AdvancedSettingsFlag;
		MaxOrdersFlagDota2 = settingDota2_0.MaxOrdersFlag;
		MaxUncommonFlagDota2 = settingDota2_0.MaxUncommonFlagDota2;
		MaxRareFlagDota2 = settingDota2_0.MaxRareFlagDota2;
		MaxMythicalFlagDota2 = settingDota2_0.MaxMythicalFlagDota2;
		MaxLegendaryFlagDota2 = settingDota2_0.MaxLegendaryFlagDota2;
		MaxImmortalFlagDota2 = settingDota2_0.MaxImmortalFlagDota2;
		MaxAncientFlagDota2 = settingDota2_0.MaxAncientFlagDota2;
		MaxArcanaFlagDota2 = settingDota2_0.MaxArcanaFlagDota2;
		IgnorFirstOrderFlagDota2 = settingDota2_0.IgnorFirstOrderFlag;
		IgnorFarOrderFlagDota2 = settingDota2_0.IgnorFarOrderFlag;
		BlueOrderFlagDota2 = settingDota2_0.BlueOrderFlag;
		BlueSellFlagDota2 = settingDota2_0.BlueSellFlag;
		RedOrderFlagDota2 = settingDota2_0.RedOrderFlag;
		RedSellFlagDota2 = settingDota2_0.RedSellFlag;
		ImportCountFlagDota2 = settingDota2_0.ImportCountFlag;
		ImportHistoryFlagDota2 = settingDota2_0.ImportHistoryFlag;
		AddImportFlagDota2 = settingDota2_0.AddImportFlag;
		BlueOrderPercentDota2 = settingDota2_0.BlueOrderPercent;
		CountForMinThresholdColorDota2 = settingDota2_0.CountForMinThresholdColor;
		BiggerProfitDota2 = settingDota2_0.BiggerProfit;
		BiggerProfitMoneyDota2 = settingDota2_0.BiggerProfitMoney;
		MonthsDota2 = settingDota2_0.Months;
		BuysCountFromDota2 = settingDota2_0.BuysCountFrom;
		BuysCountToDota2 = settingDota2_0.BuysCountTo;
		MaxOrdersCountDota2 = settingDota2_0.MaxOrdersCount;
		MaxUncommonCountDota2 = settingDota2_0.MaxUncommonCountDota2;
		MaxRareCountDota2 = settingDota2_0.MaxRareCountDota2;
		MaxMythicalCountDota2 = settingDota2_0.MaxMythicalCountDota2;
		MaxLegendaryCountDota2 = settingDota2_0.MaxLegendaryCountDota2;
		MaxImmortalCountDota2 = settingDota2_0.MaxImmortalCountDota2;
		MaxAncientCountDota2 = settingDota2_0.MaxAncientCountDota2;
		MaxArcanaCountDota2 = settingDota2_0.MaxArcanaCountDota2;
		PositionOfIgnorFirstOrderDota2 = settingDota2_0.PositionOfIgnorFirstOrder;
		PercentOfIgnorFirstOrderDota2 = settingDota2_0.PercentOfIgnorFirstOrder;
		ImportCountFromDota2 = settingDota2_0.ImportCountFrom;
		ImportCountToDota2 = settingDota2_0.ImportCountTo;
		ImportHistoryFromDota2 = settingDota2_0.ImportHistoryFrom;
		ImportHistoryToDota2 = settingDota2_0.ImportHistoryTo;
		OrdersForAnalyticsDota2 = settingDota2_0.OrdersForAnalytics;
		MinProfitMoneyDota2 = settingDota2_0.MinProfitMoney;
		BuyPriceFromDota2 = settingDota2_0.BuyPriceFrom;
		BuyPriceToDota2 = settingDota2_0.BuyPriceTo;
		CountForExceptionDota2 = settingDota2_0.CountForException;
		DaysForExceptionDota2 = settingDota2_0.DaysForException;
		CountOnSellLimitDota2 = settingDota2_0.CountOnSellLimit;
		MaxPointsFitsProfitDota2 = settingDota2_0.MaxPointsFitsProfit;
		ApiKeyDota2 = settingDota2_0.ApiKey;
		ApiKeySteamDota2 = settingDota2_0.ApiKeySteam;
		UsernameDota2 = settingDota2_0.Username;
		PasswordDota2 = settingDota2_0.Password;
		ApiTimeoutMsDota2 = settingDota2_0.ApiTimeoutMs;
		LastBuyCountDaysDota2 = settingDota2_0.LastBuyCountDays;
		MaxThresholdYPercentageDota2 = settingDota2_0.MaxThresholdYPercentage;
		MinThresholdYPercentageDota2 = settingDota2_0.MinThresholdYPercentage;
		SelectedTimeToFrequencyVerificationtTeMainAlgorithmDota2 = SelectedTimeToStringFromMainAlgorithm(settingDota2_0.FrequencyVerificationtTeMainAlgorithm);
		SelectedTimeToFrequencyAlgorithmChecksAutomaxDota2 = SelectedTimeToString(settingDota2_0.FrequencyAlgorithmChecksAutomax);
		SelectedTimeToFrequencyAlgorithmChecksAutoMinDota2 = SelectedTimeToString(settingDota2_0.FrequencyAlgorithmChecksAutoMin);
		SelectedTimeToFrequencyCheckingItemsNotDeliveredDota2 = SelectedTimeToStringForAutoSell(settingDota2_0.FrequencyCheckingItemsNotDelivered);
		PercentageBeforeTheDiscountIsAddedDota2 = settingDota2_0.PercentageBeforeTheDiscountIsAdded;
		DefaultMinThresholdDota2 = settingDota2_0.DefaultMinThreshold;
		DefaultMaxThresholdDota2 = settingDota2_0.DefaultMaxThreshold;
	}

	public void AnalyticsTimeClick()
	{
		AnalyticsTimeFlag = !AnalyticsTimeFlag;
	}

	public void ExposeTimeClick()
	{
		ExposeTimeFlag = !ExposeTimeFlag;
	}

	public void FrequencyAlgorithmChecksAutomaxClick()
	{
		FrequencyAlgorithmChecksAutomaxFlag = !FrequencyAlgorithmChecksAutomaxFlag;
	}

	public void FrequencyAlgorithmChecksAutoMinClick()
	{
		FrequencyAlgorithmChecksAutoMinFlag = !FrequencyAlgorithmChecksAutoMinFlag;
	}

	public void LoggerClick()
	{
		LoggerFlag = !LoggerFlag;
	}

	public void DeleteOrdersClick()
	{
		DeleteOrdersFlag = !DeleteOrdersFlag;
	}

	public void AdvancedSettingsClick()
	{
		AdvancedSettingsFlag = !AdvancedSettingsFlag;
	}

	public void MaxOrdersClick()
	{
		MaxOrdersFlag = !MaxOrdersFlag;
	}

	public void MaxStatTrakClick()
	{
		MaxStatTrakFlag = !MaxStatTrakFlag;
	}

	public void MaxKniveClick()
	{
		MaxKniveFlag = !MaxKniveFlag;
	}

	public void MaxStatTrakKniveClick()
	{
		MaxStatTrakKniveFlag = !MaxStatTrakKniveFlag;
	}

	public void MaxStickersClick()
	{
		MaxStickersFlag = !MaxStickersFlag;
	}

	public void MaxCaseClick()
	{
		MaxCaseFlag = !MaxCaseFlag;
	}

	public void MaxItemsWithStickersClick()
	{
		MaxItemsWithStickersFlag = !MaxItemsWithStickersFlag;
	}

	public void IgnorFirstOrderClick()
	{
		IgnorFirstOrderFlag = !IgnorFirstOrderFlag;
	}

	public void IgnorFarOrderFlagClick()
	{
		IgnorFarOrderFlag = !IgnorFarOrderFlag;
	}

	public void BlueOrderClick()
	{
		BlueOrderFlag = !BlueOrderFlag;
	}

	public void BlueSellClick()
	{
		BlueSellFlag = !BlueSellFlag;
	}

	public void RedOrderClick()
	{
		RedOrderFlag = !RedOrderFlag;
	}

	public void RedSellClick()
	{
		RedSellFlag = !RedSellFlag;
	}

	public void ImportCountClick()
	{
		ImportCountFlag = !ImportCountFlag;
	}

	public void ImportHistoryClick()
	{
		ImportHistoryFlag = !ImportHistoryFlag;
	}

	public void AddImportClick()
	{
		AddImportFlag = !AddImportFlag;
	}

	public string SelectedTimeToString(int time)
	{
		string result = string.Empty;
		switch (time)
		{
		case 0:
			result = "15";
			break;
		case 1:
			result = "30";
			break;
		case 2:
			result = "60";
			break;
		case 3:
			result = "120";
			break;
		case 4:
			result = "240";
			break;
		}
		return result;
	}

	public string SelectedTimeToStringForAutoSell(int time)
	{
		string result = string.Empty;
		switch (time)
		{
		case 0:
			result = "5";
			break;
		case 1:
			result = "10";
			break;
		case 2:
			result = "15";
			break;
		case 3:
			result = "20";
			break;
		case 4:
			result = "25";
			break;
		}
		return result;
	}

	public string SelectedTimeToStringFromMainAlgorithm(int time)
	{
		string result = string.Empty;
		switch (time)
		{
		case 0:
			result = "1";
			break;
		case 1:
			result = "2";
			break;
		case 2:
			result = "4";
			break;
		case 3:
			result = "6";
			break;
		case 4:
			result = "12";
			break;
		case 5:
			result = "24";
			break;
		case 6:
			result = "48";
			break;
		case 7:
			result = "1/2";
			break;
		case 8:
			result = "1/3";
			break;
		}
		return result;
	}

	public int SelectedTimeToInt(string time)
	{
		int result = 0;
		switch (time)
		{
		case "15":
			result = 0;
			break;
		case "30":
			result = 1;
			break;
		case "60":
			result = 2;
			break;
		case "120":
			result = 3;
			break;
		case "240":
			result = 4;
			break;
		}
		return result;
	}

	public int SelectedTimeToIntForAutoSell(string time)
	{
		int result = 0;
		switch (time)
		{
		case "5":
			result = 0;
			break;
		case "10":
			result = 1;
			break;
		case "15":
			result = 2;
			break;
		case "20":
			result = 3;
			break;
		case "25":
			result = 4;
			break;
		}
		return result;
	}

	public int SelectedTimeToIntFromMainAlgorithm(string time)
	{
		int result = 0;
		switch (time)
		{
		case "1":
			result = 0;
			break;
		case "2":
			result = 1;
			break;
		case "4":
			result = 2;
			break;
		case "6":
			result = 3;
			break;
		case "12":
			result = 4;
			break;
		case "24":
			result = 5;
			break;
		case "48":
			result = 6;
			break;
		case "1/2":
			result = 7;
			break;
		case "1/3":
			result = 8;
			break;
		}
		return result;
	}

	public void OpenFile()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Expected O, but got Unknown
		OpenFileDialog val = new OpenFileDialog();
		((FileDialog)val).set_DefaultExt(".xlsx");
		((FileDialog)val).set_Filter("Excel (*.xlsx)|*.xlsx");
		val.set_Multiselect(false);
		if (((CommonDialog)val).ShowDialog() == true)
		{
			((FileDialog)val).set_InitialDirectory(Environment.GetFolderPath(Environment.SpecialFolder.Personal));
			string text = (PathToExcelFile = ((FileDialog)val).get_FileName());
		}
	}

	public async void Save()
	{
		jobject_0.set_Item("Username", JToken.op_Implicit(setting_0.Username));
		jobject_0.set_Item("Password", JToken.op_Implicit(setting_0.Password));
		jobject_0.set_Item("ApiKeySteam", JToken.op_Implicit(setting_0.ApiKeySteam));
		jobject_0.set_Item("ApiKey", JToken.op_Implicit(setting_0.ApiKey));
		string contents = JsonConvert.SerializeObject((object)jobject_0);
		File.WriteAllText("settings.json", contents);
		ApiKeyDota2 = ApiKey;
		ApiKeySteamDota2 = ApiKeySteam;
		UsernameDota2 = Username;
		PasswordDota2 = Password;
		try
		{
			await iapiMarketCsgoCom_0.SetSteamAPIKey(ApiKeySteam);
		}
		catch (ApplicationException ex)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn(ex.Message, Array.Empty<object>());
			}
		}
		catch (NullReferenceException ex2)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn(ex2.Message, Array.Empty<object>());
			}
		}
		catch (ArgumentException ex3)
		{
			if (setting_0.LoggerFlag)
			{
				ilog_0.Warn(ex3.Message, Array.Empty<object>());
			}
		}
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new GetSettigsForSteamTrader
		{
			setting = setting_0,
			settingDota2 = settingDota2_0
		});
		imessageBox_0.Show("Настройки сохранены!");
	}

	public void OpenData()
	{
		Process.Start(Const.DataDirectory);
	}

	protected override void OnInitialize()
	{
		((Screen)this).OnInitialize();
	}

	protected override void OnActivate()
	{
		((Screen)this).OnActivate();
	}

	protected override void OnDeactivate(bool close)
	{
		((Screen)this).OnDeactivate(close);
	}

	public void CloseScreen()
	{
		((Screen)this).TryClose((bool?)null);
	}

	public void AnalyticsTimeClickDota2()
	{
		AnalyticsTimeFlagDota2 = !AnalyticsTimeFlagDota2;
	}

	public void ExposeTimeClickDota2()
	{
		ExposeTimeFlagDota2 = !ExposeTimeFlagDota2;
	}

	public void FrequencyAlgorithmChecksAutomaxClickDota2()
	{
		FrequencyAlgorithmChecksAutomaxFlagDota2 = !FrequencyAlgorithmChecksAutomaxFlagDota2;
	}

	public void FrequencyAlgorithmChecksAutoMinClickDota2()
	{
		FrequencyAlgorithmChecksAutoMinFlagDota2 = !FrequencyAlgorithmChecksAutoMinFlagDota2;
	}

	public void LoggerClickDota2()
	{
		LoggerFlagDota2 = !LoggerFlagDota2;
	}

	public void DeleteOrdersClickDota2()
	{
		DeleteOrdersFlagDota2 = !DeleteOrdersFlagDota2;
	}

	public void AdvancedSettingsClickDota2()
	{
		AdvancedSettingsFlagDota2 = !AdvancedSettingsFlagDota2;
	}

	public void MaxOrdersClickDota2()
	{
		MaxOrdersFlagDota2 = !MaxOrdersFlagDota2;
	}

	public void MaxUncommonClickDota2()
	{
		MaxUncommonFlagDota2 = !MaxUncommonFlagDota2;
	}

	public void MaxRareClickDota2()
	{
		MaxRareFlagDota2 = !MaxRareFlagDota2;
	}

	public void MaxMythicalClickDota2()
	{
		MaxMythicalFlagDota2 = !MaxMythicalFlagDota2;
	}

	public void MaxLegendaryClickDota2()
	{
		MaxLegendaryFlagDota2 = !MaxLegendaryFlagDota2;
	}

	public void MaxImmortalClickDota2()
	{
		MaxImmortalFlagDota2 = !MaxImmortalFlagDota2;
	}

	public void MaxAncientClickDota2()
	{
		MaxAncientFlagDota2 = !MaxAncientFlagDota2;
	}

	public void MaxArcanaClickDota2()
	{
		MaxArcanaFlagDota2 = !MaxArcanaFlagDota2;
	}

	public void IgnorFirstOrderClickDota2()
	{
		IgnorFirstOrderFlagDota2 = !IgnorFirstOrderFlagDota2;
	}

	public void IgnorFarOrderFlagClickDota2()
	{
		IgnorFarOrderFlagDota2 = !IgnorFarOrderFlagDota2;
	}

	public void BlueOrderClickDota2()
	{
		BlueOrderFlagDota2 = !BlueOrderFlagDota2;
	}

	public void BlueSellClickDota2()
	{
		BlueSellFlagDota2 = !BlueSellFlagDota2;
	}

	public void RedOrderClickDota2()
	{
		RedOrderFlagDota2 = !RedOrderFlagDota2;
	}

	public void RedSellClickDota2()
	{
		RedSellFlagDota2 = !RedSellFlagDota2;
	}

	public void ImportCountClickDota2()
	{
		ImportCountFlagDota2 = !ImportCountFlagDota2;
	}

	public void ImportHistoryClickDota2()
	{
		ImportHistoryFlagDota2 = !ImportHistoryFlagDota2;
	}

	public void AddImportClickDota2()
	{
		AddImportFlagDota2 = !AddImportFlagDota2;
	}

	public async void SaveDota2()
	{
		ApiKeyDota2 = ApiKey;
		ApiKeySteamDota2 = ApiKeySteam;
		UsernameDota2 = Username;
		PasswordDota2 = Password;
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new GetSettigsForMain
		{
			setting = setting_0,
			settingDota2 = settingDota2_0
		});
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new GetSettigsForOrders
		{
			setting = setting_0,
			settingDota2 = settingDota2_0
		});
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new GetSettigsForSells
		{
			setting = setting_0,
			settingDota2 = settingDota2_0
		});
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new GetSettigsForDB
		{
			setting = setting_0,
			settingDota2 = settingDota2_0
		});
		EventAggregatorExtensions.PublishOnUIThread(ieventAggregator_0, (object)new GetSettigsForSteamTrader
		{
			setting = setting_0,
			settingDota2 = settingDota2_0
		});
		imessageBox_0.Show("Настройки сохранены!");
	}

	public void OpenDataDota2()
	{
		Process.Start(Const.DataDirectory);
	}
}
