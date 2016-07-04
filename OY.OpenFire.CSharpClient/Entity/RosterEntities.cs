using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{
    public class RosterEntities
    {
        /** The roster. */
        public List<RosterItemEntity> Roster { get; set; }

        /**
         * Instantiates a new roster entities.
         */
        public RosterEntities()
        {

        }

        /**
         * Instantiates a new roster entities.
         *
         * @param roster
         *            the roster
         */
        public RosterEntities(List<RosterItemEntity> roster)
        {
            this.Roster = roster;
        }
    }
}