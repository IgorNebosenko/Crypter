namespace Crypter
{
    /// <summary>
    /// Interface of crypt
    /// </summary>
    public interface ICrypt
    {
        /// <summary>
        /// Prperty of path
        /// </summary>
        string Path { get; set; }
        /// <summary>
        /// Property of Key
        /// </summary>
        string Key { get; set; }
        /// <summary>
        /// Method of crypt
        /// </summary>
        void Crypt();
    }
}
