using PostSharp.Patterns.Diagnostics;
namespace xyLOGIX.Validators.Events
{
    /// <summary> Represents a handler for a ValidationFailed event. </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Validators.Events.ValidationFailedEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that
    /// handle the ValidationFailed event.
    /// </remarks>
    public delegate void ValidationFailedEventHandler(
        [NotLogged] object sender,
        [NotLogged] ValidationFailedEventArgs e
    );
}