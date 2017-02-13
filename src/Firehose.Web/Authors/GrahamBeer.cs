public class GrahamBeer : IAmACommunityMember
    {
        public string FirstName => "Graham";
        public string LastName => "Beer";
        public string ShortBioOrTagLine => "System Engineer";
        public string StateOrRegion => "UK";
        public string EmailAddress => "Graham.Beer@outlook.com";
        public string TwitterHandle => "Gbeer7";
        public string GravatarHash => "27d2592f62f63479cac9314da41f9af1";
        public string GitHubHandle => "Gbeer7";
        public GeoPosition Position => new GeoPosition(47.643417, -122.126083);

        public Uri WebSite => new Uri("https://graham-beer.github.io/#blog");
        public IEnumerable<Uri> FeedUris { get { yield return new Uri("https://graham-beer.github.io/feed.xml"); } }
    }