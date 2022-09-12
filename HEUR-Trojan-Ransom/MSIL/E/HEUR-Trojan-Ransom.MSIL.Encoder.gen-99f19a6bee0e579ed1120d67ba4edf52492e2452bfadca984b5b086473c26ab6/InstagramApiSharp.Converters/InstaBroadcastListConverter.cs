using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastListConverter : IObjectConverter<InstaBroadcastList, List<InstaBroadcastResponse>>
{
	public List<InstaBroadcastResponse> SourceObject { get; set; }

	public InstaBroadcastList Convert()
	{
		InstaBroadcastList instaBroadcastList = new InstaBroadcastList();
		List<InstaBroadcastResponse> sourceObject = SourceObject;
		if (sourceObject != null && sourceObject.Count > 0)
		{
			foreach (InstaBroadcastResponse item in SourceObject)
			{
				instaBroadcastList.Add(ConvertersFabric.Instance.GetBroadcastConverter(item).Convert());
			}
			return instaBroadcastList;
		}
		return instaBroadcastList;
	}
}
