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
		/// <summary>
		/// The key of the threshold preset to edit.
		/// Note that in order to identify the threshold preset to be edited, you have 2 options:
		/// - Either provide the <see cref="ThresholdPresetKey"/>.
		/// - Either provide the <see cref="ThresholdName"/> AND the full <see cref="ThresholdPresetCurrentData"/>.
		/// </summary>
		public string ThresholdPresetKey { get; set; }

		/// <summary>
		/// The name of the threshold to which belongs the threshold preset to edit.
		/// Note that in order to identify the threshold preset to be edited, you have 2 options:
		/// - Either provide the <see cref="ThresholdPresetKey"/>.
		/// - Either provide the <see cref="ThresholdName"/> AND the full <see cref="ThresholdPresetCurrentData"/>.
		/// </summary>
		public string ThresholdName { get; set; }

		/// <summary>
		/// The current data of the threshold preset to edit.
		/// Note that in order to identify the threshold preset to be edited, you have 2 options:
		/// - Either provide the <see cref="ThresholdPresetKey"/>.
		/// - Either provide the <see cref="ThresholdName"/> AND the full <see cref="ThresholdPresetCurrentData"/>.
		/// </summary>
		public PidThresholdPresetData ThresholdPresetCurrentData { get; set; }

		/// <summary>
		/// The new desired data for the threshold preset to edit.
		/// </summary>
		public PidThresholdPresetData ThresholdPresetNewData { get; set; }
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
		/// <summary>
		/// The key of the threshold preset to delete.
		/// Note that in order to identify the threshold preset to be deleted, you have 2 options:
		/// - Either provide the <see cref="ThresholdPresetKey"/>.
		/// - Either provide the <see cref="ThresholdName"/> AND the full <see cref="ThresholdPresetData"/>.
		/// </summary>
		public string ThresholdPresetKey { get; set; }

		/// <summary>
		/// The name of the threshold to which belongs the threshold preset to delete.
		/// Note that in order to identify the threshold preset to be deleted, you have 2 options:
		/// - Either provide the <see cref="ThresholdPresetKey"/>.
		/// - Either provide the <see cref="ThresholdName"/> AND the full <see cref="ThresholdPresetData"/>.
		/// </summary>
		public string ThresholdName { get; set; }

		/// <summary>
		/// The current data of the threshold preset to delete.
		/// Note that in order to identify the threshold preset to be deleted, you have 2 options:
		/// - Either provide the <see cref="ThresholdPresetKey"/>.
		/// - Either provide the <see cref="ThresholdName"/> AND the full <see cref="ThresholdPresetData"/>.
		/// </summary>
		public PidThresholdPresetData ThresholdPresetData { get; set; }
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
