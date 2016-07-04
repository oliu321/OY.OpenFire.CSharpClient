namespace OY.OpenFire.CSharpClient.Entity
{

    /**
     * The Class GroupEntity.
     */
    public class GroupEntity
    {

        /** The name. */
        public string Name { get; set; }

        /** The description. */

        public string Description { get; set; }

        /**
         * Instantiates a new group entity.
         */
        public GroupEntity()
        {
        }

        /**
         * Instantiates a new group entity.
         *
         * @param name
         *            the name
         * @param description
         *            the description
         */
        public GroupEntity(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }



    }
}