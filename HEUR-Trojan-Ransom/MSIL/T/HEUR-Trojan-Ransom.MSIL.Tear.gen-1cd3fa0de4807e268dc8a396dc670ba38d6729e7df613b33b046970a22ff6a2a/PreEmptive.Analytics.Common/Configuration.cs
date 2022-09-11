using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PreEmptive.Analytics.Common;

public class Configuration
{
	public class ApplicationStopBehavior
	{
		public int? StopTimeout;

		public int? NeededTimeForSavingAtStop;

		public int? SessionExtensionWindow;

		public bool? DefaultsToSynchronousStop;

		public ApplicationStopBehavior Copy()
		{
			int num = 4642;
			int num2 = num;
			num = 4642;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return (ApplicationStopBehavior)MemberwiseClone();
			}
		}
	}

	public Guid CompanyID;

	public string CompanyName;

	public Guid ApplicationID;

	public string ApplicationType;

	public string ApplicationName;

	public string ApplicationVersion;

	public string InstanceID;

	public bool OptIn = true;

	public Guid DefaultSession;

	public Guid MessageGroup;

	internal IList<string> ilist_0;

	public string Endpoint;

	public bool UseSSL;

	public bool SupportOfflineStorage;

	public int MinimumFailureCount;

	public int MinimumTimeToLive;

	public bool Offline;

	public bool OmitPersonalInfo;

	public bool FullData;

	public int MaximumBatchSize;

	public IAttributeLimiter AttributeLimiter;

	[CompilerGenerated]
	private bool bool_0;

	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private ApplicationStopBehavior applicationStopBehavior_0;

	public bool InstanceIdUserSet
	{
		[CompilerGenerated]
		get
		{
			int num = 30813;
			int num2 = num;
			num = 30813;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return bool_0;
			}
		}
		[CompilerGenerated]
		internal set
		{
			int num = -26536;
			int num2 = num;
			num = -26536;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			bool_0 = value;
		}
	}

	public string GeneratedUserName
	{
		[CompilerGenerated]
		get
		{
			int num = 30237;
			int num2 = num;
			num = 30237;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		internal set
		{
			int num = 24609;
			int num2 = num;
			num = 24609;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			string_0 = value;
		}
	}

	public ApplicationStopBehavior StopBehavior
	{
		[CompilerGenerated]
		get
		{
			int num = 27425;
			int num2 = num;
			num = 27425;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return applicationStopBehavior_0;
			}
		}
		[CompilerGenerated]
		private set
		{
			int num = -22097;
			int num2 = num;
			num = -22097;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			applicationStopBehavior_0 = value;
		}
	}

	public Configuration()
	{
		Endpoint = "\udea1특훿틝꺜닟뛜님뻝늙뛢닜긷刓嘿刮带刿嘤刋湜爡瘗爜繜爥瘗爜渤刿嘱刻帡剸嘟勋껁닅뛓닙뻛님뛕늁꺟튳횡튭\udeb3튱횻튀\uee95\uf2a5\uf697\uf28cﺄ\uf29f\uf691\uf28b\uee84틥훼튭\udea4튵훽틾껇닔뛞닗뻁닞";
		UseSSL = true;
		SupportOfflineStorage = true;
		MinimumFailureCount = 150;
		MinimumTimeToLive = 259200;
		FullData = true;
		MaximumBatchSize = 4190208;
		AttributeLimiter = EndpointAttributeLimits.Common;
		base._002Ector();
		method_0(Guid.Empty, Guid.Empty);
	}

	public Configuration(Guid companyID, Guid applicationID)
	{
		Endpoint = "닅뛝늓뻁늘뛛닀긴刹噽刎帠刳嘗刃渂爂瘛爈縗牘瘥爋渰剸嘁刻帠删嘻勍껗닅뚜닳뻗닅뛁닏꺵튿횼특\udefd튛횷튝\uee81\uf297\uf695\uf297ﺜ\uf291\uf6a1\uf28b\ueea0튠횻튽\udeb7튀훡튀껁닀뛑늑뻢닃뛐닂긻別嘺";
		UseSSL = true;
		SupportOfflineStorage = true;
		MinimumFailureCount = 150;
		MinimumTimeToLive = 259200;
		FullData = true;
		MaximumBatchSize = 4190208;
		AttributeLimiter = EndpointAttributeLimits.Common;
		base._002Ector();
		method_0(companyID, applicationID);
	}

	public Configuration(string companyID, string applicationID)
	{
		Endpoint = "닅뛝늓뻁늘뛛닀긴刹噽刎帠刳嘗刃渂爂瘛爈縗牘瘥爋渰剸嘁刻帠删嘻勍껗닅뚜닳뻗닅뛁닏꺵튿횼특\udefd튛횷튝\uee81\uf297\uf695\uf297ﺜ\uf291\uf6a1\uf28b\ueea0튠횻튽\udeb7튀훡튀껁닀뛑늑뻢닃뛐닂긻別嘺";
		UseSSL = true;
		SupportOfflineStorage = true;
		MinimumFailureCount = 150;
		MinimumTimeToLive = 259200;
		FullData = true;
		MaximumBatchSize = 4190208;
		AttributeLimiter = EndpointAttributeLimits.Common;
		base._002Ector();
		if (!Guid.TryParse(companyID, out var result) || !Guid.TryParse(applicationID, out var result2))
		{
			result = Guid.Empty;
			result2 = Guid.Empty;
		}
		method_0(result, result2);
	}

	private void method_0(Guid guid_0, Guid guid_1)
	{
		int num = 13;
		int num2 = 23166;
		int num3 = num2;
		num2 = 23166;
		switch (num3 == num2)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		CompanyID = guid_0;
		ApplicationID = guid_1;
		ilist_0 = new List<string> { "껚닆뛚", "껂닓뛄닕뻛늟뛓닜께刷嘺刽帮刷噻刡渞爞瘟爆縊爛瘘爕" };
		StopBehavior = new ApplicationStopBehavior();
	}

	public string GetFullEndpointURI()
	{
		int num = 6;
		if (1 == 0)
		{
		}
		int num2 = -18649;
		int num3 = num2;
		num2 = -18649;
		switch (num3 == num2)
		{
		default:
			if (0 == 0)
			{
			}
			return string.Format("\udea9틦횯튔꺝늙뛉늏뻏", new object[2]
			{
				UseSSL ? "\udeba튢횦틞껁" : "\udeba튢횦틞",
				Endpoint
			});
		}
	}

	public Configuration Copy()
	{
		int num = -16357;
		int num2 = num;
		num = -16357;
		switch (num2 == num)
		{
		default:
		{
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			Configuration configuration = (Configuration)MemberwiseClone();
			configuration.StopBehavior = StopBehavior.Copy();
			return configuration;
		}
		}
	}
}
