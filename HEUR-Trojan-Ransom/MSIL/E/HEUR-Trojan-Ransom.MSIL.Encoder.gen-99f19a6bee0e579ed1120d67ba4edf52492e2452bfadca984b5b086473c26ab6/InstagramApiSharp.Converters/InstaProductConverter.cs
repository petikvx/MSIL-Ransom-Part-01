using System;
using System.Collections.Generic;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaProductConverter : IObjectConverter<InstaProduct, InstaProductResponse>
{
	public InstaProductResponse SourceObject { get; set; }

	public InstaProduct Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		InstaProduct instaProduct = new InstaProduct
		{
			CheckoutStyle = SourceObject.CheckoutStyle,
			CurrentPrice = SourceObject.CurrentPrice,
			ExternalUrl = SourceObject.ExternalUrl,
			FullPrice = SourceObject.FullPrice,
			HasViewerSaved = SourceObject.HasViewerSaved,
			Merchant = ConvertersFabric.Instance.GetMerchantConverter(SourceObject.Merchant).Convert(),
			Name = SourceObject.Name,
			Price = SourceObject.Price,
			ProductId = SourceObject.ProductId,
			ReviewStatus = SourceObject.ReviewStatus,
			CurrentPriceStripped = SourceObject.CurrentPriceStripped,
			FullPriceStripped = SourceObject.FullPriceStripped,
			ProductAppealReviewStatus = SourceObject.ProductAppealReviewStatus
		};
		InstaProductImageResponse mainImage = SourceObject.MainImage;
		if (mainImage != null && mainImage.Images?.Candidates?.Count > 0)
		{
			foreach (ImageResponse candidate in SourceObject.MainImage.Images.Candidates)
			{
				try
				{
					instaProduct.MainImage.Add(new InstaImage(candidate.Url, int.Parse(candidate.Width), int.Parse(candidate.Height)));
				}
				catch
				{
				}
			}
		}
		InstaProductImageResponse thumbnailImage = SourceObject.ThumbnailImage;
		if (thumbnailImage != null && thumbnailImage.Images?.Candidates?.Count > 0)
		{
			foreach (ImageResponse candidate2 in SourceObject.ThumbnailImage.Images.Candidates)
			{
				try
				{
					instaProduct.ThumbnailImage.Add(new InstaImage(candidate2.Url, int.Parse(candidate2.Width), int.Parse(candidate2.Height)));
				}
				catch
				{
				}
			}
		}
		List<InstaProductImageResponse> productImages = SourceObject.ProductImages;
		if (productImages != null && productImages.Count > 0)
		{
			foreach (InstaProductImageResponse productImage in SourceObject.ProductImages)
			{
				if (productImage != null && productImage.Images?.Candidates?.Count > 0)
				{
					foreach (ImageResponse candidate3 in productImage.Images.Candidates)
					{
						try
						{
							instaProduct.ThumbnailImage.Add(new InstaImage(candidate3.Url, int.Parse(candidate3.Width), int.Parse(candidate3.Height)));
						}
						catch
						{
						}
					}
				}
			}
			return instaProduct;
		}
		return instaProduct;
	}
}
