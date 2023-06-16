namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.PidThresholdsPresets
{
	public class PidThresholdPresetData
	{
		/// <summary>
		/// The name of the PID Threshold the preset belongs to.
		/// </summary>
		public string ThresholdName { get; set; }

		// Preset
		public PresetType? Type { get; set; }

		/// <summary>
		/// The ID of the PIDs this preset relates to.
		/// </summary>
		public string Pid { get; set; }

		/// <summary>
		/// The description of the PIDs this preset relates to.
		/// </summary>
		////public string PidDescription { get; set; }

		/// <summary>
		/// Allows to enable/disable the PID presence check.
		/// </summary>
		public bool? RequirePresence { get; set; }

		/// <summary>
		/// The required language for this preset.
		/// </summary>
		public string RequiredLanguage { get; set; }

		public Scrambling? MonitorScrambling { get; set; }

		// Min Bit Rate
		public bool? MonitorMinBitrate { get; set; }

		/// <summary>
		/// The min bandwidth allowed for the PID in kbps.
		/// </summary>
		public string MinBitrateValue { get; set; }

		// Max Bit Rate
		public bool? MonitorMaxBitrate { get; set; }

		/// <summary>
		/// The max bandwidth allowed for the PID in kbps.
		/// </summary>
		public string MaxBitrateValue { get; set; }

		/// <summary>
		/// Allows to configure when PCR Errors should be ignored via schedule name.
		/// </summary>
		public string IgnorePcrErrorsSchedule { get; set; }

		// Ignore
		/// <summary>
		/// Allows to configure when CC Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreCcErrors { get; set; }

		/// <summary>
		/// Allows to configure when Missing Pid Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreMissingPidAlarm { get; set; }

		/// <summary>
		/// Allows to configure when Unreferenced Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreUnreferencedPidAlarm { get; set; }

		/// <summary>
		/// Allows to configure when All Errors should be ignored via schedule name.
		/// </summary>
		public string IgnoreAll { get; set; }
	}
}
