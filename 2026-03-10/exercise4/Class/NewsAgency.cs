class NewsAgency
{
    private static readonly Lazy<NewsAgency> _instance = new (() => new NewsAgency());
    private List<INewsSubscriber> _listSubscriber = [];
    private string _news;

    public static readonly NewsAgency Instance = _instance.Value;
    public string News { get => _news; set { _news = value; Notify(); } }

    private NewsAgency() {}

    public void Attach(INewsSubscriber subscriber){ _listSubscriber.Add(subscriber); }
    public void Detach(INewsSubscriber subscriber){ _listSubscriber.Remove(subscriber); }
    public void Notify() { foreach (var sub in _listSubscriber) { sub.Update(); } }
}