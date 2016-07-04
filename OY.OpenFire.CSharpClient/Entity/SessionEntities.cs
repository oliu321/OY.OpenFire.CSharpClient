using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{

    public class SessionEntities
    {
        public List<SessionEntity> Sessions { get; set; }

        public SessionEntities()
        {
        }

        public SessionEntities(List<SessionEntity> sessions)
        {
            this.Sessions = sessions;
        }
    }
}