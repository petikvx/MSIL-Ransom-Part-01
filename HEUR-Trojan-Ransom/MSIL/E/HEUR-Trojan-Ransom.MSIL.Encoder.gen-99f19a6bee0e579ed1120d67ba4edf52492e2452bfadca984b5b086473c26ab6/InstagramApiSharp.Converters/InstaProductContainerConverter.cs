using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaProductContainerConverter : IObjectConverter<InstaProductTag, InstaProductContainerResponse>
{
	public InstaProductContainerResponse SourceObject { get; set; }

	public InstaProductTag Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaProductTag instaProductTag = new InstaProductTag
		{
			Product = ConvertersFabric.Instance.GetProductConverter(SourceObject.Product).Convert()
		};
		if (SourceObject.Position != null)
		{
			instaProductTag.Position = new InstaPosition(SourceObject.Position[0], SourceObject.Position[1]);
		}
		return instaProductTag;
	}
}
