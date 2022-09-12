using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using InstagramApiSharp.API.Versions;
using InstagramApiSharp.Classes.Android.DeviceInfo;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Enums;
using InstagramApiSharp.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace InstagramApiSharp;

internal static class ExtensionHelper
{
	private static Random Rnd = new Random();

	public static string GenerateUserAgent(this AndroidDevice deviceInfo, InstaApiVersion apiVersion)
	{
		if (deviceInfo == null)
		{
			return "Instagram 44.0.0.9.93 Android (24/7.0; 640dpi; 1440x2560; samsung; SM-G935F; hero2lte; samsungexynos8890; en_US; 107092322)";
		}
		if (deviceInfo.AndroidVer == null)
		{
			deviceInfo.AndroidVer = AndroidVersion.GetRandomAndriodVersion();
		}
		return string.Format("Instagram {6} Android ({7}/{8}; {0}; {1}; {2}; {3}; {4}; {5}; en_US; {9})", deviceInfo.Dpi, deviceInfo.Resolution, deviceInfo.HardwareManufacturer, deviceInfo.DeviceModelIdentifier, deviceInfo.FirmwareBrand, deviceInfo.HardwareModel, apiVersion.AppVersion, deviceInfo.AndroidVer.APILevel, deviceInfo.AndroidVer.VersionNumber, apiVersion.AppApiVersionCode);
	}

	public static string GenerateFacebookUserAgent()
	{
		AndroidDevice randomAndroidDevice = AndroidDeviceGenerator.GetRandomAndroidDevice();
		return $"Mozilla/5.0 (Linux; Android {randomAndroidDevice.AndroidVer.VersionNumber}; {randomAndroidDevice.DeviceModelIdentifier} Build/{randomAndroidDevice.AndroidBoardName + randomAndroidDevice.DeviceModel}; wv) AppleWebKit/537.36 (KHTML, like Gecko) Version/4.0 Chrome/69.0.3497.100 Mobile Safari/537.36";
	}

	public static bool IsEmpty(this string content)
	{
		return string.IsNullOrEmpty(content);
	}

	public static bool IsNotEmpty(this string content)
	{
		return !string.IsNullOrEmpty(content);
	}

	public static string EncodeList(this long[] listOfValues, bool appendQuotation = true)
	{
		return listOfValues.ToList().EncodeList(appendQuotation);
	}

	public static string EncodeList(this string[] listOfValues, bool appendQuotation = true)
	{
		return listOfValues.ToList().EncodeList(appendQuotation);
	}

	public static string EncodeList(this List<long> listOfValues, bool appendQuotation = true)
	{
		if (!appendQuotation)
		{
			return string.Join(",", listOfValues);
		}
		List<string> list = new List<string>();
		foreach (long listOfValue in listOfValues)
		{
			list.Add(listOfValue.Encode());
		}
		return string.Join(",", list);
	}

	public static string EncodeList(this List<string> listOfValues, bool appendQuotation = true)
	{
		if (!appendQuotation)
		{
			return string.Join(",", listOfValues);
		}
		List<string> list = new List<string>();
		foreach (string listOfValue in listOfValues)
		{
			list.Add(listOfValue.Encode());
		}
		return string.Join(",", list);
	}

	public static string Encode(this long content)
	{
		return content.ToString().Encode();
	}

	public static string Encode(this string content)
	{
		return "\"" + content + "\"";
	}

	public static string EncodeRecipients(this long[] recipients)
	{
		return recipients.ToList().EncodeRecipients();
	}

	public static string EncodeRecipients(this List<long> recipients)
	{
		List<string> list = new List<string>();
		foreach (long recipient in recipients)
		{
			list.Add($"[{recipient}]");
		}
		return string.Join(",", list);
	}

	public static string EncodeUri(this string data)
	{
		return WebUtility.UrlEncode(data);
	}

	public static string GetJson(this InstaLocationShort location)
	{
		if (location == null)
		{
			return null;
		}
		return new JObject
		{
			{
				"name",
				location.Address ?? string.Empty
			},
			{
				"address",
				location.ExternalId ?? string.Empty
			},
			{ "lat", location.Lat },
			{ "lng", location.Lng },
			{
				"external_source",
				location.ExternalSource ?? "facebook_places"
			},
			{ "facebook_places_id", location.ExternalId }
		}.ToString(Formatting.None);
	}

	public static InstaTVChannelType GetChannelType(this string type)
	{
		if (string.IsNullOrEmpty(type))
		{
			return InstaTVChannelType.User;
		}
		return type.ToLower() switch
		{
			"popular" => InstaTVChannelType.Popular, 
			"for_you" => InstaTVChannelType.ForYou, 
			"continue_watching" => InstaTVChannelType.ContinueWatching, 
			"chrono_following" => InstaTVChannelType.ChronoFollowing, 
			_ => InstaTVChannelType.User, 
		};
	}

	public static string GetRealChannelType(this InstaTVChannelType type)
	{
		return type switch
		{
			InstaTVChannelType.ChronoFollowing => "chrono_following", 
			InstaTVChannelType.Popular => "popular", 
			InstaTVChannelType.ContinueWatching => "continue_watching", 
			InstaTVChannelType.User => "user", 
			_ => "for_you", 
		};
	}

	public static string GenerateRandomString(this int length)
	{
		return new string((from x in Enumerable.Range(0, length)
			select "abcdefghijklmnopqrstuvwxyz0123456789"[Rnd.Next(0, "abcdefghijklmnopqrstuvwxyz0123456789".Length)]).ToArray());
	}

