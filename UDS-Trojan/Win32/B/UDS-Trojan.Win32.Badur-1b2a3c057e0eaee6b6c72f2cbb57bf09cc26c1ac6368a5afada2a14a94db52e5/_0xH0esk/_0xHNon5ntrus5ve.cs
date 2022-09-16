using System;
using System.Collections.Generic;
using System.Reflection;
using _0xH3yoglobins;
using _0xHCa7ella;
using _0xHD2ves;
using _0xHI3dustriously;
using _0xHMoo0ers;
using _0xHOxidasi7;
using _0xHPr44mpting;
using _0xHSigm1te;
using _0xHSnorke7er;
using _0xHWrathe6;

namespace _0xH0esk;

internal sealed class _0xHNon5ntrus5ve
{
	internal readonly _0xHCym8n8s[] _0xHBitte5ed;

	internal readonly string _0xHConcei4er;

	internal readonly _0xHSov8r8ignti8s _0xHInhabi2an2;

	internal readonly _0xHFire0ots _0xHW8bbled = (_0xHFire0ots)(-1);

	internal readonly _0xHK7z7tsky _0xHOrches6ra6e = (_0xHK7z7tsky)(-1);

	internal readonly _0xHParam0t0riz0 _0xHNoncon1umer1;

	public _0xHNon5ntrus5ve(Type dataType, _0xHAlliu0s eventAttrib, List<Type> recursionCheck)
	{
		IEnumerable<PropertyInfo> enumerable = _0xHHy4ercriticisms._0xHMise2ucating(dataType);
		List<_0xHCym8n8s> list = new List<_0xHCym8n8s>();
		foreach (PropertyInfo item in enumerable)
		{
			if (!_0xHHy4ercriticisms._0xHR3j3ct33s(item, typeof(_0xHSi7ex)) && item.CanRead && item.GetIndexParameters().Length == 0)
			{
				MethodInfo methodInfo = _0xHHy4ercriticisms._0xHEquato8s(item);
				if (!(methodInfo == null) && !methodInfo.IsStatic && methodInfo.IsPublic)
				{
					Type propertyType = item.PropertyType;
					_0xHMit1genic _0xHMit1genic = _0xHHy4ercriticisms._0xHR2viv2r(propertyType, recursionCheck);
					_0xHDocume7tatio7 _0xHDocume7tatio = _0xHHy4ercriticisms._0xH4mobarbital<_0xHDocume7tatio7>(item);
					string name = ((_0xHDocume7tatio != null && _0xHDocume7tatio._0xH3obbies != null) ? _0xHDocume7tatio._0xH3obbies : (_0xHHy4ercriticisms._0xHDo7bt(item.Name) ? _0xHMit1genic._0xHSant2ras : item.Name));
					list.Add(new _0xHCym8n8s(name, methodInfo, _0xHMit1genic, _0xHDocume7tatio));
				}
			}
		}
		_0xHBitte5ed = list.ToArray();
		_0xHCym8n8s[] array = _0xHBitte5ed;
		foreach (_0xHCym8n8s _0xHCym8n8s in array)
		{
			_0xHMit1genic _0xHCa8toid = _0xHCym8n8s._0xHCa8toid;
			_0xHW8bbled = (_0xHFire0ots)_0xHHy4ercriticisms._0xHSlidin8((int)_0xHCa8toid._0xHI5te5di5g, (int)_0xHW8bbled);
			_0xHOrches6ra6e = (_0xHK7z7tsky)_0xHHy4ercriticisms._0xHSlidin8((int)_0xHCa8toid._0xHHyp6pneas, (int)_0xHOrches6ra6e);
			_0xHInhabi2an2 |= _0xHCa8toid._0xHCh8mp;
			_0xHNoncon1umer1 |= _0xHCa8toid._0xHParenta0es;
		}
		if (eventAttrib != null)
		{
			_0xHW8bbled = (_0xHFire0ots)_0xHHy4ercriticisms._0xHSlidin8((int)eventAttrib._0xHTrad3t3onal3sm, (int)_0xHW8bbled);
			_0xHOrches6ra6e = (_0xHK7z7tsky)_0xHHy4ercriticisms._0xHSlidin8((int)eventAttrib._0xH1ngarias, (int)_0xHOrches6ra6e);
			_0xHInhabi2an2 |= eventAttrib._0xHDefense4ess;
			_0xHNoncon1umer1 |= eventAttrib._0xHExp1unders;
			_0xHConcei4er = eventAttrib._0xHJ8bbering;
		}
		if (_0xHConcei4er == null)
		{
			_0xHConcei4er = dataType.Name;
		}
	}
}
