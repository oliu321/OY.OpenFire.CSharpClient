using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{
    public class ParticipantEntities
    {
        List<ParticipantEntity> participants;

        public ParticipantEntities()
        {
        }

        public ParticipantEntities(List<ParticipantEntity> participants)
        {
            this.participants = participants;
        }

        public List<ParticipantEntity> getParticipants()
        {
            return participants;
        }

        public void setParticipants(List<ParticipantEntity> participants)
        {
            this.participants = participants;
        }
    }
}
