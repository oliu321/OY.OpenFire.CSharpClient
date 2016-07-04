using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{
    /**
     * The Class RosterItemEntity.
     */
    public class RosterItemEntity
    {

        /** The jid. */
        public string Jid { get; set; }

        /** The nickname. */
        public string Nickname { get; set; }

        /** The subscription type. */
        public int SubscriptionType { get; set; }

        /** The groups. */
        public List<string> Groups { get; set; }

        /**
         * Instantiates a new roster item entity.
         */
        public RosterItemEntity()
        {

        }

        /**
         * Instantiates a new roster item entity.
         *
         * @param jid
         *            the jid
         * @param nickname
         *            the nickname
         * @param subscriptionType
         *            the subscription type
         */
        public RosterItemEntity(string jid, string nickname, int subscriptionType)
        {
            this.Jid = jid;
            this.Nickname = nickname;
            this.SubscriptionType = subscriptionType;
        }
    }
}