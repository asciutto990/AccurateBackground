namespace AccurateBackground.Enums
{
    /// <summary>
    /// PKG_BASIC (Criminal History (National)) includes checks of the National Criminal Database Search, One Name Submission.
    /// PKG_STANDARD (Criminal and Address Check (National and Local)) Includes National and County criminal history, Global terror watchlist.
    /// PKG_PRO (7-year Criminal History and Address Check) SSN address trace, National Criminal search, and seven-year historical check at county criminal level.
    /// PKG_EMPTY (An empty package) You can add searches to build a custom package
    /// </summary>
    public enum PackageType
    {
        PKG_BASIC,
        PKG_STANDARD,
        PKG_PRO,
        PKG_EMPTY
    }
}