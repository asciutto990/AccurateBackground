namespace AccurateBackground.Enums
{
    /// <summary>
    /// In the EXPRESS workflow, the developer is responsible for providing all the required Candidate information in the Candidate resource.
    /// In the INTERACTIVE workflow, an email to a secure data collection form will be sent to the candidate to record their consent to the background check and all the required information necessary to conduct the checks.
    /// </summary>
    public enum Workflow
    {
        EXPRESS,
        INTERACTIVE
    }
}