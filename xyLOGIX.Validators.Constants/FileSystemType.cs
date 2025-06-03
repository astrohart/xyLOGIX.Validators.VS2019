namespace xyLOGIX.Validators.Constants
{
    /// <summary>
    /// Value(s) that indicate the type of file system that is present (e.g., NTFS,
    /// FAT32, etc.).
    /// </summary>
    public enum FileSystemType
    {
        /// <summary>
        /// A file system that is formatted using the <c>FAT32</c> or other legacy file
        /// system format.
        /// </summary>
        Legacy,

        /// <summary>
        /// A file system that is formatted using the <c>NTFS</c> file system format.
        /// </summary>
        NTFS,

        /// <summary>
        /// Unknown file system type.
        /// </summary>
        Unknown = -1
    }
}