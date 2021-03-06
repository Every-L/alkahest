using Alkahest.Core.Data;

namespace Alkahest.Core.Net.Protocol.Packets
{
    public sealed class SSwitchInfoPacket : Packet
    {
        const string Name = "S_SWITCH_INFO";

        public override string OpCode => Name;

        [Packet(Name)]
        internal static Packet Create()
        {
            return new SSwitchInfoPacket();
        }

        [PacketField]
        public SkillId OnSkill { get; set; }

        [PacketField]
        public SkillId OffSkill { get; set; }

        [PacketField]
        public bool Enabled { get; set; }
    }
}
