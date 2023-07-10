namespace Skyline.DataMiner.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.PidThresholdsPresets
{
	public enum PresetType
	{
		/*Name = -2,*/
		PID = -1,
		MPEG2Video = 0,
		MPEG4Video = 1,
		HEVCVideo = 2,
		MPEG1Audio = 3,
		MPEG4Audio = 4,
		AC3Audio = 5,
		AACAudio = 6,
		AACLATMAudio = 7,
		SMPTEPCMAudio = 8,
		Subtitling = 9,
		Teletext = 10,
		PrivateData = 11,
		EISS = 12,
		EBIF = 13,
		DSM_CC = 14,
		SCTE35 = 15,
		UnknownComponent = 16,
		PCR = 17,
		PAT = 18,
		PMT = 19,
		CAT = 20,
		SDT_BAT = 21,
		NIT = 22,
		EIT = 23,
		RST = 24,
		TDT_TOT = 25,
		MIP = 26,
		ECM = 27,
		EMM = 28,
		ATSCBASE = 29,
		ATSCEIT = 30,
		ATSCRRT = 31,
		ATSCETT = 32,
		NullPID = 33,
		LTC = 34,
		JPEG2000Video = 35,
		UncompressedVideo = 36,
		AIT = 37,
	}

	public enum Scrambling
	{
		Ignore = -10,
		RequireScrambling = 1,
		RequireNoScrambling = 2,
	}
}
