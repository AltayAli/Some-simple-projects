using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkGenerator
{
    class CheckGenerator
    {
        static Dictionary<string, int> _generatenum;
        private Queue<string> _checks;

        public CheckGenerator()
        {
            _generatenum = new Dictionary<string, int>();
            _checks = new Queue<string>();
        }
        public string ApplyCheck(string key)
        {
            if (_generatenum.ContainsKey(key))
            {
                int num =_generatenum[key];
                num++;
                _generatenum[key] = num;
            }else
            {
                _generatenum.Add(key, 1);
            }
            string myCheck = $"{key}{_generatenum[key]}";
            _checks.Enqueue(myCheck);
            return myCheck;
        }
        public string GetCheck()
        {
            if (_checks.Count > 0)
            {
                return _checks.Dequeue();
            }
            return null;
        }
    }
}
