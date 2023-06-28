namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.PidThresholdsPresets
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public class CreatePidThresholdPreset : Message
	{
		public string ThresholdName { get; set; }

		public PidThresholdPresetData ThresholdPresetData { get; set; }
	}

	public class CreatePidThresholdPresetResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreatePidThresholdPreset Request { get; set; }

		// PresetId not (yet) returned as it is not that straight forward to define which preset is the new one since there is no identifier for it (unique name or so)
		////public string ThresholdID { get; set; }
	}

	public class EditPidThresholdPreset : Message
	{
		public string ThresholdPresetKey { get; set; }

		public PidThresholdPresetData ThresholdPresetData { get; set; }
	}

	public class EditPidThresholdPresetResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditPidThresholdPreset Request { get; set; }

		public string ThresholdPresetKey { get; set; }
	}

	public class DeletePidThresholdPresets : Message
	{
		public IEnumerable<string> ThresholdPresetKeys { get; set; }
	}

	public class DeletePidThresholdPresetsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllThresholdPresetsDeleted { get; set; }

		public string Description { get; set; }

		public DeletePidThresholdPresets Request { get; set; }

		public List<string> DeletedKeys { get; set; }

		public List<string> FoundButNotDeletedKeys { get; set; }

		public List<string> NotFoundKeys { get; set; }
	}
}
