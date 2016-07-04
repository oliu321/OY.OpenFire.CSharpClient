using System;
using System.Collections.Generic;
namespace OY.OpenFire.CSharpClient.Entity
{
    public class MUCRoomEntity
    {

        public string RoomName { get;set;}
        public string Description { get; set; }
        public string Password { get; set; }
        public string Subject { get; set; }
        public string NaturalName { get; set; }

        public int MaxUsers { get; set; }

        public DateTime CreationDate { get; set; }
        public DateTime ModificationDate { get; set; }

        public bool Persistent { get; set; }
        public bool PublicRoom { get; set; }
        public bool RegistrationEnabled { get; set; }
        public bool CanAnyoneDiscoverJID { get; set; }
        public bool CanOccupantsChangeSubject { get; set; }
        public bool CanOccupantsInvite { get; set; }
        public bool CanChangeNickname { get; set; }
        public bool LogEnabled { get; set; }
        public bool LoginRestrictedToNickname { get; set; }
        public bool MembersOnly { get; set; }
        public bool Moderated { get; set; }

        public List<string> BroadcastPresenceRoles { get; set; }

        public List<string> Owners { get; set; }

        public List<string> Admins { get; set; }

        public List<string> Members { get; set; }

        public List<string> Outcasts { get; set; }

        public MUCRoomEntity()
        {
        }

        public MUCRoomEntity(string roomName, string naturalName, string description)
        {
            this.NaturalName = naturalName;
            this.RoomName = roomName;
            this.Description = description;
        }



    }
}