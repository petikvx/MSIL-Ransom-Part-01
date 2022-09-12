using System;
using InstagramApiSharp.Classes.Models;
using InstagramApiSharp.Classes.ResponseWrappers;

namespace InstagramApiSharp.Converters;

internal class InstaBroadcastCreateConverter : IObjectConverter<InstaBroadcastCreate, InstaBroadcastCreateResponse>
{
	public InstaBroadcastCreateResponse SourceObject { get; set; }

	public InstaBroadcastCreate Convert()
	{
		if (SourceObject == null)
		{
			throw new ArgumentNullException("Source object");
		}
		return new InstaBroadcastCreate
		{
			AllowResolutionChange = SourceObject.AllowResolutionChange,
			AvcRtmpPayload = SourceObject.AvcRtmpPayload,
			BroadcasterUpdateFrequency = SourceObject.BroadcasterUpdateFrequency,
			BroadcastId = SourceObject.BroadcastId,
			ConnectWith1rtt = SourceObject.ConnectWith1rtt,
			DisableSpeedTest = SourceObject.DisableSpeedTest,
			HeartbeatInterval = SourceObject.HeartbeatInterval,
			LiveTraceEnabled = SourceObject.LiveTraceEnabled,
			LiveTraceSampleIntervalInSeconds = SourceObject.LiveTraceSampleIntervalInSeconds,
			LiveTraceSamplingSource = SourceObject.LiveTraceSamplingSource,
			MaxTimeInSeconds = SourceObject.MaxTimeInSeconds,
			PassThruEnabled = SourceObject.PassThruEnabled,
			SpeedTestMinimumBandwidthThreshold = SourceObject.SpeedTestMinimumBandwidthThreshold,
			SpeedTestRetryMaxCount = SourceObject.SpeedTestRetryMaxCount,
			SpeedTestRetryTimeDelay = SourceObject.SpeedTestRetryTimeDelay,
			SpeedTestUiTimeout = SourceObject.SpeedTestUiTimeout,
			StreamAudioBitRate = SourceObject.StreamAudioBitRate,
			StreamAudioChannels = SourceObject.StreamAudioChannels,
			StreamAudioSampleRate = SourceObject.StreamAudioSampleRate,
			StreamNetworkConnectionRetryCount = SourceObject.StreamNetworkConnectionRetryCount,
			StreamNetworkConnectionRetryDelayInSeconds = SourceObject.StreamNetworkConnectionRetryDelayInSeconds,
			StreamNetworkSpeedTestPayloadSizeInBytes = SourceObject.StreamNetworkSpeedTestPayloadSizeInBytes,
			StreamNetworkSpeedTestPayloadTimeoutInSeconds = SourceObject.StreamNetworkSpeedTestPayloadTimeoutInSeconds,
			StreamNnetworkSpeedTestPayloadChunkSizeInBytes = SourceObject.StreamNnetworkSpeedTestPayloadChunkSizeInBytes,
			StreamVideoAdaptiveBitrateConfig = SourceObject.StreamVideoAdaptiveBitrateConfig,
			StreamVideoAllowBFrames = SourceObject.StreamVideoAllowBFrames,
			StreamVideoBitRate = SourceObject.StreamVideoBitRate,
			StreamVideoFps = SourceObject.StreamVideoFps,
			StreamVideoWidth = SourceObject.StreamVideoWidth,
			UploadUrl = SourceObject.UploadUrl
		};
	}
}
