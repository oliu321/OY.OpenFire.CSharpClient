using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{


    /**
     * The Class UserGroupsEntity.
     */
    public class UserGroupsEntity
    {

        /** The group names. */
        public List<string> GroupNames { get; set; }

        /**
         * Instantiates a new user groups entity.
         */
        public UserGroupsEntity()
        {

        }

        /**
         * Instantiates a new user groups entity.
         *
         * @param groupNames
         *            the group names
         */
        public UserGroupsEntity(List<string> groupNames)
        {
            this.GroupNames = groupNames;
        }


    }
}