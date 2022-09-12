using System;
using System.Collections.Generic;

namespace Poshmark_tools;

internal class listing_page_class
{
	public class SizeObj
	{
		public string id { get; set; }

		public string display { get; set; }

		public string display_with_size_set { get; set; }
	}

	public class SizeQuantity
	{
		public string size_id { get; set; }

		public int quantity_available { get; set; }

		public int quantity_reserved { get; set; }

		public int quantity_sold { get; set; }

		public int size_ref { get; set; }

		public SizeObj size_obj { get; set; }

		public List<string> size_set_tags { get; set; }
	}

	public class Inventory
	{
		public string status { get; set; }

		public DateTime status_changed_at { get; set; }

		public List<SizeQuantity> size_quantities { get; set; }

		public int size_quantity_revision { get; set; }

		public bool multi_item { get; set; }
	}

	public class DepartmentObj
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryObj
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryFeatureObj
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class Catalog
	{
		public List<string> category_features { get; set; }

		public string department { get; set; }

		public string category { get; set; }

		public DepartmentObj department_obj { get; set; }

		public CategoryObj category_obj { get; set; }

		public List<CategoryFeatureObj> category_feature_objs { get; set; }
	}

	public class Color
	{
		public string name { get; set; }

		public string rgb { get; set; }
	}

	public class CoverShot
	{
		public string id { get; set; }

		public string picture { get; set; }

		public string path { get; set; }

		public string path_small { get; set; }

		public string path_large { get; set; }

		public string content_type { get; set; }

		public string storage_location { get; set; }

		public string md5_hash { get; set; }

		public DateTime created_at { get; set; }

		public string url { get; set; }

		public string url_small { get; set; }

		public string url_large { get; set; }
	}

	public class Picture
	{
		public string id { get; set; }

		public string picture { get; set; }

		public string path { get; set; }

		public string path_small { get; set; }

		public string path_large { get; set; }

		public string content_type { get; set; }

		public string storage_location { get; set; }

		public string md5_hash { get; set; }

		public DateTime created_at { get; set; }

		public string url { get; set; }

		public string url_small { get; set; }

		public string url_large { get; set; }
	}

	public class PriceAmount
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class OriginalPriceAmount
	{
		public string val { get; set; }

		public string currency_code { get; set; }

		public string currency_symbol { get; set; }
	}

	public class FirstEventShare
	{
		public string event_id { get; set; }

		public DateTime shared_at { get; set; }
	}

	public class Aggregates
	{
		public int shares { get; set; }

		public int comments { get; set; }

		public int likes { get; set; }

		public int active_offers { get; set; }
	}

	public class Comment
	{
		public string id { get; set; }

		public string user_id { get; set; }

		public string comment { get; set; }

		public DateTime created_at { get; set; }

		public string state { get; set; }

		public string creator_id { get; set; }

		public string creator_username { get; set; }

		public string creator_display_handle { get; set; }

		public string creator_full_name { get; set; }

		public string creator_picture_url { get; set; }
	}

	public class Like
	{
		public string user_id { get; set; }

		public DateTime created_at { get; set; }

		public string creator_id { get; set; }

		public string id { get; set; }

		public string creator_username { get; set; }

		public string creator_display_handle { get; set; }

		public string creator_full_name { get; set; }

		public string creator_picture_url { get; set; }

		public string creator_fb_id { get; set; }
	}

	public class OfferData
	{
	}

	public class Department
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryV2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class CategoryFeature
	{
		public string id { get; set; }

		public string display { get; set; }

		public string slug { get; set; }
	}

	public class SizeObj2
	{
		public string id { get; set; }

		public string display { get; set; }

		public string display_with_size_set { get; set; }
	}

	public class BrandObj
	{
		public string id { get; set; }

		public string canonical_name { get; set; }

		public string slug { get; set; }
	}

	public class Data
	{
		public string id { get; set; }

		public string creator_id { get; set; }

		public string status { get; set; }

		public DateTime status_changed_at { get; set; }

		public string origin_domain { get; set; }

		public List<string> destination_domains { get; set; }

		public int publish_count { get; set; }

		public string app { get; set; }

		public string app_version { get; set; }

		public Inventory inventory { get; set; }

		public Catalog catalog { get; set; }

		public List<Color> colors { get; set; }

		public string catalog_source { get; set; }

		public string inventory_unit_id { get; set; }

		public DateTime updated_at { get; set; }

		public string brand { get; set; }

		public CoverShot cover_shot { get; set; }

		public List<Picture> pictures { get; set; }

		public string title { get; set; }

		public string description { get; set; }

		public PriceAmount price_amount { get; set; }

		public OriginalPriceAmount original_price_amount { get; set; }

		public string size { get; set; }

		public string brand_id { get; set; }

		public string category { get; set; }

		public string condition { get; set; }

		public DateTime first_published_at { get; set; }

		public int post_like_page { get; set; }

		public int like_count { get; set; }

		public bool has_offer { get; set; }

		public int share_count { get; set; }

		public FirstEventShare first_event_share { get; set; }

		public DateTime created_at { get; set; }

		public int price { get; set; }

		public int original_price { get; set; }

		public int comment_count { get; set; }

		public int post_comment_page { get; set; }

		public int post_event_page { get; set; }

		public int post_event_host_shares_page { get; set; }

		public bool has_seller_offer { get; set; }

		public string picture_url { get; set; }

		public Aggregates aggregates { get; set; }

		public List<Comment> comments { get; set; }

		public List<object> events { get; set; }

		public List<object> event_host_shares { get; set; }

		public List<Like> likes { get; set; }

		public bool caller_has_offered { get; set; }

		public OfferData offer_data { get; set; }

		public string creator_username { get; set; }

		public string creator_display_handle { get; set; }

		public string creator_full_name { get; set; }

		public string creator_picture_url { get; set; }

		public bool caller_has_liked { get; set; }

		public Department department { get; set; }

		public CategoryV2 category_v2 { get; set; }

		public List<CategoryFeature> category_features { get; set; }

		public SizeObj2 size_obj { get; set; }

		public BrandObj brand_obj { get; set; }
	}

	public class Sm
	{
		public string image_name { get; set; }

		public string message { get; set; }

		public string popup_id { get; set; }

		public string popup_template { get; set; }
	}

	public class Sl
	{
		public bool enabled { get; set; }
	}

	public class Presentation
	{
		public List<Sm> sm { get; set; }

		public Sl sl { get; set; }
	}

	public class RootObject
	{
		public Data data { get; set; }

		public Presentation presentation { get; set; }

		public string req_id { get; set; }
	}
}
