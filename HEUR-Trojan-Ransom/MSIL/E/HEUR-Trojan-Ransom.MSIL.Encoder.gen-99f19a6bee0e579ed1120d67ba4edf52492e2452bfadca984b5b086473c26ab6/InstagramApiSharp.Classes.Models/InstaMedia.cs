using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace InstagramApiSharp.Classes.Models;

public class InstaMedia : INotifyPropertyChanged
{
	private int _likecount;

	private string _cmcount;

	private bool _play;

	private bool _hasviewersaved;

	public long TakenAtUnix { get; set; }

	public DateTime TakenAt { get; set; }

	public string Pk { get; set; }

	public string InstaIdentifier { get; set; }

	public DateTime DeviceTimeStamp { get; set; }

	public InstaMediaType MediaType { get; set; }

	public string Code { get; set; }

	public string ClientCacheKey { get; set; }

	public string FilterType { get; set; }

	public List<InstaImage> Images { get; set; } = new List<InstaImage>();


	public List<InstaVideo> Videos { get; set; } = new List<InstaVideo>();


	public int Width { get; set; }

	public string Height { get; set; }

	public InstaUser User { get; set; }

	public string TrackingToken { get; set; }

	public int LikesCount
	{
		get
		{
			return _likecount;
		}
		set
		{
			_likecount = value;
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("LikesCount"));
		}
	}

	public string NextMaxId { get; set; }

	public InstaCaption Caption { get; set; }

	public string CommentsCount
	{
		get
		{
			return _cmcount;
		}
		set
		{
			_cmcount = value;
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("CommentsCount"));
		}
	}

	public bool IsCommentsDisabled { get; set; }

	public bool PhotoOfYou { get; set; }

	private bool _hasliked { get; set; }

	public bool HasLiked
	{
		get
		{
			return _hasliked;
		}
		set
		{
			_hasliked = value;
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HasLiked"));
		}
	}

	public List<InstaUserTag> UserTags { get; set; } = new List<InstaUserTag>();


	public InstaUserShortList Likers { get; set; } = new InstaUserShortList();


	public InstaCarousel Carousel { get; set; }

	public int ViewCount { get; set; }

	public bool HasAudio { get; set; }

	public bool IsMultiPost => Carousel != null;

	public List<InstaComment> PreviewComments { get; set; } = new List<InstaComment>();


	public InstaLocation Location { get; set; }

	public bool Play
	{
		get
		{
			return _play;
		}
		set
		{
			_play = value;
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Play"));
		}
	}

	public bool CommentLikesEnabled { get; set; }

	public bool CommentThreadingEnabled { get; set; }

	public bool HasMoreComments { get; set; }

	public int MaxNumVisiblePreviewComments { get; set; }

	public bool CanViewMorePreviewComments { get; set; }

	public bool CanViewerReshare { get; set; }

	public bool CaptionIsEdited { get; set; }

	public bool CanViewerSave { get; set; }

	public bool HasViewerSaved
	{
		get
		{
			return _hasviewersaved;
		}
		set
		{
			_hasviewersaved = value;
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HasViewerSaved"));
		}
	}

	public string Title { get; set; }

	public string ProductType { get; set; }

	public bool NearlyCompleteCopyrightMatch { get; set; }

	public int NumberOfQualities { get; set; }

	public double VideoDuration { get; set; }

	public List<InstaProductTag> ProductTags { get; set; } = new List<InstaProductTag>();


	public bool DirectReplyToAuthorEnabled { get; set; }

	public event PropertyChangedEventHandler PropertyChanged;
}
