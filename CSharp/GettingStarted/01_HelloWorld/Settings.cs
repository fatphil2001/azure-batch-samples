namespace Microsoft.Azure.Batch.Samples.HelloWorld
{
    using System.Text;
    using Common;

    public partial class Settings
    {
        public string PoolId { get; set; }
        public int PoolTargetLowPriorityNodeCount { get; set; }
        public int PoolTargetDedicatedNodeCount { get; set; }
        public string PoolOSFamily { get; set; }
        public string PoolNodeVirtualMachineSize { get; set; }
        public bool ShouldDeleteJob { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            SampleHelpers.AddSetting(stringBuilder, "PoolId", this.PoolId);
            SampleHelpers.AddSetting(stringBuilder, "PoolTargetLowPriorityNodeCount", this.PoolTargetLowPriorityNodeCount);
            SampleHelpers.AddSetting(stringBuilder, "PoolTargetDedicatedNodeCount", this.PoolTargetDedicatedNodeCount);
            SampleHelpers.AddSetting(stringBuilder, "PoolOSFamily", this.PoolOSFamily);
            SampleHelpers.AddSetting(stringBuilder, "PoolNodeVirtualMachineSize", this.PoolNodeVirtualMachineSize);
            SampleHelpers.AddSetting(stringBuilder, "ShouldDeleteJob", this.ShouldDeleteJob);

            return stringBuilder.ToString();
        }
    }
}
