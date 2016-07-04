namespace OY.OpenFire.CSharpClient.Entity
{

    /**
     * The Class SystemProperty.
     */
    public class SystemProperty
    {

        /** The key. */
        public string Key;

        /** The value. */
        public string Value;

        /**
         * Instantiates a new system property.
         */
        public SystemProperty()
        {

        }

        /**
         * Instantiates a new system property.
         *
         * @param key the key
         * @param value the value
         */
        public SystemProperty(string key, string value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}