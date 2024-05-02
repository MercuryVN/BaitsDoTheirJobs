namespace BaitsDoTheirJobs;

public sealed class ModConfig
{
    public bool MagnetBaitEnabled { get; set; } = true;
    public bool ForceTreasure { get; set; } = false;
    public bool WildBaitEnabled { get; set; } = true;
    public bool ForceDoubleFish { get; set; } = false;
    public bool TargetedBaitEnabled { get; set; } = true;
    public bool ForceTargetedFish { get; set; } = false;
}