namespace Operation.DMC
{
    public enum LimitSwitchEnable : ushort
    {
        PositiveNegativeInhibition = 0,
        PositiveNegativePermission = 1,
        PositiveInhibitionNegativePermission = 2,
        PositivePermissionNegativeInhibition = 3,
    }

    public enum EffectiveLevel : ushort
    {
        PositiveNegativeLowLevel = 0,
        PositiveNegativeHighLevel = 1,
        PositiveLowLevelNegativeHighLevel = 2,
        PositiveHighLevelNegativeLowLevel = 3,
    }

    public enum BrakingMode : ushort
    {
        PositiveNegativeImmediate = 0,
        PositiveNegativeDecelerate = 1,
        PositiveImmediateNegativeDecelerate = 2,
        PositiveDecelerateNegativeImmediate = 3,
    }
}
