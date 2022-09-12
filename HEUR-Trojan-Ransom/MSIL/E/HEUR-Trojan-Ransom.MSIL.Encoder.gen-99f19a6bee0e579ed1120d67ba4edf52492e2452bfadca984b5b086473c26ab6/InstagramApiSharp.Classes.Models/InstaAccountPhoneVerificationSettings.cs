using Newtonsoft.Json;

namespace InstagramApiSharp.Classes.Models;

public class InstaAccountPhoneVerificationSettings
{
	[JsonProperty("max_sms_count")]
	public int MaxSmsCount { get; set; }

	[JsonProperty("resend_sms_delay_sec")]
	public int ResendSmsDelaySec { get; set; }

	[JsonProperty("robocall_after_max_sms")]
	public bool RobocallAfterMaxSms { get; set; }

	[JsonProperty("robocall_count_down_time_sec")]
	public int RobocallCountDownTimeSec { get; set; }
}
