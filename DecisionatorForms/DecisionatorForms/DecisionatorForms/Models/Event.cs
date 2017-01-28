using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecisionatorForms.Models
{
    [DynamoDBTable("Events")]
    class Event
    {
        [DynamoDBHashKey]
        public string eventID { get; set; }

        public String hostID { get; set; }
        public String hostName { get; set; }
        public String attendees { get; set; }
        public String rsvpList { get; set; }
        public String topic { get; set; }
        public String dateCreated { get; set; }
        public String category { get; set; }
        public String viewedList { get; set; }
        public double latitude { get; set; }
        public double longitude { get; set; }
        public Boolean isPrivate { get; set; }
    }
}
