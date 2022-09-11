using System;
using NAudio.Wave;
using SoundPull.SoundCloud;

namespace SoundPull.Tools;

public class SoundCloudPlayer
{
	public enum Loop
	{
		Track,
		Playlist,
		None
	}

	private readonly WaveOutEvent player = new WaveOutEvent();

	private readonly string clientID;

	private SoundCloudTrack track;

	private SoundCloudPlaylist playlist;

	private int playlistTrackPosition;

	public Loop loopType;

	public SoundCloudPlayer(SoundCloudTrack track, string clientID)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		loopType = (Loop)Convert.ToInt32(1.0 + Math.Abs(1.0));
		base._002Ector();
		this.clientID = clientID;
		this.track = track;
		Init(track.stream_url + "?client_id=" + clientID);
		player.add_PlaybackStopped((EventHandler<StoppedEventArgs>)Playback_Stopped);
	}

	public SoundCloudPlayer(SoundCloudPlaylist playlist, string clientID)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		loopType = (Loop)Convert.ToInt32(1.1585290151921035 + Math.Sin(1.0));
		base._002Ector();
		this.clientID = clientID;
		this.playlist = playlist;
		track = playlist.tracks[0];
		Init(track.stream_url + "?client_id=" + clientID);
		player.add_PlaybackStopped((EventHandler<StoppedEventArgs>)Playback_Stopped);
	}

	public void SetTrack(SoundCloudTrack track, bool play)
	{
		if (playlist == null)
		{
			player.Dispose();
			this.track = track;
			Init(track.stream_url + "?client_id=" + clientID);
			if (play)
			{
				player.Play();
			}
		}
	}

	public void SetPlaylist(SoundCloudPlaylist playlist, bool play)
	{
		if (track == null)
		{
			player.Dispose();
			this.playlist = playlist;
			track = playlist.tracks[0];
			Init(track.stream_url + "?client_id=" + clientID);
			if (play)
			{
				player.Play();
			}
		}
	}

	public void SetTrackInPlaylist(int trackIndex)
	{
		if (playlist != null)
		{
			player.Dispose();
			track = playlist.tracks[trackIndex];
			Init(track.stream_url + "?client_id=" + clientID);
		}
	}

	public void SetLoop(Loop loop)
	{
		loopType = loop;
	}

	public void Play()
	{
		player.Play();
	}

	public void Stop()
	{
		player.Stop();
	}

	public void Pause()
	{
		player.Pause();
	}

	public void Next(bool play)
	{
		if (playlist != null)
		{
			if (playlistTrackPosition < playlist.track_count)
			{
				playlistTrackPosition++;
				player.Dispose();
				track = playlist.tracks[playlistTrackPosition];
				Init(track.stream_url + "?client_id=" + clientID);
			}
			else if (playlistTrackPosition >= playlist.track_count)
			{
				playlistTrackPosition = 0;
				player.Dispose();
				track = playlist.tracks[playlistTrackPosition];
				Init(track.stream_url + "?client_id=" + clientID);
			}
			if (play)
			{
				player.Play();
			}
		}
	}

	public void Previous(bool play)
	{
		if (playlist != null)
		{
			if (playlistTrackPosition > 0)
			{
				playlistTrackPosition--;
				player.Dispose();
				track = playlist.tracks[playlistTrackPosition];
				Init(track.stream_url + "?client_id=" + clientID);
			}
			else if (playlistTrackPosition <= 0)
			{
				playlistTrackPosition = playlist.track_count - 1;
				player.Dispose();
				track = playlist.tracks[playlistTrackPosition];
				Init(track.stream_url + "?client_id=" + clientID);
			}
			if (play)
			{
				player.Play();
			}
		}
	}

	public void SetVolume(float volume)
	{
		player.set_Volume(volume);
	}

	public float GetVolume()
	{
		return player.get_Volume();
	}

	public SoundCloudTrack GetPlayingTrack()
	{
		return track;
	}

	public PlaybackState GetState()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return player.get_PlaybackState();
	}

	public string GetCurrentPosition()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)GetState() == 0)
		{
			return "0:00";
		}
		double num = (double)player.GetPosition() * 1000.0 / (double)player.get_OutputWaveFormat().get_BitsPerSample() / (double)player.get_OutputWaveFormat().get_Channels() * 8.0 / (double)player.get_OutputWaveFormat().get_SampleRate();
		int num2 = Convert.ToInt32(num / 1000.0);
		return TimeSpan.FromSeconds(num2).ToString("m\\:ss");
	}

	public string GetCurrentPosition(string format)
	{
		double num = (double)player.GetPosition() * 1000.0 / (double)player.get_OutputWaveFormat().get_BitsPerSample() / (double)player.get_OutputWaveFormat().get_Channels() * 8.0 / (double)player.get_OutputWaveFormat().get_SampleRate();
		int num2 = Convert.ToInt32(num / 1000.0);
		return TimeSpan.FromSeconds(num2).ToString(format);
	}

	public Loop GetLoop()
	{
		return loopType;
	}

	private void Playback_Stopped(object sender, StoppedEventArgs e)
	{
		if (loopType == Loop.Track)
		{
			player.Dispose();
			Init(track.stream_url + "?client_id=" + clientID);
			player.Play();
		}
		else if (loopType == Loop.Playlist && playlist != null)
		{
			Next(play: true);
		}
	}

	private void Init(string url)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Expected O, but got Unknown
		MediaFoundationReader val = new MediaFoundationReader(url);
		try
		{
			player.Init((IWaveProvider)(object)val);
		}
		finally
		{
			((IDisposable)val)?.Dispose();
		}
	}
}
