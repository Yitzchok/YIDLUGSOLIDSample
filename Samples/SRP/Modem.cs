namespace Samples.SRP
{
    public interface IConnection
    {
        void Dial(string nunmber);
        void Hangup();
    }

    public interface IDataChannel
    {
        void Send(byte[] data);
        byte[] Receive();
    }
}