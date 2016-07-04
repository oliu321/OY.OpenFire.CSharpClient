using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{


    /**
     * The Class UserEntities.
     */
    public class UserEntities
    {

        /** The users. */
        public List<UserEntity> Users { get; set; }

        /**
         * Instantiates a new user entities.
         */
        public UserEntities()
        {

        }

        /**
         * Instantiates a new user entities.
         *
         * @param users
         *            the users
         */
        public UserEntities(List<UserEntity> users)
        {
            this.Users = users;
        }

    }
}