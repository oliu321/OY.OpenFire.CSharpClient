
namespace OY.OpenFire.CSharpClient.Entity
{
    /**
     * The Class AuthenticationToken.
     */
    public class AuthenticationToken
    {

        /** The auth mode. */
        public AuthenticationMode AuthMode { get; set; }

        /** The username. */
        public string Username { get; set; }

        /** The password. */
        public string Password { get; set; }

        /** The shared secret key. */
        public string SharedSecretKey { get; set; }

        /**
         * Instantiates a new authentication token.
         *
         * @param username
         *            the username
         * @param password
         *            the password
         */
        public AuthenticationToken(string username, string password)
        {
            this.AuthMode = AuthenticationMode.BASIC_AUTH;
            this.Username = username;
            this.Password = password;
        }

        /**
         * Instantiates a new authentication token.
         *
         * @param sharedSecretKey
         *            the shared secret key
         */
        public AuthenticationToken(string sharedSecretKey)
        {
            this.AuthMode = AuthenticationMode.SHARED_SECRET_KEY;
            this.SharedSecretKey = sharedSecretKey;
        }
    }
}