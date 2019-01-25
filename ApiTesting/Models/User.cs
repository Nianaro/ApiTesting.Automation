using System;
using Newtonsoft.Json;

namespace ApiTesting.Models
{
    public class User
    {
        [JsonProperty("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("html_url")]
        public Uri HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public Uri FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public Uri SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public Uri OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public Uri ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public Uri ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        public bool SiteAdmin { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("blog")]
        public string Blog { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("hireable")]
        public string Hireable { get; set; }

        [JsonProperty("bio")]
        public string Bio { get; set; }

        [JsonProperty("public_repos")]
        public long PublicRepos { get; set; }

        [JsonProperty("public_gists")]
        public long PublicGists { get; set; }

        [JsonProperty("followers")]
        public long Followers { get; set; }

        [JsonProperty("following")]
        public long Following { get; set; }

        [JsonProperty("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        protected bool Equals(User other)
        {
            return string.Equals(Login, other.Login) 
                    && Id == other.Id 
                    && string.Equals(NodeId, other.NodeId) 
                    && Equals(AvatarUrl, other.AvatarUrl) 
                    && string.Equals(GravatarId, other.GravatarId) 
                    && Equals(Url, other.Url) 
                    && Equals(HtmlUrl, other.HtmlUrl) 
                    && Equals(FollowersUrl, other.FollowersUrl) 
                    && string.Equals(FollowingUrl, other.FollowingUrl) 
                    && string.Equals(GistsUrl, other.GistsUrl) 
                    && string.Equals(StarredUrl, other.StarredUrl) 
                    && Equals(SubscriptionsUrl, other.SubscriptionsUrl) 
                    && Equals(OrganizationsUrl, other.OrganizationsUrl) 
                    && Equals(ReposUrl, other.ReposUrl) 
                    && string.Equals(EventsUrl, other.EventsUrl) 
                    && Equals(ReceivedEventsUrl, other.ReceivedEventsUrl) 
                    && string.Equals(Type, other.Type) 
                    && SiteAdmin == other.SiteAdmin 
                    && string.Equals(Name, other.Name) 
                    && string.Equals(Company, other.Company) 
                    && string.Equals(Blog, other.Blog) 
                    && string.Equals(Location, other.Location) 
                    && string.Equals(Email, other.Email)
                    && string.Equals(Hireable, other.Hireable) 
                    && string.Equals(Bio, other.Bio) 
                    && PublicRepos == other.PublicRepos 
                    && PublicGists == other.PublicGists 
                    && Followers == other.Followers 
                    && Following == other.Following 
                    && CreatedAt.Equals(other.CreatedAt) 
                    && UpdatedAt.Equals(other.UpdatedAt);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj.GetType() == this.GetType() && Equals((User)obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = (Login != null ? Login.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ Id.GetHashCode();
                hashCode = (hashCode * 397) ^ (NodeId != null ? NodeId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (AvatarUrl != null ? AvatarUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (GravatarId != null ? GravatarId.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Url != null ? Url.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (HtmlUrl != null ? HtmlUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (FollowersUrl != null ? FollowersUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (FollowingUrl != null ? FollowingUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (GistsUrl != null ? GistsUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (StarredUrl != null ? StarredUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (SubscriptionsUrl != null ? SubscriptionsUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (OrganizationsUrl != null ? OrganizationsUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ReposUrl != null ? ReposUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (EventsUrl != null ? EventsUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (ReceivedEventsUrl != null ? ReceivedEventsUrl.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Type != null ? Type.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ SiteAdmin.GetHashCode();
                hashCode = (hashCode * 397) ^ (Name != null ? Name.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Company != null ? Company.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Blog != null ? Blog.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Location != null ? Location.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Email != null ? Email.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Hireable != null ? Hireable.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ (Bio != null ? Bio.GetHashCode() : 0);
                hashCode = (hashCode * 397) ^ PublicRepos.GetHashCode();
                hashCode = (hashCode * 397) ^ PublicGists.GetHashCode();
                hashCode = (hashCode * 397) ^ Followers.GetHashCode();
                hashCode = (hashCode * 397) ^ Following.GetHashCode();
                hashCode = (hashCode * 397) ^ CreatedAt.GetHashCode();
                hashCode = (hashCode * 397) ^ UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }
}