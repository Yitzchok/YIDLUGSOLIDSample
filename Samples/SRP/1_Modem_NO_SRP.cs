namespace Samples.SRP
{
    public interface IModem
    {
        void Dial(string nunmber);
        void Hangup();
        void Send(byte[] data);
        byte[] Receive();
    }
}