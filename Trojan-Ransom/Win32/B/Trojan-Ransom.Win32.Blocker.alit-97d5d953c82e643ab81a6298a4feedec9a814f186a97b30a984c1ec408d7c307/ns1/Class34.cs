using System;
using System.Net;
using System.Threading;
using ns3;

namespace ns1;

internal class Class34
{
	internal sealed class Class36
	{
		internal readonly Class34 class34_0;

		internal readonly byte[] byte_0;

		internal readonly Class46 class46_0;

		internal readonly Class38 class38_0;

		public bool bool_0 = true;

		public Class36(Class34 reportSender, byte[] encryptedData, Class46 services, Class38 notificationEmailSettings)
		{
			class34_0 = reportSender;
			class38_0 = notificationEmailSettings;
			class46_0 = services;
			byte_0 = encryptedData;
		}
	}

	internal sealed class Class37
	{
		internal readonly Class34 class34_0;

		public bool bool_0;

		public Class37(Class34 reportSender)
		{
			class34_0 = reportSender;
		}
	}

	internal sealed class Class38
	{
		public static Class38 class38_0 = new Class38(null, null, null);

		internal readonly string string_0;

		internal readonly string string_1;

		internal readonly string string_2;

		public string BuildFriendlyNumber => string_2;

		public string AppFriendlyName => string_1;

		public string EmailAddress => string_0;

		public Class38(string emailAddress, string appFriendlyName, string buildFriendlyNumber)
		{
			string_0 = emailAddress;
			string_2 = buildFriendlyNumber;
			string_1 = appFriendlyName;
		}
	}

	protected const string string_0 = "{100fd8cd-4fe2-410e-8c33-ae1af08ef31d}";

	private const string string_1 = "{be78a0c5-c47c-4127-a428-52bdc580a02f}";

	private const string string_2 = "{bf13b64c-b3d2-4165-b3f5-7f852d4744cf}";

	internal IWebProxy iwebProxy_0;

	internal Delegate3 delegate3_0;

	public event Delegate3 SendingReportFeedback
	{
		add
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Combine(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
		remove
		{
			Delegate3 @delegate = delegate3_0;
			Delegate3 delegate2;
			do
			{
				delegate2 = @delegate;
				Delegate3 value2 = (Delegate3)Delegate.Remove(delegate2, value);
				@delegate = Interlocked.CompareExchange(ref delegate3_0, value2, delegate2);
			}
			while ((object)@delegate != delegate2);
		}
	}
}
