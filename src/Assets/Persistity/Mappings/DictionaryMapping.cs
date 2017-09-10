using System;
using System.Collections;
using System.Collections.Generic;

namespace Persistity.Mappings
{
    public class DictionaryMapping : Mapping
    {
        public Type KeyType { get; set; }
        public Type ValueType { get; set; }
        public Func<object, IDictionary> GetValue { get; set; }
        public Action<object, object> SetValue { get; set; }
        public IList<Mapping> KeyMappings { get; private set; }
        public IList<Mapping> ValueMappings { get; private set; }
        public bool IsKeyDynamicType { get; set; }
        public bool IsValueDynamicType { get; set; }

        public DictionaryMapping()
        {
            KeyMappings = new List<Mapping>();
            ValueMappings = new List<Mapping>();
        }
    }
}