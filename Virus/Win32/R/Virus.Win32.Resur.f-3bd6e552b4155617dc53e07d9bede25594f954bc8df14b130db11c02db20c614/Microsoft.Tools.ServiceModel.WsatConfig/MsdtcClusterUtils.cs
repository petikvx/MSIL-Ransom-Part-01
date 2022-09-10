using System;
using System.Collections.Generic;
using System.Security.Permissions;
using System.Text;

namespace Microsoft.Tools.ServiceModel.WsatConfig;

internal static class MsdtcClusterUtils
{
	private const string MsdtcResourceTypeName = "Distributed Transaction Coordinator";

	private static string clusterName;

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static bool IsClusterServer(string machineName)
	{
		SafeHCluster safeHCluster = SafeNativeMethods.OpenCluster(Utilities.IsLocalMachineName(machineName) ? null : machineName);
		bool flag = false;
		using (safeHCluster)
		{
			return !safeHCluster.IsInvalid;
		}
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	internal static SafeHResource GetTransactionManagerClusterResource(string virtualServerName, out string[] nodes)
	{
		nodes = null;
		SafeHCluster safeHCluster = SafeNativeMethods.OpenCluster(null);
		if (safeHCluster.IsInvalid)
		{
			return null;
		}
		using (safeHCluster)
		{
			if (Utilities.OSMajor <= 5 && Utilities.IsLocalMachineName(virtualServerName))
			{
				virtualServerName = GetClusterName(safeHCluster);
			}
			SafeHClusEnum safeHClusEnum = SafeNativeMethods.ClusterOpenEnum(safeHCluster, ClusterEnum.Resource);
			if (safeHClusEnum.IsInvalid)
			{
				return null;
			}
			using (safeHClusEnum)
			{
				uint num = 0u;
				bool resourceFromEnumeration;
				do
				{
					string theResourceName = string.Empty;
					if (!(resourceFromEnumeration = GetResourceFromEnumeration(safeHCluster, safeHClusEnum, num, out var hResource, out theResourceName)))
					{
						continue;
					}
					if (IsTransactionManager(hResource))
					{
						string resourceNetworkName = GetResourceNetworkName(hResource);
						Utilities.Log("Resource network name: " + resourceNetworkName);
						if (Utilities.SafeCompare(resourceNetworkName, virtualServerName))
						{
							nodes = GetClusterNodes(safeHCluster);
							return hResource;
						}
					}
					hResource.Dispose();
					num++;
				}
				while (resourceFromEnumeration);
			}
		}
		return null;
	}

	private static string GetClusterName(SafeHCluster hCluster)
	{
		if (clusterName == null)
		{
			uint lpcchClusterName = 255u;
			StringBuilder stringBuilder = new StringBuilder(255);
			int clusterInformation = SafeNativeMethods.GetClusterInformation(hCluster, stringBuilder, ref lpcchClusterName, IntPtr.Zero);
			if ((clusterInformation != 0L || clusterInformation == 234L) && clusterInformation == 234L)
			{
				stringBuilder = new StringBuilder((int)lpcchClusterName);
				clusterInformation = SafeNativeMethods.GetClusterInformation(hCluster, stringBuilder, ref lpcchClusterName, IntPtr.Zero);
				if (clusterInformation != 0L)
				{
					return null;
				}
			}
			clusterName = stringBuilder.ToString();
		}
		return clusterName;
	}

	private static bool IsTransactionManager(SafeHResource hResource)
	{
		Utilities.Log("Entered IsTransactionManager - ");
		string resourceType = GetResourceType(hResource);
		Utilities.Log("Resource type name: " + resourceType);
		return string.CompareOrdinal(resourceType, "Distributed Transaction Coordinator") == 0;
	}

	private static string GetResourceType(SafeHResource hResource)
	{
		return IssueClusterResourceControlString(hResource, ClusterResourceControlCode.GetResourceType);
	}

	private static string GetResourceNetworkName(SafeHResource hResource)
	{
		uint nSize = 64u;
		StringBuilder stringBuilder = new StringBuilder(64);
		if (SafeNativeMethods.GetClusterResourceNetworkName(hResource, stringBuilder, ref nSize))
		{
			return stringBuilder.ToString();
		}
		return null;
	}

	[SecurityPermission(SecurityAction.LinkDemand, UnmanagedCode = true)]
	private static bool GetResourceFromEnumeration(SafeHCluster hCluster, SafeHClusEnum hEnum, uint index, out SafeHResource hResource, out string theResourceName)
	{
		uint lpcchName = 0u;
		hResource = null;
		theResourceName = string.Empty;
		uint lpdwType;
		switch (SafeNativeMethods.ClusterEnum(hEnum, index, out lpdwType, null, ref lpcchName))
		{
		case 259u:
			return false;
		case 0u:
		case 234u:
		{
			StringBuilder stringBuilder = new StringBuilder((int)(++lpcchName));
			if (SafeNativeMethods.ClusterEnum(hEnum, index, out lpdwType, stringBuilder, ref lpcchName) == 0)
			{
				string text = stringBuilder.ToString();
				hResource = SafeNativeMethods.OpenClusterResource(hCluster, text);
				if (hResource.IsInvalid)
				{
					hResource = null;
				}
				else
				{
					theResourceName = text;
				}
			}
			break;
		}
		}
		return true;
	}

	private static string[] GetClusterNodes(SafeHCluster hCluster)
	{
		SafeHClusEnum safeHClusEnum = SafeNativeMethods.ClusterOpenEnum(hCluster, ClusterEnum.Node);
		if (safeHClusEnum.IsInvalid)
		{
			return null;
		}
		List<string> list = new List<string>(2);
		using (safeHClusEnum)
		{
			uint num = 0u;
			uint num2;
			do
			{
				uint lpcchName = 0u;
				num2 = SafeNativeMethods.ClusterEnum(safeHClusEnum, num, out var lpdwType, null, ref lpcchName);
				switch (num2)
				{
				case 0u:
				case 234u:
				{
					StringBuilder stringBuilder = new StringBuilder((int)(++lpcchName));
					num2 = SafeNativeMethods.ClusterEnum(safeHClusEnum, num, out lpdwType, stringBuilder, ref lpcchName);
					if (num2 == 0)
					{
						Utilities.Log("Found a node: [" + stringBuilder.ToString() + "]");
						list.Add(stringBuilder.ToString());
					}
					break;
				}
				case 259u:
					goto end_IL_0079;
				}
				num++;
				continue;
				end_IL_0079:
				break;
			}
			while (num2 == 0);
		}
		return list.ToArray();
	}

	private static byte[] IssueClusterResourceControl(SafeHResource hResource, ClusterResourceControlCode code)
	{
		uint lpcbBytesReturned = 0u;
		uint num = SafeNativeMethods.ClusterResourceControl(hResource, IntPtr.Zero, code, IntPtr.Zero, 0u, null, 0u, ref lpcbBytesReturned);
		if (num == 0 || num == 234)
		{
			byte[] array = new byte[lpcbBytesReturned];
			if (SafeNativeMethods.ClusterResourceControl(hResource, IntPtr.Zero, code, IntPtr.Zero, 0u, array, lpcbBytesReturned, ref lpcbBytesReturned) == 0)
			{
				return array;
			}
		}
		return null;
	}

	private static string IssueClusterResourceControlString(SafeHResource hResource, ClusterResourceControlCode code)
	{
		byte[] array = IssueClusterResourceControl(hResource, code);
		if (array == null)
		{
			return null;
		}
		try
		{
			return Encoding.Unicode.GetString(array, 0, array.Length - 2);
		}
		catch (ArgumentException)
		{
			return null;
		}
	}
}
