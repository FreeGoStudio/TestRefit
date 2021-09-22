using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestRefit.Response
{
    public class UsersResponse
    {
        public string login { get; set; }
        public int? id { get; set; }
        public string node_id { get; set; }
        public string avatar_url { get; set; }
        public string gravatar_id { get; set; }
        public string url { get; set; }
        public string html_url { get; set; }
        public string followers_url { get; set; }
        public string following_url { get; set; }
        public string gists_url { get; set; }
        public string starred_url { get; set; }
        public string subscriptions_url { get; set; }
        public string organizations_url { get; set; }
        public string repos_url { get; set; }
        public string events_url { get; set; }
        public string received_events_url { get; set; }
        public string type { get; set; }
        public bool? site_admin { get; set; }
        public string name { get; set; }
        public string company { get; set; }
        public string blog { get; set; }
        public string location { get; set; }
        public string email { get; set; }
        public string hireable { get; set; }
        public string bio { get; set; }
        public string twitter_username { get; set; }
        public int? public_repos { get; set; }
        public int? public_gists { get; set; }
        public int? followers { get; set; }
        public int? following { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }

    }
    public class SearchResult
    {
        public Breed[] breeds { get; set; }
        public string id { get; set; }
        public string url { get; set; }
        public int width { get; set; }
        public int height { get; set; }
    }

    public class Breed
    {
        public Weight weight { get; set; }
        public string id { get; set; }
        public string name { get; set; }
        public string cfa_url { get; set; }
        public string vetstreet_url { get; set; }
        public string vcahospitals_url { get; set; }
        public string temperament { get; set; }
        public string origin { get; set; }
        public string country_codes { get; set; }
        public string country_code { get; set; }
        public string description { get; set; }
        public string life_span { get; set; }
        public int indoor { get; set; }
        public int lap { get; set; }
        public string alt_names { get; set; }
        public int adaptability { get; set; }
        public int affection_level { get; set; }
        public int child_friendly { get; set; }
        public int dog_friendly { get; set; }
        public int energy_level { get; set; }
        public int grooming { get; set; }
        public int health_issues { get; set; }
        public int intelligence { get; set; }
        public int shedding_level { get; set; }
        public int social_needs { get; set; }
        public int stranger_friendly { get; set; }
        public int vocalisation { get; set; }
        public int experimental { get; set; }
        public int hairless { get; set; }
        public int natural { get; set; }
        public int rare { get; set; }
        public int rex { get; set; }
        public int suppressed_tail { get; set; }
        public int short_legs { get; set; }
        public string wikipedia_url { get; set; }
        public int hypoallergenic { get; set; }
    }

    public class Weight
    {
        public string imperial { get; set; }
        public string metric { get; set; }
    }
}
