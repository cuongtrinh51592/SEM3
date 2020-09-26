using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Session04.Models;

namespace Session04.DAL
{
    public class ClubMemberDbManagement
    {
        public Member CreateMember(Member memberModel)
        {
            using (var dbEntities = new GoldClubContext())
            {
                var MemberObj = new Member()
                {
                    //ID is auto generated
                    Name = memberModel.Name,
                    Gender = memberModel.Gender,
                    MemberFee = memberModel.MemberFee
                };
                dbEntities.Members.Add(MemberObj);
                dbEntities.SaveChanges();
            }
            return memberModel;
        }
    }
}