namespace OY.OpenFire.CSharpClient.Entity
{
    /**
     * The Class UserProperty.
     */
    public class UserProperty
    {

        /** The key. */
        public string Key { get; set; }

        /** The value. */
        public string Value { get; set; }

        /**
         * Instantiates a new user property.
         */
        public UserProperty()
        {

        }

        /**
         * Instantiates a new user property.
         *
         * @param key
         *            the key
         * @param value
         *            the value
         */
        public UserProperty(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}