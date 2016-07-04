using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{


    /**
     * The Class UserEntity.
     */
    public class UserEntity
    {

        /** The username. */
        public string Username { get; set; }

        /** The name. */
        public string Name { get; set; }

        /** The email. */
        public string Email { get; set; }

        /** The password. */
        public string Password { get; set; }

        /** The properties. */
        public List<UserProperty> Properties { get; set; }

        /**
         * Instantiates a new user entity.
         */
        public UserEntity()
        {

        }

        /**
         * Instantiates a new user entity.
         *
         * @param username            the username
         * @param name            the name
         * @param email            the email
         * @param password the password
         */
        public UserEntity(string username, string name, string email, string password)
        {
            this.Username = username;
            this.Name = name;
            this.Email = email;
            this.Password = password;
        }


    }
}