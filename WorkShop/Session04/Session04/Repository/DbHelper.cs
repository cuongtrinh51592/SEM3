using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Session04.DAL;
using Session04.Models;

namespace Session04.Repository
{
    public class DbHelper
    {
        public Member PostMemberDetails(Member memberModel)
        {
            ClubMemberDbManagement dbInstance = new ClubMemberDbManagement();
            return dbInstance.CreateMember(memberModel);
        }
    }
}