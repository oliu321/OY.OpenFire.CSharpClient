using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OY.OpenFire.CSharpClient.Entity;
using System.Net.Http;

namespace OY.OpenFire.CSharpClient
{
    public interface IOpenFireRestService
    {
        UserEntities getUsers();
        UserEntities getUsers(Dictionary<string, string> queryParams);
        UserEntity getUser(String username);
        HttpResponseMessage  createUser(UserEntity userEntity);
        HttpResponseMessage  updateUser(UserEntity userEntity);
        MUCRoomEntities getChatRooms();
        MUCRoomEntities getChatRooms(Dictionary<String, String> queryParams);
        MUCRoomEntity getChatRoom(String roomName);
        HttpResponseMessage  createChatRoom(MUCRoomEntity chatRoom);
        HttpResponseMessage  updateChatRoom(MUCRoomEntity chatRoom);
        HttpResponseMessage  deleteChatRoom(String roomName);
        ParticipantEntities getChatRoomParticipants(String roomName);
        HttpResponseMessage  addOwner(String roomName, String jid);
        HttpResponseMessage  addAdmin(String roomName, String jid);
        HttpResponseMessage  addMember(String roomName, String jid);
        HttpResponseMessage  addOutcast(String roomName, String jid);
        SessionEntities getSessions();
        SessionEntities getSessions(String username);
        UserGroupsEntity getUserGroups(String username);
        HttpResponseMessage  addUserToGroups(String username, UserGroupsEntity userGroupsEntity);
        HttpResponseMessage  addUserToGroup(String username, String groupName);
        HttpResponseMessage  deleteUserFromGroup(String username, String groupName);
        HttpResponseMessage  lockoutUser(String username);
        HttpResponseMessage  unlockUser(String username);
        SystemProperties getSystemProperties();
        SystemProperty getSystemProperty(String propertyName);
        HttpResponseMessage  createSystemProperty(SystemProperty property);
        HttpResponseMessage  updateSystemProperty(SystemProperty property);
        HttpResponseMessage  deleteSystemProperty(String propertyName);
        GroupEntities getGroups();
        GroupEntity getGroup(String groupName);
        HttpResponseMessage  createGroup(GroupEntity group);
        HttpResponseMessage  updateGroup(GroupEntity group);
        HttpResponseMessage  deleteGroup(String groupName);
        RosterEntities getRoster(String username);
        HttpResponseMessage  addRosterEntry(String username, RosterItemEntity rosterItemEntity);
        HttpResponseMessage  updateRosterEntry(String username, RosterItemEntity rosterItemEntity);
        HttpResponseMessage  deleteRosterEntry(String username, String jid);
    }
}
