namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class SHitComboPacket : Packet
    {
        const string Name = "S_HIT_COMBO";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new SHitComboPacket();
        }

        [PacketField]
        public uint Hits { get; set; }
    }
}
