namespace DesignPatterns.Wednesday.Second_Task
{
    public sealed class ConfigurationManager
    {
        private static ConfigurationManager? _instance = null;
        private static readonly object _instanceLock = new object();
        private static Dictionary<string, string> Settings = new Dictionary<string, string>();

        private ConfigurationManager() { }

        public static ConfigurationManager Instance
        {
            get
            {
                lock (_instanceLock)
                {
                    if (_instance == null)
                    {
                        _instance = new ConfigurationManager();
                    }
                    return _instance;
                }
            }
        }

        public string GetSetting(string key)
        {
            key = key.ToLower().Trim();
            if (Settings.ContainsKey(key))
                return Settings[key];
            return "There is no such key in the dictionary";
        }

        public void SetSetting(string key, string value)
        {
            key = key.ToLower().Trim();
            value = value.ToLower().Trim();
            Settings[key] = value;
        }
    }
}
