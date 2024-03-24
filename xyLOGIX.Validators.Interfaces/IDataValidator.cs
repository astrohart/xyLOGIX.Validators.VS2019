using PostSharp.Patterns.Threading;

namespace xyLOGIX.Validators.Interfaces
{
    /// <summary>
    /// Defines the publicly-exposed methods and properties that are in common to all
    /// data validators.
    /// </summary>
    [Synchronized]
    public interface IDataValidator
    {
        // TODO: Add events, methods, and properties to your interface here.
    }
}