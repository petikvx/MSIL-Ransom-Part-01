using System;
using System.Linq;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaProductInfoConverter : IObjectConverter<InstaProductInfo, InstaProductInfoResponse>
{
	public InstaProductInfoResponse SourceObject { get; set; }

	public InstaProductInfo Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaProductInfo instaProductInfo = new InstaProductInfo
		{
			Product = ConvertersFabric.Instance.GetProductConverter(SourceObject.Product).Convert(),
			User = ConvertersFabric.Instance.GetUserShortConverter(SourceObject.User).Convert()
		};
		if (SourceObject.OtherProductItems != null && SourceObject.OtherProductItems.Any())
		{
			foreach (InstaProductResponse otherProductItem in SourceObject.OtherProductItems)
			{
				instaProductInfo.OtherProducts.Add(ConvertersFabric.Instance.GetProductConverter(otherProductItem).Convert());
			}
		}
		if (SourceObject.MoreFromBusiness != null)
		{
			instaProductInfo.MoreFromBusiness = ConvertersFabric.Instance.GetProductMediaListConverter(SourceObject.MoreFromBusiness).Convert();
		}
		return instaProductInfo;
	}
}
