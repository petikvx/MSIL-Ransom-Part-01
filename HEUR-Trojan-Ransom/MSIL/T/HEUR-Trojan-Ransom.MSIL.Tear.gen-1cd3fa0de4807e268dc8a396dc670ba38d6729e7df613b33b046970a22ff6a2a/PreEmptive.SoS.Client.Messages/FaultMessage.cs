using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using PreEmptive.Analytics.Common;
using PreEmptive.SoS.Client.Cache;
using PreEmptive.SoS.Client.MessageProxies;

namespace PreEmptive.SoS.Client.Messages;

public class FaultMessage : Message
{
	[CompilerGenerated]
	private string string_0;

	[CompilerGenerated]
	private string string_1;

	[CompilerGenerated]
	private FaultEventType faultEventType_0;

	[CompilerGenerated]
	private Exception exception_0;

	public string Contact
	{
		[CompilerGenerated]
		get
		{
			int num = -10888;
			int num2 = num;
			num = -10888;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return string_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 23616;
			int num2 = num;
			num = 23616;
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

	public string Comment
	{
		[CompilerGenerated]
		get
		{
			int num = -24080;
			int num2 = num;
			num = -24080;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return string_1;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = 12838;
			int num2 = num;
			num = 12838;
			switch (num2 == num)
			{
			}
			if (1 == 0)
			{
			}
			if (0 == 0)
			{
			}
			string_1 = value;
		}
	}

	public FaultEventType FaultEvent
	{
		[CompilerGenerated]
		get
		{
			int num = 19587;
			int num2 = num;
			num = 19587;
			switch (num2 == num)
			{
			default:
				if (1 == 0)
				{
				}
				if (0 == 0)
				{
				}
				return faultEventType_0;
			}
		}
		[CompilerGenerated]
		set
		{
			if (1 == 0)
			{
			}
			int num = -24380;
			int num2 = num;
			num = -24380;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			faultEventType_0 = value;
		}
	}

	public Exception Exception
	{
		[CompilerGenerated]
		get
		{
			int num = 429;
			int num2 = num;
			num = 429;
			switch (num2 == num)
			{
			default:
				if (0 == 0)
				{
				}
				if (1 == 0)
				{
				}
				return exception_0;
			}
		}
		[CompilerGenerated]
		set
		{
			int num = -2512;
			int num2 = num;
			num = -2512;
			switch (num2 == num)
			{
			}
			if (0 == 0)
			{
			}
			if (1 == 0)
			{
			}
			exception_0 = value;
		}
	}

	public FaultMessage(Exception exception_1, StackTrace stackTrace_0, int skip)
		: this(exception_1)
	{
	}

	public FaultMessage(Exception exception_1)
	{
		Exception = exception_1;
	}

	public override void Send(CacheService cache, PlatformClient paclient)
	{
		int num = 6;
		int num2 = -5140;
		int num3 = num2;
		num2 = -5140;
		switch (num3 == num2)
		{
		}
		if (1 == 0)
		{
		}
		if (0 == 0)
		{
		}
		BinaryInfo binary = Message.ConvertBinaryInfo(base.Binary);
		ExtendedKeys keys = Message.ConvertExtendedKeys(GetExtendedKeys());
		bool optInOverride = base.Event.PrivacySetting == PrivacySettings.AlwaysSend;
		paclient.ReportException(new ExceptionInfo(method_0(FaultEvent), Exception, Contact, Comment, Exception.Data["\ude97튮횱틋껂닂뛛닑뻜닻뛗닝긡刷嘵刻"] as string), optInOverride, keys, null, binary);
	}

	private ExceptionType method_0(FaultEventType faultEventType_1)
	{
		while (true)
		{
			int num = 12027;
			int num2 = num;
			num = 12027;
			switch (num2 == num)
			{
			default:
			{
				if (0 == 0)
				{
				}
				num = 1;
				int num3 = num;
				while (true)
				{
					if (true)
					{
					}
					switch (num3)
					{
					case 1:
						break;
					case 2:
						goto IL_0059;
					default:
						goto end_IL_0064;
					case 0:
						return ExceptionType.Uncaught;
					}
					switch (faultEventType_1)
					{
					default:
						num = 2;
						num3 = num;
						continue;
					case FaultEventType.Caught:
						return ExceptionType.Caught;
					case FaultEventType.Uncaught:
						return ExceptionType.Uncaught;
					case FaultEventType.Thrown:
						break;
					}
					goto end_IL_0094;
					IL_0059:
					num = 0;
					num3 = num;
					continue;
					end_IL_0064:
					break;
				}
				continue;
			}
			case false:
			case true:
				break;
				end_IL_0094:
				break;
			}
			break;
		}
		return ExceptionType.Thrown;
	}
}
