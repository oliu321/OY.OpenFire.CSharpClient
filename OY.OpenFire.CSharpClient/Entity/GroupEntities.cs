using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{
    public class GroupEntities
    {
        /** The groups. */
        public List<GroupEntity> Groups { get; set; }

        /**
         * Instantiates a new group entities.
         */
        public GroupEntities()
        {
        }

        /**
         * Instantiates a new group entities.
         *
         * @param groups the groups
         */
        public GroupEntities(List<GroupEntity> groups)
        {
            this.Groups = groups;
        }
    }
}