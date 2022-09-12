using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastTopLiveStatusListConverter : IObjectConverter<InstaBroadcastTopLiveStatusList, InstaBroadcastTopLiveStatusResponse>
{
	public InstaBroadcastTopLiveStatusResponse SourceObject { get; set; }

	public InstaBroadcastTopLiveStatusList Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaBroadcastTopLiveStatusList instaBroadcastTopLiveStatusList = new InstaBroadcastTopLiveStatusList();
		try
		{
			List<InstaBroadcastStatusItemResponse> broadcastStatusItems = SourceObject.BroadcastStatusItems;
			if (broadcastStatusItems != null && broadcastStatusItems.Count > 0)
			{
				foreach (InstaBroadcastStatusItemResponse broadcastStatusItem in SourceObject.BroadcastStatusItems)
				{
					instaBroadcastTopLiveStatusList.Add(ConvertersFabric.Instance.GetBroadcastStatusItemConverter(broadcastStatusItem).Convert());
				}
				return instaBroadcastTopLiveStatusList;
			}
			return instaBroadcastTopLiveStatusList;
		}
		catch
		{
			return instaBroadcastTopLiveStatusList;
		}
	}
}
