using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionatorForms.Models
{
    [DynamoDBTable("Profiles")]
    class Profile
    {
        [DynamoDBHashKey]
        public string userID { get; set; }

        public String imageTags { get; set; }
        public String textTags { get; set; }
        public String placesTags { get; set; }
        public String likeTags { get; set; }
        public String movieLikeTags { get; set; }
    }
}
