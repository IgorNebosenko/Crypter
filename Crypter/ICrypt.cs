namespace Crypter
{
    public interface ICrypt
    {
        string Path { get; set; }
        string Key { get; set; }
        void Crypt();
    }
}
