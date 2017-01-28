using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionatorForms.Models
{
    [DynamoDBTable("Users")]
    class User
    {
        [DynamoDBHashKey]
        public string userID { get; set; }

        public String friendID { get; set; }
        public String friendName { get; set; }
        public String fName { get; set; }
        public String lName { get; set; }
        public String lastLogin { get; set; }
        public String profilePic { get; set; }
        public String achievements { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public int rsvpCount { get; set; }
    }
}
