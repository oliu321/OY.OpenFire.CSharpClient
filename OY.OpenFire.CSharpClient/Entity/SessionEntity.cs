using System;
namespace OY.OpenFire.CSharpClient.Entity
{
    public class SessionEntity
    {
        public string sessionId { get; set; }
        public string username { get; set; }
        public string ressource { get; set; }
        public string node { get; set; }
        public string sessionStatus { get; set; }
        public string presenceStatus { get; set; }
        public int priority { get; set; }
        public string hostAddress { get; set; }
        public string hostName { get; set; }

        public DateTime creationDate { get; set; }
        public DateTime lastActionDate { get; set; }

        public bool secure { get; set; }

        public SessionEntity()
        {
        }
    }
}