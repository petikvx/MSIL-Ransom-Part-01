using System;
using System.Collections.Generic;

namespace WindowsFormsApplication1;

public class Post
{
	public string id { get; set; }

	public string creator_id { get; set; }

	public DateTime lowest_price_at { get; set; }

	public string category { get; set; }

	public string status { get; set; }

	public DateTime status_changed_at { get; set; }

	public int publish_count { get; set; }

	public string app { get; set; }

	public string app_version { get; set; }

	public Inventory inventory { get; set; }

	public Catalog catalog { get; set; }

	public List<string> colors { get; set; }

	public string catalog_source { get; set; }

	public Tags tags { get; set; }

	public DateTime updated_at { get; set; }

	public List<object> scratch_pictures { get; set; }

	public string title { get; set; }

	public string description { get; set; }

	public PriceAmount price_amount { get; set; }

	public OriginalPriceAmount original_price_amount { get; set; }

	public LowestPriceAmount lowest_price_amount { get; set; }

	public string size { get; set; }

	public string brand { get; set; }

	public string brand_id { get; set; }

	public string condition { get; set; }

	public CoverShot10 cover_shot { get; set; }

	public List<Picture> pictures { get; set; }

	public int brand_update_count { get; set; }

	public string sift_ca_score { get; set; }

	public string sift_decision { get; set; }

	public List<PostRoll> post_rolls { get; set; }

	public int post_like_page { get; set; }

	public int like_count { get; set; }

	public string seller_broadcast_offer_id { get; set; }

	public DateTime seller_broadcast_offer_expires_at { get; set; }

	public SellerBroadcastOfferPriceAmount seller_broadcast_offer_price_amount { get; set; }

	public bool has_offer { get; set; }

	public PreviousLowestPriceAmount previous_lowest_price_amount { get; set; }

	public FirstEventShare first_event_share { get; set; }

	public string inventory_unit_id { get; set; }

	public DateTime created_at { get; set; }

	public string price { get; set; }

	public string original_price { get; set; }

	public string lowest_price { get; set; }

	public string seller_broadcast_offer_price { get; set; }

	public int share_count { get; set; }

	public int comment_count { get; set; }

	public int post_comment_page { get; set; }

	public int post_event_page { get; set; }

	public int post_event_host_shares_page { get; set; }

	public bool has_seller_offer { get; set; }

	public string picture_url { get; set; }

	public Aggregates aggregates { get; set; }

	public List<object> comments { get; set; }

	public List<object> events { get; set; }

	public List<object> likes { get; set; }

	public bool caller_has_offered { get; set; }

	public OfferData offer_data { get; set; }

	public string creator_username { get; set; }

	public string creator_display_handle { get; set; }

	public string creator_full_name { get; set; }

	public string creator_fb_id { get; set; }

	public string creator_picture_url { get; set; }

	public bool caller_has_liked { get; set; }

	public PriceDrop price_drop { get; set; }

	public Department department { get; set; }

	public CategoryV2 category_v2 { get; set; }

	public List<CategoryFeature> category_features { get; set; }

	public SizeObj2 size_obj { get; set; }
}
