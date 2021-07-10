namespace Fork2Model.Enums
{
    public enum ErrorMessage
    {
        // Unexpected Error happened
        UNKNOWN_ERROR,
        // User is missing required permissions
        MISSING_PERMISSION,
        // No token was provided
        MISSING_TOKEN,
        // Unknown package received
        UNKNOWN_PACKAGE,
        // Invalid Token provided
        INVALID_TOKEN,
    }
}