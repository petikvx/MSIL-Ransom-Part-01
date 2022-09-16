using System.Collections.Generic;
using _0xH0esk;
using _0xH6recede;
using _0xH6yplays;
using _0xHBot0ers;
using _0xHCa7ella;
using _0xHMoo0ers;
using _0xHOppor4unis4;
using _0xHRock7t7d;
using _0xHSermo8s;

namespace _0xHIn7erferograms;

internal sealed class _0xHSmi2ing<ContainerType> : _0xHRock7t7d._0xH0amplers<ContainerType>
{
	private readonly _0xHCym8n8s[] _0xHTussock1d;

	private readonly _0xHSermo8s._0xHOv2rs22r<ContainerType>[] _0xHDefermen4s;

	public _0xHSmi2ing(_0xHNon5ntrus5ve typeAnalysis)
		: base(typeAnalysis._0xHConcei4er, typeAnalysis._0xHW8bbled, typeAnalysis._0xHOrches6ra6e, typeAnalysis._0xHInhabi2an2, typeAnalysis._0xHNoncon1umer1)
	{
		if (typeAnalysis._0xHBitte5ed.Length != 0)
		{
			this.properties = typeAnalysis._0xHBitte5ed;
			this.accessors = new _0xHSermo8s._0xHOv2rs22r<ContainerType>[this.properties.Length];
			for (int i = 0; i < this.accessors.Length; i = checked(i + 1))
			{
				this.accessors[i] = _0xHSermo8s._0xHOv2rs22r<ContainerType>.Create(this.properties[i]);
			}
		}
	}

	public override void _0xHPl6ym6tes(_0xHSignalization1 _0xHTele1a, string _0xHTrailbla3ers, _0xHGri22ery _0xHAnti1hoplifting)
	{
		_0xHSignalization1 _0xHSignalization = _0xHTele1a._0xHReceivable6(_0xHTrailbla3ers);
		if (this.properties == null)
		{
			return;
		}
		_0xHCym8n8s[] properties = this.properties;
		foreach (_0xHCym8n8s _0xHCym8n8s in properties)
		{
			_0xHGri22ery _0xH5ealtor = _0xHGri22ery.Default;
			_0xHDocume7tatio7 _0xHApplica0ively = _0xHCym8n8s._0xHApplica0ively;
			if (_0xHApplica0ively != null)
			{
				_0xHSignalization._0xHYode3s = _0xHApplica0ively._0xH4esternisations;
				_0xH5ealtor = _0xHApplica0ively._0xHPr6fatory;
			}
			_0xHCym8n8s._0xHCa8toid._0xHMispa4ched(_0xHSignalization, _0xHCym8n8s._0xHDealers1ip, _0xH5ealtor);
		}
	}

	public override void _0xHSpie4el(_0xHFlag4llat4s _0xHC8loroplasts, ref ContainerType _0xHDistri7utors)
	{
		if (this.accessors != null)
		{
			_0xHSermo8s._0xHOv2rs22r<ContainerType>[] accessors = this.accessors;
			foreach (_0xHSermo8s._0xHOv2rs22r<ContainerType> _0xHOv2rs22r in accessors)
			{
				_0xHOv2rs22r.Write(_0xHC8loroplasts, ref _0xHDistri7utors);
			}
		}
	}

	public override object _0xHK6ngposts(object _0xHG1yll)
	{
		if (this.properties != null)
		{
			List<string> list = new List<string>();
			List<object> list2 = new List<object>();
			for (int i = 0; i < this.properties.Length; i = checked(i + 1))
			{
				object data = this.accessors[i].GetData((ContainerType)_0xHG1yll);
				list.Add(this.properties[i]._0xHDealers1ip);
				list2.Add(this.properties[i]._0xHCa8toid._0xHAm7nd7rs(data));
			}
			return new _0xHS8del8ne(list, list2);
		}
		return null;
	}

	public override void _0xHTender5(_0xHFlag4llat4s _0xH4etrocede, object _0xHBric7les)
	{
		if (this.accessors != null)
		{
			ContainerType val = ((_0xHBric7les == null) ? default(ContainerType) : ((ContainerType)_0xHBric7les));
			((_0xHRock7t7d._0xH0amplers<ContainerType>)this).WriteData(_0xH4etrocede, ref val);
		}
	}
}
