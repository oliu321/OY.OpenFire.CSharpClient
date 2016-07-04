using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OY.OpenFire.CSharpClient
{
    public class OpenFireRestClient : IOpenFireRestService
    {
        public Entity.UserEntities getUsers()
        {
            throw new NotImplementedException();
        }

        public Entity.UserEntities getUsers(Dictionary<string, string> queryParams)
        {
            throw new NotImplementedException();
        }

        public Entity.UserEntity getUser(string username)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage createUser(Entity.UserEntity userEntity)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage updateUser(Entity.UserEntity userEntity)
        {
            throw new NotImplementedException();
        }

        public Entity.MUCRoomEntities getChatRooms()
        {
            throw new NotImplementedException();
        }

        public Entity.MUCRoomEntities getChatRooms(Dictionary<string, string> queryParams)
        {
            throw new NotImplementedException();
        }

        public Entity.MUCRoomEntity getChatRoom(string roomName)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage createChatRoom(Entity.MUCRoomEntity chatRoom)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage updateChatRoom(Entity.MUCRoomEntity chatRoom)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage deleteChatRoom(string roomName)
        {
            throw new NotImplementedException();
        }

        public Entity.ParticipantEntities getChatRoomParticipants(string roomName)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage addOwner(string roomName, string jid)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage addAdmin(string roomName, string jid)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage addMember(string roomName, string jid)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage addOutcast(string roomName, string jid)
        {
            throw new NotImplementedException();
        }

        public Entity.SessionEntities getSessions()
        {
            throw new NotImplementedException();
        }

        public Entity.SessionEntities getSessions(string username)
        {
            throw new NotImplementedException();
        }

        public Entity.UserGroupsEntity getUserGroups(string username)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage addUserToGroups(string username, Entity.UserGroupsEntity userGroupsEntity)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage addUserToGroup(string username, string groupName)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage deleteUserFromGroup(string username, string groupName)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage lockoutUser(string username)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage unlockUser(string username)
        {
            throw new NotImplementedException();
        }

        public Entity.SystemProperties getSystemProperties()
        {
            throw new NotImplementedException();
        }

        public Entity.SystemProperty getSystemProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage createSystemProperty(Entity.SystemProperty property)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage updateSystemProperty(Entity.SystemProperty property)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage deleteSystemProperty(string propertyName)
        {
            throw new NotImplementedException();
        }

        public Entity.GroupEntities getGroups()
        {
            throw new NotImplementedException();
        }

        public Entity.GroupEntity getGroup(string groupName)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage createGroup(Entity.GroupEntity group)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage updateGroup(Entity.GroupEntity group)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage deleteGroup(string groupName)
        {
            throw new NotImplementedException();
        }

        public Entity.RosterEntities getRoster(string username)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage addRosterEntry(string username, Entity.RosterItemEntity rosterItemEntity)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage updateRosterEntry(string username, Entity.RosterItemEntity rosterItemEntity)
        {
            throw new NotImplementedException();
        }

        public System.Net.Http.HttpResponseMessage deleteRosterEntry(string username, string jid)
        {
            throw new NotImplementedException();
        }
    }
}