	public static void PrintInDebug(this object obj)
	{
	}

	public static InstaImageUpload ConvertToImageUpload(this InstaImage instaImage, InstaUserTagUpload[] userTags = null)
	{
		return new InstaImageUpload
		{
			Height = instaImage.Height,
			ImageBytes = instaImage.ImageBytes,
			Uri = instaImage.Uri,
			Width = instaImage.Width,
			UserTags = userTags?.ToList()
		};
	}

	public static JObject ConvertToJson(this InstaStoryPollUpload poll)
	{
		JArray value = new JArray
		{
			new JObject
			{
				{ "text", poll.Answer1 },
				{ "count", 0 },
				{ "font_size", poll.Answer1FontSize }
			},
			new JObject
			{
				{ "text", poll.Answer2 },
				{ "count", 0 },
				{ "font_size", poll.Answer2FontSize }
			}
		};
		return new JObject
		{
			{ "x", poll.X },
			{ "y", poll.Y },
			{ "z", poll.Z },
			{ "width", poll.Width },
			{ "height", poll.Height },
			{ "rotation", poll.Rotation },
			{ "question", poll.Question },
			{ "viewer_vote", 0 },
			{ "viewer_can_vote", true },
			{ "tallies", value },
			{ "is_shared_result", false },
			{ "finished", false },
			{ "is_sticker", poll.IsSticker }
		};
	}

	public static JObject ConvertToJson(this InstaStoryLocationUpload location)
	{
		return new JObject
		{
			{ "x", location.X },
			{ "y", location.Y },
			{ "z", location.Z },
			{ "width", location.Width },
			{ "height", location.Height },
			{ "rotation", location.Rotation },
			{ "location_id", location.LocationId },
			{ "is_sticker", location.IsSticker }
		};
	}

	public static JObject ConvertToJson(this InstaStoryHashtagUpload hashtag)
	{
		return new JObject
		{
			{ "x", hashtag.X },
			{ "y", hashtag.Y },
			{ "z", hashtag.Z },
			{ "width", hashtag.Width },
			{ "height", hashtag.Height },
			{ "rotation", hashtag.Rotation },
			{ "tag_name", hashtag.TagName },
			{ "is_sticker", hashtag.IsSticker }
		};
	}

	public static JObject ConvertToJson(this InstaStorySliderUpload slider)
	{
		return new JObject
		{
			{ "x", slider.X },
			{ "y", slider.Y },
			{ "z", slider.Z },
			{ "width", slider.Width },
			{ "height", slider.Height },
			{ "rotation", slider.Rotation },
			{ "question", slider.Question },
			{ "viewer_can_vote", true },
			{ "viewer_vote", -1.0 },
			{ "slider_vote_average", 0.0 },
			{ "background_color", slider.BackgroundColor },
			{
				"emoji",
				slider.Emoji ?? ""
			},
			{ "text_color", slider.TextColor },
			{ "is_sticker", slider.IsSticker }
		};
	}

	public static JObject ConvertToJson(this InstaMediaStoryUpload mediaStory)
	{
		return new JObject
		{
			{ "x", mediaStory.X },
			{ "y", mediaStory.Y },
			{ "width", mediaStory.Width },
			{ "height", mediaStory.Height },
			{ "rotation", mediaStory.Rotation },
			{ "media_id", mediaStory.MediaPk },
			{ "is_sticker", mediaStory.IsSticker }
		};
	}

	public static JObject ConvertToJson(this InstaStoryMentionUpload storyMention)
	{
		return new JObject
		{
			{ "x", storyMention.X },
			{ "y", storyMention.Y },
			{ "z", storyMention.Z },
			{ "width", storyMention.Width },
			{ "height", storyMention.Height },
			{ "rotation", storyMention.Rotation },
			{ "user_id", storyMention.Pk }
		};
	}

	public static JObject ConvertToJson(this InstaStoryQuestionUpload question)
	{
		return new JObject
		{
			{ "x", question.X },
			{ "y", question.Y },
			{ "z", question.Z },
			{ "width", question.Width },
			{ "height", question.Height },
			{ "rotation", question.Rotation },
			{ "question", question.Question },
			{ "viewer_can_interact", question.ViewerCanInteract },
			{ "profile_pic_url", question.ProfilePicture },
			{ "question_type", question.QuestionType },
			{ "background_color", question.BackgroundColor },
			{ "text_color", question.TextColor },
			{ "is_sticker", question.IsSticker }
		};
	}

	public static JObject ConvertToJson(this InstaStoryCountdownUpload countdown)
	{
		return new JObject
		{
			{ "x", countdown.X },
			{ "y", countdown.Y },
			{ "z", countdown.Z },
			{ "width", countdown.Width },
			{ "height", countdown.Height },
			{ "rotation", countdown.Rotation },
			{ "text", countdown.Text },
			{ "start_background_color", countdown.StartBackgroundColor },
			{ "end_background_color", countdown.EndBackgroundColor },
			{ "digit_color", countdown.DigitColor },
			{ "digit_card_color", countdown.DigitCardColor },
			{
				"end_ts",
				countdown.EndTime.ToUnixTime()
			},
			{ "text_color", countdown.TextColor },
			{ "following_enabled", countdown.FollowingEnabled },
			{ "is_sticker", countdown.IsSticker }
		};
	}
}
