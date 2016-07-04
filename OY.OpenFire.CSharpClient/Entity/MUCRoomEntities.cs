using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{
    public class MUCRoomEntities
    {
        public List<MUCRoomEntity> mucRooms { get; set; }

        public MUCRoomEntities()
        {
        }

        public MUCRoomEntities(List<MUCRoomEntity> mucRooms)
        {
            this.mucRooms = mucRooms;
        }
    }
}