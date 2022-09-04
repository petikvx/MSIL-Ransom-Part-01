namespace ns1;

public class ID3V1
{
	public enum ID3Version
	{
		ID3V10 = 10,
		ID3V11
	}

	private bool mTagAvailable;

	private ID3Version mTagVersion;

	private string mArtist;

	private string mTitle;

	private string mAlbum;

	private string mYear;

	private string mComment;

	private byte mGenre;

	private string mGenreName;

	private byte mTrack;

	public bool TagAvailable
	{
		get
		{
			return mTagAvailable;
		}
		set
		{
			mTagAvailable = value;
		}
	}

	public ID3Version TagVersion
	{
		get
		{
			return mTagVersion;
		}
		set
		{
			mTagVersion = value;
		}
	}

	public string Artist
	{
		get
		{
			return mArtist;
		}
		set
		{
			mArtist = value;
		}
	}

	public string Title
	{
		get
		{
			return mTitle;
		}
		set
		{
			mTitle = value;
		}
	}

	public string Album
	{
		get
		{
			return mAlbum;
		}
		set
		{
			mAlbum = value;
		}
	}

	public string Year
	{
		get
		{
			return mYear;
		}
		set
		{
			mYear = value;
		}
	}

	public string Comment
	{
		get
		{
			return mComment;
		}
		set
		{
			mComment = value;
		}
	}

	public byte Genre
	{
		get
		{
			return mGenre;
		}
		set
		{
			mGenre = value;
			mGenreName = GetGenreName(value);
		}
	}

	public string GenreName => mGenreName;

	public byte Track
	{
		get
		{
			return mTrack;
		}
		set
		{
			mTrack = value;
		}
	}

	public string GetGenreName(byte Number)
	{
		string[] array = new string[147]
		{
			"Blues", "Classic Rock", "Country", "Dance", "Disco", "Funk", "Grunge", "Hip - Hop", "Jazz", "Metal",
			"New Age", "Oldies", "Other", "Pop", "R&B", "Rap", "Reggae", "Rock", "Techno", "Industrial",
			"Alternative", "Ska", "Death Metal", "Pranks", "Soundtrack", "Euro -Techno", "Ambient", "Trip -Hop", "Vocal", "Jazz Funk",
			"Fusion", "Trance", "Classical", "Instrumental", "Acid", "House", "Game", "Sound Clip", "Gospel", "Noise",
			"AlternRock", "Bass", "Soul", "Punk", "Space", "Meditative", "Instrumental Pop", "Instrumental Rock", "Ethnic", "Gothic",
			"Darkwave", "Techno -Industrial", "Electronic", "Pop -Folk", "Eurodance", "Dream", "Southern Rock", "Comedy", "Cult", "Gangsta",
			"Top 40", "Christian Rap", "Pop/Funk", "Jungle", "Native American", "Cabaret", "New Wave", "Psychadelic", "Rave", "Showtunes",
			"Trailer", "Lo - Fi", "Tribal", "Acid Punk", "Acid Jazz", "Polka", "Retro", "Musical", "Rock & Roll", "Hard Rock",
			"Folk", "Folk/Rock", "National Folk", "Swing", "Bebob", "Latin", "Revival", "Celtic", "Bluegrass", "Avantgarde",
			"Gothic Rock", "Progressive Rock", "Psychedelic Rock", "Symphonic Rock", "Slow Rock", "Big Band", "Chorus", "Easy Listening", "Acoustic", "Humour",
			"Speech", "Chanson", "Opera", "Chamber Music", "Sonata", "Symphony", "Booty Bass", "Primus", "Porn Groove", "Satire",
			"Slow Jam", "Club", "Tango", "Samba", "Folklore", "Ballad", "Power Ballad", "Rhythmic Soul", "Freestyle", "Duet",
			"Punk Rock", "Drum Solo", "A Cappella", "Euro - House", "Dance Hall", "Goa", "Drum & Bass", "Club - House", "Hardcore", "Terror",
			"Indie", "BritPop", "Negerpunk", "Polsk Punk", "Beat", "Christian Gangsta Rap", "Heavy Metal", "Black Metal", "Crossover", "Contemporary Christian",
			"Christian Rock", "Merengue", "Salsa", "Thrash Metal", "Anime", "JPop", "Synthpop"
		};
		return array[Number];
	}
}
