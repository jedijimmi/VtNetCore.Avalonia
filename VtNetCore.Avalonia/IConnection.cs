using System;
using Avalonia.Input;

namespace VtNetCore.Avalonia
{
    public class DataReceivedEventArgs : EventArgs, IEquatable<DataReceivedEventArgs>
    {
        public byte[] Data { get; set; }

        public bool Equals(DataReceivedEventArgs other)
        {
            return ReferenceEquals(this, other);
        }
    }

    public interface IConnection
    {
        bool IsConnected { get; }

        event EventHandler<DataReceivedEventArgs> DataReceived;

        event EventHandler<EventArgs> Closed;

        bool Connect();

        void Disconnect();

        void SendData(byte[] data);

        void KeyPressed(Key key, char c, KeyModifiers modifiers);

        void SetTerminalWindowSize(int columns, int rows, int width, int height);
    }
}
