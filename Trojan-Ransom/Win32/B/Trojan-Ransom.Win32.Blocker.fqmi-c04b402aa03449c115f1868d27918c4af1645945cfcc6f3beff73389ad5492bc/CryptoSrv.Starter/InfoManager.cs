using System;
using System.Management;

namespace CryptoSrv.Starter;

public class InfoManager
{
	public static string OperationSystem => Environment.OSVersion.VersionString;

	public static int ProcessorCount => Environment.ProcessorCount;

	public static string VideoCardInfo
	{
		get
		{
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_000c: Expected O, but got Unknown
			try
			{
				ManagementObjectSearcher val = new ManagementObjectSearcher("SELECT * FROM Win32_VideoController");
				string text = string.Empty;
				ManagementObjectEnumerator enumerator = val.Get().GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						ManagementBaseObject current = enumerator.get_Current();
						PropertyDataEnumerator enumerator2 = current.get_Properties().GetEnumerator();
						try
						{
							while (enumerator2.MoveNext())
							{
								PropertyData current2 = enumerator2.get_Current();
								if (current2.get_Name() == "Name" && current2.get_Value() != null)
								{
									text = string.Concat(text, current2.get_Value(), " ");
								}
							}
						}
						finally
						{
							if (enumerator2 is IDisposable disposable)
							{
								disposable.Dispose();
							}
						}
					}
				}
				finally
				{
					((IDisposable)enumerator)?.Dispose();
				}
				return text;
			}
			catch (Exception ex)
			{
				return ex.Message;
			}
		}
	}
}
