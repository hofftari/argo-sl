using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArgoSL.Classes.Interfaces
{
    public interface ISLClient
    {
        string GetAllCampaignTemplates();
        string GetList(string listId);
        string GetListMembers(string listId);
        string GetCampaign(string campaignId);
        string GetAllCampaigns();
        string GetAllLists();
        string EditCampaign(string campaignId, string campaignObject);
        string SetListMemberStatus(string listId, string memberId, string memberObject);
        string SearchForMember(string query);
        string CreateCampaign();
        string CreateList(string listObject);
        string UpsertListMembers(string listId, string memberObject);
        string RemoveListMember(string listId, string memberId);
    }
}
