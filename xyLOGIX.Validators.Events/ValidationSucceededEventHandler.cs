namespace xyLOGIX.Validators.Events
{
    /// <summary> Represents a handler for a ValidationSucceeded event. </summary>
    /// <param name="sender">
    /// Reference to the instance of the object that raised the
    /// event.
    /// </param>
    /// <param name="e">
    /// A
    /// <see cref="T:xyLOGIX.Validators.Events.ValidationSucceededEventArgs" /> that
    /// contains the event data.
    /// </param>
    /// <remarks>
    /// This delegate merely specifies the signature of all methods that
    /// handle the ValidationSucceeded event.
    /// </remarks>
    public delegate void ValidationSucceededEventHandler(
        object sender,
        ValidationSucceededEventArgs e
    );
}