using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DR.DataAccess.Test
{
    [AttributeUsage(PatternAttributeTargets.TestComponent)]
    public class JIRAAttribute : MetadataPatternAttribute
    {
        private List<String> _keys;

        public JIRAAttribute(String key, params String[] keys)
        {
            _keys = new List<String>(keys) { key };
        }

        protected override IEnumerable<KeyValuePair<String, String>> GetMetadata()
        {
            return _keys.Select(key => new KeyValuePair<String, String>(MetadataKeys.JIRA, String.Format("https://jira.wonga.com/browse/{0}", key)));
        }
    }
}
