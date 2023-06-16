namespace Skyline.DataMiner.Utils.ConnectorAPI.BridgeTechnologies.VBProbeSeries.AlarmThresholds.PidThresholdsPresets
{
	using System.Collections.Generic;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public class CreateSubPidThreshold : Message
	{
		public PidThresholdPresetData ThresholdPresetData { get; set; }
	}

	public class CreateSubPidThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsCreated { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public CreateSubPidThreshold Request { get; set; }

		// PresetId not (yet) returned as it is not that straight forward to define which preset is the new one since there is no identifier for it (unique name or so)
		////public string ThresholdID { get; set; }
	}

	public class EditSubPidThreshold : Message
	{
		public string ThresholdPresetKey { get; set; }

		public PidThresholdPresetData ThresholdPresetData { get; set; }
	}

	public class EditSubPidThresholdResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool IsEdited { get; set; }

		public bool IsFullMatch { get; set; }

		public string Description { get; set; }

		public EditSubPidThreshold Request { get; set; }

		public string ThresholdId { get; set; }
	}

	public class DeleteSubPidThresholds : Message
	{
		public string PresetName { get; set; }

		public IEnumerable<PidThresholdPresetData> PresetsToDelete { get; set; }
	}

	public class DeleteSubPidThresholdsResult : Message
	{
		public bool IsRequestValid { get; set; }

		public bool AreAllThresholdPresetsDeleted { get; set; }

		public string Description { get; set; }

		public DeleteSubPidThresholds Request { get; set; }
	}
}
